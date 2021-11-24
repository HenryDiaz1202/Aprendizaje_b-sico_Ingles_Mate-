using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        double resultado;
        string Operacion;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            txPantalla.Text = "0";
        }

        int Contador = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Contador = Contador + 1;
            textBox1.Text = Contador.ToString();
        }

        private void btCero_Click(object sender, EventArgs e)
        {
            txPantalla.Text = txPantalla.Text + "0";
        }

        private void btUno_Click(object sender, EventArgs e)
        {
            txPantalla.Text = txPantalla.Text + "1";
        }

        private void btDos_Click(object sender, EventArgs e)
        {
            txPantalla.Text = txPantalla.Text + "2";
        }

        private void btTres_Click(object sender, EventArgs e)
        {
            txPantalla.Text = txPantalla.Text + "3";
        }

        private void btCuatro_Click(object sender, EventArgs e)
        {
            txPantalla.Text = txPantalla.Text + "4";
        }

        private void btCinco_Click(object sender, EventArgs e)
        {
            txPantalla.Text = txPantalla.Text + "5";
        }

        private void btSeis_Click(object sender, EventArgs e)
        {
            txPantalla.Text = txPantalla.Text + "6";
        }

        private void btSiete_Click(object sender, EventArgs e)
        {
            txPantalla.Text = txPantalla.Text + "7";
        }

        private void btOcho_Click(object sender, EventArgs e)
        {
            txPantalla.Text = txPantalla.Text + "8";
        }

        private void btNueve_Click(object sender, EventArgs e)
        {
            txPantalla.Text = txPantalla.Text + "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txPantalla.Text = txPantalla.Text + ".";

        }

        private void btMas_Click(object sender, EventArgs e)
        {
            Operacion = "+";
            primero = double.Parse(txPantalla.Text);
            txPantalla.Clear();
        }

        private void btMenos_Click(object sender, EventArgs e)
        {
            Operacion = "-";
            primero = double.Parse(txPantalla.Text);
            txPantalla.Clear();
        }

        private void btPor_Click(object sender, EventArgs e)
        {
            Operacion = "*";
            primero = double.Parse(txPantalla.Text);
            txPantalla.Clear();
        }

        private void btDividir_Click(object sender, EventArgs e)
        {
            Operacion = "/";
            primero = double.Parse(txPantalla.Text);
            txPantalla.Clear();
        }

        private void btIgual_Click(object sender, EventArgs e)
        { 
            segundo = double.Parse(txPantalla.Text);
            switch (Operacion)
            {
                case "+":
                    resultado = primero + segundo;
                    txPantalla.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = primero - segundo;
                    txPantalla.Text = resultado.ToString();
                    break;
                case "*":
                    resultado = primero * segundo;
                    txPantalla.Text = resultado.ToString();
                    break;
                case "/":
                    resultado = primero / segundo;
                    txPantalla.Text = resultado.ToString();
                    break;
            }
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            txPantalla.Clear();
            txPantalla.Text="0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Operacion = "√";
            primero= double.Parse(txPantalla.Text);   
            resultado = primero;
            txPantalla.Text = Math.Sqrt(primero).ToString();
        }
    }
}
