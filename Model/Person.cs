﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model
{
    public abstract class Person
    {
        public string name { get; set; } = null;
        public string gender { get; set; } = null;
        public DateTime YearOfBirth { get; set; }

        public Person(string name, string gender, DateTime yearOfBirth)
        {
            this.name = name;
            this.gender = gender;
            YearOfBirth = yearOfBirth;
        }
        public Person() { }



    }
}
