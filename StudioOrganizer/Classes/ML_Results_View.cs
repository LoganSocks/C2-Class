using System;
using System.Collections.Generic;
using System.Text;

namespace StudioOrganizer.Classes
{
    public class ML_Results_View
    {
        public string Project_Name { get; set; }

        public int Days_Old { get; set; }
        public string Priority { get; set; }

        public float Confidence { get; set; }
    }
}
