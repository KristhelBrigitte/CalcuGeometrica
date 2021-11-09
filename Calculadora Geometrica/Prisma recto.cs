using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Geometrica
{
    class PrismaRecto:Figura
    {
        double altura;
        double ladoBase;
        double apotema;
        int cantidadLados;

        public double Altura { get; set; }
        public double LadoBase { get; set; }
        public double Apotema { get; set; }
        public int CantidadLados { get; set; }

        public PrismaRecto()
        {
            altura = 0;
            ladoBase = 0;
            apotema = 0;
            cantidadLados = 0;
        }

        public PrismaRecto(double alt,double lb,double ap, int lados)
        {
            altura = alt;
            ladoBase = lb;
            apotema = ap;
            cantidadLados = lados;
        }

        public double perimetro()
        {
            return ladoBase * cantidadLados;
        }

        public override double CalcularArea()
        {
            return perimetro()* (altura+apotema);
        }

        public override double CalcularVolumen()
        {
            return (perimetro() * apotema / 2) * altura;
        }

        public override string ToString()
        {
            return "FIGURA: Prisma recto" + "Altura: " +  altura + " Lado base " + ladoBase +" Apotema: "+apotema +" # Lados: "+cantidadLados+ " Area: " + CalcularArea() + " Volumen: " + CalcularVolumen();
        }
    }
}
