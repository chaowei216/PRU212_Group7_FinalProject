using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface ICageRepository
    {
        public List<Cage> GetAllCages();
        public Cage GetCageByID(string id);
        public Cage GetCageByName(string name);
        public void AddCage(Cage cage);
        public void UpdateCage(Cage cage);
        public void DeleteCage(Cage cage);
        public List<Cage> GetCagesByAreaName(string areaName);
    }
}
