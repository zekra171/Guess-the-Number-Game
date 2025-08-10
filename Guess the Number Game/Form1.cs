using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_the_Number_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ResetGame();
        }
        int randomNumber = 0;
        void ResetGame()
        {
            guessButton.Visible = true;
            Random random = new Random();
            randomNumber = random.Next(1, 101); 
            feedbackLabel.Text = "";
            guessTextBox.Text = "";
            guessTextBox.Focus();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            guessButton.Visible = false;
            if (int.TryParse(guessTextBox.Text, out int userGuess))
            {
                if (userGuess < 1 || userGuess > 100)
                {
                    feedbackLabel.Text = "Please enter \n a number between 1 and 100.";
                }
                else if (userGuess < randomNumber)
                {
                    feedbackLabel.Text = "Too low!";
                }
                else if (userGuess > randomNumber)
                {
                    feedbackLabel.Text = "Too high!";
                }
                else
                {
                    feedbackLabel.Text = "Correct!";
                }
            }
            else
            {
                feedbackLabel.Text = "Please enter a valid number.";
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}
