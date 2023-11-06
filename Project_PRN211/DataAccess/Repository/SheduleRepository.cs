using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class SheduleRepository
    {
        public bool AddNewSchedule(Schedule newSchedule) => ScheduleDAO.Instance.AddNewSchedule(newSchedule);


        public bool DeleteSchedule(string id) => ScheduleDAO.Instance.DeleteSchedule(id);

        public Schedule? GetSchedule(string id) => ScheduleDAO.Instance.GetScheduleById(id);


        public ICollection<Schedule> GetSchedules() => ScheduleDAO.Instance.GetSchedules();


        public bool UpdateSchedule(Schedule newSchedule) => ScheduleDAO.Instance.UpdateSchedule(newSchedule);
    }
}
