using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        int turn = 2;
        int disabled = 0;
        public void checkWinner(int disabled)
        {
            if (disabled == 9)
            {
                if (button1.Text == button2.Text && button1.Text == button3.Text)//1st row
                    label1.Text = button1.Text + " wins!!";
                else if (button4.Text == button5.Text && button4.Text == button6.Text)//2nd row
                    label1.Text = button1.Text + " wins!!";
                else if (button7.Text == button8.Text && button7.Text == button9.Text)//3rd row
                    label1.Text = button1.Text + " wins!!";
                else if (button1.Text == button4.Text && button1.Text == button7.Text)//left col
                    label1.Text = button1.Text + " wins!!";
                else if (button2.Text == button5.Text && button2.Text == button8.Text)//middle col
                    label1.Text = button1.Text + " wins!!";
                else if (button3.Text == button6.Text && button3.Text == button9.Text)//left col
                    label1.Text = button1.Text + " wins!!";
                else if (button1.Text == button5.Text && button1.Text == button9.Text)//top left to bottom right
                    label1.Text = button1.Text + " wins!!";
                else if (button3.Text == button5.Text && button3.Text == button7.Text)//top right to bottom left
                    label1.Text = button1.Text + " wins!!";
            }
        }
        public bool whosTurn(int turn)
        {
            return turn % 2 == 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (whosTurn(turn))
            {
                button1.Text = "X";
                label1.Text = "Os Turn";
                turn = 1;
            }  else
            {
                button1.Text = "O";
                label1.Text = "Xs Turn";
                turn = 2;
            }
        
            button1.Enabled = false;
            disabled++;
            checkWinner(disabled);
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (whosTurn(turn))
            {
                button2.Text = "X";
                label1.Text = "Os Turn";
                turn = 1;
            }
            else
            {
                button2.Text = "O";
                label1.Text = "Xs Turn";
                turn = 2;
            }

            button2.Enabled = false;
            disabled++;
            checkWinner(disabled);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (whosTurn(turn))
            {
                button3.Text = "X";
                label1.Text = "Os Turn";
                turn = 1;
            }
            else
            {
                button3.Text = "O";
                label1.Text = "Xs Turn";
                turn = 2;
            }

            button3.Enabled = false;
            disabled++;
            checkWinner(disabled);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (whosTurn(turn))
            {
                button4.Text = "X";
                label1.Text = "Os Turn";
                turn = 1;
            }
            else
            {
                button4.Text = "O";
                label1.Text = "Xs Turn";
                turn = 2;
            }

            button4.Enabled = false;
            disabled++;
            checkWinner(disabled);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (whosTurn(turn))
            {
                button5.Text = "X";
                label1.Text = "Os Turn";
                turn = 1;
            }
            else
            {
                button5.Text = "O";
                label1.Text = "Xs Turn";
                turn = 2;
            }

            button5.Enabled = false;
            disabled++;
            checkWinner(disabled);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (whosTurn(turn))
            {
                button6.Text = "X";
                label1.Text = "Os Turn";
                turn = 1;
            }
            else
            {
                button6.Text = "O";
                label1.Text = "Xs Turn";
                turn = 2;
            }

            button6.Enabled = false;
            disabled++;
            checkWinner(disabled);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (whosTurn(turn))
            {
                button7.Text = "X";
                label1.Text = "Os Turn";
                turn = 1;
            }
            else
            {
                button7.Text = "O";
                label1.Text = "Xs Turn";
                turn = 2;
            }

            button7.Enabled = false;
            disabled++;
            checkWinner(disabled);
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (whosTurn(turn))
            {
                button8.Text = "X";
                label1.Text = "Os Turn";
                turn = 1;
            }
            else
            {
                button8.Text = "O";
                label1.Text = "Xs Turn";
                turn = 2;
            }

            button8.Enabled = false;
            disabled++;
            checkWinner(disabled);
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (whosTurn(turn))
            {
                button9.Text = "X";
                label1.Text = "Os Turn";
                turn = 1;
            }
            else
            {
                button9.Text = "O";
                label1.Text = "Xs Turn";
                turn = 2;
            }

            button9.Enabled = false;
            disabled++;
            checkWinner(disabled);
        }
    }
}
