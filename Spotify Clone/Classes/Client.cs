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
        private SuperUser ActiveUser;
        private List<Album> AllAlbums;
        private List<Song> AllSongs;
        private List<Person> AllUsers;

        public Client(List<Person> person, List<Album> album, List<Song> song)
        {
        }

        public void SetActiveUser(Person person)
        {
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
        }

        public void ShowPlaylists()
        {
        }

        public void SelectPlaylist(int id)
        {
        }

        public void RemovePlaylists(int id)
        {
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
