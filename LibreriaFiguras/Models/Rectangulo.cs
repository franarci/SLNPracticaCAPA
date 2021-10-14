using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaFiguras.Models
{
    public class Rectangulo
    {
        public double Largo{ get; set; }
        public double Alto{ get; set; }

        public Rectangulo(double largo, double alto)
        {
            Largo = largo;
            Alto = alto;
        }

        public double superficie()
        {
            return Largo * Alto;
        }
    }
}
