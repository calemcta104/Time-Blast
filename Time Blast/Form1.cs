using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Blast
{
    public partial class Form1 : Form
    {
        //global variables for theme modes
        public static Boolean wildWestMode, futureMode, pirateMode;

        public Form1()
        {
            InitializeComponent();
            OnStart();
        }

        public void OnStart()
        {
            // Create an instance of the MainScreen 

            menuScreen ms = new menuScreen();



            // Add the User Control to the Form 

            this.Controls.Add(ms);
        }
    }
}
