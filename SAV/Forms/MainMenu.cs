using Forms.Media_Player;
using Forms.Views;

namespace Form_menu
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void buttonEditArtist_Click(object sender, EventArgs e)
        {
            ArtistListWindow artistWin = new ArtistListWindow();
            artistWin.Show();
        }

        private void buttonEditAlbum_Click(object sender, EventArgs e)
        {
            AlbumListWindow albumListWindow = new AlbumListWindow();
            albumListWindow.Show();
        }

        private void buttonEditSong_Click(object sender, EventArgs e)
        {
            SongLisWindow songLisWindow = new SongLisWindow();
            songLisWindow.Show();
        }

        private void buttonSongMenu_Click(object sender, EventArgs e)
        {
            SongListViewPlay songListView = new SongListViewPlay();
            songListView.Show();    
        }
    }

}