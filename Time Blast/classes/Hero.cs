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
                gameScreen.heroSize = 70;
            }
            else if (moveUp == true && moveRight == true)
            {
                heroImage = gameScreen.wildWestHeroUpRight;
                gameScreen.heroSize = 70;
            }
            else if (moveDown == true && moveLeft == true)
            {
                heroImage = gameScreen.wildWestHeroDownLeft;
                gameScreen.heroSize = 70;
            }
            else if (moveDown == true && moveRight == true)
            {
                heroImage = gameScreen.wildWestHeroDownRight;
                gameScreen.heroSize = 70;
            }
            else if (moveUp == true)
            {
                heroImage = gameScreen.wildWestHeroUp;
                gameScreen.heroSize = 50;
            }
            else if (moveDown == true)
            {
                heroImage = gameScreen.wildWestHeroDown;
                gameScreen.heroSize = 50;
            }
            else if (moveLeft == true)
            {
                heroImage = gameScreen.wildWestHeroLeft;
                gameScreen.heroSize = 50;
            }
            else if (moveRight == true)
            {
                heroImage = gameScreen.wildWestHeroRight;
                gameScreen.heroSize = 50;
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
