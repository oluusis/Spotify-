using SAV.BusinessObjects;
using SAV.ORM;
using SAV.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAV.Services
{
    public class AlbumService
    {
        private AlbumRepo _albumRepo;
        private static readonly object myLock = new object();
        private static AlbumService _instance;

        public AlbumService()
        {
            _albumRepo = AlbumRepo.GetInstance();
        }

        public static AlbumService GetInstance()
        {
            lock (myLock)
            {
                if(_instance == null)
                {
                    return _instance= new AlbumService();
                }
                return _instance;
            }
        }

        public List<Album> GetAlbums()
        {
            return _albumRepo.GetList();
        }

        public void SaveAlbum(Album album)
        {
            if(album.ID == 0)
            {
                _albumRepo.Save(album);
            }
            else
            {
                _albumRepo.Update(album);
            }
        }

        public void DeleteAlbum(Album album)
        {
            _albumRepo.Delete(album);
        }

        public Album FindId(int id)
        {
            return _albumRepo.FindId(id);
        }
    }
}
