using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //instancia perteneciente a la clase caballo 

            Caballo Babieeca = new Caballo();
            Humano Juan = new Humano();
            Gorilas Copito = new Gorilas();

            Babieeca.CuidarCrias(); //en el menu aparecen metodos que hereda de la clase mamiferos (cuidar crias)
            Juan.Pensar(); //no hereda metodos exclusivos de la clase caballo
            Copito.Trepar();
        }
    }

    class Mamiferos
    {
        public void Respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public void CuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias hasta cuando se valgan por si solas");
        }


    }
    //nombre de la clase ":" + nombre de la clase de la que hereda
    class Caballo:Mamiferos
    {
        //asi no es necesario volver a programar que Caballo respira y cuida de sus crias 
        public void Galopar()
        {
            Console.WriteLine("Soy capaz de galopar"); //exxclusividad de caballos
        }

    }
    class Humano:Mamiferos
    {
        public void Pensar()
        { 
            Console.WriteLine("Soy capaz de pensar criticamente");  //esclusividad humanos
        }
       
    }
    class Gorilas:Mamiferos
    {
        public void Trepar()
        {
            Console.WriteLine("Soy capaz de trepar"); //exclusividad gorilas
        }
    }
}
