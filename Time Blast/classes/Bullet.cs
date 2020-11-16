using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Blast
{
    class Bullet
    {
        public static int bulletX, bulletY, bulletSize;

        public static Image bulletImage;

        public Bullet(int _bulletX, int _bulletY, int _bulletSize)
        {
            bulletX = _bulletX;
            bulletY = _bulletY;
            bulletSize = _bulletSize;

        }

        public static void WildWestShoot(int _bulletSpeed)
        {

            if (Hero.faceUp == true && Hero.faceLeft == true)
            {
                bulletX = Hero.x + 50;
                bulletY = Hero.y;
            }
            else if (Hero.faceUp == true && Hero.faceRight == true)
            {
                
            }
            else if (Hero.faceDown == true && Hero.faceLeft == true)
            {
                
            }
            else if (Hero.faceDown == true && Hero.faceRight == true)
            {
                
            }
            else if (Hero.faceUp == true)
            {
                bulletX = Hero.x + gameScreen.heroSize - 10;
                bulletY = Hero.y;
            }
            else if (Hero.faceDown == true)
            {
                bulletX = Hero.x + 10;
                bulletY = Hero.y + gameScreen.heroSize;
            }
            else if (Hero.faceLeft == true)
            {
                bulletX = Hero.x + 10;
                bulletY = Hero.y + gameScreen.heroSize;
            }
            else if (Hero.faceRight == true)
            {
                
            }
        }

        public static void FutureShoot(int _bulletX, int _bulletY, int _bulletSpeed, int _bulletSize)
        { }

        public static void PirateShoot(int _bulletX, int _bulletY, int _bulletSpeed, int _bulletSize)
        { }

        public static void EnemyShoot(int _bulletX, int _bulletY, int _bulletSpeed, int _bulletSize)
        { }
    }
}
