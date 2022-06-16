namespace ExamenCalcuNL15
{
    partial class GraficaEstablecida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtCos = new System.Windows.Forms.Button();
            this.BtSen = new System.Windows.Forms.Button();
            this.BtAcos = new System.Windows.Forms.Button();
            this.BtTan = new System.Windows.Forms.Button();
            this.BtSenh = new System.Windows.Forms.Button();
            this.BtCosh = new System.Windows.Forms.Button();
            this.BtAtan = new System.Windows.Forms.Button();
            this.BtAsen = new System.Windows.Forms.Button();
            this.BtExp = new System.Windows.Forms.Button();
            this.BtTanh = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(204, 71);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(803, 449);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            // 
            // BtCos
            // 
            this.BtCos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCos.Location = new System.Drawing.Point(13, 55);
            this.BtCos.Name = "BtCos";
            this.BtCos.Size = new System.Drawing.Size(135, 38);
            this.BtCos.TabIndex = 18;
            this.BtCos.Text = "y=cos(x)";
            this.BtCos.UseVisualStyleBackColor = true;
            this.BtCos.Click += new System.EventHandler(this.BtCos_Click);
            // 
            // BtSen
            // 
            this.BtSen.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSen.Location = new System.Drawing.Point(13, 99);
            this.BtSen.Name = "BtSen";
            this.BtSen.Size = new System.Drawing.Size(135, 38);
            this.BtSen.TabIndex = 19;
            this.BtSen.Text = "y=sen(x)";
            this.BtSen.UseVisualStyleBackColor = true;
            this.BtSen.Click += new System.EventHandler(this.BtSen_Click);
            // 
            // BtAcos
            // 
            this.BtAcos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAcos.Location = new System.Drawing.Point(13, 187);
            this.BtAcos.Name = "BtAcos";
            this.BtAcos.Size = new System.Drawing.Size(135, 38);
            this.BtAcos.TabIndex = 21;
            this.BtAcos.Text = "y=acos(x)";
            this.BtAcos.UseVisualStyleBackColor = true;
            this.BtAcos.Click += new System.EventHandler(this.BtAcos_Click);
            // 
            // BtTan
            // 
            this.BtTan.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtTan.Location = new System.Drawing.Point(13, 143);
            this.BtTan.Name = "BtTan";
            this.BtTan.Size = new System.Drawing.Size(135, 38);
            this.BtTan.TabIndex = 20;
            this.BtTan.Text = "y=tan(x)";
            this.BtTan.UseVisualStyleBackColor = true;
            this.BtTan.Click += new System.EventHandler(this.BtTan_Click);
            // 
            // BtSenh
            // 
            this.BtSenh.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSenh.Location = new System.Drawing.Point(13, 362);
            this.BtSenh.Name = "BtSenh";
            this.BtSenh.Size = new System.Drawing.Size(135, 38);
            this.BtSenh.TabIndex = 25;
            this.BtSenh.Text = "y=senh(x)";
            this.BtSenh.UseVisualStyleBackColor = true;
            this.BtSenh.Click += new System.EventHandler(this.BtSenh_Click);
            // 
            // BtCosh
            // 
            this.BtCosh.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCosh.Location = new System.Drawing.Point(13, 318);
            this.BtCosh.Name = "BtCosh";
            this.BtCosh.Size = new System.Drawing.Size(135, 38);
            this.BtCosh.TabIndex = 24;
            this.BtCosh.Text = "y=cosh(x)";
            this.BtCosh.UseVisualStyleBackColor = true;
            this.BtCosh.Click += new System.EventHandler(this.BtCosh_Click);
            // 
            // BtAtan
            // 
            this.BtAtan.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAtan.Location = new System.Drawing.Point(13, 274);
            this.BtAtan.Name = "BtAtan";
            this.BtAtan.Size = new System.Drawing.Size(135, 38);
            this.BtAtan.TabIndex = 23;
            this.BtAtan.Text = "y=atan(x)";
            this.BtAtan.UseVisualStyleBackColor = true;
            this.BtAtan.Click += new System.EventHandler(this.BtAtan_Click);
            // 
            // BtAsen
            // 
            this.BtAsen.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAsen.Location = new System.Drawing.Point(13, 230);
            this.BtAsen.Name = "BtAsen";
            this.BtAsen.Size = new System.Drawing.Size(135, 38);
            this.BtAsen.TabIndex = 22;
            this.BtAsen.Text = "y=asen(x)";
            this.BtAsen.UseVisualStyleBackColor = true;
            this.BtAsen.Click += new System.EventHandler(this.BtAsen_Click);
            // 
            // BtExp
            // 
            this.BtExp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtExp.Location = new System.Drawing.Point(12, 450);
            this.BtExp.Name = "BtExp";
            this.BtExp.Size = new System.Drawing.Size(135, 38);
            this.BtExp.TabIndex = 29;
            this.BtExp.Text = "y=exp(x)";
            this.BtExp.UseVisualStyleBackColor = true;
            this.BtExp.Click += new System.EventHandler(this.BtExp_Click);
            // 
            // BtTanh
            // 
            this.BtTanh.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtTanh.Location = new System.Drawing.Point(12, 406);
            this.BtTanh.Name = "BtTanh";
            this.BtTanh.Size = new System.Drawing.Size(135, 38);
            this.BtTanh.TabIndex = 32;
            this.BtTanh.Text = "y=tanh(x)";
            this.BtTanh.UseVisualStyleBackColor = true;
            this.BtTanh.Click += new System.EventHandler(this.BtTanh_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(392, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(24, 27);
            this.Titulo.TabIndex = 33;
            this.Titulo.Text = "  ";
            // 
            // GraficaEstablecida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 532);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.BtTanh);
            this.Controls.Add(this.BtExp);
            this.Controls.Add(this.BtSenh);
            this.Controls.Add(this.BtCosh);
            this.Controls.Add(this.BtAtan);
            this.Controls.Add(this.BtAsen);
            this.Controls.Add(this.BtAcos);
            this.Controls.Add(this.BtTan);
            this.Controls.Add(this.BtSen);
            this.Controls.Add(this.BtCos);
            this.Controls.Add(this.chart1);
            this.Name = "GraficaEstablecida";
            this.Text = "Grafica Establecida";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button BtCos;
        private System.Windows.Forms.Button BtSen;
        private System.Windows.Forms.Button BtAcos;
        private System.Windows.Forms.Button BtTan;
        private System.Windows.Forms.Button BtSenh;
        private System.Windows.Forms.Button BtCosh;
        private System.Windows.Forms.Button BtAtan;
        private System.Windows.Forms.Button BtAsen;
        private System.Windows.Forms.Button BtExp;
        private System.Windows.Forms.Button BtTanh;
        private System.Windows.Forms.Label Titulo;
    }
}