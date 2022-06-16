namespace ExamenCalcuNL15
{
    partial class GraficaPolar
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtGraficarr = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Tbxi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Tbxf = new System.Windows.Forms.TextBox();
            this.TBfx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(364, 38);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(803, 449);
            this.chart1.TabIndex = 31;
            this.chart1.Text = "chart1";
            // 
            // BtGraficarr
            // 
            this.BtGraficarr.Location = new System.Drawing.Point(211, 148);
            this.BtGraficarr.Name = "BtGraficarr";
            this.BtGraficarr.Size = new System.Drawing.Size(115, 33);
            this.BtGraficarr.TabIndex = 22;
            this.BtGraficarr.Text = "Graficar r=g(x)";
            this.BtGraficarr.UseVisualStyleBackColor = true;
            this.BtGraficarr.Click += new System.EventHandler(this.BtGraficarr_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "g(x)";
            // 
            // Tbxi
            // 
            this.Tbxi.Location = new System.Drawing.Point(57, 108);
            this.Tbxi.Name = "Tbxi";
            this.Tbxi.Size = new System.Drawing.Size(108, 22);
            this.Tbxi.TabIndex = 23;
            this.Tbxi.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "xf";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "xi";
            // 
            // Tbxf
            // 
            this.Tbxf.Location = new System.Drawing.Point(57, 146);
            this.Tbxf.Name = "Tbxf";
            this.Tbxf.Size = new System.Drawing.Size(108, 22);
            this.Tbxf.TabIndex = 26;
            this.Tbxf.Text = "0";
            // 
            // TBfx
            // 
            this.TBfx.Location = new System.Drawing.Point(57, 184);
            this.TBfx.Name = "TBfx";
            this.TBfx.Size = new System.Drawing.Size(108, 22);
            this.TBfx.TabIndex = 28;
            this.TBfx.Text = "x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "Ingrese datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(453, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 32);
            this.label2.TabIndex = 32;
            this.label2.Text = "Gráficas polares";
            // 
            // GraficaPolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 500);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.BtGraficarr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tbxi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Tbxf);
            this.Controls.Add(this.TBfx);
            this.Name = "GraficaPolar";
            this.Text = "Grafica Polar";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button BtGraficarr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tbxi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Tbxf;
        private System.Windows.Forms.TextBox TBfx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}