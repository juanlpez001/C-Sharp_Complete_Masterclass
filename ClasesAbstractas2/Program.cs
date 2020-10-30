using System;

namespace ClasesAbstractas2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
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

            IMamiferosTerrestres ImiBabieca = miBabieca; //ahora es un objeto de la interfaz IMamiferos 
            ISaltoConPatas Imibabieca2 = miBabieca;  //ahora es un objeto de la interfaz ISaltoConPatas
            Console.WriteLine("Numero de patas de Babieca: " + ImiBabieca.numeroPatas()); //ahora es accesible con el principio de sustitución ya que numeroPAtas() 
                                                                                          //hace referencia a ImiBabieca de IMamiferos. 

            Console.WriteLine("Numero de patas con las que realiza un salto: " + Imibabieca2.numeroPatas()); //ahora es accesible con el principio de sustitución ya que numeroPAtas() 
                                                                                                             //hace referencia a ImiBabieca2 de ISaltoConPatas. 




            IMamiferosTerrestres ImiCopito = miCopito;
            ISaltoConPatas ImiCopito2 = miCopito;

            Console.WriteLine("Numero de patas Gorila: " + ImiCopito.numeroPatas());
            Console.WriteLine("Numero de patas Gcon las que realiza un salto: " + ImiCopito2.numeroPatas());
        */
            Lagartija Juancho = new Lagartija("Juancho");

            Juancho.getNombre();

            Humano Juan = new Humano("Juan");

            Juan.getNombre();

            }
    }
    // En la interfaz definimos el comportamiento obligatorio  las clases que hereden
    interface IMamiferosTerrestres
    {
        //los metodos de una interfaz no se desarrollan, simplemente se declaran
        int numeroPatas(); //no agregar modificadores de acceso (public, private, protected)     

    }

    interface IAnimalesDeportes
    {
        string tipoDeporte();
        Boolean esOlimpico();
    }

    interface ISaltoConPatas
    {
        int numeroPatas();
    }

    abstract class Animales
    {
        public void respirar()
        {

            Console.WriteLine("Soy capaz de respirar");

        }

        public abstract void getNombre(); //están obligadas a desarrollar getNombre
    
    }

    class Mamiferos : Animales
    {
        public Mamiferos(String nombre)
        {
            nombreSerVivo = nombre;
        }

     

        public virtual void pensar()
        {
            Console.WriteLine("Pensamiento básico instintivo");
        }

        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias hasta que se valgan por si solas");

        }

        public override void getNombre() //override sobreescribimos el meto abstracto (desarrollamos) 
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
    class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesDeportes, ISaltoConPatas
    {
        public Caballo(String nombreCaballo) : base(nombreCaballo)
        {

        }

        public void galopar()
        {
            Console.WriteLine("Soy capaz de Galopar");

        }
        //nuestra clase ahora es inaccesible desde fuera porque ya no tiene modificador public 
        int IMamiferosTerrestres.numeroPatas() //nos retornara el metodo de la interfaz IMamiferosTerrestres a
        {
            return 4;
        }
        //nuestra clase ahora es inaccesible desde fuera porque ya no tiene modificador public 
        int ISaltoConPatas.numeroPatas() //nos retornara el metodo de la interfaz ISaltoConPatas
        {
            return 2;
        }

        public string tipoDeporte()
        {
            return "Carreras de caballos (Hipica)";
        }

        public Boolean esOlimpico()
        {
            return true;
        }
    }

    class Lagartija : Animales
    {
        public Lagartija(String nombre)
        {
            nombreReptil = nombre; 
        }
        public override void getNombre()
        {
            Console.WriteLine("El nombre del reptil es: " + nombreReptil);
        }

        private String nombreReptil; 
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

    class Gorila : Mamiferos, IMamiferosTerrestres, ISaltoConPatas
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

        int IMamiferosTerrestres.numeroPatas()
        {
            return 2;
        }

        int ISaltoConPatas.numeroPatas()
        {
            return 2;
        }
    }
}