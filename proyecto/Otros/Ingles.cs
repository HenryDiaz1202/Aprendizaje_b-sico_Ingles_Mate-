using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace proyecto
{
    public partial class Ingles : Form
    {
        public Ingles()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbririFormInPanel1(new Numbers());
            panel_Contenedor.Width = 811;
            panel_Contenedor.Height = 486;
            panel_Contenedor.Visible = true;
        }
        private void AbririFormInPanel1(Object Formhijo)
        {
            if (this.panel_Contenedor.Controls.Count > 0)
                this.panel_Contenedor.Controls.RemoveAt(0);
            Numbers c = new Numbers();
            c.TopLevel = false;
            c.Dock = DockStyle.Fill;
            this.panel_Contenedor.Controls.Add(c);
            this.panel_Contenedor.Tag = c;
            c.Show();
        }
        private void panel_Contenedor_MouseHover(object sender, EventArgs e)
        {
            panel_Contenedor.Visible = false;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbririFormInPanel2(new COLORES());
            panel_Contenedor.Width = 811;
            panel_Contenedor.Height = 486;
            panel_Contenedor.Visible = true;
        }
        private void AbririFormInPanel2(Object Formhijo)
        {
            if (this.panel_Contenedor.Controls.Count > 0)
                this.panel_Contenedor.Controls.RemoveAt(0);
            COLORES COL = new COLORES();
            COL.TopLevel = false;
            COL.Dock = DockStyle.Fill;
            this.panel_Contenedor.Controls.Add(COL);
            this.panel_Contenedor.Tag = COL;
            COL.Show();
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirFormInPanel3(new Animales ());
            panel_Contenedor.Width = 811;
            panel_Contenedor.Height = 486;
            panel_Contenedor.Visible = true;
        }
        private void AbrirFormInPanel3(Object Formhijo)
        {
            if (this.panel_Contenedor.Controls.Count > 0)
                this.panel_Contenedor.Controls.RemoveAt(0);
            Animales  ANIM = new Animales ();
            ANIM.TopLevel = false;
            ANIM.Dock = DockStyle.Fill;
            this.panel_Contenedor.Controls.Add(ANIM);
            this.panel_Contenedor.Tag = ANIM;
            ANIM.Show();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirFormInPanel4(new Ropa());
            panel_Contenedor.Width = 811;
            panel_Contenedor.Height = 486;
            panel_Contenedor.Visible = true;
        }
        private void AbrirFormInPanel4(Object Formhijo)
        {
            if (this.panel_Contenedor.Controls.Count > 0 )
                this.panel_Contenedor.Controls.RemoveAt(0);
            Ropa rop = new Ropa();
            rop.TopLevel = false;
            rop.Dock = DockStyle.Fill;
            this.panel_Contenedor.Controls.Add(rop);
            this.panel_Contenedor.Tag = rop;
            rop.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirFormInPanel5(new Formas());
            panel_Contenedor.Width = 811;
            panel_Contenedor.Height = 486;
            panel_Contenedor.Visible = true;
        }
        private void AbrirFormInPanel5(Object Formhijo)
        {
            if (this.panel_Contenedor.Controls.Count > 0)
                this.panel_Contenedor.Controls.RemoveAt(0);
            Formas forms = new Formas();
            forms.TopLevel = false;
            forms.Dock = DockStyle.Fill;
            this.panel_Contenedor.Controls.Add(forms);
            this.panel_Contenedor.Tag = forms;
            forms.Show();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirFormInPanel6(new PartesCuerpo());
            panel_Contenedor.Width = 811;
            panel_Contenedor.Height = 486;
            panel_Contenedor.Visible = true;
        }
        private void AbrirFormInPanel6(Object Formhijo)
        {
            if (this.panel_Contenedor.Controls.Count > 0)
                this.panel_Contenedor.Controls.RemoveAt(0);
            PartesCuerpo partes = new PartesCuerpo();
            partes.TopLevel = false;
            partes.Dock = DockStyle.Fill;
            this.panel_Contenedor.Controls.Add(partes);
            this.panel_Contenedor.Tag = partes;
            partes.Show();
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirFormInPanel7(new DaysAndMonths());
            panel_Contenedor.Width = 811;
            panel_Contenedor.Height = 486;
            panel_Contenedor.Visible = true;
        }
        private void AbrirFormInPanel7(Object Formhijo)
        {
            if (this.panel_Contenedor.Controls.Count > 0)
                this.panel_Contenedor.Controls.RemoveAt(0);
            DaysAndMonths DIAS = new DaysAndMonths();
            DIAS.TopLevel = false;
            DIAS.Dock = DockStyle.Fill;
            this.panel_Contenedor.Controls.Add(DIAS);
            this.panel_Contenedor.Tag = DIAS;
            DIAS.Show();
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirFormInPanel8(new Familia());
            panel_Contenedor.Width = 811;
            panel_Contenedor.Height = 486;
            panel_Contenedor.Visible = true;
        }
        private void AbrirFormInPanel8(Object Formhijo)
        {
            if (this.panel_Contenedor.Controls.Count > 0)
                this.panel_Contenedor.Controls.RemoveAt(0);
            Familia fam = new Familia();
            fam.TopLevel = false;
            fam.Dock = DockStyle.Fill;
            this.panel_Contenedor.Controls.Add(fam);
            this.panel_Contenedor.Tag = fam;
            fam.Show();
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirFormInPanel9(new Comidas());
            panel_Contenedor.Width = 811;
            panel_Contenedor.Height = 486;
            panel_Contenedor.Visible = true;
        }
        private void AbrirFormInPanel9(Object Formhijo)
        {
            if (this.panel_Contenedor.Controls.Count > 0)
                this.panel_Contenedor.Controls.RemoveAt(0);
            Comidas com = new Comidas();
            com.TopLevel = false;
            com.Dock = DockStyle.Fill;
            this.panel_Contenedor.Controls.Add(com);
            this.panel_Contenedor.Tag = com;
            com.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirFormInPanel10(new Pronombres());
            panel_Contenedor.Width = 811;
            panel_Contenedor.Height = 486;
            panel_Contenedor.Visible = true;
        }
        private void AbrirFormInPanel10(Object Formhijo)
        {
            if (this.panel_Contenedor.Controls.Count > 0)
                this.panel_Contenedor.Controls.RemoveAt(0);
            Pronombres pron = new Pronombres();
            pron.TopLevel = false;
            pron.Dock = DockStyle.Fill;
            this.panel_Contenedor.Controls.Add(pron);
            this.panel_Contenedor.Tag = pron;
            pron.Show();
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirFormInPanel11(new Verbos());
            panel_Contenedor.Width = 811;
            panel_Contenedor.Height = 486;
            panel_Contenedor.Visible = true;
        }
        private void AbrirFormInPanel11(Object Formhijo)
        {
            if (this.panel_Contenedor.Controls.Count > 0)
                this.panel_Contenedor.Controls.RemoveAt(0);
            Verbos Verbs = new Verbos();
            Verbs.TopLevel = false;
            Verbs.Dock = DockStyle.Fill;
            this.panel_Contenedor.Controls.Add(Verbs);
            this.panel_Contenedor.Tag = Verbs;
            Verbs.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirFormInPanel12(new Saludos());
            panel_Contenedor.Width = 811;
            panel_Contenedor.Height = 486;
            panel_Contenedor.Visible = true;
        }
        private void AbrirFormInPanel12(Object Formhijo)
        {
            if (this.panel_Contenedor.Controls.Count > 0)
                this.panel_Contenedor.Controls.RemoveAt(0);
            Saludos sal = new Saludos();
            sal.TopLevel = false;
            sal.Dock = DockStyle.Fill;
            this.panel_Contenedor.Controls.Add(sal);
            this.panel_Contenedor.Tag = sal;
            sal.Show();
        }
    }
}
