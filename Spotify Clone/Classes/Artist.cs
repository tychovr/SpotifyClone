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
        private List<Album> Albums = new List<Album>();
        private List<Song> Songs = new List<Song>();

        public Artist(List<Album> album, string name)
        {
            Albums = album;
        }

        public void AddSong(Song song)
        {
            Songs.Add(song);
        }

        public void AddAlbum(Album album)
        {
            Albums.Add(album);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
