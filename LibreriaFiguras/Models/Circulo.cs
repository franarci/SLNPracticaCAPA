using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaFiguras.Models
{
    public class Circulo
    {
        public double Radio { get; set; }

        public Circulo(double radio)
        {
            Radio = radio;
        }

        public double superficie()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }
    }
}
