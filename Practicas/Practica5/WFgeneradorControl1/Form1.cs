using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFgeneradorControl1
{
    public partial class Form1 : Form
    {
        Label label1, label2;
        Button boton1, boton2;
        MenuStrip menuStrip1;
        ToolStripMenuItem Archivo, Editar, Ver, Firma, Salir;
        public Form1()
        {
            InitializeComponent();
            GenerarControles();
        }

        public void GenerarControles()
        {
            this.Text = "Practica";

            //Label
            label1 = new Label();
            label1.Location = new Point(20, 70);
            label1.Width = 60;
            label1.Height = 30;
            label1.Text = "ESIME";
            this.Controls.Add(label1);

            //Boton
            boton1 = new Button();
            boton1.Location = new Point(100, 70);
            boton1.Size = new Size(80, 30);
            boton1.Text = "ICE";
            boton1.Click += Boton1_Click;
            this.Controls.Add(boton1);

            //Contenido del menustrip
            Archivo = new ToolStripMenuItem();
            Archivo.Text = "&Archivo";
            Editar = new ToolStripMenuItem();
            Editar.Text = "&Editar";
            Ver = new ToolStripMenuItem();
            Ver.Text = "&Ver";

            Firma = new ToolStripMenuItem();
            Firma.Text = "&Firma";
            Firma.Click += Firma_Click;

            Salir = new ToolStripMenuItem();
            Salir.Text = "&Salir";
            Salir.Click += Salir_Click;

            Archivo.DropDownItems.AddRange(new ToolStripDropDownItem[] { Firma, Salir });

            menuStrip1=new MenuStrip();
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Size = new Size(200, 30);
            menuStrip1.BackColor = Color.AliceBlue;
            menuStrip1.Items.AddRange(new ToolStripItem[] {Archivo, Editar, Ver });
            this.Controls.Add(menuStrip1);

            //Label indicadora de la practica
            label2 = new Label();
            label2.Location = new Point(180, 30);
            label2.AutoSize = true;
            label2.Text = "Practica: Generando los primeros controles";
            label2.Font = new Font("Arial Rounded MT Bold", 13.8F);
            this.Controls.Add(label2);

            //Boton para firma
            boton2 = new Button();
            boton2.Location = new Point(710, 410);
            boton2.Size = new Size(75, 25);
            boton2.Text = "Firma";
            boton2.Click += Boton2_Click;
            this.Controls.Add(boton2);
        }

        private void Boton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WPFmanuels.exe");
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Firma_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WPFmanuels.exe");
        }

        private void Boton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("IPN-ESIME");
        }
    }
}
