﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Person
    {
        private string name;
        private int age;

        public Person() { }

        public Person(int Age, string Name)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public void printInfo()
        {
            Console.WriteLine($"{Name} is {Age} years old.");
        }

    }

}

