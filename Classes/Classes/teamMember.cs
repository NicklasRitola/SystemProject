using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class TeamMember : Participants
    {

        public TeamMember(string firstName, string surName, int gender)
        {
            last = surName;
            first = firstName;
            gend = gender;

        }
        public void RegisterDive()
        {

        }
    }
}
