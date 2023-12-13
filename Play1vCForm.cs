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
    public partial class Play1vCForm : Form
    {
       public string pname {  get; set; }
        public enum Player
        {
            X, O  
        }

        Player currentPlayer;
        Random random = new Random();
        int playerWinCount = 0;
        int CPUWinCount = 0;
        List<Button> buttons;



        public Play1vCForm()
        {
            InitializeComponent();
            NewGame();
        }

        private void RTbtnpy1_Click(object sender, EventArgs e)
        {
            this.Close();
            Play1Form back = new Play1Form();
            back.Show();
        }
       

        private void CPUmove(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = random.Next(buttons.Count);
                buttons[index].Enabled = false;
                currentPlayer = Player.O;
                buttons[index].Text = currentPlayer.ToString();
                buttons[index].BackColor = Color.Yellow;
                buttons.RemoveAt(index);
                CheckGame();
                CPUTimer.Stop();

            }
        }


        private int GetBestMove()
        {
            int bestScore = int.MinValue;
            int bestMove = -1;

            foreach (var button in buttons)
            {
                int index = buttons.IndexOf(button);

                if (buttons[index].Enabled)
                {
                    buttons[index].Text = currentPlayer.ToString();
                    buttons[index].Enabled = false;

                    int score = Minimax(0, false);

                    buttons[index].Text = "?";
                    buttons[index].Enabled = true;

                    if (score > bestScore)
                    {
                        bestScore = score;
                        bestMove = index;
                    }
                }
            }

            return bestMove;
        }


        private int Minimax(int depth, bool isMaximizing)
        {
            Player winner = CheckForWinner();

            if (winner != Player.X && winner != Player.O)
            {
                return 0; // Game is still ongoing
            }

            if (winner == Player.O)
            {
                return 1; // CPU wins
            }

            if (winner == Player.X)
            {
                return -1; // Player wins
            }

            if (buttons.All(button => !button.Enabled))
            {
                return 0; // Draw
            }

            int bestScore = isMaximizing ? int.MinValue : int.MaxValue;

            foreach (var button in buttons)
            {
                int index = buttons.IndexOf(button);

                if (buttons[index].Enabled)
                {
                    buttons[index].Text = isMaximizing ? Player.O.ToString() : Player.X.ToString();
                    buttons[index].Enabled = false;

                    int score = Minimax(depth + 1, !isMaximizing);

                    buttons[index].Text = "?";
                    buttons[index].Enabled = true;

                    bestScore = isMaximizing ? Math.Max(score, bestScore) : Math.Min(score, bestScore);
                }
            }

            return bestScore;
        }

        private Player CheckForWinner()
        {
            // Check for a winning condition
            if (button1.Text == currentPlayer.ToString() && button2.Text == currentPlayer.ToString() && button3.Text == currentPlayer.ToString()
                || button4.Text == currentPlayer.ToString() && button5.Text == currentPlayer.ToString() && button6.Text == currentPlayer.ToString()
                || button7.Text == currentPlayer.ToString() && button8.Text == currentPlayer.ToString() && button9.Text == currentPlayer.ToString()
                || button1.Text == currentPlayer.ToString() && button4.Text == currentPlayer.ToString() && button7.Text == currentPlayer.ToString()
                || button2.Text == currentPlayer.ToString() && button5.Text == currentPlayer.ToString() && button8.Text == currentPlayer.ToString()
                || button3.Text == currentPlayer.ToString() && button6.Text == currentPlayer.ToString() && button9.Text == currentPlayer.ToString()
                || button1.Text == currentPlayer.ToString() && button5.Text == currentPlayer.ToString() && button9.Text == currentPlayer.ToString()
                || button3.Text == currentPlayer.ToString() && button5.Text == currentPlayer.ToString() && button7.Text == currentPlayer.ToString())
            {
                return currentPlayer;
            }

            return Player.X;
        }



        private void PlayerClickButton(object sender, EventArgs e)
        {
            var button = (Button)sender;

            currentPlayer = Player.X;
            button.Text = currentPlayer.ToString();
            button.Enabled = false;
            button.BackColor = Color.Orange;
            buttons.Remove(button);
            CheckGame();
            CPUTimer.Start();
        }

        private void NewGameButton(object sender, EventArgs e)
        {
            NewGame();
        }

        private void CheckGame()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
                || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
                || button7.Text == "X" && button8.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
                || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
                || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
                || button3.Text == "X" && button5.Text == "X" && button7.Text == "X"
                )
            {
                CPUTimer.Stop();
                MessageBox.Show(pname + " Wins");
                playerWinCount++;
                label1.Text = pname + " wins: " + playerWinCount;
                NewGame();

            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
                || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
                || button7.Text == "O" && button8.Text == "O" && button9.Text == "O"
                || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
                || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
                || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
                || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
                || button3.Text == "O" && button5.Text == "O" && button7.Text == "O"
                )
            {
                CPUTimer.Stop();
                MessageBox.Show("CPU Wins");
                CPUWinCount++;
                label3.Text = "CPU wins: " + CPUWinCount;
                NewGame();

            }
            else if (buttons.All(button => button.Text != "?"))
            {
                MessageBox.Show("Draw !!!");
                NewGame();
            }

        }

        private void NewGame()
        {
             buttons = new List<Button> { button1, button2, button3, button4, button5, button6, 
                button7, button8, button9 };

            foreach (Button x in buttons) 
            {
                x.Enabled = true;
                x.Text = "?";
                x.BackColor = DefaultBackColor;
            }
        }

        private void Play1vCForm_Load(object sender, EventArgs e)
        {
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Confirm if you want to exit the game", "Tic Tac Toe",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (iExit == DialogResult.Yes)
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
