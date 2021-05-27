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
        bool PlayerInput = true;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Click_Input(object sender, EventArgs e)
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

            if (((bttn1.Text == "X") && (bttn2.Text == "X") && (bttn3.Text == "X")) ||
               ((bttn4.Text == "X") && (bttn5.Text == "X") && (bttn6.Text == "X")) ||
               ((bttn7.Text == "X") && (bttn8.Text == "X") && (bttn9.Text == "X")))
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else if (((bttn1.Text == "O") && (bttn2.Text == "O") && (bttn3.Text == "O")) ||
               ((bttn4.Text == "O") && (bttn5.Text == "O") && (bttn6.Text == "O")) ||
               ((bttn7.Text == "O") && (bttn8.Text == "O") && (bttn9.Text == "O")))
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else if (((bttn1.Text == "X") && (bttn4.Text == "X") && (bttn7.Text == "X")) ||
              ((bttn2.Text == "X") && (bttn5.Text == "X") && (bttn8.Text == "X")) ||
              ((bttn3.Text == "X") && (bttn6.Text == "X") && (bttn9.Text == "X")))
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else if (((bttn1.Text == "O") && (bttn4.Text == "O") && (bttn7.Text == "O")) ||
               ((bttn2.Text == "O") && (bttn5.Text == "O") && (bttn8.Text == "O")) ||
               ((bttn3.Text == "O") && (bttn6.Text == "O") && (bttn9.Text == "O")))
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else if (((bttn1.Text == "X") && (bttn5.Text == "X") && (bttn9.Text == "X")) ||
             ((bttn3.Text == "X") && (bttn5.Text == "X") && (bttn7.Text == "X")))
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else if (((bttn1.Text == "O") && (bttn5.Text == "O") && (bttn9.Text == "O")) ||
             ((bttn3.Text == "O") && (bttn5.Text == "O") && (bttn7.Text == "O")))
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else if (false)
            {
                MessageBox.Show("Draw!");
            }
        }
    }
}
