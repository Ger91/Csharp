using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Caballo : Mamiferos,IMamiferosTerrestres,IAnimalesYDeportes,ISalto// PRIMERO SE IMPLEMENTA LA CLASE Y DESPUES LA INTERFACE
    {
        public Caballo(String nombreCaballo) : base(nombreCaballo) // cuando ponemos :base() llamamos al método de la superClase  en este caso clase mamifero.
        {

        }

        public bool bOlimpico()
        {
            return false;
        }

        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }


         int IMamiferosTerrestres.NummeroPatas()
        {
            return 4;
        }
        int ISalto.NummeroPatas()
        {
            return 2;
        }


        public string tipoDeporte()
        {
            return "hípica";
        }
    }


}
