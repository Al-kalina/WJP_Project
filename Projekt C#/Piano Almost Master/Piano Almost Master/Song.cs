using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piano_Almost_Master
{
    static class Song
    {
        //inicjalizowanie piosenek: 
        private static string[] song_1 =  { "a", "s", "d", "f", "g", "h"};
        private static int[] song1Delay = { 100, 120, 130, 140, 150 };
        private static string[] song_2 = { "A", "A", "A", "B" };
        private static int[] song2Delay = { 100, 120, 130, 140, 150 };
        private static string[] song_3 =  { "A", "A", "A", "B"};
        private static int[] song3Delay = { 100, 120, 130, 140, 150 };
        /// <summary>
        /// encoded different songs in lists 
        /// </summary>
        /// ***************************************************************************
        /// ***************************************************************************
        /// ***************************************************************************
        //sends a list with coded sounds to play in 
        public static string[] getSong(string choice)
        {
            if (choice == "song1")
                return song_1;
            else if (choice == "song2")
                return song_2;
            else if (choice == "song3")
                return song_3;
            else
                throw new SongNotFoundException("The song has not been found");
        }
    }
    public class SongNotFoundException:Exception
    {
        public SongNotFoundException(string message):base(message)
        {

        }
    }
}
