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
        bool x = true;
        int[,] field = new int[3, 3];
        public Form1()
        {
            InitializeComponent();
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    field[x, y] = 0;
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            // невозможно юзать свич из-за ограничений шарпа (кейс ток константы)
            string pChar = x ? "X" : "O";
            int row = 0, col = 0;
            if (button == button1) { row = 0; col = 0; }
            else if (button == button2) { row = 0; col = 1; }
            else if (button == button3) { row = 0; col = 2; }
            else if (button == button4) { row = 1; col = 0; }
            else if (button == button5) { row = 1; col = 1; }
            else if (button == button6) { row = 1; col = 2; }
            else if (button == button7) { row = 2; col = 0; }
            else if (button == button8) { row = 2; col = 1; }
            else if (button == button9) { row = 2; col = 2; }

            if (field[row, col] == 0)
            {
                x = !x;
                field[row, col] = x ? 1 : 2;
                button.Text = pChar;
            }
            else
            {
                MessageBox.Show("Клетка занята!");
            }
        }
    }
}
