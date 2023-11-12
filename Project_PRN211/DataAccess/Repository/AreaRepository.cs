using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class AreaRepository : IAreaRepository
    {
        public void AddArea(Area area)
        {
            AreaDAO.Instance.AddArea(area);
        }

        public void DeleteArea(Area area)
        {
            AreaDAO.Instance.DeleteArea(area);
        }

        public List<Area> GetAllArea()
        {
            return AreaDAO.Instance.GetAllArea();
        }

        public Area GetAreaByID(string id)
        {
            return AreaDAO.Instance.GetAreaByID(id);
        }

        public Area GetAreaByName(string name)
        {
            return AreaDAO.Instance.GetAreaByName(name);
        }

        public void UpdateArea(Area area)
        {
            AreaDAO.Instance.UpdateArea(area);
        }
    }
}
