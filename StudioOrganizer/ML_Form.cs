using StudioOrganizer.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudioOrganizer
{
    public partial class ML_Form : Form
    {
        public ML_Form()
        {
            InitializeComponent();
        }
        //this will trigger when the ml button is cliicked
        private async void ML_Button_Click(object sender, EventArgs e)
        {
            try
            {
              
                //Setup a stpowatch to see how long the ML is taking
                Stopwatch watch = new Stopwatch();
                //Start it
                watch.Start();
                //using the await and task run makes the ML run in the background
                var Results = await Task.Run(() => SQL_Actions.ML_Results());
                //This is for testing if the ML is picking up any projects to sort
                MessageBox.Show($"AI found {Results.Count} projects to analyze.");
                //Stop the stopwatch
                watch.Stop();

                //Display how long the ML took
                MessageBox.Show($"ML Finished in {Results.Count}{watch.ElapsedMilliseconds}ms");
                //Check if no projects are found
                if (Results == null || Results.Count == 0)
                {   //Let the user know none were found
                    MessageBox.Show("No Results Found");
                    //end it
                    return;
                }
                //Set the dgv to null for qa fresh start
                ML_dgv.DataSource = null;
                //I used a binding list bc i couldnt get my regular list to go through and a binding list is better for Dgv's
                var Binding_List = new BindingList<ML_Results_View>(Results);

                //Set the dgv to receuve the binding list
                ML_dgv.DataSource = Binding_List;
                //Uodate the dgv
                ML_dgv.Update();
                //refresh the dgv
                ML_dgv.Refresh();



            }
            catch (Exception ex)
            {   //If it doesnt work display the error to user
                MessageBox.Show("Machine Learning Error: " + ex.Message);
            }
           
        }
        //method to show sample form
        private void Samples_Button_Click(object sender, EventArgs e)
        {   //create new sapmple form
            Samples_Form samples_form = new Samples_Form();
            //show the new sample fomr
            samples_form.Show();
            //hide this fomr
            this.Hide();
        }
        //method for showing projects form
        private void Project_Button_Click(object sender, EventArgs e)
        {   //create new project form
            Project_Form project_form = new Project_Form();
            //Show the project form
            project_form.Show();
            //Hide this form
            this.Hide();
        }
    }
}
