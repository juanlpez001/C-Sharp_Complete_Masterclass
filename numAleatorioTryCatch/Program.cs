using System;

namespace numAleatorioTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();

            int aleatorio = numero.Next(0, 100);

            int minumero = 101;

            int intentos = 0;


            Console.WriteLine("introduce un número entre 0 y 100.");


            while (aleatorio != minumero)
            {
                intentos++;


                try
                {

                    minumero = int.Parse(Console.ReadLine());
                }

                catch (FormatException e)
                {
                    Console.WriteLine("Error, has introducido texto, se tomará como 0.");
                    minumero = 0;

                }
                catch (Exception e)
                {   //si utilizamos este tipo de excepcion las demas excepciones van a quedar cubiertas (no serviran)

                    Console.WriteLine("El número introducido no es un valor valido, se tomará como 0.");
                    Console.WriteLine(e.Message);
                    minumero = 0;

                }
                if (minumero > aleatorio) Console.WriteLine("El número es más bajo.");

                if (minumero < aleatorio) Console.WriteLine("el número es más alto.");
            }


            Console.WriteLine($"¡Correcto! Has necesitado {intentos} intentos.");


        }
    }
}

   

