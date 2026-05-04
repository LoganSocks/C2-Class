using StudioOrganizer.Classes;
using System.Data;
using System.Data.SQLite;




namespace StudioOrganizer
{
    public partial class Project_Form : Form
    {
        public Project_Form()
        {
            InitializeComponent();
        }

        private void Project_Form_Load(object sender, EventArgs e)
        {   //Call the INitialize method form the SQL Actions class
            SQL_Actions.InitializeDatabase();
            //Update the display for the user everytime the form loads
            Update_DGV();
        }
        private void Save_btn_Click(object sender, EventArgs e)
        {   //Check if the project title text box is blank
            if (string.IsNullOrWhiteSpace(Project_Title_tb.Text))
            {   //Let the user know that the project title cannot be blank
                MessageBox.Show("Project Title Cannot Be Blank.");
                //return the process early
                return;
            }//Create a new object that using the parameters of the Music project class
            Music_Project New_Project = new Music_Project(Project_Title_tb.Text, Status_cb.SelectedItem.ToString(), (int)BPM_num.Value, Key_cb.SelectedItem.ToString(), DateTime.Now);

            try
            {   //Call the save method from the SQLActions classs
                SQL_Actions.SaveProject(New_Project);
                //If it works let the user know the project was successfully saved
                MessageBox.Show("Project Saved!");
                //Clear the title text box
                Project_Title_tb.Clear();
                //reset the status cmbo box
                Status_cb.ResetText();
                //Set the bpm num box to a default value
                BPM_num.Value = 120;
                //Reset the key combo box
                Key_cb.ResetText();
                //Update the display to add the saved project
                Update_DGV();
            }//catch if the save fails
            catch (Exception ex)
            {   //Display a message to the user along with a detailed error messgae
                MessageBox.Show("An Error Occured While Saving. Please Try Again." + ex.Message);
            }
        }
        //This will update the main data grid view with the projects and all of their info
        public void Update_DGV()
        {   //Shortcut to the databse
            string SqliteDB = "Projects.db";
            //Shortcut for the SQL query
            //This query will select a project from the table
            string SqliteSelect = "SELECT * FROM Projects_Tbl";
            //Create a connection to the database
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={SqliteDB};Version = 3;"))
            {   //Create a new SQL command usingf the shortrcut from above
                using (SQLiteCommand cmd = new SQLiteCommand(SqliteSelect, conn))
                {   //The adapter will mak ssure the data is readable and fits into the data grid view
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {   //create a new datatable
                        DataTable dt = new DataTable();
                        //Use the adapter and run the data through the data table
                        adapter.Fill(dt);
                        //fill the dgv with the data to see
                        project_DGV.DataSource = dt;
                    }
                }
            }
        }

        private void Key_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void Samples_btn_Click(object sender, EventArgs e)
        {   //This creates a new instance of the samples form and displays it when the button is clicked
            Samples_Form samples_form = new Samples_Form();
            //Display the sample form
            samples_form.Show();
            //Hide the main form
            this.Hide();
        }

        private void ML_Button_Click(object sender, EventArgs e)
        {
            ML_Form ml_form = new ML_Form();

            ml_form.Show();

            this.Hide();

        }
    }
}
