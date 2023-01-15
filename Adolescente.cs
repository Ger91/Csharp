using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Adolescente : Humano
    {
        public Adolescente(string nombreHumano) : base(nombreHumano)
        {
        }
        //no se puede heredar ese método devido a que esta sellado
        //public override void pensar()
        //{
        //    Console.WriteLine("Las hormonas no me dejan pensar con claridad");
        //}
    }
}
