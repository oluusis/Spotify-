using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SAV.BusinessObjects
{
    [Table("tb_User")]
    public class User
    {
        [Key]
        [Column("ID")]
        public int ID { get; set; }

        [Column("Username")]
        public string Name { get; set; }

        [Column("Password")]
        public string Password { get; set; }

        [Column("FirstName")]
        public string FirstName { get; set; }

        [Column("LastName")]
        public string LastName { get; set; }

        [Column("Email")]
        public string? Email { get; set; }

        [Column("IsActive")]
        public bool IsActive { get; set; } // možná to nebudu convertovat správně


        // list rolý

        public User() 
        { 
        }

        public User(int iD, string name, string password, string firstName, string lastName, string? email, bool isActive)
        {
            ID = iD;
            Name = name;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            IsActive = isActive;
        }
    }
}
