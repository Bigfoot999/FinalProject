using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model
{
    public abstract class Person
    {
        public string Name { get; set; } = null;
        public string Gender { get; set; } = null;
        public DateTime YearOfBirth { get; set; }

        public Person(string name, string gender, DateTime yearOfBirth)
        {
            this.Name = name;
            this.Gender = gender;
            YearOfBirth = yearOfBirth;
        }
        public Person() { }



    }
}
