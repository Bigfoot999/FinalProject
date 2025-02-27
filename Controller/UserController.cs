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
        public User CreateUser(string name, string gender, DateTime year, string role)
        {
            return userRepository.createUser(name, gender, year, role);
        }
        public User findbyId(int id)
        {
            return userRepository.findById(id);
        }
        public List<User> getAll()
        {
            return userRepository.getAll();
        }
        public List<User> findByName(String name)
        {
            return userRepository.findByName(name);
        }
        public String updateUser(int id,string Name, String Gender, DateTime Year, string role)
        {
            return userRepository.updateUser(id, Name, Gender, Year, role);
        }
        public string deleteUser(int id) {
            return userRepository.deleteUser(id);
        }
}
