using SAV.BusinessObjects;
using SAV.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Forms.Media_Player
{
    public partial class PlaySound : Form
    {
        private Song _song;
        private Album _album;
        private Artist _artist;
        private ArtistService _artistService;
        private SongService _songService;
        private AlbumService _albumService;
        private List<Song> listSongs;

        private int seconds;
        private int minutes;

        private SoundPlayer player;

        private bool isStart;

        public PlaySound(int selectedID)
        {
            this._songService = SongService.GetInstance();
            this._albumService = AlbumService.GetInstance();
            this._artistService = ArtistService.GetInstance();
            this._song = _songService.FindId(selectedID);
            this._album = _albumService.FindId(_song.AlbumID);
            this._artist = _artistService.FindId(_album.ArtistID);


            this.seconds = 0;
            this.minutes = 0;

            this.player = new SoundPlayer();
            this.isStart = false;

            this.listSongs = _songService.GetSongs();

            InitializeComponent();
            SetAll();
        }

        public void SetAll()
        {
            this.labelArtisName.Text = _artist.Name;
            this.labelCountry.Text = _artist.CountryCode;
            this.labelAlbumTitle.Text = _album.Title;
            this.labelRelesedIn.Text = Convert.ToString(_album.Year);
            this.labelSongTitle.Text = _song.Name;
            this.labelDuration.Text = _song.GetMinutes();
            this.labelTrack.Text = _song.TrackNo.ToString();
            this.labelDurOf.Text = _song.GetMinutes();
            this.player.SoundLocation = $@"{_song.SongFile}";
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            string vystup = "";
            this.seconds += 1;
            if (seconds == 60)
            {
                this.seconds = 0;
                this.minutes += 1;
            }
            if(seconds < 10)
            {
                vystup = minutes.ToString() + ":0" + seconds.ToString();
            }
            else
            {
                vystup = minutes.ToString() + ":" + seconds.ToString();
            }
            
            this.labelSeconds.Text = vystup;

            if (vystup == _song.GetMinutes())
            {
                timer1.Stop();
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (isStart)
            {
                isStart= false;
                timer1.Stop();
                player.Stop();
            }
            else
            {
                isStart = true;
                timer1.Start();
                player.Play();
            }

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            
            

            if (_song.ID != listSongs[listSongs.Count-1].ID)
            {
                this._song = _songService.FindId(_song.ID + 1);
            }
            else
            {
                this._song = listSongs[0];
            }
            Reset();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (_song.ID > 1)
            {
                this._song = _songService.FindId(_song.ID - 1);
            }
            else
            {
                this._song = listSongs[listSongs.Count- 1];
            }
            Reset();
        }

        private void Reset()
        {
            SetAll();
            player.Stop();
            isStart = false;
            this.timer1.Stop();
            this.seconds = 0;          
            this.minutes = 0;
            this.labelSeconds.Text = "0:00";
        }
    }
}
