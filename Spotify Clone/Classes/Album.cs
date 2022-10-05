using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Clone
{
    internal class Album : SongCollection
    {
        private List<Artist> Artists;

        public Album(List<Artist> artist, string title, List<Song> song)
        {
        }

        public void AddSong(Song song)
        {
        }

        public void AddAlbum(Album album)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
