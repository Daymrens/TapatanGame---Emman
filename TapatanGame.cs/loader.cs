using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TapatanGame.cs
{
    public partial class loader : Form
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public loader()
        {
            timer.Tick += new EventHandler(Timer1_Tick);
            InitializeComponent();
            timer.Start();
            InitializeTimer();



        }
        private void InitializeTimer()
        {
            // Call this procedure when the application starts.  
            // Set to 1 second.  
            timer.Interval = 7000;
            timer.Tick += new EventHandler(Timer1_Tick);

            // Enable timer.  
            timer.Enabled = true;

         
        }
        private void Timer1_Tick(object Sender, EventArgs e)
        {
            // Set the caption to the current time.  
            if(timer.Interval == 7000)
            {
                timer.Stop();
                NewForm();
                timer.Stop();
            }
           
        }
        private void NewForm()
        {
            timer.Stop();
            this.Hide();
            GamePage f1 = new GamePage();
            f1.Show();
        }
    }
}
