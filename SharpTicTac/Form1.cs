using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpTicTac
{
    public partial class Form1 : Form
    {
        
        bool[,] field = new bool[3, 3];
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            // невозможно юзать свич из-за ограничений шарпа (кейс ток константы)
            
            if (button == button1) { field[0, 0] = true; button.Text = "X"; }
            else if (button == button2) { field[0, 1] = true; button.Text = "X"; }
            else if (button == button3) { field[0, 2] = true; button.Text = "X"; }
            else if (button == button4) { field[1, 0] = true; button.Text = "X"; }
            else if (button == button5) { field[1, 1] = true; button.Text = "X"; }
            else if (button == button6) { field[1, 2] = true; button.Text = "X"; }
            else if (button == button7) { field[2, 0] = true; button.Text = "X"; }
            else if (button == button8) { field[2, 1] = true; button.Text = "X"; }
            else if (button == button9) { field[2, 2] = true; button.Text = "X"; }
        }
    }
}
