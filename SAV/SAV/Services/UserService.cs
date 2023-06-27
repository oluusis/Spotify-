using SAV.Repos;
using SAV.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAV.Interfaces;

namespace SAV.Services
{
    public class UserService : IUserService
    {
        private static readonly object Key = new object();
        private static UserService _instance { get; set; }

        private UserRepo _userRepo { get; set; }

        public UserService() 
        {
            this._userRepo = UserRepo.GetInstance();        
        }

        public static UserService GetInstance()
        {
            lock(Key)
            {
                if(_instance != null)
                { 
                    return _instance;
                }
                return new UserService(); 
            }
        }

        public List<User> GetList()
        {
            return _userRepo.GetList();
        }

        public User FindId(int Id)
        {
            return _userRepo.FindID(Id);
        }
    }
}
