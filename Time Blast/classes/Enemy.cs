using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Blast
{
    class Enemy
    {
        public static int counter = 0;

        public static int x, y, enemyHealth;
        public static int x2, y2, enemyHealth2;

        public Enemy(int _x, int _y, int _enemyHealth)
        {
            x = _x;
            y = _y;
            enemyHealth = _enemyHealth;

        }
        
        public static void enemyMove(int speed)
        {
            counter++;

             Random moveGen = new Random();

              int enemyMovement = moveGen.Next(1, 3);

            


                //tries to match Y level
                if (enemyMovement == 1)
                {
                   if (Hero.y < y)
                    {
                        y = y - speed;
                    }
                    else if (Hero.y  > y)
                    {
                        y = y + speed;
                    }
                }
                //Tries to match X level
                else if (enemyMovement == 2)
                {
                    if (Hero.x  < x)
                    {
                        x = x - speed;
                    }
                    else if (Hero.x  > x)
                    {
                        x = x + speed;
                    }
                }

            //tries to match Y level
            if (enemyMovement == 1)
            {
                if (Hero.y < y2 - 25)
                {
                    y2 = y2 - speed - 2;
                }
                else if (Hero.y > y2)
                {
                    y2 = y2 + speed - 2;
                }
            }
            //Tries to match X level
            else if (enemyMovement == 2)
            {
                if (Hero.x < x2 - 20)
                {
                    x2 = x2 - speed - 2;
                }
                else if (Hero.x > x2)
                {
                    x2 = x2 + speed- 2;
                }
            }

        }
    }
}
