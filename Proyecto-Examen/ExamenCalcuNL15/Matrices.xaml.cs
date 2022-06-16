using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExamenCalcuNL15
{
    /// <summary>
    /// Lógica de interacción para Matrices.xaml
    /// </summary>
    public partial class Matrices : Page
    {
        int m, n, m2 ,n2;

        CalcuMatrices matA;
        CalcuMatrices matB;
        CalcuMatrices matC;
        CalcuMatrices matIn;
        CalcuMatrices mat2A;
        CalcuMatrices mat2B;
        CalcuMatrices mat2C;
        CalcuMatrices mat2In;
        CalcuMatrices matSuRe;
        CalcuMatrices matMul;

        TextBox[,] TbMat;
        TextBox[,] TbMat2;

        public Matrices()
        {
            InitializeComponent();
        }

        public void LeerMat()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matA.Elem[i, j] = double.Parse(TbMat[i, j].Text);
                }
            }
        }

        public void MostrarMat()
        {
            string aux;
            LbMat.Items.Add("Matriz A");
            for (int i = 0; i < m; i++)
            {
                aux = "";
                for (int j = 0; j < n; j++)
                {
                    aux += matA.Elem[i, j] + "\t";
                }
                aux += "\t";
                LbMat.Items.Add(aux);
            }

            TbIndi.Text = "Mostrando matriz";
        }

        private void BtTamaño_Click(object sender, RoutedEventArgs e)
        {
            m = int.Parse(Tbm.Text);
            n = int.Parse(Tbn.Text);
            int x = 0;
            int y = -20;
            matA = new CalcuMatrices(m, n);
            TbMat = new TextBox[m, n];
            StackPanel1.Children.Clear();
            TbIndi.Text = "Tamaño de la matriz " + m + "x" + n + " establecido";

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    TbMat[i, j] = new TextBox();
                    TbMat[i, j].Width = 30;
                    TbMat[i, j].Height = 20;
                    TbMat[i, j].HorizontalAlignment = HorizontalAlignment.Left;
                    TbMat[i, j].VerticalAlignment = VerticalAlignment.Top;
                    if (j == 0)
                    {
                        TbMat[i, j].Margin = new Thickness(30 * j, x, 0, 0);
                    }

                    else
                    {
                        TbMat[i, j].Margin = new Thickness(30 * j, y, 0, 0);
                    }

                    StackPanel1.Children.Add(TbMat[i, j]);
                }
            }
        }

        private void BtMostrar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LeerMat();
                MostrarMat();
            }

            catch
            {
                MessageBox.Show("Error de datos");
            }
        }

        private void BtTranspuesta_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LeerMat();

                matB = new CalcuMatrices(n, m);

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        matB.Elem[i, j] = matA.Elem[j, i];
                    }
                }

                string aux;
                LbMat.Items.Add("Transpuesta de la matriz A");
                for (int i = 0; i < n; i++)
                {
                    aux = "";
                    for (int j = 0; j < m; j++)
                    {
                        aux += matB.Elem[i, j] + "\t";
                    }
                    aux += "\t";
                    LbMat.Items.Add(aux);
                }

                TbIndi.Text = "Mostrando matriz transpuesta";
            }

            catch
            {
                MessageBox.Show("Error de datos");
            }
        }

        private void BtInversa_Click(object sender, RoutedEventArgs e)
        {
            if(m==n)
            {
                LeerMat();

                matIn = new CalcuMatrices(m, n);

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matIn.Elem[i, j] = 0;
                        if (i == j)
                        {
                            matIn.Elem[i, j] = 1;
                        }
                    }
                }

                double pivote;
                double aux;

                for (int i = 0; i < m; i++)
                {
                    pivote = matA.Elem[i, i];
                    for (int k = 0; k < n; k++)
                    {
                        matA.Elem[i, k] = matA.Elem[i, k] / pivote;
                        matIn.Elem[i, k] /= pivote;
                    }

                    for (int j = 0; j < n; j++)
                    {
                        if (i != j)
                        {
                            aux = matA.Elem[j, i];
                            for (int k = 0; k < n; k++)
                            {
                                matA.Elem[j, k] = matA.Elem[j, k] - aux * matA.Elem[i, k];
                                matIn.Elem[j, k] = matIn.Elem[j, k] - aux * matIn.Elem[i, k];
                            }
                        }
                    }
                }

                string aux2;
                LbMat.Items.Add("Inversa de la matriz A");
                for (int i = 0; i < n; i++)
                {
                    aux2 = "";
                    for (int j = 0; j < m; j++)
                    {
                        aux2 += matIn.Elem[i, j] + "\t";
                    }
                    aux2 += "\t";
                    LbMat.Items.Add(aux2);
                }

                TbIndi.Text = "Mostrando matriz inversa";

            }

            else
            {
                MessageBox.Show("La matriz no es cuadrada");
            }
        }

        private void BtDeterminante_Click(object sender, RoutedEventArgs e)
        {
            if(m == n)
            {
                LeerMat();

                double pivote, pivote1, aux;
                double det = 1;

                for (int i = 0; i < m; i++)
                {
                    pivote = matA.Elem[i, i];
                    for (int j = i + 1; j < n; j++)
                    {
                        pivote1 = matA.Elem[j, i];
                        aux = pivote1 / pivote;
                        for (int k = 0; k < m; k++)
                        {
                            matA.Elem[j, k] = matA.Elem[j, k] - aux * matA.Elem[i, k];
                        }
                    }
                }

                LbMat.Items.Add("Determinante de la matriz A");
                for (int i = 0; i < n; i++)
                {
                    det *= matA.Elem[i, i];
                }
                LbMat.Items.Add(det);

                TbIndi.Text = "Mostrando el determinante";
            }

            else
            {
                MessageBox.Show("La matriz no es cuadrada");
            }
        }

        private void BtMultiplicar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LeerMat();

                matB = new CalcuMatrices(m, n);

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matB.Elem[i, j] = double.Parse(TbMulti.Text) * matA.Elem[i, j];
                    }
                }

                string aux;
                LbMat.Items.Add("Matriz A multiplicada por " + TbMulti.Text);
                for (int i = 0; i < m; i++)
                {
                    aux = "";
                    for (int j = 0; j < n; j++)
                    {
                        aux += matB.Elem[i, j] + "\t";
                    }
                    aux += "\t";
                    LbMat.Items.Add(aux);
                }

                TbIndi.Text = "Mostrando matriz multiplicada por " + TbMulti.Text;
            }

            catch
            {
                MessageBox.Show("Error de datos");
            }
        }

        private void BtElevar_Click(object sender, RoutedEventArgs e)
        {
            if (m == n)
            {
                LeerMat();
                matB = new CalcuMatrices(m, n);
                matC = new CalcuMatrices(m, n);

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matB.Elem[i, j] = matA.Elem[i, j];
                    }
                }

                for (int a = 0; a < (int.Parse(TbElevar.Text)) - 1; a++)
                {
                    for (int i = 0; i < m; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            for (int k = 0; k < n; k++)
                            {
                                matC.Elem[i, j] += matB.Elem[i, k] * matA.Elem[k, j];
                            }
                        }
                    }

                    for (int i = 0; i < m; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            matB.Elem[i, j] = matC.Elem[i, j];
                            matC.Elem[i, j] = 0;
                        }
                    }
                }

                string aux;
                LbMat.Items.Add("Matriz A elevada a la " + TbElevar.Text);
                for (int i = 0; i < m; i++)
                {
                    aux = "";
                    for (int j = 0; j < n; j++)
                    {
                        aux += matB.Elem[i, j] + "\t";
                    }
                    aux += "\t";
                    LbMat.Items.Add(aux);
                }

                TbIndi.Text = "Mostrando matriz elevada a la " + TbElevar.Text;
            }

            else
            {
                MessageBox.Show("El número de columnas de la primera matriz debe coincidir con el número de filas de la segunda matriz");
            }
        }


        public void LeerMat2()
        {
            for (int i = 0; i < m2; i++)
            {
                for (int j = 0; j < n2; j++)
                {
                    mat2A.Elem[i, j] = double.Parse(TbMat2[i, j].Text);
                }
            }
        }

        public void MostrarMat2()
        {
            string aux;
            LbMat.Items.Add("Matriz B");
            for (int i = 0; i < m2; i++)
            {
                aux = "";
                for (int j = 0; j < n2; j++)
                {
                    aux += mat2A.Elem[i, j] + "\t";
                }
                aux += "\t";
                LbMat.Items.Add(aux);
            }

            TbIndi2.Text = "Mostrando matriz";
        }

        private void BtTamaño2_Click(object sender, RoutedEventArgs e)
        {
            m2 = int.Parse(Tbm2.Text);
            n2 = int.Parse(Tbn2.Text);
            int x = 0;
            int y = -20;
            mat2A = new CalcuMatrices(m2, n2);
            TbMat2 = new TextBox[m2, n2];
            StackPanel2.Children.Clear();
            TbIndi2.Text = "Tamaño de la matriz " + m2 + "x" + n2 + " establecido";

            for (int i = 0; i < m2; i++)
            {
                for (int j = 0; j < n2; j++)
                {
                    TbMat2[i, j] = new TextBox();
                    TbMat2[i, j].Width = 30;
                    TbMat2[i, j].Height = 20;
                    TbMat2[i, j].HorizontalAlignment = HorizontalAlignment.Left;
                    TbMat2[i, j].VerticalAlignment = VerticalAlignment.Top;
                    if (j == 0)
                    {
                        TbMat2[i, j].Margin = new Thickness(30 * j, x, 0, 0);
                    }

                    else
                    {
                        TbMat2[i, j].Margin = new Thickness(30 * j, y, 0, 0);
                    }

                    StackPanel2.Children.Add(TbMat2[i, j]);
                }
            }
        }

        private void BtMostrar2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LeerMat2();
                MostrarMat2();
            }

            catch
            {
                MessageBox.Show("Error de datos");
            }
        }

        private void BtTranspuesta2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LeerMat2();

                mat2B = new CalcuMatrices(n2, m2);

                for (int i = 0; i < n2; i++)
                {
                    for (int j = 0; j < m2; j++)
                    {
                        mat2B.Elem[i, j] = mat2A.Elem[j, i];
                    }
                }

                string aux;
                LbMat.Items.Add("Transpuesta de la matriz B");
                for (int i = 0; i < n2; i++)
                {
                    aux = "";
                    for (int j = 0; j < m2; j++)
                    {
                        aux += mat2B.Elem[i, j] + "\t";
                    }
                    aux += "\t";
                    LbMat.Items.Add(aux);
                }

                TbIndi2.Text = "Mostrando matriz transpuesta";
            }

            catch
            {
                MessageBox.Show("Error de datos");
            }
        }

        private void BtInversa2_Click(object sender, RoutedEventArgs e)
        {
            if (m2 == n2)
            {
                LeerMat2();

                mat2In = new CalcuMatrices(m2, n2);

                for (int i = 0; i < m2; i++)
                {
                    for (int j = 0; j < n2; j++)
                    {
                        mat2In.Elem[i, j] = 0;
                        if (i == j)
                        {
                            mat2In.Elem[i, j] = 1;
                        }
                    }
                }

                double pivote;
                double aux;

                for (int i = 0; i < m2; i++)
                {
                    pivote = mat2A.Elem[i, i];
                    for (int k = 0; k < n2; k++)
                    {
                        mat2A.Elem[i, k] = mat2A.Elem[i, k] / pivote;
                        mat2In.Elem[i, k] /= pivote;
                    }

                    for (int j = 0; j < n2; j++)
                    {
                        if (i != j)
                        {
                            aux = mat2A.Elem[j, i];
                            for (int k = 0; k < n2; k++)
                            {
                                mat2A.Elem[j, k] = mat2A.Elem[j, k] - aux * mat2A.Elem[i, k];
                                mat2In.Elem[j, k] = mat2In.Elem[j, k] - aux * mat2In.Elem[i, k];
                            }
                        }
                    }
                }

                string aux2;
                LbMat.Items.Add("Inversa de la matriz B");
                for (int i = 0; i < n2; i++)
                {
                    aux2 = "";
                    for (int j = 0; j < m2; j++)
                    {
                        aux2 += mat2In.Elem[i, j] + "\t";
                    }
                    aux2 += "\t";
                    LbMat.Items.Add(aux2);
                }

                TbIndi2.Text = "Mostrando matriz inversa";

            }

            else
            {
                MessageBox.Show("La matriz no es cuadrada");
            }
        }

        private void BtDeterminante2_Click(object sender, RoutedEventArgs e)
        {
            if (m2 == n2)
            {
                LeerMat2();

                double pivote, pivote1, aux;
                double det = 1;

                for (int i = 0; i < m2; i++)
                {
                    pivote = mat2A.Elem[i, i];
                    for (int j = i + 1; j < n2; j++)
                    {
                        pivote1 = mat2A.Elem[j, i];
                        aux = pivote1 / pivote;
                        for (int k = 0; k < m2; k++)
                        {
                            mat2A.Elem[j, k] = mat2A.Elem[j, k] - aux * mat2A.Elem[i, k];
                        }
                    }
                }

                LbMat.Items.Add("Determinante de la matriz B");
                for (int i = 0; i < n2; i++)
                {
                    det *= mat2A.Elem[i, i];
                }
                LbMat.Items.Add(det);

                TbIndi2.Text = "Mostrando el determinante";
            }

            else
            {
                MessageBox.Show("La matriz no es cuadrada");
            }
        }

        private void BtMultiplicar2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LeerMat2();

                mat2B = new CalcuMatrices(m2, n2);

                for (int i = 0; i < m2; i++)
                {
                    for (int j = 0; j < n2; j++)
                    {
                        mat2B.Elem[i, j] = double.Parse(TbMulti2.Text) * mat2A.Elem[i, j];
                    }
                }

                string aux;
                LbMat.Items.Add("Matriz B multiplicada por " + TbMulti2.Text);
                for (int i = 0; i < m2; i++)
                {
                    aux = "";
                    for (int j = 0; j < n2; j++)
                    {
                        aux += mat2B.Elem[i, j] + "\t";
                    }
                    aux += "\t";
                    LbMat.Items.Add(aux);
                }

                TbIndi2.Text = "Mostrando matriz multiplicada por " + TbMulti2.Text;
            }

            catch
            {
                MessageBox.Show("Error de datos");
            }
        }

        private void BtElevar2_Click(object sender, RoutedEventArgs e)
        {
            if (m2 == n2)
            {
                LeerMat2();
                mat2B = new CalcuMatrices(m2, n2);
                mat2C = new CalcuMatrices(m2, n2);

                for (int i = 0; i < m2; i++)
                {
                    for (int j = 0; j < n2; j++)
                    {
                        mat2B.Elem[i, j] = mat2A.Elem[i, j];
                    }
                }

                for (int a = 0; a < (int.Parse(TbElevar2.Text)) - 1; a++)
                {
                    for (int i = 0; i < m2; i++)
                    {
                        for (int j = 0; j < m2; j++)
                        {
                            for (int k = 0; k < n2; k++)
                            {
                                mat2C.Elem[i, j] += mat2B.Elem[i, k] * mat2A.Elem[k, j];
                            }
                        }
                    }

                    for (int i = 0; i < m2; i++)
                    {
                        for (int j = 0; j < n2; j++)
                        {
                            mat2B.Elem[i, j] = mat2C.Elem[i, j];
                            mat2C.Elem[i, j] = 0;
                        }
                    }
                }

                string aux;
                LbMat.Items.Add("Matriz B elevada a la " + TbElevar2.Text);
                for (int i = 0; i < m2; i++)
                {
                    aux = "";
                    for (int j = 0; j < n2; j++)
                    {
                        aux += mat2B.Elem[i, j] + "\t";
                    }
                    aux += "\t";
                    LbMat.Items.Add(aux);
                }

                TbIndi2.Text = "Mostrando matriz elevada a la " + TbElevar2.Text;
            }

            else
            {
                MessageBox.Show("El número de columnas de la primera matriz debe coincidir con el número de filas de la segunda matriz");
            }
        }

        private void BtSumaMats_Click(object sender, RoutedEventArgs e)
        {
            if (m == n)
            {
                LeerMat();
                LeerMat2();
                matSuRe = new CalcuMatrices(m, n);

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matSuRe.Elem[i, j] = matA.Elem[i, j] + mat2A.Elem[i, j];
                    }
                }

                string aux;
                LbMat.Items.Add("Suma de las matrices A y B");
                for (int i = 0; i < m; i++)
                {
                    aux = "";
                    for (int j = 0; j < n; j++)
                    {
                        aux += matSuRe.Elem[i, j] + "\t";
                    }
                    aux += "\t";
                    LbMat.Items.Add(aux);
                }
            }

            else
            {
                MessageBox.Show("Las dimensiones de ambas matrices deben ser iguales para poder sumarlas");
            }
        }

        private void BtRestaMats_Click(object sender, RoutedEventArgs e)
        {
            if (m == n)
            {
                LeerMat();
                LeerMat2();
                matSuRe = new CalcuMatrices(m, n);

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matSuRe.Elem[i, j] = matA.Elem[i, j] - mat2A.Elem[i, j];
                    }
                }

                string aux;
                LbMat.Items.Add("Resta de las matrices A y B");
                for (int i = 0; i < m; i++)
                {
                    aux = "";
                    for (int j = 0; j < n; j++)
                    {
                        aux += matSuRe.Elem[i, j] + "\t";
                    }
                    aux += "\t";
                    LbMat.Items.Add(aux);
                }
            }

            else
            {
                MessageBox.Show("Las dimensiones de ambas matrices deben ser iguales para poder Restarlas");
            }
        }

        private void BtMultiMats_Click(object sender, RoutedEventArgs e)
        {
            if (m == n2)
            {
                LeerMat();
                LeerMat2();
                matMul = new CalcuMatrices(m, n);

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n2; j++)
                    {
                        for (int k = 0; k < n; k++)
                        {
                            matMul.Elem[i, j] += matA.Elem[i, k] * mat2A.Elem[k, j];
                        }
                    }
                }

                string aux;
                LbMat.Items.Add("Multiplicación de las matrices A y B");
                for (int i = 0; i < m; i++)
                {
                    aux = "";
                    for (int j = 0; j < n2; j++)
                    {
                        aux += matMul.Elem[i, j] + "\t";
                    }
                    aux += "\t";
                    LbMat.Items.Add(aux);
                }
            }

            else
            {
                MessageBox.Show("El número de columnas de la matriz A debe coincidir con el número de filas de la matriz B");
            }
        }

        private void BtBorrar_Click(object sender, RoutedEventArgs e)
        {
            LbMat.Items.Clear();
        }
    }
}
