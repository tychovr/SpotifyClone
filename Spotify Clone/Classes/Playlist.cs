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
        public string Title;

        public Playlist(Person person, string title) : base(title)
        {
            Owner = person;
            Title = title;
        }

        // Adds IPlayable to the playlist
        public void Add(IPlayable playable)
        {
            Playables.Add(playable);
        }

        // Removes IPlayable from the playlist
        public void Remove(IPlayable playable)
        {
            Playables.Remove(playable);
        }

        public override string ToString()
        {
            return Owner.Name;
        }
    }
}
