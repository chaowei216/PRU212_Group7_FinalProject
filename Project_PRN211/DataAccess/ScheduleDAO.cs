using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class ScheduleDAO
    {
        private static ScheduleDAO instance = null;
        public static object lockObject = new object();
        private ScheduleDAO() { }
        public static ScheduleDAO Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new ScheduleDAO();
                    }
                    return instance;
                }
            }
        }
        public Schedule? GetScheduleById(string id)
        {
            using var db = new ZooManagementFormContext();
            return db.Schedules.FirstOrDefault(sch => sch.ScheduleId == id);
        }

        public List<Schedule> GetSchedules()
        {
            using var db = new ZooManagementFormContext();
            return db.Schedules.ToList();
        }
        public bool AddNewSchedule(Schedule schedule)
        {
            using var db = new ZooManagementFormContext();
            try
            {
                var total = GetSchedules().Count();
                int count = total + 1;
                var scheduleId = "SC" + count.ToString().PadLeft(4, '0');
                schedule.ScheduleId = scheduleId;
                schedule.Status = true;
                db.Schedules.Add(schedule);
                return db.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool UpdateSchedule(Schedule schedule)
        {
            using var db = new ZooManagementFormContext();
            var sche = db.Schedules.FirstOrDefault(sch => sch.ScheduleId == sch.ScheduleId);
            if (sche != null)
            {
                db.Schedules.Update(schedule);
                return db.SaveChanges() > 0;
            }
            return false;
        }



        public bool DeleteSchedule(Schedule c)
        {
            using var db = new ZooManagementFormContext();
            Schedule? sche = db.Schedules.FirstOrDefault(f => f.ScheduleId == c.ScheduleId);
            if (sche != null)
            {
                db.Schedules.Remove(sche);
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public List<AnimalSchedule> GetSchedulesByAnimalId(string animalId)
        {
            try
            {
                using var db = new ZooManagementFormContext();
                var animal = db.Animals.FirstOrDefault(a => a.AnimalId.Equals(animalId));
                if(animal != null)
                {
                    return db.AnimalSchedules.Include(a => a.Animal).Include(a => a.Schedule).Where(a => a.AnimalId.Equals(animalId)).ToList();
                } else
                {
                    throw new Exception("Animal is not existed!");
                }
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool AddAnimalSchedule(AnimalSchedule animal)
        {
            try
            {
                using var db = new ZooManagementFormContext();
                var aSche = db.AnimalSchedules.FirstOrDefault(a => a.AnimalId.Equals(animal.AnimalId) && a.ScheduleId.Equals(a.ScheduleId));
                if(aSche == null)
                {
                    db.AnimalSchedules.Add(animal);
                    return db.SaveChanges() > 0;
                } else
                {
                    return false;
                }

            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        } 

        public bool UpdateAnimalSchedule(AnimalSchedule animal)
        {
            try
            {
                using var db = new ZooManagementFormContext();
                var aSche = db.AnimalSchedules.FirstOrDefault(a => a.AnimalId.Equals(animal.AnimalId) && a.ScheduleId.Equals(a.ScheduleId));
                if(aSche != null)
                {
                    aSche.Time = animal.Time;
                    aSche.Description = animal.Description;
                    db.AnimalSchedules.Update(aSche);
                    return db.SaveChanges() > 0;
                } else
                {
                    throw new Exception("Does not exist!");
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool DeleteAnimalSchedule(AnimalSchedule animal)
        {
            try
            {
                using var db = new ZooManagementFormContext();
                var aSche = db.AnimalSchedules.FirstOrDefault(a => a.AnimalId.Equals(animal.AnimalId) && a.ScheduleId.Equals(a.ScheduleId));
                if (aSche != null)
                {
                    db.AnimalSchedules.Remove(aSche);
                    return db.SaveChanges() > 0;
                }
                else
                {
                    throw new Exception("Does not exist!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
