using SAV.BusinessObjects;
using SAV.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAV.Repos
{
    public class UserRoleRepo
    {
        private static readonly object myLock = new object();
        private static UserRoleRepo _instance { get; set; }
        private MssqlDBContextUR _dbcontext { get; set; }

        public UserRoleRepo()
        {
            this._dbcontext = MssqlDBContextUR.GetInstance();
        }

        public static UserRoleRepo GetInstance()
        {
            lock (myLock)
            {
                if (_instance != null)
                {
                    return _instance;
                }
                return _instance = new UserRoleRepo();
            }
        }

        public List<UserRole> GetList()
        {
            var query = from a in _dbcontext.UserRoles
                        select a;

            return query.ToList<UserRole>();
        }

        public UserRole FindId(int id)
        {
            var query = from a in this._dbcontext.UserRoles
                        where a.ID == id
                        select a;

            UserRole aUserRole = query.FirstOrDefault<UserRole>();

            return aUserRole;
        }
    }
}
