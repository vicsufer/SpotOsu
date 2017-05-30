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
using System.IO;

namespace SpotOsu
{
    public partial class Form1 : Form
    {
        enum Mode { SOUNDCLOUD, SPOTIFY};
        Mode currentMode;
        MainFrame mf;

        public Form1()
        {
            InitializeComponent();
            txtOsuPath.Text = $@"C:\Users\{Environment.UserName}\AppData\Local\osu!\" ;
            ChangeMode(Mode.SPOTIFY);
            btnChangeMode.Enabled = false;
        }
       
        private void ChangeMode(Mode mode)
        {
            switch (mode)
            {
                case Mode.SOUNDCLOUD:
                    lblSpotifyClientID.Visible = false;
                    txtSpotifyClient.Visible = false;
                    btnChangeMode.Text = "Spotify Mode";                
                    currentMode = Mode.SOUNDCLOUD;
                    break;

                case Mode.SPOTIFY:
                    lblSpotifyClientID.Visible = true;
                    txtSpotifyClient.Visible = true;
                    btnChangeMode.Text = "SoundCloud Mode";
                    currentMode = Mode.SPOTIFY;
                    break;
            }
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
            lstSongs.Items.Clear();
            lstPlaylist.Items.Clear();

            if (lstCollections.SelectedItems.Count == 0)
                return;
            var strings = lstCollections.SelectedItems.Cast<string>();

            List<BeatmapLittle> tracks = new List<BeatmapLittle>();
            foreach (var s in strings)
            {
                var aux = mf.GetCollectionBeatmaps(s);
                foreach (var each in aux)
                {
                    tracks.Add(each);
                }
            }
            var tracks2 = tracks.GroupBy( x => x.title).Select( x=>x.First() ).OrderBy(x=> x.title);

            foreach(var song in tracks2)
            {
                lstSongs.Items.Add( song.ToListBoxString() );
                lstPlaylist.Items.Add( song.ToListBoxString() );
            }
        }

        private async Task CreateSpotifyPlaylistAsync(IEnumerable<string> songs)
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
            
            lblCurrentStatus.Text = "Working...\nPlease wait.";

            try
            {
                int numberOfSongs = await mf.CreateSpotifyPlaylistAsync(token, playlistName, songs);
                MessageBox.Show("Playlist Created with: "+numberOfSongs+" songs");
                lblCurrentStatus.Text = "Completed";
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);
                lblCurrentStatus.Text = "Error";
            }

            return;
        }

        private async void btnCreatePlaylist_Click(object sender, EventArgs e)
        {
            var items = lstPlaylist.Items.Cast<string>();

            var split = items.Select(x => x.Split(new char[] { ':' }, 2)[1] );
            
            switch (currentMode)
            {
                case Mode.SPOTIFY:
                    await CreateSpotifyPlaylistAsync(split);
                    break;
                case Mode.SOUNDCLOUD:
                    break;
            }
            btnCreatePlaylist.Enabled = true;

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
            //MessageBox.Show(this, "Developed by: Bordex\nOsu profile: https://osu.ppy.sh/u/4887459 \nTwitter: https://twitter.com/vicbordex \n\n Check for Updates: https://github.com/ByBordex/SpotOsu/releases");
            List<List<String>> labels = new List<List<string>>();
            var l1 = new List<string>(); l1.Add("Developed by: Bordex");
                l1.Add("https://osu.ppy.sh/u/4887459 ");
            var l2 = new List<string>(); l2.Add("Check for Updates:");
                l2.Add("https://github.com/ByBordex/SpotOsu/releases ");
            labels.Add(l1); labels.Add(l2);
            new FormLinkable(labels).Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<List<String>> labels = new List<List<string>>();
            var l1 = new List<string>(); l1.Add("Usage guide");
            //l1.Add("https://github.com/ByBordex/SpotOsu/blob/master/README.md ");
            new FormLinkable(labels).Show();
        }

        private void btnChangeMode_Click(object sender, EventArgs e)
        {
            if (currentMode == Mode.SPOTIFY)
                ChangeMode(Mode.SOUNDCLOUD);
            else
                ChangeMode(Mode.SPOTIFY);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lstPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPlaylist.SelectedItems.Cast<string>().Count() == 0)
            {
                return;
            }
            var name = lstPlaylist.SelectedItem.ToString();
            var split = name.Split('-',':');
            var set_id = int.Parse(split[0]);

            string osuFolder = txtOsuPath.Text;

            var bm = mf.GetBeatmapsBySetIDList(new int[] { set_id }).First() ;
            lblSongName.Text = "Title: " + bm.title;
            lblArtist.Text = "Artist: " + bm.artist;


            if (File.Exists(osuFolder + "data\\bt\\" + bm.beatmapSetID + "l.jpg"))
                pictureBox1.ImageLocation = osuFolder + "data\\bt\\" + bm.beatmapSetID + "l.jpg";
            else if (File.Exists(osuFolder + "data\\bt\\" + bm.beatmapSetID + ".jpg"))
                pictureBox1.ImageLocation = osuFolder + "data\\bt\\" + bm.beatmapSetID + ".jpg";
            else
                pictureBox1.ImageLocation = null;

        }
    }
}
