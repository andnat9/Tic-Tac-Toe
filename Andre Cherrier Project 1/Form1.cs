/*Tic Tac Toe Board
 * A fun game to play against your friends.
 * Creator: Andre Cherrier
 * September 15, 2017
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

namespace Andre_Cherrier_Project_1
{
    public partial class ticTacToeBoard : Form
    {
        int player = 1;
        int oneScore = 1;
        int twoScore = 1;
        public void buttonPress(Button butnum)
        {
            //A method to be called in the buttons
            butnum.Font = new Font("Times New Roman", 30, FontStyle.Bold);

            if (player % 2 == 0)
            {
                butnum.Text = "O";
                butnum.BackColor = Color.PaleGoldenrod;
                butnum.Enabled = false;
                player++;
            }
            else
            {
                butnum.Text = "X";
                butnum.BackColor = Color.LightPink;
                butnum.Enabled = false;
                player++;
            }
            xButton.Enabled = false;
            oButton.Enabled = false;
            testWinner();
            if (winnerLabel.Text != "")
            {
                playAgain.Visible = true;
                playAgain.Enabled = true;
            }
            else
            {
                playAgain.Visible = false;
                playAgain.Enabled = false;
            }
            if (winnerLabel.Text != "")
            {
                oneOne.Enabled = false;
                oneTwo.Enabled = false;
                oneThree.Enabled = false;
                twoOne.Enabled = false;
                twoTwo.Enabled = false;
                twoThree.Enabled = false;
                threeOne.Enabled = false;
                threeTwo.Enabled = false;
                threeThree.Enabled = false;
            }
            if (winnerLabel.Text == "Player 1 Wins!")
            {
                playerOneScore.Text = "Player 1 Score: " + oneScore++;
            }
            else if (winnerLabel.Text == "Player 2 Wins!")
            {
                playerTwoScore.Text = "Player 2 Score: " + twoScore++;
            }
        }

        public void tryAgain(Button reset)
        {

        }
        public void testWinner()
        {
            //winning by rows
            if (oneOne.Text == oneTwo.Text && oneTwo.Text == oneThree.Text && oneThree.Enabled == false) //row one winner
            {
                if (xButton.Checked == true && player % 2 == 0)
                {
                    winnerLabel.Text = "Player 1 Wins!";
                }
                else if (xButton.Checked == false && player % 2 != 0)
                {
                    winnerLabel.Text = "Player 1 Wins!";
                }
                else if (xButton.Checked == true && player % 2 != 0)
                {
                    winnerLabel.Text = "Player 2 Wins!";
                }
                else if (xButton.Checked == false && player % 2 == 0)
                {
                    winnerLabel.Text = "Player 2 Wins!";
                }

            }

            else if (twoOne.Text == twoTwo.Text && twoTwo.Text == twoThree.Text && twoThree.Enabled == false) //row two winner
            {
                if (xButton.Checked == true && player % 2 == 0)
                {
                    winnerLabel.Text = "Player 1 Wins!";
                }
                else if (xButton.Checked == false && player % 2 != 0)
                {
                    winnerLabel.Text = "Player 1 Wins!";
                }
                else if (xButton.Checked == true && player % 2 != 0)
                {
                    winnerLabel.Text = "Player 2 Wins!";
                }
                else if (xButton.Checked == false && player % 2 == 0)
                {
                    winnerLabel.Text = "Player 2 Wins!";
                }

            }
            else if (threeOne.Text == threeTwo.Text && threeTwo.Text == threeThree.Text && threeThree.Enabled == false) //row three winner
            {
                if (xButton.Checked == true && player % 2 == 0)
                {
                    winnerLabel.Text = "Player 1 Wins!";
                }
                else if (xButton.Checked == false && player % 2 != 0)
                {
                    winnerLabel.Text = "Player 1 Wins!";
                }
                else if (xButton.Checked == true && player % 2 != 0)
                {
                    winnerLabel.Text = "Player 2 Wins!";
                }
                else if (xButton.Checked == false && player % 2 == 0)
                {
                    winnerLabel.Text = "Player 2 Wins!";
                }

            }

            //winning by columns
            else if (oneOne.Text == twoOne.Text && twoOne.Text == threeOne.Text && threeOne.Enabled == false) //column one winner
            {
                if (xButton.Checked == true && player % 2 == 0)
                {
                    winnerLabel.Text = "Player 1 Wins!";
                }
                else if (xButton.Checked == false && player % 2 != 0)
                {
                    winnerLabel.Text = "Player 1 Wins!";
                }
                else if (xButton.Checked == true && player % 2 != 0)
                {
                    winnerLabel.Text = "Player 2 Wins!";
                }
                else if (xButton.Checked == false && player % 2 == 0)
                {
                    winnerLabel.Text = "Player 2 Wins!";
                }
            }
            else if (oneTwo.Text == twoTwo.Text && twoTwo.Text == threeTwo.Text && threeTwo.Enabled == false) //column two winner
            {
                if (xButton.Checked == true && player % 2 == 0)
                {
                    winnerLabel.Text = "Player 1 Wins!";
                }
                else if (xButton.Checked == false && player % 2 != 0)
                {
                    winnerLabel.Text = "Player 1 Wins!";
                }
                else if (xButton.Checked == true && player % 2 != 0)
                {
                    winnerLabel.Text = "Player 2 Wins!";
                }
                else if (xButton.Checked == false && player % 2 == 0)
                {
                    winnerLabel.Text = "Player 2 Wins!";
                }
            }
            else if (oneThree.Text == twoThree.Text && twoThree.Text == threeThree.Text && threeThree.Enabled == false) //column three winner
            {
                if (xButton.Checked == true && player % 2 == 0)
                {
                    winnerLabel.Text = "Player 1 Wins!";
                }
                else if (xButton.Checked == false && player % 2 != 0)
                {
                    winnerLabel.Text = "Player 1 Wins!";
                }
                else if (xButton.Checked == true && player % 2 != 0)
                {
                    winnerLabel.Text = "Player 2 Wins!";
                }
                else if (xButton.Checked == false && player % 2 == 0)
                {
                    winnerLabel.Text = "Player 2 Wins!";
                }
            }
            //winning diagonally
            else if (oneOne.Text == twoTwo.Text && twoTwo.Text == threeThree.Text && threeThree.Enabled == false) //diagonal win
            {
                if (xButton.Checked == true && player % 2 == 0)
                {
                    winnerLabel.Text = "Player 1 Wins!";
                }
                else if (xButton.Checked == false && player % 2 != 0)
                {
                    winnerLabel.Text = "Player 1 Wins!";
                }
                else if (xButton.Checked == true && player % 2 != 0)
                {
                    winnerLabel.Text = "Player 2 Wins!";
                }
                else if (xButton.Checked == false && player % 2 == 0)
                {
                    winnerLabel.Text = "Player 2 Wins!";
                }
            }
            else if (threeOne.Text == twoTwo.Text && twoTwo.Text == oneThree.Text && oneThree.Enabled == false) //second diagonal win
            {
                if (xButton.Checked == true && player % 2 == 0)
                {
                    winnerLabel.Text = "Player 1 Wins!";
                }
                else if (xButton.Checked == false && player % 2 != 0)
                {
                    winnerLabel.Text = "Player 1 Wins!";
                }
                else if (xButton.Checked == true && player % 2 != 0)
                {
                    winnerLabel.Text = "Player 2 Wins!";
                }
                else if (xButton.Checked == false && player % 2 == 0)
                {
                    winnerLabel.Text = "Player 2 Wins!";
                }
            }
            //If it's a draw
            if (oneOne.Enabled == false && oneTwo.Enabled == false && oneThree.Enabled == false && twoOne.Enabled == false && twoTwo.Enabled == false && twoThree.Enabled == false && threeOne.Enabled == false && threeTwo.Enabled == false && threeThree.Enabled == false && winnerLabel.Text == "")
            {
                winnerLabel.Text = "It's a Draw!";
            }

        }
        public ticTacToeBoard()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {
            //changing Label to name's Tic Tac Toe Game
            gameName.Text = nameBox.Text + "'s Tic Tac Toe Game";
            //multiple pictures for different names (Kat wanted me to have a bear and her to have a moose)
            if (nameBox.Text == "Kat")
            {
                moose.Visible = true;
                moose.BringToFront();
            }
            else if (nameBox.Text == "Andre")
            {
                bearPicture.Visible = true;
                bearPicture.BringToFront();
            }
            else
            {
                ticTacToePicture.Visible = true;
                ticTacToePicture.BringToFront();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gameName_Click(object sender, EventArgs e)
        {

        }
        //The nine buttons calling the method buttonPress
        private void button1_Click(object sender, EventArgs e)
        {
            buttonPress(oneOne);
        }

        private void oneTwo_Click(object sender, EventArgs e)
        {
            buttonPress(oneTwo);
        }

        private void oneThree_Click(object sender, EventArgs e)
        {
            buttonPress(oneThree);
        }

        private void twoOne_Click(object sender, EventArgs e)
        {
            buttonPress(twoOne);
        }

        private void twoTwo_Click(object sender, EventArgs e)
        {
            buttonPress(twoTwo);
        }

        private void twoThree_Click(object sender, EventArgs e)
        {
            buttonPress(twoThree);
        }

        private void threeOne_Click(object sender, EventArgs e)
        {
            buttonPress(threeOne);
        }

        private void threeTwo_Click(object sender, EventArgs e)
        {
            buttonPress(threeTwo);
        }

        private void threeThree_Click(object sender, EventArgs e)
        {
            buttonPress(threeThree);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void xButton_CheckedChanged(object sender, EventArgs e)
        {
            if (xButton.Checked == true)
            {
                player = 1;
            }
            else
            {
                player = 2;
            }
        }

        private void oButton_CheckedChanged(object sender, EventArgs e)
        {
            if (oButton.Checked == true)
            {
                player = 2;
            }
            else
            {
                player = 1;
            }
        }

        private void playAgain_Click(object sender, EventArgs e)
        {
            if (winnerLabel.Text != "") //Resetting TicTacToe Board, radio buttons, and winner label
            {
                oneOne.Text = "Click Here";
                oneOne.BackColor = Color.Gainsboro;
                oneOne.Enabled = true;
                oneOne.Font = new Font("Palatino Linotype", 12);
                oneTwo.Text = "Click Here";
                oneTwo.BackColor = Color.Gainsboro;
                oneTwo.Enabled = true;
                oneTwo.Font = new Font("Palatino Linotype", 12);
                oneThree.Text = "Click Here";
                oneThree.BackColor = Color.Gainsboro;
                oneThree.Enabled = true;
                oneThree.Font = new Font("Palatino Linotype", 12);
                twoOne.Text = "Click Here";
                twoOne.BackColor = Color.Gainsboro;
                twoOne.Enabled = true;
                twoOne.Font = new Font("Palatino Linotype", 12);
                twoTwo.Text = "Click Here";
                twoTwo.BackColor = Color.Gainsboro;
                twoTwo.Enabled = true;
                twoTwo.Font = new Font("Palatino Linotype", 12);
                twoThree.Text = "Click Here";
                twoThree.BackColor = Color.Gainsboro;
                twoThree.Enabled = true;
                twoThree.Font = new Font("Palatino Linotype", 12);
                threeOne.Text = "Click Here";
                threeOne.BackColor = Color.Gainsboro;
                threeOne.Enabled = true;
                threeOne.Font = new Font("Palatino Linotype", 12);
                threeTwo.Text = "Click Here";
                threeTwo.BackColor = Color.Gainsboro;
                threeTwo.Enabled = true;
                threeTwo.Font = new Font("Palatino Linotype", 12);
                threeThree.Text = "Click Here";
                threeThree.BackColor = Color.Gainsboro;
                threeThree.Enabled = true;
                threeThree.Font = new Font("Palatino Linotype", 12);
                xButton.Enabled = true;
                oButton.Enabled = true;
                winnerLabel.Text = "";
                playAgain.Visible = false;
                player = 1;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            oneScore = 1;
            twoScore = 1;
            playerOneScore.Text = "Player 1 Score: 0";
            playerTwoScore.Text = "Player 2 Score: 0";
        }
    }
}
