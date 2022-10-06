using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Clone
{
    internal class Song
    {
        public string Title;
        public List<Artist> Artists;
        public Genre SongGenre;
        public int Duration;

        public Song(List<Artist> artist, Genre genre, int songID)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
