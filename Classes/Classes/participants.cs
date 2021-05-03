using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Participants
    {


        public string first;
        public string last;
        public int gend;

        public Participants()
        {

        }
        public Participants(string firstName, string surName, int gender)
        {
            last = surName;
            first = firstName;
            gend = gender;
        }
        
    }
}
