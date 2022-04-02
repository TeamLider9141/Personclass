
using System;

using static System.Math;

using System.Numerics;
using first_class;

namespace first_class
{
    public class Program
    {
        public static void Main(string[] args)
        {
         
            Person person = new Person()
            {
                FirstName = "Killer",
                LastName = "9141",

                 Birthday = new DateTime(2002, 02, 02),
            };
             Console.WriteLine(person.Age()); //  number of days I lived!!!


        }
    }
}

