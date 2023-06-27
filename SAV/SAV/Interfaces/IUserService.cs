using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SAV.BusinessObjects;
using SAV.Services;

namespace SAV.Interfaces
{
    public interface IUserService
    {
        //public static UserService GetInstance()

        public List<User> GetList();

        public User FindId(int id);
    }
}
