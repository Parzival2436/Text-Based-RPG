using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class Player : GameCharacter
    {
        public Player()
        {
            posX = 10;
            posY = 10;
            life = 5;
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
            Enemy enemy = new Enemy();

            string tile = map.mapText[y, x];
            if (tile == map.wall)
            {
                pathBlocked = true;
            }
            if (tile == enemy.avatar)
            {
                pathBlocked = true;
                enemy.life -= 1;
            }
        }

        public void showHud()
        {
            Console.SetCursorPosition(2, 21);
            Console.Write("Life: " + life);
        }

    }

}
