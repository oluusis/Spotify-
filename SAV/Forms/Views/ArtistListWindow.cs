using Forms.EditForrms;
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
using static System.ComponentModel.Design.ObjectSelectorEditor;


namespace Form_menu
{
    public partial class ArtistListWindow : Form
    {
        private ArtistService _artistService { get; set; }
        private char _selected { get; set; }
        private DataGridViewRow _artistRow;

        public ArtistListWindow()
        {
            this._artistService = ArtistService.GetInstance();
            InitializeComponent();

            InitializeDataGridViewArtist();
        }

        private void InitializeDataGridViewArtist()
        {
            this.dataGridViewAritists.AutoGenerateColumns = false;
            this.dataGridViewAritists.ColumnCount = 7;

            this.dataGridViewAritists.Columns[0].Name = "ID";
            this.dataGridViewAritists.Columns[1].Name = "Name";
            this.dataGridViewAritists.Columns[2].Name = "Description";
            this.dataGridViewAritists.Columns[3].Name = "Country Code";
            this.dataGridViewAritists.Columns[4].Name = "Active From";
            this.dataGridViewAritists.Columns[5].Name = "Active To";
            this.dataGridViewAritists.Columns[6].Name = "Image File";

            this.dataGridViewAritists.Columns[0].DataPropertyName = "ID";
            this.dataGridViewAritists.Columns[1].DataPropertyName = "Name";
            this.dataGridViewAritists.Columns[2].DataPropertyName = "Description";
            this.dataGridViewAritists.Columns[3].DataPropertyName = "CountryCode";
            this.dataGridViewAritists.Columns[4].DataPropertyName = "ActiveFrom";
            this.dataGridViewAritists.Columns[5].DataPropertyName = "ActiveTo";
            this.dataGridViewAritists.Columns[6].DataPropertyName = "ImageFile";

            List<Artist> artists = this._artistService.GetArtists();
            this.dataGridViewAritists.DataSource = artists;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            _selected = 'c';
            this._artistRow = this.dataGridViewAritists.Rows[0]; 
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

        private void startView()
        {
            if(_artistRow!= null)
            {
                if (_selected == 'c') _artistRow = null;
                EditArtistForms editForm = new EditArtistForms(_selected, _artistRow);
                DialogResult dialogResult = editForm.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    switch (_selected)
                    {
                        case 'c':
                            this._artistService.SaveArtist(new Artist(0,editForm.textBoxName.Text,editForm.textBoxDescription.Text, editForm.textBoxCountryCode.Text,Convert.ToDateTime( editForm.textBoxActiveFrom.Text),Convert.ToDateTime( editForm.textBoxActiveTo.Text), editForm.textBoxImageFile.Text));
                                break;
                        case 'u':
                            this._artistService.SaveArtist(new Artist(Convert.ToInt32(_artistRow.Cells[0].Value), editForm.textBoxName.Text, editForm.textBoxDescription.Text, editForm.textBoxCountryCode.Text, Convert.ToDateTime(editForm.textBoxActiveFrom.Text), Convert.ToDateTime(editForm.textBoxActiveTo.Text), editForm.textBoxImageFile.Text));
                                break;
                        case 'd':
                            this._artistService.DeleteArtist(new Artist() { ID = Convert.ToInt32(_artistRow.Cells[0].Value) }); // nepůjde nám to protože tam je foreign key na objekt který chci smazat
                                break;
                        default:
                            break;
                    }
                    this.dataGridViewAritists.DataSource = null;
                    this._artistRow = null;
                    InitializeDataGridViewArtist();
                }
            }         
        }

        private void dataGridViewAritists_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1 )
            {
                this._artistRow = this.dataGridViewAritists.Rows[e.RowIndex];
            }
        }
    }
}
