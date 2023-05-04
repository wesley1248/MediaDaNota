using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaDaNota {
    internal class Contagem {
        public static double contagemA (double a, double b, double c)
        {
            double soma = a + b + c;
            double contador = 0;
            for (int i = 0; i < soma; i++) 
            {
                contador++; 
            }
            return contador;
        }
    }
}
