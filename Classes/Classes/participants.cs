using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Participants
    {


        private string first;
        private string last;
        private int gend;

        public Participants(string firstName, string surName, int gender)
        {
            last = surName;
            first = firstName;
            gend = gender;
        }
        
    }
}
