using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AnimalDAO
    {
        private static AnimalDAO? instance = null;
        private static object lockObject = new object();
        private AnimalDAO() { }
        public static AnimalDAO Instance
        {
            get
            {
                lock(lockObject)
                {
                    if(instance == null)
                    {
                        instance = new AnimalDAO();
                    }
                    return instance;
                }
            }
        }

        public Animal? GetAnimalById(string id)
        {
            using var db = new ZooManagementFormContext();
            return db.Animals.FirstOrDefault(ani => ani.AnimalId == id);
        }

        public List<Animal> FilterAndSearchAnimalBySpeices(string species, string keys)
        {
            using var db = new ZooManagementFormContext();
            if(species.Equals("All"))
                return db.Animals.Where(ani => ani.Status == true && ani.Name.ToLower().Contains(keys.ToLower())).ToList();
            else
            return db.Animals.Where(ani => ani.Status == true && ani.SpeciesName.Equals(species) && ani.Name.ToLower().Contains(keys.ToLower())).ToList();
        }

        public List<Animal> GetAnimals()
        {
            using var db = new ZooManagementFormContext();
            return db.Animals.ToList();
        }

        public List<Animal> GetAvailableAnimal()
        {
            using var db = new ZooManagementFormContext();
            return db.Animals.Where(ani => ani.Status == true).ToList();
        }

        public bool AddNewAnimal(Animal animal)
        {
            using var db = new ZooManagementFormContext();
            var totalAnimals = GetAnimals().Count(); //mang rong tra ve 0 hay null?
            int count = totalAnimals + 1;
            var animalId = "AN" + count.ToString().PadLeft(4, '0');
            animal.AnimalId = animalId;
            animal.Status = true;
            animal.HealthCheck = "Normal";
            db.Animals.Add(animal);
            return db.SaveChanges() > 0;
        }

        public bool UpdateAnimal(Animal animal)
        {
            using var db = new ZooManagementFormContext();
            var ani = db.Animals.FirstOrDefault(ani => ani.AnimalId == animal.AnimalId);
            if(ani != null)
            {
                ani.Name = animal.Name;
                ani.HealthCheck = animal.HealthCheck;
                ani.Rarity = animal.Rarity;
                ani.Description = animal.Description;
                db.Animals.Update(ani);
                return db.SaveChanges() > 0;
            }
            else return false;
        }

        public bool DeleteAnimal(string id)
        {
            using var db = new ZooManagementFormContext();
            Animal? ani = db.Animals.FirstOrDefault(a => a.AnimalId == id);
            if(ani != null)
            {
                ani.Status = false;
                db.Animals.Update(ani);
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
