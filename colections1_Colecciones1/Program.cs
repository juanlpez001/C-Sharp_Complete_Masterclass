using System;
using System.Collections.Generic;

namespace colections1_Colecciones1
{
    class Program
    {
        static void Main(string[] args)
        {
            //List, tipo de elemento a almacenar, nombre, new list tipo elemento
            List<int> numeros = new List<int>(); //Declarar una liista (coleccion de tipo list)
            /*
                        numeros.Add(5); //agregar un elemento 
                        numeros.Add(7); //agregar un elemento 
                        numeros.Add(9); //agregar un elemento 
            */







            /*//podriamos crear un array de enteros que agregue elementos al List
             int[] listaNumeros = new int[] { 3, 6, 8, 10, 50 };

             for (int i = 0; i < 5; i++)
             {
                 numeros.Add(listaNumeros[i]);
             }





             for (int i = 0; i < 5; i++)
             {
                 Console.WriteLine(numeros[i]);
             }
            */




            //List<int> numeros = new List<int>();
            Console.WriteLine("¿Cuantos elementos quieres introducir?");
            int elemento = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            //elementos que almacene el usuario
            for ( int i= 0; i<elemento; i++)
            //for ( int i = 0; i<numeros.Count; i++) 
            {
                numeros.Add(Int32.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Elementos Almacenados: ");

            //lee elementos 
            for (int i = 0; i < elemento; i++)
            {
              
                Console.WriteLine(numeros[i]);
            }





        }
    }
}
