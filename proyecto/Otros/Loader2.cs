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
    public partial class Loader2 : Form
    {
        public Loader2()
        {
            InitializeComponent();
        }
        int contador ;
        private void timer1_Tick(object sender, EventArgs e)
        {            
            if (progressBar1.Value < 100 )
            {
                contador = contador + 50;
            progressBar1.Value = contador;
            }            
        else
            {
                Form5 f5 = new Form5();
                f5.Show();
                timer1.Enabled = false;
                this.Hide();
            }
        }
        private void Loader2_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
