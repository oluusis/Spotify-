using Microsoft.EntityFrameworkCore;
using SAV.BusinessObjects;
using SAV.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SAV.Repos
{
    public class SongRepo
    {
        private MssqlDbContext _contex;
        private static readonly object myLock = new object();
        private static SongRepo _instance;

        public SongRepo()
        {
            this._contex= MssqlDbContext.Getinstance();
        }

        public static SongRepo GetInstance()
        {
            lock (myLock)
            {
                if(_instance == null)
                {
                   return _instance = new SongRepo();
                }
                return _instance;
            }
        }


        public List<Song> GetList()
        {
            var query = from s in _contex.Songs.Include(aa => aa.Album)
                        select s;

            return query.ToList<Song>();
        }

        public void Update(Song song)
        {
            var query = from s in this._contex.Songs
                        where s.ID == song.ID
                        select s;

            Song sAttached = query.FirstOrDefault<Song>();

            sAttached.Name = song.Name;
            sAttached.SongFile = song.SongFile;
            sAttached.DiscNo = song.DiscNo;
            sAttached.TrackNo = song.TrackNo;
            sAttached.Duration = song.Duration;
            sAttached.AlbumID = song.AlbumID;

            this._contex.SaveChanges();
        }


        public void Create(Song song)
        {
            this._contex.Add(song);
            this._contex.SaveChanges();
        }

 
        public void Delete(Song song)
        {
            var query = from s in this._contex.Songs
                        where s.ID == song.ID
                        select s;

            Song sAttached = query.FirstOrDefault<Song>();

            this._contex.Entry(sAttached).State = EntityState.Deleted;
            this._contex.SaveChanges();
        }


        public Song FindSong(int id)
        {
            var query = from s in this._contex.Songs
                        where s.ID == id
                        select s;

            Song song =  query.FirstOrDefault<Song>();
            return song;
        }


        public int ConvertToID(string name)
        {
            var query = from s in this._contex.Songs
                        where s.Name == name
                        select s;
            
            Song song = query.FirstOrDefault<Song>();
            if (song == null)
            {
                return -1;
            }
            return song.ID;
        }

    }
}
