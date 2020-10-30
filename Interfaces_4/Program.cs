using System;

namespace Interfaces_4
{
    class Program
    {
        static void Main(string[] args)
        {

            AvisosTrafico av1 = new AvisosTrafico();

            av1.mostrarAviso();

            AvisosTrafico av2 = new AvisosTrafico("Policia Nacional de Vias", "Sanción exceso de velocidad", "19-06-20");

            Console.WriteLine(av2.getFecha());

            av2.mostrarAviso();
        
        }



    }
}
