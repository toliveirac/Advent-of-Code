using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string num_ = "0";
            int substantivo,verbo = 0;
            string[] numero = new string[500];
            bool stat = false;

            for (int item = 0; item < 99; item++)
            {
                if(stat == true) { break; }

                substantivo = item;

                for (int itens = 0; itens < 99; itens++)
                {
                    verbo = itens;

                    string row = "0";
                    int A, B, R, index = 0;
                    
                    System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\toliv\Desktop\AdventOfCode\Day02\input.txt");

                    row = file.ReadLine();

                    string original = row;
                    char[] delimitadores = new char[] { ',' };
                    string[] strings = original.Split(delimitadores);

                    //Separa cada numero em uma posição do array
                    foreach (string s in strings)
                    {
                        if (index == 1) { numero[index] = substantivo.ToString(); index++; }
                        else if (index == 2) { numero[index] = verbo.ToString(); index++; }
                        else
                        {
                            numero[index] = s;
                            index++;
                        }
                    }

                    index = 0;

                    //acessa cada pos no array e aplica regras
                    foreach (string s in strings)
                    {

                        if (numero[index] == "99")  // Interrompe programa
                        {
                         if (numero[0] == "19690720")
                         {
                               txtSubs.Text = ((substantivo * 100) + verbo).ToString();
                               break;
                         }
                            break;
                        }
                        else if (numero[index] == "1" | numero[index] == "2") //Soma e Substitui ou Multiplica e Substitui
                        {
                            //Pega valor da posição indicada
                            R = Convert.ToInt32(numero[index + 3]);
                            int nameA = Convert.ToInt32(numero[index + 1]);
                            int nameB = Convert.ToInt32(numero[index + 2]);
                            A = Convert.ToInt32(numero[nameA]);
                            B = Convert.ToInt32(numero[nameB]);

                            if (numero[index] == "1")
                            {
                                numero[R] = (A + B).ToString();
                                index = index + 4;

                            }
                            else
                            {
                                numero[R] = (A * B).ToString();
                                index = index + 4;
                            }
                        }

                    }
                    num_ = numero[0];
                    index = 0;
                    if (numero[0] == "19690720")
                    {
                        txtSubs.Text = ((substantivo * 100) + verbo).ToString();

                        break;
                    }


                }
              
            }
            txtInput.Text = "finishi";
        }
    }
}
