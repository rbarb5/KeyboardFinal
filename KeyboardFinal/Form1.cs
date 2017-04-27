using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDialogs; //using mydialogs

namespace KeyboardFinal
{
    public partial class Keyboard : Form
    {
        bool multipress = true;  //defines variables
        int interval = 500;
        int Str_KeyStrokes = 0;
        bool firstVisit = true;
        string bbox;

        public Keyboard()
        {
            InitializeComponent();
        }

        private void modeBtn_Click(object sender, EventArgs e)
        {
            if (multipress == true)
            {
                statusBox.Text = "Predictive Mode"; //if the mode is multipress, change the statusbox text to Predictive Mode and set multipress to false
                multipress = false;
            }
            else
            {
                statusBox.Text = "Multi-press Mode"; //if the mode is predictive, change the statusbox text to multipress mode and set multipress to true
                multipress = true;
            }
        }

        private void configureDelayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            interval = Convert.ToInt16(My_Dialogs.InputBox("Please enter a delay")); //creates an inputbox to allow the user to choose their delay
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            notePadBox.AppendText("\n"); //when the enter key is pressed a new line is appended to the textbox
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine(timer1.Interval.ToString());
            builderBox.Clear();
            if (firstVisit == true) //if its the first time, set firstvisit to false, enable the timer, add 1 to Str_Keystroker and display this in the builderbox
            {
                firstVisit = false;
                timer1.Enabled = true;
                Console.WriteLine("timer starter");
                Str_KeyStrokes++;
                builderBox.Text = Convert.ToString(Str_KeyStrokes);
            }
            else if (timer1.Enabled == true) //if the timer is enabled, add 1 to Str_KeyStrokes, reset the timer
            {
                Str_KeyStrokes++;
                builderBox.Text = Convert.ToString(Str_KeyStrokes);
                timer1.Enabled = false;
                timer1.Enabled = true;
                Console.WriteLine("timer restarted");
            }
            else if (timer1.Enabled == false) //if the timer isn't enabled, set keystrokes to 1, add 1, enable timer
            {
                Str_KeyStrokes = 0;
                Str_KeyStrokes++;
                builderBox.Text = Convert.ToString(Str_KeyStrokes);
                timer1.Enabled = true;
                Console.WriteLine("timer started - not first click");
            }

            if (Str_KeyStrokes == 1)
            {
                builderBox.Text = "p";
            }
            else if (Str_KeyStrokes == 2)
            {
                builderBox.Text = "q";
            }
            else if (Str_KeyStrokes == 3) //displays the correct character for each keystroke
            {
                builderBox.Text = "r";
            }
            else if (Str_KeyStrokes == 4)
            {
                builderBox.Text = "s";
            }
            else if (Str_KeyStrokes == 5)
            {
                builderBox.Text = "1";
            }
            else if (Str_KeyStrokes == 6)
            {
                builderBox.Text = "P";
            }
            else if (Str_KeyStrokes == 7)
            {
                builderBox.Text = "Q";
            }
            else if (Str_KeyStrokes == 8)
            {
                builderBox.Text = "R";
            }
            else if (Str_KeyStrokes == 9)
            {
                builderBox.Text = "S";
            }
            if (Str_KeyStrokes == 9)
            {
                Str_KeyStrokes = 0;
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
                Str_KeyStrokes++;
                builderBox.Text = Convert.ToString(Str_KeyStrokes);
            }
            else if (timer1.Enabled == true)
            {
                Str_KeyStrokes++;
                builderBox.Text = Convert.ToString(Str_KeyStrokes);
                timer1.Enabled = false;
                timer1.Enabled = true;
                Console.WriteLine("timer restarted");
            }
            else if (timer1.Enabled == false)
            {
                Str_KeyStrokes = 0;
                Str_KeyStrokes++;
                builderBox.Text = Convert.ToString(Str_KeyStrokes);
                timer1.Enabled = true;
                Console.WriteLine("timer started - not first click");
            }
            if (Str_KeyStrokes == 1)
            {
                builderBox.Text = "t";
            }
            else if (Str_KeyStrokes == 2)
            {
                builderBox.Text = "u";
            }
            else if (Str_KeyStrokes == 3) //displays the correct character for each keystroke
            {
                builderBox.Text = "v";
            }
            else if (Str_KeyStrokes == 4)
            {
                builderBox.Text = "2";
            }
            else if (Str_KeyStrokes == 5)
            {
                builderBox.Text = "T";
            }
            else if (Str_KeyStrokes == 6)
            {
                builderBox.Text = "U";
            }
            else if (Str_KeyStrokes == 7)
            {
                builderBox.Text = "V";
            }
            if (Str_KeyStrokes == 7)
            {
                Str_KeyStrokes = 0;
            }

        }

