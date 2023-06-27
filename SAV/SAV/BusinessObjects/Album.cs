using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SAV.BusinessObjects
{
    [Table("tb_Albums")]
    public class Album
    {

        [Key]
        [Column("ID")]
        public int ID { get; set; }

       
       [Column("Title")]
        public string Title { get; set; }

        [Column("Year")]
        public int Year { get; set; } 

        [Column("Description")]
        public string? Description { get; set; }

        [Column("ImageFile")]
        public string ImageFile { get; set; }

        [ForeignKey("FK_Aritst_Album")]
        [Column("Artist_ID")]
        public int ArtistID { get; set; }
        public Artist Artist { get; set; }



        public List<Song>  Songs { get; set; }

        public Album()
        {

        }

        public Album(int iD, string title, int year, string? description, string imageFile, int artistID)
        {
            ID = iD;
            Title = title;
            Year = year;
            Description = description;
            ImageFile = imageFile;
            ArtistID = artistID;
        }
    }
}
