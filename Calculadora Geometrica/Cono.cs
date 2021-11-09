using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Geometrica
{
    class Cono:Figura
    {
        double radio;
        double generatriz;
        double altura;

        public Cono()
        {
            radio =0;
            generatriz = 0;
            altura = 0;
        }

        public double getRadio()
        {
            return radio;
        }

        public void setRadio(double rad)
        {
            radio = rad;
        }

        public double getGeneratriz()
        {
            return generatriz;
        }
        public void setGeneratriz(double gen)
        {
            generatriz = gen;
        }

        public double getAltura()
        {
            return altura;
        }

        public void setAltura(double alt)
        {
            altura = alt;
        }
      


        public override double CalcularArea()
        {
            return  3.14 *radio*(radio+generatriz);
        }

        public override double CalcularVolumen()
        {
            return (3.14 * Math.Pow(radio, 2)*altura)/3;
        }


        public override string ToString()
        {
            return "FIGURA: Cono " + "Altura: " + getAltura() + " Radio: " + getRadio() +" Generatriz: "+getGeneratriz()+ " Area: " + CalcularArea() + " Volumen: " + CalcularVolumen();
        }


    }
}
