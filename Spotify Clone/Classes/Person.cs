using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Clone
{
    internal class Person
    {
        public string Name;
        private List<Person> Friends;
        private List<Playlist> Playlists;

        public Person(string name)
        {
            Name = name;
        }

        public List<Person> ShowFriends()
        {
            return Friends;
        }

        public List<Playlist> ShowPlaylists()
        {
            return Playlists;
        }

        public Playlist SelectPlaylist(int id)
        {
            return Playlists[id];
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
