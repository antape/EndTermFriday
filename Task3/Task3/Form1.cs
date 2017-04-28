using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        int dif = 0;
        int a = 1000;
        public Form1()
        {
            InitializeComponent();
            timer.Interval = a;
            timer.Tick += timer_Tick;
            timer.Start();

        }
        void timer_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += dif;
        }

        bool press = false;

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && !press)
            {
                timer.Start();
                dif = +1;
                press = true;
            }
            else
            {
                timer.Stop();
                press = false;

            }

            if (e.KeyData == Keys.Left)
            {
                a = a - 900;
                if (a > 0) { 
                timer.Interval = a;
                timer.Start();
                } else
                {
                    timer.Interval = 1;
                    timer.Start();
                }
               
            }

        }
    }
}
