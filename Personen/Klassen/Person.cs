using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Personen.Klassen
{
    class Person
    {
        private string name;
        private int age;
        private string city;
        private string job;

        public Person(string name, int age, string city, string job)
        {
            this.name = name;
            this.age = age;
            this.city = city;
            this.job = job;
        }

        public string Name
        {

            get { return this.name; }
            set { this.name = value; }


        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value >= 0)
                {
                    this.age = value;
                }
            }
        }

        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }

        public string Job
        {
            get { return this.job; }
            set { this.job = value; }
        }



    }
}
