using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            bool gameOver = false;

            Player player = new Player();
            Map map = new Map();



            while (gameOver == false)
            {
                resetDraw();
            }

            void resetDraw()
            {
                map.Draw();
                player.Draw();
            }
        }
    }
}
