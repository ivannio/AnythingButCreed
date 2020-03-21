using System;
using System.Collections.Generic;
using System.Text;

namespace AnythingButCreed
{
    class Song
    {
        public string Artist { get; set; }
        public string Title { get; set; }

        public Song(string artist, string title)
        {
            Artist = artist;
            Title = title;
        }
    }
}
