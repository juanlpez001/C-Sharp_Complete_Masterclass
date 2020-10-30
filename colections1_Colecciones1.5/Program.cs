using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace colections1_Colecciones1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();

            Console.WriteLine("Introduce elementos en la colección, 0 para Salir. ");

            int elem = 1; 

            while(elem != 0)
            {
                elem = Int32.Parse(Console.ReadLine());
                numeros.Add(elem);

            }
            //para eliminar el 0
            numeros.RemoveAt(numeros.Count - 1); //va a eliminar el ultimo elemento 

            Console.WriteLine("Elementos introducidos: ");

            // por cada elemento que hay en coleccion numeros
            foreach(int elemento in numeros)
            {
                Console.WriteLine(elemento);

            }
        
        
        }
    }
}
