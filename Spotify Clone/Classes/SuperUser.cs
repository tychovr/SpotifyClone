using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Clone
{
    internal class SuperUser : Person
    {
        private List<Album> AllAlbums;
        private List<Song> AllSongs;
        private List<Person> AllUsers;

        public SuperUser(List<Person> friendList, string name, List<Album> album, List<Song> song, List<Person> person) : base(friendList, name)
        {
            AllAlbums = album;
            AllSongs = song;
            AllUsers = person;
        }
    }
}
