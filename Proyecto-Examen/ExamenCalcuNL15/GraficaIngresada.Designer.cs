namespace ExamenCalcuNL15
{
    partial class GraficaIngresada
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BtGraficarfx = new System.Windows.Forms.Button();
            this.Btf1x = new System.Windows.Forms.Button();
            this.Tbxf = new System.Windows.Forms.TextBox();
            this.TBfx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Tbxi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tbf1x = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtGraficarfx
            // 
            this.BtGraficarfx.Location = new System.Drawing.Point(229, 143);
            this.BtGraficarfx.Name = "BtGraficarfx";
            this.BtGraficarfx.Size = new System.Drawing.Size(115, 33);
            this.BtGraficarfx.TabIndex = 3;
            this.BtGraficarfx.Text = "Graficar y=f(x)";
            this.BtGraficarfx.UseVisualStyleBackColor = true;
            this.BtGraficarfx.Click += new System.EventHandler(this.BtGraficarfx_Click);
            // 
            // Btf1x
            // 
            this.Btf1x.Location = new System.Drawing.Point(202, 212);
            this.Btf1x.Name = "Btf1x";
            this.Btf1x.Size = new System.Drawing.Size(159, 33);
            this.Btf1x.TabIndex = 4;
            this.Btf1x.Text = "Graficar y1, y2...";
            this.Btf1x.UseVisualStyleBackColor = true;
            this.Btf1x.Click += new System.EventHandler(this.Btf1x_Click);
            // 
            // Tbxf
            // 
            this.Tbxf.Location = new System.Drawing.Point(61, 179);
            this.Tbxf.Name = "Tbxf";
            this.Tbxf.Size = new System.Drawing.Size(108, 22);
            this.Tbxf.TabIndex = 16;
            this.Tbxf.Text = "0";
            // 
            // TBfx
            // 
            this.TBfx.Location = new System.Drawing.Point(61, 217);
            this.TBfx.Name = "TBfx";
            this.TBfx.Size = new System.Drawing.Size(108, 22);
            this.TBfx.TabIndex = 18;
            this.TBfx.Text = "x";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "xi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "xf";
            // 
            // Tbxi
            // 
            this.Tbxi.Location = new System.Drawing.Point(61, 141);
            this.Tbxi.Name = "Tbxi";
            this.Tbxi.Size = new System.Drawing.Size(108, 22);
            this.Tbxi.TabIndex = 13;
            this.Tbxi.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "f(x)";
            // 
            // Tbf1x
            // 
            this.Tbf1x.Location = new System.Drawing.Point(60, 255);
            this.Tbf1x.Name = "Tbf1x";
            this.Tbf1x.Size = new System.Drawing.Size(108, 22);
            this.Tbf1x.TabIndex = 20;
            this.Tbf1x.Text = "x";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "f1(x)";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(376, 55);
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
            this.chart1.Size = new System.Drawing.Size(803, 449);
            this.chart1.TabIndex = 21;
            this.chart1.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(390, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 32);
            this.label2.TabIndex = 22;
            this.label2.Text = "Gráficas multifunciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Ingrese datos";
            // 
            // GraficaIngresada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 516);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btf1x);
            this.Controls.Add(this.Tbf1x);
            this.Controls.Add(this.BtGraficarfx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tbxi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Tbxf);
            this.Controls.Add(this.TBfx);
            this.Name = "GraficaIngresada";
            this.Text = "Grafica Ingresada";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtGraficarfx;
        private System.Windows.Forms.Button Btf1x;
        private System.Windows.Forms.TextBox Tbxf;
        private System.Windows.Forms.TextBox TBfx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tbxi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tbf1x;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}