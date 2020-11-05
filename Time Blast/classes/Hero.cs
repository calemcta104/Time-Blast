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
            if (moveUp == true && moveRight == true)
            {
                heroImage = gameScreen.wildWestHeroUpRight;
            }
            if (moveDown == true && moveLeft == true)
            {
                heroImage = gameScreen.wildWestHeroDownLeft;
            }
            if (moveDown == true && moveRight == true)
            {
                heroImage = gameScreen.wildWestHeroDownRight;
            }
            if (moveUp == true && y >= 0)
            {
                y = y - speed;
                faceUp = true;
                faceDown = false;
                heroImage = gameScreen.wildWestHeroUp;
            }
            if (moveDown == true && y + 50 <= 700)
            {
                y = y + speed;
                faceDown = true;
                faceUp = false;
                heroImage = gameScreen.wildWestHeroDown;
            }
            if (moveLeft == true && x >= 0)
            {
                x = x - speed;
                faceLeft = true;
                faceRight = false;
                heroImage = gameScreen.wildWestHeroLeft;
            }
            if (moveRight == true && x + 30 <= 902)
            {
                x = x + speed;
               faceRight = true;
               faceLeft = false;
                heroImage = gameScreen.wildWestHeroRight;
            }
           
        }

        public void Shoot(int _heroX, int _heroY/*, //bulletSize*/)
        {

        }
    }
}
