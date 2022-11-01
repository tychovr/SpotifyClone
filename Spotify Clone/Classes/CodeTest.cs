using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Clone
{
    internal class CodeTest
    {
        public void Test()
        {
            List<Person> person = new List<Person>();
            List<Album> album = new List<Album>();
            List<Song> song = new List<Song>();
            Client client = new Client(person, album, song);
            client.ShowAllAlbums();
            client.ShowAllSongs();
        }
    }
}
