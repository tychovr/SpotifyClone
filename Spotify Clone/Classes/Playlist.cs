using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Clone
{
    internal class Playlist : SongCollection
    {
        public Playlist(List<Song> songs, string title) : base(songs, title)
        {
        }
    }
}
