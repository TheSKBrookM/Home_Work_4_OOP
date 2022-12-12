using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_4_2
{
    internal class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("\nPlay song...\n");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("\nPause play song...\n");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("\nStop play song...\n");
        }
        public void Record()
        {
            Console.WriteLine("\nRecord song...\n");
        }
        void IRecodable.Pause()
        {
            Console.WriteLine("\nPause recording song...\n");
        }
        void IRecodable.Stop()
        {
            Console.WriteLine("\nStop recording song...\n");
        }
    }
}
