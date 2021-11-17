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

        void Disabler()
        {
            btnTic1.Enabled = false;
            btnTic2.Enabled = false;
            btnTic3.Enabled = false;
            btnTic4.Enabled = false;
            btnTic5.Enabled = false;
            btnTic6.Enabled = false;
            btnTic7.Enabled = false;
            btnTic8.Enabled = false;
            btnTic9.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            count = 0;
        }

        private void btnTic1_Click(object sender, EventArgs e)
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

                if (btnTic2.Text == "O" && btnTic3.Text == "O")
                {
                    Disabler();
                    MessageBox.Show("Player O wins the game!");
                }
                if (btnTic4.Text == "O" && btnTic7.Text == "O")
                {
                    Disabler();
                    MessageBox.Show("Player O wins the game!");
                }
                if (btnTic5.Text == "O" && btnTic9.Text == "O")
                {
                    Disabler();
                    MessageBox.Show("Player O wins the game!");
                }
            }
            else
            {
                count += 1;
                isXorO = false;
                btnTic1.Text = "X";
                btnTic1.Enabled = false;

                if (btnTic2.Text == "X" && btnTic3.Text == "X")
                {
                    Disabler();
                    MessageBox.Show("Player x wins the game!");
                }
                if (btnTic4.Text == "X" && btnTic7.Text == "X")
                {
                    Disabler();
                    MessageBox.Show("Player x wins the game!");
                }
                if (btnTic5.Text == "X" && btnTic9.Text == "X")
                {
                    Disabler();
                    MessageBox.Show("Player x wins the game!");
                }

            }

            if (count == 9)
            {
                MessageBox.Show("Game is draw!!");
            }
        
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
                btnTic3.Enabled = false;

                if (btnTic1.Text == "O" && btnTic2.Text == "O")
                {
                    Disabler();
                    MessageBox.Show("Player O wins the game!");
                }
                if (btnTic5.Text == "O" && btnTic7.Text == "O")
                {
                    Disabler();
                    MessageBox.Show("Player O wins the game!");
                }
                if (btnTic6.Text == "O" && btnTic9.Text == "O")
                {
                    Disabler();
                    MessageBox.Show("Player O wins the game!");
                }
            }
            else
            {
                count += 1;
                isXorO = false;
                btnTic3.Text = "X";
                btnTic3.Enabled = false;

                if (btnTic1.Text == "X" && btnTic2.Text == "X")
                {
                    Disabler();
                    MessageBox.Show("Player x wins the game!");
                }
                if (btnTic5.Text == "X" && btnTic7.Text == "X")
                {
                    Disabler();
                    MessageBox.Show("Player x wins the game!");
                }
                if (btnTic6.Text == "X" && btnTic9.Text == "X")
                {
                    Disabler();
                    MessageBox.Show("Player x wins the game!");
                }

            }

            if (count == 9)
            {
                MessageBox.Show("Game is draw!!");
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

                if (btnTic1.Text == "O" && btnTic3.Text == "O")
                {
                    Disabler();
                    MessageBox.Show("Player O wins the game!");
                }
                if (btnTic5.Text == "O" && btnTic7.Text == "O")
                {
                    Disabler();
                    MessageBox.Show("Player O wins the game!");
                }
            }
            else
            {
                count += 1;
                isXorO = false;
                btnTic2.Text = "X";
                btnTic2.Enabled = false;

                if (btnTic1.Text == "X" && btnTic3.Text == "X")
                {
                    Disabler();
                    MessageBox.Show("Player x wins the game!");
                }
                if (btnTic5.Text == "X" && btnTic8.Text == "X")
                {
                    Disabler();
                    MessageBox.Show("Player x wins the game!");
                }

            }

            if (count == 9)
            {
                MessageBox.Show("Game is draw!!");
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

                if (btnTic1.Text == "O" && btnTic7.Text == "O")
                {
                    Disabler();
                    MessageBox.Show("Player x wins the game!");
                }
                if (btnTic5.Text == "O" && btnTic6.Text == "O")
                {
                    Disabler();
                    MessageBox.Show("Player O wins the game!");
                }
            }
            else
            {
                count += 1;
                isXorO = false;
                btnTic4.Text = "X";
                btnTic4.Enabled = false;

                if (btnTic1.Text == "X" && btnTic7.Text == "X")
                {
                    Disabler();
                    MessageBox.Show("Player x wins the game!");
                }
                if (btnTic5.Text == "X" && btnTic6.Text == "X")
                {
                    Disabler();
                    MessageBox.Show("Player x wins the game!");
                }

            }

            if (count == 9)
            {
                MessageBox.Show("Game is draw!!");
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

                if (btnTic1.Text == "O" && btnTic9.Text == "O")
                {
                    Disabler();
                    MessageBox.Show("Player O wins the game!");
                }
                if (btnTic2.Text == "O" && btnTic8.Text == "O")
                {
                    Disabler();
                    MessageBox.Show("Player O wins the game!");
                }
                if (btnTic3.Text == "O" && btnTic7.Text == "O")
                {
                    Disabler();
                    MessageBox.Show("Player O wins the game!");
                }
                if (btnTic4.Text == "O" && btnTic6.Text == "O")
                {
                    Disabler();
                    MessageBox.Show("Player O wins the game!");
                }
            }
            else
            {
                count += 1;
                isXorO = false;
                btnTic5.Text = "X";
                btnTic5.Enabled = false;

                if (btnTic1.Text == "X" && btnTic9.Text == "X")
                {
                    Disabler();
                    MessageBox.Show("Player x wins the game!");
                }
                if (btnTic2.Text == "X" && btnTic8.Text == "X")
                {
                    Disabler();
                    MessageBox.Show("Player x wins the game!");
                }
                if (btnTic3.Text == "X" && btnTic7.Text == "X")
                {
                    Disabler();
                    MessageBox.Show("Player x wins the game!");
                }
                if (btnTic4.Text == "X" && btnTic5.Text == "X")
                {
                    Disabler();
                    MessageBox.Show("Player x wins the game!");
                }

            }

            if (count == 9)
            {
                MessageBox.Show("Game is draw!!");
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

                if (btnTic3.Text == "O" && btnTic9.Text == "O")
                {
                    Disabler();
                    MessageBox.Show("Player O wins the game!");
                }
                if (btnTic4.Text == "O" && btnTic5.Text == "O")
                {
                    Disabler();
                    MessageBox.Show("Player O wins the game!");
                }
            }
            else
            {
                count += 1;
                isXorO = false;
                btnTic6.Text = "X";
                btnTic6.Enabled = false;

                if (btnTic3.Text == "X" && btnTic9.Text == "X")
                {
                    Disabler();
                    MessageBox.Show("Player x wins the game!");
                }
                if (btnTic4.Text == "X" && btnTic5.Text == "X")
                {
                    Disabler();
                    MessageBox.Show("Player x wins the game!");
                }

            }

            if (count == 9)
            {
                MessageBox.Show("Game is draw!!");
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

                if (btnTic1.Text == "O" && btnTic4.Text == "O")
                {
                    Disabler();
                    MessageBox.Show("Player O wins the game!");
                }
                if (btnTic3.Text == "O" && btnTic5.Text == "O")
                {
                    Disabler();
                    MessageBox.Show("Player O wins the game!");
                }
                if (btnTic8.Text == "O" && btnTic9.Text == "O")
                {
                    Disabler();
                    MessageBox.Show("Player O wins the game!");
                }
            }
            else
            {
                count += 1;
                isXorO = false;
                btnTic7.Text = "X";
                btnTic7.Enabled = false;

                if (btnTic1.Text == "X" && btnTic4.Text == "X")
                {
                    Disabler();
                    MessageBox.Show("Player x wins the game!");
                }
                if (btnTic3.Text == "X" && btnTic5.Text == "X")
                {
                    Disabler();
                    MessageBox.Show("Player x wins the game!");
                }
                if (btnTic8.Text == "X" && btnTic9.Text == "X")
                {
                    Disabler();
                    MessageBox.Show("Player x wins the game!");
                }

            }

            if (count == 9)
            {
                MessageBox.Show("Game is draw!!");
            
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

                if (btnTic2.Text == "O" && btnTic5.Text == "O")
                {
                    Disabler();
                    MessageBox.Show("Player O wins the game!");
                }
                if (btnTic7.Text == "O" && btnTic9.Text == "O")
                {
                    Disabler();
                    MessageBox.Show("Player O wins the game!");
                }
            }
            else
            {
                count += 1;
                isXorO = false;
                btnTic8.Text = "X";
                btnTic8.Enabled = false;

                if (btnTic2.Text == "X" && btnTic5.Text == "X")
                {
                    Disabler();
                    MessageBox.Show("Player x wins the game!");
                }
                if (btnTic7.Text == "X" && btnTic9.Text == "X")
                {
                    Disabler();
                    MessageBox.Show("Player x wins the game!");
                }

            }

            if (count == 9)
            {
                MessageBox.Show("Game is draw!!");
            
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

                if (btnTic3.Text == "O" && btnTic6.Text == "O")
                {
                    Disabler();
                    MessageBox.Show("Player O wins the game!");
                }
                if (btnTic1.Text == "O" && btnTic5.Text == "O")
                {
                    Disabler();
                    MessageBox.Show("Player O wins the game!");
                }
                if (btnTic7.Text == "O" && btnTic8.Text == "O")
                {
                    Disabler();
                    MessageBox.Show("Player O wins the game!");
                }
            }
            else
            {
                count += 1;
                isXorO = false;
                btnTic9.Text = "X";
                btnTic9.Enabled = false;

                if (btnTic3.Text == "X" && btnTic6.Text == "X")
                {
                    Disabler();
                    MessageBox.Show("Player x wins the game!");
                }
                if (btnTic1.Text == "X" && btnTic5.Text == "X")
                {
                    Disabler();
                    MessageBox.Show("Player x wins the game!");
                }
                if (btnTic7.Text == "X" && btnTic8.Text == "X")
                {
                    Disabler();
                    MessageBox.Show("Player x wins the game!");
                }

            }

            if (count == 9)
            {
                MessageBox.Show("Game is draw!!");
            }
        
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnTic1.Enabled = true;
            btnTic1.Text = "";
            btnTic2.Enabled = true;
            btnTic2.Text = "";
            btnTic3.Enabled = true;
            btnTic3.Text = "";
            btnTic4.Enabled = true;
            btnTic4.Text = "";
            btnTic5.Enabled = true;
            btnTic5.Text = "";
            btnTic6.Enabled = true;
            btnTic6.Text = "";
            btnTic7.Enabled = true;
            btnTic7.Text = "";
            btnTic8.Enabled = true;
            btnTic8.Text = "";
            btnTic9.Enabled = true;
            btnTic9.Text = "";

            count = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
