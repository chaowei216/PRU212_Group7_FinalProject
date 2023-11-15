using BussinessObject.Models;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
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
            try
            {
                using var db = new ZooManagementFormContext();
                var f1 = db.Foods.Where(f => f.Fname.ToLower().Equals(food.Fname.ToLower())).ToList().Count();
                if (f1 > 0)
                    throw new Exception("Name is existed!");
                else
                {
                    var total = GetFoods().Count();
                    int count = total + 1;
                    var foodId = "FD" + count.ToString().PadLeft(4, '0');

                    food.FoodId = foodId;

                    db.Foods.Add(food);
                    return db.SaveChanges() > 0;
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public bool UpdateFood(Food food)
        {
            try
            {
                using var db = new ZooManagementFormContext();
                var fd = GetFoodById(food.FoodId);
                if (fd != null)
                {
                    fd.Quantity = food.Quantity;
                    fd.ImportDate = food.ImportDate;
                    fd.ExpiredDate = food.ExpiredDate;
                    db.Foods.Update(fd);
                    return db.SaveChanges() > 0;
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return false;
        }

        public bool DeleteFood(string id) 
        {
            try
            {
                using var db = new ZooManagementFormContext();
                Food fd = GetFoodById(id);
                var count = db.AnimalFoods.Where(af => af.FoodId.Equals(id) && af.EndEat <= DateTime.Now).Count();
                if(count > 0)
                {
                    throw new Exception("Food is still ate!");
                }
                if (fd != null)
                {
                    fd.Quantity = 0;
                    db.Foods.Update(fd);
                    return db.SaveChanges() > 0;
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return false;
        }

        public List<Food> SearchFoodByName(string name)
        {
            using var db = new ZooManagementFormContext();
            return db.Foods.Where(f => f.Fname.ToUpper().Contains(name.ToUpper())).ToList();
        }

        public List<AnimalFood> LoadFoodOfAnimal(string animalId)
        {
            using var db = new ZooManagementFormContext();
            return db.AnimalFoods.Where(af => af.AnimalId.Equals(animalId)).ToList();
        }

        public bool AddFoodForAnimal(AnimalFood food)
        {
            using var db = new ZooManagementFormContext();
            try
            {
                db.AnimalFoods.Add(food);
                return db.SaveChanges() > 0;
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool UpdateFoodForAnimal(AnimalFood af)
        {
            using var db = new ZooManagementFormContext();
            try
            {
                var aniFood = db.AnimalFoods.FirstOrDefault(a => a.AnimalId.Equals(af.AnimalId) && a.FoodId.Equals(af.FoodId));
                if (aniFood != null)
                {
                    aniFood.EndEat = af.EndEat;
                    aniFood.Amount = af.Amount;
                    db.AnimalFoods.Update(af);
                    return db.SaveChanges() > 0;
                }
            } catch(Exception ex) { throw new Exception(ex.Message); }
            return false;
        }

        public bool DeleteFoodOfAnimal(AnimalFood af)
        {
            using var db = new ZooManagementFormContext();

            try
            {
                AnimalFood aniFood = db.AnimalFoods.FirstOrDefault(a => a.AnimalId.Equals(af.AnimalId) && a.FoodId.Equals(af.FoodId));
                if (aniFood != null)
                {
                    if (aniFood.EndEat < DateTime.Now)
                    {
                        throw new Exception("Animal didnt eat it more!");
                    }
                    else
                    {
                        aniFood.EndEat = DateTime.Now;
                        db.AnimalFoods.Update(aniFood);
                        return db.SaveChanges() > 0;
                    }
                }
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return false;

        }
    }
}
