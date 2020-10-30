using System;

namespace Herencia3_PrincipioConstitucion
{
    class Program
    {
        static void Main(string[] args)
        {
            //instancia perteneciente a la clase caballo 

            Caballo Babieeca = new Caballo("MiCaballo");
            Humano Juan = new Humano("Pablo");
            Gorilas Copito = new Gorilas("Jorge");

            Console.WriteLine("PRINCIPIO DE CONSTITUCION");
            //PRINCIPIO DE CONSTITUCIÓN
            Mamiferos animal = new Caballo("Bucefalo"); //dentro objetos mamiferos almacenamos un objeto caballo

            Mamiferos persona = new Humano("López"); //persona hace parte de Mamiferos 

            //ANIMAL Y PERSONA SON DE TIPO MAMIFEROS, ESAS INSTANCIAS PUEDEN ACCEDER A METODOS DECLARADOS EN CLASES MAMIFEROS

            Caballo Bucefalo = new Caballo("MiBucefalo"); //una instancia perteneciente a la clase caballo
            animal = Bucefalo; //en una variable de tipo mamiferos almaceno una de tipo Caballo
            //un caballo es un mamifero pero no al reves, un mamifero no siempre es un caballo 
            //Bucefalo = animal; estaria erroneo

            //TAMBIEN SE PUEDE HACER //object es la que está en la cuspide 
            Object miAnimal = new Caballo("otroBucefalo");


            Babieeca.CuidarCrias(); //en el menu aparecen metodos que hereda de la clase mamiferos (cuidar crias)
            Juan.Pensar(); //no hereda metodos exclusivos de la clase caballo
            Copito.Trepar();

            Juan.getNombre();
        }
    }

    class Mamiferos
    {
        public Mamiferos(String nombre)
        {
            nombreSerVivo = nombre; //lo que se almacene en nombre se almacenara en nombreSerVivo
        }

        public void Respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public void CuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias hasta cuando se valgan por si solas");
        }
        public void getNombre()
        {
            Console.WriteLine("El nombre del ser vivo es: " + nombreSerVivo);
        }

        private String nombreSerVivo;


    }
    //nombre de la clase ":" + nombre de la clase de la que hereda
    class Caballo : Mamiferos
    {
        public Caballo(String nombreCaballo) : base(nombreCaballo)
        {



        }
        //asi no es necesario volver a programar que Caballo respira y cuida de sus crias 
        public void Galopar()
        {
            Console.WriteLine("Soy capaz de galopar"); //exxclusividad de caballos
        }


    }
    class Humano : Mamiferos
    {
        public Humano(String nombreHumano) : base(nombreHumano)
        {

        }
        public void Pensar()
        {
            Console.WriteLine("Soy capaz de pensar criticamente");  //esclusividad humanos
        }

    }
    class Gorilas : Mamiferos
    {
        public Gorilas(String nombreGorilas) : base(nombreGorilas)
        {

        }
        public void Trepar()
        {
            Console.WriteLine("Soy capaz de trepar"); //exclusividad gorilas
        }
    }
}
