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


        public static int x, y, heroSpeed, heroHealth;

        public Hero(int _x, int _y, int _heroSpeed, int _health)
        {
            x = _x;
            y = _y;
            heroSpeed = _heroSpeed;
            heroHealth = _health;

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
