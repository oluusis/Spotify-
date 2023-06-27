using SAV.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAV.Interfaces
{
    public interface IUserRoleService
    {
        public List<UserRole> GetList();

        public UserRole FindId(int id);
    }
}
