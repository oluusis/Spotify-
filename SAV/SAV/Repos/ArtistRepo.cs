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
    public class ArtistRepo
    {
        private MssqlDbContext _context;
        private static ArtistRepo _instance;
        private static readonly object myLock = new object();

        public ArtistRepo()
        {
            _context = MssqlDbContext.Getinstance();
        }

        public static ArtistRepo GetInstance()
        {
            lock (myLock)
            {
                if(_instance == null)
                {
                    return _instance = new ArtistRepo();
                }
                return _instance;
            }
        }

        public List<Artist> GetList()
        {
            var query = from a in _context.Artists
                        select a;   

            return query.ToList<Artist>();
        }



        public Artist FindId(int ID)
        {
            var query = from a in _context.Artists
                        where ID == a.ID
                        select a; 

            Artist artist = query.FirstOrDefault<Artist>();
            return artist;
        }



        public void Update(Artist artist)
        {
            var query = from a in _context.Artists
                        where artist.ID == a.ID
                        select a;

            Artist aAttached = query.FirstOrDefault<Artist>();

            aAttached.Name = artist.Name;
            aAttached.Description = artist.Description;
            aAttached.CountryCode = artist.CountryCode;
            aAttached.ActiveFrom= artist.ActiveFrom;
            aAttached.ActiveTo= artist.ActiveTo;
            aAttached.ImageFile = artist.ImageFile;

            this._context.SaveChanges();
        }


        public void Add(Artist artist)
        {
            this._context.Add(artist);
            this._context.SaveChanges();
        }

        public void Delete(Artist artist) 
        {
            var query = from a in this._context.Artists
                        where artist.ID == a.ID
                        select a;

            Artist aAttached = query.FirstOrDefault<Artist>();

            this._context.Entry(aAttached).State = EntityState.Deleted;
            this._context.SaveChanges();
        }
    }
}
