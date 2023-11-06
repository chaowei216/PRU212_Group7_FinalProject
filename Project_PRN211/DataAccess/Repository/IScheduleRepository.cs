using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IScheduleRepository
    {
        Schedule? GetSchedule(string id);
        ICollection<Schedule> GetSchedules();
        bool AddNewSchedule(Schedule newSchedule);
        bool DetachSchedule(string id);
        bool UpdateSchedule(Schedule newSchedule);
    }
}
