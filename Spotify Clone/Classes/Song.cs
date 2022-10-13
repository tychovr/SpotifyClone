﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Clone
{
    internal class Song : IPlayable
    {
        private string title;
        private List<Artist> artists;
        private Genre songGenre;

        public string Title { get { return title; } set { title = value; } }
        public List<Artist> Artists { get { return artists; } set { artists = value; } }
        public Genre SongGenre { get { return songGenre; } set { songGenre = value; } }

        private int Duration;

        public Song(List<Artist> artist, Genre genre, int songID, int duration)
        {
            Artists = artist;
            SongGenre = genre;
            Duration = duration;
        }

        public int Length()
        {

        }

        public void Next()
        {
            throw new NotImplementedException();
        }

        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Play()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
