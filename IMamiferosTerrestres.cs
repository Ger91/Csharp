using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
     interface IMamiferosTerrestres
    {
        /*
         1.El nombre del método debe coincidir.
        2. Mismo tipo de dato a devolver
        3.Mismo nº de parametros y tipo

        no permite deficinr campos en interfaces
        no se pueden definir constructores
        no se pueden definir destructores 
        no se pueden especificar modificadores de acceso en métodos (todos son public de forma implícita)
        no se pueden anidar clases ni otro tipo de estucturas en las interfaces
         */
        int NummeroPatas();
    }
}
