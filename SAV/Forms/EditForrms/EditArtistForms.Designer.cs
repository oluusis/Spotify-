namespace Forms.EditForrms
{
    partial class EditArtistForms
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
            this.labelName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCC = new System.Windows.Forms.Label();
            this.labelAF = new System.Windows.Forms.Label();
            this.labelAT = new System.Windows.Forms.Label();
            this.labelImageFile = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCountryCode = new System.Windows.Forms.TextBox();
            this.textBoxActiveFrom = new System.Windows.Forms.TextBox();
            this.textBoxActiveTo = new System.Windows.Forms.TextBox();
            this.textBoxImageFile = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(39, 33);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(42, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description:";
            // 
            // labelCC
            // 
            this.labelCC.AutoSize = true;
            this.labelCC.Location = new System.Drawing.Point(15, 136);
            this.labelCC.Name = "labelCC";
            this.labelCC.Size = new System.Drawing.Size(82, 15);
            this.labelCC.TabIndex = 0;
            this.labelCC.Text = "Country code:";
            // 
            // labelAF
            // 
            this.labelAF.AutoSize = true;
            this.labelAF.Location = new System.Drawing.Point(22, 171);
            this.labelAF.Name = "labelAF";
            this.labelAF.Size = new System.Drawing.Size(72, 15);
            this.labelAF.TabIndex = 0;
            this.labelAF.Text = "Active from:";
            // 
            // labelAT
            // 
            this.labelAT.AutoSize = true;
            this.labelAT.Location = new System.Drawing.Point(37, 212);
            this.labelAT.Name = "labelAT";
            this.labelAT.Size = new System.Drawing.Size(57, 15);
            this.labelAT.TabIndex = 0;
            this.labelAT.Text = "Active to:";
            // 
            // labelImageFile
            // 
            this.labelImageFile.AutoSize = true;
            this.labelImageFile.Location = new System.Drawing.Point(32, 258);
            this.labelImageFile.Name = "labelImageFile";
            this.labelImageFile.Size = new System.Drawing.Size(62, 15);
            this.labelImageFile.TabIndex = 0;
            this.labelImageFile.Text = "Image file:";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(48, 326);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(179, 326);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(102, 30);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(152, 23);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxCountryCode
            // 
            this.textBoxCountryCode.Location = new System.Drawing.Point(106, 133);
            this.textBoxCountryCode.Name = "textBoxCountryCode";
            this.textBoxCountryCode.Size = new System.Drawing.Size(110, 23);
            this.textBoxCountryCode.TabIndex = 4;
            // 
            // textBoxActiveFrom
            // 
            this.textBoxActiveFrom.Location = new System.Drawing.Point(106, 171);
            this.textBoxActiveFrom.Name = "textBoxActiveFrom";
            this.textBoxActiveFrom.Size = new System.Drawing.Size(48, 23);
            this.textBoxActiveFrom.TabIndex = 5;
            // 
            // textBoxActiveTo
            // 
            this.textBoxActiveTo.Location = new System.Drawing.Point(106, 209);
            this.textBoxActiveTo.Name = "textBoxActiveTo";
            this.textBoxActiveTo.Size = new System.Drawing.Size(48, 23);
            this.textBoxActiveTo.TabIndex = 6;
            // 
            // textBoxImageFile
            // 
            this.textBoxImageFile.Location = new System.Drawing.Point(106, 258);
            this.textBoxImageFile.Name = "textBoxImageFile";
            this.textBoxImageFile.Size = new System.Drawing.Size(165, 23);
            this.textBoxImageFile.TabIndex = 7;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(102, 62);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(100, 23);
            this.textBoxDescription.TabIndex = 8;
            // 
            // EditArtistForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 374);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxImageFile);
            this.Controls.Add(this.textBoxActiveTo);
            this.Controls.Add(this.textBoxActiveFrom);
            this.Controls.Add(this.textBoxCountryCode);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelImageFile);
            this.Controls.Add(this.labelAT);
            this.Controls.Add(this.labelAF);
            this.Controls.Add(this.labelCC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelName);
            this.Name = "EditArtistForms";
            this.Text = "EditArtistForms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelName;
        private Label label2;
        private Label labelCC;
        private Label labelAF;
        private Label labelAT;
        private Label labelImageFile;
        private Button buttonOK;
        private Button buttonCancel;
        public TextBox textBoxName;
        public TextBox textBoxCountryCode;
        public TextBox textBoxActiveFrom;
        public TextBox textBoxActiveTo;
        public TextBox textBoxImageFile;
        public TextBox textBoxDescription;
    }
}