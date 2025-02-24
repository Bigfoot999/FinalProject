using System;
using System.Collections.Generic;
using System.IO;
using FinalProject.Model;


namespace FinalProject.Repository
{
    public class UserRepository
    {
        public List<User> lsUser;
        protected int Id = 1001;
        public UserRepository()
        {
            this.lsUser = new List<User>();
        }

        public User createUser(string name, string gender, DateTime year, string role)
        {
            User user = new User(name, gender, year, role);
            Id++;
            user.Id = Id;
            lsUser.Add(user);

            return user;

        }

        internal User findById(int id)
        {
            foreach (User user in lsUser)
            {
                if (user.Id == id)
                {
                    return user;
                }
            }
            return null;
        }

        public List<User> getAll()
        {
            return lsUser;
        }

        public List<User> findByName(string name)
        {
            List<User> newLs = new List<User>();
            foreach (User user in lsUser)
            {
                if (user.Name.Contains(name))
                {
                    newLs.Add(user);
                }
            }
            return newLs;
        }

        public String updateUser(int id, string name, string gender, DateTime year, string role)
        {
            foreach (User user in lsUser)
            {
                if (user.Id == id)
                {
                    user.Name = name;
                    user.Gender = gender;
                    user.YearOfBirth = year;
                    user.Role = role;
                    return "Thông tin User đã được cập nhật!";
                }
            }
            return "Cập nhật thất bại!";
        }
    }
}
