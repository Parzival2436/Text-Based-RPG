using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    class Enemy : GameCharacter
    {
        public Enemy()
        {
            posX = 30;
            posY = 10;
            life = 5;
            avatar = "X";
            pathBlocked = false;
        }

        protected void MoveUp()
        {
            tileCheck(posX, posY - 1);
            if (pathBlocked)
            {
                pathBlocked = false;
                return;
            }
            posY -= 1;
        }
        protected void MoveDown()
        {
            tileCheck(posX, posY + 1);
            if (pathBlocked)
            {
                pathBlocked = false;
                return;
            }
            posY += 1;
        }
        protected void MoveLeft()
        {
            tileCheck(posX - 1, posY);
            if (pathBlocked)
            {
                pathBlocked = false;
                return;
            }
            posX -= 1;
        }
        protected void MoveRight()
        {
            tileCheck(posX + 1, posY);
            if (pathBlocked)
            {
                pathBlocked = false;
                return;
            }
            posX += 1;
        }

        public void tileCheck(int x, int y)
        {
            Map map = new Map();
            Player player = new Player();

            string tile = map.mapText[y, x];
            if (tile == map.wall)
            {
                pathBlocked = true;
            }
            if (tile == map.wall)
            {
                pathBlocked = true;
                player.life -= 1;
            }

        }
    }
}
