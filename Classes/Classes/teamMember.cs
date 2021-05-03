using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
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
        public void RegisterDive()
        {

        }
    }
}
