using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class UserRepository : IUserRepository
    {
        public void AddUser(User user)
        {
            UserDAO.Instance.AddUser(user);
        }

        public User CheckLogin(string email, string password)
        {
            return UserDAO.Instance.CheckLogin(email, password);
        }

        public bool DeleteUser(string id)
        {
            return UserDAO.Instance.DeleteUser(id);
        }

        public User GetUserByID(string id)
        {
            return UserDAO.Instance.GetUserByID(id);
        }
        public User GetUserByEmail(string email)
        {
            return UserDAO.Instance.GetUserByEmail(email);
        }

        public User GetUserByLastName(string name)
        {
            return UserDAO.Instance.GetUserByLastName(name);
        }

        public User? GetUserByPhone(string phone)
        {
            return UserDAO.Instance.GetUserByPhone(phone);
        }

        public List<User> GetUsers()
        {
            return UserDAO.Instance.GetUsers();
        }

        public List<User> GetUsersByRole(int role)
        {
            return UserDAO.Instance.GetUsersByRole(role);
        }

        public bool UpdateUser(User user)
        {
            return UserDAO.Instance.UpdateUser(user);
        }

        public User GetTrainerByAnimalId(string animalId) => UserDAO.Instance.GetTrainerByAnimalId(animalId);
    }
}
