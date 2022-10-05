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

        public Album(List<Artist> artist, List<Song> song) : base(artist)
        {
            Artists = artist;
        }
    }
}
