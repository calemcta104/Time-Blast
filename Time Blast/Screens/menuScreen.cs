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
    public partial class menuScreen : UserControl
    {
        public menuScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            gameScreen gs = new gameScreen();
            f.Controls.Add(gs);
            gs.Focus();

        }

        private void menuScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
