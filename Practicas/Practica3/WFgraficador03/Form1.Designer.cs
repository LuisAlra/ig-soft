namespace WFgraficador03
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tbf1x = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tbxi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TBfx = new System.Windows.Forms.TextBox();
            this.Tbxf = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btf1x = new System.Windows.Forms.Button();
            this.BtGraficarfx = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LbSalida = new System.Windows.Forms.ListBox();
            this.BtFirma = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1194, 28);
            this.menuStrip1.TabIndex = 0;
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
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Tbf1x);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Tbxi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TBfx);
            this.groupBox1.Controls.Add(this.Tbxf);
            this.groupBox1.Location = new System.Drawing.Point(13, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 174);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "f1(x)";
            // 
            // Tbf1x
            // 
            this.Tbf1x.Location = new System.Drawing.Point(55, 135);
            this.Tbf1x.Name = "Tbf1x";
            this.Tbf1x.Size = new System.Drawing.Size(108, 22);
            this.Tbf1x.TabIndex = 20;
            this.Tbf1x.Text = "x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "f(x)";
            // 
            // Tbxi
            // 
            this.Tbxi.Location = new System.Drawing.Point(56, 21);
            this.Tbxi.Name = "Tbxi";
            this.Tbxi.Size = new System.Drawing.Size(108, 22);
            this.Tbxi.TabIndex = 13;
            this.Tbxi.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "xf";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "xi";
            // 
            // TBfx
            // 
            this.TBfx.Location = new System.Drawing.Point(56, 97);
            this.TBfx.Name = "TBfx";
            this.TBfx.Size = new System.Drawing.Size(108, 22);
            this.TBfx.TabIndex = 18;
            this.TBfx.Text = "x";
            // 
            // Tbxf
            // 
            this.Tbxf.Location = new System.Drawing.Point(56, 59);
            this.Tbxf.Name = "Tbxf";
            this.Tbxf.Size = new System.Drawing.Size(108, 22);
            this.Tbxf.TabIndex = 16;
            this.Tbxf.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btf1x);
            this.groupBox2.Controls.Add(this.BtGraficarfx);
            this.groupBox2.Location = new System.Drawing.Point(200, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 129);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Proceso";
            // 
            // Btf1x
            // 
            this.Btf1x.Location = new System.Drawing.Point(8, 80);
            this.Btf1x.Name = "Btf1x";
            this.Btf1x.Size = new System.Drawing.Size(156, 33);
            this.Btf1x.TabIndex = 4;
            this.Btf1x.Text = "Graficar y1, y2...";
            this.Btf1x.UseVisualStyleBackColor = true;
            this.Btf1x.Click += new System.EventHandler(this.Btf1x_Click);
            // 
            // BtGraficarfx
            // 
            this.BtGraficarfx.Location = new System.Drawing.Point(24, 29);
            this.BtGraficarfx.Name = "BtGraficarfx";
            this.BtGraficarfx.Size = new System.Drawing.Size(115, 33);
            this.BtGraficarfx.TabIndex = 3;
            this.BtGraficarfx.Text = "Graficar y=f(x)";
            this.BtGraficarfx.UseVisualStyleBackColor = true;
            this.BtGraficarfx.Click += new System.EventHandler(this.BtGraficarfx_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chart1);
            this.groupBox3.Controls.Add(this.LbSalida);
            this.groupBox3.Location = new System.Drawing.Point(390, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(774, 381);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Salida";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(299, 23);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(451, 324);
            this.chart1.TabIndex = 18;
            this.chart1.Text = "chart1";
            // 
            // LbSalida
            // 
            this.LbSalida.FormattingEnabled = true;
            this.LbSalida.HorizontalScrollbar = true;
            this.LbSalida.ItemHeight = 16;
            this.LbSalida.Items.AddRange(new object[] {
            " "});
            this.LbSalida.Location = new System.Drawing.Point(16, 23);
            this.LbSalida.Name = "LbSalida";
            this.LbSalida.Size = new System.Drawing.Size(260, 324);
            this.LbSalida.TabIndex = 17;
            // 
            // BtFirma
            // 
            this.BtFirma.Location = new System.Drawing.Point(1089, 529);
            this.BtFirma.Name = "BtFirma";
            this.BtFirma.Size = new System.Drawing.Size(75, 23);
            this.BtFirma.TabIndex = 3;
            this.BtFirma.Text = "Firma";
            this.BtFirma.UseVisualStyleBackColor = true;
            this.BtFirma.Click += new System.EventHandler(this.BtFirma_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(657, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Practica: Agregando multifunciones a la practica anterior";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 568);
            this.Controls.Add(this.label2);
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
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tbf1x;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tbxi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBfx;
        private System.Windows.Forms.TextBox Tbxf;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ListBox LbSalida;
        private System.Windows.Forms.Button Btf1x;
        private System.Windows.Forms.Button BtGraficarfx;
        private System.Windows.Forms.Button BtFirma;
        private System.Windows.Forms.Label label2;
    }
}

