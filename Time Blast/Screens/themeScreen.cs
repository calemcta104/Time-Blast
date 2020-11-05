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
    public partial class themeScreen : UserControl
    {
        public themeScreen()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            
        }

        private void pirateButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            gameScreen gs = new gameScreen();
            f.Controls.Add(gs);
            gs.Focus();

            Form1.pirateMode = true;
            Form1.futureMode = false;
            Form1.wildWestMode = false;
        }

        private void futureButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            gameScreen gs = new gameScreen();
            f.Controls.Add(gs);
            gs.Focus();

            Form1.pirateMode = false;
            Form1.futureMode = true;
            Form1.wildWestMode = false;
        }

        private void wildWestButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            gameScreen gs = new gameScreen();
            f.Controls.Add(gs);
            gs.Focus();

            Form1.pirateMode = false;
            Form1.futureMode = false;
            Form1.wildWestMode = true;
        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            menuScreen ms = new menuScreen();
            f.Controls.Add(ms);
            ms.Focus();
        }
    }
}
