using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public class Dive 
    {
        public float score;
        public string competition;  //used to know what competition
        public int nrDive;          //used to track what jump
        public int diveGroups;       // used to rate the jumps score
        public string performer;    //inte med i nuvarande UML diagram. La till då dive måste kopplas till en hoppare.

        public Dive()
        {
        }
        public Dive(string comp, int ID, int diveGroup, string athlete) 
        {
            //creating a dive. The score is set from another function from the judge.
            competition = comp; 
            nrDive = ID;
            diveGroups = diveGroup;
            performer = athlete;
        }
    }
}
