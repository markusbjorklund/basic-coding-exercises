using System;
using System.Collections.Generic;

namespace exercise_111
{
    class Program
    {
        public static void Main(string[] args)
        {
            // IMPLEMENT YOUR CODE IN HERE!
            List<PersonalInformation> list = new List<PersonalInformation>();
            while (true)
            {
                // first name
                Console.WriteLine("First name:");
                string firstName = Console.ReadLine();
                // break on empty first name
                if (firstName == "")
                {
                    break;
                }
                // last name
                Console.WriteLine("Last name:");
                string lastName = Console.ReadLine();
                // id number
                Console.WriteLine("Identification number:");
                string identificationNumber = Console.ReadLine();

                // add names to the list
                list.Add(new PersonalInformation(firstName, lastName, identificationNumber));
            }
            // tidy up with an empty line
            Console.WriteLine();

            // print what we want
            foreach (PersonalInformation line in list)
            {
                Console.WriteLine(line.firstName + " " + line.lastName);
            }
        }
    }
}




