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

namespace Forms.EditForrms
{
    public partial class EditSongFroms : Form
    {
        private char _selected { get; set; }
        private DataGridViewRow _dataGridViewRow;

        private AlbumService _albumService;

        public EditSongFroms(char selected,DataGridViewRow dataGridViewRow)
        {
            InitializeComponent();
            this._dataGridViewRow = dataGridViewRow;
            this._selected = selected;
            this._albumService= new AlbumService();
            SetValues();
        }

        public void SetValues()
        {
            this.comboBoxAlbum.DataSource = _albumService.GetAlbums();
            this.comboBoxAlbum.ValueMember = "Title";

            if (_dataGridViewRow != null)
            {

                this.textBoxName.Text = _dataGridViewRow.Cells[1].Value.ToString();
                this.textBoxSongFile.Text = _dataGridViewRow.Cells[2].Value.ToString();
                this.numericUpDownDisc.Text = _dataGridViewRow.Cells[3].Value.ToString();
                this.numericUpDownTrack.Text = _dataGridViewRow.Cells[4].Value.ToString();
                this.textBoxDuration.Text = _dataGridViewRow.Cells[5].Value.ToString();
                this.comboBoxAlbum.SelectedItem = _albumService.FindId( Convert.ToInt32(_dataGridViewRow.Cells[6].Value));
                
               
                
            }
        }

        private void buttonOK_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
