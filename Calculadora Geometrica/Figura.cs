using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Geometrica
{
    abstract class Figura
    {
        public abstract double CalcularArea();

        public abstract double CalcularVolumen();

        public abstract string ToString();
    }
}
