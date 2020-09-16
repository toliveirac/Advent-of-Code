using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string row = "1";

            int total = 0, resultado = 0, combustivel=0;
            bool trigger = true;

            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\toliv\Desktop\AdventOfCode\Day01\input.txt");
            row = file.ReadLine();
            while (row != null)
            {
                if (row != "")
                {
                    resultado = ((Convert.ToInt32(row) / 3) - 2);
                    trigger = true;
                    while (trigger) 
                    {   if (resultado > 0)
                        {
                            combustivel = ((Convert.ToInt32(resultado) / 3) - 2);
                            total = resultado + total;
                            if (combustivel > 0)
                            {
                                resultado = combustivel;
                            }
                            else
                            {
                                trigger = false;
                            }
                        }
                    }
                    row = file.ReadLine();
                }
            }
            caixa.Text = Convert.ToString(total);
        }

        private void texto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
