namespace ExamenCalcuNL15
{
    partial class GraficaParametrica
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
            this.BtGraParame = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbf1x = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbfx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(460, 52);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(803, 449);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart4";
            // 
            // BtGraParame
            // 
            this.BtGraParame.Location = new System.Drawing.Point(293, 176);
            this.BtGraParame.Margin = new System.Windows.Forms.Padding(4);
            this.BtGraParame.Name = "BtGraParame";
            this.BtGraParame.Size = new System.Drawing.Size(140, 55);
            this.BtGraParame.TabIndex = 3;
            this.BtGraParame.Text = "Graficar x=f(t),y=g(t)\r\n";
            this.BtGraParame.UseVisualStyleBackColor = true;
            this.BtGraParame.Click += new System.EventHandler(this.BtGraParame_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 290);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "g(t)";
            // 
            // tbf1x
            // 
            this.tbf1x.Location = new System.Drawing.Point(73, 290);
            this.tbf1x.Margin = new System.Windows.Forms.Padding(4);
            this.tbf1x.Name = "tbf1x";
            this.tbf1x.Size = new System.Drawing.Size(197, 22);
            this.tbf1x.TabIndex = 14;
            this.tbf1x.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "f(t)";
            // 
            // tbfx
            // 
            this.tbfx.Location = new System.Drawing.Point(73, 236);
            this.tbfx.Margin = new System.Windows.Forms.Padding(4);
            this.tbfx.Name = "tbfx";
            this.tbfx.Size = new System.Drawing.Size(197, 22);
            this.tbfx.TabIndex = 12;
            this.tbfx.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "xf";
            // 
            // tbxf
            // 
            this.tbxf.Location = new System.Drawing.Point(73, 143);
            this.tbxf.Margin = new System.Windows.Forms.Padding(4);
            this.tbxf.Name = "tbxf";
            this.tbxf.Size = new System.Drawing.Size(197, 22);
            this.tbxf.TabIndex = 10;
            this.tbxf.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "xi";
            // 
            // tbxi
            // 
            this.tbxi.Location = new System.Drawing.Point(73, 97);
            this.tbxi.Margin = new System.Windows.Forms.Padding(4);
            this.tbxi.Name = "tbxi";
            this.tbxi.Size = new System.Drawing.Size(197, 22);
            this.tbxi.TabIndex = 8;
            this.tbxi.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "Ingrese datos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(477, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(323, 32);
            this.label6.TabIndex = 24;
            this.label6.Text = "Gráficas paramétricas";
            // 
            // GraficaParametrica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 527);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbf1x);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbfx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxi);
            this.Controls.Add(this.BtGraParame);
            this.Controls.Add(this.chart1);
            this.Name = "GraficaParametrica";
            this.Text = "Gráfica Paramétrica";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button BtGraParame;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbf1x;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbfx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}