using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardFinal
{
    public partial class Keyboard : Form
    {
        bool multipress = true;
        int interval = 500;
        int timePressed = 0;
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
    }
}
