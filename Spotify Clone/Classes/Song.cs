using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Clone
{
    internal class Song : IPlayable
    {
        private string title;
        private List<Artist> artists = new List<Artist>();
        private Genre songGenre;
        private int duration;

        public string Title { get { return title; } set { title = value; } }
        public List<Artist> Artists { get { return artists; } set { artists = value; } }
        public Genre SongGenre { get { return songGenre; } set { songGenre = value; } }
        public int Duration { get { return duration; } set { duration = value; } }

        public Song(string title, List<Artist> artist, Genre genre, int songID, int duration)
        {
            Title = title;
            Artists = artist;
            SongGenre = genre;
            Duration = duration;
        }

        public int Length()
        {
            return Duration;
        }

        public void Next()
        {
            Play();
        }

        public void Pause()
        {
            Program.TypeWriter2("Pausing: " + Title);
        }

        public void Play()
        {
            Console.SetCursorPosition(5, 10);
            Program.TypeWriter2("Playing: " + Title);
        }

        public void Stop()
        {
            Program.TypeWriter2("Stopped playing: " + Title);
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
