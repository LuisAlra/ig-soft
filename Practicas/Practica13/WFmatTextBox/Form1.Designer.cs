namespace WFmatTextBox
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
            this.TbMat = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tbm = new System.Windows.Forms.TextBox();
            this.Tbn = new System.Windows.Forms.TextBox();
            this.TbTamaño = new System.Windows.Forms.Button();
            this.TbLeerMat = new System.Windows.Forms.Button();
            this.TbPonerMat = new System.Windows.Forms.Button();
            this.LbMat = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Tbindi = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtFirma = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbMat
            // 
            this.TbMat.Location = new System.Drawing.Point(7, 25);
            this.TbMat.Multiline = true;
            this.TbMat.Name = "TbMat";
            this.TbMat.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TbMat.Size = new System.Drawing.Size(388, 275);
            this.TbMat.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1081, 28);
            this.menuStrip1.TabIndex = 1;
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
            this.firmaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.firmaToolStripMenuItem.Text = "Firma";
            this.firmaToolStripMenuItem.Click += new System.EventHandler(this.firmaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Tbm
            // 
            this.Tbm.Location = new System.Drawing.Point(76, 307);
            this.Tbm.Name = "Tbm";
            this.Tbm.Size = new System.Drawing.Size(100, 22);
            this.Tbm.TabIndex = 2;
            this.Tbm.Text = "0";
            // 
            // Tbn
            // 
            this.Tbn.Location = new System.Drawing.Point(247, 306);
            this.Tbn.Name = "Tbn";
            this.Tbn.Size = new System.Drawing.Size(100, 22);
            this.Tbn.TabIndex = 3;
            this.Tbn.Text = "0";
            // 
            // TbTamaño
            // 
            this.TbTamaño.Location = new System.Drawing.Point(148, 337);
            this.TbTamaño.Name = "TbTamaño";
            this.TbTamaño.Size = new System.Drawing.Size(106, 23);
            this.TbTamaño.TabIndex = 4;
            this.TbTamaño.Text = "Tamaño";
            this.TbTamaño.UseVisualStyleBackColor = true;
            this.TbTamaño.Click += new System.EventHandler(this.TbTamaño_Click);
            // 
            // TbLeerMat
            // 
            this.TbLeerMat.Location = new System.Drawing.Point(47, 43);
            this.TbLeerMat.Name = "TbLeerMat";
            this.TbLeerMat.Size = new System.Drawing.Size(106, 23);
            this.TbLeerMat.TabIndex = 5;
            this.TbLeerMat.Text = "Leer Matriz";
            this.TbLeerMat.UseVisualStyleBackColor = true;
            this.TbLeerMat.Click += new System.EventHandler(this.TbLeerMat_Click);
            // 
            // TbPonerMat
            // 
            this.TbPonerMat.Location = new System.Drawing.Point(47, 95);
            this.TbPonerMat.Name = "TbPonerMat";
            this.TbPonerMat.Size = new System.Drawing.Size(106, 23);
            this.TbPonerMat.TabIndex = 6;
            this.TbPonerMat.Text = "Poner Matriz";
            this.TbPonerMat.UseVisualStyleBackColor = true;
            this.TbPonerMat.Click += new System.EventHandler(this.TbPonerMat_Click);
            // 
            // LbMat
            // 
            this.LbMat.FormattingEnabled = true;
            this.LbMat.HorizontalScrollbar = true;
            this.LbMat.ItemHeight = 16;
            this.LbMat.Location = new System.Drawing.Point(6, 22);
            this.LbMat.Name = "LbMat";
            this.LbMat.ScrollAlwaysVisible = true;
            this.LbMat.Size = new System.Drawing.Size(388, 340);
            this.LbMat.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TbMat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Tbm);
            this.groupBox1.Controls.Add(this.Tbn);
            this.groupBox1.Controls.Add(this.TbTamaño);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 366);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "n=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "m=";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Tbindi);
            this.groupBox2.Controls.Add(this.TbLeerMat);
            this.groupBox2.Controls.Add(this.TbPonerMat);
            this.groupBox2.Location = new System.Drawing.Point(441, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 366);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Proceso";
            // 
            // Tbindi
            // 
            this.Tbindi.Location = new System.Drawing.Point(6, 293);
            this.Tbindi.Multiline = true;
            this.Tbindi.Name = "Tbindi";
            this.Tbindi.ReadOnly = true;
            this.Tbindi.Size = new System.Drawing.Size(186, 55);
            this.Tbindi.TabIndex = 7;
            this.Tbindi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LbMat);
            this.groupBox3.Location = new System.Drawing.Point(667, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 366);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Proceso";
            // 
            // BtFirma
            // 
            this.BtFirma.Location = new System.Drawing.Point(992, 457);
            this.BtFirma.Name = "BtFirma";
            this.BtFirma.Size = new System.Drawing.Size(75, 23);
            this.BtFirma.TabIndex = 12;
            this.BtFirma.Text = "Firma";
            this.BtFirma.UseVisualStyleBackColor = true;
            this.BtFirma.Click += new System.EventHandler(this.BtFirma_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(784, 27);
            this.label3.TabIndex = 13;
            this.label3.Text = "Practica: Implementación de arreglos con TextBox (multilinea) en WF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 492);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtFirma);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Practica";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbMat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.TextBox Tbm;
        private System.Windows.Forms.TextBox Tbn;
        private System.Windows.Forms.Button TbTamaño;
        private System.Windows.Forms.Button TbLeerMat;
        private System.Windows.Forms.Button TbPonerMat;
        private System.Windows.Forms.ListBox LbMat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Tbindi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtFirma;
        private System.Windows.Forms.Label label3;
    }
}

