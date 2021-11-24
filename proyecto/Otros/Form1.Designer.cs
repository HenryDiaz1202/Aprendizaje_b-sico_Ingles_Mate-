namespace proyecto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txPantalla = new System.Windows.Forms.TextBox();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btOcho = new System.Windows.Forms.Button();
            this.btSiete = new System.Windows.Forms.Button();
            this.btCuatro = new System.Windows.Forms.Button();
            this.btCinco = new System.Windows.Forms.Button();
            this.btMas = new System.Windows.Forms.Button();
            this.btUno = new System.Windows.Forms.Button();
            this.btDos = new System.Windows.Forms.Button();
            this.btMenos = new System.Windows.Forms.Button();
            this.btCero = new System.Windows.Forms.Button();
            this.btDividir = new System.Windows.Forms.Button();
            this.btPor = new System.Windows.Forms.Button();
            this.btIgual = new System.Windows.Forms.Button();
            this.btTres = new System.Windows.Forms.Button();
            this.btSeis = new System.Windows.Forms.Button();
            this.btNueve = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(59, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txPantalla
            // 
            this.txPantalla.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txPantalla.Location = new System.Drawing.Point(12, 38);
            this.txPantalla.Name = "txPantalla";
            this.txPantalla.ReadOnly = true;
            this.txPantalla.Size = new System.Drawing.Size(254, 20);
            this.txPantalla.TabIndex = 5;
            this.txPantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(12, 85);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(59, 23);
            this.btLimpiar.TabIndex = 6;
            this.btLimpiar.Text = "CE";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btOcho
            // 
            this.btOcho.Location = new System.Drawing.Point(142, 85);
            this.btOcho.Name = "btOcho";
            this.btOcho.Size = new System.Drawing.Size(59, 23);
            this.btOcho.TabIndex = 14;
            this.btOcho.Text = "8";
            this.btOcho.UseVisualStyleBackColor = true;
            this.btOcho.Click += new System.EventHandler(this.btOcho_Click);
            // 
            // btSiete
            // 
            this.btSiete.Location = new System.Drawing.Point(77, 85);
            this.btSiete.Name = "btSiete";
            this.btSiete.Size = new System.Drawing.Size(59, 23);
            this.btSiete.TabIndex = 15;
            this.btSiete.Text = "7";
            this.btSiete.UseVisualStyleBackColor = true;
            this.btSiete.Click += new System.EventHandler(this.btSiete_Click);
            // 
            // btCuatro
            // 
            this.btCuatro.Location = new System.Drawing.Point(77, 112);
            this.btCuatro.Name = "btCuatro";
            this.btCuatro.Size = new System.Drawing.Size(59, 23);
            this.btCuatro.TabIndex = 18;
            this.btCuatro.Text = "4";
            this.btCuatro.UseVisualStyleBackColor = true;
            this.btCuatro.Click += new System.EventHandler(this.btCuatro_Click);
            // 
            // btCinco
            // 
            this.btCinco.Location = new System.Drawing.Point(142, 112);
            this.btCinco.Name = "btCinco";
            this.btCinco.Size = new System.Drawing.Size(59, 23);
            this.btCinco.TabIndex = 17;
            this.btCinco.Text = "5";
            this.btCinco.UseVisualStyleBackColor = true;
            this.btCinco.Click += new System.EventHandler(this.btCinco_Click);
            // 
            // btMas
            // 
            this.btMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btMas.Location = new System.Drawing.Point(12, 112);
            this.btMas.Name = "btMas";
            this.btMas.Size = new System.Drawing.Size(59, 23);
            this.btMas.TabIndex = 16;
            this.btMas.Text = "+";
            this.btMas.UseVisualStyleBackColor = true;
            this.btMas.Click += new System.EventHandler(this.btMas_Click);
            // 
            // btUno
            // 
            this.btUno.Location = new System.Drawing.Point(77, 138);
            this.btUno.Name = "btUno";
            this.btUno.Size = new System.Drawing.Size(59, 23);
            this.btUno.TabIndex = 21;
            this.btUno.Text = "1";
            this.btUno.UseVisualStyleBackColor = true;
            this.btUno.Click += new System.EventHandler(this.btUno_Click);
            // 
            // btDos
            // 
            this.btDos.Location = new System.Drawing.Point(142, 138);
            this.btDos.Name = "btDos";
            this.btDos.Size = new System.Drawing.Size(59, 23);
            this.btDos.TabIndex = 20;
            this.btDos.Text = "2";
            this.btDos.UseVisualStyleBackColor = true;
            this.btDos.Click += new System.EventHandler(this.btDos_Click);
            // 
            // btMenos
            // 
            this.btMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btMenos.Location = new System.Drawing.Point(12, 138);
            this.btMenos.Name = "btMenos";
            this.btMenos.Size = new System.Drawing.Size(59, 23);
            this.btMenos.TabIndex = 19;
            this.btMenos.Text = "-";
            this.btMenos.UseVisualStyleBackColor = true;
            this.btMenos.Click += new System.EventHandler(this.btMenos_Click);
            // 
            // btCero
            // 
            this.btCero.Location = new System.Drawing.Point(142, 165);
            this.btCero.Name = "btCero";
            this.btCero.Size = new System.Drawing.Size(59, 23);
            this.btCero.TabIndex = 24;
            this.btCero.Text = "0";
            this.btCero.UseVisualStyleBackColor = true;
            this.btCero.Click += new System.EventHandler(this.btCero_Click);
            // 
            // btDividir
            // 
            this.btDividir.Location = new System.Drawing.Point(77, 165);
            this.btDividir.Name = "btDividir";
            this.btDividir.Size = new System.Drawing.Size(59, 23);
            this.btDividir.TabIndex = 23;
            this.btDividir.Text = "/";
            this.btDividir.UseVisualStyleBackColor = true;
            this.btDividir.Click += new System.EventHandler(this.btDividir_Click);
            // 
            // btPor
            // 
            this.btPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btPor.Location = new System.Drawing.Point(12, 165);
            this.btPor.Name = "btPor";
            this.btPor.Size = new System.Drawing.Size(59, 23);
            this.btPor.TabIndex = 22;
            this.btPor.Text = "*";
            this.btPor.UseVisualStyleBackColor = true;
            this.btPor.Click += new System.EventHandler(this.btPor_Click);
            // 
            // btIgual
            // 
            this.btIgual.Location = new System.Drawing.Point(207, 165);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(59, 52);
            this.btIgual.TabIndex = 28;
            this.btIgual.Text = "=";
            this.btIgual.UseVisualStyleBackColor = true;
            this.btIgual.Click += new System.EventHandler(this.btIgual_Click);
            // 
            // btTres
            // 
            this.btTres.Location = new System.Drawing.Point(207, 138);
            this.btTres.Name = "btTres";
            this.btTres.Size = new System.Drawing.Size(59, 23);
            this.btTres.TabIndex = 27;
            this.btTres.Text = "3";
            this.btTres.UseVisualStyleBackColor = true;
            this.btTres.Click += new System.EventHandler(this.btTres_Click);
            // 
            // btSeis
            // 
            this.btSeis.Location = new System.Drawing.Point(207, 112);
            this.btSeis.Name = "btSeis";
            this.btSeis.Size = new System.Drawing.Size(59, 23);
            this.btSeis.TabIndex = 26;
            this.btSeis.Text = "6";
            this.btSeis.UseVisualStyleBackColor = true;
            this.btSeis.Click += new System.EventHandler(this.btSeis_Click);
            // 
            // btNueve
            // 
            this.btNueve.Location = new System.Drawing.Point(207, 85);
            this.btNueve.Name = "btNueve";
            this.btNueve.Size = new System.Drawing.Size(59, 23);
            this.btNueve.TabIndex = 25;
            this.btNueve.Text = "9";
            this.btNueve.UseVisualStyleBackColor = true;
            this.btNueve.Click += new System.EventHandler(this.btNueve_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(141, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "√";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(76, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "%";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(11, 194);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 23);
            this.button4.TabIndex = 29;
            this.button4.Text = ".";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(279, 237);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btIgual);
            this.Controls.Add(this.btTres);
            this.Controls.Add(this.btSeis);
            this.Controls.Add(this.btNueve);
            this.Controls.Add(this.btCero);
            this.Controls.Add(this.btDividir);
            this.Controls.Add(this.btPor);
            this.Controls.Add(this.btUno);
            this.Controls.Add(this.btDos);
            this.Controls.Add(this.btMenos);
            this.Controls.Add(this.btCuatro);
            this.Controls.Add(this.btCinco);
            this.Controls.Add(this.btMas);
            this.Controls.Add(this.btSiete);
            this.Controls.Add(this.btOcho);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.txPantalla);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txPantalla;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btOcho;
        private System.Windows.Forms.Button btSiete;
        private System.Windows.Forms.Button btCuatro;
        private System.Windows.Forms.Button btCinco;
        private System.Windows.Forms.Button btMas;
        private System.Windows.Forms.Button btUno;
        private System.Windows.Forms.Button btDos;
        private System.Windows.Forms.Button btMenos;
        private System.Windows.Forms.Button btCero;
        private System.Windows.Forms.Button btDividir;
        private System.Windows.Forms.Button btPor;
        private System.Windows.Forms.Button btIgual;
        private System.Windows.Forms.Button btTres;
        private System.Windows.Forms.Button btSeis;
        private System.Windows.Forms.Button btNueve;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;

    }
}

