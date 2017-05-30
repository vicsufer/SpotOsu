using osu_database_reader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{

    public class MainFrame
    {
        Spotify sp;

        public CollectionDb collections_db;
        public OsuDb osu_db;
        string Osu_path;
        public string spotifyToken;

        public const int MAX_BEATMAPS = 400;

        public MainFrame(string path = "")
        {
            Osu_path = !path.Equals("") ? path : $@"C:\Users\{Environment.UserName}\AppData\Local\osu!\";
            collections_db = CollectionDb.Read(Osu_path + "collection.db");
            osu_db = OsuDb.Read(Osu_path + "osu!.db");
        }

        public void CreatePlaylist(string clientID, string playlistName, IEnumerable<string> collection = null, bool mode = true)
        {
            sp = new Spotify(clientID);
            sp.CreatePlaylistByCollection(playlistName, GetBeatmapsByNamesList(collection) ,true);
        }

        public IEnumerable<BeatmapLittle> GetBeatmapsByNamesList(IEnumerable<string> names)
        {
            List<BeatmapLittle> beatmaps = new List<BeatmapLittle>();
            Parallel.ForEach(names, name =>
            {
                var beatmap = osu_db.Beatmaps.Find( x => x.Title.Equals(name));
                lock (beatmaps) { beatmaps.Add(new BeatmapLittle(name)); }
            });
            return beatmaps;
        }
        public IEnumerable<BeatmapLittle> GetCollectionBeatmaps(string collectionName)
        {
            if (collectionName.ToLower().Equals("all"))
            {
                return GetAllBeatmaps();
            }

            List<BeatmapLittle> beatmaps = new List<BeatmapLittle>();
            var hashList = collections_db.Collections.Find( x => x.Name.ToLower() == collectionName.ToLower()).Md5Hashes;
            Parallel.ForEach(hashList, hash =>
                {
                    var beatmap = osu_db.Beatmaps.Find( bm => bm.BeatmapChecksum == hash);
                    BeatmapLittle aux = new BeatmapLittle(beatmap);
                    lock (beatmaps)
                    {
                        beatmaps.Add(aux);
                    }
                }
            );
            return beatmaps;
        }

        IEnumerable<BeatmapLittle> GetAllBeatmaps()
        {
            List<BeatmapLittle> beatmaps = new List<BeatmapLittle>();
            var list = osu_db.Beatmaps.AsParallel().GroupBy(x => x.Title).Select(x => x.First()).ToList();
            while(list.Count() >= MAX_BEATMAPS)
                list = list.GetRange(0, list.Count()-1);
            Parallel.ForEach( list, beatmap =>
            {
                BeatmapLittle aux = new BeatmapLittle(beatmap);
                lock (beatmaps)
                {
                    beatmaps.Add(aux);
                }
            }
            );
            return beatmaps;
        }
    }
}
