using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Clone
{
    internal class Artist
    {
        public string Name;
        private List<Album> Albums;
        private List<Song> Songs;

        public Artist(List<Album> album)
        {
            Albums = album;
        }
    }
}
