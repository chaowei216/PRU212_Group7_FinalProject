using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AreaDAO
    {
        private static AreaDAO instance;
        private static readonly object instanceLock = new object();
        public AreaDAO() { }
        public static AreaDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new AreaDAO();
                    }
                }
                return instance;
            }
        }
        public List<Area> GetAllArea()
        {
            using var db = new ZooManagementFormContext();
            return db.Areas.ToList();
        }
        public Area GetAreaByID(string id)
        {
            List<Area> areas = GetAllArea();
            Area area = areas.Where(a => a.AreaId.Equals(id)).FirstOrDefault();
            return area;
        }
        public Area GetAreaByName(string name)
        {
            List<Area> areas = GetAllArea();
            return areas.Where(c => c.AreaName == name).FirstOrDefault();
        }
        public void AddArea(Area area)
        {
            try
            {
                using var db = new ZooManagementFormContext();
                db.Areas.Add(area);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("ID Existed");
            }
        }
        public void UpdateArea(Area area)
        {
            try
            {
                Area a = GetAreaByID(area.AreaId);
                if (a != null)
                {
                    using var db = new ZooManagementFormContext();
                    db.Areas.Update(area);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ID not found");
            }
        }
        public void DeleteArea(Area area)
        {
            try
            {
                using var db = new ZooManagementFormContext();
                var cDelete = db.Areas.Where(c => c.AreaId == area.AreaId).FirstOrDefault();
                db.Areas.Remove(cDelete);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("ID not found");
            }
        }
    }
}
