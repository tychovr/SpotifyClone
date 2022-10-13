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

        public SuperUser(List<Person> friendList, string name, List<Album> album, List<Song> song, List<Person> person) : base(name)
        {
            AllAlbums = album;
            AllSongs = song;
            AllUsers = person;
        }

        public void AddFriend(Person person)
        {
            Friends.Add(person);
        }

        public void RemoveFriend(Person person)
        {
        }

        public void CreatePlayList(string name)
        {
            Playlist playlist = new Playlist(this, name);
            Playlists.Add(playlist);
        }

        public void RemovePlayList(int id)
        {
            Playlists.RemoveAt(id);
        }

        public void AddToPlayList(IPlayable playable)
        {
        }

        public void RemoveFromPlayList(IPlayable playable)
        {
        }
    }
}
