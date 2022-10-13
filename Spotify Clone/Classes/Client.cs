using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Clone
{
    internal class Client
    {
        public IPlayable CurrentlyPlaying;
        public int CurrentTime;
        public bool Playing;
        public bool Shuffle;
        public bool Repeat;
        private SuperUser activeUser;
        private List<Album> allAlbums;
        private List<Song> allSongs;
        private List<Person> allUsers;

        public SuperUser ActiveUser { get => activeUser; set => activeUser = value; }

        public Client(List<Person> person, List<Album> album, List<Song> song)
        {
        }

        public void SetActiveUser(Person person)
        {
            activeUser = (SuperUser)person;
        }

        public void ShowAllAlbums()
        {
        }

        public void SelectAlbum(int id)
        {
        }

        public void ShowAllSongs()
        {
        }

        public void SelectSong(int id)
        {
        }

        public void ShowAllUsers()
        {
        }

        public void SelectUser(int id)
        {
        }

        public void ShowUserPlaylists()
        {
        }

        public void SelectUserPlaylist(int id)
        {
        }

        public void Play()
        {
        }

        public void Pause()
        {
        }

        public void Stop()
        {
        }

        public void NextSong()
        {
        }

        public void SetShuffle()
        {
        }

        public void SetRepeat()
        {
        }

        public void CreatePlaylist(string name)
        {
            activeUser.CreatePlayList(name);
        }

        public void ShowPlaylists()
        {
            activeUser.Playlists.ForEach(playlist => Console.WriteLine(playlist));
        }

        public void SelectPlaylist(int id)
        {
        }

        public void RemovePlaylists(int id)
        {
            activeUser.RemovePlayList(id);
        }

        public void AddSongToPlaylist(int id)
        {

        }

        public void ShowSongsInPlaylist()
        {
        }

        public void RemoveFromPlaylist(int id)
        {
        }

        public void ShowFriends()
        {
            SuperUser.Friends.ForEach(friend => Console.WriteLine(friend));
        }

        public void SelectFriend(int id)
        {
        }

        public void AddFriend(int id)
        {
        }

        public void RemoveFriend(int id)
        {
        }
    }
}
