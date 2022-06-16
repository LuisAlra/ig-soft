namespace WPF_tiempo_alarma_WF
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rBalarma = new System.Windows.Forms.RadioButton();
            this.tBxalarma = new System.Windows.Forms.TextBox();
            this.rBuDesact = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "  ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 15);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // rBalarma
            // 
            this.rBalarma.AutoSize = true;
            this.rBalarma.Location = new System.Drawing.Point(81, 169);
            this.rBalarma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBalarma.Name = "rBalarma";
            this.rBalarma.Size = new System.Drawing.Size(114, 20);
            this.rBalarma.TabIndex = 2;
            this.rBalarma.TabStop = true;
            this.rBalarma.Text = "Activar alarma";
            this.rBalarma.UseVisualStyleBackColor = true;
            // 
            // tBxalarma
            // 
            this.tBxalarma.Location = new System.Drawing.Point(261, 169);
            this.tBxalarma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBxalarma.Name = "tBxalarma";
            this.tBxalarma.Size = new System.Drawing.Size(437, 22);
            this.tBxalarma.TabIndex = 3;
            this.tBxalarma.Text = "06:15:00:0-martes,12,abril,2022";
            // 
            // rBuDesact
            // 
            this.rBuDesact.AutoSize = true;
            this.rBuDesact.Location = new System.Drawing.Point(81, 241);
            this.rBuDesact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBuDesact.Name = "rBuDesact";
            this.rBuDesact.Size = new System.Drawing.Size(138, 20);
            this.rBuDesact.TabIndex = 4;
            this.rBuDesact.TabStop = true;
            this.rBuDesact.Text = "Desactivar alarma";
            this.rBuDesact.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.rBuDesact);
            this.Controls.Add(this.tBxalarma);
            this.Controls.Add(this.rBalarma);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rBalarma;
        private System.Windows.Forms.TextBox tBxalarma;
        private System.Windows.Forms.RadioButton rBuDesact;
    }
}