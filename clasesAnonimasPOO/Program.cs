using System;

using static System.Math; //importar metodos estaticos Math.  

using static System.Console; //importar metodo estatico Console. 

namespace clasesAnonimasPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //realizarTarea();

            // double raiz = Math.Sqrt(9);
            /*Gracias a que importamos el  metodo estatico math 
            No hay necesidad de llamar a la clase Math*/
            double raiz = Sqrt(9);
            double potencia = Pow(3, 4);


            var miVariable = new { nombre = "Juan", Edad = 19 }; //clase anonima
            //decimos que es anonima porque después de new no hay ningun nombre

            Console.WriteLine(miVariable.Edad); //para acceder a edad

            //double potencia = Math.Pow(3, 4);

            WriteLine(raiz);
            WriteLine(potencia);

        }

        static void realizarTarea()
        {
            Punto origen = new Punto();  //constructor por defecto

            Punto destino = new Punto(128, 80);

            Punto otroPunto = new Punto();

            double distancia = origen.DistanciaHasta(destino);
            //almacenamos la distancia entre origen y destino x, y 
            //distancia = origen que es nuestro primer objeto. objeto Distancia hasta destino



            Console.WriteLine($"La distancia entre los puntos es de: {distancia}");

            Console.WriteLine($"Numero de objetos creados: {Punto.ContadorDeObjetos()} ");

        }
    }
}