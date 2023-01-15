using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Chimpance : Gorila
    {
        public Chimpance(string nombreGorila) : base(nombreGorila)
        {
            Console.WriteLine($"El nombre del chimpancé es {nombreGorila}");
        }

        public void  Balancearse()
        {
            Console.WriteLine("Me puedo desplazar balanceandome entre lianas");
        }
    }
}
