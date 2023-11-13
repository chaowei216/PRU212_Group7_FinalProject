using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UserDAO
    {
        private static UserDAO instance;
        private static readonly object instanceLock = new object();
        public UserDAO() { }
        public static UserDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UserDAO();
                    }
                }
                return instance;
            }
        }
        public User CheckLogin(string email, string password)
        {
            using var db = new ZooManagementFormContext();
            return db.Users.Where(m => m.Email.Equals(email)).FirstOrDefault();
        }
        public List<User> GetUsers()
        {
            using var db = new ZooManagementFormContext();
            return db.Users.ToList();
        }
        public User GetUserByID(string id)
        {
            List<User> users = GetUsers();
            User user = users.Where(u => u.UserId == id).FirstOrDefault();
            return user;
        }
        public User GetUserByLastName(string name)
        {
            List<User> users = GetUsers();
            User user = users.Where(u => u.Lastname == name).FirstOrDefault();
            return user;
        }
        public User GetUserByEmail(string email)
        {
            List<User> users = GetUsers();
            User user = users.Where(u => u.Email == email).FirstOrDefault();
            return user;
        }
        public List<User> GetUsersByRole(int role)
        {
            List<User> users = GetUsers();
            List<User> listUserByRole = new List<User>();
            foreach (User user in users)
            {
                if (user.Role == role)
                {
                    listUserByRole.Add(user);
                }
            }
            return listUserByRole;
        }

        public User GetTrainerByAnimalId(string id)
        {
            try
            {
                using var db = new ZooManagementFormContext();
                var animalTrainer = db.AnimalTrainers.FirstOrDefault(ac => ac.AnimalId == id && ac.EndTrainDate == null);
                return GetUserByID(animalTrainer.UserId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void AddUser(User user)
        {
            try
            {
                using var db = new ZooManagementFormContext();
                db.Users.Add(user);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("ID or Email Existed");
            }
        }
        public bool UpdateUser(User user)
        {
            try
            {
                User u = GetUserByID(user.UserId);
                if (u != null)
                {
                    using var db = new ZooManagementFormContext();
                    db.Users.Update(user);
                    var saved = db.SaveChanges();
                    return saved > 0 ? true : false;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ID not found");
            }
        }

        public User? GetUserByPhone(string phone)
        {
            if (phone == null) return null;
            return GetUsers().Where(x => x.Phone == phone).FirstOrDefault();
        }

        public bool DeleteUser(string id)
        {
            var user = GetUserByID(id);

            if (user == null) return false;

            if (user.CountAnimal != 0) return false;

            user.Status = false;

            using var db = new ZooManagementFormContext();
            db.Users.Update(user);
            var saved = db.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
