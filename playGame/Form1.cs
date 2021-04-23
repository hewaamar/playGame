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

namespace playGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {

        }

        private void playButton_Click_1(object sender, EventArgs e)
        {

            // make play button click sound
            SoundPlayer playButtonSound = new SoundPlayer(Properties.Resources.playButtonSound);
            playButtonSound.Play();

            // make play button disappear
            playButton.Visible = false;

            // change the countdown number from 3 to 2
            counter.Text = "Game starts in 2";

            // play beep sound
            SoundPlayer counterBeep = new SoundPlayer(Properties.Resources.counterBeep);
            counterBeep.Play();

            // wait 1 second
            Refresh();
            Thread.Sleep(1500);

            // change the countdown number from 2 to 1
            counter.Text = "Game starts in 1";

            // play beep sound
            counterBeep.Play();

            // wait 1 second
            Refresh();
            Thread.Sleep(1500);

            // change the countdown number from 2 to 1
            counter.Text = "Game starts in 0";

            // play beep sound
            counterBeep.Play();

            // wait 1 second
            Refresh();
            Thread.Sleep(1500);

            //make counter disappear
            counter.Visible = false;

            // play beep sound
            counterBeep.Play();

            //make "GO!!!" appear
            go.Visible = true;

            // play GO sound
            SoundPlayer goSound = new SoundPlayer(Properties.Resources.goSound);
            goSound.Play();

            // make "GO!!! change colour"
            go.BackColor = Color.YellowGreen;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
