using SAV.Repos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAV.Services;
using SAV.BusinessObjects;
using Forms.EditForrms;

namespace Forms.Views
{
    public partial class SongLisWindow : Form
    {
        private SongService songService { get; set; }
        private char _selected { get; set; }
        private DataGridViewRow _songRow;

        public SongLisWindow()
        {
            this.songService = SongService.GetInstance();
            InitializeComponent();

            InitializeDataGridViewArtist();

        }

        private void InitializeDataGridViewArtist()
        {
            this.dataGridViewSongs.AutoGenerateColumns = false;
            this.dataGridViewSongs.ColumnCount = 7;

            this.dataGridViewSongs.Columns[0].Name = "ID";
            this.dataGridViewSongs.Columns[1].Name = "Name";
            this.dataGridViewSongs.Columns[2].Name = "Song file path";
            this.dataGridViewSongs.Columns[3].Name = "DiscNo";
            this.dataGridViewSongs.Columns[4].Name = "TrackNo";
            this.dataGridViewSongs.Columns[5].Name = "Duration";
            this.dataGridViewSongs.Columns[6].Name = "Album ID";


            this.dataGridViewSongs.Columns[0].DataPropertyName = "ID";
            this.dataGridViewSongs.Columns[1].DataPropertyName= "Name";
            this.dataGridViewSongs.Columns[2].DataPropertyName = "SongFile";
            this.dataGridViewSongs.Columns[3].DataPropertyName = "DiscNo";
            this.dataGridViewSongs.Columns[4].DataPropertyName = "TrackNo";
            this.dataGridViewSongs.Columns[5].DataPropertyName = "Duration";
            this.dataGridViewSongs.Columns[6].DataPropertyName = "AlbumID";


            List<Song> songs = this.songService.GetSongs();
            this.dataGridViewSongs.DataSource = songs;
        }

        private void startView()
        {
            if (_songRow != null)
            {
                if (_selected == 'c') _songRow = null;
                EditSongFroms editForm = new EditSongFroms(_selected, _songRow);
                
                DialogResult dialogResult = editForm.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    switch (_selected)
                    {
                        case 'c':
                            this.songService.SaveSong(new Song(0, editForm.textBoxName.Text,editForm.textBoxSongFile.Text,Convert.ToInt32(editForm.numericUpDownDisc.Value),Convert.ToInt32(editForm.numericUpDownTrack.Value),Convert.ToDouble(editForm.textBoxDuration.Text),Convert.ToInt32(editForm.comboBoxAlbum.SelectedIndex)+1));
                            break;
                        case 'u':
                            this.songService.SaveSong(new Song(Convert.ToInt32(_songRow.Cells[0].Value), editForm.textBoxName.Text, editForm.textBoxSongFile.Text, Convert.ToInt32(editForm.numericUpDownDisc.Value), Convert.ToInt32(editForm.numericUpDownTrack.Value), Convert.ToDouble(editForm.textBoxDuration.Text), Convert.ToInt32(editForm.comboBoxAlbum.SelectedIndex)+1));
                            break;
                        case 'd':
                            this.songService.DeleteSong(new Song() { ID = Convert.ToInt32(_songRow.Cells[0].Value) });
                            break;
                        default:
                            break;
                    }
                    this.dataGridViewSongs.DataSource = null;
                    this._songRow = null;
                    InitializeDataGridViewArtist();
                }
            }
        }

        private void dataGridViewAritists_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                this._songRow = this.dataGridViewSongs.Rows[e.RowIndex];
            }
        }

        private void buttonCreate_Click_1(object sender, EventArgs e)
        {
            _selected = 'c';
            this._songRow = this.dataGridViewSongs.Rows[0];
            startView();
        }

        private void buttonRead_Click_1(object sender, EventArgs e)
        {
            _selected = 'r';
            startView();
        }

        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
            _selected = 'u';
            startView();
        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            _selected = 'd';
            startView();
        }
    }
}
