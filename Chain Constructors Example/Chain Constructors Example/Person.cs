using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Constructors_Example
{
    class Person
    {
        public Person(string name, int age) : this(name, age, false) //assume person is not over 21 if age is not given, until age is given
        {
        }
        public Person(string name, int age, bool isOverTwentyOne)
        {
            Name = name;
            Age = age;
            IsOverTwentyOne = CheckAge(Age);
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsOverTwentyOne { get; set; }
        
        private bool CheckAge(int age)
        {
            if (age >= legalAgeToPurchaseAlcohol)
            {
                return true;
            }
            return false;
        }

        const int legalAgeToPurchaseAlcohol = 21; //utilize const keyword
    }
}
