using System.Collections.Generic;
using Spectre.Console;

namespace Spotify_Clone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Spotify Clone";

            // Create new User classes
            Person tycho = new Person("Tycho");
            Person luuk = new Person("Luuk");
            Person kyara = new Person("Kyara");
            Person fabian = new Person("Fabian");

            // Create new Artist classes
            Artist subZeroProject = new Artist(new List<Album>(), "Sub Zero Project");
            Artist daTweekaz = new Artist(new List<Album>(), "Da Tweekaz");
            Artist headhunterz = new Artist(new List<Album>(), "Headhunterz");
            Artist rebelion = new Artist(new List<Album>(), "Rebelion");
            Artist dbstf = new Artist(new List<Album>(), "D-Block & S-te-Fan");
            Artist villain = new Artist(new List<Album>(), "Villain");
            Artist hardDriver = new Artist(new List<Album>(), "Hard Driver");
            Artist coone = new Artist(new List<Album>(), "Coone");
            Artist soundrush = new Artist(new List<Album>(), "Soundrush");
            Artist eurille = new Artist(new List<Album>(), "Eurille");
            Artist wildstylez = new Artist(new List<Album>(), "Wildstylez");
            Artist noisecontrollers = new Artist(new List<Album>(), "Noisecontrollers");
            Artist micahMargin = new Artist(new List<Album>(), "Micah Martin");
            Artist dimitriK = new Artist(new List<Album>(), "Dimitri K");
            Artist theDarkHorror = new Artist(new List<Album>(), "The Dark Horror");
            Artist endymion = new Artist(new List<Album>(), "Endymion");

            // Create new Song classes
            Song darkestHourTheClock = new Song("Darkest Hour (The Clock)", new List<Artist> { subZeroProject, dbstf }, Genre.Hardstyle, 1, 241);
            Song theSolution = new Song("The Solution", new List<Artist> { subZeroProject, villain }, Genre.Hardstyle, 2, 201);
            Song rennaisanceOfRave = new Song("Renaissance of Rave", new List<Artist> { subZeroProject }, Genre.Hardstyle, 3, 197);
            Song tripToMarsAstronauts = new Song("Trip To Mars (Astronauts)", new List<Artist> { subZeroProject }, Genre.Hardstyle, 4, 182);
            Song edgeOfTheUnknown = new Song("Edge of the Unknown", new List<Artist> { daTweekaz, hardDriver, coone }, Genre.Hardstyle, 5, 258);
            Song byTheSword = new Song("By The Sword", new List<Artist> { daTweekaz, hardDriver, coone }, Genre.Hardstyle, 6, 216);
            Song rescueMe = new Song("Rescue Me", new List<Artist> { headhunterz, soundrush, eurille }, Genre.Hardstyle, 7, 256);
            Song noOneCanStopUsNow = new Song("No One Can Stop Us Now", new List<Artist> { headhunterz, wildstylez, noisecontrollers }, Genre.Hardstyle, 8, 169);
            Song aI = new Song("A.I.", new List<Artist> { rebelion, micahMargin }, Genre.Rawstyle, 9, 399);
            Song sideFxs = new Song("Sided Fx's", new List<Artist> { rebelion, dimitriK, theDarkHorror }, Genre.Terrorcore, 10, 186);
            Song dieGladiator = new Song("Die Gladiator", new List<Artist> { rebelion, endymion }, Genre.Hardcore, 11, 89);
            Song outtaControl = new Song("Outta Control", new List<Artist> { rebelion }, Genre.Terrorcore, 12, 189);

            // Create new Album classes
            Album albumContagion = new Album(new List<Artist> { subZeroProject }, "Contagion", new List<Song> { darkestHourTheClock, theSolution });
            Album albumRennaisanceOfRave = new Album(new List<Artist> { subZeroProject }, "Rennaisance Of Rave", new List<Song> { rennaisanceOfRave, tripToMarsAstronauts });
            Album albumLegendsOfTheElite = new Album(new List<Artist> { daTweekaz }, "Legends Of The Elite", new List<Song> { edgeOfTheUnknown, byTheSword });
            Album albumTheReturnOfHeadhunterz = new Album(new List<Artist> { headhunterz }, "The Return Of Headhunterz", new List<Song> { rescueMe, noOneCanStopUsNow });
            Album albumArtificalIntoxication = new Album(new List<Artist> { rebelion }, "Artifical Intoxication", new List<Song> { aI, sideFxs });
            Album albumTheFirstDose = new Album(new List<Artist> { rebelion }, "The First Dose", new List<Song> { dieGladiator, outtaControl });

            // Add albums to artists
            subZeroProject.AddAlbum(albumContagion);
            subZeroProject.AddAlbum(albumRennaisanceOfRave);
            daTweekaz.AddAlbum(albumLegendsOfTheElite);
            headhunterz.AddAlbum(albumTheReturnOfHeadhunterz);
            rebelion.AddAlbum(albumArtificalIntoxication);
            rebelion.AddAlbum(albumTheFirstDose);

            // Add songs to albums
            albumContagion.AddSong(darkestHourTheClock);
            albumContagion.AddSong(theSolution);
            albumRennaisanceOfRave.AddSong(rennaisanceOfRave);
            albumRennaisanceOfRave.AddSong(tripToMarsAstronauts);
            albumLegendsOfTheElite.AddSong(edgeOfTheUnknown);
            albumLegendsOfTheElite.AddSong(byTheSword);
            albumTheReturnOfHeadhunterz.AddSong(rescueMe);
            albumTheReturnOfHeadhunterz.AddSong(noOneCanStopUsNow);
            albumArtificalIntoxication.AddSong(aI);
            albumArtificalIntoxication.AddSong(sideFxs);
            albumTheFirstDose.AddSong(dieGladiator);
            albumTheFirstDose.AddSong(outtaControl);


            // Create new Playlist classes
            Playlist playlistZwareResonantie = new Playlist(tycho, "Zware Resonantie");
            Playlist playlistAlt = new Playlist(luuk, "Alt");
            Playlist playlistBTS = new Playlist(kyara, "BTS");
            Playlist playlistRaveVibes = new Playlist(fabian, "Rave Vibes");

            // Add songs to playlists
            playlistZwareResonantie.Add(darkestHourTheClock);
            playlistZwareResonantie.Add(theSolution);
            playlistZwareResonantie.Add(dieGladiator);
            playlistZwareResonantie.Add(outtaControl);
            playlistAlt.Add(rennaisanceOfRave);
            playlistAlt.Add(tripToMarsAstronauts);
            playlistAlt.Add(edgeOfTheUnknown);
            playlistAlt.Add(byTheSword);
            playlistBTS.Add(rescueMe);
            playlistBTS.Add(noOneCanStopUsNow);
            playlistBTS.Add(aI);
            playlistBTS.Add(sideFxs);
            playlistRaveVibes.Add(darkestHourTheClock);
            playlistRaveVibes.Add(theSolution);
            playlistRaveVibes.Add(rennaisanceOfRave);
            playlistRaveVibes.Add(tripToMarsAstronauts);

            // Add playlists to users
            tycho.Playlists.Add(playlistZwareResonantie);
            luuk.Playlists.Add(playlistAlt);
            kyara.Playlists.Add(playlistBTS);
            fabian.Playlists.Add(playlistRaveVibes);

            // Add friends to users
            tycho.Friends.Add(kyara);
            tycho.Friends.Add(fabian);
            luuk.Friends.Add(kyara);
            luuk.Friends.Add(fabian);
            kyara.Friends.Add(tycho);
            kyara.Friends.Add(luuk);
            fabian.Friends.Add(tycho);
            fabian.Friends.Add(luuk);

            // Add all data to lists
            List<Person> allUsers = new List<Person> { tycho, luuk, kyara, fabian };
            List<Album> allAlbums = new List<Album> { albumContagion, albumRennaisanceOfRave, albumLegendsOfTheElite, albumTheReturnOfHeadhunterz, albumArtificalIntoxication, albumTheFirstDose };
            List<Song> allSongs = new List<Song> { darkestHourTheClock, theSolution, rennaisanceOfRave, tripToMarsAstronauts, edgeOfTheUnknown, byTheSword, rescueMe, noOneCanStopUsNow, aI, sideFxs, dieGladiator, outtaControl };


            // Start TestCode()
            SuperUser SuperUser = new SuperUser("Tycho", tycho);
            Client client = new Client(SuperUser, allAlbums, allSongs, allUsers);

            TestCode(client, SuperUser, allAlbums, allSongs, allUsers);
        }

        public static void TestCode(Client client, SuperUser superUser, List<Album> allAlbums, List<Song> allSongs, List<Person> allUsers)
        {
            // Loading test animation
            AnsiConsole.Progress()
                .Columns(new ProgressColumn[]
                {
                    new TaskDescriptionColumn(),    // Task description
                    new PercentageColumn(),         // Percentage
                    new ProgressBarColumn(),        // Progress bar
                    new RemainingTimeColumn(),      // Remaining time
                    new SpinnerColumn(),            // Spinner
                })
            .Start(ctx =>
            {
                // Define tasks
                var task1 = ctx.AddTask("[#FF0000]Adding Users[/]");
                var task2 = ctx.AddTask("[#FF7F00]Adding Artists[/]");
                var task3 = ctx.AddTask("[#FFFF00]Adding Songcollection[/]");
                var task4 = ctx.AddTask("[#00FF00]Adding Albums[/]");
                var task5 = ctx.AddTask("[#0000FF]Adding Playlists[/]");
                var task6 = ctx.AddTask("[#2E2B5F]Adding SuperUser[/]");
                var task7 = ctx.AddTask("[#8B00FF]Giving you a big smile[/]");


                while (!ctx.IsFinished)
                {
                    task1.Increment(2);
                    task2.Increment(1.9);
                    task3.Increment(1.7);
                    task4.Increment(1.5);
                    task5.Increment(1.3);
                    task6.Increment(1);
                    task7.Increment(0.8);
                    Thread.Sleep(60);
                }
            });

            Console.Clear();

            AnsiConsole.Progress()
                .Columns(new ProgressColumn[]
                {
                    new TaskDescriptionColumn(),    // Task description
                    new PercentageColumn(),         // Percentage
                    new ProgressBarColumn(),        // Progress bar
                    new RemainingTimeColumn(),      // Remaining time
                    new SpinnerColumn(),            // Spinner
                })
            .Start(ctx =>
            {
                // Define tasks
                var task1 = ctx.AddTask("[#FF0000]Removing the big smile I just gave you[/]");
                var task2 = ctx.AddTask("[#0000FF]Starting Test[/]");
                task1.Value = 99;

                for (int i = 0; i < 100; i++)
                {
                    task1.Increment(-1);
                    task2.Increment(1);
                    Thread.Sleep(50);
                }
            });

            Thread.Sleep(69);
            Console.Clear();

            // Start client tests
            TypeWriter("Client.cs - SetActiveUser() | Tycho");
            client.SetActiveUser(superUser);
            Thread.Sleep(3000);
            Console.Clear();

            TypeWriter("Client.cs - ShowAllAlbums() | Showcase");
            client.ShowAllAlbums();
            Thread.Sleep(5000);
            Console.Clear();

            TypeWriter("Client.cs - SelectAlbum() | Showcase");
            client.SelectAlbum(2);
            Thread.Sleep(3000);
            Console.Clear();

            TypeWriter("Client.cs - Play() | Album");
            allAlbums[2].Play();
            Thread.Sleep(3000);
            Console.Clear();

            TypeWriter("Client.cs - ShowAllSongs() | Showcase");
            client.ShowAllSongs();
            Thread.Sleep(5000);
            Console.Clear();

            TypeWriter("Client.cs - SelectSong() | Showcase");
            client.SelectSong(2);
            Thread.Sleep(3000);
            Console.Clear();

            TypeWriter("Client.cs - AddSongToPlaylist() | Friend's playlist");
            TypeWriter2("This feature is not yet implemented");
            Thread.Sleep(1500);
            Console.Clear();

            TypeWriter("Client.cs - AddSongToPlaylist() | Artist's album");
            TypeWriter2("This feature is not yet implemented");
            Thread.Sleep(1500);
            Console.Clear();

            TypeWriter("Client.cs - Play() | Song");
            allSongs[2].Play();
            Thread.Sleep(3000);
            Console.Clear();

            TypeWriter("Client.cs - ShowAllUsers() | Showcase");
            client.ShowAllUsers();
            Thread.Sleep(5000);
            Console.Clear();

            TypeWriter("Client.cs - SelectUser() | Showcase");
            client.SelectUser(2);
            Thread.Sleep(3000);
            Console.Clear();

            TypeWriter("Client.cs - ShowUserPlaylists() | Showcase");
            client.ShowUserPlaylists();
            Thread.Sleep(5000);
            Console.Clear();

            TypeWriter("Client.cs - SelectUserPlaylist() | Showcase");
            client.SelectUserPlaylist(0);
            Thread.Sleep(3000);
            Console.Clear();

            TypeWriter("Client.cs - ShowSongsInPlaylist() | Showcase");
            client.ShowSongsInPlaylist();
            Thread.Sleep(5000);
            Console.Clear();

            TypeWriter("Client.cs - CreatePlaylist() | Showcase");
            client.CreatePlaylist("TestPlaylist");
            Thread.Sleep(3000);
            Console.Clear();

            TypeWriter("Client.cs - SelectPlaylist() | TestPlaylist");
            client.SelectPlaylist(1);
            Thread.Sleep(3000);
            Console.Clear();

            TypeWriter("Client.cs - AddSongToPlaylist() | TestPlaylist");
            client.AddSongToPlaylist(2);
            Console.Clear();
            client.AddSongToPlaylist(4);
            Console.Clear();
            client.AddSongToPlaylist(5);
            Console.Clear();
            client.AddSongToPlaylist(6);
            Console.Clear();
            client.AddSongToPlaylist(0);
            Thread.Sleep(3000);
            Console.Clear();

            TypeWriter("Client.cs - ShowPlaylistSongs() | TestPlaylist");
            client.ShowSongsInPlaylist();
            Thread.Sleep(5000);
            Console.Clear();

            TypeWriter("Client.cs - RemoveFromPlaylist() | TestPlaylist");
            client.RemoveFromPlaylist(2);
            Console.Clear();
            client.RemoveFromPlaylist(1);
            Thread.Sleep(3000);
            Console.Clear();

            TypeWriter("Client.cs - ShowPlaylistSongs() | TestPlaylist");
            client.ShowSongsInPlaylist();
            Thread.Sleep(5000);
            Console.Clear();

            TypeWriter("Client.cs - RemovePlaylist() | TestPlaylist");
            client.RemovePlaylist();
            Thread.Sleep(3000);
            Console.Clear();

            TypeWriter("Client.cs - ShowFriends() | Showcase");
            client.ShowFriends();
            Thread.Sleep(5000);
            Console.Clear();

            TypeWriter("Client.cs - AddFriend() | Showcase");
            client.AddFriend(1);
            Thread.Sleep(3000);
            Console.Clear();

            TypeWriter("Client.cs - ShowFriends() | Showcase");
            client.ShowFriends();
            Thread.Sleep(5000);
            Console.Clear();

            TypeWriter("Client.cs - RemoveFriend() | Showcase");
            client.RemoveFriend(1);
            Thread.Sleep(3000);
            Console.Clear();

            TypeWriter("Client.cs - ShowFriends() | Showcase");
            client.ShowFriends();
            Thread.Sleep(5000);
            Console.Clear();

            TypeWriter("Client.cs - SetShuffle() | Showcase");
            TypeWriter2("This feature is not yet implemented");
            Thread.Sleep(1500);
            Console.Clear();

            TypeWriter("Client.cs - SetRepeat() | Showcase");
            TypeWriter2("This feature is not yet implemented");
            Thread.Sleep(1500);
            Console.Clear();

            TypeWriter("Client.cs - Play() | Playlist");
            allUsers[1].Playlists[0].Play();
            Thread.Sleep(3000);
            Console.Clear();

            TypeWriter("Client.cs - Play() | Song");
            allSongs[4].Play();
            Thread.Sleep(3000);
            Console.Clear();

            TypeWriter("Client.cs - Pause() | Song");
            allSongs[4].Pause();
            Thread.Sleep(3000);
            Console.Clear();

            TypeWriter("Client.cs - Next() | Song");
            allSongs[4].Next();
            Thread.Sleep(3000);
            Console.Clear();

            TypeWriter("Client.cs - Stop() | Song");
            allSongs[4].Stop();
            Thread.Sleep(3000);
            Console.Clear();

            TypeWriter("Ending program test...");
            Thread.Sleep(3000);
            Console.Clear();

            // Ending test animation
            AnsiConsole.Progress()
                .Columns(new ProgressColumn[]
                {
                    new TaskDescriptionColumn(),    // Task description
                    new PercentageColumn(),         // Percentage
                    new ProgressBarColumn(),        // Progress bar
                    new RemainingTimeColumn(),      // Remaining time
                    new SpinnerColumn(),            // Spinner
                })
            .Start(ctx =>
            {
                // Define tasks
                var task1 = ctx.AddTask("[#FF0000]Stealing your cookies[/]");
                var task2 = ctx.AddTask("[#FF7F00]Hacking into your device[/]");
                var task3 = ctx.AddTask("[#FFFF00]Stealing login data[/]");
                var task4 = ctx.AddTask("[#00FF00]Accessing device[/]");
                var task5 = ctx.AddTask("[#0000FF]Installing virussus[/]");
                var task6 = ctx.AddTask("[#2E2B5F]Deleting windows[/]");
                var task7 = ctx.AddTask("[#8B00FF]Permanent shutdown[/]");


                while (!ctx.IsFinished)
                {
                    task1.Increment(2);
                    task2.Increment(1.9);
                    task3.Increment(1.7);
                    task4.Increment(1.5);
                    task5.Increment(1.3);
                    task6.Increment(1);
                    task7.Increment(0.8);
                    Thread.Sleep(60);
                }
            });

            Console.Clear();
            Environment.Exit(0);
        }

        // End of program test
        // Explains every test in a cool and fast effect
        public static void TypeWriter(string text)
        {
            Console.SetCursorPosition(5, 5);

            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
                Thread.Sleep(75);
            }

            Console.CursorTop = Console.CursorTop + 3;
        }

        // Shows the actions
        public static void TypeWriter2(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
                Thread.Sleep(75);
            }

            Console.CursorTop = Console.CursorTop + 3;
        }
    }
}