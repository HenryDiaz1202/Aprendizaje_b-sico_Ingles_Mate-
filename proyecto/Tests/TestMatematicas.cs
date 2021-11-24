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
    public partial class TestMatematicas : Form
    {
        public TestMatematicas()
        {
            InitializeComponent();
        }
        int segundo = 59, minuto =15;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label32.Text = minuto.ToString();
            if (minuto < 10)
            {
                label32.Text = "0" + minuto.ToString();
            }
            label35.Text = segundo.ToString();
            timer1.Enabled = true;
            segundo = segundo - 1;
            if (segundo == 0)
            {
                minuto = minuto - 1;
                segundo = 59;
            }
            if (minuto == -1)
            {
                timer1.Stop();
                comprobarRespuestas();
                label32.Text = "00";
                label35.Text = "00";
                MessageBox.Show("Tiempo finalizado \n su puntuación es de "+txtSumaTotal.Text+" puntos de 20. ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupBox1.Enabled = false;
                button5.Visible = true;
                comprobarRespuestas();
            }
        }

        private void TestMatematicas_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void comprobarRespuestas()
        {
            int nume1=0, nume2=0, nume3=0, nume4=0, nume5=0, nume6=0, nume7=0, nume8=0, nume9=0, nume10=0, nume11=0, nume12=0, nume13=0, nume14=0, nume15=0, nume16=0, nume17=0, nume18=0, nume19=0, nume20=0, nume21=0,total2,total3,total4,total5, total;

            //Sumas
            if (textBox1.Text!="144") { }
            else
            {
                nume1 = 1;
            }
            if (textBox3.Text != "1563") { }
            else
            {
                nume2 = 1;
            }
            if (textBox4.Text != "1453") { }
            else
            {
                nume3 = 1;
            }
            if (textBox5.Text != "1549") { }
            else
            {
                nume4 = 1;
            }
            if (textBox6.Text != "415") { }
            else
            {
                nume5 = 1;
            }

            total = nume1 + nume2+nume3+nume4+nume5;
            txtPuntosSuma.Text = total.ToString();
            ////Multiplicacion
            if (textBox2.Text != "100") { }
            else
            {
                nume6 = 1;
            }
            if (textBox7.Text != "197628") { }
            else
            {
                nume7 = 1;
            }
            if (textBox8.Text != "1500") { }
            else
            {
                nume8 = 1;
            }
            if (textBox9.Text != "1700") { }
            else
            {
                nume9 = 1;
            }
            if (textBox10.Text != "45") { }
            else
            {
                nume10 = 1;
            }
            total2 = nume6 + nume7 + nume8 + nume9 + nume10;
            txtPuntosMultiplicacion.Text = total2.ToString();
            ////Restas
            if (textBox12.Text != "302") { }
            else
            {
                nume11 = 1;
            }
            if (textBox13.Text != "1928") { }
            else
            {
                nume12 = 1;
            }
            if (textBox14.Text != "31") { }
            else
            {
                nume13 = 1;
            }
            if (textBox15.Text != "984") { }
            else
            {
                nume14 = 1;
            }
            if (textBox21.Text != "841") { }
            else
            {
                nume15 = 1;
            }
            total3 = nume11 + nume12 + nume13 + nume14 + nume15;
            txtPuntosResta.Text = total3.ToString();
            ////Division
            if (textBox16.Text != "69.5") { }
            else
            {
                nume16 = 1;
            }
            if (textBox17.Text != "45") { }
            else
            {
                nume17 = 1;
            }
            if (textBox18.Text != "31.16") { }
            else
            {
                nume18 = 1;
            }
            if (textBox19.Text != "33") { }
            else
            {
                nume19 = 1;
            }
            if (textBox20.Text != "5") { }
            else
            {
                nume20 = 1;
            }
            total4= nume16 + nume17 + nume18 + nume19 + nume20;
            txtPuntosDivision.Text = total4.ToString();

            if (textBox11.Text != "140.4") { }
            else
            {
                nume21 = 2;
            }
            total5 = nume21;
            int totaltotal=total+total2+total3+total4+total5;
            txtSumaTotal.Text = totaltotal.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            groupBox1.Enabled = true;
            segundo = 59;
            minuto = 15;
            limpiar();
            timer1.Start();
        }
        private void limpiar()
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox2.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox21.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox11.Clear();
            txtSumaTotal.Text = "0";
            txtPuntosSuma.Text = "0";
            txtPuntosResta.Text = "0";
            txtPuntosMultiplicacion.Text = "0";
            txtPuntosDivision.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            comprobarRespuestas();
            label32.Text = "00";
            label35.Text = "00";
            MessageBox.Show("Tiempo finalizado \n su puntuación es de " + txtSumaTotal.Text + " puntos de 20. ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            groupBox1.Enabled = false;
            button5.Visible = true;
            comprobarRespuestas();
        }




    }
}
