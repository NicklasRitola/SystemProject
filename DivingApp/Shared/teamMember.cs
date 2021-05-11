using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public class TeamMember : Participants
    {
        public TeamMember()
        { 
        }
        public TeamMember(string firstName, string surName, int gender, int Age) //register member
        {
            last = surName;
            first = firstName;
            gend = gender;
            age = Age;

        }
        public Dive RegisterDive(string comp, int ID, int diveGroup, string athlete)
        {
            Dive createdDive = new Dive(comp, ID, diveGroup, athlete);
            return createdDive;
        }
    }
}
