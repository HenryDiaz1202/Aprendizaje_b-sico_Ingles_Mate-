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
    public partial class Form5 : Form
    {
        int Contador = 0;
        public Form5()
        {
            InitializeComponent();
        }
        private void Form5_Load_1(object sender, EventArgs e)
        {

            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Parent = panel2;

            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Parent = panel1;

            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Parent = panel1;

            //button1.BackColor = Color.Transparent;
            //button1.Parent = pictureBox1;

            timer1.Enabled = true;
            pictureBox10.Visible = true;
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult RESULTADO= MessageBox.Show("Esta seguro que quiere salir del programa?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(RESULTADO==DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabbedMdiManager1_PageRemoved(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
        {
           //// DialogResult resultao;
           ////resultao =
           // if(MessageBox.Show("¿Seguro que quiere cerrar la página?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
           // {

           // }
           // else if(MessageBox.Show("¿Seguro que quiere cerrar la página?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)
           // {
           // }
           ////if (resultao == DialogResult.OK)
           ////{
           ////    button1.Visible = true;
           ////}
           //// else
           //// {

           //// }   
        }

        private void ImagenInvisible()
        {
            pictureBox10.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Abecedario abcd = new Abecedario();
            abcd.Show();
            abcd.MdiParent = this;
            ImagenInvisible();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Tablas tab = new Tablas();
            tab.Show();
            tab.MdiParent = this;
            ImagenInvisible();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ingles ing = new Ingles();
            ing.Show();
            ing.MdiParent = this;
            ImagenInvisible();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Matemáticas math = new Matemáticas();
            math.Show();
            math.MdiParent = this;
            ImagenInvisible();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult resul;
            resul = MessageBox.Show("El test tendrá un tiempo máximo de 15 minutos \n cuando finalice se mostrarán los resultados.","Aviso",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if(resul==DialogResult.OK)
            {
                TestMatematicas testMa = new TestMatematicas();
                testMa.Show();
                testMa.MdiParent = this;
                ImagenInvisible();
            }
            else
            {

            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult resul;
            resul = MessageBox.Show("El test tendrá un tiempo máximo de 10 minutos \n cuando finalice se mostrarán los resultados.","Aviso",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if(resul==DialogResult.OK)
            {
                TestIngles testIng = new TestIngles();
                testIng.Show();
                testIng.MdiParent = this;
                ImagenInvisible();
            }
            else
            {

            }
        }

        int posX = 0;
        int posY = 0;
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            Contador = Contador + 1;
            if(Contador==10)
            {
                pictureBox2.Image = pictureBox3.Image;
            }
            if (Contador ==15)
            {
                pictureBox2.Image = pictureBox6.Image;
            }
            if (Contador == 20)
            {
                Contador = 1;
                pictureBox2.Image = pictureBox7.Image;

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form5_MouseHover(object sender, EventArgs e)
        {
            pictureBox10.Visible = true;
        }
    }
}
