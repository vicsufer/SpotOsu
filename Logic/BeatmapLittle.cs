using osu_database_reader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class BeatmapLittle
    {

        public string title, artist;
        public string songTags;
        public int beatmapId, beatmapSetID;
        public BeatmapLittle(BeatmapEntry bm)
        {
            title = bm.Title;
            artist = bm.Artist;
            songTags = bm.SongTags;
            beatmapId = bm.BeatmapId;
            beatmapSetID = bm.BeatmapSetId;
        }
        public BeatmapLittle(String str)
        {
            var split = str.Split('-');
            title = split[0];
            artist = split[1];
        }
        public override string ToString()
        {
            return "Track:" + title + " Artist:" + artist;
        }
        public string searchString()
        {
            return artist +"+"+ title;
        }

        public string ToListBoxString()
        {
            return beatmapSetID + ": " + title + " - " + artist;
        }

    }
}
