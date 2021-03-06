using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        //Declaration of the Variables and Setting the Player's Input in Bool True in nature
        bool PlayerInput = true;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Code for the input of the players
        public void Click_Input(object sender, EventArgs e)
        {
            Button Input = (Button)sender;

            if (PlayerInput)
            {
                Input.Text = "X";
            }
            else
            {
                Input.Text = "O";
            }
            PlayerInput = !PlayerInput;
            Input.Enabled = false;

         // Code for the checking of winners in the game
            if (((bttn1.Text == "X") && (bttn2.Text == "X") && (bttn3.Text == "X")) ||
               ((bttn4.Text == "X") && (bttn5.Text == "X") && (bttn6.Text == "X")) ||
               ((bttn7.Text == "X") && (bttn8.Text == "X") && (bttn9.Text == "X")))
            {
                MessageBox.Show("Player 1 Wins!");

                gameRestart();
            }
            else if (((bttn1.Text == "O") && (bttn2.Text == "O") && (bttn3.Text == "O")) ||
               ((bttn4.Text == "O") && (bttn5.Text == "O") && (bttn6.Text == "O")) ||
               ((bttn7.Text == "O") && (bttn8.Text == "O") && (bttn9.Text == "O")))
            {
                MessageBox.Show("Player 2 Wins!");
                gameRestart();
            }
            else if (((bttn1.Text == "X") && (bttn4.Text == "X") && (bttn7.Text == "X")) ||
              ((bttn2.Text == "X") && (bttn5.Text == "X") && (bttn8.Text == "X")) ||
              ((bttn3.Text == "X") && (bttn6.Text == "X") && (bttn9.Text == "X")))
            {
                MessageBox.Show("Player 1 Wins!");
                gameRestart();
            }
            else if (((bttn1.Text == "O") && (bttn4.Text == "O") && (bttn7.Text == "O")) ||
               ((bttn2.Text == "O") && (bttn5.Text == "O") && (bttn8.Text == "O")) ||
               ((bttn3.Text == "O") && (bttn6.Text == "O") && (bttn9.Text == "O")))
            {
                MessageBox.Show("Player 2 Wins!");
                gameRestart();
            }
            else if (((bttn1.Text == "X") && (bttn5.Text == "X") && (bttn9.Text == "X")) ||
             ((bttn3.Text == "X") && (bttn5.Text == "X") && (bttn7.Text == "X")))
            {
                MessageBox.Show("Player 1 Wins!");
                gameRestart();
            }
            else if (((bttn1.Text == "O") && (bttn5.Text == "O") && (bttn9.Text == "O")) ||
             ((bttn3.Text == "O") && (bttn5.Text == "O") && (bttn7.Text == "O")))
            {
                MessageBox.Show("Player 2 Wins!");
                gameRestart();
            }

         // Code if ever the match is draw
            if (((bttn1.Text == "X") || (bttn1.Text == "O") && (bttn1.Enabled == false))&&
               ((bttn2.Text == "X") || (bttn2.Text == "O") && (bttn2.Enabled == false))&&
               ((bttn3.Text == "X") || (bttn3.Text == "O") && (bttn3.Enabled == false))&&
               ((bttn4.Text == "X") || (bttn4.Text == "O") && (bttn4.Enabled == false))&&
               ((bttn5.Text == "X") || (bttn5.Text == "O") && (bttn5.Enabled == false))&&
               ((bttn6.Text == "X") || (bttn6.Text == "O") && (bttn6.Enabled == false))&&
               ((bttn7.Text == "X") || (bttn7.Text == "O") && (bttn7.Enabled == false))&&
               ((bttn8.Text == "X") || (bttn8.Text == "O") && (bttn8.Enabled == false))&&
               ((bttn9.Text == "X") || (bttn9.Text == "O") && (bttn9.Enabled == false)))
            {
                MessageBox.Show("Draw!");
                gameRestart();
            }
        }
        // Code if ever the match is already finish
        private void gameRestart()
        {
            bttn1.Text = "";
            bttn2.Text = "";
            bttn3.Text = "";
            bttn4.Text = "";
            bttn5.Text = "";
            bttn6.Text = "";
            bttn7.Text = "";
            bttn8.Text = "";
            bttn9.Text = "";
            bttn1.Enabled = true;
            bttn2.Enabled = true;
            bttn3.Enabled = true;
            bttn4.Enabled = true;
            bttn5.Enabled = true;
            bttn6.Enabled = true;
            bttn7.Enabled = true;
            bttn8.Enabled = true;
            bttn9.Enabled = true;
        }
    }
}
