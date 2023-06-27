using SAV.BusinessObjects;
using SAV.Interfaces;
using SAV.ORM;
using SAV.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAV.Services
{
    public class RoleService : IRoleService
    {
        private static readonly object key = new object();
        private static RoleService _instance { get; set; }
        private RoleRepo _roleRepo { get; set; }

        public RoleService()
        {
            this._roleRepo = RoleRepo.GetInstance();
        }

        public static RoleService GetInstance()
        {
            lock (key)
            {
                if (_instance == null)
                {
                    return _instance = new RoleService();
                }
                return _instance;
            }
        }



        public Role FindID(int id)
        {
            return _roleRepo.FindId(id);
        }

        public List<Role> GetList()
        {
            return _roleRepo.GetList();
        }

        public void Delete(Role role)
        {
            _roleRepo.Delete(role);
        }

        public void SaveRole(Role role)
        {
            if (role.Id == 0)
            {
                _roleRepo.Create(role);
            }
            else
            {
                _roleRepo.Update(role);
            }
        }
    }
}
