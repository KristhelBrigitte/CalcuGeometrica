using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Geometrica
{
    class TetraedoRegular:Figura
    {
        double lado;

        public TetraedoRegular()
        {
            lado = 0;
        }

        public double Lado { get; set; }

        public override double CalcularArea()
        {
            return (Math.Sqrt(3)*Math.Pow(lado,2));
        }

        public override double CalcularVolumen()
        {
            return (Math.Sqrt(2) * Math.Pow(lado, 3))/12;
        }
        public override string ToString()
        {
            return "FIGURA: Tetraedo" + "LADO: "+lado+  " AREA: " + CalcularArea() + " VOLUMEN: " + CalcularVolumen();
        }


    }

}
