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

            // Create new Album classes
            Album album1 = new Album(new List<Artist>(), "Contagion", new List<Song>());
            Album album2 = new Album(new List<Artist>(), "Rennaisance Of Rave", new List<Song>());
            Album album3 = new Album(new List<Artist>(), "Legends Of The Elite", new List<Song>());
            Album album4 = new Album(new List<Artist>(), "The Return Of Headhunterz", new List<Song>());
            Album album5 = new Album(new List<Artist>(), "Artifical Intoxication", new List<Song>());
            Album album6 = new Album(new List<Artist>(), "The First Dose", new List<Song>());

            // Create new Artist classes
            Artist artist1 = new Artist(new List<Album>(), "Sub Zero Project");
            Artist artist2 = new Artist(new List<Album>(), "Da Tweekaz");
            Artist artist3 = new Artist(new List<Album>(), "Headhunterz");
            Artist artist4 = new Artist(new List<Album>(), "Rebelion");

            // Create new Song classes
            Song song1 = new Song("Renaissance of Rave", new List<Artist>(), Genre.Hardstyle, 1, 197);
            Song song2 = new Song("Trip To Mars (Astronauts)", new List<Artist>(), Genre.Hardstyle, 2, 182);
            Song song3 = new Song("Darkest Hour (The Clock", new List<Artist>(), Genre.Hardstyle, 3, 241);
            Song song4 = new Song("The Solution", new List<Artist>(), Genre.Hardstyle, 4, 201);
            Song song5 = new Song("Edge of the Unknown", new List<Artist>(), Genre.Hardstyle, 5, 258);
            Song song6 = new Song("By The Sword", new List<Artist>(), Genre.Hardstyle, 6, 216);
            Song song7 = new Song("Rescue Me", new List<Artist>(), Genre.Hardstyle, 7, 256);
            Song song8 = new Song("No One Can Stop Us Now", new List<Artist>(), Genre.Hardstyle, 8, 169);
            Song song9 = new Song("A.I.", new List<Artist>(), Genre.Rawstyle, 9, 399);
            Song song10 = new Song("Sided Fx's", new List<Artist>(), Genre.Terrorcore, 10, 186);
        }
    }
}