using SAV.BusinessObjects;
using SAV.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SAV.Services
{
    public class SongService
    {
        private SongRepo _songRepo;
        private static readonly object myLock = new object();
        private static SongService _instance;

        public SongService()
        {
            this._songRepo = SongRepo.GetInstance();
        }

        public static SongService GetInstance()
        {
            lock (myLock)
            {
                if (_instance == null)
                {
                    return _instance = new SongService();
                }
                return _instance;
            }
        }

        // GET LIST
        public List<Song> GetSongs()
        {
            return _songRepo.GetList();
        }

        // SAVE / UPDATE SONG
        public void SaveSong(Song song)
        {
            if(song.ID == 0)
            {
                _songRepo.Create(song);
            }
            else
            {
                _songRepo.Update(song);
            }
        }

        // DELETE
        public void DeleteSong(Song song)
        {
            _songRepo.Delete(song);
        }

        public Song FindId(int id)
        {
            return _songRepo.FindSong(id);
        }

        public int ConvertToID(string name)
        {
            return _songRepo.ConvertToID(name);
        }

    }
}
