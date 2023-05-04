using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediaDaNota {
    internal class Resultado {
        public static string ResultadoA(double a, double b, double c)
        {
            double soma = a + b + c;
            if (soma >= 70.0)
            {
                string situaçao = "APROVADO";
                return situaçao;
            }
            else
            {
                string situaçao = "REPROVADO";
                return situaçao;
            }
        }
    }
}
