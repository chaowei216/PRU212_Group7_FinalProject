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

    }
}
