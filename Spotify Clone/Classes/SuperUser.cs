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

        public void AddFriend(Person person)
        {
        }

        public void RemoveFriend(Person person)
        {
        }

        public Playlist CreatePlayList(string name)
        {
        }

        public void RemovePlayList(int id)
        {
        }

        public void AddToPlayList(IPlayable playable)
        {
        }

        public void RemoveFromPlayList(IPlayable playable)
        {
        }
    }
}
