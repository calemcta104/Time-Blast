using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Time_Blast
{
    class Bullet
    {
        public static int bulletX, bulletY, bulletSize;
        public static Boolean bulletMoveUp, bulletMoveRight, bulletMoveDown, bulletMoveLeft;
        public static Image bulletImage;

        public Bullet(int _bulletX, int _bulletY, int _bulletSize)
        {
            bulletX = _bulletX;
            bulletY = _bulletY;
            bulletSize = _bulletSize;

        }

        public static void WildWestShoot(int _bulletSpeed)
        {
            if (Hero.faceUp == true)
            {
                bulletX = Hero.x + gameScreen.heroSize - 10;
                bulletY = Hero.y;
                bulletImage = gameScreen.wildWestBulletUp;
                bulletMoveUp = true;
                bulletMoveLeft = false;
                bulletMoveRight = false;
                bulletMoveDown = false;

            }
            else if (Hero.faceDown == true)
            {
                bulletX = Hero.x + 10;
                bulletY = Hero.y + gameScreen.heroSize;
                bulletImage = gameScreen.wildWestBulletDown;
                bulletMoveDown = true;
                bulletMoveUp = false;
                bulletMoveLeft = false;
                bulletMoveRight = false;
            }
            if (Hero.faceLeft == true)
            {
                bulletX = Hero.x;
                bulletY = Hero.y + 20;
                bulletImage = gameScreen.wildWestBulletLeft;
                bulletMoveLeft = true;
                bulletMoveRight = false;
                bulletMoveUp = false;
                bulletMoveDown = false;
            }
            else if (Hero.faceRight == true)
            {
                bulletX = Hero.x + gameScreen.heroSize;
                bulletY = Hero.y + gameScreen.heroSize - 10;
                bulletImage = gameScreen.wildWestBulletRight;
                bulletMoveRight = true;
                bulletMoveLeft = false;
                bulletMoveUp = false;
                bulletMoveDown = false;
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
