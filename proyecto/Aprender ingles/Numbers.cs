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
    public partial class Numbers : Form
    {
        public Numbers()
        {
            InitializeComponent();
        }
        private void Hablar(object texto)
        {
            SpeechSynthesizer voz = new SpeechSynthesizer();
            SpeechSynthesizer audio = new SpeechSynthesizer();
            voz.SetOutputToDefaultAudioDevice();
            voz.Speak(texto.ToString());
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
            tarea.Start("one");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
            tarea.Start("two");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
            tarea.Start("three");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
            tarea.Start("four");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
            tarea.Start("five");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
            tarea.Start("six");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
            tarea.Start("seven");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
            tarea.Start("eight");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
            tarea.Start("nai");
        }
         
        private void button11_Click(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
            tarea.Start("ten");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
            tarea.Start("ileven");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
            tarea.Start("twelve");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
            tarea.Start("zéeRtíin");
        }

        private void label17_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
            tarea.Start("fifteen");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
            tarea.Start("sixteen");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
            tarea.Start("sebentín");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
            tarea.Start("eityn");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
            tarea.Start("naintíin");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
            tarea.Start("tuenty");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
            tarea.Start("fourteen");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
            tarea.Start("certy");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
            tarea.Start("fory");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
            tarea.Start("fifty");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
            tarea.Start("sixty");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
            tarea.Start("sébenty");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
            tarea.Start("eyty");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
            tarea.Start("naity");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
            tarea.Start("uanjándred");
        }
    }
}
