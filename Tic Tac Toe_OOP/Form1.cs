using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_OOP
{
    public partial class Form1 : Form
    {
        int count = 0;
        bool isXorO;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                count += 1;
                btnTic1.Text = "X";
                btnTic1.Enabled = false;
                isXorO = false;
            }
            else if (!isXorO)
            {
                isXorO = true;
                count += 1;
                btnTic1.Text = "O";
                btnTic1.Enabled = false;
            }
            else
            {
                count += 1;
                isXorO = false;
                btnTic1.Text = "X";
                btnTic1.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTic3_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                count += 1;
                btnTic3.Text = "X";
                btnTic3.Enabled = false;
                isXorO = false;
            }
            else if (!isXorO)
            {
                isXorO = true;
                count += 1;
                btnTic3.Text = "O";
                btnTic1.Enabled = false;
            }
            else
            {
                count += 1;
                isXorO = false;
                btnTic3.Text = "X";
                btnTic3.Enabled = false;
            }
        }

        private void btnTic2_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                count += 1;
                btnTic2.Text = "X";
                btnTic2.Enabled = false;
                isXorO = false;
            }
            else if (!isXorO)
            {
                isXorO = true;
                count += 1;
                btnTic2.Text = "O";
                btnTic2.Enabled = false;
            }
            else
            {
                count += 1;
                isXorO = false;
                btnTic2.Text = "X";
                btnTic2.Enabled = false;
            }
        }

        private void btnTic4_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                count += 1;
                btnTic4.Text = "X";
                btnTic4.Enabled = false;
                isXorO = false;
            }
            else if (!isXorO)
            {
                isXorO = true;
                count += 1;
                btnTic4.Text = "O";
                btnTic4.Enabled = false;
            }
            else
            {
                count += 1;
                isXorO = false;
                btnTic4.Text = "X";
                btnTic4.Enabled = false;
            }
        }

        private void btnTic5_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                count += 1;
                btnTic5.Text = "X";
                btnTic5.Enabled = false;
                isXorO = false;
            }
            else if (!isXorO)
            {
                isXorO = true;
                count += 1;
                btnTic5.Text = "O";
                btnTic5.Enabled = false;
            }
            else
            {
                count += 1;
                isXorO = false;
                btnTic5.Text = "X";
                btnTic5.Enabled = false;
            }
        }

        private void btnTic6_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                count += 1;
                btnTic6.Text = "X";
                btnTic6.Enabled = false;
                isXorO = false;
            }
            else if (!isXorO)
            {
                isXorO = true;
                count += 1;
                btnTic6.Text = "O";
                btnTic6.Enabled = false;
            }
            else
            {
                count += 1;
                isXorO = false;
                btnTic6.Text = "X";
                btnTic6.Enabled = false;
            }
        }

        private void btnTic7_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                count += 1;
                btnTic7.Text = "X";
                btnTic7.Enabled = false;
                isXorO = false;
            }
            else if (!isXorO)
            {
                isXorO = true;
                count += 1;
                btnTic7.Text = "O";
                btnTic7.Enabled = false;
            }
            else
            {
                count += 1;
                isXorO = false;
                btnTic7.Text = "X";
                btnTic7.Enabled = false;
            }
        }

        private void btnTic8_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                count += 1;
                btnTic8.Text = "X";
                btnTic8.Enabled = false;
                isXorO = false;
            }
            else if (!isXorO)
            {
                isXorO = true;
                count += 1;
                btnTic8.Text = "O";
                btnTic8.Enabled = false;
            }
            else
            {
                count += 1;
                isXorO = false;
                btnTic8.Text = "X";
                btnTic8.Enabled = false;
            }
        }

        private void btnTic9_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                count += 1;
                btnTic9.Text = "X";
                btnTic9.Enabled = false;
                isXorO = false;
            }
            else if (!isXorO)
            {
                isXorO = true;
                count += 1;
                btnTic9.Text = "O";
                btnTic9.Enabled = false;
            }
            else
            {
                count += 1;
                isXorO = false;
                btnTic9.Text = "X";
                btnTic9.Enabled = false;
            }
        }
    }
}
