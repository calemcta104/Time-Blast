using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Blast
{
    public partial class gameScreen : UserControl
    {
        #region declaring variables
        //booleans

        public static Boolean wKeyDown, aKeyDown, sKeyDown, dKeyDown;


        //brushes
        SolidBrush heroBrush = new SolidBrush(Color.Red);

        //lists
        //List<Hero> heroList = new List<Hero>();


        //hero variables

        int heroSize = 20;
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

            Hero hero1 = new Hero(Hero.x, Hero.y, heroSize);
            //heroList.Add(hero1);
        }

        

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //Rectangle heroRec = new Rectangle(Hero.x, Hero.y, heroSize, heroSize);


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
        public void IanMethod()
        {

        }
        public void CalemMethod()
        {
            
        }
        private void gameScreen_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.FillRectangle(heroBrush, Hero.x, Hero.y, heroSize, heroSize);
            e.Graphics.FillRectangle(heroBrush,Hero.x, Hero.y, 20, 20);
        }

    }
}
