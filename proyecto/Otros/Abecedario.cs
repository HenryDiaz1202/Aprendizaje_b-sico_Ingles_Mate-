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
    public partial class Abecedario : Form
    {

        public Abecedario()
        {
            InitializeComponent();
        }

        private void Abecedario_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
            //tarea.Start("El abecedario español, tiene 27 letras, ");
            timer1.Enabled = true;
        }
        private void Hablar(object texto)
        {
            SpeechSynthesizer voz = new SpeechSynthesizer();
            SpeechSynthesizer audio = new SpeechSynthesizer();
            voz.SetOutputToDefaultAudioDevice();
            voz.Speak(texto.ToString());
        }
        int contador = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            button2.Visible = true;
            contador = contador + 1;

            if (contador == 4)
            {
                pictureBox1.Image = pbA.Image;
                Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
                tarea.Start("A");
            }
            if (contador == 7)
            {
                pictureBox1.Image = pbB.Image;
                Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
                tarea.Start("B");
            }
            if (contador == 10)
            {
                pictureBox1.Image = pbC.Image;
                Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
                tarea.Start("C");
            }
            if (contador == 13)
            {
                pictureBox1.Image = pbD.Image;
                Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
                tarea.Start("D");
            }
            if (contador == 16)
            {
                pictureBox1.Image = pbE.Image;
                Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
                tarea.Start("E");
            }

            if (contador == 19)
            {
                pictureBox1.Image = pbF.Image;
                Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
                tarea.Start("F");
            }

            if (contador == 22)
            {
                pictureBox1.Image = pbG.Image;
                Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
                tarea.Start("G");
            }


            if (contador == 25)
            {
                pictureBox1.Image = pbH.Image;
                Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
                tarea.Start("H");
            }


            if (contador == 28)
            {
                pictureBox1.Image = pbI.Image;
                Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
                tarea.Start("Í");
            }
            if (contador == 31)
            {
                pictureBox1.Image = pbJ.Image;
                Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
                tarea.Start("J");
            }
            if (contador == 34)
            {
                pictureBox1.Image = pbK.Image;
                Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
                tarea.Start("K");
            }
            if (contador == 37)
            {
                pictureBox1.Image = pbL.Image;
                Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
                tarea.Start("L");
            }
            if (contador == 40)
            {
                pictureBox1.Image = pbM.Image;
                Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
                tarea.Start("M");
            }
            if (contador == 43)
            {
                pictureBox1.Image = pbN.Image;
                Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
                tarea.Start("N");
            }
            if (contador == 46)
            {
                pictureBox1.Image = pbÑ.Image;
                Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
                tarea.Start("Ñ");
            }
            if (contador == 49)
            {
                pictureBox1.Image = pbO.Image;
                Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
                tarea.Start("Ó");
            }
            if (contador == 52)
            {
                pictureBox1.Image = pbP.Image;
                Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
                tarea.Start("P");
            }
            if (contador == 55)
            {
                pictureBox1.Image = pbQ.Image;
                Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
                tarea.Start("Q");
            }
            if (contador == 58)
            {
                pictureBox1.Image = pbR.Image;
                Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
                tarea.Start("R");
            }
            if (contador == 61)
            {
                pictureBox1.Image = pbS.Image;
                Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
                tarea.Start("S");
            }
            if (contador == 64)
            {
                pictureBox1.Image = pbT.Image;
                Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
                tarea.Start("T");
            }
            if (contador == 67)
            {
                pictureBox1.Image = pbU.Image;
                Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
                tarea.Start("U");
            }
            if (contador == 70)
            {
                pictureBox1.Image = pbV.Image;
                Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
                tarea.Start("V");
            }
            if (contador == 73)
            {
                pictureBox1.Image = pbW.Image;
                Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
                tarea.Start("doblevé");
            }
            if (contador == 76)
            {
                pictureBox1.Image = pbX.Image;
                Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
                tarea.Start("X");
            }
            if (contador == 79)
            {
                pictureBox1.Image = pbY.Image;
                Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
                tarea.Start("Yé");
            }
            if (contador == 82)
            {
                pictureBox1.Image = pbZ.Image;
                Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
                tarea.Start("Z");
            }
//////////////////////////////////////////////////////////////////////////////////////////////////////////

            if (contador == 85)
            {
                pictureBox1.Image = pbA.Image;
                Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
                tarea.Start("Las vocales.");
            }

            if (contador == 88)
            {
                pictureBox1.Image = pbA.Image;
                Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
                tarea.Start("A");
            }
            if (contador == 91)
            {
                pictureBox1.Image = pbE.Image;
                Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
                tarea.Start("E");
            }
            if (contador == 94)
            {
                pictureBox1.Image = pbI.Image;
                Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
                tarea.Start("I");
            }
            if (contador == 97)
            {
                pictureBox1.Image = pbO.Image;
                Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
                tarea.Start("O");
            }
            if (contador == 100)
            {
                pictureBox1.Image = pbU.Image;
                Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
                tarea.Start("U");
            }
            if (contador == 103)
            {
                contador = 0;
                timer1.Stop();
                button2.Visible = false;
                pictureBox1.Image = pbTodo.Image;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            timer1.Enabled = false;
        }
    }
}
