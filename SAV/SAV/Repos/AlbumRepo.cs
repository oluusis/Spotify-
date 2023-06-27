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
    public class AlbumRepo
    {
        private static readonly object mylock = new object();
        private MssqlDbContext _context;
        private static AlbumRepo _instance;
        

        public AlbumRepo()
        {
            _context = MssqlDbContext.Getinstance();
        }

        public static AlbumRepo GetInstance()
        {
            lock (mylock)
            {
                if (_instance == null)
                {
                    return _instance = new AlbumRepo();
                }
                return _instance;
            }
           
        }

        public List<Album> GetList()
        {
            var query = from a in _context.Albums
                        select a;
            return query.ToList<Album>(); 
        }

        public void Update(Album album)
        {
            var query = from a in _context.Albums
                        where a.ID == album.ID
                        select a;

            Album aAttached = query.FirstOrDefault<Album>();

            aAttached.Description = album.Description;
            aAttached.Title = album.Title;
            aAttached.Year = album.Year;
            aAttached.ImageFile = album.ImageFile;
            aAttached.ArtistID = album.ArtistID;

            this._context.SaveChanges();

        }

        public void Save(Album album)
        {
            _context.Add(album);
            _context.SaveChanges();
        }

        public void Delete(Album album)
        {
            var query = from a in this._context.Albums
                        where album.ID == a.ID
                        select a;

            Album aAttached = query.FirstOrDefault<Album>();

            this._context.Entry(aAttached).State = EntityState.Deleted;
            this._context.SaveChanges();
        }

        public Album FindId(int id)
        {
            var query = from a in this._context.Albums
                        where id == a.ID
                        select a;

            Album album = query.FirstOrDefault<Album>();

            return album;
        }
    }
}
