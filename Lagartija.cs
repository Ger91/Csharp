using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Lagartija : Animales
    {
        private String nombreReptil;
        public override void getNombre()
        {
            Console.WriteLine("El nombre del reptil es " + nombreReptil);
        }
        public Lagartija(String Lagartija)
        {
            this.nombreReptil= Lagartija;
        }
    }
}
