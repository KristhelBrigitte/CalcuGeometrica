using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Geometrica
{
    class Ortoedro:Figura
    {
        double altura;
        double base1;
        double base2;

        public Ortoedro()
        {
            altura = 0;
            base1 = 0;
            base2 = 0;
        }

        public double Altura { get; set; }
        public double Base1 { get; set; }
        public double Base2 { get; set; }


        public override double CalcularArea()
        {
            return 2 * ((base1 * base2) + (base1 * altura) + (base2 * altura));
        }

        public override double CalcularVolumen()
        {
            return altura*base1*base2;
        }
        public override string ToString()
        {
            return "FIGURA: Ortoedro " + "Altura: " + altura+ " Base 1: " + base1 + " Base 2: "+base2+" Area: " + CalcularArea() + " Volumen: " + CalcularVolumen();
        }
    }
}
