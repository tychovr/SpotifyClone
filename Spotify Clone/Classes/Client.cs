using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;

namespace Spotify_Clone
{
    internal class Client
    {
        public IPlayable CurrentlyPlaying;
        public int CurrentTime;
        public int SelectedId;
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
            int Counter = 0;

            foreach (Album album in allAlbums)
            {
                Counter++;
                AnsiConsole.MarkupLine($"[green]{Counter}[/] - [yellow]{album.Title}[/]");
            }
        }

        public void SelectAlbum(int id)
        {
            Album SelectedAlbum = allAlbums[id];
        }

        public void ShowAllSongs()
        {
            int Counter = 0;

            foreach (Song song in allSongs)
            {
                Counter++;
                AnsiConsole.MarkupLine($"[green]{Counter}[/] - [yellow]{song.Title}[/] - [blue]{song.Artists}[/] - [red]{song.Duration}[/]");
            }
        }

        public void SelectSong(int id)
        {
            Song SelectedSong = allSongs[id];
        }

        public void ShowAllUsers()
        {
            int Counter = 0;

            foreach (var user in allUsers)
            {
                AnsiConsole.MarkupLine($"[{Counter}] {user.Name}");
                Counter++;
            }
        }

        public void SelectUser(int id)
        {
            Person SelectedUser = allUsers[id];
        }

        public void ShowUserPlaylists()
        {
            int i = 0;

            var table = new Table();
            table.Border = TableBorder.Rounded;

            table.AddColumn("ID");
            table.AddColumn("Playlist Title");
            table.AddColumn("Creator");

            for (i = 0; i < allUsers[SelectedId].Playlists.Count; i++)
            {
                table.AddRow(i.ToString(), allUsers[SelectedId].Playlists[i].Title, allUsers[SelectedId].Name);
            }

            AnsiConsole.Write(table);
        }

        public void SelectUserPlaylist(int id)
        {
            Playlist SelectedPlaylist = allUsers[SelectedId].Playlists[id];
        }

        public void Play()
        {
            if (CurrentlyPlaying != null)
            {
                Playing = true;
                CurrentlyPlaying.Play();
            }
        }

        public void Pause()
        {
            if (CurrentlyPlaying != null)
            {
                Playing = false;
                CurrentlyPlaying.Pause();
            }
        }

        public void Stop()
        {
            if (CurrentlyPlaying != null)
            {
                Playing = false;
                CurrentlyPlaying.Stop();
            }
        }

        public void NextSong()
        {
        }

        public void SetShuffle()
        {
            Shuffle = !Shuffle;
        }

        public void SetRepeat()
        {
            Repeat = !Repeat;
        }

        public void CreatePlaylist(string name)
        {
            activeUser.CreatePlayList(name);
        }

        public void ShowPlaylists()
        {
            int i = 0;

            var table = new Table();
            table.Border = TableBorder.Rounded;

            table.AddColumn("ID");
            table.AddColumn("Playlist Title");
            table.AddColumn("Creator");

            for (i = 0; i < activeUser.Playlists.Count; i++)
            {
                table.AddRow(i.ToString(), activeUser.Playlists[i].Title, activeUser.Name);
            }

            AnsiConsole.Write(table);
        }

        public void SelectPlaylist(int id)
        {
            SelectedId = id;
        }

        public void RemovePlaylists(int id)
        {
            activeUser.RemovePlayList(id);
        }

        public void AddSongToPlaylist(int id)
        {
            activeUser.Playlists[SelectedId].Add(allSongs[id]);
        }

        public void ShowSongsInPlaylist()
        {
        }

        public void RemoveFromPlaylist(int id)
        {
            activeUser.Playlists[SelectedId].Remove(allSongs[id]);
        }

        public void ShowFriends()
        {
            activeUser.Friends.ForEach(friend => Console.WriteLine(friend));
        }

        public void SelectFriend(int id)
        {
        }

        public void AddFriend(int id)
        {
            activeUser.AddFriend(allUsers[id]);
        }

        public void RemoveFriend(int id)
        {
            activeUser.RemoveFriend(allUsers[id]);
        }
    }
}
