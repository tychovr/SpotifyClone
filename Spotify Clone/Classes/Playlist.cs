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

        public Playlist(Person person) : base(person)
        {
            Owner = person;
        }
        {
        }
}
}
