using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IFoodRepository
    {
        Food? GetFood(string id);
        ICollection<Food>GetFoods();
        bool AddNewFood(Food newFood);
        bool DeleteFood(string id);
        bool UpdateFood(Food newFood);
        List<Food> SearchFoodByName(string name);
        List<AnimalFood> GetFoodOfAnimal(string animalId);
        bool AddFoodForAnimal(AnimalFood af);
        bool DeleteFoodForAnimal(AnimalFood af);
        bool UpdateFoodForAnimal(AnimalFood af);
    }
}
