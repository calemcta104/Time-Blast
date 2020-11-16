using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Time_Blast
{
    public partial class gameScreen : UserControl
    {
        #region declaring variables
        //booleans

        public static Boolean wKeyDown, aKeyDown, sKeyDown, dKeyDown, spaceKeyDown;

        int counter = 0;
        

        //brushes
        SolidBrush heroBrush = new SolidBrush(Color.Red);
        SolidBrush enemyBrush = new SolidBrush(Color.Blue);
        SolidBrush enemyBrush2 = new SolidBrush(Color.Green);
        SolidBrush objectiveBrush = new SolidBrush(Color.Yellow);
        

        //picture variables
        #region WW hero image variables
        public static Image wildWestHeroRight = Properties.Resources.WWHero;
        public static Image wildWestHeroLeft = Properties.Resources.HeroLeft;
        public static Image wildWestHeroUp = Properties.Resources.HeroUp;
        public static Image wildWestHeroDown = Properties.Resources.HeroDown;
        public static Image wildWestHeroUpRight = Properties.Resources.HeroUpperRight;
        public static Image wildWestHeroUpLeft = Properties.Resources.HeroUpperLeft;
        public static Image wildWestHeroDownLeft = Properties.Resources.HeroLowerLeft;
        public static Image wildWestHeroDownRight = Properties.Resources.HeroLowerRight;

        #endregion
        #region WW bullet image variables
        public static Image wildWestBulletRight = Properties.Resources.BulletRight;
        public static Image wildWestBulletLeft = Properties.Resources.BulletLeft;
        public static Image wildWestBulletUp = Properties.Resources.BulletUp;
        public static Image wildWestBulletDown = Properties.Resources.BulletDown;
        public static Image wildWestBulletUpRight = Properties.Resources.BulletUpperRight__1_;
        public static Image wildWestBulletUpLeft = Properties.Resources.BulletUpperLeft;
        public static Image wildWestBulletDownLeft = Properties.Resources.BulletLowerLeft;
        public static Image wildWestBulletDownRight = Properties.Resources.BulletLowerRight;
        #endregion

        #region Future hero image variables
        public static Image futureHero = Properties.Resources.FutureHero;
        #endregion
        #region pirate hero image variables
        public static Image pirateHero = Properties.Resources.PirtateHero;
        #endregion


        //lists
        //List<Hero> heroList = new List<Hero>();
        List<Enemy> enemyList = new List<Enemy>();
        List<Bullet> bulletList = new List<Bullet>();


        //hero variables / bullet variables

        public static int heroSize = 50;
        int heroSpeed = 7;
        int enemySpeed = 5;

        public static int bulletSpeed = 9;
        public static int bulletSize = 30;

        //health
        int playerHealth = 4;
        int enemyHealth = 3;

        #endregion


        public gameScreen()
        {
            InitializeComponent();
            OnStart();
        }

        public void OnStart()
        {
            Enemy enemy1 = new Enemy(Enemy.x, Enemy.y, heroSize);
            Enemy enemy2 = new Enemy(Enemy.x2, Enemy.y2, heroSize);
            enemyList.Add(enemy1);
            enemyList.Add(enemy2);

            Hero.x = 200;
            Hero.y = 200;
            Enemy.x = 400;
            Enemy.y = 100;
            Enemy.x2 = 100;
            Enemy.y2 = 400;
            Hero hero1 = new Hero(Hero.x, Hero.y, heroSize);

            
            //heroList.Add(hero1);
        }

        

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            Rectangle heroRec = new Rectangle(Hero.x, Hero.y, heroSize, heroSize);
            Rectangle enemyRec = new Rectangle(Enemy.x, Enemy.y, heroSize, heroSize);
            Rectangle enemyRec2 = new Rectangle(Enemy.x2, Enemy.y2, heroSize, heroSize);
            Rectangle objectiveRec = new Rectangle(600, 600, 20, 20);


            Hero.Move(heroSpeed, wKeyDown, sKeyDown, aKeyDown, dKeyDown);
            counter++;
            if (heroRec.IntersectsWith(enemyRec) || heroRec.IntersectsWith(enemyRec2))
            {
                
                if (counter > 50)
                {
                    playerHealth--;
                    healthLabel.Text = $"{playerHealth}";
                    counter = 0;
                }
            }
            if(playerHealth == 0)
            {
                gameTimer.Stop();
                lossLabel.Visible = true;
            }

            if (heroRec.IntersectsWith(objectiveRec) && enemyList.Count == 0)
            {
                gameTimer.Stop();
                winLabel.Visible = true;
            }
            else
            {

            }


            if (spaceKeyDown == true)
            {
                if (Form1.wildWestMode == true)
                {
                    Bullet bullet1 = new Bullet(Bullet.bulletX, Bullet.bulletY, bulletSize);
                    bulletList.Add(bullet1);
                    Bullet.WildWestShoot(bulletSpeed);

                    
                }
                //else if (Form1.futureMode == true)
                //{
                //    Bullet.FutureShoot();
                //}
                //else if (Form1.pirateMode == true)
                //{
                //    Bullet.PirateShoot();
                //}
            }
            if (Bullet.bulletMoveUp == true)
            { Bullet.bulletY = Bullet.bulletY - bulletSpeed; }
            else if (Bullet.bulletMoveUp == false)
            { Bullet.bulletY = Bullet.bulletY + bulletSpeed; }
            else if (Bullet.bulletMoveRight == true)
            { Bullet.bulletX = Bullet.bulletX + bulletSpeed; }
            else if (Bullet.bulletMoveRight == false)
            { Bullet.bulletX = Bullet.bulletX - bulletSpeed; }



            Refresh();


        }


        private void gameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wKeyDown = false;
                    break;
                case Keys.A:
                    aKeyDown = false;
                    break;
                case Keys.S:
                    sKeyDown = false;
                    break;
                case Keys.D:
                    dKeyDown = false;
                    break;
                case Keys.Space:
                    spaceKeyDown = false;
                    break;
            }
        }
        private void gameScreen_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wKeyDown = true;
                    break;
                case Keys.A:
                    aKeyDown = true;
                    break;
                case Keys.S:
                    sKeyDown = true;
                    break;
                case Keys.D:
                    dKeyDown = true;
                    break;
                case Keys.Space:
                    spaceKeyDown = true;
                    break;
            }
        }

        private void enemyTimer_Tick(object sender, EventArgs e)
        { 
            //if player health is zero they still move to rub it in your face that they win and have free will and you dont
           Enemy.enemyMove(enemySpeed);

            Refresh();
        }

        private void gameScreen_Paint(object sender, PaintEventArgs e)
        {
           

            //Draws Hero Character
            if (Form1.wildWestMode == true)
            {
                e.Graphics.DrawImage(Hero.heroImage, Hero.x, Hero.y, heroSize, heroSize);

                if(Hero.y > Enemy.y && Hero.x < Enemy.x)
                {
                    e.Graphics.DrawImage(Properties.Resources.BanditLowerLeft, Enemy.x, Enemy.y, 100, 100);
                }
                else if (Hero.y > Enemy.y && Hero.x > Enemy.x)
                {
                    e.Graphics.DrawImage(Properties.Resources.BanditLowerRight, Enemy.x, Enemy.y, 100, 100);
                }
                else if (Hero.y < Enemy.y && Hero.x > Enemy.x)
                {
                    e.Graphics.DrawImage(Properties.Resources.BanditUpperRight, Enemy.x, Enemy.y, 100, 100);
                }
                else if (Hero.y < Enemy.y && Hero.x < Enemy.x)
                {
                    e.Graphics.DrawImage(Properties.Resources.BanditUpperLeft, Enemy.x, Enemy.y, 100, 100);
                }
                else if (Hero.y == Enemy.y && Hero.x < Enemy.x)
                {
                    e.Graphics.DrawImage(Properties.Resources.banditLeft, Enemy.x, Enemy.y, 70, 70);
                }
                else if (Hero.y == Enemy.y && Hero.x > Enemy.x)
                {
                    e.Graphics.DrawImage(Properties.Resources.banditRight, Enemy.x, Enemy.y, 70, 70);
                }
                else if(Hero.y < Enemy.y && Hero.x == Enemy.x)
                {
                    e.Graphics.DrawImage(Properties.Resources.banditUp, Enemy.x, Enemy.y, 70, 70);
                }
                else if(Hero.y > Enemy.y && Hero.x == Enemy.x)
                {
                    e.Graphics.DrawImage(Properties.Resources.banditDown, Enemy.x, Enemy.y, 70, 70);
                }

                if (Hero.y > Enemy.y2 && Hero.x < Enemy.x2)
                {
                    e.Graphics.DrawImage(Properties.Resources.BanditLowerLeft, Enemy.x2, Enemy.y2, 100, 100);
                }
                else if (Hero.y > Enemy.y2 && Hero.x > Enemy.x2)
                {
                    e.Graphics.DrawImage(Properties.Resources.BanditLowerRight, Enemy.x2, Enemy.y2, 100, 100);
                }
                else if (Hero.y < Enemy.y2 && Hero.x > Enemy.x2)
                {
                    e.Graphics.DrawImage(Properties.Resources.BanditUpperRight, Enemy.x2, Enemy.y2, 100, 100);
                }
                else if (Hero.y < Enemy.y2 && Hero.x < Enemy.x2)
                {
                    e.Graphics.DrawImage(Properties.Resources.BanditUpperLeft, Enemy.x2, Enemy.y2, 100, 100);
                }
                else if (Hero.y == Enemy.y2 && Hero.x < Enemy.x2)
                {
                    e.Graphics.DrawImage(Properties.Resources.banditLeft, Enemy.x2, Enemy.y2, 70, 70);
                }
                else if (Hero.y == Enemy.y2 && Hero.x > Enemy.x2)
                {
                    e.Graphics.DrawImage(Properties.Resources.banditRight, Enemy.x2, Enemy.y2, 70, 70);
                }
                else if (Hero.y < Enemy.y2 && Hero.x == Enemy.x2)
                {
                    e.Graphics.DrawImage(Properties.Resources.banditUp, Enemy.x2, Enemy.y2, 70, 70);
                }
                else if (Hero.y > Enemy.y2 && Hero.x == Enemy.x2)
                {
                    e.Graphics.DrawImage(Properties.Resources.banditDown, Enemy.x2, Enemy.y2, 70, 70);
                }
            }

            if (Form1.futureMode == true)
            {
                e.Graphics.DrawImage(futureHero, Hero.x, Hero.y, heroSize, heroSize);

                if (Hero.y > Enemy.y && Hero.x < Enemy.x)
                {
                    e.Graphics.DrawImage(Properties.Resources.AlienLowerLeft, Enemy.x, Enemy.y, 100, 100);
                }
                else if (Hero.y > Enemy.y && Hero.x > Enemy.x)
                {
                    e.Graphics.DrawImage(Properties.Resources.AlienLowerRight, Enemy.x, Enemy.y, 100, 100);
                }
                else if (Hero.y < Enemy.y && Hero.x > Enemy.x)
                {
                    e.Graphics.DrawImage(Properties.Resources.AlienUpperRight, Enemy.x, Enemy.y, 100, 100);
                }
                else if (Hero.y < Enemy.y && Hero.x < Enemy.x)
                {
                    e.Graphics.DrawImage(Properties.Resources.AlienUpperLeft, Enemy.x, Enemy.y, 100, 100);
                }
                else if (Hero.y == Enemy.y && Hero.x < Enemy.x)
                {
                    e.Graphics.DrawImage(Properties.Resources.alienLeft, Enemy.x, Enemy.y, 70, 70);
                }
                else if (Hero.y == Enemy.y && Hero.x > Enemy.x)
                {
                    e.Graphics.DrawImage(Properties.Resources.alienRight, Enemy.x, Enemy.y, 70, 70);
                }
                else if (Hero.y < Enemy.y && Hero.x == Enemy.x)
                {
                    e.Graphics.DrawImage(Properties.Resources.alienUp, Enemy.x, Enemy.y, 70, 70);
                }
                else if (Hero.y > Enemy.y && Hero.x == Enemy.x)
                {
                    e.Graphics.DrawImage(Properties.Resources.alienDown, Enemy.x, Enemy.y, 70, 70);
                }

                if (Hero.y > Enemy.y2 && Hero.x < Enemy.x2)
                {
                    e.Graphics.DrawImage(Properties.Resources.AlienLowerLeft, Enemy.x2, Enemy.y2, 100, 100);
                }
                else if (Hero.y > Enemy.y2 && Hero.x > Enemy.x2)
                {
                    e.Graphics.DrawImage(Properties.Resources.AlienLowerRight, Enemy.x2, Enemy.y2, 100, 100);
                }
                else if (Hero.y < Enemy.y2 && Hero.x > Enemy.x2)
                {
                    e.Graphics.DrawImage(Properties.Resources.AlienUpperRight, Enemy.x2, Enemy.y2, 100, 100);
                }
                else if (Hero.y < Enemy.y2 && Hero.x < Enemy.x2)
                {
                    e.Graphics.DrawImage(Properties.Resources.AlienUpperLeft, Enemy.x2, Enemy.y2, 100, 100);
                }
                else if (Hero.y == Enemy.y2 && Hero.x < Enemy.x2)
                {
                    e.Graphics.DrawImage(Properties.Resources.alienLeft, Enemy.x2, Enemy.y2, 70, 70);
                }
                else if (Hero.y == Enemy.y2 && Hero.x > Enemy.x2)
                {
                    e.Graphics.DrawImage(Properties.Resources.alienRight, Enemy.x2, Enemy.y2, 70, 70);
                }
                else if (Hero.y < Enemy.y2 && Hero.x == Enemy.x2)
                {
                    e.Graphics.DrawImage(Properties.Resources.alienUp, Enemy.x2, Enemy.y2, 70, 70);
                }
                else if (Hero.y > Enemy.y2 && Hero.x == Enemy.x2)
                {
                    e.Graphics.DrawImage(Properties.Resources.alienDown, Enemy.x2, Enemy.y2, 70, 70);
                }
            }
            if (Form1.pirateMode == true)
            {
                e.Graphics.DrawImage(pirateHero, Hero.x, Hero.y, heroSize, heroSize + 10);

                if (Hero.y > Enemy.y && Hero.x < Enemy.x)
                {
                    e.Graphics.DrawImage(Properties.Resources.NavyLowerLeft, Enemy.x, Enemy.y, 100, 100);
                }
                else if (Hero.y > Enemy.y && Hero.x > Enemy.x)
                {
                    e.Graphics.DrawImage(Properties.Resources.NavyLowerRight, Enemy.x, Enemy.y, 100, 100);
                }
                else if (Hero.y < Enemy.y && Hero.x > Enemy.x)
                {
                    e.Graphics.DrawImage(Properties.Resources.NavyUpperRight, Enemy.x, Enemy.y, 100, 100);
                }
                else if (Hero.y < Enemy.y && Hero.x < Enemy.x)
                {
                    e.Graphics.DrawImage(Properties.Resources.NavyUpperLeft, Enemy.x, Enemy.y, 100, 100);
                }
                else if (Hero.y == Enemy.y && Hero.x < Enemy.x)
                {
                    e.Graphics.DrawImage(Properties.Resources.NavyLeft, Enemy.x, Enemy.y, 70, 70);
                }
                else if (Hero.y == Enemy.y && Hero.x > Enemy.x)
                {
                    e.Graphics.DrawImage(Properties.Resources.NavyRight, Enemy.x, Enemy.y, 70, 70);
                }
                else if (Hero.y < Enemy.y && Hero.x == Enemy.x)
                {
                    e.Graphics.DrawImage(Properties.Resources.NavyUp, Enemy.x, Enemy.y, 70, 70);
                }
                else if (Hero.y > Enemy.y && Hero.x == Enemy.x)
                {
                    e.Graphics.DrawImage(Properties.Resources.NavyDown, Enemy.x, Enemy.y, 70, 70);
                }

                if (Hero.y > Enemy.y2 && Hero.x < Enemy.x2)
                {
                    e.Graphics.DrawImage(Properties.Resources.NavyLowerLeft, Enemy.x2, Enemy.y2, 100, 100);
                }
                else if (Hero.y > Enemy.y2 && Hero.x > Enemy.x2)
                {
                    e.Graphics.DrawImage(Properties.Resources.NavyLowerRight, Enemy.x2, Enemy.y2, 100, 100);
                }
                else if (Hero.y < Enemy.y2 && Hero.x > Enemy.x2)
                {
                    e.Graphics.DrawImage(Properties.Resources.NavyUpperRight, Enemy.x2, Enemy.y2, 100, 100);
                }
                else if (Hero.y < Enemy.y2 && Hero.x < Enemy.x2)
                {
                    e.Graphics.DrawImage(Properties.Resources.NavyUpperLeft, Enemy.x2, Enemy.y2, 100, 100);
                }
                else if (Hero.y == Enemy.y2 && Hero.x < Enemy.x2)
                {
                    e.Graphics.DrawImage(Properties.Resources.NavyLeft, Enemy.x2, Enemy.y2, 70, 70);
                }
                else if (Hero.y == Enemy.y2 && Hero.x > Enemy.x2)
                {
                    e.Graphics.DrawImage(Properties.Resources.NavyRight, Enemy.x2, Enemy.y2, 70, 70);
                }
                else if (Hero.y < Enemy.y2 && Hero.x == Enemy.x2)
                {
                    e.Graphics.DrawImage(Properties.Resources.NavyUp, Enemy.x2, Enemy.y2, 70, 70);
                }
                else if (Hero.y > Enemy.y2 && Hero.x == Enemy.x2)
                {
                    e.Graphics.DrawImage(Properties.Resources.NavyDown, Enemy.x2, Enemy.y2, 70, 70);
                }
            }

            //Draws Enemy Character
            foreach (Bullet b in bulletList)
            {
                e.Graphics.DrawImage(Bullet.bulletImage, Bullet.bulletX, Bullet.bulletY, bulletSize, bulletSize);
            }

            //Draws Enemy Characters
            e.Graphics.FillRectangle(enemyBrush, Enemy.x, Enemy.y, 20, 20);
            e.Graphics.FillRectangle(enemyBrush2, Enemy.x2,Enemy.y2, 20, 20);

            //Draws Objective
            e.Graphics.FillRectangle(objectiveBrush, 600, 600, 20, 20);

        }

    }
}
