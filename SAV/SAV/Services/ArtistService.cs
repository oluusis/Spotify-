using SAV.BusinessObjects;
using SAV.Repos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAV.Services
{
    public class ArtistService
    {
        private ArtistRepo _artistrepo;
        private static readonly object myLock = new object();
        private static ArtistService _instance;

        public ArtistService()
        {
            _artistrepo = ArtistRepo.GetInstance();
        }

        public static ArtistService GetInstance()
        {
            lock (myLock)
            {
                if (_instance == null)
                {
                    return _instance = new ArtistService();
                }
                return _instance;
            }
        }

        // get list
        public List<Artist> GetArtists()
        {
            return _artistrepo.GetList();
        }

        public void SaveArtist(Artist artist)
        {
            if(artist.ID == 0)
            {
                //create new
                _artistrepo.Add(artist);
            }
            else
            {
                //update old
                _artistrepo.Update(artist);
            }

        }

        public void DeleteArtist(Artist artist)
        {
            _artistrepo.Delete(artist);
        }

        public Artist FindId(int id)
        {
            return _artistrepo.FindId(id);  
        }


    }
}
