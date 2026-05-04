using System;
using System.Collections.Generic;
using System.Text;

namespace StudioOrganizer.Classes
{
    //This is the base class because evertyhing will need a name, ID, and date it was added
    public class Studio_Item
    {
        //Get and set values for the ID and make it int
        public int ID {  get; set; }
        //Get values for the name of the item added
        public string Name { get; set; }
        //get the date and time something was added
        public DateTime Date_Added { get; set; }
        //this is the construyctor to initialize the class
        public Studio_Item(string name, DateTime date_added)
        {
            Name = name;
            Date_Added = DateTime.Now;
        }
    }
}
