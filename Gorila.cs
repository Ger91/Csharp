using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    //sealed  class   Gorila : Mamiferos, IMamiferosTerrestres //EVITA QUE HAYA OTRAS CLASES QUE HEREDEN DE GORILA 
      class   Gorila : Mamiferos, IMamiferosTerrestres
    {

        public Gorila(String nombreGorila) : base(nombreGorila)
        {

        }
        public override void pensar()// sobreescritura  el método de la clase padre.

        {
            Console.WriteLine("Pensamiento instintivo avanzado");
        }
        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }


        public int NummeroPatas()
        {
            return 2;
        }
    }
}
