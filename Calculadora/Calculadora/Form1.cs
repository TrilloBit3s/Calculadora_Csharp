using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)//Botao textBox resultado
        {

        }

        private void button5_Click(object sender, EventArgs e)//Botao CE
        {
            txtResultado.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)//Botao C
        {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)//Botao =
        {
            if (txtResultado.Text != "")
            {
                valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                if (operacao == "SOMA")
                {
                    txtResultado.Text = Convert.ToString(valor1 + valor2);
                }
                else if (operacao == "SUB")
                {
                    txtResultado.Text = Convert.ToString(valor1 - valor2);
                }
                else if (operacao == "MULT")
                {
                    txtResultado.Text = Convert.ToString(valor1 * valor2);
                }
                else
                {
                    txtResultado.Text = Convert.ToString(valor1 / valor2);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)//Botao +
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }
            else
            {
                //MessageBox.Show("Informe um valor para efetuar a soma.");
            }
        }

        private void button7_Click(object sender, EventArgs e)//Botao -
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SUB";
                lblOperacao.Text = "-";
            }
            else
            {
                //MessageBox.Show("Informe um valor para efetuar a subdivisão.");
            }
        }

        private void button12_Click(object sender, EventArgs e)//Botao *
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "MULT";
                lblOperacao.Text = "*";
            }
            else
            {
                //MessageBox.Show("Informe um valor para efetuar a multiplicação.");
            }
        }

        private void button17_Click(object sender, EventArgs e)//Botao /
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "DIV";
                lblOperacao.Text = "/";
            }
            else
            {
                //MessageBox.Show("Informe um valor para efetuar a divisão.");
            }
        }

        private void button13_Click(object sender, EventArgs e)//Botao <
        {
            if (txtResultado.Text != "")
            {
                txtResultado.Text = txtResultado.Text.Remove(txtResultado.Text.Length - 1, 1);
            }
            else
            {
                //MessageBox.Show("Informe um valor para deletar.");
            }
        }

        private void button18_Click(object sender, EventArgs e)//Botao .
        {
            txtResultado.Text = txtResultado.Text + ".";
        }

        private void button19_Click(object sender, EventArgs e)//Botao 0
        {
            txtResultado.Text += "0"; //textResultado.Text = textResultado.Text + "0"; //esta linha é faz a mesma função da linha de baixo
        }

        private void button14_Click(object sender, EventArgs e)//Botao 1
        {
            txtResultado.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)//Botao 2
        {
            txtResultado.Text += "2";
        }

        private void button1_Click_1(object sender, EventArgs e)//Botao 3
        {
            txtResultado.Text += "3";
        }

        private void button15_Click_1(object sender, EventArgs e)//Botao 4
        {
            txtResultado.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)//Botao 5
        {
            txtResultado.Text += "5";
        }

        private void button2_Click(object sender, EventArgs e)//Botao 6
        {
            txtResultado.Text += "6";
        }

        private void button16_Click(object sender, EventArgs e)//Botao 7
        {
            txtResultado.Text += "7";
        }

        private void button10_Click(object sender, EventArgs e)//Botao 8
        {
            txtResultado.Text += "8";
        }

        private void button3_Click_1(object sender, EventArgs e)//Botao 9
        {
            txtResultado.Text += "9";
        }
    }
}