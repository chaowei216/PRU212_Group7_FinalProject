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
            db.Schedules.Add(schedule);
            return db.SaveChanges() > 0;
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
    }
}
