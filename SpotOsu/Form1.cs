using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using System.Threading;

namespace SpotOsu
{
    public partial class Form1 : Form
    {
        MainFrame mf;
        public Form1()
        {
            InitializeComponent();
            txtOsuPath.Text = $@"C:\Users\{Environment.UserName}\AppData\Local\osu!\" ;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            lstCollections.Items.Clear();
            string osuPath = txtOsuPath.Text;
            mf = new MainFrame(osuPath);
            lstCollections.Items.Add("All");
            foreach (var each in mf.collections_db.Collections)
            {
                lstCollections.Items.Add(each.Name);
            }
        }

        private void lstCollections_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // Get the currently selected item in the ListBox.
            string currentCollection = lstCollections.SelectedItem.ToString();
            var songs = mf.GetCollectionBeatmaps(currentCollection).GroupBy( x=> x.title).Select( x=> x.First());
            lstSongs.Items.Clear();
            lstPlaylist.Items.Clear();

            foreach(var song in songs)
            {
                lstSongs.Items.Add( song.ToListBoxString() );
                lstPlaylist.Items.Add( song.ToListBoxString() );
            }
        }

        private void btnCreatePlaylist_Click(object sender, EventArgs e)
        {
            
            string token = txtSpotifyClient.Text;
            string playlistName = txtPlaylistName.Text;
            if (token == string.Empty)
            {
                MessageBox.Show("Token is empty");
                return;
            }
            if (playlistName == string.Empty)
            {
                playlistName = "New osu! playlist";
            }
            btnCreatePlaylist.Enabled = false;
            var items = lstPlaylist.Items.Cast<String>();
            lblCurrentStatus.Text = "Working...\nPlease wait.";
            //Thread aux = new Thread( () => { mf.CreatePlaylist(token, playlistName, items); /*CreationCompleted()*/;} );
            lblCurrentStatus.Invoke((MethodInvoker)(() => { mf.CreatePlaylist(token, playlistName, items); CreationCompleted(); }));
            //aux.IsBackground = true;
            //aux.Start();

        }

        //Not working from other thread
        private void CreationCompleted()
        {
            btnCreatePlaylist.Enabled = true;
            lblCurrentStatus.Text = "Completed";
        }

        private void lstPlaylist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var item = lstPlaylist.SelectedItem;
            lstPlaylist.Items.Remove(item);
           
        }

        private void lstSongs__MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var item = lstSongs.SelectedItem;
            var found = lstPlaylist.Items.Contains(item);
            if (!found)
                lstPlaylist.Items.Add(item);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Developed by: Bordex\nOsu profile: https://osu.ppy.sh/u/4887459 \nTwitter: https://twitter.com/vicbordex \n\n Check for Updates: https://github.com/ByBordex/SpotOsu/releases");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ByBordex/SpotOsu/blob/master/README.md");
        }
    }
}
