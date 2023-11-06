using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class FoodRepository : IFoodRepository
    {
        public bool AddNewFood(Food newFood) => FoodDAO.Instance.AddNewFood(newFood);
        

        public bool DeleteFood(string id) => FoodDAO.Instance.DeleteFood(id);
        
        public Food? GetFood(string id) => FoodDAO.Instance.GetFoodById(id);
        

        public ICollection<Food> GetFoods() => FoodDAO.Instance.GetFoods();
        

        public bool UpdateFood(Food newFood) => FoodDAO.Instance.UpdateFood(newFood);
        
    }
}
