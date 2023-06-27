using Forms.Views;
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

namespace Forms.EditForrms
{
    public partial class EditRoleForms : Form
    {
        public Role Role { get; set; }

        public EditRoleForms(Role role, ButtonsValue btn)
        {
            this.Role = role;
            InitializeComponent();
            if(btn != ButtonsValue.create)
            {
                FillTextBoxes();
            }          
        }

        private void FillTextBoxes()
        {
            this.textBoxCode.Text = this.Role.Code;
            this.textBoxDescription.Text = this.Role.Description;
            this.textBoxName.Text = this.Role.Name;
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
