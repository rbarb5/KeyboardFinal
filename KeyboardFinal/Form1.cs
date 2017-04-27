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
            interval = Convert.ToInt16(My_Dialogs.InputBox("Please enter a delay"));
            timer1.Interval = interval;
            
             //creates an inputbox to allow the user to choose their delay
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
                builderBox.Text = " ";
            }
            else if (Str_KeyStrokes == 2)
            {
                builderBox.Text = "0";
            }
            if (Str_KeyStrokes == 2)
            {
                Str_KeyStrokes = 0;
            }


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

        private void fiveBtn_Click(object sender, EventArgs e)
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
                builderBox.Text = "j";
            }
            else if (Str_KeyStrokes == 2)
            {
                builderBox.Text = "k";
            }
            else if (Str_KeyStrokes == 3) //displays the correct character for each keystroke
            {
                builderBox.Text = "l";
            }
            else if (Str_KeyStrokes == 4)
            {
                builderBox.Text = "5";
            }
            else if (Str_KeyStrokes == 5)
            {
                builderBox.Text = "J";
            }
            else if (Str_KeyStrokes == 6)
            {
                builderBox.Text = "K";
            }
            else if (Str_KeyStrokes == 7)
            {
                builderBox.Text = "L";
            }
            if (Str_KeyStrokes == 7)
            {
                Str_KeyStrokes = 0;
            }

        }

        private void sixBtn_Click(object sender, EventArgs e)
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
                builderBox.Text = "m";
            }
            else if (Str_KeyStrokes == 2)
            {
                builderBox.Text = "n";
            }
            else if (Str_KeyStrokes == 3) //displays the correct character for each keystroke
            {
                builderBox.Text = "o";
            }
            else if (Str_KeyStrokes == 4)
            {
                builderBox.Text = "5";
            }
            else if (Str_KeyStrokes == 5)
            {
                builderBox.Text = "M";
            }
            else if (Str_KeyStrokes == 6)
            {
                builderBox.Text = "N";
            }
            else if (Str_KeyStrokes == 7)
            {
                builderBox.Text = "O";
            }
            if (Str_KeyStrokes == 7)
            {
                Str_KeyStrokes = 0;
            }
        }

        private void sevenBtn_Click(object sender, EventArgs e)
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
                builderBox.Text = ".";
            }
            else if (Str_KeyStrokes == 2)
            {
                builderBox.Text = ",";
            }
            else if (Str_KeyStrokes == 3) //displays the correct character for each keystroke
            {
                builderBox.Text = "'";
            }
            if (Str_KeyStrokes == 3)
            {
                Str_KeyStrokes = 0;
            }
        }

        private void eightBtn_Click(object sender, EventArgs e)
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
                builderBox.Text = "a";
            }
            else if (Str_KeyStrokes == 2)
            {
                builderBox.Text = "b";
            }
            else if (Str_KeyStrokes == 3) //displays the correct character for each keystroke
            {
                builderBox.Text = "c";
            }
            else if (Str_KeyStrokes == 4)
            {
                builderBox.Text = "8";
            }
            else if (Str_KeyStrokes == 5)
            {
                builderBox.Text = "A";
            }
            else if (Str_KeyStrokes == 6)
            {
                builderBox.Text = "B";
            }
            else if (Str_KeyStrokes == 7)
            {
                builderBox.Text = "C";
            }
            if (Str_KeyStrokes == 7)
            {
                Str_KeyStrokes = 0;
            }
        }

        private void nineBtn_Click(object sender, EventArgs e)
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
                builderBox.Text = "d";
            }
            else if (Str_KeyStrokes == 2)
            {
                builderBox.Text = "e";
            }
            else if (Str_KeyStrokes == 3) //displays the correct character for each keystroke
            {
                builderBox.Text = "f";
            }
            else if (Str_KeyStrokes == 4)
            {
                builderBox.Text = "9";
            }
            else if (Str_KeyStrokes == 5)
            {
                builderBox.Text = "D";
            }
            else if (Str_KeyStrokes == 6)
            {
                builderBox.Text = "E";
            }
            else if (Str_KeyStrokes == 7)
            {
                builderBox.Text = "F";
            }
            if (Str_KeyStrokes == 7)
            {
                Str_KeyStrokes = 0;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notePadBox.Clear(); //clears the text box
        }

        private void hashBtn_Click(object sender, EventArgs e)
        {
            builderBox.Text = "#";
        }

        private void starBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

