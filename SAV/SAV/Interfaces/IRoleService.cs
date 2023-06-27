using SAV.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAV.Interfaces
{
    public interface IRoleService
    {
        public List<Role> GetList();

        public Role FindID(int id);

        public void Delete(Role role);

        public void SaveRole(Role role);
    }
}
