using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenCalcuNL15
{
    internal class Conversiones
    {
        public Conversiones()
        {

        }

        public void Dec2Bin(int dec, ref string bin)
        {
            bin = Convert.ToString(dec, 2);
        }

        public void Bin2Dec(string bin, ref int dec)
        {
            int sum = 0;
            char[] array =  bin.ToCharArray();
            Array.Reverse(array);

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    sum += (int)Math.Pow(2, i);
                }
            }

            dec = sum;
        }

        public void Dec2Hexa(int dec, ref string hexa)
        {
            char[] letras = { 'A', 'B', 'C', 'D', 'E', 'F' };
            int divisor = 16;
            int resto = 0;
            hexa = "";

            for (int i = dec % divisor, j = 0; dec > 0; dec /= divisor, i = dec % divisor, j++)
            {
                resto = i % divisor;
                if (resto >= 10)
                {
                    hexa = letras[resto - 10] + hexa;
                }

                else
                {
                    hexa = resto + hexa;
                }
            }
        }

        public void Hexa2Dec(string hexa, ref int dec)
        {
            dec = 0;
            int divisor = 16;

            for (int i = 0, j = hexa.Length - 1; i < hexa.Length; i++, j--)
            {

                if (hexa[i] >= '0' && hexa[i] <= '9')
                {
                    dec += (int)Math.Pow(divisor, j) * Convert.ToInt32(hexa[i] + "");
                }
                else if (hexa[i] >= 'A' && hexa[i] <= 'F')
                {
                    dec += (int)Math.Pow(divisor, j) * Convert.ToInt32((hexa[i] - 'A' + 10) + "");
                }
            }
        }

        public void Dec2Octal(int dec, ref string octal)
        {
            int divisor2 = 8;
            int digito = 0;
            int oct = 0;

            for (int i = dec % divisor2, j = 0; dec > 0; dec /= divisor2, i = dec % divisor2, j++)
            {
                digito = i % divisor2;
                oct += digito * (int)Math.Pow(10, j);
            }

            octal = oct.ToString();
        }

        public void Octal2Dec(string octal, ref int dec)
        {
            dec = 0;
            int digito = 0;
            int divisor = 10;

            for (int i = int.Parse(octal), j = 0; i > 0; i /= divisor, j++)
            {
                digito = (int)i % divisor;
                dec += digito * (int)Math.Pow(8, j);
            }
        }

        public void Cel2Far(double cel, ref double far)
        {
            far = (1.8 * cel) + 32;
        }

        public void Cel2Ran(double far, ref double ran)
        {
            ran = far + 460;
        }

        public void Cel2Kel(double cel, ref double kel)
        {
            kel = cel + 273;
        }

        public void Far2Cel(double far, ref double cel)
        {
            cel = (far - 32)/1.8;
        }

        public void Ran2Cel(double ran, ref double cel)
        {
            cel = (ran - 0.6)/1.8;
            cel = cel - 273;
        }

        public void Kel2Cel(double kel, ref double cel)
        {
            cel = kel - 273;
        }
    }
}
