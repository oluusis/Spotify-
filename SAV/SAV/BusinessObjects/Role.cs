using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SAV.BusinessObjects
{
    [Table("tb_Role")]
    public class Role
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("Code")]
        public string Code { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Description")]
        public string? Description { get; set; }

        // list useru

        public Role()
        {

        }

        public Role(int id, string code, string name, string? description)
        {
            Id = id;
            Code = code;
            Name = name;
            Description = description;
        }
    }
}
