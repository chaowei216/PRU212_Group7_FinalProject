using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IAreaRepository
    {
        public List<Area> GetAllArea();
        public Area GetAreaByID(string id);
        public Area GetAreaByName(string name);
        public void AddArea(Area area);
        public void UpdateArea(Area area);
        public void DeleteArea(Area area);

    }
}
