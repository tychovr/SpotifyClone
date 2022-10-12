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
        private List<IPlayable> playables;

        public List<IPlayable> Playables { get => playables; set => playables = value; }

        public SongCollection(string title)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }

        public List<IPlayable> ShowPlayables()
        {
            return Playables;
        }

        public void Play()
        {
            Console.WriteLine("Playing: " + Title);
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
