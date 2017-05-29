using System.Windows.Forms;

namespace SpotOsu
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblSpotifyClientID = new System.Windows.Forms.Label();
            this.txtSpotifyClient = new System.Windows.Forms.TextBox();
            this.txtPlaylistName = new System.Windows.Forms.TextBox();
            this.lblPlaylistName = new System.Windows.Forms.Label();
            this.btnCreatePlaylist = new System.Windows.Forms.Button();
            this.lblOsuPath = new System.Windows.Forms.Label();
            this.txtOsuPath = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lstCollections = new System.Windows.Forms.ListBox();
            this.lstSongs = new System.Windows.Forms.ListBox();
            this.lstPlaylist = new System.Windows.Forms.ListBox();
            this.lblCurrentStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSpotifyClientID
            // 
            this.lblSpotifyClientID.AutoSize = true;
            this.lblSpotifyClientID.Location = new System.Drawing.Point(37, 314);
            this.lblSpotifyClientID.Name = "lblSpotifyClientID";
            this.lblSpotifyClientID.Size = new System.Drawing.Size(82, 13);
            this.lblSpotifyClientID.TabIndex = 0;
            this.lblSpotifyClientID.Text = "Spotify ClientID:";
            // 
            // txtSpotifyClient
            // 
            this.txtSpotifyClient.Location = new System.Drawing.Point(125, 311);
            this.txtSpotifyClient.Name = "txtSpotifyClient";
            this.txtSpotifyClient.Size = new System.Drawing.Size(239, 20);
            this.txtSpotifyClient.TabIndex = 1;
            // 
            // txtPlaylistName
            // 
            this.txtPlaylistName.Location = new System.Drawing.Point(125, 337);
            this.txtPlaylistName.Name = "txtPlaylistName";
            this.txtPlaylistName.Size = new System.Drawing.Size(239, 20);
            this.txtPlaylistName.TabIndex = 3;
            // 
            // lblPlaylistName
            // 
            this.lblPlaylistName.AutoSize = true;
            this.lblPlaylistName.Location = new System.Drawing.Point(46, 340);
            this.lblPlaylistName.Name = "lblPlaylistName";
            this.lblPlaylistName.Size = new System.Drawing.Size(73, 13);
            this.lblPlaylistName.TabIndex = 2;
            this.lblPlaylistName.Text = "Playlist Name:";
            // 
            // btnCreatePlaylist
            // 
            this.btnCreatePlaylist.Location = new System.Drawing.Point(370, 309);
            this.btnCreatePlaylist.Name = "btnCreatePlaylist";
            this.btnCreatePlaylist.Size = new System.Drawing.Size(91, 48);
            this.btnCreatePlaylist.TabIndex = 4;
            this.btnCreatePlaylist.Text = "Create Playlist";
            this.btnCreatePlaylist.UseVisualStyleBackColor = true;
            this.btnCreatePlaylist.Click += new System.EventHandler(this.btnCreatePlaylist_Click);
            // 
            // lblOsuPath
            // 
            this.lblOsuPath.AutoSize = true;
            this.lblOsuPath.Location = new System.Drawing.Point(137, 28);
            this.lblOsuPath.Name = "lblOsuPath";
            this.lblOsuPath.Size = new System.Drawing.Size(55, 13);
            this.lblOsuPath.TabIndex = 5;
            this.lblOsuPath.Text = "osu! Path:";
            // 
            // txtOsuPath
            // 
            this.txtOsuPath.Location = new System.Drawing.Point(198, 25);
            this.txtOsuPath.Name = "txtOsuPath";
            this.txtOsuPath.Size = new System.Drawing.Size(239, 20);
            this.txtOsuPath.TabIndex = 6;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(453, 23);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lstCollections
            // 
            this.lstCollections.FormattingEnabled = true;
            this.lstCollections.Location = new System.Drawing.Point(13, 65);
            this.lstCollections.Name = "lstCollections";
            this.lstCollections.Size = new System.Drawing.Size(180, 225);
            this.lstCollections.TabIndex = 8;
            this.lstCollections.SelectedIndexChanged += new System.EventHandler(this.lstCollections_SelectedIndexChanged);
            // 
            // lstSongs
            // 
            this.lstSongs.FormattingEnabled = true;
            this.lstSongs.Location = new System.Drawing.Point(226, 65);
            this.lstSongs.Name = "lstSongs";
            this.lstSongs.Size = new System.Drawing.Size(180, 225);
            this.lstSongs.TabIndex = 9;
            this.lstSongs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstSongs__MouseDoubleClick);
            // 
            // lstPlaylist
            // 
            this.lstPlaylist.FormattingEnabled = true;
            this.lstPlaylist.Location = new System.Drawing.Point(436, 65);
            this.lstPlaylist.Name = "lstPlaylist";
            this.lstPlaylist.Size = new System.Drawing.Size(180, 225);
            this.lstPlaylist.TabIndex = 10;
            this.lstPlaylist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstPlaylist_MouseDoubleClick);
            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.AutoSize = true;
            this.lblCurrentStatus.Location = new System.Drawing.Point(16, 20);
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new System.Drawing.Size(40, 13);
            this.lblCurrentStatus.TabIndex = 12;
            this.lblCurrentStatus.Text = "Chilling";
            this.lblCurrentStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCurrentStatus);
            this.groupBox1.Location = new System.Drawing.Point(483, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(84, 50);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Text = "Menu";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.otherToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(628, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.fileToolStripMenuItem.Text = "App";
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.otherToolStripMenuItem.Text = "Other";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 369);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstPlaylist);
            this.Controls.Add(this.lstSongs);
            this.Controls.Add(this.lstCollections);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtOsuPath);
            this.Controls.Add(this.lblOsuPath);
            this.Controls.Add(this.btnCreatePlaylist);
            this.Controls.Add(this.txtPlaylistName);
            this.Controls.Add(this.lblPlaylistName);
            this.Controls.Add(this.txtSpotifyClient);
            this.Controls.Add(this.lblSpotifyClientID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SpotOsu!";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSpotifyClientID;
        private System.Windows.Forms.TextBox txtSpotifyClient;
        private System.Windows.Forms.TextBox txtPlaylistName;
        private System.Windows.Forms.Label lblPlaylistName;
        private System.Windows.Forms.Button btnCreatePlaylist;
        private System.Windows.Forms.Label lblOsuPath;
        private System.Windows.Forms.TextBox txtOsuPath;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ListBox lstCollections;
        private System.Windows.Forms.ListBox lstSongs;
        private System.Windows.Forms.ListBox lstPlaylist;
        private Label lblCurrentStatus;
        private GroupBox groupBox1;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem otherToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
    }
}

