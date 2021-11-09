using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Geometrica
{
    class Cubo:Figura
    {
        double lado;

        public Cubo()
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
            return 6* Math.Pow(lado,2);
        }

        public override double CalcularVolumen()
        {
            return  Math.Pow(lado, 3);
        }
        public override string ToString()
        {
            return "FIGURA: Cubo " + "Lado: " + lado +" Area: " + CalcularArea() + " Volumen: " + CalcularVolumen();
        }

    }
}
