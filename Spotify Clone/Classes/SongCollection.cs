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

        public void Play()
        {
            Client client = new Client();

            if (client.Shuffle)
            {
                Random random = new Random();
                int randomIndex = random.Next(0, Playables.Count);
                Playables[randomIndex].Play();

                Console.WriteLine("Playing " + Playables[randomIndex].ToString());
            }

            else
            {
                foreach (IPlayable playable in Playables)
                {
                    playable.Play();
                    Console.WriteLine("Playing " + playable.ToString());

                    Thread.Sleep(3000);
                    Console.Clear();
                }
            }

            if (client.Repeat)
            {
                Play();
            }
        }

        public void Pause()
        {
            Console.WriteLine("Pausing: " + Title);
        }

        public void Next()
        {
            Play();
        }

        public void Stop()
        {
            Console.WriteLine("Stopped playing: " + Title);

            Thread.Sleep(3000);
            Console.Clear();
        }

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
