using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using SAV.BusinessObjects;

namespace SAV.ORM
{
    public class MssqlDBContextUR : DbContext
    {
        private static readonly object myLock = new object();       
        private static MssqlDBContextUR instance { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost; Initial Catalog=db_SAV; Integrated Security=True;");
        }

        public static MssqlDBContextUR GetInstance()
        {
            lock(myLock)
            {
                if(instance != null)
                {
                    return instance;
                }
                return new MssqlDBContextUR();
            }
        }
    }
}
