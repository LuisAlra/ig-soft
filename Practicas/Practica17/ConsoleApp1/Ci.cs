using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ci
    {
        private double pi;
        public double Pi 
        { 
            get { return pi; } 
            set { pi = value; } 
        }
       
        public void Meti()
        {
            pi = 100.8;
        }
    }
}
