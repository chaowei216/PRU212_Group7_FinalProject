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
        public bool AddFoodForAnimal(AnimalFood af) => FoodDAO.Instance.AddFoodForAnimal(af);

        public bool AddNewFood(Food newFood) => FoodDAO.Instance.AddNewFood(newFood);
        

        public bool DeleteFood(string id) => FoodDAO.Instance.DeleteFood(id);

        public bool DeleteFoodForAnimal(AnimalFood af) => FoodDAO.Instance.DeleteFoodOfAnimal(af);

        public Food? GetFood(string id) => FoodDAO.Instance.GetFoodById(id);

        public List<AnimalFood> GetFoodOfAnimal(string animalId) => FoodDAO.Instance.LoadFoodOfAnimal(animalId);

        public ICollection<Food> GetFoods() => FoodDAO.Instance.GetFoods();

        public List<Food> SearchFoodByName(string name) => FoodDAO.Instance.SearchFoodByName(name);

        public bool UpdateFood(Food newFood) => FoodDAO.Instance.UpdateFood(newFood);

        public bool UpdateFoodForAnimal(AnimalFood af) => FoodDAO.Instance.UpdateFoodForAnimal(af);
    }
}
