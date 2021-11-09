using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Geometrica
{
    class Cilindro : Figura
    {
        double altura;
        double radio;

        public double getAltura()
        {
            return altura;
        }

        public void setAltura(double alt)
        {
            altura = alt;
        }

        public double getRadio()
        {
            return radio;
        }

        public void setRadio(double rad)
        {
            radio = rad;
        }

        public Cilindro()
        {
            radio = 0; altura = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="alt"></param>
        /// <param name="rad"></param>
        public Cilindro(double alt, double rad)
        {
            altura = alt;
            radio = rad;
        }

        public override double CalcularArea()
        {
            return 6.28 * radio * (radio + altura);
        }

        public override double CalcularVolumen()
        {
            return 3.14 * Math.Pow(radio, 2) * altura;
        }

        public override string ToString()
        {
            return "FIGURA: Cilindro " + "Altura: " + getAltura() + " Radio: " + getRadio() + " Area: " + CalcularArea() + " Volumen: " + CalcularVolumen();
        }
    }

}
