using Microsoft.EntityFrameworkCore;
using SAV.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAV.ORM
{
    public class MssqlDbContext : DbContext
    {
        private static readonly object myLock = new object();
        private static MssqlDbContext instace { get; set; }

        public DbSet<Artist> Artists { get; set; }

        public DbSet<Song> Songs { get; set; }

        public DbSet<Album> Albums { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost; Initial Catalog=db_SAV; Integrated Security=True;");
        }

        public static MssqlDbContext Getinstance()
        {
            lock (myLock)
            {
                if (instace != null)
                {
                    return instace;
                }
                return new MssqlDbContext();
            }
           
        } 
    }
}
