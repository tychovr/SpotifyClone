using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Clone
{
    internal class SongCollection : IPlayable
    {
        public string Title;
        private List<IPlayable> playables = new List<IPlayable>();

        public List<IPlayable> Playables { get => playables; set => playables = value; }

        public SongCollection(string title)
        {

        }

        public override string ToString()
        {
            return Title;
        }

        public List<IPlayable> ShowPlayables()
        {
            return Playables;
        }

        // Plays the song
        public void Play()
        {
            Client client = new Client();

            if (client.Shuffle)
            {
                Random random = new Random();
                int randomIndex = random.Next(0, Playables.Count);
                Playables[randomIndex].Play();
            }

            else
            {
                foreach (IPlayable playable in Playables)
                {
                    playable.Play();

                    Console.Clear();
                }
            }
        }

        // Pauses the song
        public void Pause()
        {
            Console.WriteLine("Pausing: " + Title);
        }

        // Plays the next song in queue
        public void Next()
        {
            Play();
        }

        // Stops the song
        public void Stop()
        {
            Console.WriteLine("Stopped playing: " + Title);

            Console.Clear();
        }

        // Gets the length of the song
        public int Length()
        {
            int length = 0;
            foreach (IPlayable playable in Playables)
            {
                length += playable.Length();
            }
            return length;
        }
    }
}
