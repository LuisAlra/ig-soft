namespace WPFSenales01
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tBr1 = new System.Windows.Forms.TrackBar();
            this.tBr2 = new System.Windows.Forms.TrackBar();
            this.tBr3 = new System.Windows.Forms.TrackBar();
            this.cBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBr1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBr3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.LightGray;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(349, 50);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(356, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tBr1
            // 
            this.tBr1.Location = new System.Drawing.Point(32, 68);
            this.tBr1.Name = "tBr1";
            this.tBr1.Size = new System.Drawing.Size(174, 45);
            this.tBr1.TabIndex = 1;
            // 
            // tBr2
            // 
            this.tBr2.Location = new System.Drawing.Point(32, 128);
            this.tBr2.Name = "tBr2";
            this.tBr2.Size = new System.Drawing.Size(174, 45);
            this.tBr2.TabIndex = 2;
            // 
            // tBr3
            // 
            this.tBr3.Location = new System.Drawing.Point(32, 179);
            this.tBr3.Name = "tBr3";
            this.tBr3.Size = new System.Drawing.Size(174, 45);
            this.tBr3.TabIndex = 3;
            // 
            // cBox1
            // 
            this.cBox1.FormattingEnabled = true;
            this.cBox1.Items.AddRange(new object[] {
            "cos",
            "sen",
            "tan"});
            this.cBox1.Location = new System.Drawing.Point(42, 250);
            this.cBox1.Name = "cBox1";
            this.cBox1.Size = new System.Drawing.Size(149, 21);
            this.cBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cBox1);
            this.Controls.Add(this.tBr3);
            this.Controls.Add(this.tBr2);
            this.Controls.Add(this.tBr1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBr1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBr3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TrackBar tBr1;
        private System.Windows.Forms.TrackBar tBr2;
        private System.Windows.Forms.TrackBar tBr3;
        private System.Windows.Forms.ComboBox cBox1;
    }
}