using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class AnimalRepository : IAnimalRepository
    {
        public bool AddNewAnimal(Animal newAnimal) => AnimalDAO.Instance.AddNewAnimal(newAnimal);

        public bool DeleteAnimal(string id) => AnimalDAO.Instance.DeleteAnimal(id);

        public Animal GetAnimal(string id) =>  AnimalDAO.Instance.GetAnimalById(id);

        public ICollection<Animal> GetAnimals() => AnimalDAO.Instance.GetAnimals();

        public ICollection<Animal> GetAvailableAnimals() => AnimalDAO.Instance.GetAvailableAnimal();

        public ICollection<Animal> SearchAndFilterAnimalBySpecies(string species, string key) => AnimalDAO.Instance.FilterAndSearchAnimalBySpeices(species, key);

        public bool UpdateAnimal(Animal animal) => AnimalDAO.Instance.UpdateAnimal(animal);
    }
}
