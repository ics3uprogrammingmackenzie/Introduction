/*
 * Created by: Mackenzie Brown Plourde
 * Created on: Feb. 7, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #4 - SchoolApp
 * This program displays Hello World but with an exit menu
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolAppMackenzie
{
    public partial class frmSchoolApp : Form
    {
        public frmSchoolApp()
        {
            InitializeComponent();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            //close the program
            this.Close();
        }
    }
}
