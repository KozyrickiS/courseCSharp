using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMove
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.MovementPlayer(0, 0, 0, 0);
            Console.ReadKey();
        }
    }
}
