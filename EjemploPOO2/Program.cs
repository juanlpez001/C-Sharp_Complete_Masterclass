using System;

namespace EjemploPOO2
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo;

            miCirculo = new Circulo();

            Console.WriteLine(miCirculo.CalculoArea(3));

            Circulo miCirculo2 = new Circulo();

            Console.WriteLine(miCirculo2.CalculoArea(9));

        }

    }

    class Circulo
    {
        private const double pi = 3.1416;  //para encapsular solo es necesario poner private. 
        //encapsular lo usamos para las variables, constantes para impedir que se modifique y se pueda ver o usar. 

        public double CalculoArea(int radio)
        {

            return pi * radio * radio;
        }

    }
    /*CONVENCIONES A LA HORA DE PROGRAMAR:
     * Los identificadores "Public deben de comenzar con letra mayuscula. 
     * Notacion. "PascalCase". 
     * Ejemplo: public double CalculoArea(){...
     * 
     * Los identificadores que no son "public" ddeben comenzar por letra minuscula.
     * Notacion. "camelCase".
     * Ej. longitudRadio*/
}