        private void emptyBtn_Click(object sender, EventArgs e)
        {
            notePadBox.AppendText(builderBox.Text);
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {

        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine(timer1.Interval.ToString());
            builderBox.Clear();
            if (firstVisit == true)
            {
                firstVisit = false;
                timer1.Enabled = true;
                Console.WriteLine("timer starter");
                Str_KeyStrokes++;
                builderBox.Text = Convert.ToString(Str_KeyStrokes);
            }
            else if (timer1.Enabled == true)
            {
                Str_KeyStrokes++;
                builderBox.Text = Convert.ToString(Str_KeyStrokes);
                timer1.Enabled = false;
                timer1.Enabled = true;
                Console.WriteLine("timer restarted");
            }
            else if (timer1.Enabled == false)
            {
                Str_KeyStrokes = 0;
                Str_KeyStrokes++;
                builderBox.Text = Convert.ToString(Str_KeyStrokes);
                timer1.Enabled = true;
                Console.WriteLine("timer started - not first click");
            }
            if (Str_KeyStrokes == 1)
            {
                builderBox.Text = "w";
            }
            else if (Str_KeyStrokes == 2)
            {
                builderBox.Text = "x";
            }
            else if (Str_KeyStrokes == 3) //displays the correct character for each keystroke
            {
                builderBox.Text = "y";
            }
            else if (Str_KeyStrokes == 4)
            {
                builderBox.Text = "z";
            }
            else if (Str_KeyStrokes == 5)
            {
                builderBox.Text = "3";
            }
            else if (Str_KeyStrokes == 6)
            {
                builderBox.Text = "W";
            }
            else if (Str_KeyStrokes == 7)
            {
                builderBox.Text = "X";
            }
            else if (Str_KeyStrokes == 8)
            {
                builderBox.Text = "Y";
            }
            else if (Str_KeyStrokes == 9)
            {
                builderBox.Text = "Z";
            }
            if (Str_KeyStrokes == 9)
            {
                Str_KeyStrokes = 0;
            }

        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine(timer1.Interval.ToString());
            builderBox.Clear();
            if (firstVisit == true)
            {
                firstVisit = false;
                timer1.Enabled = true;
                Console.WriteLine("timer starter");
                Str_KeyStrokes++;
                builderBox.Text = Convert.ToString(Str_KeyStrokes);
            }
            else if (timer1.Enabled == true)
            {
                Str_KeyStrokes++;
                builderBox.Text = Convert.ToString(Str_KeyStrokes);
                timer1.Enabled = false;
                timer1.Enabled = true;
                Console.WriteLine("timer restarted");
            }
            else if (timer1.Enabled == false)
            {
                Str_KeyStrokes = 0;
                Str_KeyStrokes++;
                builderBox.Text = Convert.ToString(Str_KeyStrokes);
                timer1.Enabled = true;
                Console.WriteLine("timer started - not first click");
            }
            if (Str_KeyStrokes == 1)
            {
                builderBox.Text = "g";
            }
            else if (Str_KeyStrokes == 2)
            {
                builderBox.Text = "h";
            }
            else if (Str_KeyStrokes == 3) //displays the correct character for each keystroke
            {
                builderBox.Text = "i";
            }
            else if (Str_KeyStrokes == 4)
            {
                builderBox.Text = "4";
            }
            else if (Str_KeyStrokes == 5)
            {
                builderBox.Text = "G";
            }
            else if (Str_KeyStrokes == 6)
            {
                builderBox.Text = "H";
            }
            else if (Str_KeyStrokes == 7)
            {
                builderBox.Text = "I";
            }
            if (Str_KeyStrokes == 7)
            {
                Str_KeyStrokes = 0;
            }

        }
    }
}

