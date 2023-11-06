using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CageDAO
    {
        private static CageDAO instance;
        private static readonly object instanceLock = new object();
        public CageDAO() { }
        public static CageDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CageDAO();
                    }
                }
                return instance;
            }
        }
        public List<Cage> GetAllCages()
        {
            using var db = new ZooManagementFormContext();
            return db.Cages.ToList();
        }
        public Cage GetCageByID(string id)
        {
            List<Cage> cages = GetAllCages();
            Cage cage = cages.Where(c => c.Cid.Equals(id)).FirstOrDefault();
            return cage;
        }
        public Cage GetCageByName(string name)
        {
            List<Cage> cage = GetAllCages();
            return cage.Where(c => c.Name == name).FirstOrDefault();
        }
        public void AddCage(Cage cage)
        {
            try
            {
                using var db = new ZooManagementFormContext();
                db.Cages.Add(cage);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("ID Existed");
            }
        }
        public void UpdateCage(Cage cage)
        {
            try
            {
                Cage c = GetCageByID(cage.Cid);
                if (c != null)
                {
                    using var db = new ZooManagementFormContext();
                    db.Cages.Update(cage);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ID not found");
            }
        }
        public void DeleteCage(Cage cage)
        {
            try
            {
                using var db = new ZooManagementFormContext();
                var cDelete = db.Cages.Where(c => c.Cid == cage.Cid).FirstOrDefault();
                db.Cages.Remove(cage);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("ID not found");
            }
        }
    }
}
