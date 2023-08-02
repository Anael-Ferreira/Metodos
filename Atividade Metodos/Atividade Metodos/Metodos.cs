using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Metodos
{
    internal class Metodos
    {
        public int Soma(int n1, int n2, int n3, int n4, int n5)
        {
            return n1 + n2 + n3 + n4 + n5;
        }

        public int Media(int n1, int n2, int n3, int n4, int n5)
        {
            return (n1 + n2 + n3 + n4 + n5) / 5;
        }

        public int Maior(int n1, int n2, int n3, int n4, int n5)
        {
            return Math.Max(n1, Math.Max(n2, Math.Max(n3,Math.Max(n4, n5))));
        }

        public int Menor(int n1, int n2, int n3, int n4, int n5)
        {
            return Math.Min(n1, Math.Min(n2, Math.Min(n3, Math.Min(n4, n5))));
        }

        public double Elevado(int n2, int n3)
        {
            return Math.Pow(n2, n3);
        }
    }
}
