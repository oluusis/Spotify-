namespace Form_menu
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSongMenu = new System.Windows.Forms.Button();
            this.buttonEditArtist = new System.Windows.Forms.Button();
            this.buttonEditAlbum = new System.Windows.Forms.Button();
            this.buttonEditSong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSongMenu
            // 
            this.buttonSongMenu.Location = new System.Drawing.Point(12, 12);
            this.buttonSongMenu.Name = "buttonSongMenu";
            this.buttonSongMenu.Size = new System.Drawing.Size(429, 69);
            this.buttonSongMenu.TabIndex = 0;
            this.buttonSongMenu.Text = "SONG MENU";
            this.buttonSongMenu.UseVisualStyleBackColor = true;
            this.buttonSongMenu.Click += new System.EventHandler(this.buttonSongMenu_Click);
            // 
            // buttonEditArtist
            // 
            this.buttonEditArtist.Location = new System.Drawing.Point(12, 87);
            this.buttonEditArtist.Name = "buttonEditArtist";
            this.buttonEditArtist.Size = new System.Drawing.Size(139, 75);
            this.buttonEditArtist.TabIndex = 1;
            this.buttonEditArtist.Text = "EDIT ARTISTS";
            this.buttonEditArtist.UseVisualStyleBackColor = true;
            this.buttonEditArtist.Click += new System.EventHandler(this.buttonEditArtist_Click);
            // 
            // buttonEditAlbum
            // 
            this.buttonEditAlbum.Location = new System.Drawing.Point(157, 87);
            this.buttonEditAlbum.Name = "buttonEditAlbum";
            this.buttonEditAlbum.Size = new System.Drawing.Size(139, 75);
            this.buttonEditAlbum.TabIndex = 2;
            this.buttonEditAlbum.Text = "EDIT ALBUMS";
            this.buttonEditAlbum.UseVisualStyleBackColor = true;
            this.buttonEditAlbum.Click += new System.EventHandler(this.buttonEditAlbum_Click);
            // 
            // buttonEditSong
            // 
            this.buttonEditSong.Location = new System.Drawing.Point(302, 87);
            this.buttonEditSong.Name = "buttonEditSong";
            this.buttonEditSong.Size = new System.Drawing.Size(139, 75);
            this.buttonEditSong.TabIndex = 3;
            this.buttonEditSong.Text = "EDIT SONGS";
            this.buttonEditSong.UseVisualStyleBackColor = true;
            this.buttonEditSong.Click += new System.EventHandler(this.buttonEditSong_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 165);
            this.Controls.Add(this.buttonEditSong);
            this.Controls.Add(this.buttonEditAlbum);
            this.Controls.Add(this.buttonEditArtist);
            this.Controls.Add(this.buttonSongMenu);
            this.Name = "MainMenu";
            this.Text = "MAIN MENU";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonSongMenu;
        private Button buttonEditArtist;
        private Button buttonEditAlbum;
        private Button buttonEditSong;
    }
}