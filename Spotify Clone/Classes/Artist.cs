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

        public Artist(List<Album> album, string name)
        {
            Albums = album;
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
