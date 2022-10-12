using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Clone
{
    internal class Playlist : SongCollection
    {
        public Person Owner;

        public Playlist(Person person, string title) : base(title)
        {
            Owner = person;
        }

        public void Add(IPlayable playable)
        {
            Playables.Add(playable);
        }

        public void Remove(IPlayable playable)
        {
        }

        public override string ToString()
        {
            return Owner.Name;
        }
    }
}
