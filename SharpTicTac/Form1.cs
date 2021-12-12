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
        int clicks = 0;
        bool x = true;
        int[][] field = {new int[] {0, 0, 0}, new int[] { 0, 0, 0,}, new int[] { 0, 0, 0}};
        public Form1()
        {
            InitializeComponent();

        }

        bool checkWin(int sym)
        {
            int[] r1 = field[0];
            int[] r2 = field[1];
            int[] r3 = field[2];
            return (r1[0] == sym & r1[1] == sym & r1[2] == sym) ||
            (r2[0] == sym & r2[1] == sym & r2[2] == sym) ||
            (r3[0] == sym & r3[1] == sym & r3[2] == sym) ||
            (r1[0] == sym & r2[0] == sym & r3[0] == sym) ||
            (r1[1] == sym & r2[1] == sym & r3[1] == sym) ||
            (r1[2] == sym & r2[2] == sym & r3[2] == sym) ||
            (r1[0] == sym & r2[1] == sym & r3[2] == sym) ||
            (r1[2] == sym & r2[1] == sym & r3[0] == sym);
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

            if (field[row][col] == 0)
            {
                clicks++;
                int sym = x ? 1 : 2;
                field[row][col] = sym;
                button.Text = pChar;
                if (checkWin(sym)) 
                { 
                    string winner = x ? "X" : "O";
                    MessageBox.Show($"Выиграл {winner}"); 
                    this.Close(); 
                }
                else if (clicks >= 9)
                {
                    MessageBox.Show($"Ничья!");
                    this.Close();
                }

                x = !x;
            }
            else
            {
                MessageBox.Show("Клетка занята!");
            }
        }
    }
}
