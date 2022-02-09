using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Play_Game
{
    public partial class displayScreen : Form
    {
        public displayScreen()
        {
            InitializeComponent();
        }

        private void startLabel_Click(object sender, EventArgs e)
        {
            //title hidden, timer unhidden
            startLabel.Visible = false;
            countdownDisplay.Visible = true;

            //soundplayer
            SoundPlayer beep = new SoundPlayer(Properties.Resources.beep);
            beep.Play();
            Refresh();
            Thread.Sleep(1000);

            //countdown
            countdownDisplay.Text = "2";
            Refresh();
            beep.Play();
            Thread.Sleep(1000);

            countdownDisplay.Text = "1";
            Refresh();
            beep.Play();
            Thread.Sleep(1000);

            countdownDisplay.Visible = false;

            //display cat photo
            BackColor = Color.Red;
            catImage.Visible = true;
            Refresh();

            //flashing
            Thread.Sleep(1000);
            BackColor = Color.Orange;
            Refresh();

            Thread.Sleep(1000);
            BackColor = Color.Yellow;
            Refresh();

            Thread.Sleep(1000);
            BackColor = Color.Green;
            Refresh();

            Thread.Sleep(1000);
            BackColor = Color.Blue;
            Refresh();

            Thread.Sleep(1000);
            BackColor = Color.Purple;
            Refresh();           
        }
    }
}
