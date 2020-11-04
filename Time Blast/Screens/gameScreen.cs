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
        Boolean wKeyDown, aKeyDown, sKeyDown, dKeyDown, wildWestMode, futureMode, pirateMode;

        SolidBrush heroBrush = new SolidBrush(Color.Red);

        List<Hero> heroList = new List<Hero>();

        Hero hero1;
        int heroSize = 20;
        int heroSpeed = 7;

        int playerHealth = 8;
        int enemyHealth = 3;

#endregion
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            Rectangle heroRec = new Rectangle(heroList[0].heroX, heroList[0].heroY, heroSize, heroSize);

            Refresh();
        }


        private void gameScreen_Paint(object sender, PaintEventArgs e)
        {
            foreach( Hero h in heroList)
            {
                e.Graphics.FillRectangle(heroBrush, h.heroX, h.heroY, heroSize, heroSize);
            }
        }
        


        public gameScreen()
        {
            InitializeComponent();
            IanMethod();
            OnStart();
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


        public void OnStart()
        {
            int heroX = this.Width / 2- heroSize;
            int heroY = this.Height / 2 - heroSize;
            hero1 = new Hero(heroX, heroY, heroSpeed, heroSize);
            heroList.Add(hero1);
        }

       


        public void IanMethod()
        {

        }
        public void CalemMethod()
        {
            
        }

    }
}
