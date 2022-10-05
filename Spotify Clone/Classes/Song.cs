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
        public Genres SongGenre;
        public int Duration;

        public Song(List<Artist> artist, Genres genre)
        {

        }

        public enum Genres
        {
            Rock,
            Pop,
            HipHop,
            Country,
            Jazz,
            Classical,
            Blues,
            Metal,
            Electronic,
            Folk,
            Reggae,
            RnB,
            Soul,
            Punk,
            Indie,
            Alternative,
            World,
            Latin,
            Reggaeton,
            Salsa,
            KPop,
            JPop,
            Anime,
            Soundtrack,
            Musical,
            Childrens,
            Comedy,
            SpokenWord,
            Audiobook,
            Podcast,
            Radio,
            Dance,
            Other
        }

    }
}
