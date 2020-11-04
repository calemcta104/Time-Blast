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


        int playerHealth = 8;
        int enemyHealth = 3;

#endregion
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            Rectangle heroRec = new Rectangle(Hero.heroX, Hero.heroY, Hero.heroSize, Hero.heroSize);
        }

        private void gameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(heroBrush, Hero.heroX, Hero.heroY, Hero.heroSize, Hero.heroSize);
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

        }

        private void gameScreen_Load(object sender, EventArgs e)
        {

        }


        public void IanMethod()
        {

        }
        public void CalemMethod()
        {
            
        }

    }
}
