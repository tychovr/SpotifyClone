using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Clone
{
    internal class Album : SongCollection
    {
        private List<Artist> Artists = new List<Artist>();
        private List<Song> Songs = new List<Song>();
        private List<Album> Albums = new List<Album>();

        public Album(List<Artist> artist, string title, List<Song> song) : base(title)
        {
            Artists = artist;

            foreach (Song s in song)
            {
                Playables.Add(s);
            }
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
            return Title;
        }
    }
}
