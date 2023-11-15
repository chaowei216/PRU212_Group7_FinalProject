using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ScheduleRepository : IScheduleRepository
    {
        public bool AddNewSchedule(Schedule newSchedule) => ScheduleDAO.Instance.AddNewSchedule(newSchedule);


    

        public void DeleteSchedule(Schedule c)
     => ScheduleDAO.Instance.DeleteSchedule(c);
        public bool DetachSchedule(string id)
        {
            throw new NotImplementedException();
        }

        public List<Schedule> GetAllSchedules()
      =>  ScheduleDAO.Instance.GetSchedules();
        public Schedule? GetSchedule(string id) => ScheduleDAO.Instance.GetScheduleById(id);


        public ICollection<Schedule> GetSchedules() => ScheduleDAO.Instance.GetSchedules();


        public bool UpdateSchedule(Schedule newSchedule) => ScheduleDAO.Instance.UpdateSchedule(newSchedule);
    }
}
