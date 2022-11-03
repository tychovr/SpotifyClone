using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Clone
{
    internal class SuperUser : Person
    {
        private List<Album> allAlbums = new List<Album>();
        private List<Song> allSongs = new List<Song>();
        private List<Person> allUsers = new List<Person>();
        private Person person;

        public List<Album> AllAlbums { get => allAlbums; set => allAlbums = value; }
        public List<Song> AllSongs { get => allSongs; set => allSongs = value; }
        public List<Person> AllUsers { get => allUsers; set => allUsers = value; }
        public Person Person { get => person; set => person = value; }

        public SuperUser(string name, Person person) : base(name)
        {
            Person = person;
        }

        public SuperUser(string name, List<Album> album, List<Song> song, List<Person> users, Person person) : base(name)
        {
            AllAlbums = album;
            AllSongs = song;
            AllUsers = users;
            Person = person;
        }

        public void AddFriend(Person person)
        {
            Person.Friends.Add(person);
        }

        public void RemoveFriend(Person person)
        {
            Friends.Remove(person);
        }

        public void CreatePlayList(string name)
        {
            Playlist playlist = new Playlist(person, name);
            Person.Playlists.Add(playlist);
        }

        public void RemovePlayList(int id)
        {
            Person.Playlists.RemoveAt(id);
        }

        public void AddToPlayList(int selectedId, IPlayable playable)
        {
            Person.Playlists[selectedId].Add(playable);
        }

        public void RemoveFromPlayList(int selectedId, IPlayable playable)
        {
            Person.Playlists[selectedId].Remove(playable);
        }
    }
}
