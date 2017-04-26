using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDialogs;

namespace KeyboardFinal
{
    public partial class Keyboard : Form
    {
        bool multipress = true;
        int interval = 500;
        int timesPressed = 0;
        bool firstVisit = true;

        public Keyboard()
        {
            InitializeComponent();
        }

        private void modeBtn_Click(object sender, EventArgs e)
        {
            if (multipress == true)
            {
                statusBox.Text = "Predictive Mode";
                multipress = false;
            }
            else
            {
                statusBox.Text = "Multi-press Mode";
                multipress = true;
            }
        }

        private void configureDelayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            interval = Convert.ToInt16(My_Dialogs.InputBox("Please enter a delay"));
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            notePadBox.AppendText("\n");
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine(timer1.Interval.ToString());
            builderBox.Clear();
            if (firstVisit == true)
            {
                firstVisit = false;
                timer1.Enabled = true;
                Console.WriteLine("timer starter");
                timesPressed++;
                builderBox.Text = Convert.ToString(timesPressed);
            }
            else if (timer1.Enabled == true)
            {
                timesPressed++;
                builderBox.Text = Convert.ToString(timesPressed);
                timer1.Enabled = false;
                timer1.Enabled = true;
                Console.WriteLine("timer restarted");
            }
            else if (timer1.Enabled == false)
            {
                timesPressed = 0;
                timesPressed++;
                builderBox.Text = Convert.ToString(timesPressed);
                timer1.Enabled = true;
                Console.WriteLine("timer started - not first click");
            }

            if (timesPressed == 1)
            {
                builderBox.Text = "p";
            }
            else if (timesPressed == 2)
            {
                builderBox.Text = "q";
            }
            else if (timesPressed == 3)
            {
                builderBox.Text = "r";
            }
            else if (timesPressed == 4)
            {
                builderBox.Text = "s";
            }
            else if (timesPressed == 5)
            {
                builderBox.Text = "1";
            }
            else if (timesPressed == 6)
            {
                builderBox.Text = "P";
            }
            else if (timesPressed == 7)
            {
                builderBox.Text = "Q";
            }
            else if (timesPressed == 8)
            {
                builderBox.Text = "R";
            }
            else if (timesPressed == 8)
            {
                builderBox.Text = "S";
            }
        }












        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = interval;
            timer1.Tick += new EventHandler(timerEnded);
        }

        private void timerEnded(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Console.WriteLine("timer ended");
        }











        private void twoBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine(timer1.Interval.ToString());
            builderBox.Clear();
            if (firstVisit == true)
            {
                firstVisit = false;
                timer1.Enabled = true;
                Console.WriteLine("timer starter");
                timesPressed++;
                builderBox.Text = Convert.ToString(timesPressed);
            }
            else if (timer1.Enabled == true)
            {
                timesPressed++;
                builderBox.Text = Convert.ToString(timesPressed);
                timer1.Enabled = false;
                timer1.Enabled = true;
                Console.WriteLine("timer restarted");
            }
            else if (timer1.Enabled == false)
            {
                timesPressed = 0;
                timesPressed++;
                builderBox.Text = Convert.ToString(timesPressed);
                timer1.Enabled = true;
                Console.WriteLine("timer started - not first click");
            }
        }
    }
}
