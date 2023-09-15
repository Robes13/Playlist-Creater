using Playlisten.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlisten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMusic myMusic = new MyMusic();
            myMusic.Start();
        }
    }
}
