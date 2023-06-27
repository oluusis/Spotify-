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

namespace Forms.Media_Player
{
    public partial class SongListViewPlay : Form
    {
        private List<Artist> _artists;
        private List<Song> _songs;
        private List<Album> _albums;

        private SongService _songS;



        public SongListViewPlay()
        {
            this._songS = SongService.GetInstance();
            AlbumService albumS = AlbumService.GetInstance();
            ArtistService artistS = ArtistService.GetInstance();

            this._artists = artistS.GetArtists();
            this._albums = albumS.GetAlbums();
            this._songs = _songS.GetSongs();



            InitializeComponent();
            InitializeTreeView();
        }

        private void InitializeTreeView()
        {
            this.treeView.Nodes.Clear();
            TreeNode parrent = new TreeNode("Tvoji umělci: ");
            AddArtist(parrent);
            this.treeView.Nodes.Add(parrent);

        }

        private void AddArtist(TreeNode parrent)
        {

            foreach (Artist artist in _artists)
            {
                parrent.Nodes.Add(artist.Name, artist.Name);
                AddAlbum(parrent.Nodes[artist.Name], artist.ID);

            }
        }

        private void AddAlbum(TreeNode parrant, int ID)
        {
            foreach (Album album in _albums)
            {
                if (album.ArtistID == ID)
                {
                    parrant.Nodes.Add(album.Title, album.Title + " - " + album.Year);
                    AddSong(parrant.Nodes[album.Title], album.ID);
                }
            }
        }


        private void AddSong(TreeNode parrant, int ID)
        {
            foreach (Song song in _songs)
            {
                if (song.AlbumID == ID)
                {
                    parrant.Nodes.Add(song.Name, song.Name);
                }
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

            int idSong = _songS.ConvertToID(e.Node.Text);
            if (idSong > 0)
            {
                PlaySound playSound = new PlaySound(idSong);
                playSound.Show();
            }
        }
    }
}
