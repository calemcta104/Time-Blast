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

        public static Boolean wKeyDown, aKeyDown, sKeyDown, dKeyDown;

        int counter = 0;
        

        //brushes
        SolidBrush heroBrush = new SolidBrush(Color.Red);
        SolidBrush enemyBrush = new SolidBrush(Color.Blue);
        SolidBrush enemyBrush2 = new SolidBrush(Color.Green);

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
        #region Future hero image variables
        public static Image futureHero = Properties.Resources.FutureHero;
        #endregion
        #region pirate hero image variables
        public static Image pirateHero = Properties.Resources.PirtateHero;
        #endregion


        //lists
        //List<Hero> heroList = new List<Hero>();
        List<Enemy> enemyList = new List<Enemy>();


        //hero variables

        public static int heroSize = 50;
        int heroSpeed = 7;
        int enemySpeed = 5;

        //health
        int playerHealth = 4;
        int enemyHealth = 3;

        #endregion


        public gameScreen()
        {
            InitializeComponent();
            IanMethod();
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


            Hero.Move(heroSpeed, wKeyDown, sKeyDown, aKeyDown, dKeyDown);

            if(heroRec.IntersectsWith(enemyRec) || heroRec.IntersectsWith(enemyRec2))
            {
                
                playerHealth--;
                healthLabel.Text = $"{playerHealth}";
            }
           

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
            }
        }

        private void enemyTimer_Tick(object sender, EventArgs e)
        { 
           Enemy.enemyMove(enemySpeed);

            Refresh();
        }

        public void IanMethod()
        {

        }
        public void CalemMethod()
        {
            
        }
        private void gameScreen_Paint(object sender, PaintEventArgs e)
        {
           

            //Draws Hero Character
            //e.Graphics.FillRectangle(heroBrush,Hero.x, Hero.y, 20, 20);
            if (Form1.wildWestMode == true)
            {
                e.Graphics.DrawImage(Hero.heroImage, Hero.x, Hero.y, heroSize, heroSize);

                //if (Hero.faceUp == true)
                //{ 
                //    e.Graphics.DrawImage(wildWestHeroUp, Hero.x, Hero.y, heroSize, heroSize);
                //}
                //else if (Hero.faceDown == true)
                //{
                //    e.Graphics.DrawImage(wildWestHeroDown, Hero.x, Hero.y, heroSize, heroSize);
                //}
                //else if (Hero.faceLeft == true)
                //{
                //    e.Graphics.DrawImage(wildWestHeroLeft, Hero.x, Hero.y, heroSize, heroSize);
                //}
                //else if (Hero.faceRight == true)
                //{
                //    e.Graphics.DrawImage(wildWestHeroRight, Hero.x, Hero.y, heroSize, heroSize);
                //}
                //else if (Hero.faceUp == true && Hero.faceRight == true)
                //{
                //    e.Graphics.DrawImage(wildWestHeroUpRight, Hero.x, Hero.y, heroSize, heroSize);
                //}
                //else if (Hero.faceDown == true && Hero.faceRight == true)
                //{
                //    e.Graphics.DrawImage(wildWestHeroDownRight, Hero.x, Hero.y, heroSize, heroSize);
                //}
                //else if (Hero.faceUp == true && Hero.faceLeft == true)
                //{
                //    e.Graphics.DrawImage(wildWestHeroUpLeft, Hero.x, Hero.y, heroSize, heroSize);
                //}
                //else if (Hero.faceDown == true && Hero.faceLeft == true)
                //{
                //    e.Graphics.DrawImage(wildWestHeroDownLeft, Hero.x, Hero.y, heroSize, heroSize);
                //}
            }

            if (Form1.futureMode == true)
            {
                e.Graphics.DrawImage(futureHero, Hero.x, Hero.y, heroSize, heroSize);
            }
            if (Form1.pirateMode == true)
            {
                e.Graphics.DrawImage(pirateHero, Hero.x, Hero.y, heroSize, heroSize + 10);
            }

            //Draws Enemy Characters
            e.Graphics.FillRectangle(enemyBrush, Enemy.x, Enemy.y, 20, 20);
            e.Graphics.FillRectangle(enemyBrush2, Enemy.x2,Enemy.y2, 20, 20);

        }

    }
}
