using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class FoodDAO
    {
        private static FoodDAO instance = null;
        public static object lockObject = new object();
        private FoodDAO() { }
        public static FoodDAO Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new FoodDAO();
                    }
                    return instance;
                }
            }

        }
        public Food? GetFoodById(string id)
        {
            using var db = new ZooManagementFormContext();
            return db.Foods.FirstOrDefault(f => f.FoodId == id);
        }

        public List<Food>GetFoods()
        {
            using var db = new ZooManagementFormContext();
            return db.Foods.ToList();
        }

        public bool AddNewFood(Food food)
        {
            using var db = new ZooManagementFormContext();
            db.Foods.Add(food);
            return db.SaveChanges() > 0;
        }

        public bool UpdateFood(Food food)
        {
            using var db = new ZooManagementFormContext();
            var fd = db.Foods.FirstOrDefault(f => f.FoodId == food.FoodId);
            if (fd != null)
            {
                db.Foods.Update(food);
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public bool DeleteFood(string id) 
        {
            using var db = new ZooManagementFormContext();
            Food? fd = db.Foods.FirstOrDefault(f => f.FoodId == id);
            if (fd != null)
            {
                db.Foods.Remove(fd);
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
