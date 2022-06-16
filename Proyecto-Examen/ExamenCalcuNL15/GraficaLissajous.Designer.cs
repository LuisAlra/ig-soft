namespace ExamenCalcuNL15
{
    partial class GraficaLissajous
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
            this.BtLissajous = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tBxdesfase = new System.Windows.Forms.TextBox();
            this.tBxPropor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxi = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TbxPropor2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtLissajous
            // 
            this.BtLissajous.Location = new System.Drawing.Point(329, 125);
            this.BtLissajous.Margin = new System.Windows.Forms.Padding(4);
            this.BtLissajous.Name = "BtLissajous";
            this.BtLissajous.Size = new System.Drawing.Size(140, 49);
            this.BtLissajous.TabIndex = 16;
            this.BtLissajous.Text = "Lissajous\r\n\r\n";
            this.BtLissajous.UseVisualStyleBackColor = true;
            this.BtLissajous.Click += new System.EventHandler(this.BtLissajous_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 227);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 48);
            this.label6.TabIndex = 21;
            this.label6.Text = "Delta o\r\n desfase\r\n (grados)\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 32);
            this.label5.TabIndex = 20;
            this.label5.Text = "Proporción\r\n ";
            // 
            // tBxdesfase
            // 
            this.tBxdesfase.Location = new System.Drawing.Point(101, 223);
            this.tBxdesfase.Margin = new System.Windows.Forms.Padding(4);
            this.tBxdesfase.Name = "tBxdesfase";
            this.tBxdesfase.Size = new System.Drawing.Size(173, 22);
            this.tBxdesfase.TabIndex = 19;
            this.tBxdesfase.Text = "0";
            // 
            // tBxPropor
            // 
            this.tBxPropor.Location = new System.Drawing.Point(174, 181);
            this.tBxPropor.Margin = new System.Windows.Forms.Padding(4);
            this.tBxPropor.Name = "tBxPropor";
            this.tBxPropor.Size = new System.Drawing.Size(41, 22);
            this.tBxPropor.TabIndex = 18;
            this.tBxPropor.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "xf";
            // 
            // tbxf
            // 
            this.tbxf.Location = new System.Drawing.Point(77, 138);
            this.tbxf.Margin = new System.Windows.Forms.Padding(4);
            this.tbxf.Name = "tbxf";
            this.tbxf.Size = new System.Drawing.Size(197, 22);
            this.tbxf.TabIndex = 14;
            this.tbxf.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "xi";
            // 
            // tbxi
            // 
            this.tbxi.Location = new System.Drawing.Point(77, 92);
            this.tbxi.Margin = new System.Windows.Forms.Padding(4);
            this.tbxi.Name = "tbxi";
            this.tbxi.Size = new System.Drawing.Size(197, 22);
            this.tbxi.TabIndex = 12;
            this.tbxi.Text = "0";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(503, 82);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(803, 449);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart5";
            // 
            // TbxPropor2
            // 
            this.TbxPropor2.Location = new System.Drawing.Point(101, 181);
            this.TbxPropor2.Margin = new System.Windows.Forms.Padding(4);
            this.TbxPropor2.Name = "TbxPropor2";
            this.TbxPropor2.Size = new System.Drawing.Size(42, 22);
            this.TbxPropor2.TabIndex = 22;
            this.TbxPropor2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 38);
            this.label3.TabIndex = 23;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Ingrese datos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(497, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(309, 32);
            this.label7.TabIndex = 24;
            this.label7.Text = "Gráficas de Lissajous";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExamenCalcuNL15.Properties.Resources.lissa;
            this.pictureBox1.Location = new System.Drawing.Point(28, 309);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(441, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // GraficaLissajous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 593);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbxPropor2);
            this.Controls.Add(this.BtLissajous);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBxdesfase);
            this.Controls.Add(this.tBxPropor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxi);
            this.Controls.Add(this.chart1);
            this.Name = "GraficaLissajous";
            this.Text = "GraficaLissajous";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtLissajous;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBxdesfase;
        private System.Windows.Forms.TextBox tBxPropor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxi;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox TbxPropor2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}