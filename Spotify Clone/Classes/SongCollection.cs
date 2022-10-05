using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Clone
{
    internal class SongCollection
    {
        public string Title;
        private List<IPlayable> Playables;

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
    }
}
