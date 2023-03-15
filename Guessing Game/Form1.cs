using System;
using System.Windows.Forms;

namespace Guessing_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                string secretWord = "sword";
                if (txtGuess1.Text != secretWord && txtGuess2.Text != secretWord && txtGuess3.Text != secretWord)
                {
                    MessageBox.Show("Sorry, you lose");
                }
                else { MessageBox.Show("Congratulations, you win!"); }
            }
            catch (Exception except) { MessageBox.Show("Error: " + except.Message); }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
