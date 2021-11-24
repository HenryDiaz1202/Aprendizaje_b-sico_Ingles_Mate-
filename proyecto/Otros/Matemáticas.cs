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
    public partial class Matemáticas : Form
    {
        public Matemáticas()
        {
            InitializeComponent();
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel_Contenedor.Visible = true;
            AbrirFormInPanel1(new Sumar());
        }
        private void AbrirFormInPanel1(Object Formhijo)
        {
            if (this.panel_Contenedor.Controls.Count > 0)
                this.panel_Contenedor.Controls.RemoveAt(0);
             Sumar sum= new Sumar();
            sum.TopLevel = false;
            sum.Dock = DockStyle.Fill;
            this.panel_Contenedor.Controls.Add(sum);
            this.panel_Contenedor.Tag = sum;
            sum.Show();
        }

        private void panel_Contenedor_MouseHover(object sender, EventArgs e)
        {
            panel_Contenedor.Visible = false;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel_Contenedor.Visible = true;
            AbrirFormInPanel2(new Restar());
        }
        private void AbrirFormInPanel2(Object Formhijo)
        {
            if (this.panel_Contenedor.Controls.Count > 0)
                this.panel_Contenedor.Controls.RemoveAt(0);
            Restar rest = new Restar();
            rest.TopLevel = false;
            rest.Dock = DockStyle.Fill;
            this.panel_Contenedor.Controls.Add(rest);
            this.panel_Contenedor.Tag = rest;
            rest.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirFormInPanel3(new Multiplicar());
            panel_Contenedor.Visible = true;
        }
        private void AbrirFormInPanel3(Object Formhijo)
        {
            if (this.panel_Contenedor.Controls.Count > 0)
                this.panel_Contenedor.Controls.RemoveAt(0);
            Multiplicar mult = new Multiplicar();
            mult.TopLevel = false;
            mult.Dock = DockStyle.Fill;
            this.panel_Contenedor.Controls.Add(mult);
            this.panel_Contenedor.Tag = mult;
            mult.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel_Contenedor.Visible = true;
            AbrirFormInPanel4(new Dividir());
        }
        private void AbrirFormInPanel4(Object Formhijo)
        {
            if (this.panel_Contenedor.Controls.Count > 0)
                this.panel_Contenedor.Controls.RemoveAt(0);
            Dividir div = new Dividir();
            div.TopLevel = false;
            div.Dock = DockStyle.Fill;
            this.panel_Contenedor.Controls.Add(div);
            this.panel_Contenedor.Tag = div;
            div.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel_Contenedor.Visible = true;
            AbrirFormInPanel5(new pdf());
        }
        private void AbrirFormInPanel5(Object Formhijo)
        {
            if (this.panel_Contenedor.Controls.Count > 0)
                this.panel_Contenedor.Controls.RemoveAt(0);
           pdf p = new pdf();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            this.panel_Contenedor.Controls.Add(p);
            this.panel_Contenedor.Tag = p;
            p.Show();
        }

    }
}
