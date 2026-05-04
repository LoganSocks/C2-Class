using System;
using System.Collections.Generic;
using System.Text;

namespace StudioOrganizer.Classes
{   //This class will be for beats and tell the user the status of the beat
    public class Music_Project : Studio_Item
    {   
    
        //Will hold status like mixing or mastered
        public string Project_Status { get; set; }
        //Will hold the BPM of the beat
        public int BPM { get; set; }
        //hold the key of the beat(The main key as some instruments will be in other keys like the drums are allowed to be in a different key thanm the melodic instrunemnts
        public string Key { get; set; }
        
        
        //Constructor for the music project class
        public Music_Project(string project_name, string project_status, int bpm, string key, DateTime project_created) : base( project_name, project_created)
        {
           
            Project_Status = project_status;
            BPM = bpm;
            Key = key;
            
        }
    }
}
