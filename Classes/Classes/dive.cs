using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Dive 
    {
        public float score;
        public int diverID;
        public string diveGroups;
        public string performer; //inte med i nuvarande UML diagram. La till då dive måste kopplas till en hoppare.

        public Dive()
        {
            score = 0;

        }
    }
}
