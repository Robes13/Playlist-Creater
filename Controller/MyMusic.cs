using Playlisten.Model;
using Playlisten.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Playlisten.Controller
{
    /// <summary>
    /// This class runs the entire program.
    /// </summary>
    internal class MyMusic
    {
        public void Start()
        {
            // All these SongTrack's are all the current songs in the system. (Think of this as from input from a sd card or database, or so on.)
            SongTrack kvindeMin = new SongTrack("Kvinde min", "Kim Larsen", 2.3);
            SongTrack thisIsMyLife = new SongTrack("This Is My Life", "Kim Larsen", 2.8);
            SongTrack rabalderStraede = new SongTrack("Rabalder Stræde", "Kim Larsen", 2.1);
            SongTrack allMyLove = new SongTrack("All My Love", "Rocazino", 3.2);
            List<SongTrack> availAbleSongs = new List<SongTrack>()
            {
                kvindeMin, thisIsMyLife, rabalderStraede, allMyLove
            };
            // End of song input

            // Initiating new gui object.
            Gui gui = new Gui();
            gui.StartGui();

            // Initiating new read object.
            Read read = new Read();
            read.ReadKey();


            // Initiating new playlist object.
            Playlist playlist = new Playlist();

            while (true)
            {
                gui.PrintAllAvailableSongs(availAbleSongs);
                gui.PrintAllPlayliste(playlist.Playlists);


                gui.CreatePlayListText();

                // Here I used the function .ToLower() to ensure it would match with 'new', if it doesnt match the program will just run again.
                string whatToDo = read.ReadLineReturn().ToLower();


                if (whatToDo == "new")
                {
                    gui.DeleteExplainationText();
                    gui.WritePlayListName();
                    string playListName = read.ReadLineReturn().ToLower();
                    gui.WriteSongNumber();
                    playlist.AddPlaylist(CreatePlayList(availAbleSongs, playListName));
                }
            }
        }
        /// <summary>
        /// This method makes it possible to create new playlist, and it will loop until the user doesnt want to add more 
        /// songs to their playlist.
        /// </summary>
        /// <param name="tracksAvailalbe"> The songs available to choose from</param>
        /// <param name="playlistName"> The playlist name.</param>
        /// <returns></returns>
        public Playlist CreatePlayList(List<SongTrack> tracksAvailalbe, string playlistName)
        {
            Read read = new Read();
            LinkedList<SongTrack> playList = new LinkedList<SongTrack>();
            while (true)
            {
                string whatToDo = read.ReadLineReturn();
                if (whatToDo == "end")
                {
                    break;
                }
                else
                {
                    byte count = 1;
                    foreach (SongTrack track in tracksAvailalbe)
                    {
                        if (count == Convert.ToByte(whatToDo))
                        {
                            playList.AddLast(track);
                        }
                        count++;
                    }
                }
            }
            Playlist play = new Playlist(playList, playlistName);
            return play;

        }
    }
}
