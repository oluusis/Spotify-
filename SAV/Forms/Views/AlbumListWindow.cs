using SAV.BusinessObjects;
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
using Forms.EditForrms;

namespace Forms.Views
{
    public partial class AlbumListWindow : Form
    {
        private AlbumService albumService { get; set; }
       // private ArtistService _artistService { get; set; }
       
        private char _selected { get; set; }
        private DataGridViewRow _albumRow;

        public AlbumListWindow()
        {
            this.albumService = AlbumService.GetInstance();
            InitializeComponent();
            InitializeDataGridViewArtist();
        }

        private void InitializeDataGridViewArtist()
        {
            this.dataGridViewAlbum.AutoGenerateColumns = false;
            this.dataGridViewAlbum.ColumnCount = 6;

            this.dataGridViewAlbum.Columns[0].Name = "ID";
            this.dataGridViewAlbum.Columns[1].Name = "Title";
            this.dataGridViewAlbum.Columns[2].Name = "Year";
            this.dataGridViewAlbum.Columns[3].Name = "Description";
            this.dataGridViewAlbum.Columns[4].Name = "Image file path";
            this.dataGridViewAlbum.Columns[5].Name = "ID Artist";

            this.dataGridViewAlbum.Columns[0].DataPropertyName = "ID";
            this.dataGridViewAlbum.Columns[1].DataPropertyName = "Title";
            this.dataGridViewAlbum.Columns[2].DataPropertyName = "Year";
            this.dataGridViewAlbum.Columns[3].DataPropertyName = "Description";
            this.dataGridViewAlbum.Columns[4].DataPropertyName = "ImageFile";
            this.dataGridViewAlbum.Columns[5].DataPropertyName = "ArtistID";

            List<Album> albums = this.albumService.GetAlbums();
            this.dataGridViewAlbum.DataSource = albums;
        }




        private void dataGridViewAlbum_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                this._albumRow = this.dataGridViewAlbum.Rows[e.RowIndex];
            }
        }
        private void startView()
        {
            if (_albumRow != null)
            {
                if (_selected == 'c') _albumRow = null;
                EditAlbumForms editForm = new EditAlbumForms(_selected, _albumRow);
                DialogResult dialogResult = editForm.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    switch (_selected)
                    {
                        case 'c':
                            this.albumService.SaveAlbum(new Album(0, editForm.textBoxName.Text, Convert.ToInt32(editForm.textBoxYear.Text), editForm.textBoxDescription.Text, editForm.textBoxImageFile.Text, Convert.ToInt32(editForm.textBoxArtist.Text)));
                            break;
                        case 'u':
                            this.albumService.SaveAlbum(new Album(Convert.ToInt32(_albumRow.Cells[0].Value), editForm.textBoxName.Text, Convert.ToInt32(editForm.textBoxYear.Text), editForm.textBoxDescription.Text, editForm.textBoxImageFile.Text, Convert.ToInt32(editForm.textBoxArtist.Text)));
                            break;
                        case 'd':
                            this.albumService.DeleteAlbum(new Album() { ID = Convert.ToInt32(_albumRow.Cells[0].Value) }); // FK bude blokovat pokud nasamzem vsechny co mají tenhle klíč
                            break;
                        default:
                            break;
                    }
                    this.dataGridViewAlbum.DataSource = null;
                    this._albumRow = null;
                    InitializeDataGridViewArtist();
                }
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            _selected = 'c';
            this._albumRow = this.dataGridViewAlbum.Rows[0];
            startView();
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            _selected = 'r';
            startView();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            _selected = 'u';
            startView();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            _selected = 'd';
            startView();
        }
    }
}
