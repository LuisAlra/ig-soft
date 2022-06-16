namespace WFCalculadora02
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBfxy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBfx = new System.Windows.Forms.TextBox();
            this.tBy = new System.Windows.Forms.TextBox();
            this.tBx = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tBmensaje = new System.Windows.Forms.TextBox();
            this.btfxy = new System.Windows.Forms.Button();
            this.btfx = new System.Windows.Forms.Button();
            this.btcot = new System.Windows.Forms.Button();
            this.btcsc = new System.Windows.Forms.Button();
            this.btsec = new System.Windows.Forms.Button();
            this.bttanh = new System.Windows.Forms.Button();
            this.btcosh = new System.Windows.Forms.Button();
            this.btsenh = new System.Windows.Forms.Button();
            this.bttani = new System.Windows.Forms.Button();
            this.btcosi = new System.Windows.Forms.Button();
            this.btseni = new System.Windows.Forms.Button();
            this.bttan = new System.Windows.Forms.Button();
            this.btcos = new System.Windows.Forms.Button();
            this.btsen = new System.Windows.Forms.Button();
            this.btdiv = new System.Windows.Forms.Button();
            this.btmult = new System.Windows.Forms.Button();
            this.btresta = new System.Windows.Forms.Button();
            this.btsuma = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.resultado = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtGraficador = new System.Windows.Forms.Button();
            this.BtFirma = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tBfxy);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tBfx);
            this.groupBox1.Controls.Add(this.tBy);
            this.groupBox1.Controls.Add(this.tBx);
            this.groupBox1.Location = new System.Drawing.Point(25, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(312, 347);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 257);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "f(x, y)";
            // 
            // tBfxy
            // 
            this.tBfxy.Location = new System.Drawing.Point(99, 255);
            this.tBfxy.Margin = new System.Windows.Forms.Padding(4);
            this.tBfxy.Name = "tBfxy";
            this.tBfxy.Size = new System.Drawing.Size(193, 22);
            this.tBfxy.TabIndex = 6;
            this.tBfxy.Text = "xy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 199);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "f(x)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "x";
            // 
            // tBfx
            // 
            this.tBfx.Location = new System.Drawing.Point(99, 199);
            this.tBfx.Margin = new System.Windows.Forms.Padding(4);
            this.tBfx.Name = "tBfx";
            this.tBfx.Size = new System.Drawing.Size(193, 22);
            this.tBfx.TabIndex = 2;
            this.tBfx.Text = "x";
            // 
            // tBy
            // 
            this.tBy.Location = new System.Drawing.Point(99, 128);
            this.tBy.Margin = new System.Windows.Forms.Padding(4);
            this.tBy.Name = "tBy";
            this.tBy.Size = new System.Drawing.Size(132, 22);
            this.tBy.TabIndex = 1;
            this.tBy.Text = "0";
            // 
            // tBx
            // 
            this.tBx.Location = new System.Drawing.Point(99, 58);
            this.tBx.Margin = new System.Windows.Forms.Padding(4);
            this.tBx.Name = "tBx";
            this.tBx.Size = new System.Drawing.Size(132, 22);
            this.tBx.TabIndex = 0;
            this.tBx.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tBmensaje);
            this.groupBox2.Controls.Add(this.btfxy);
            this.groupBox2.Controls.Add(this.btfx);
            this.groupBox2.Controls.Add(this.btcot);
            this.groupBox2.Controls.Add(this.btcsc);
            this.groupBox2.Controls.Add(this.btsec);
            this.groupBox2.Controls.Add(this.bttanh);
            this.groupBox2.Controls.Add(this.btcosh);
            this.groupBox2.Controls.Add(this.btsenh);
            this.groupBox2.Controls.Add(this.bttani);
            this.groupBox2.Controls.Add(this.btcosi);
            this.groupBox2.Controls.Add(this.btseni);
            this.groupBox2.Controls.Add(this.bttan);
            this.groupBox2.Controls.Add(this.btcos);
            this.groupBox2.Controls.Add(this.btsen);
            this.groupBox2.Controls.Add(this.btdiv);
            this.groupBox2.Controls.Add(this.btmult);
            this.groupBox2.Controls.Add(this.btresta);
            this.groupBox2.Controls.Add(this.btsuma);
            this.groupBox2.Location = new System.Drawing.Point(401, 46);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(456, 373);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Proceso";
            // 
            // tBmensaje
            // 
            this.tBmensaje.Location = new System.Drawing.Point(35, 332);
            this.tBmensaje.Margin = new System.Windows.Forms.Padding(4);
            this.tBmensaje.Name = "tBmensaje";
            this.tBmensaje.Size = new System.Drawing.Size(197, 22);
            this.tBmensaje.TabIndex = 3;
            // 
            // btfxy
            // 
            this.btfxy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btfxy.Location = new System.Drawing.Point(132, 283);
            this.btfxy.Margin = new System.Windows.Forms.Padding(4);
            this.btfxy.Name = "btfxy";
            this.btfxy.Size = new System.Drawing.Size(100, 28);
            this.btfxy.TabIndex = 17;
            this.btfxy.Text = "f(x,y)";
            this.btfxy.UseVisualStyleBackColor = false;
            this.btfxy.Click += new System.EventHandler(this.btfxy_Click);
            // 
            // btfx
            // 
            this.btfx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btfx.Location = new System.Drawing.Point(24, 283);
            this.btfx.Margin = new System.Windows.Forms.Padding(4);
            this.btfx.Name = "btfx";
            this.btfx.Size = new System.Drawing.Size(100, 28);
            this.btfx.TabIndex = 16;
            this.btfx.Text = "f(x)";
            this.btfx.UseVisualStyleBackColor = false;
            this.btfx.Click += new System.EventHandler(this.btfx_Click);
            // 
            // btcot
            // 
            this.btcot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btcot.Location = new System.Drawing.Point(348, 196);
            this.btcot.Margin = new System.Windows.Forms.Padding(4);
            this.btcot.Name = "btcot";
            this.btcot.Size = new System.Drawing.Size(100, 28);
            this.btcot.TabIndex = 15;
            this.btcot.Text = "Cot";
            this.btcot.UseVisualStyleBackColor = false;
            this.btcot.Click += new System.EventHandler(this.btcot_Click);
            // 
            // btcsc
            // 
            this.btcsc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btcsc.Location = new System.Drawing.Point(240, 196);
            this.btcsc.Margin = new System.Windows.Forms.Padding(4);
            this.btcsc.Name = "btcsc";
            this.btcsc.Size = new System.Drawing.Size(100, 28);
            this.btcsc.TabIndex = 14;
            this.btcsc.Text = "Csc";
            this.btcsc.UseVisualStyleBackColor = false;
            this.btcsc.Click += new System.EventHandler(this.btcsc_Click);
            // 
            // btsec
            // 
            this.btsec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btsec.Location = new System.Drawing.Point(132, 196);
            this.btsec.Margin = new System.Windows.Forms.Padding(4);
            this.btsec.Name = "btsec";
            this.btsec.Size = new System.Drawing.Size(100, 28);
            this.btsec.TabIndex = 13;
            this.btsec.Text = "Sec";
            this.btsec.UseVisualStyleBackColor = false;
            this.btsec.Click += new System.EventHandler(this.btsec_Click);
            // 
            // bttanh
            // 
            this.bttanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bttanh.Location = new System.Drawing.Point(24, 196);
            this.bttanh.Margin = new System.Windows.Forms.Padding(4);
            this.bttanh.Name = "bttanh";
            this.bttanh.Size = new System.Drawing.Size(100, 28);
            this.bttanh.TabIndex = 12;
            this.bttanh.Text = "Tanh";
            this.bttanh.UseVisualStyleBackColor = false;
            this.bttanh.Click += new System.EventHandler(this.bttanh_Click);
            // 
            // btcosh
            // 
            this.btcosh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btcosh.Location = new System.Drawing.Point(348, 144);
            this.btcosh.Margin = new System.Windows.Forms.Padding(4);
            this.btcosh.Name = "btcosh";
            this.btcosh.Size = new System.Drawing.Size(100, 28);
            this.btcosh.TabIndex = 11;
            this.btcosh.Text = "Cosh";
            this.btcosh.UseVisualStyleBackColor = false;
            this.btcosh.Click += new System.EventHandler(this.btcosh_Click);
            // 
            // btsenh
            // 
            this.btsenh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btsenh.Location = new System.Drawing.Point(240, 143);
            this.btsenh.Margin = new System.Windows.Forms.Padding(4);
            this.btsenh.Name = "btsenh";
            this.btsenh.Size = new System.Drawing.Size(100, 28);
            this.btsenh.TabIndex = 10;
            this.btsenh.Text = "Senh";
            this.btsenh.UseVisualStyleBackColor = false;
            this.btsenh.Click += new System.EventHandler(this.btsenh_Click);
            // 
            // bttani
            // 
            this.bttani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bttani.Location = new System.Drawing.Point(132, 143);
            this.bttani.Margin = new System.Windows.Forms.Padding(4);
            this.bttani.Name = "bttani";
            this.bttani.Size = new System.Drawing.Size(100, 28);
            this.bttani.TabIndex = 9;
            this.bttani.Text = "Tan-1";
            this.bttani.UseVisualStyleBackColor = false;
            this.bttani.Click += new System.EventHandler(this.bttani_Click);
            // 
            // btcosi
            // 
            this.btcosi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btcosi.Location = new System.Drawing.Point(24, 143);
            this.btcosi.Margin = new System.Windows.Forms.Padding(4);
            this.btcosi.Name = "btcosi";
            this.btcosi.Size = new System.Drawing.Size(100, 28);
            this.btcosi.TabIndex = 8;
            this.btcosi.Text = "Cos-1";
            this.btcosi.UseVisualStyleBackColor = false;
            this.btcosi.Click += new System.EventHandler(this.btcosi_Click);
            // 
            // btseni
            // 
            this.btseni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btseni.Location = new System.Drawing.Point(348, 85);
            this.btseni.Margin = new System.Windows.Forms.Padding(4);
            this.btseni.Name = "btseni";
            this.btseni.Size = new System.Drawing.Size(100, 28);
            this.btseni.TabIndex = 7;
            this.btseni.Text = "Sen-1";
            this.btseni.UseVisualStyleBackColor = false;
            this.btseni.Click += new System.EventHandler(this.btseni_Click);
            // 
            // bttan
            // 
            this.bttan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bttan.Location = new System.Drawing.Point(240, 85);
            this.bttan.Margin = new System.Windows.Forms.Padding(4);
            this.bttan.Name = "bttan";
            this.bttan.Size = new System.Drawing.Size(100, 28);
            this.bttan.TabIndex = 6;
            this.bttan.Text = "Tan";
            this.bttan.UseVisualStyleBackColor = false;
            this.bttan.Click += new System.EventHandler(this.bttan_Click);
            // 
            // btcos
            // 
            this.btcos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btcos.Location = new System.Drawing.Point(132, 85);
            this.btcos.Margin = new System.Windows.Forms.Padding(4);
            this.btcos.Name = "btcos";
            this.btcos.Size = new System.Drawing.Size(100, 28);
            this.btcos.TabIndex = 5;
            this.btcos.Text = "Cos";
            this.btcos.UseVisualStyleBackColor = false;
            this.btcos.Click += new System.EventHandler(this.btcos_Click);
            // 
            // btsen
            // 
            this.btsen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btsen.Location = new System.Drawing.Point(24, 85);
            this.btsen.Margin = new System.Windows.Forms.Padding(4);
            this.btsen.Name = "btsen";
            this.btsen.Size = new System.Drawing.Size(100, 28);
            this.btsen.TabIndex = 4;
            this.btsen.Text = "Sen";
            this.btsen.UseVisualStyleBackColor = false;
            this.btsen.Click += new System.EventHandler(this.btsen_Click);
            // 
            // btdiv
            // 
            this.btdiv.Location = new System.Drawing.Point(348, 37);
            this.btdiv.Margin = new System.Windows.Forms.Padding(4);
            this.btdiv.Name = "btdiv";
            this.btdiv.Size = new System.Drawing.Size(100, 28);
            this.btdiv.TabIndex = 3;
            this.btdiv.Text = "/";
            this.btdiv.UseVisualStyleBackColor = true;
            this.btdiv.Click += new System.EventHandler(this.btdiv_Click);
            // 
            // btmult
            // 
            this.btmult.Location = new System.Drawing.Point(240, 37);
            this.btmult.Margin = new System.Windows.Forms.Padding(4);
            this.btmult.Name = "btmult";
            this.btmult.Size = new System.Drawing.Size(100, 28);
            this.btmult.TabIndex = 2;
            this.btmult.Text = "*";
            this.btmult.UseVisualStyleBackColor = true;
            this.btmult.Click += new System.EventHandler(this.btmult_Click);
            // 
            // btresta
            // 
            this.btresta.Location = new System.Drawing.Point(132, 37);
            this.btresta.Margin = new System.Windows.Forms.Padding(4);
            this.btresta.Name = "btresta";
            this.btresta.Size = new System.Drawing.Size(100, 28);
            this.btresta.TabIndex = 1;
            this.btresta.Text = "-";
            this.btresta.UseVisualStyleBackColor = true;
            this.btresta.Click += new System.EventHandler(this.btresta_Click);
            // 
            // btsuma
            // 
            this.btsuma.Location = new System.Drawing.Point(24, 37);
            this.btsuma.Margin = new System.Windows.Forms.Padding(4);
            this.btsuma.Name = "btsuma";
            this.btsuma.Size = new System.Drawing.Size(100, 28);
            this.btsuma.TabIndex = 0;
            this.btsuma.Text = "+";
            this.btsuma.UseVisualStyleBackColor = true;
            this.btsuma.Click += new System.EventHandler(this.btsuma_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.resultado);
            this.groupBox3.Location = new System.Drawing.Point(893, 46);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(229, 354);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Salida";
            // 
            // resultado
            // 
            this.resultado.FormattingEnabled = true;
            this.resultado.ItemHeight = 16;
            this.resultado.Items.AddRange(new object[] {
            " "});
            this.resultado.Location = new System.Drawing.Point(8, 27);
            this.resultado.Margin = new System.Windows.Forms.Padding(4);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(197, 308);
            this.resultado.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1152, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // firmaToolStripMenuItem
            // 
            this.firmaToolStripMenuItem.Name = "firmaToolStripMenuItem";
            this.firmaToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.firmaToolStripMenuItem.Text = "Firma";
            this.firmaToolStripMenuItem.Click += new System.EventHandler(this.firmaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // BtGraficador
            // 
            this.BtGraficador.Location = new System.Drawing.Point(98, 419);
            this.BtGraficador.Name = "BtGraficador";
            this.BtGraficador.Size = new System.Drawing.Size(101, 29);
            this.BtGraficador.TabIndex = 5;
            this.BtGraficador.Text = "A graficador";
            this.BtGraficador.UseVisualStyleBackColor = true;
            this.BtGraficador.Click += new System.EventHandler(this.BtGraficador_Click);
            // 
            // BtFirma
            // 
            this.BtFirma.Location = new System.Drawing.Point(1050, 500);
            this.BtFirma.Name = "BtFirma";
            this.BtFirma.Size = new System.Drawing.Size(72, 29);
            this.BtFirma.TabIndex = 6;
            this.BtFirma.Text = "Firma";
            this.BtFirma.UseVisualStyleBackColor = true;
            this.BtFirma.Click += new System.EventHandler(this.BtFirma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 554);
            this.Controls.Add(this.BtFirma);
            this.Controls.Add(this.BtGraficador);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tBy;
        private System.Windows.Forms.TextBox tBx;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btcot;
        private System.Windows.Forms.Button btcsc;
        private System.Windows.Forms.Button btsec;
        private System.Windows.Forms.Button bttanh;
        private System.Windows.Forms.Button btcosh;
        private System.Windows.Forms.Button btsenh;
        private System.Windows.Forms.Button bttani;
        private System.Windows.Forms.Button btcosi;
        private System.Windows.Forms.Button btseni;
        private System.Windows.Forms.Button bttan;
        private System.Windows.Forms.Button btcos;
        private System.Windows.Forms.Button btsen;
        private System.Windows.Forms.Button btdiv;
        private System.Windows.Forms.Button btmult;
        private System.Windows.Forms.Button btresta;
        private System.Windows.Forms.Button btsuma;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox resultado;
        private System.Windows.Forms.TextBox tBmensaje;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaToolStripMenuItem;
        private System.Windows.Forms.TextBox tBfx;
        private System.Windows.Forms.Button btfx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBfxy;
        private System.Windows.Forms.Button btfxy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button BtGraficador;
        private System.Windows.Forms.Button BtFirma;
    }
}

