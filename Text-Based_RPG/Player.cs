using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class Player
    {
        int posX;
        int posY;
        string avatar;

        public Player()
        {
            posX = 10;
            posY = 10;
            avatar = "A";
        }

        public void Draw()
        {
            //Console.Clear();
            Console.SetCursorPosition(posX, posY);
            Console.Write(avatar);
            Move();
        }

        protected void Move()
        {
            ConsoleKeyInfo input;
            input = Console.ReadKey(true);
            if (input.KeyChar == 'w')
            {
                tileCheck(posX, posY + 1);
                posY -= 1;
            }
            if (input.KeyChar == 'a')
            {
                tileCheck(posX - 1, posY);
                posX -= 1;
            }
            if (input.KeyChar == 's')
            {
                tileCheck(posX, posY - 1);
                posY += 1;
            }
            if (input.KeyChar == 'd')
            {
                tileCheck(posX + 1, posY);
                posX += 1;
            }
        }

        protected void tileCheck(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            char tile = Console.ReadKey().KeyChar;
            avatar = Char.ToString(tile); //debug
        }

    }

}
