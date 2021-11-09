using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Geometrica
{
    class OctaedroRegular:Figura
    {
        double lado;

        public OctaedroRegular()
        {
            lado = 0;
        }
        public double Lado
        {
            get => this.lado;
            set => this.lado = value;
        }

        public override double CalcularArea()
        {
            return 2*Math.Sqrt(3) * Math.Pow(lado, 2);
        }

        public override double CalcularVolumen()
        {
            return (Math.Sqrt(2) * Math.Pow(lado, 3)) / 3;
        }
        public override string ToString()
        {
            return "FIGURA: Octaedro " + "Lado: " + lado + " Area: " + CalcularArea() + " Volumen: " + CalcularVolumen();
        }
    }
}
