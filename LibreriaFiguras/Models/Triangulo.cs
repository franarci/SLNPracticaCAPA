using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaFiguras.Models
{
    public class Triangulo
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Triangulo(double _base, double altura)
        {
            Base = _base;
            Altura = altura;
        }

        public double superficie()
        {

            return Base * Altura / 2;
        }
    }
}
