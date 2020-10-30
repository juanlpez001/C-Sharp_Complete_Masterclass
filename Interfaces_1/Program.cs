using System;

namespace Interfaces_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballo miBabieca = new Caballo("Babieca");

            Humano miJuan = new Humano("Juan");

            Gorila miCopito = new Gorila("Copito");

            Mamiferos[] almacenAnimales = new Mamiferos[3];

            almacenAnimales[0] = miBabieca;

            almacenAnimales[1] = miJuan;

            almacenAnimales[2] = miCopito;

            for (int i = 0; i < 3; i++)
            {
                almacenAnimales[i].pensar();

            }

            Mamiferos miMamifero = new Mamiferos("");


            Ballena miWillie = new Ballena("Willie");
            miWillie.nadar();

            Console.WriteLine("Numero de patas de Babieca: " + miBabieca.numeroPatas());

            Console.WriteLine("Numero de patas Gorila: " +miCopito.numeroPatas());

        }
    }
    // En la interfaz definimos el comportamiento obligatorio  las clases que hereden
    interface IMamiferosTerrestres
    {
        //los metodos de una interfaz no se desarrollan, simplemente se declaran
        int numeroPatas(); //no agregar modificadores de acceso (public, private, protected)     

    }

    class Mamiferos
    {
        public Mamiferos(String nombre)
        {
            nombreSerVivo = nombre;
        }

        protected void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public virtual void pensar()
        {
            Console.WriteLine("Pensamiento básico instintivo");
        }

        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias hasta que se valgan por si solas");

        }

        public void getNombre()
        {
            Console.WriteLine("El nombre del ser vivo es: " + nombreSerVivo);
        }

        private String nombreSerVivo;
    }

    class Ballena : Mamiferos
    {
        public Ballena(String nombreBallena) : base(nombreBallena)
        {

        }

        public void nadar()
        {
            Console.WriteLine("Soy capaz de nadar");
        }
    }
    //cuando una clase está heredando de otra clase y queremos agregar otra herencia la ponemos seguida de una coma(,)
    class Caballo : Mamiferos, IMamiferosTerrestres
    {
        public Caballo(String nombreCaballo) : base(nombreCaballo)
        {

        }

        public void galopar()
        {
            Console.WriteLine("Soy capaz de Galopar");

        }

        public int numeroPatas()
        {
            return 4;
        }
    }

    class Humano : Mamiferos
    {
        public Humano(String nombreHumano) : base(nombreHumano)
        {


        }
        public override void pensar() //con esto le indicamos a visual studio que modificamos una clase
        {
            Console.WriteLine("Soy Capaz de pensar");
        }
    }

    class Gorila : Mamiferos, IMamiferosTerrestres
    {
        public Gorila(string nombreGorila) : base(nombreGorila)
        {

        }

        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }

        public override void pensar()
        {
            Console.WriteLine("Pensamiento instintivo Avanzado");
        }

        public int numeroPatas()
        {
            return 2;
        }
    }
}
