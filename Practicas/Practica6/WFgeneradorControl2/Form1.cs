using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFgeneradorControl2
{
    public partial class Form1 : Form
    {
        Label label1, label2, label3, label4, label5;
        Button boton1, boton2;
        GroupBox groupBox1;
        ListBox listBox1;
        MenuStrip menuStrip1;
        ToolStripMenuItem Archivo, Editar, Ver, Firma, Salir;
        RadioButton radioButton1;
        RichTextBox richTextBox1;
        TabControl tabControl1;
        TabPage tabPage1, tabPage2;
        TextBox textBox1;
        DateTimePicker dataTimePicker1;
        MonthCalendar monthCalendar1;
        ComboBox comboBox1;
        CheckBox checkBox1;
        NumericUpDown numericUpDown1;
        CheckedListBox checkedListBox1;
        TrackBar trackBar1;
        Panel panel1;
        ProgressBar progressBar1;
        LinkLabel linkLabel1;

        public Form1()
        {
            InitializeComponent();
            GenerarControles();
        }

        public void GenerarControles()
        {
            this.Text = "Practica";
            this.Width = 818;
            this.Height = 497;

            //Control 1 - Label
            label1 = new Label();
            label1.Location = new Point(20, 70);
            label1.Width = 60;
            label1.Height = 30;
            label1.Text = "ESIME";
            this.Controls.Add(label1);

            //Control 2 - Boton
            boton1 = new Button();
            boton1.Location = new Point(80, 70);
            boton1.Size = new Size(80, 30);
            boton1.Text = "SOFTWARE";
            //boton1.Click += Boton1_Click;
            this.Controls.Add(boton1);

            //Control 3 - GroupBox
            groupBox1 = new GroupBox();
            groupBox1.Location = new Point(190, 70);
            groupBox1.Width = 90;
            groupBox1.Height = 50;
            groupBox1.Text = "GroupBox";
            this.Controls.Add(groupBox1);

            //Control 4 - ListBox
            listBox1 = new ListBox();
            listBox1.Location = new Point(300,75);
            listBox1.Width = 60;
            listBox1.Height = 55;
            listBox1.Items.AddRange(new object[] { "ListBox" });
            this.Controls.Add(listBox1);

            //Control 5 - Menustrip
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

            menuStrip1 = new MenuStrip();
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Size = new Size(200, 30);
            menuStrip1.BackColor = Color.AliceBlue;
            menuStrip1.Items.AddRange(new ToolStripItem[] { Archivo, Editar, Ver });
            this.Controls.Add(menuStrip1);

            //Control 6 - RadioButton
            radioButton1 = new RadioButton();
            radioButton1.Location = new Point(380, 70);
            radioButton1.Size = new Size(90, 25);
            radioButton1.Text = "RadioButton";
            this.Controls.Add(radioButton1);

            //Control 7 - RichTextBox
            richTextBox1 = new RichTextBox();
            richTextBox1.Location = new Point(480,70);
            richTextBox1.Size = new Size(80,55);
            richTextBox1.Text = "RichTextBox";
            this.Controls.Add(richTextBox1);

            //Control 8 - TabControl
            tabControl1 = new TabControl();
            tabControl1.Location = new Point(600,70);
            tabControl1.Size = new Size(150, 70);
            this.Controls.Add(tabControl1);

            tabPage1 = new TabPage();
            tabPage1.Location = new Point(0,0);
            tabPage1.Size = new Size(50, 50);
            tabPage1.Text = "Control 1";
            this.tabControl1.Controls.Add(tabPage1);

            tabPage2 = new TabPage();
            tabPage2.Location = new Point(0, 0);
            tabPage2.Size = new Size(50, 50);
            tabPage2.Text = "Control 2";
            this.tabControl1.Controls.Add(tabPage2);

            //Control 9 - TextBox
            textBox1 = new TextBox();
            textBox1.Text = "TextBox";
            textBox1.Location = new Point(20,180);
            textBox1.Size = new Size(50, 25);
            this.Controls.Add(textBox1);

            //control 10 - DataTimePicker
            dataTimePicker1 = new DateTimePicker();
            dataTimePicker1.Location = new Point(80, 180);
            dataTimePicker1.Size = new Size(210, 25);
            this.Controls.Add(dataTimePicker1);

            //Control 11 - MonthCalendar
            monthCalendar1 = new MonthCalendar();
            monthCalendar1.Location = new Point(300,150);
            monthCalendar1.Size = new Size(290,200);
            this.Controls.Add(monthCalendar1);  

            //Control 12 - comboBox
            comboBox1 = new ComboBox();
            comboBox1.Location = new Point(580,150);
            comboBox1.Size = new Size(100,25);
            comboBox1.Items.AddRange(new object[] { "Opción 1", "Opción 2", "Opción 3", "Opcion 4" });
            comboBox1.Text = "Opción 1";
            this.Controls.Add(comboBox1);

            //Control 13 - CheckBox;
            checkBox1 = new CheckBox();
            checkBox1.Location = new Point(690, 150);
            checkBox1.Size = new Size(85, 25);
            checkBox1.Text = "Seleccionar";
            this.Controls.Add(checkBox1);

            //Control 14 - NumericUpDown
            numericUpDown1 = new NumericUpDown();
            numericUpDown1.Location = new Point(10, 250);
            numericUpDown1.Size = new Size(90,25);
            numericUpDown1.Value = 15;
            this.Controls.Add(numericUpDown1);

            //Control 15 - CheckedListBox
            checkedListBox1 = new CheckedListBox();
            checkedListBox1.Location = new Point(110, 250);
            checkedListBox1.Size = new Size(160, 110);
            checkedListBox1.Items.AddRange(new object[] { "Opción 1", "Opción 2", "Opción 3", "Opcion 4" });
            this.Controls.Add(checkedListBox1);

            //Control 16 -  TrackBar
            trackBar1 = new TrackBar();
            trackBar1.Location = new Point(290, 330);
            trackBar1.Size = new Size(104,56);
            this.Controls.Add(trackBar1);

            //Control 17 - Panel
            panel1 = new Panel();
            panel1.Location = new Point(400, 320);
            panel1.Size = new Size(50, 50);
            panel1.BackColor = Color.Aquamarine;
            this.Controls.Add(panel1);

            label3 = new Label();
            label3.Text = "Panel";
            label3.AutoSize = true;
            this.panel1.Controls.Add(label3);  
            
            //Control 18 - ProgressBar
            progressBar1 = new ProgressBar();
            progressBar1.Location = new Point(460, 340);
            progressBar1.Size = new Size(100, 35);
            this.Controls.Add(progressBar1);

            label4 = new Label();
            label4.Text = "ProgressBar:";
            label4.Location = new Point(460, 320);
            label4.AutoSize = true;
            this.Controls.Add(label4);

            //Control 19 - LinkLabel
            linkLabel1 = new LinkLabel();
            linkLabel1.Text = "LinkLabel";
            linkLabel1.AutoSize= true;
            linkLabel1.Location = new Point(570, 330);
            this.Controls.Add(linkLabel1);

            label5 = new Label();
            label5.Text = "Label";
            label5.BackColor = Color.Beige;    
            label5.Location = new Point(630, 330);
            label5.AutoSize = true;
            this.Controls.Add(label5);

            //Label indicadora de la practica
            label2 = new Label();
            label2.Location = new Point(180, 30);
            label2.AutoSize = true;
            label2.Text = "Practica: Generando 20 controles";
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

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Firma_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WPFmanuels.exe");
        }

        private void Boton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WPFmanuels.exe");
        }
    }
}
