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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCollections = new System.Windows.Forms.Label();
            this.lblSongs = new System.Windows.Forms.Label();
            this.lblPlaylsitSongs = new System.Windows.Forms.Label();
            this.btnChangeMode = new System.Windows.Forms.Button();
            this.lblSongName = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTags = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSpotifyClientID
            // 
            this.lblSpotifyClientID.AutoSize = true;
            this.lblSpotifyClientID.Location = new System.Drawing.Point(103, 314);
            this.lblSpotifyClientID.Name = "lblSpotifyClientID";
            this.lblSpotifyClientID.Size = new System.Drawing.Size(82, 13);
            this.lblSpotifyClientID.TabIndex = 0;
            this.lblSpotifyClientID.Text = "Spotify ClientID:";
            // 
            // txtSpotifyClient
            // 
            this.txtSpotifyClient.Location = new System.Drawing.Point(191, 311);
            this.txtSpotifyClient.Name = "txtSpotifyClient";
            this.txtSpotifyClient.Size = new System.Drawing.Size(239, 20);
            this.txtSpotifyClient.TabIndex = 1;
            // 
            // txtPlaylistName
            // 
            this.txtPlaylistName.Location = new System.Drawing.Point(191, 337);
            this.txtPlaylistName.Name = "txtPlaylistName";
            this.txtPlaylistName.Size = new System.Drawing.Size(239, 20);
            this.txtPlaylistName.TabIndex = 3;
            // 
            // lblPlaylistName
            // 
            this.lblPlaylistName.AutoSize = true;
            this.lblPlaylistName.Location = new System.Drawing.Point(112, 340);
            this.lblPlaylistName.Name = "lblPlaylistName";
            this.lblPlaylistName.Size = new System.Drawing.Size(73, 13);
            this.lblPlaylistName.TabIndex = 2;
            this.lblPlaylistName.Text = "Playlist Name:";
            // 
            // btnCreatePlaylist
            // 
            this.btnCreatePlaylist.Location = new System.Drawing.Point(436, 309);
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
            this.lstCollections.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
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
            this.lstPlaylist.SelectedIndexChanged += new System.EventHandler(this.lstPlaylist_SelectedIndexChanged);
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
            this.groupBox1.Location = new System.Drawing.Point(536, 307);
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
            this.menuStrip1.Size = new System.Drawing.Size(855, 24);
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
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            // 
            // lblCollections
            // 
            this.lblCollections.AutoSize = true;
            this.lblCollections.Location = new System.Drawing.Point(14, 47);
            this.lblCollections.Name = "lblCollections";
            this.lblCollections.Size = new System.Drawing.Size(61, 13);
            this.lblCollections.TabIndex = 17;
            this.lblCollections.Text = "Collections:";
            // 
            // lblSongs
            // 
            this.lblSongs.AutoSize = true;
            this.lblSongs.Location = new System.Drawing.Point(223, 49);
            this.lblSongs.Name = "lblSongs";
            this.lblSongs.Size = new System.Drawing.Size(87, 13);
            this.lblSongs.TabIndex = 18;
            this.lblSongs.Text = "Collection songs:";
            // 
            // lblPlaylsitSongs
            // 
            this.lblPlaylsitSongs.AutoSize = true;
            this.lblPlaylsitSongs.Location = new System.Drawing.Point(441, 49);
            this.lblPlaylsitSongs.Name = "lblPlaylsitSongs";
            this.lblPlaylsitSongs.Size = new System.Drawing.Size(73, 13);
            this.lblPlaylsitSongs.TabIndex = 19;
            this.lblPlaylsitSongs.Text = "Playlist songs:";
            // 
            // btnChangeMode
            // 
            this.btnChangeMode.Location = new System.Drawing.Point(17, 309);
            this.btnChangeMode.Name = "btnChangeMode";
            this.btnChangeMode.Size = new System.Drawing.Size(80, 48);
            this.btnChangeMode.TabIndex = 20;
            this.btnChangeMode.Text = "SoundCloud Mode";
            this.btnChangeMode.UseVisualStyleBackColor = true;
            this.btnChangeMode.Click += new System.EventHandler(this.btnChangeMode_Click);
            // 
            // lblSongName
            // 
            this.lblSongName.AutoSize = true;
            this.lblSongName.Location = new System.Drawing.Point(634, 270);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(0, 13);
            this.lblSongName.TabIndex = 21;
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(634, 290);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(0, 13);
            this.lblArtist.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(634, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // lblTags
            // 
            this.lblTags.AutoSize = true;
            this.lblTags.Location = new System.Drawing.Point(634, 310);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(0, 13);
            this.lblTags.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 369);
            this.Controls.Add(this.lblTags);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.lblSongName);
            this.Controls.Add(this.btnChangeMode);
            this.Controls.Add(this.lblPlaylsitSongs);
            this.Controls.Add(this.lblSongs);
            this.Controls.Add(this.lblCollections);
            this.Controls.Add(this.label1);
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
            this.Text = "SpotOsu! v0.3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private Label label1;
        private Label lblCollections;
        private Label lblSongs;
        private Label lblPlaylsitSongs;
        private Button btnChangeMode;
        private Label lblSongName;
        private Label lblArtist;
        private PictureBox pictureBox1;
        private Label lblTags;
    }
}

