namespace WFmatDataGrid01
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
            this.DGMat = new System.Windows.Forms.DataGridView();
            this.Tbm = new System.Windows.Forms.TextBox();
            this.Tbn = new System.Windows.Forms.TextBox();
            this.BtLeer = new System.Windows.Forms.Button();
            this.BtPoner = new System.Windows.Forms.Button();
            this.BtTamaño = new System.Windows.Forms.Button();
            this.LbMat = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Tbindi = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtFirma = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGMat)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGMat
            // 
            this.DGMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGMat.ColumnHeadersVisible = false;
            this.DGMat.Location = new System.Drawing.Point(6, 21);
            this.DGMat.Name = "DGMat";
            this.DGMat.RowHeadersVisible = false;
            this.DGMat.RowHeadersWidth = 51;
            this.DGMat.RowTemplate.Height = 24;
            this.DGMat.Size = new System.Drawing.Size(388, 275);
            this.DGMat.TabIndex = 0;
            // 
            // Tbm
            // 
            this.Tbm.Location = new System.Drawing.Point(74, 301);
            this.Tbm.Name = "Tbm";
            this.Tbm.Size = new System.Drawing.Size(100, 22);
            this.Tbm.TabIndex = 1;
            this.Tbm.Text = "0";
            // 
            // Tbn
            // 
            this.Tbn.Location = new System.Drawing.Point(244, 302);
            this.Tbn.Name = "Tbn";
            this.Tbn.Size = new System.Drawing.Size(100, 22);
            this.Tbn.TabIndex = 2;
            this.Tbn.Text = "0";
            // 
            // BtLeer
            // 
            this.BtLeer.Location = new System.Drawing.Point(47, 36);
            this.BtLeer.Name = "BtLeer";
            this.BtLeer.Size = new System.Drawing.Size(106, 23);
            this.BtLeer.TabIndex = 3;
            this.BtLeer.Text = "Leer Matriz";
            this.BtLeer.UseVisualStyleBackColor = true;
            this.BtLeer.Click += new System.EventHandler(this.BtLeer_Click);
            // 
            // BtPoner
            // 
            this.BtPoner.Location = new System.Drawing.Point(47, 86);
            this.BtPoner.Name = "BtPoner";
            this.BtPoner.Size = new System.Drawing.Size(106, 23);
            this.BtPoner.TabIndex = 4;
            this.BtPoner.Text = "Poner Matriz";
            this.BtPoner.UseVisualStyleBackColor = true;
            this.BtPoner.Click += new System.EventHandler(this.BtPoner_Click);
            // 
            // BtTamaño
            // 
            this.BtTamaño.Location = new System.Drawing.Point(144, 334);
            this.BtTamaño.Name = "BtTamaño";
            this.BtTamaño.Size = new System.Drawing.Size(106, 23);
            this.BtTamaño.TabIndex = 5;
            this.BtTamaño.Text = "Tamaño";
            this.BtTamaño.UseVisualStyleBackColor = true;
            this.BtTamaño.Click += new System.EventHandler(this.BtTamaño_Click);
            // 
            // LbMat
            // 
            this.LbMat.FormattingEnabled = true;
            this.LbMat.HorizontalScrollbar = true;
            this.LbMat.ItemHeight = 16;
            this.LbMat.Items.AddRange(new object[] {
            " "});
            this.LbMat.Location = new System.Drawing.Point(6, 20);
            this.LbMat.Name = "LbMat";
            this.LbMat.ScrollAlwaysVisible = true;
            this.LbMat.Size = new System.Drawing.Size(388, 340);
            this.LbMat.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1081, 28);
            this.menuStrip1.TabIndex = 7;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DGMat);
            this.groupBox1.Controls.Add(this.Tbm);
            this.groupBox1.Controls.Add(this.BtTamaño);
            this.groupBox1.Controls.Add(this.Tbn);
            this.groupBox1.Location = new System.Drawing.Point(12, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 366);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "n=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "m=";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Tbindi);
            this.groupBox2.Controls.Add(this.BtLeer);
            this.groupBox2.Controls.Add(this.BtPoner);
            this.groupBox2.Location = new System.Drawing.Point(445, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 366);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Proceso";
            // 
            // Tbindi
            // 
            this.Tbindi.Location = new System.Drawing.Point(6, 290);
            this.Tbindi.Multiline = true;
            this.Tbindi.Name = "Tbindi";
            this.Tbindi.ReadOnly = true;
            this.Tbindi.Size = new System.Drawing.Size(186, 55);
            this.Tbindi.TabIndex = 5;
            this.Tbindi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LbMat);
            this.groupBox3.Location = new System.Drawing.Point(669, 81);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 366);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Salida";
            // 
            // BtFirma
            // 
            this.BtFirma.Location = new System.Drawing.Point(995, 458);
            this.BtFirma.Name = "BtFirma";
            this.BtFirma.Size = new System.Drawing.Size(75, 23);
            this.BtFirma.TabIndex = 11;
            this.BtFirma.Text = "Firma";
            this.BtFirma.UseVisualStyleBackColor = true;
            this.BtFirma.Click += new System.EventHandler(this.BtFirma_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(664, 27);
            this.label3.TabIndex = 12;
            this.label3.Text = "Practica: Implementación de arreglos con DataGrid en WF";
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
            ((System.ComponentModel.ISupportInitialize)(this.DGMat)).EndInit();
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

        private System.Windows.Forms.DataGridView DGMat;
        private System.Windows.Forms.TextBox Tbm;
        private System.Windows.Forms.TextBox Tbn;
        private System.Windows.Forms.Button BtLeer;
        private System.Windows.Forms.Button BtPoner;
        private System.Windows.Forms.Button BtTamaño;
        private System.Windows.Forms.ListBox LbMat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Tbindi;
        private System.Windows.Forms.Button BtFirma;
        private System.Windows.Forms.Label label3;
    }
}

