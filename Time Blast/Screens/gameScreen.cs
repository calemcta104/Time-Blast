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

        Random moveGen = new Random();
        public static int enemyMovement;
        int counter = 0;
        

        //brushes
        SolidBrush heroBrush = new SolidBrush(Color.Red);
        SolidBrush enemyBrush = new SolidBrush(Color.Blue);

        //lists
        //List<Hero> heroList = new List<Hero>();


        //hero variables

        public static int heroSize = 20;
        int heroSpeed = 7;

        //health
        int playerHealth = 8;
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
            Hero.x = 200;
            Hero.y = 200;
            enemyMovement = moveGen.Next(1, 3);
            Hero hero1 = new Hero(Hero.x, Hero.y, heroSize);
            Enemy enemy1 = new Enemy(Enemy.x, Enemy.y, heroSize);
            //heroList.Add(hero1);
        }

        

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            Rectangle heroRec = new Rectangle(Hero.x, Hero.y, heroSize, heroSize);
            Rectangle enemyRec = new Rectangle(Enemy.x, Enemy.y, heroSize, heroSize);


            Hero.Move(heroSpeed, wKeyDown, sKeyDown, aKeyDown, dKeyDown);
            

            

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
           Enemy.enemyMove(heroSpeed);
            
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
            e.Graphics.FillRectangle(heroBrush,Hero.x, Hero.y, 20, 20);

            //Draws Enemy Characters
            e.Graphics.FillRectangle(enemyBrush, Enemy.x, Enemy.y, 20, 20);
        }

    }
}
