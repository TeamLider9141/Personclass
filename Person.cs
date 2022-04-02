using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_class
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public  DateTime Birthday { get; set; }
        public float Height { get; set; }
        public int Weight { get; set; }
        public double Age()
        {
            return (DateTime.Now - Birthday).Days ;

        }

    }
}
