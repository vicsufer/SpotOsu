using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotifyAPI.Local;
using SpotifyAPI.Local.Models;
using System.Threading;
using SpotifyAPI.Web.Models;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web.Enums;

namespace Logic
{
    public class Spotify
    {
        private readonly SpotifyWebAPI _spotify;
        int apiSleepTime = 250;
        public Spotify(string clientID)
        {
            _spotify = new SpotifyWebAPI();
            WebAPIFactory webApiFactory = new WebAPIFactory(
                   "http://localhost",
                   8000,
                   clientID,
                   Scope.PlaylistModifyPublic | Scope.PlaylistModifyPrivate,
                   TimeSpan.FromSeconds(20)
              );
            try
            {
               _spotify = (webApiFactory.GetWebApi()).Result;
            }
            catch (Exception ex)
            {
                throw new SpotifyException("Unable to connect");
            }

            if (_spotify == null)
                return;

        }

        public void Close()
        {
            _spotify.Dispose();
        }

        public void UpdateInfo()
        {

        }

        public FullPlaylist CreatePlaylist(string name, bool mode)
        {

            var profile_id = _spotify.GetPrivateProfile().Id;
            

            FullPlaylist playlist = _spotify.CreatePlaylist(profile_id, name, mode);
            while (playlist.HasError())
            {
                Thread.Sleep(apiSleepTime);
                Console.WriteLine("Error Status: " + playlist.Error.Status);
                Console.WriteLine("Error Msg: CreatePlayList" + playlist.Error.Message);
            }
            return playlist;
        }

        public FullTrack FindTrackByBeatmap(BeatmapLittle beatmap)
        {
            FullTrack aux = null;

            SearchItem item = _spotify.SearchItems(beatmap.searchString(), SearchType.Track) ;
            while (item.HasError())
            {
                Console.WriteLine("Error Status: " + item.Error.Status);
                Console.WriteLine("Error Msg: FindTrackByBeatmap " + item.Error.Message);

                Thread.Sleep(apiSleepTime);

                item = _spotify.SearchItems(beatmap.searchString(), SearchType.Track);
            }
            if (item.Tracks.Total > 0)
            {
               aux = item.Tracks.Items.First();
            }
            return aux;
        }

        public List<FullTrack> FindTracksByCollection(IEnumerable<BeatmapLittle> collection)
        {
            List<FullTrack> aux = new List<FullTrack>();
            foreach (var beatmap in collection)
            {
                var track = FindTrackByBeatmap(beatmap);
                if (track != null)
                    aux.Add(track);
            }
            
            return aux;
        }

        public void CreatePlaylistByCollection(string name, IEnumerable<BeatmapLittle> collection, out int numberOfSongs, bool mode = true)
        {
            var tracks = FindTracksByCollection(collection).Select( x => x.Uri).ToList();
            var playlist = CreatePlaylist(name, mode);
            var user = _spotify.GetPrivateProfile();
            while (user.HasError())
            {
                Console.WriteLine("Error Status: " + user.Error.Status);
                Console.WriteLine("Error Msg: CreatePlayListByCollection" + user.Error.Message);
                Thread.Sleep(20);
                user = _spotify.GetPrivateProfile();
            }
            _spotify.AddPlaylistTracks(user.Id, playlist.Id, tracks );
            numberOfSongs = tracks.Count();
        }
    }
}
