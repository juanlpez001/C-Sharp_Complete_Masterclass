using System;

namespace ConceptosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            realizarTarea();
        }

        static void realizarTarea()
        {
            Punto origen = new Punto();  //constructor por defecto

            Punto destino = new Punto(128, 80);
        }
    }
}
