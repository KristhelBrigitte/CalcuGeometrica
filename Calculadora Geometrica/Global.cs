using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Calculadora_Geometrica
{
    class Global
    {
        private static ArrayList historial;

      

        public Global()
        {
            if (historial == null)
            {
               historial = new ArrayList();
            }

        }


        public void agregarRegistro(Figura fig)
        {

            historial.Add(fig);
        }
        
        public ArrayList getArrayLis ()
        {
            return historial;
        }

        public int tam()
        {
            return historial.Count;
        }

        



    }
}
