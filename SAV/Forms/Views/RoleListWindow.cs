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
using SAV.BusinessObjects;
using Forms.EditForrms;

namespace Forms.Views
{
    public partial class RoleListWindow : Form
    {
        private RoleService roleService { get; set; }
        private ButtonsValue selectedOperation;
        private Role selectedRole { get; set; } 
        
        public RoleListWindow()
        {
            this.roleService = RoleService.GetInstance();
            this.selectedRole= new Role();

            InitializeComponent();
            InitializeDataGridViewArtist();
        }

        private void InitializeDataGridViewArtist()
        {
            this.dataGridViewRoles.AutoGenerateColumns = false;
            this.dataGridViewRoles.ColumnCount = 4;

            this.dataGridViewRoles.Columns[0].Name = "ID";
            this.dataGridViewRoles.Columns[1].Name = "Code";
            this.dataGridViewRoles.Columns[2].Name = "Name";
            this.dataGridViewRoles.Columns[3].Name = "Description";

            this.dataGridViewRoles.Columns[0].DataPropertyName = "ID";
            this.dataGridViewRoles.Columns[1].DataPropertyName = "Code";
            this.dataGridViewRoles.Columns[2].DataPropertyName = "Name";
            this.dataGridViewRoles.Columns[3].DataPropertyName = "Description";


            List<Role> roles = this.roleService.GetList();
            this.dataGridViewRoles.DataSource = roles;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            this.selectedOperation = ButtonsValue.create;
            this.selectedRole = null;
            startView();
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            this.selectedOperation = ButtonsValue.read;
            startView();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.selectedOperation = ButtonsValue.update;
            startView();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.selectedOperation = ButtonsValue.delete;
            startView();
        }


        private void startView()
        {
            if(this.selectedRole == null && this.selectedOperation != ButtonsValue.create) { this.selectedRole = roleService.FindID(1); }

            EditRoleForms editForm = new EditRoleForms(this.selectedRole, this.selectedOperation);

            DialogResult dialogResult = editForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                switch (selectedOperation)
                {
                    case ButtonsValue.create:
                        this.roleService.SaveRole(new Role(0,editForm.textBoxCode.Text,editForm.textBoxName.Text,editForm.textBoxDescription.Text));   
                        break;
                    case ButtonsValue.update:
                        this.roleService.SaveRole(new Role(selectedRole.Id, editForm.textBoxCode.Text, editForm.textBoxName.Text, editForm.textBoxDescription.Text));
                        break;

                    case ButtonsValue.delete:
                        roleService.Delete(selectedRole);
                        break;
                    default:
                        break;
                }
            }

            List<Role> roles = this.roleService.GetList();
            this.dataGridViewRoles.DataSource = roles;
            this.selectedRole = roleService.FindID(1);

        }

        private void dataGridViewRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                this.selectedRole = roleService.FindID(e.RowIndex+1);
            }
        }
    }
}
