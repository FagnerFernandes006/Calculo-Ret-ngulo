using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaRetangulo
{
    public class Retangulo
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public double Area()
        {
            return Base * Altura;
        }
        public double Perimetro()
        {
            return (Base + Base) + (Altura + Altura);
        }
        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(Altura, 2));
        }
    }
}
