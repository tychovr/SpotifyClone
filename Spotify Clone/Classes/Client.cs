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
        private List<Album> allAlbums = new List<Album>();
        private List<Song> allSongs = new List<Song>();
        private List<Person> allUsers = new List<Person>();

        public SuperUser ActiveUser { get => activeUser; set => activeUser = value; }

        public Client()
        {
        }

        public Client(SuperUser superUser, List<Album> album, List<Song> song, List<Person> user)
        {
            allAlbums = album;
            allSongs = song;
            allUsers = user;
        }

        public void SetActiveUser(SuperUser superUser)
        {
            ActiveUser = superUser;
        }

        public void ShowAllAlbums()
        {
            int Counter = 0;

            var Table = new Table().Centered();
            Table.Title("[#0c0c0c].[/]");
            Table.Border(TableBorder.HeavyEdge);
            Table.AddColumns("[#FF0000]ID[/]", "[#FF7F00]Title[/]", "[#FFFF00]Artist[/]", "[#00FF00]Songs[/]");

            foreach (var album in allAlbums)
            {
                Table.AddRow("[#FF0000]" + Counter.ToString() + "[/]", "[#FF7F00]" + album.Title + "[/]", "[#FFFF00]" + album.Artists[0].Name + "[/]", "[#00FF00]" + album.Songs.Count.ToString() + "[/]");
                Counter++;
            }

            AnsiConsole.Render(Table);
        }

        public void SelectAlbum(int id)
        {
            Album SelectedAlbum = allAlbums[id];
            Program.TypeWriter2("Selected album: " + SelectedAlbum.Title);
        }

        public void ShowAllSongs()
        {
            int Counter = 0;

            var Table = new Table().Centered();
            Table.Title("[#0c0c0c].[/]");
            Table.Border(TableBorder.HeavyEdge);
            Table.AddColumns("[#FF0000]ID[/]", "[#FF7F00]Title[/]", "[#FFFF00]Artists[/]", "[#00FF00]Genre[/]", "[#0000FF]Duration[/]");
            foreach (var song in allSongs)
            {
                Table.AddRow("[#FF0000]" + Counter.ToString() + "[/]", "[#FF7F00]" + song.Title + "[/]", "[#FFFF00]" + song.Artists.Count() + "[/]", "[#00FF00]" + song.SongGenre + "[/]", "[#0000FF]" + song.Duration + " seconds[/]");
                Counter++;
            }

            AnsiConsole.Render(Table);
        }

        public void SelectSong(int id)
        {
            Song SelectedSong = allSongs[id];
            Program.TypeWriter2("Selected song: " + SelectedSong.Title);
        }

        public void ShowAllUsers()
        {
            int Counter = 0;

            var Table = new Table().Centered();
            Table.Title("[#0c0c0c].[/]").Centered();
            Table.Border(TableBorder.HeavyEdge);
            Table.AddColumns("[#FF0000]ID[/]", "[#FF7F00]Name[/]", "[#FFFF00]Friends[/]", "[#00FF00]Playlists[/]");
            foreach (var person in allUsers)
            {
                Table.AddRow("[#FF0000]" + Counter.ToString() + "[/]", "[#FF7F00]" + person.Name + "[/]", "[#FFFF00]" + person.Friends.Count() + "[/]", "[#00FF00]" + person.Playlists.Count() + "[/]");
                Counter++;
            }

            AnsiConsole.Render(Table);
        }

        public void SelectUser(int id)
        {
            Person SelectedUser = allUsers[id];
        }

        public void ShowUserPlaylists()
        {
            int Counter = 0;

            var Table = new Table().Centered();

            Table.Title("[#0c0c0c].[/]");
            Table.Border(TableBorder.HeavyEdge);
            Table.AddColumns("[#FF0000]ID[/]", "[#FF7F00]Name[/]", "[#FFFF00]Songs[/]");

            foreach (var playlist in ActiveUser.Person.Playlists)
            {
                Table.AddRow("[#FF0000]" + Counter.ToString() + "[/]", "[#FF7F00]" + playlist.Title + "[/]", "[#FFFF00]" + playlist.Playables.Count() + "[/]");
                Counter++;
            }

            AnsiConsole.Write(Table);
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
            if (CurrentlyPlaying != null)
            {
                CurrentlyPlaying.Next();
            }
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
