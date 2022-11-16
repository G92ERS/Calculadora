using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
     //Variaveis Globais:
     int a, b;
     int res = 0;
     string ultimoOp;
     string op;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbltitulo_Click(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {

        }

        private void numeroPressionado(Object sender, EventArgs e)
        {
            Button numero = (Button)sender;
            txbtela.Text += numero.Text;
        }

        private void operacao (object sender, EventArgs e)
        {
            Button operador = (Button)sender;

            try {
                if (txbaux.Text != "")
                {
                    DataTable dt = new DataTable();
                    var v = dt.Compute(txbaux.Text + txbtela.Text, "");
                    txbaux.Text = v.ToString() + " " + operador.Text;
                    txbtela.Text = "";
                }
                else
                {
                    txbaux.Text = txbtela.Text + " " + operador.Text;
                    txbtela.Text = "";
                }
            } catch
            {
                DataTable dt = new DataTable();
                var v = dt.Compute(txbaux.Text + "0", "");
                txbtela.Text = v.ToString();
            }

        }

        private void btn8_Click(object sender, EventArgs e)
        {

        }

        private void btn9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnmulti_Click(object sender, EventArgs e)
        {

        }

        private void btn6_Click(object sender, EventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        private void btnsubtracao_Click(object sender, EventArgs e)
        {

        }

        private void btndeleta_Click(object sender, EventArgs e)
        {

        }

        private void txbtela_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txbtela.Text = "";
            txbaux.Text = "";
        }

        private void txbaux_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            if (txbtela.Text != "")
            {
                DataTable dt = new DataTable();

                var v = dt.Compute(txbaux.Text + txbtela.Text, "");
                txbaux.Text = "";
                txbtela.Text = v.ToString();
            }
        }
    }
}
