using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlisten.Model
{
    /// <summary>
    /// This class just reads key and reads console line.
    /// </summary>
    internal class Read
    {
        public void ReadKey()
        {
            Console.ReadKey();
        }
        public string ReadLineReturn()
        {
            string readLine = Console.ReadLine();
            return readLine;
        }
    }
}
