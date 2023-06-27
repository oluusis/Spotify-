using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using SAV.Services;

namespace SAV.BusinessObjects
{
    [Table("tb_Songs")]
    public class Song
    {
        //private AlbumService _albumService;



        [Key]
        [Column("ID")]
        public int ID { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("SongFile")]
        public string SongFile { get; set; }

        [Column("DiscNo")]
        public int DiscNo { get; set; }

        [Column("TrackNo")]
        public int TrackNo { get; set; }

        [Column("Duration")]
        public double Duration { get; set; }
        public string GetDuration { get
            {
                return GetMinutes();
            } }

        [ForeignKey("Album_ID")]
        [Column("Album_ID")]
        public int AlbumID { get; set; }    
        public Album Album { get;set; }

        public Song()
        {

        }

        public Song(int iD, string name, string songFile, int discNo, int trackNo, double duration, int albumID)
        {
            ID = iD;
            Name = name;
            SongFile = songFile;
            DiscNo = discNo;
            TrackNo = trackNo;
            Duration = duration;
            AlbumID = albumID;
            //this.Album = _albumService.FindId(albumID);
        }

        public string GetMinutes()
        {
            int minutes = Convert.ToInt32(Math.Floor(this.Duration));
            
            double seconds = (this.Duration - minutes)*60;
            if(seconds < 10)
            {
                return Convert.ToString(minutes) + ":" +"0"+ Convert.ToString(seconds);
            }
            else
            {
                return Convert.ToString(minutes) + ":" + Convert.ToString(seconds);
            }

            
        }

    }
}
