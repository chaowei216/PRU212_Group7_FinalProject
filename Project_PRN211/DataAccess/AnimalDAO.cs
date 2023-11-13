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
                lock (lockObject)
                {
                    if (instance == null)
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
            if (species.Equals("All"))
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

        public bool AddNewAnimal(Animal animal, Cage cage, User user)
        {
            using var db = new ZooManagementFormContext();
            try
            {
                //add animal
                var totalAnimals = GetAnimals().Count();
                int count = totalAnimals + 1;
                var animalId = "AN" + count.ToString().PadLeft(4, '0');


                animal.AnimalId = animalId;
                animal.Status = true;
                animal.HealthCheck = "Normal";

                //Add animal cage
                AnimalCage aniCage = new AnimalCage
                {
                    Animal = animal,
                    Cage = db.Cages.FirstOrDefault(c => c.Cid.Equals(cage.Cid)),
                    EntryCageDate = DateTime.Now
                };
                db.AnimalCages.Add(aniCage);


                //add animal user
                AnimalTrainer trainer = new AnimalTrainer
                {
                    User = db.Users.FirstOrDefault(u => u.UserId.Equals(user.UserId)),
                    Animal = animal,
                    StartTrainDate = DateTime.Now,
                };
                db.AnimalTrainers.Add(trainer);

                return db.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public bool UpdateAnimal(Animal animal, Cage cage, User user)
        {
            using var db = new ZooManagementFormContext();
            var ani = db.Animals.FirstOrDefault(ani => ani.AnimalId == animal.AnimalId);
            var c = db.AnimalCages.FirstOrDefault(c1 => c1.AnimalId == animal.AnimalId && c1.OutCageDate == null);
            var u = db.AnimalTrainers.FirstOrDefault(u1 => u1.AnimalId == animal.AnimalId && u1.EndTrainDate == null);
            if (ani != null)
            {
                ani.Name = animal.Name;
                ani.HealthCheck = animal.HealthCheck;
                ani.Rarity = animal.Rarity;
                ani.Description = animal.Description;
                db.Animals.Update(ani);

                var c2 = db.Cages.FirstOrDefault(c => c.Cid == cage.Cid);
                if(c2 != null && c2.Cid != c.CageId)
                {
                    c.OutCageDate = DateTime.Now;
                    db.AnimalCages.Update(c);
                    var oldCage = db.AnimalCages.FirstOrDefault(ac => ac.AnimalId == animal.AnimalId && ac.CageId == cage.Cid);
                    if(oldCage != null)
                    {
                        oldCage.OutCageDate = null;
                        db.AnimalCages.Update(oldCage);
                    } else
                    {
                        AnimalCage aniCage = new AnimalCage
                        {
                            Animal = ani,
                            Cage = db.Cages.FirstOrDefault(c => c.Cid.Equals(cage.Cid)),
                            EntryCageDate = DateTime.Now
                        };
                        db.AnimalCages.Add(aniCage);
                    }
                }

                var u2 = db.Users.FirstOrDefault(u => u.UserId == user.UserId);
                if (u2 != null && u2.UserId != u.UserId)
                {
                    u.EndTrainDate = DateTime.Now;
                    db.AnimalTrainers.Update(u);
                    var oldTrainer = db.AnimalTrainers.FirstOrDefault(at => at.AnimalId == animal.AnimalId && at.UserId == user.UserId);
                    if(oldTrainer != null)
                    {
                        oldTrainer.EndTrainDate = null;
                        db.AnimalTrainers.Update(oldTrainer);
                    } else
                    {
                        AnimalTrainer trainer = new AnimalTrainer
                        {
                            User = db.Users.FirstOrDefault(u => u.UserId.Equals(user.UserId)),
                            Animal = ani,
                            StartTrainDate = DateTime.Now,
                        };
                        db.AnimalTrainers.Add(trainer);
                    }
                }

                return db.SaveChanges() > 0;
            }
            else return false;
        }

        public bool DeleteAnimal(string id)
        {
            try
            {
                using var db = new ZooManagementFormContext();
                Animal? ani = db.Animals.FirstOrDefault(a => a.AnimalId == id);
                var aniCage = db.AnimalCages.FirstOrDefault(ac => ac.AnimalId == id && ac.OutCageDate == null);
                var trainer = db.AnimalTrainers.FirstOrDefault(at => at.AnimalId == id && at.EndTrainDate == null);
                if (ani != null && aniCage != null && trainer != null)
                {
                    ani.Status = false;
                    db.Animals.Update(ani);

                    aniCage.OutCageDate = DateTime.Now;
                    db.AnimalCages.Update(aniCage);

                    trainer.EndTrainDate = DateTime.Now;
                    db.AnimalTrainers.Update(trainer);

                    return db.SaveChanges() > 0;
                }
                return false;
            } catch (Exception ex)
            {
                throw new Exception("ID does not exist!");
            }

        }
    }
}
