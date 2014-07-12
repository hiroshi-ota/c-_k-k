using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okienkowa_2
{
    public partial class Form1 : Form
    {

        bool turn = true; // true = X, false = O;
        int turn_count = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            try
            {
                foreach (Control item in Controls)
                {
                    Button b = (Button)item;
                    item.Enabled = true;
                    b.Text = "";
                }
            }
            catch { }

            


        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Kamil", "Kółko i Krzyżyk About");
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;

            b.Enabled = false;

            turn_count ++;

            checkForWinner();

        }

        private void disableButtons()
        {
            try
            {
                foreach (Control item in Controls)
                {
                    Button b = (Button)item;
                    item.Enabled = false;
                }
            }
            catch { }
            
        }


        private void checkForWinner()
        {
            bool thereIsWinner = false;


            if ((b11.Text == b12.Text) && (b12.Text == b13.Text) && b11.Enabled == false)
                thereIsWinner = true;
            else if ((b21.Text == b22.Text) && (b22.Text == b23.Text) && b21.Enabled == false)
                thereIsWinner = true;
            else if ((b31.Text == b32.Text) && (b32.Text == b33.Text) && b31.Enabled == false)
                thereIsWinner = true;
            

            if ((b11.Text == b21.Text) && (b21.Text == b31.Text) && b11.Enabled == false)
                thereIsWinner = true;
            else if ((b12.Text == b22.Text) && (b22.Text == b32.Text) && b12.Enabled == false)
                thereIsWinner = true;
            else if ((b13.Text == b23.Text) && (b23.Text == b33.Text) && b13.Enabled == false)
                thereIsWinner = true;

            if ((b11.Text == b22.Text) && (b22.Text == b33.Text) && b11.Enabled == false)
                thereIsWinner = true;
            else if ((b13.Text == b22.Text) && (b22.Text == b31.Text) && b13.Enabled == false)
                thereIsWinner = true;


            if (thereIsWinner)
            {
                disableButtons();
                
                string winner = "";
                if (turn)
                {
                    winner = "O";
                }
                else
                    winner = "X";

                MessageBox.Show(winner + " is the WINNER!!!", "Win...");
               
            }
            else
            {
                if (turn_count == 9)
                    MessageBox.Show("Mamy remis!", "Wtopa!");
            }
            
        }

    }
}
