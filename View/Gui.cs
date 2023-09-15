using Playlisten.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlisten.View
{
    /// <summary>
    /// This class is responsible for handling everything gui related
    /// </summary>
    internal class Gui
    {
        // This byte keep tracks of how many songs that currently are in the system.
        private byte _count;
        /// <summary>
        /// This method explains the program.
        /// </summary>
        public void StartGui()
        {
            Console.WriteLine("This program makes you able to add music from the currently stored music, to playlists in this program.");
            Console.WriteLine("Press any key to start");
        }
        /// <summary>
        /// This method prints all the songs from a given list.
        /// </summary>
        /// <param name="tracks"> This list contains all the current songs in the system.</param>
        public void PrintAllAvailableSongs(List<SongTrack> tracks)
        {
            Console.Clear();
            byte count = 1;
            Console.WriteLine("These are all the songs available: ");
            Console.WriteLine();
            foreach (SongTrack track in tracks) 
            {
                Console.WriteLine($"{count}. {track.SongTitle}, {track.SongArtist}, {track.SongLength} mins");
                count++;
            }
            count += 2;
            _count = count;
        }
        /// <summary>
        /// Explains that to create a new playlist, the user just has to type new
        /// </summary>
        public void CreatePlayListText()
        {
            Console.SetCursorPosition(0, _count);
            Console.WriteLine("Write 'new' to create a new playlist");
        }
        /// <summary>
        /// This method asks for the name of the playlist
        /// </summary>
        public void WritePlayListName()
        {
            Console.SetCursorPosition(0, _count);
            Console.WriteLine("Please enter the name of the playlist you wish to create: ");
            Console.SetCursorPosition(0, _count + 1);
        }
        /// <summary>
        ///  Asks the user to write the number of the song
        /// </summary>
        public void WriteSongNumber()
        {
            DeleteExplainationText();
            Console.SetCursorPosition(0, _count);
            Console.WriteLine("Please enter the number of the song you want to add to your playlist, or write end to stop adding songs. ");
            Console.SetCursorPosition(0, _count + 1);
        }
        /// <summary>
        /// Prints all the current playlists
        /// </summary>
        /// <param name="playlists"></param>
        public void PrintAllPlayliste(List<Playlist> playlists) 
        {
            byte count = 1;
            if (playlists.Count > 0)
            {
                Console.SetCursorPosition(50, 0);
                Console.Write("Existing playlist:");
            }
            foreach (Playlist playlist in playlists) 
            {
                Console.SetCursorPosition(50, count);
                Console.Write($"{count}. {playlist.PlayListName}");
                count++;
            }
        }
        /// <summary>
        /// Places a white space at some specific places to make the gui look cleaner.
        /// </summary>
        public void DeleteExplainationText()
        {
            for(int i = 0; i < 90; i++)
            {
                Console.SetCursorPosition(i, _count);
                Console.Write(' ');
            }
            for(int i = 0; i < 90; i++)
            {
                Console.SetCursorPosition(i, _count + 1);
                Console.Write(" ");
            }
            Console.SetCursorPosition(0, _count);
        }
    }
}