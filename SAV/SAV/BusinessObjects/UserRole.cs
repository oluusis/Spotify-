using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SAV.BusinessObjects
{
    [Table("tb_UserRole")]
    public class UserRole
    {
        [Key]
        [Column("ID")]
        public int ID { get; set; }

        [ForeignKey("FK_UserRole_User")]
        [Column("User_ID")]
        public int UserID { get; set; }
        public User User { get; set; }

        [ForeignKey("FK_UserRole_Role")]
        [Column("Role_ID")]
        public int RoleID { get; set; }
        public User Role { get; set; }

        public UserRole() 
        {         
        }
    }
}
