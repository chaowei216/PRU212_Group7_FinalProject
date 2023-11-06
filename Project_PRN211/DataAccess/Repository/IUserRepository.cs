using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IUserRepository
    {
        public User CheckLogin(string email, string password);
        public List<User> GetUsers();
        public User GetUserByID(string id);
        public List<User> GetUsersByRole(int role);
        public User GetUserByLastName(string name);
        public User GetUserByEmail(string email);
        public void AddUser(User user);
        public bool UpdateUser(User user);
        public User? GetUserByPhone(string phone);
        public bool DeleteUser(string id);
    }
}
