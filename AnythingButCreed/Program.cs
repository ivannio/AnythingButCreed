using System;
using System.Collections.Generic;
using System.Linq;

namespace AnythingButCreed
{
    class Program
    {
        static void Main(string[] args)
        {
            var allSongs = new List<Song>();

            allSongs.Add(new Song("Creed", "With Arms Wide Open"));
            allSongs.Add(new Song("Creed", "Higher"));
            allSongs.Add(new Song("Gorillaz", "Welcome To The World of the Plastic Beach"));
            allSongs.Add(new Song("Gorillaz", "White Flag"));
            allSongs.Add(new Song("Gorillaz", "Rhinestone Eyes"));
            allSongs.Add(new Song("Gorillaz", "Stylo"));
            allSongs.Add(new Song("Gorillaz", "Superfast Jellyfish"));
            allSongs.Add(new Song("Gorillaz", "Welcome To The World of the Plastic Beach"));
            allSongs.Add(new Song("Gorillaz", "Empire Ants"));
            allSongs.Add(new Song("Gorillaz", "Glitter Freeze"));
            allSongs.Add(new Song("Gorillaz", "Some Kind of Nature"));
            allSongs.Add(new Song("Gorillaz", "On Melancholy Hill"));

            var goodSongs = new List<Song>();           
            
            goodSongs.AddRange(allSongs.Where(song => song.Artist != "Creed"));            

            foreach (var song in goodSongs)
            {
                Console.WriteLine($"{song.Artist}: {song.Title}");
            }            
        }
    }
}
