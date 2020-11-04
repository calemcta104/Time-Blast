using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Blast
{
    class Hero
    {
        public static Boolean moveUp, moveDown, moveLeft, moveRight;

        public static int heroX, heroY, heroSpeed, heroHealth, heroSize;

        public Hero(int _heroX, int _heroY, int _heroSpeed, int _health, int _heroSize)
        {
            heroX = _heroX;
            heroY = _heroY;
            heroSpeed = _heroSpeed;
            heroHealth = _health;
            heroSize = _heroSize;

        }

        public void Move(int _heroSpeed)
        {
            heroSpeed = _heroSpeed;
        }

        public void Shoot(int _heroX, int _heroY/*, //bulletSize*/)
        {

        }
    }
}
