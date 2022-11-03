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

        // Adds fried to the user's friend list
        public void AddFriend(Person person)
        {
            Person.Friends.Add(person);
        }

        // Removes friend from the user's friend list
        public void RemoveFriend(Person person)
        {
            Person.Friends.Remove(person);
        }

        // Creates an empty playlist with title
        public void CreatePlayList(string name)
        {
            Playlist playlist = new Playlist(person, name);
            Person.Playlists.Add(playlist);
        }

        // Removes playlist from the user's playlist list
        public void RemovePlayList(int id)
        {
            Person.Playlists.RemoveAt(id);
        }

        // Adds the selected IPlayable to the selected playlist
        public void AddToPlayList(int selectedId, IPlayable playable)
        {
            Person.Playlists[selectedId].Add(playable);
        }

        // Removes the selected IPlayable from the selected playlist
        public void RemoveFromPlayList(int selectedId, IPlayable playable)
        {
            Person.Playlists[selectedId].Playables.Remove(playable);
        }
    }
}
