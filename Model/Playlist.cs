using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Playlisten.Model
{
    /// <summary>
    /// This is the playlist class.
    /// </summary>
    internal class Playlist
    {
        #region Fields

        private LinkedList<SongTrack> songList = new LinkedList<SongTrack>();
        private string _playListName;
        private List<Playlist> _playlists = new List<Playlist>();

        #endregion Fields

        #region Constructors
        // empty constructor so I can call the method through it.
        public Playlist() 
        {
            
        }
        // Specifying what makes up a playlist object.
        public Playlist(LinkedList<SongTrack> playlist, string playListName)
        {
            songList = playlist;
            _playListName = playListName;
        }

        #endregion Constructors

        #region Properties

        public LinkedList<SongTrack> playlists 
        { 
            get { return songList; } 
        }

        public string PlayListName 
        { 
            get { return _playListName; } 
            set { _playListName = value; }
        }

        public List<Playlist> Playlists
        { 
            get { return _playlists; } 
            set { _playlists = value; }
        }

        #endregion Properties

        #region Methods
        /// <summary>
        /// Adding the newly created playlist to a list made of playlist objects.
        /// </summary>
        /// <param name="playlist"></param>
        public void AddPlaylist(Playlist playlist) 
        {
            _playlists.Add(playlist);
        }

        #endregion Methods
    }
}
