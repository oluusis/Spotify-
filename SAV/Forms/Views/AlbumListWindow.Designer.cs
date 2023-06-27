namespace Forms.Views
{
    partial class AlbumListWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.dataGridViewAlbum = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(643, 393);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(145, 45);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(425, 393);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(145, 45);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(221, 393);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(145, 45);
            this.buttonRead.TabIndex = 5;
            this.buttonRead.Text = "READ";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(12, 393);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(145, 45);
            this.buttonCreate.TabIndex = 6;
            this.buttonCreate.Text = "CREATE";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // dataGridViewAlbum
            // 
            this.dataGridViewAlbum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlbum.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewAlbum.Name = "dataGridViewAlbum";
            this.dataGridViewAlbum.RowTemplate.Height = 25;
            this.dataGridViewAlbum.Size = new System.Drawing.Size(776, 363);
            this.dataGridViewAlbum.TabIndex = 2;
            this.dataGridViewAlbum.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAlbum_CellClick);
            // 
            // AlbumListWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.dataGridViewAlbum);
            this.Name = "AlbumListWindow";
            this.Text = "Albums";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlbum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonDelete;
        private Button buttonUpdate;
        private Button buttonRead;
        private Button buttonCreate;
        private DataGridView dataGridViewAlbum;
    }
}