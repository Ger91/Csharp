
using System.Runtime.CompilerServices;

namespace Herencia
{
    class Program 
    {
        static void Main(string[] args)
        {
            Gorila Copito= new Gorila("Copito");
            Caballo Babieca = new Caballo("Babieca");
            IMamiferosTerrestres IBabieca = Babieca;
            ISalto IMiBabieca = Babieca;


            Humano Ger= new Humano("Ger");
            /*Aqui se diseña aquellos métodos heredados y sin heredar*/
            Copito.cuidarCrias();
            Copito.respirar();
            Copito.trepar();
            Copito.getNombre();

            Babieca.cuidarCrias();
            Babieca.respirar();
            Babieca.galopar();

            Ger.cuidarCrias();
            Ger.respirar();
            Ger.pensar();

            //---------Clase object 

            //  Ger.Equals.cuidarCrias(); 
            // en el caso de equals o ToString provienen de la primera clase por lo tanto lo tendran cualquier objeto creado de la clase object
            /*PRINCIPIO DE SUSTITUCIÓN 
             BARBARA LISKOV
             Se trata de sustituir un objeto de un tipo por otro de un tipo diferente tieniendo en cuenta el tipo que esta herendando.

             Se trata de aplicar la frase "ES SIEMPRE UN "

             Ejemplo

             Un caballo es siempre un grila ?¿ no por lo tanto no se puede sustituir

             Caballo animal =new Gorila(); dará error

                Mamiferos animal= new Caballo(); no dará error
             */
            Mamiferos animal = new Caballo("mascota");
            Caballo mascota = new Caballo("Bonito");

            animal = mascota;
            object micaballo =new  Caballo("Rocinante");

            Mamiferos[] almacenAnimales = new Mamiferos[3];

            almacenAnimales[0] = mascota;
            almacenAnimales[1] = Ger;
            almacenAnimales[2] = Babieca;


            /*-------------------POLIMORFISMO---------------*/

            Ballena Wally = new Ballena("Wally");
            Wally.nadar();
            Console.WriteLine($"numero de patas de babieca :" + IBabieca.NummeroPatas());
            Console.WriteLine($" babieca salta con  :" + IMiBabieca.NummeroPatas());

            Lagartija Ainhoa = new Lagartija("Aimhoa");

            Ainhoa.respirar();

            Ger.respirar();

            Ainhoa.getNombre();

            //Creacion de propiedades 
           }
            /*public double SALARIO{
             * 
             * get {return this.Salario;}
             * set {this.salario=evaluacionSalario(value);} 
             * }*/
        }
    }
    
    
}