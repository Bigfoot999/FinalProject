using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Model;
using FinalProject.Repository;

namespace FinalProject.Controller
{
    class UserController
    {
        UserRepository userRepository = new UserRepository();
        protected int id = 1001;
        public User CreateUser(string name, string gender, DateTime year , string role)
        {
            return userRepository.createUser(name, gender, year, role);
        }
        public User findbyId(int id)
        {
            return userRepository.findById(id);
        }
    }
}
