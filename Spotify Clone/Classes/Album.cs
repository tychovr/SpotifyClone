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
        private List<Song> Songs;
        private List<Album> Albums;

        public Album(List<Artist> artist, string title, List<Song> song) : base(title)
        {
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
            return base.ToString();
        }
    }
}
