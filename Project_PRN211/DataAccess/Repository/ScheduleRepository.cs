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
        public bool AddAnimalSchedule(AnimalSchedule animalSchedule) => ScheduleDAO.Instance.AddAnimalSchedule(animalSchedule);

        public bool AddNewSchedule(Schedule newSchedule) => ScheduleDAO.Instance.AddNewSchedule(newSchedule);

        public bool DeleteAnimalSchedule(AnimalSchedule animalSchedule) => ScheduleDAO.Instance.DeleteAnimalSchedule(animalSchedule);

        public void DeleteSchedule(Schedule c)
     => ScheduleDAO.Instance.DeleteSchedule(c);
        public bool DetachSchedule(string id)
        {
            throw new NotImplementedException();
        }

        public List<Schedule> GetAllSchedules()
      =>  ScheduleDAO.Instance.GetSchedules();
        public Schedule? GetSchedule(string id) => ScheduleDAO.Instance.GetScheduleById(id);

        public List<AnimalSchedule> GetScheduleOfAnimal(string id) => ScheduleDAO.Instance.GetSchedulesByAnimalId(id);

        public ICollection<Schedule> GetSchedules() => ScheduleDAO.Instance.GetSchedules();

        public bool UpdateAnimalSchedule(AnimalSchedule animalSchedule) => ScheduleDAO.Instance.UpdateAnimalSchedule(animalSchedule);

        public bool UpdateSchedule(Schedule newSchedule) => ScheduleDAO.Instance.UpdateSchedule(newSchedule);
    }
}
