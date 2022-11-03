using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Clone
{
    internal interface IPlayable
    {
        string Play();
        string Pause();
        void Next();
        string Stop();
        int Length();
    }
}
