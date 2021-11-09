using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Geometrica
{
    class Piramide:Figura
    {
       double ladoBase;
       double altura;

        public double LadoBase { get; set; }
        public double Altura { get; set; }


        public override double CalcularArea()
        {
            double ladoB = ladoBase / 2;
            double periPira = 4 * ladoBase;
            return (periPira*(ladoB+arista()))/2;
        }

        public override double CalcularVolumen()
        {
            return ((ladoBase * ladoBase) * altura) / 3;
        }

        public double arista()
        {
            return Math.Sqrt(Math.Pow((ladoBase/2), 2) + Math.Pow(altura, 2));
        }
        public override string ToString()
        {
            return "FIGURA: Piramide Altura: " + altura +" Lado de base: "+ladoBase +" Area: " + CalcularArea() + " Volumen: " + CalcularVolumen();
        }
    }
}
