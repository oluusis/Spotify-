using SAV.BusinessObjects;
using SAV.Interfaces;
using SAV.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAV.Services
{
    public class UserRoleService : IUserRoleService
    {
        private static readonly object key = new object();
        private static UserRoleService _instance { get; set; }
        private UserRoleRepo _roleRepo { get; set; }

        public UserRoleService()
        {
            this._roleRepo = UserRoleRepo.GetInstance();
        }

        public static UserRoleService GetInstance()
        {
            lock (key)
            {
                if (_instance == null)
                {
                    return _instance = new UserRoleService();
                }
                return _instance;
            }
        }

        public UserRole FindId(int id)
        {
            return _roleRepo.FindId(id);
        }

        public List<UserRole> GetList()
        {
            return _roleRepo.GetList();
        }
    }
}
