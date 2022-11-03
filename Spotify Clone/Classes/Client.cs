using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Spectre.Console;

namespace Spotify_Clone
{
    internal class Client
    {
        public IPlayable CurrentlyPlaying;
        public int CurrentTime;
        public int SelectedId;
        public int SelectedUser = -1;
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

            Console.SetCursorPosition(5, 10);
            Program.TypeWriter2("Logged in user: " + ActiveUser.Name);
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

            Console.SetCursorPosition(5, 10);
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
                Table.AddRow("[#FF0000]" + Counter.ToString() + "[/]", "[#FF7F00]" + song.Title + "[/]", "[#FFFF00]" + song.Artists.Count() + "[/]", "[#00FF00]" + song.SongGenre + "[/]", "[#0000FF]" + song.Length() + " seconds[/]");
                Counter++;
            }

            AnsiConsole.Render(Table);
        }

        public void SelectSong(int id)
        {
            Song SelectedSong = allSongs[id];

            Console.SetCursorPosition(5, 10);
            Program.TypeWriter2("Selected song: " + SelectedSong.Title + " by ");

            foreach (var artist in SelectedSong.Artists)
            {
                Console.CursorTop = Console.CursorTop - 3;
                Program.TypeWriter2(artist.Name + " ");
            }
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

            Console.SetCursorPosition(5, 10);
            Program.TypeWriter2("Selected user: " + SelectedUser.Name);
        }

        public void ShowUserPlaylists()
        {
            if (SelectedUser < 0)
            {
                int Counter1 = 0;

                var Table1 = new Table().Centered();
                Table1.Border(TableBorder.HeavyEdge);

                Table1.Title("[#0c0c0c].[/]");
                Table1.Border(TableBorder.HeavyEdge);
                Table1.AddColumns("[#FF0000]ID[/]", "[#FF7F00]Name[/]", "[#FFFF00]Songs[/]");

                foreach (var playlist in ActiveUser.Person.Playlists)
                {
                    Table1.AddRow("[#FF0000]" + Counter1.ToString() + "[/]", "[#FF7F00]" + playlist.Title + "[/]", "[#FFFF00]" + playlist.Playables.Count() + "[/]");
                    Counter1++;
                }

                AnsiConsole.Write(Table1);
            }
            else
            {
                int Counter2 = 0;

                var Table2 = new Table().Centered();

                Table2.Title("[#0c0c0c].[/]");
                Table2.Border(TableBorder.HeavyEdge);
                Table2.AddColumns("[#FF0000]ID[/]", "[#FF7F00]Name[/]", "[#FFFF00]Songs[/]");

                foreach (var playlist in allUsers[SelectedUser].Playlists)
                {
                    Table2.AddRow("[#FF0000]" + Counter2.ToString() + "[/]", "[#FF7F00]" + playlist.Title + "[/]", "[#FFFF00]" + playlist.Playables.Count() + "[/]");
                    Counter2++;
                }

                AnsiConsole.Write(Table2);
            }
        }

        public void SelectUserPlaylist(int id)
        {
            Playlist SelectedPlaylist = allUsers[SelectedId].Playlists[id];

            Console.SetCursorPosition(5, 10);
            Program.TypeWriter2("Selected playlist: " + SelectedPlaylist.Title + " by " + SelectedPlaylist.Owner.Name);
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

            if (Shuffle)
            {
                Console.SetCursorPosition(5, 10);
                Program.TypeWriter2("Switched shuffle on!");
            }
            else
            {
                Console.SetCursorPosition(5, 10);
                Program.TypeWriter2("Switched shuffle off!");
            }
        }

        public void SetRepeat()
        {
            Repeat = !Repeat;

            if (Repeat)
            {
                Console.SetCursorPosition(5, 10);
                Program.TypeWriter2("Switched repeat on!");
            }
            else
            {
                Console.SetCursorPosition(5, 10);
                Program.TypeWriter2("Switched repeat off!");
            }
        }

        public void CreatePlaylist(string name)
        {
            activeUser.CreatePlayList(name);

            Console.SetCursorPosition(5, 10);
            Program.TypeWriter2("Created " + name + " playlist succesfully!");
        }

        public void ShowPlaylists()
        {
            int counter = 0;

            var table = new Table();
            table.Title("[#0c0c0c].[/]");
            table.Border = TableBorder.Rounded;

            table.AddColumn("[#FF0000]ID[/]");
            table.AddColumn("[#FF7f00]Playlist Title[/]");
            table.AddColumn("[#FFFF00]Creator[/]");

            for (counter = 0; counter < activeUser.Playlists.Count; counter++)
            {
                table.AddRow("[#FF0000]" + counter.ToString() + "[/]", "[#FF7F00]" + activeUser.Playlists[counter].Title + "[/]", "[#FFFF00]" + activeUser.Playlists[counter].Owner.Name + "[/]");
            }

            AnsiConsole.Write(table);
        }

        public void SelectPlaylist(int id)
        {
            SelectedId = id;

            Console.SetCursorPosition(5, 10);
            Program.TypeWriter2("Selected playlist: " + activeUser.Person.Playlists[id].Title);
        }

        public void RemovePlaylists(int id)
        {
            if (id < activeUser.Person.Playlists.Count)
            {
                Console.SetCursorPosition(5, 10);
                Program.TypeWriter2("Removed " + activeUser.Person.Playlists[id].Title + " from " + activeUser.Name + "'s playlists");

                activeUser.RemovePlayList(id);
            }
            else
            {
                Console.SetCursorPosition(5, 10);
                Program.TypeWriter2("There is no playlist with that ID");
            }
        }

        public void AddSongToPlaylist(int id)
        {
            activeUser.Person.Playlists[SelectedId].Playables.Add(allSongs[id]);

            Console.SetCursorPosition(5, 10);
            Program.TypeWriter2("Added: " + allSongs[id].Title + " to " + activeUser.Person.Playlists[SelectedId].Title);
        }

        public void ShowSongsInPlaylist()
        {
            int counter = 0;

            var table = new Table().Centered();

            table.Title("[#0c0c0c].[/]");
            table.Border = TableBorder.Rounded;
            table.AddColumn("[#FF0000]ID[/]");
            table.AddColumn("[#FF7F00]Song Title[/]");

            foreach (var playable in activeUser.Person.Playlists[SelectedId].Playables)
            {
                table.AddRow("[#FF0000]" + counter.ToString() + "[/]", "[#FF7F00]" + playable.ToString() + "[/]");
                counter++;
            }

            AnsiConsole.Write(table);
        }

        public void RemoveFromPlaylist(int id)
        {
            if (id < activeUser.Person.Playlists[SelectedId].Playables.Count)
            {
                Console.SetCursorPosition(5, 10);
                Program.TypeWriter2("Removed " + allSongs[id].Title + " from " + activeUser.Person.Playlists[SelectedId].Title);

                activeUser.Person.Playlists[SelectedId].Playables.Remove(allSongs[id]);

            }
            else
            {
                Console.SetCursorPosition(5, 10);
                Program.TypeWriter2("There is no song with that ID in " + activeUser.Person.Playlists[SelectedId].Title + "!");
            }
        }

        public void RemovePlaylist()
        {
            Console.SetCursorPosition(5, 10);
            Program.TypeWriter2("Removed " + activeUser.Person.Playlists[SelectedId].Title + " playlist succesfully!");

            activeUser.RemovePlayList(SelectedId);
        }

        public void ShowFriends()
        {
            int counter = 0;

            var table = new Table().Centered();
            table.Title("[#0c0c0c].[/]");
            table.Border = TableBorder.Rounded;

            table.AddColumn("[#FF0000]ID[/]");
            table.AddColumn("[#FF7F00]Friend Name[/]");

            foreach (var friend in activeUser.Person.Friends)
            {
                table.AddRow("[#FF0000]" + counter.ToString() + "[/]", "[#FF7F00]" + friend.Name + "[/]");
                counter++;
            }

            AnsiConsole.Write(table);
        }

        public void SelectFriend(int id)
        {
            if (id < activeUser.Person.Friends.Count)
            {
                SelectedId = id;

                Console.SetCursorPosition(5, 10);
                Program.TypeWriter2("Selected friend: " + allUsers[id].Name);
            }
            else
            {
                Console.SetCursorPosition(5, 10);
                Program.TypeWriter2("There is no user with that ID!");
            }
        }

        public void AddFriend(int id)
        {
            if (id < activeUser.Person.Friends.Count)
            {
                if (activeUser.Person.Friends.Find(x => x.Name == allUsers[id].Name) == null)
                {
                    activeUser.AddFriend(allUsers[id]);

                    Console.SetCursorPosition(5, 10);
                    Program.TypeWriter2("Added " + allUsers[id].Name + " as a friend!");
                }
                else
                {
                    Console.SetCursorPosition(5, 10);
                    Program.TypeWriter2("You are already friends with " + allUsers[id].Name + "!");
                }
            }
            else
            {
                Console.SetCursorPosition(5, 10);
                Program.TypeWriter2("There is no user with that ID!");
            }
        }

        public void RemoveFriend(int id)
        {
            if (id < activeUser.Person.Friends.Count)
            {
                Console.SetCursorPosition(5, 10);
                Program.TypeWriter2("Removed " + allUsers[id].Name + " as a friend!");

                activeUser.RemoveFriend(allUsers[id]);

            }
            else
            {
                Console.SetCursorPosition(5, 10);
                Program.TypeWriter2("There is no friend with that ID in your friends list!");
            }
        }
    }
}
