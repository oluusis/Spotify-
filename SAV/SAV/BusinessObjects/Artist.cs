using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore.SqlServer;

namespace SAV.BusinessObjects
{
    [Table("tb_Artists")]
    public class Artist
    {
        [Key]
        [Column("ID")]
        public int ID { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Description")]
        public string? Description { get; set; }

        [Column("CountryCode")]
        public string CountryCode { get; set; }

        [Column("ActiveFrom")]
        public DateTime? ActiveFrom { get; set; }

        [Column("ActiveTo")]
        public DateTime? ActiveTo { get; set; }

        [Column("ImageFile")]
        public string ImageFile { get; set; }

        public List<Album> Albums { get; set;}

        public Artist()
        {

        }

        public Artist(int iD, string name, string? description, string countryCode, DateTime? activeFrom, DateTime? activeTo, string imageFile)
        {
            ID = iD;
            Name = name;
            Description = description;
            CountryCode = countryCode;
            ActiveFrom = activeFrom;
            ActiveTo = activeTo;
            ImageFile = imageFile;
        }
    }
}
