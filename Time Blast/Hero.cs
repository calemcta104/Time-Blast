﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Blast
{
    class Hero
    {
        public static Boolean moveUp, moveDown, moveLeft, moveRight;


        public static int x, y, heroHealth;

        public Hero(int _x, int _y, int _health)
        {
            x = _x;
            y = _y;
            heroHealth = _health;

        }

        public static void Move(int speed, bool moveUp, bool moveDown, bool moveLeft, bool moveRight)
        {
            //if (moveUp)
            //{
            //    Hero.moveUp = true;
            //}
            //else if (gameScreen.aKeyDown == true)
            //{
            //    Hero.moveLeft = true;
            //}
            //else if (gameScreen.sKeyDown == true )
            //{
            //    Hero.moveDown = true;
            //}
            //else if (gameScreen.dKeyDown == true)
            //{
            //    Hero.moveRight = true;
            //}


            //if (gameScreen.wKeyDown == false)
            //{
            //    Hero.moveUp = false;
            //}
            //else if (gameScreen.aKeyDown == false)
            //{
            //    Hero.moveLeft = false;
            //}
            //else if (gameScreen.sKeyDown == false)
            //{
            //    Hero.moveDown = false;
            //}
            //else if (gameScreen.dKeyDown == false)
            //{
            //    Hero.moveRight = false;
           // }

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
