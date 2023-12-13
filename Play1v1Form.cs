using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe__FormsApp
{
    public partial class Play1v1Form : Form
    {
        public string pname1 { get; set; }
        public string pname2 { get; set; }

        Boolean checker;
        int plusone;
        int moveCount = 0;

        void DisableButtons()
        {
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
        }
        private void NewGame()
        {
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;

            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";

            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
            button10.BackColor = Color.White;
        }
        private bool CheckWinner(string symbol)
        {
            // Check rows
            if ((button2.Text == symbol && button3.Text == symbol && button4.Text == symbol) ||
                (button5.Text == symbol && button6.Text == symbol && button7.Text == symbol) ||
                (button8.Text == symbol && button9.Text == symbol && button10.Text == symbol))
            {
                return true;
            }

            // Check columns
            if ((button2.Text == symbol && button5.Text == symbol && button8.Text == symbol) ||
                (button3.Text == symbol && button6.Text == symbol && button9.Text == symbol) ||
                (button4.Text == symbol && button7.Text == symbol && button10.Text == symbol))
            {
                return true;
            }

            // Check diagonals
            if ((button2.Text == symbol && button6.Text == symbol && button10.Text == symbol) ||
                (button4.Text == symbol && button6.Text == symbol && button8.Text == symbol))
            {
                return true;
            }

            return false;
        }

        private void UpdateScore(Label label)
        {
            if (CheckWinner("X"))
            {
                MessageBox.Show("The winner is " + pname1, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(p1slabel.Text);
                p1slabel.Text = Convert.ToString(plusone + 1);
                p1label.Text = pname1 + " wins:";
                DisableButtons();
            }
            else if (CheckWinner("O"))
            {
                MessageBox.Show("The winner is " + pname2, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(p2slabel.Text);
                p2slabel.Text = Convert.ToString(plusone + 1);
                p2label.Text = pname2 + " wins:";
                DisableButtons();
            }
            
        }


        public Play1v1Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Play2Form back = new Play2Form();
            back.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(button2.Enabled)
    {
                button2.Text = checker ? "X" : "O";
                button2.BackColor = checker ? Color.Orange : Color.Yellow;
                checker = !checker;

                UpdateScore(checker ? p1slabel : p2slabel);
                moveCount++;

                if (moveCount == 9 && !CheckWinner("X") && !CheckWinner("O"))
                {
                    MessageBox.Show("Draw !!!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisableButtons();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Enabled)
            {
                button3.Text = checker ? "X" : "O";
                button3.BackColor = checker ? Color.Orange : Color.Yellow;
                checker = !checker;

                UpdateScore(checker ? p1slabel : p2slabel);
                moveCount++;

                if (moveCount == 9 && !CheckWinner("X") && !CheckWinner("O"))
                {
                    MessageBox.Show("Draw !!!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisableButtons();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Enabled)
            {
                button4.Text = checker ? "X" : "O";
                button4.BackColor = checker ? Color.Orange : Color.Yellow;
                checker = !checker;

                UpdateScore(checker ? p1slabel : p2slabel);
                moveCount++;

                if (moveCount == 9 && !CheckWinner("X") && !CheckWinner("O"))
                {
                    MessageBox.Show("Draw !!!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisableButtons();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Enabled)
            {
                button5.Text = checker ? "X" : "O";
                button5.BackColor = checker ? Color.Orange : Color.Yellow;
                checker = !checker;

                UpdateScore(checker ? p1slabel : p2slabel);
                moveCount++;

                if (moveCount == 9 && !CheckWinner("X") && !CheckWinner("O"))
                {
                    MessageBox.Show("Draw !!!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisableButtons();
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Enabled)
            {
                button6.Text = checker ? "X" : "O";
                button6.BackColor = checker ? Color.Orange : Color.Yellow;
                checker = !checker;

                UpdateScore(checker ? p1slabel : p2slabel);
                moveCount++;

                if (moveCount == 9 && !CheckWinner("X") && !CheckWinner("O"))
                {
                    MessageBox.Show("Draw !!!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisableButtons();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Enabled)
            {
                button7.Text = checker ? "X" : "O";
                button7.BackColor = checker ? Color.Orange : Color.Yellow;
                checker = !checker;

                UpdateScore(checker ? p1slabel : p2slabel);
                moveCount++;

                if (moveCount == 9 && !CheckWinner("X") && !CheckWinner("O"))
                {
                    MessageBox.Show("Draw !!!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisableButtons();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Enabled)
            {
                button8.Text = checker ? "X" : "O";
                button8.BackColor = checker ? Color.Orange : Color.Yellow;
                checker = !checker;

                UpdateScore(checker ? p1slabel : p2slabel);
                moveCount++;

                if (moveCount == 9 && !CheckWinner("X") && !CheckWinner("O"))
                {
                    MessageBox.Show("Draw !!!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisableButtons();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Enabled)
            {
                button9.Text = checker ? "X" : "O";
                button9.BackColor = checker ? Color.Orange : Color.Yellow;
                checker = !checker;

                UpdateScore(checker ? p1slabel : p2slabel);
                moveCount++;

                if (moveCount == 9 && !CheckWinner("X") && !CheckWinner("O"))
                {
                    MessageBox.Show("Draw !!!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisableButtons();
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.Enabled)
            {
                button10.Text = checker ? "X" : "O";
                button10.BackColor = checker ? Color.Orange : Color.Yellow;
                checker = !checker;

                UpdateScore(checker ? p1slabel : p2slabel);
                moveCount++;

                if (moveCount == 9 && !CheckWinner("X") && !CheckWinner("O"))
                {
                    MessageBox.Show("Draw !!!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisableButtons();
                }
            }
        }
        

        private void button11_Click(object sender, EventArgs e)
        {
           NewGame();
           moveCount = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Confirm if you want to exit the game", "Tic Tac Toe",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Draw !!!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Close();
            HomeForm back = new HomeForm();
            back.Show();
        }
    }
}
