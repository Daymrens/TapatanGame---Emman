using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace TapatanGame.cs
{
    public partial class Form1 : Form
    {
        public SoundPlayer player = new SoundPlayer();
        private System.Windows.Forms.Timer loadtime;
        public Form1()
        {
            InitializeComponent();
            PlayMusic();
            btnPlay.Parent = pictureBox1;
        }

        #region OptionsFuncs
        private void Playbtn(object sender, EventArgs e)
        {
            this.Hide();
            loader load = new loader();
            load.Show();
        }

        private void optbtn(object sender, EventArgs e)
        {
            optpnl.BringToFront();
            panel2.BringToFront();
        }

        private void exitOpt(object sender, EventArgs e)
        {
            optpnl.SendToBack();
            panel2.SendToBack();
        }

        private void btnExitGame(object sender, EventArgs e)
        {
            exitpnl.BringToFront();
        }
        private void exitYes(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void exitNo(object sender, EventArgs e)
        {
            exitpnl.SendToBack();
        }
        #endregion

        private void PlayMusic()
        {
            try
            {
                player.SoundLocation = @"C:\path\to\your\bgmusic\bg1.wav";
                player.PlayLooping();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error playing music: " + ex.Message);
            }

        }

        private void musicoff(object sender, EventArgs e)
        {
            player.Stop();
        }
        private void musicon(object sender, EventArgs e)
        {

            PlayMusic();
        }
    }
}
