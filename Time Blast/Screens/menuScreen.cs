﻿using System;
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
            // Create an instance of the gameScreen 

            gameScreen gs = new gameScreen();



            // Add the User Control to the Form 

            this.Controls.Add(gs);

            Form f = this.FindForm();

            f.Controls.Remove(this);


        }

        private void menuScreen_Load(object sender, EventArgs e)
        {

        }
    }
}