using StudioOrganizer.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudioOrganizer
{
    public partial class Samples_Form : Form
    {
        public Samples_Form()
        {
            InitializeComponent();
            Update_DGV();
        }
        //This will run everytime the sample fporm is loaded
        private void Samples_Form_Load(object sender, EventArgs e)
        {   //Use the get al projects to get a list of all projects to use for connection
            List<Music_Project> projects = SQL_Actions.GetAllProjects();
            //The data source is the list that is created with the get all projects method
            Project_Select_cb.DataSource = projects;
            //This will be displayed so the user can pick which song the sample is in.... this over the ID because the ID is more for the computers
            Project_Select_cb.DisplayMember = "Name";
            //This is what is grabbed but not displayed to us until a sample is created
            Project_Select_cb.ValueMember = "ID";
        }
        //This will run when the save button is clicked
        private void Save_btn_Click(object sender, EventArgs e)
        {   //Get project ID's to cinnect a sample to a project it is used in
            int Selected_Project_ID = (int)Project_Select_cb.SelectedValue;
            //Create a new sample with the data that the user input in the different boxes
            Sound_Sample New_Sample = new Sound_Sample(Sample_Name_tb.Text, Sample_Type_cb.SelectedItem.ToString(), Key_cb.SelectedItem.ToString(), Selected_Project_ID, DateTime.Now);
            //Call the save sample from the SQL actions class
            SQL_Actions.Save_Sample(New_Sample);
            //Let the user know the sample was created succeessfully
            MessageBox.Show("Sample Saved and Linked Successfully.");
            //Update the view with the newly saved sample
            Update_DGV();
        }
        //This will update the samples data grid view
        public void Update_DGV()
        {   //Shortcut to the db
            string SqliteDB = "Projects.db";
            //Select query shortcut
            string SqliteSelect = "SELECT * FROM Sample_Tbl";
            //Establish a connection to the databse
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={SqliteDB};Version = 3;"))
            {   //Create a new command with the select query
                using (SQLiteCommand cmd = new SQLiteCommand(SqliteSelect, conn))
                {   //Use the sqlite adapter to make sure the data is displayed correctly
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {   //create a new data table
                        DataTable dt = new DataTable();
                        //Use the adapter to fil the datatabel
                        adapter.Fill(dt);
                        //Use this data source to fill the samplke data grid view
                        Sample_DGV.DataSource = dt;
                    }
                }
            }
        }
        //This method will run whgen the projects button is clicked and will take the user back to the projects page
        private void Projects_btn_Click(object sender, EventArgs e)
        {
            //create a new instance of the projecst form
            Project_Form project_form = new Project_Form();
            //Show the projects form
            project_form.Show();
            //Hide this samples form
            this.Hide();
        }
    }
}
