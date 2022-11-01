namespace Spotify_Clone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(159, 35);
            Console.SetBufferSize(159, 35);
            Console.Title = "Spotify Clone";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;

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

            // Create lists with artists for albums
            List<Artist> artistCollecion1 = new List<Artist>();
            artistCollecion1.Add(subZeroProject);

            List<Artist> artistCollecion2 = new List<Artist>();
            artistCollecion2.Add(daTweekaz);

            List<Artist> artistCollecion3 = new List<Artist>();
            artistCollecion3.Add(headhunterz);

            List<Artist> artistCollecion4 = new List<Artist>();
            artistCollecion4.Add(rebelion);

            // Create lists with artists for songs
            List<Artist> artists1 = new List<Artist>();
            artists1.Add(subZeroProject);
            artists1.Add(dbstf);

            List<Artist> artists2 = new List<Artist>();
            artists2.Add(subZeroProject);
            artists2.Add(villain);

            List<Artist> artists3 = new List<Artist>();
            artists3.Add(subZeroProject);

            List<Artist> artists5 = new List<Artist>();
            artists5.Add(daTweekaz);
            artists5.Add(hardDriver);
            artists5.Add(coone);

            List<Artist> artists7 = new List<Artist>();
            artists7.Add(headhunterz);
            artists7.Add(soundrush);
            artists7.Add(eurille);

            List<Artist> artists8 = new List<Artist>();
            artists8.Add(headhunterz);
            artists8.Add(wildstylez);
            artists8.Add(noisecontrollers);

            List<Artist> artists9 = new List<Artist>();
            artists9.Add(rebelion);
            artists9.Add(micahMargin);

            List<Artist> artists10 = new List<Artist>();
            artists10.Add(rebelion);
            artists10.Add(dimitriK);
            artists10.Add(theDarkHorror);

            List<Artist> artists11 = new List<Artist>();
            artists11.Add(rebelion);
            artists11.Add(endymion);

            List<Artist> artists12 = new List<Artist>();
            artists12.Add(rebelion);

            // Create new Song classes
            Song darkestHourTheClock = new Song("Darkest Hour (The Clock)", artists1, Genre.Hardstyle, 1, 241);
            Song theSolution = new Song("The Solution", artists2, Genre.Hardstyle, 2, 201);
            Song rennaisanceOfRave = new Song("Renaissance of Rave", artists3, Genre.Hardstyle, 3, 197);
            Song tripToMarsAstronauts = new Song("Trip To Mars (Astronauts)", artists3, Genre.Hardstyle, 4, 182);
            Song edgeOfTheUnknown = new Song("Edge of the Unknown", artists5, Genre.Hardstyle, 5, 258);
            Song byTheSword = new Song("By The Sword", artists5, Genre.Hardstyle, 6, 216);
            Song rescueMe = new Song("Rescue Me", artists7, Genre.Hardstyle, 7, 256);
            Song noOneCanStopUsNow = new Song("No One Can Stop Us Now", artists8, Genre.Hardstyle, 8, 169);
            Song aI = new Song("A.I.", artists9, Genre.Rawstyle, 9, 399);
            Song sideFxs = new Song("Sided Fx's", artists10, Genre.Terrorcore, 10, 186);
            Song dieGladiator = new Song("Die Gladiator", artists11, Genre.Hardcore, 11, 89);
            Song outtaControl = new Song("Outta Control", artists12, Genre.Terrorcore, 12, 189);

            // Create lists with songs for albums
            List<Song> contagionCollection = new List<Song>();
            contagionCollection.Add(darkestHourTheClock);
            contagionCollection.Add(theSolution);

            List<Song> rennaisanceOfRaveCollecion = new List<Song>();
            rennaisanceOfRaveCollecion.Add(rennaisanceOfRave);
            rennaisanceOfRaveCollecion.Add(tripToMarsAstronauts);

            List<Song> legendsOfTheEliteCollection = new List<Song>();
            legendsOfTheEliteCollection.Add(edgeOfTheUnknown);
            legendsOfTheEliteCollection.Add(byTheSword);

            List<Song> theReturnOfHeadhunterzCollection = new List<Song>();
            theReturnOfHeadhunterzCollection.Add(rescueMe);
            theReturnOfHeadhunterzCollection.Add(noOneCanStopUsNow);

            List<Song> artificalIntoxicationCollecion = new List<Song>();
            artificalIntoxicationCollecion.Add(aI);
            artificalIntoxicationCollecion.Add(sideFxs);

            List<Song> theFirstDoseCollecion = new List<Song>();
            theFirstDoseCollecion.Add(dieGladiator);
            theFirstDoseCollecion.Add(outtaControl);

            // Create new Album classes
            Album albumContagion = new Album(artistCollecion1, "Contagion", contagionCollection);
            Album albumRennaisanceOfRave = new Album(artistCollecion1, "Rennaisance Of Rave", rennaisanceOfRaveCollecion);
            Album albumLegendsOfTheElite = new Album(artistCollecion2, "Legends Of The Elite", legendsOfTheEliteCollection);
            Album albumTheReturnOfHeadhunterz = new Album(artistCollecion3, "The Return Of Headhunterz", theReturnOfHeadhunterzCollection);
            Album albumArtificalIntoxication = new Album(artistCollecion4, "Artifical Intoxication", artificalIntoxicationCollecion);
            Album albumTheFirstDose = new Album(artistCollecion4, "The First Dose", theFirstDoseCollecion);

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

            // Activate hardcoded test
            TestCode testCode = new TestCode();
            testCode.StartTest();
        }
    }
}