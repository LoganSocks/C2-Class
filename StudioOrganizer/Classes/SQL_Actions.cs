using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;
using Microsoft.ML;
using Microsoft.ML.Data;
using System.Linq;

namespace StudioOrganizer.Classes
{
    //This class will create the tables needed for each form 
    //it will be static so it it not created everytime, instead you can just call it
    public static class SQL_Actions
    {   //This mmethod will create both tables and get everything started
        public static void InitializeDatabase()
        {   //Shortcut to DB
            string SqliteDB = "Projects.db";
            //Check if the file exists
            if (!File.Exists(SqliteDB))
            {   //If the file does not exist create a new one that will be the home of the database
                SQLiteConnection.CreateFile(SqliteDB);
                //Establish a conneciion to the databsee
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={SqliteDB};Version = 3;"))
                {   //Open the connection to the database
                    conn.Open();
                    //This is the creation of the projects table
                    string Create_Projects_Table = @"CREATE TABLE Projects_Tbl(ProjectID INTEGER PRIMARY KEY AUTOINCREMENT, Project_Name TEXT NOT NULL,
                    Project_Status TEXT, BPM INTEGER, Key TEXT, Project_Created TEXT);";
                    //This is the samples tablke with all of the information required for each sample
                    string Create_Sample_Table = @"CREATE TABLE Sample_Tbl(SampleID INTEGER PRIMARY KEY AUTOINCREMENT, Sample_Name TEXT NOT NULL, 
                    Instrument TEXT, Key TEXT, Connected_Project INTEGER, Project_Created TEXT);";
                    //This command will use the connection and create both tables
                    using (SQLiteCommand cmd = new SQLiteCommand(Create_Projects_Table + Create_Sample_Table, conn))
                    {   //This will execute and run everything without ending the app
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
        //This method will save projects to the SQL table
        public static void SaveProject(Music_Project project)
        {   //Shortcut to the db
            string SqliteDB = "Projects.db";
            //Establisha a connection to the databse
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={SqliteDB};Version = 3;"))
            {   //Open the connection
                conn.Open();
                //Showrtcxut for the INSERT query
                string sql_save = "INSERT INTO Projects_Tbl (Project_Name, Project_Status, BPM, Key, Project_Created) VALUES (@title, @status, @bpm, @key, @date)";
                //This command will save the projects and insert them into the SQL table
                using (SQLiteCommand cmd = new SQLiteCommand(sql_save, conn))
                {   //Add the name of the project
                    cmd.Parameters.AddWithValue("@title", project.Name);
                    //Add the comppletion status of the project
                    cmd.Parameters.AddWithValue("@status", project.Project_Status);
                    //add the BPM of the project
                    cmd.Parameters.AddWithValue("@bpm", project.BPM);
                    //Add the key the project is in
                    cmd.Parameters.AddWithValue("@key", project.Key);
                    //Add the date the project was added
                    cmd.Parameters.AddWithValue("@date", project.Date_Added);
                    //This will execute and run everything without ending the app
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //This gets the projects so they can be linked to the samples
        public static List<Music_Project> GetAllProjects()
        {   //Shortcut for the Db
            string SqliteDB = "Projects.db";
            //Create a list that will hold all of the projects
            List<Music_Project> Project_List = new List<Music_Project>();
            //Create a new connection to the databse
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={SqliteDB};Version = 3;"))
            {   //open the connection
                conn.Open();
                //shortcut for the select query
                string Sql_Select = "SELECT * FROM Projects_Tbl";
                //create a new command for the select query
                using (SQLiteCommand cmd = new SQLiteCommand(Sql_Select, conn))
                //Get the sqlite reader
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {   //Lets the sqlite read the databse
                    while (reader.Read())
                    {   //Create the object that ius being added to the list
                        Music_Project p = new Music_Project(reader["Project_Name"]?.ToString()?? "Untitled", reader["Project_Status"]?.ToString()??"Unknown", Convert.ToInt32(reader["BPM"]),
                        reader["Key"]?.ToString()??"Unknown", Convert.ToDateTime(reader["Project_Created"]));
                        //convert the id 
                        p.ID = Convert.ToInt32(reader["ProjectID"]);
                        //Adding the date from the databse so the machine learning doesnt set it to today
                        p.Date_Added = Convert.ToDateTime(reader["Project_Created"]);
                        //add the project to the list
                        Project_List.Add(p);
                    }
                }

            }
            //Return the projects in list form
            return Project_List;
        }
        //This method will save samples after users input the information
        public static void Save_Sample(Sound_Sample sample)
        {   //Shortcut to the db
            string SqliteDB = "Projects.db";
            //Establish a connection
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={SqliteDB};Version = 3;"))
            {   //Open the connection to the databse
                conn.Open();
                //Shortcut for the insert query
                string sql_save = "INSERT INTO Sample_Tbl (Sample_Name, Instrument, Key, Connected_Project, Project_Created) VALUES (@name, @instrument, @key, @connection, @date)";
                //This will use the shortcut above and the connection to add this information to the SQL lite table
                using (SQLiteCommand cmd = new SQLiteCommand(sql_save, conn))
                {   //Add the ample name
                    cmd.Parameters.AddWithValue("@name", sample.Name);
                    //Add the instrument the sample is 
                    cmd.Parameters.AddWithValue("@instrument", sample.Instrument);
                    //Add the key that the saample is in
                    cmd.Parameters.AddWithValue("@key", sample.Key);
                    //Add the project the sample is connected to onto the table
                    cmd.Parameters.AddWithValue("@connection", sample.Connected_Project);
                    //Add the date added to the table
                    cmd.Parameters.AddWithValue("@date", sample.Date_Added);
                    //This will execute and run everything without ending the app
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static List<ML_Results_View> ML_Results()
        {   //Init the ML 
            //ML context is like home base
            var ML_Context = new MLContext();
            //Get the projects
            var Project_Data = GetAllProjects();
            //use the projects to train the ML model
            var Training_Data = Project_Data.Select(p => new ML_Data
            {   //Convert to float to calcuate
                Days_Old = (float)(DateTime.Now - p.Date_Added).TotalDays,
                //sets it so that if it not marked as an idea it will not be picked
                Status = p.Project_Status == "Idea" ? 1f : 0f,
                //If its older than a month it will be marked high priority
                Label = (DateTime.Now - p.Date_Added).TotalDays > 12
            }).ToList();
            //Change the list to a fomrat the ML will use
            var Data_View = ML_Context.Data.LoadFromEnumerable(Training_Data);
            //Sets up the main pipeline for the ML

            var Pipeline = ML_Context.Transforms.Concatenate("Features", "Days_Old", "Status")
                .Append(ML_Context.BinaryClassification.Trainers.SdcaLogisticRegression());
            //Generate the ML model
            var Model = Pipeline.Fit(Data_View);
            //Creates the prediction engine and maps it to the ML_ouput
            var Prediction_Engine = ML_Context.Model.CreatePredictionEngine<ML_Data, ML_Output>(Model);
            //Thiss will loop through each project for the ML to sort
            return Project_Data.Select(p =>
            {   //Gets the ml data
                var Input = new ML_Data
                {   //
                    Days_Old = (float)(DateTime.Now - p.Date_Added).TotalDays,
                    Status = p.Project_Status == "Idea" ? 1f : 0f
                };
                var Prediction = Prediction_Engine.Predict(Input);
                //This is to show differences in the projects status in the ML
                string finalPriority = Prediction.Probability >= 0.5f ? "HIGH" : "Low";
                //This will give the ML results back for the dgv
                return new ML_Results_View
                {
                    Project_Name = p.Name,
                    Days_Old = (int)Input.Days_Old,
                    Priority = Prediction.High_Priority ? "HIGH" : "Low",
                    Confidence = Prediction.Probability
                };
            }).OrderByDescending(x => x.Confidence).ToList();
        }

          
    }
    }


