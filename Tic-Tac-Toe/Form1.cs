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

            
        }
    }
}
