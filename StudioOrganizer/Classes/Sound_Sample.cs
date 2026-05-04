using System;
using System.Collections.Generic;
using System.Text;

namespace StudioOrganizer.Classes
{   //This will be a class for different audio files like drums and and vocal samples
    public class Sound_Sample : Studio_Item
    {
        //Striung for the name of the instrument in the sample
        public string Instrument {  get; set; }
        //String for the key that sample is in
        public string Key { get; set; }
        
        public int Connected_Project { get; set; }
        //Constrictoir to get values for the samples properties
        public Sound_Sample(string sample_Name, string instrument, string key, int connected_project, DateTime date_added) : base(sample_Name, date_added)
        {
            
            Instrument = instrument;
            Key = key;
            Connected_Project = connected_project;
        }
    }
}
