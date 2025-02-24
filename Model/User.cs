using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Model;

namespace FinalProject.Model
{
    public class User : Person
    {
        public int Id { get; set; }
        public string Role { get; set; }
        public User(string name, string gender, DateTime yearOfBirth, string role) : base(name, gender, yearOfBirth)
        {
            
            this.Role = role; 
        }
        public User() { }
       

    }
}
