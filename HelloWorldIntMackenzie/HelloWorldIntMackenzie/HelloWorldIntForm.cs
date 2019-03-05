using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldIntMackenzie
{
    public partial class frmHelloWorldInt : Form
    {
        public frmHelloWorldInt()
        {
            InitializeComponent();
        }

        private void radGerman_CheckedChanged(object sender, EventArgs e)
        {
            lblGreeting.Text = "Hallo Welt";
        }

        private void radDutch_CheckedChanged(object sender, EventArgs e)
        {
            lblGreeting.Text = "Hallo Wereld";
        }

        private void radKorean_CheckedChanged(object sender, EventArgs e)
        {
            lblGreeting.Text = "안녕하세요 세계";
        }

        private void radEng_CheckedChanged(object sender, EventArgs e)
        {
            lblGreeting.Text = "Hello, World!";
        }
    }
}
