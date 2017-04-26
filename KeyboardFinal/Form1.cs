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
