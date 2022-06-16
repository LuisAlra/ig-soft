using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFProyectoGenControl
{
    public partial class Form1 : Form
    {
        GroupBox groupBox1, groupBox2, groupBox3;
        TextBox textBox1;
        Button button1, button2;
        ListBox listBox1;
        Label label1;
        MenuStrip menuStrip1;
        ToolStripMenuItem Archivo, Documento, Ayuda, Firma, Salir;

        public Form1()
        {
            InitializeComponent();
            GenerarControles();
        }

        public void GenerarControles()
        {
            this.Text = "Proyecto";

            //Label
            label1 = new Label();
            label1.Location = new Point(70, 50);
            label1.AutoSize = true;
            label1.Text = "Proyecto: IGU de la plantilla Entrada -> Proceso -> Salida por código c#";
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F);
            this.Controls.Add(label1);

            //GroupBox Entrada
            groupBox1 = new GroupBox();
            groupBox1.Location = new Point(20, 125);
            groupBox1.Width = 240;
            groupBox1.Height = 180; 
            groupBox1.Text = "Entrada";
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F);
            this.Controls.Add(groupBox1);

            //GroupBox Proceso
            groupBox2 = new GroupBox();
            groupBox2.Location = new Point(275, 125);
            groupBox2.Width = 240;
            groupBox2.Height = 180;
            groupBox2.Text = "Proceso";
            groupBox2.Font = new Font("Microsoft Sans Serif", 12F);
            this.Controls.Add(groupBox2);

            //GroupBox Salida
            groupBox3 = new GroupBox();
            groupBox3.Location = new Point(530, 125);
            groupBox3.Width = 240;
            groupBox3.Height = 180;
            groupBox3.Text = "Salida";
            groupBox3.Font = new Font("Microsoft Sans Serif", 12F);
            this.Controls.Add(groupBox3);

            //TextBox
            textBox1 = new TextBox();
            textBox1.Location = new Point(65,75);
            textBox1.Size = new Size(110, 30);
            textBox1.Text = "0";
            this.groupBox1.Controls.Add(textBox1);

            //Button
            button1 = new Button();
            button1.Location = new Point(85, 75);
            button1.AutoSize = true;
            button1.Text = "Proceso";
            button1.Font = new Font("Verdana", 9F);
            button1.Click += Button1_Click;
            this.groupBox2.Controls.Add(button1);

            button2 = new Button();
            button2.Location = new Point(710, 410);
            button2.Size = new Size(65, 25);
            button2.Text = "Firma";
            button2.Click += Button2_Click;
            this.Controls.Add(button2);

            //ListBox
            listBox1 = new ListBox();
            listBox1.Location = new Point(30,30);
            listBox1.Width = 180;
            listBox1.Height = 140;
            this.groupBox3.Controls.Add(listBox1);

            //Todo el contenido del MenuStrip
            Archivo = new ToolStripMenuItem();
            Archivo.Text = "&Archivo";
            Documento = new ToolStripMenuItem();
            Documento.Text = "&Documento";
            Ayuda = new ToolStripMenuItem();
            Ayuda.Text = "Ayuda";

            Firma = new ToolStripMenuItem();
            Firma.Text = "&Firma";
            Firma.Click += Firma_Click; ;

            Salir = new ToolStripMenuItem();
            Salir.Text = "&Salir";
            Salir.Click += Salir_Click; ;

            Archivo.DropDownItems.AddRange(new ToolStripDropDownItem[] { Firma, Salir });

            menuStrip1 = new MenuStrip();
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Size = new Size(200, 30);
            menuStrip1.BackColor = Color.AliceBlue;
            menuStrip1.Items.AddRange(new ToolStripItem[] { Archivo, Documento, Ayuda });
            this.Controls.Add(menuStrip1);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WPFmanuels.exe");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ejecuta el proceso...");
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Firma_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WPFmanuels.exe");
        }
    }
}
