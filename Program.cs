using System;
using System.Collections.Generic;

namespace nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();

        //     Define a List, named goodSongs, that will hold tuples consisting of two strings.
        List<(string, string)> goodSongs = new List<(string, string)>();

        //     Define a HashSet, named allSongs, that contains 7 tuples. Each tuple should contain two string values:
        HashSet<(string, string)> allSongs = new HashSet<(string, string)>();
        //     The name of an artist
        //     A song by that artist
        allSongs.Add(("Nickelback", "Photograph"));
        allSongs.Add(("Nickelback", "How You Remind Me"));
        allSongs.Add(("Nickelback", "Burn It To The Ground"));
        allSongs.Add(("Green Day", "Brain Stew"));
        allSongs.Add(("Phoenix", "1901"));
        allSongs.Add(("Weezer", "Hash Pipe"));
        allSongs.Add(("Brand New", "Seventy Times 7"));
        //     Make sure that some of the songs are from the band Nickelback. You can see a list of their greatest hits on Amazon.

        //     Once the set is populated with 7 tuples, iterate over the set of songs, and check if the band name is "Nickelback".
        //     If the band is not Nickelback, then add it to the goodSongs list.
            foreach((string, string) song in allSongs)
            {
            Console.WriteLine($"{song.Item1}");

            if(song.Item1 != "Nickelback")
                {
                goodSongs.Add(song);
                }
            }

            Console.WriteLine();
        //     USe another foreach loop to print out all the good songs.
            foreach((string, string) songs in goodSongs)
            {
            Console.WriteLine($"{songs.Item1} : {songs.Item2}");
            }
        }
    }
}
