using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Threading;

namespace proyecto
{
    public partial class TestIngles : Form
    {
        public TestIngles()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            EspanioL();
        }        
        private void EspanioL()
        {
            label5.Text = "I. Escriba el color para cada pregunta, usando la imagen.";
            label9.Text = "II. Complete la conversasión usando las palabras de la caja.";
            label29.Text = "III. Relacionar.\n Relaionar las palabras.";
        }
        private void Ingles()
        {
            label5.Text = "I. Write the color for each question, using the picture.";
            label9.Text = "II. Complete the coversation using the words of the box.";
            label29.Text = "III. Match.\n Match the words.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            Ingles();
        }
        private void Hablar(object texto)
        {
            SpeechSynthesizer voz = new SpeechSynthesizer();
            SpeechSynthesizer audio = new SpeechSynthesizer();
            voz.SetOutputToDefaultAudioDevice();
            voz.Speak(texto.ToString());
        }
        int contador = 0;
        private void TestIngles_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            contador = contador + 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled=true;
        }

        int segundo =59,minuto=10;
        private void timer2_Tick(object sender, EventArgs e)
        {
            label32.Text = minuto.ToString();
            if (minuto < 10)
            {
                label32.Text = "0" + minuto.ToString();
            }
            label35.Text = segundo.ToString();
            timer2.Enabled = true;
            segundo = segundo - 1;
            if(segundo==0)
            {
                minuto = minuto - 1;
                segundo = 59;
            }
            if(minuto==-1)
            {
                timer2.Stop();
                SumarPuntos();
                SumarSegundoPunto();
                SumarTercerPunto();
                label32.Text = "00";
                label35.Text = "00";
                MessageBox.Show("Tiempo finalizado \n su puntuación es de "+txtTotalTercerPunto.Text+" puntos de 20. ","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
                button5.Visible = true;
                EnableFalse();
                groupBox1.Enabled = false;
            }
        }

        private void SumarPuntos()
        {
            if (textBox2.Text == "Red" && textBox3.Text == "Yellow" && textBox1.Text == "Blue")
            {
                PrimerPunto.Text = "3";
            }
            else if (textBox2.Text != "Red" && textBox3.Text == "Yellow" && textBox1.Text == "Blue")
            {
                PrimerPunto.Text = "2";
            }
            else if (textBox2.Text == "Red" && textBox3.Text != "Yellow" && textBox1.Text == "Blue")
            {
                PrimerPunto.Text = "2";
            }
            else if (textBox2.Text == "Red" && textBox3.Text == "Yellow" && textBox1.Text != "Blue")
            {
                PrimerPunto.Text = "2";
            }
            else if (textBox2.Text != "Red" && textBox3.Text != "Yellow" && textBox1.Text != "Blue")
            {
                PrimerPunto.Text = "0";
            }
            else if (textBox2.Text == "Red" && textBox3.Text != "Yellow" && textBox1.Text != "Blue")
            {
                PrimerPunto.Text = "1";
            }
            else if (textBox2.Text != "Red" && textBox3.Text == "Yellow" && textBox1.Text != "Blue")
            {
                PrimerPunto.Text = "1";
            }
            else if (textBox2.Text != "Red" && textBox3.Text != "Yellow" && textBox1.Text == "Blue")
            {
                PrimerPunto.Text = "1";
            }
            //if (textBox4.Text=="are" && textBox5.Text=="fine" && textBox6.Text=="meet" && textBox7.Text=="too" && textBox8.Text=="old" && textBox10.Text=="where" && textBox9.Text=="good")
            //{
            //    textBox11.Text = "10";
            //}
            
        }
        private void SumarSegundoPunto()
        {
            int suma = 0;
            if (textBox4.Text=="Are")
            {
                textBox13.Text = 1.ToString();
            }
            else
            {

            }
            if (textBox5.Text == "Fine")
            {
                textBox12.Text = 1.ToString();
            }
            else
            {

            }
            if (textBox6.Text == "Meet")
            {
                textBox11.Text = 1.ToString();
            }
            else
            {

            }
            if (textBox7.Text == "Too")
            {
                textBox14.Text = 1.ToString();
            }
            else
            {

            }
            if (textBox8.Text == "Old")
            {
                textBox15.Text = 1.ToString();
            }
            else
            {

            }
            if (textBox10.Text == "Where")
            {
                textBox16.Text = 1.ToString();
            }
            else
            {

            }
            if (textBox9.Text == "Good")
            {
                textBox17.Text = 1.ToString();
            }
            else
            {

            }
            int otropunto,suma2;
            otropunto = int.Parse(PrimerPunto.Text);
            suma = int.Parse(textBox11.Text) + int.Parse(textBox12.Text) + int.Parse(textBox13.Text) + int.Parse(textBox14.Text) + int.Parse(textBox15.Text) + int.Parse(textBox16.Text) + int.Parse(textBox17.Text);
            suma2 = suma + otropunto;
            txTotal.Text = suma2.ToString();        
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            button5.Visible = false;
            groupBox1.Enabled = true;
            segundo = 59;
            minuto = 10;
            limpiar();
            EnableTrue();
            timer2.Start();
        }
        private void limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox11.Text = "0";
            textBox12.Text = "0";
            textBox13.Text = "0";
            textBox14.Text = "0";
            textBox15.Text = "0";
            textBox16.Text = "0";
            textBox17.Text = "0";
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            txTotal.Clear();
            PrimerPunto.Text = "0";
            textBox17.Text = "0";
            textBox18.Text = "0";
            textBox19.Text = "0";
            textBox20.Text = "0";
            textBox21.Text = "0";
            textBox22.Text = "0";
            textBox23.Text = "0";
            textBox24.Text = "0";
            textBox25.Text = "0";
            textBox26.Text = "0";
            textBox27.Text = "0";
            txtTotalTercerPunto.Text = "0";
        }
        private void EnableFalse()
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
        }
        private void EnableTrue()
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SumarTercerPunto()
        {
            if (txtA.Text==" ")
            {
                
            }
            else
            {

            }
            if (txtB.Text == "I")
            {
                textBox18.Text = 1.ToString();
            }
            else
            {

            }
            if (txtC.Text == "J")
            {
                textBox19.Text = 1.ToString();
            }
            else
            {

            }
            if (txtD.Text == "B")
            {
                textBox20.Text = 1.ToString();
            }
            else
            {

            }
            if (txtE.Text == "H")
            {
                textBox21.Text = 1.ToString();
            }
            else
            {

            }
            if (txtF.Text == "C")
            {
                textBox22.Text = 1.ToString();
            }
            else
            {

            }
            if (txtG.Text == "D")
            {
                textBox23.Text = 1.ToString();
            }
            else
            {

            }
            if (txtH.Text == "G")
            {
                textBox24.Text = 1.ToString();
            }
            else
            {

            }
            if (txtI.Text == "E")
            {
                textBox25.Text = 1.ToString();
            }
            else
            {

            }
            if (txtJ.Text == "F")
            {
                textBox26.Text = 1.ToString();
            }
            else
            {

            }
            if (txtK.Text == "A")
            {
                textBox27.Text = 1.ToString();
            }
            else
            {

            }

            int suma4=0,suma5=0,total=0;
            total = int.Parse(txTotal.Text);
            suma5 = int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text) + int.Parse(textBox21.Text) + int.Parse(textBox22.Text) + int.Parse(textBox23.Text) + int.Parse(textBox24.Text)+ int.Parse(textBox25.Text) + int.Parse(textBox26.Text) + int.Parse(textBox27.Text);
            suma4 = suma5 + total;
            txtTotalTercerPunto.Text = suma4.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer2.Stop();
            SumarPuntos();
            SumarSegundoPunto();
            SumarTercerPunto();
            label32.Text = "00";
            label35.Text = "00";
            MessageBox.Show("Tiempo finalizado \n su puntuación es de " + txtTotalTercerPunto.Text + " puntos de 20. ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            button5.Visible = true;
            EnableFalse();
            groupBox1.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox2.Text);
            textBox2.SelectionStart = textBox2.TextLength;
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            txtA.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtA.Text);
            txtA.SelectionStart = txtA.TextLength;
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            txtB.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtB.Text);
            txtB.SelectionStart = txtB.TextLength;
        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {
            txtC.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtC.Text);
            txtC.SelectionStart = txtC.TextLength;
        }

        private void txtD_TextChanged(object sender, EventArgs e)
        {
            txtD.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtD.Text);
            txtD.SelectionStart = txtD.TextLength;
        }

        private void txtE_TextChanged(object sender, EventArgs e)
        {
            txtE.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtE.Text);
            txtE.SelectionStart = txtE.TextLength;
        }

        private void txtF_TextChanged(object sender, EventArgs e)
        {
            txtF.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtF.Text);
            txtF.SelectionStart = txtF.TextLength;
        }

        private void txtG_TextChanged(object sender, EventArgs e)
        {
            txtG.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtG.Text);
            txtG.SelectionStart = txtG.TextLength;
        }

        private void txtH_TextChanged(object sender, EventArgs e)
        {
            txtH.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtH.Text);
            txtH.SelectionStart = txtH.TextLength;
        }

        private void txtI_TextChanged(object sender, EventArgs e)
        {
            txtI.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtI.Text);
            txtI.SelectionStart = txtI.TextLength;
        }

        private void txtJ_TextChanged(object sender, EventArgs e)
        {
            txtJ.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtJ.Text);
            txtJ.SelectionStart = txtJ.TextLength;
        }

        private void txtK_TextChanged(object sender, EventArgs e)
        {
            txtK.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtK.Text);
            txtK.SelectionStart = txtK.TextLength;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            textBox9.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox9.Text);
            textBox9.SelectionStart = textBox9.TextLength;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            textBox10.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox10.Text);
            textBox10.SelectionStart = textBox10.TextLength;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            textBox8.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox8.Text);
            textBox8.SelectionStart = textBox8.TextLength;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox7.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox7.Text);
            textBox7.SelectionStart = textBox7.TextLength;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox6.Text);
            textBox6.SelectionStart = textBox6.TextLength;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox5.Text);
            textBox5.SelectionStart = textBox5.TextLength;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox4.Text);
            textBox4.SelectionStart = textBox4.TextLength;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox3.Text);
            textBox3.SelectionStart = textBox3.TextLength;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox1.Text);
            textBox1.SelectionStart = textBox1.TextLength;
        }
    }
}
