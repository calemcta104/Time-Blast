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
        public static Boolean faceUp = false, faceDown = false, faceLeft = false, faceRight = true;

        
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
                faceUp = true;
                faceLeft = true;
            }
            else if (moveUp == true && moveRight == true)
            {
                heroImage = gameScreen.wildWestHeroUpRight;
                faceUp = true;
                faceRight = true;
            }
            else if (moveDown == true && moveLeft == true)
            {
                heroImage = gameScreen.wildWestHeroDownLeft;
                faceDown = true;
                faceLeft = true;
            }
            else if (moveDown == true && moveRight == true)
            {
                heroImage = gameScreen.wildWestHeroDownRight;
                faceRight = true;
                faceDown = true;
            }
            else if (moveUp == true)
            {
                heroImage = gameScreen.wildWestHeroUp;
                faceUp = true;
            }
            else if (moveDown == true)
            {
                heroImage = gameScreen.wildWestHeroDown;
                faceDown = true;
            }
            else if (moveLeft == true)
            {
                heroImage = gameScreen.wildWestHeroLeft;
                faceLeft = true;
            }
            else if (moveRight == true)
            {
                heroImage = gameScreen.wildWestHeroRight;
                faceRight = true;
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
