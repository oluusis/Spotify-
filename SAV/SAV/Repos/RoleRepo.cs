using Microsoft.EntityFrameworkCore;
using SAV.BusinessObjects;
using SAV.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAV.Repos
{
    public class RoleRepo
    {
        private static readonly object myLock = new object();
        private static RoleRepo _instance { get; set; }
        private MssqlDBContextUR _dbcontext { get; set; }

        public RoleRepo()
        {
            this._dbcontext = MssqlDBContextUR.GetInstance();
        }

        public static RoleRepo GetInstance()
        {
            lock (myLock)
            {
                if (_instance != null)
                {
                    return _instance;
                }
                return _instance = new RoleRepo();
            }
        }

        public List<Role> GetList()
        {
            var query = from a in _dbcontext.Roles
                        select a;

            return query.ToList<Role>();
        }

        public Role FindId(int id)
        {
            var query = from a in this._dbcontext.Roles
                        where a.Id == id
                        select a;
            
            Role aRole = query.FirstOrDefault<Role>();

            return aRole;
        }

        public void Delete(Role role)
        {
            var query = from s in this._dbcontext.Roles
                        where s.Id == role.Id
                        select s;

            Role sAttached = query.FirstOrDefault<Role>();

            this._dbcontext.Entry(sAttached).State = EntityState.Deleted;
            this._dbcontext.SaveChanges();
        }

        public void Create(Role role)
        {
            this._dbcontext.Add(role);
            this._dbcontext.SaveChanges();
        }

        public void Update(Role role)
        {
            var query = from s in this._dbcontext.Roles
                        where s.Id == role.Id
                        select s;

            Role sAttached = query.FirstOrDefault<Role>();

            sAttached.Name = role.Name;
            sAttached.Description= role.Description;
            sAttached.Code = role.Code;

            this._dbcontext.SaveChanges();
        }

    }
}
