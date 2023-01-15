using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia

{
     class Mamiferos:Animales
    {
        private String nombreSerVivo;

        public override void getNombre()
        {
            Console.WriteLine(String.Format("El nombre del mamífero es : {0}", nombreSerVivo));
        }
        public Mamiferos(String nombre)
        {
            nombreSerVivo = nombre;
        }
        public virtual void pensar()
        {
            Console.WriteLine("Pensamiento básico ínstintivo");
        }
        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crías hasta que se valen por sí mismas");

        }
    }
}
