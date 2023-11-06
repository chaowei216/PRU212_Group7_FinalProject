using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IAnimalRepository
    {
        Animal? GetAnimal(string id);
        ICollection<Animal> GetAnimals();
        ICollection<Animal> SearchAndFilterAnimalBySpecies(string species, string key);
        ICollection<Animal> GetAvailableAnimals();
        bool AddNewAnimal(Animal animal);
        bool DeleteAnimal(string id);
        bool UpdateAnimal(Animal newAnimal);
    }
}
