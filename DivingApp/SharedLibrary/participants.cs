using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public class Participants
    {
        public string first;
        public string last;
        public int gend;
        public int age;

        public Participants()
        {

        }
        public Participants(string firstName, string surName, int gender, int Age)
        {
            last = surName;
            first = firstName;
            gend = gender;
            age = Age;
        }
    }
}
