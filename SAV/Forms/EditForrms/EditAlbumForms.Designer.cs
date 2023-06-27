namespace Forms.EditForrms
{
    partial class EditAlbumForms
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelImageFile = new System.Windows.Forms.Label();
            this.labelCC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxImageFile = new System.Windows.Forms.TextBox();
            this.textBoxArtist = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(111, 32);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(152, 23);
            this.textBoxName.TabIndex = 17;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(158, 258);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(27, 258);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 15;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelImageFile
            // 
            this.labelImageFile.AutoSize = true;
            this.labelImageFile.Location = new System.Drawing.Point(24, 150);
            this.labelImageFile.Name = "labelImageFile";
            this.labelImageFile.Size = new System.Drawing.Size(62, 15);
            this.labelImageFile.TabIndex = 9;
            this.labelImageFile.Text = "Image file:";
            // 
            // labelCC
            // 
            this.labelCC.AutoSize = true;
            this.labelCC.Location = new System.Drawing.Point(41, 115);
            this.labelCC.Name = "labelCC";
            this.labelCC.Size = new System.Drawing.Size(32, 15);
            this.labelCC.TabIndex = 12;
            this.labelCC.Text = "Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Description:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(48, 35);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(42, 15);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Artist:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(111, 69);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(100, 23);
            this.textBoxDescription.TabIndex = 24;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(111, 112);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(100, 23);
            this.textBoxYear.TabIndex = 25;
            // 
            // textBoxImageFile
            // 
            this.textBoxImageFile.Location = new System.Drawing.Point(111, 150);
            this.textBoxImageFile.Name = "textBoxImageFile";
            this.textBoxImageFile.Size = new System.Drawing.Size(100, 23);
            this.textBoxImageFile.TabIndex = 26;
            // 
            // textBoxArtist
            // 
            this.textBoxArtist.Location = new System.Drawing.Point(111, 191);
            this.textBoxArtist.Name = "textBoxArtist";
            this.textBoxArtist.Size = new System.Drawing.Size(100, 23);
            this.textBoxArtist.TabIndex = 27;
            // 
            // EditAlbumForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 295);
            this.Controls.Add(this.textBoxArtist);
            this.Controls.Add(this.textBoxImageFile);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelImageFile);
            this.Controls.Add(this.labelCC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelName);
            this.Name = "EditAlbumForms";
            this.Text = "EditAlbumForms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public TextBox textBoxName;
        private Button buttonCancel;
        private Button buttonOK;
        private Label labelImageFile;
        private Label labelCC;
        private Label label2;
        private Label labelName;
        private Label label1;
        public TextBox textBoxDescription;
        public TextBox textBoxYear;
        public TextBox textBoxImageFile;
        public TextBox textBoxArtist;
    }
}