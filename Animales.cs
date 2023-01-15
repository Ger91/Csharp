using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    abstract class Animales
    {

        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        //Se implementa en la clase abtracta y se desarrolla en el resto de clases que hereden de Animales.

        public abstract void getNombre();
       
    }
}
