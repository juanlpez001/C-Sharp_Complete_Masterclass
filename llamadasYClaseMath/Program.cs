using System;

namespace llamadasYClaseMath
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

            Punto otroPunto = new Punto(); 

            double distancia = origen.DistanciaHasta(destino);
            //almacenamos la distancia entre origen y destino x, y 
            //distancia = origen que es nuestro primer objeto. objeto Distancia hasta destino

            
            
            Console.WriteLine($"La distancia entre los puntos es de: {distancia}");

            Console.WriteLine($"Numero de objetos creados: {Punto.ContadorDeObjetos()} ");

        }
    }
}