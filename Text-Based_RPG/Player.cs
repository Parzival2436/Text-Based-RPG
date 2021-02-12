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
        bool pathBlocked;

        public Player()
        {
            posX = 10;
            posY = 10;
            avatar = "A";
            pathBlocked = false;
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
                tileCheck(posX, posY - 1);
                if (pathBlocked)
                {
                    pathBlocked = false;
                    return;
                }
                posY -= 1;
            }
            if (input.KeyChar == 'a')
            {
                tileCheck(posX - 1, posY);
                if (pathBlocked)
                {
                    pathBlocked = false;
                    return;
                }
                posX -= 1;
            }
            if (input.KeyChar == 's')
            {
                tileCheck(posX, posY + 1);
                if (pathBlocked)
                {
                    pathBlocked = false;
                    return;
                }
                posY += 1;
            }
            if (input.KeyChar == 'd')
            {
                tileCheck(posX + 1, posY);
                if (pathBlocked)
                {
                    pathBlocked = false;
                    return;
                }
                posX += 1;
            }
        }

        public void tileCheck(int x, int y)
        {
            Map map = new Map();
            string tile = map.mapText[y, x];
            if (tile == map.wall)
            {
                pathBlocked = true;
            }
        }

    }

}
