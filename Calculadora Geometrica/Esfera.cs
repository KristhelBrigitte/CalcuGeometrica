using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Geometrica
{
    class Esfera:Figura
    {
        double radio;
    
        public double Radio
        {
            get => this.radio;
            set => this.radio = value;
        }

        public Esfera()
        {
            radio = 0;
        }

        public override double CalcularArea()
        {
            return 4 * 3.14 * Math.Pow(radio, 2);
        }

        public override double CalcularVolumen()
        {
            return (4 * 3.14 * Math.Pow(radio, 3)) / 3;
        }
        public override string ToString()
        {
            return "FIGURA: Esfera " + "Radio: " + this.radio + " Area: " + CalcularArea() + " Volumen: " + CalcularVolumen();
        }
    }
}
