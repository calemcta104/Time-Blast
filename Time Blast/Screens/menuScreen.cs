using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Blast.Properties;

namespace Time_Blast
{
    public partial class menuScreen : UserControl
    {
        public menuScreen()
        {
            InitializeComponent();
        }
        

        private void menuScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.titleScreen, 90, 5, 1000, 370);
            e.Graphics.DrawImage(Properties.Resources.MuralArt, 90, 380, 1000, 430);
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the gameScreen 
            // Add the User Control to the Form 
            Form f = this.FindForm();
            f.Controls.Remove(this);


            themeScreen ts = new themeScreen();
            f.Controls.Add(ts);
            ts.Focus();
        }
    }
}
