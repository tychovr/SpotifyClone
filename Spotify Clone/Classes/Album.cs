using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Clone
{
    internal class Album : SongCollection
    {
        private List<Artist> artists = new List<Artist>();
        private List<Song> songs = new List<Song>();
        private List<Album> albums = new List<Album>();

        public List<Artist> Artists { get => artists; set => artists = value; }
        public List<Song> Songs { get => songs; set => songs = value; }
        public List<Album> Albums { get => albums; set => albums = value; }

        public Album(List<Artist> artist, string title, List<Song> song) : base(title)
        {
            Artists = artist;
            Title = title;

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
