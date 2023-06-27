using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms.EditForrms
{
    public partial class EditArtistForms : Form
    {
        private char _selected { get; set; }
        private DataGridViewRow _dataGridViewRow;


        public EditArtistForms(char selected,DataGridViewRow dataGridViewRow)
        {
            this._dataGridViewRow = dataGridViewRow;
            this._selected = selected;
            InitializeComponent();
            SetValues();
        }

        public void SetValues()
        {
            if(_dataGridViewRow != null)
            {
                this.textBoxName.Text = _dataGridViewRow.Cells[1].Value.ToString();
                this.textBoxDescription.Text = _dataGridViewRow.Cells[2].Value.ToString();
                this.textBoxCountryCode.Text = _dataGridViewRow.Cells[3].Value.ToString();
                this.textBoxActiveFrom.Text = _dataGridViewRow.Cells[4].Value.ToString();
                this.textBoxActiveTo.Text = _dataGridViewRow.Cells[5].Value.ToString();
                this.textBoxImageFile.Text = _dataGridViewRow.Cells[6].Value.ToString();

                if(textBoxActiveFrom.Text == "")
                {
                    textBoxActiveFrom.Text = null;
                }
                if(textBoxActiveTo.Text == "")
                {
                    textBoxActiveTo.Text = null;
                }
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; 
            this.Close();   
        }
    }
}
