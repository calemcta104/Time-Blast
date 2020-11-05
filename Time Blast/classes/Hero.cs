using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Time_Blast
{
    class Hero
    {
        public static Boolean faceUp, faceDown, faceLeft, faceRight = false;

        
        public static int x, y, heroHealth;
        public static Image heroImage = gameScreen.wildWestHeroRight;

        public Hero(int _x, int _y, int _health)
        {
            x = _x;
            y = _y;
            heroHealth = _health;

        }

        public static void Move(int speed, bool moveUp, bool moveDown, bool moveLeft, bool moveRight)
        {
            if (moveUp == true && moveLeft == true)
            {
                heroImage = gameScreen.wildWestHeroUpLeft;
            }
            else if (moveUp == true && moveRight == true)
            {
                heroImage = gameScreen.wildWestHeroUpRight;
            }
            else if (moveDown == true && moveLeft == true)
            {
                heroImage = gameScreen.wildWestHeroDownLeft;
            }
            else if (moveDown == true && moveRight == true)
            {
                heroImage = gameScreen.wildWestHeroDownRight;
            }
            else if (moveUp == true)
            {
                heroImage = gameScreen.wildWestHeroUp;
            }
            else if (moveDown == true)
            {
                heroImage = gameScreen.wildWestHeroDown;
            }
            else if (moveLeft == true)
            {
                heroImage = gameScreen.wildWestHeroLeft;
            }
            else if (moveRight == true)
            {
                heroImage = gameScreen.wildWestHeroRight;
            }

            if (moveUp == true && y >= 0)
            {
                y = y - speed;
            }
            if (moveDown == true && y + 50 <= 700)
            {
                y = y + speed;
            }
            if (moveLeft == true && x >= 0)
            {
                x = x - speed;
            }
            if (moveRight == true && x + 30 <= 902)
            {
                x = x + speed;
            }
           


        }

        public void Shoot(int _heroX, int _heroY/*, //bulletSize*/)
        {

        }
    }
}
