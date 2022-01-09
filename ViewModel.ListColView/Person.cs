using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.ListColView
{
    public class Person
    {
        public Person()
        {
        }

        public Person(string firstName, string lastName, string country)
        {
            FirstName = firstName;
            LastName = lastName;
            Country = country;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
    }
}
