﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }



        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool IsMoreThanThirty(Person person)
        {
            bool moreThan30 = false;
            if (person.Age > 30)
            {
                moreThan30 = true;
            }
            return moreThan30;
        }

    }
}
