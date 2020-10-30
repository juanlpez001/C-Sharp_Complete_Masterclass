using System;

namespace enum1_TiposEnumerados
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Estaciones alergia = Estaciones.Invierno;
            Console.WriteLine(alergia);

            //para almacenar en una cadena de texto
            String La_alergia = alergia.ToString();

            //para valor nulo 
            //Estaciones? alergia = null; 
            Console.WriteLine(La_alergia);
           */

            Bonus empleado1 = Bonus.normal;

            //casting 
            //variable tipo double = casting double de lo que hay almacenado en empleado1
            double bonusEmpleado1 = (double)empleado1; //para almacenar no bajo sino 500
            Console.WriteLine("Uso enum: ");
            Console.WriteLine(bonusEmpleado1);
            Console.WriteLine();

            Console.WriteLine("Bonus enum por parametro: ");
            Empleado Juan = new Empleado(Bonus.extra, 1900.50);
            Console.WriteLine("El salario del empleado es: " + Juan.getSalario());

        }
        class Empleado 
        {
            //tambien podemos utilizar el enum como parametro en una clase 
            public Empleado(Bonus bonusEmpleado, double salario)
            {
                bonus = (double)bonusEmpleado;
                this.salario = salario; 
            }

            public double getSalario()
            {
                return salario + bonus;
            }

            private double salario, bonus; 
        }

        
    }

    //son constantes
    /* enum Estaciones { Primavera, Verano, Otoño, Invierno }; */

    enum Bonus {  bajo=500, normal=1000, bueno=1500, extra=3000 }; 

}
