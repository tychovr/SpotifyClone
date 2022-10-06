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
            throw new NotSupportedException();
        }

        public List<Playlist> ShowPlaylists()
        {
            throw new NotSupportedException();
        }

        public Playlist SelectPlaylist(int id)
        {
            throw new NotSupportedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
