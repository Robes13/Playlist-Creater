using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlisten.Model
{
    /// <summary>
    /// This class specifyes what a song is in our program.
    /// </summary>
    internal class SongTrack
    {
        #region Fields

        private string _songTitle;
        private string _songArtist;
        private double _songLength;

        #endregion Fields

        #region Constructors

        public SongTrack(string songTitle, string songArtist, double songLength)
        {
            _songTitle = songTitle;
            _songArtist = songArtist;
            _songLength = songLength;
        }

        #endregion Constructors

        #region Properties

        public string SongTitle 
        { 
            get { return _songTitle; } 
            set { _songTitle = value; } 
        }

        public string SongArtist
        {
            get { return _songArtist; } 
            set { _songArtist = value; }
        }
        
        public double SongLength
        {
            get { return _songLength; }
            set { _songLength = value; }
        }
        #endregion Properties
    }
}
