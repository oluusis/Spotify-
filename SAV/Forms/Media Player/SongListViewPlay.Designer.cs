namespace Forms.Media_Player
{
    partial class SongListViewPlay
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
            treeView = new TreeView();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            SuspendLayout();
            // 
            // treeView
            // 
            treeView.Location = new Point(12, 12);
            treeView.Name = "treeView";
            treeView.Size = new Size(334, 369);
            treeView.TabIndex = 1;
            treeView.AfterSelect += treeView_AfterSelect;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // SongListViewPlay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 403);
            Controls.Add(treeView);
            Name = "SongListViewPlay";
            Text = "SongListViewPlay";
            ResumeLayout(false);
        }

        #endregion
        private TreeView treeView;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}