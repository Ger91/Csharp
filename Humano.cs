using Herencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Humano : Mamiferos,IAnimalesYDeportes
    {

        public Humano(String nombreHumano) : base(nombreHumano)
        {

        }

        public Boolean bOlimpico()
        {
            return true;
        }

        //  new public void pensar()//------------- es para diferenciar este metodo del de la clase heredada.
        //public void pensar()// -------------invalida el método de la clase mamifero.
       sealed public override void pensar()// sobreescribe el método de la clase padre.

        {
            Console.WriteLine("Soy capaz de pensar");
        }

        public string tipoDeporte()
        {
            return "Baloncesto";
        }
    }
}