using SAV.ORM;
using SAV.BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAV.Repos
{
    public class UserRepo
    {
        private static readonly object key = new object();
        private static UserRepo _instance;

        private MssqlDBContextUR _context { get; set; }

        public UserRepo()
        {
            _context = MssqlDBContextUR.GetInstance();
        }

        public static UserRepo GetInstance()
        {
            lock(key)
            {
                if(_instance != null)
                {
                    return _instance;
                }
                return new UserRepo();
            }
        }


        public User FindID(int id)
        {
            var query = from s in _context.Users
                        where s.ID == id
                        select s;

            User userA = query.FirstOrDefault<User>();

            return userA;
        }

        public List<User> GetList()
        {
            var query = from s in _context.Users
                        select s;

            return query.ToList<User>();
        }

        //public void Update(User user)
        //{
            
        //}

        //public void Save(User user)
        //{

        //}


        //public void Delete(User user)
        //{

        //}
    }
}
