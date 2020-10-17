using Personen.Klassen;
using System;
using System.Collections.Generic;

namespace Personen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! - Aufgabe: Personen");

            string[] fileContent = System.IO.File.ReadAllLines("C:\\03_Coding\\02 Projects\\C#\\Personen\\persons.txt");

            List<Person> people = new List<Person>();

            foreach (string s in fileContent)
            {
                Console.WriteLine(s);

                string[] stringArray = s.Split(";");

                string name = stringArray[0];
                int age = int.Parse(stringArray[1]);
                string city = stringArray[2];
                string job = "";


                switch (name)
                {
                    case "Helga":
                    case "Hans":
                        job = "Coder";
                        break;
                    default:
                        job = "Officer";
                        break;
                }

                Person person1 = new Person(name, age, city, job);

                people.Add(person1);

            }


            int counter = 0;

            foreach (Person p in people)
            {
                Console.WriteLine(p.Name + p.Age + p.City + p.Job);

                fileContent[counter] = p.Name + ";" + p.Age + ";" + p.City + ";" + p.Job;

                counter = counter + 1;
            }

            System.IO.File.WriteAllLines("C:\\03_Coding\\02 Projects\\C#\\Personen\\persons1.txt", fileContent);

        }
    }
}
