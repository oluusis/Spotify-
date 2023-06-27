namespace Forms.EditForrms
{
    partial class EditSongFroms
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
            this.textBoxSongFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelImageFile = new System.Windows.Forms.Label();
            this.labelCC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.numericUpDownDisc = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTrack = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.comboBoxAlbum = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDisc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSongFile
            // 
            this.textBoxSongFile.Location = new System.Drawing.Point(110, 61);
            this.textBoxSongFile.Name = "textBoxSongFile";
            this.textBoxSongFile.Size = new System.Drawing.Size(166, 23);
            this.textBoxSongFile.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "Album:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(110, 24);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(122, 23);
            this.textBoxName.TabIndex = 34;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(157, 250);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 33;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click_1);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(26, 250);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 32;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click_1);
            // 
            // labelImageFile
            // 
            this.labelImageFile.AutoSize = true;
            this.labelImageFile.Location = new System.Drawing.Point(23, 142);
            this.labelImageFile.Name = "labelImageFile";
            this.labelImageFile.Size = new System.Drawing.Size(63, 15);
            this.labelImageFile.TabIndex = 28;
            this.labelImageFile.Text = "TrackNo #:";
            // 
            // labelCC
            // 
            this.labelCC.AutoSize = true;
            this.labelCC.Location = new System.Drawing.Point(40, 107);
            this.labelCC.Name = "labelCC";
            this.labelCC.Size = new System.Drawing.Size(58, 15);
            this.labelCC.TabIndex = 29;
            this.labelCC.Text = "DiscNo #:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Song file:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(47, 27);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(42, 15);
            this.labelName.TabIndex = 31;
            this.labelName.Text = "Name:";
            // 
            // numericUpDownDisc
            // 
            this.numericUpDownDisc.Location = new System.Drawing.Point(110, 105);
            this.numericUpDownDisc.Name = "numericUpDownDisc";
            this.numericUpDownDisc.Size = new System.Drawing.Size(29, 23);
            this.numericUpDownDisc.TabIndex = 40;
            // 
            // numericUpDownTrack
            // 
            this.numericUpDownTrack.Location = new System.Drawing.Point(112, 142);
            this.numericUpDownTrack.Name = "numericUpDownTrack";
            this.numericUpDownTrack.Size = new System.Drawing.Size(27, 23);
            this.numericUpDownTrack.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "Duration:";
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(110, 174);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(100, 23);
            this.textBoxDuration.TabIndex = 43;
            // 
            // comboBoxAlbum
            // 
            this.comboBoxAlbum.FormattingEnabled = true;
            this.comboBoxAlbum.Location = new System.Drawing.Point(110, 209);
            this.comboBoxAlbum.Name = "comboBoxAlbum";
            this.comboBoxAlbum.Size = new System.Drawing.Size(121, 23);
            this.comboBoxAlbum.TabIndex = 44;
            // 
            // EditSongFroms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 291);
            this.Controls.Add(this.comboBoxAlbum);
            this.Controls.Add(this.textBoxDuration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownTrack);
            this.Controls.Add(this.numericUpDownDisc);
            this.Controls.Add(this.textBoxSongFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelImageFile);
            this.Controls.Add(this.labelCC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelName);
            this.Name = "EditSongFroms";
            this.Text = "EditSongFroms";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDisc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public TextBox textBoxSongFile;
        private Label label1;
        public TextBox textBoxName;
        private Button buttonCancel;
        private Button buttonOK;
        private Label labelImageFile;
        private Label labelCC;
        private Label label2;
        private Label labelName;
        public NumericUpDown numericUpDownDisc;
        public NumericUpDown numericUpDownTrack;
        private Label label3;
        public TextBox textBoxDuration;
        public ComboBox comboBoxAlbum;
    }
}