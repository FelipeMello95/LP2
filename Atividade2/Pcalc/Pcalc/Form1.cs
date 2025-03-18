using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pcalc
{
    public partial class Form1 : Form
    {
        double numero1, numero2, resultado;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumero1_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtNumero1.Text,out numero1))
            {
                MessageBox.Show("Número 1 inválido!");
                txtNumero1.Focus();
            }
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            resultado = numero1 + numero2;
            txtResultado.Text = resultado.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            resultado = numero1 - numero2;
            txtResultado.Text = resultado.ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            resultado = numero1 * numero2;
            txtResultado.Text = resultado.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (numero2 == 0)
            {
                MessageBox.Show("Erro! Divisão indeterminada, digite outro valor!");
                txtNumero2.Focus();
            }
            else
                resultado = numero1 / numero2;
            txtResultado .Text = resultado.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResultado.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNumero2_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtNumero2.Text, out numero2))
            {
                MessageBox.Show("Número 2 inválido!");
                txtNumero1.Focus();
            }
        }
    }
}
