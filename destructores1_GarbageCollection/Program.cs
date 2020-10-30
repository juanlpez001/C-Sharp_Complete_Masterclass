using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace destructores1_GarbageCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            ManejoArchivos miArchivo = new ManejoArchivos();
            miArchivo.mensaje();
        }
    }

    class ManejoArchivos
    {
        StreamReader archivo = null;

        int contador = 0;

        string linea; 
        //constructor
        public ManejoArchivos()
        {
            //archivo prueba.txt almacenado en Disco Local C: 
            archivo = new StreamReader(@"c:\prueba.txt"); 

            //mientras sea diferente de nulo, quiere decir mientras contenga texto:
            while((linea=archivo.ReadLine()) != null)
            {
                Console.WriteLine(linea); //que vaya imprimiendo las lineas de texto que lee

                contador++; //incrementamos variable contador

            }

           
        }

        public void mensaje()
        {
            Console.WriteLine("hay {0} lineas", contador);
        }

        //la idea es cerrar la conexion de la aplicación con el archivo de texto
        //porque está consumiendo recursos "archivo = new StreamReader(@""); utilizaremos el destructor
       
        //el destructor debe tener el mismo nombre del constructor
        ~ManejoArchivos()
        {
            archivo.Close();
        }
    }
}
