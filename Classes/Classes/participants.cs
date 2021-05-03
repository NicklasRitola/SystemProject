using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class participants
    {

        public Person()
        {
            firstName = "unknown";
            surName = "unknown";

        }
        public Person(string firstname, string surname)
        {
            firstName = firstname;
            surname = surname;
        }

        public string firstName { get; }
        public string surName { get; }
        public override string ToString()
        {
            return firstName;
        }
    }
}
