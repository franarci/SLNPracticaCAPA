using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaFiguras.Models;

namespace WindowsFiguras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            double radio = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese un radio  (Ej: 3,8)"));
            Circulo circulo = new Circulo(radio);
            lblCirculo.Text = "Superficie: " + Convert.ToString(circulo.superficie());
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            double largo = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese un largo (Ej: 3,8)"));
            double alto = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese un alto (Ej: 3,8)"));
            Rectangulo rectangulo = new Rectangulo(largo, alto);
            lblRectangulo.Text = "Superficie: " + Convert.ToString(rectangulo.superficie());
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            double _base = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese una base (Ej: 3,8)"));
            double altura = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese una altura (Ej: 3,8)"));
            Triangulo triangulo = new Triangulo(_base, altura);
            lblTriangulo.Text = "Superficie: " + Convert.ToString(triangulo.superficie());
        }
    }
}
