using System;

namespace EjemploPOO_Encapsulacion
{
    class Program
    {
        static void Main(string[] args)
        {

            ConversorEurodolar obj = new ConversorEurodolar(); //instancia

            obj.CambiaValorEuro(1.45);        //utilizamos el objeto obj para acceder al dato euro y modificamos el valor de euro.
            //2. ahora cambiamos el valor por 1.45
            Console.WriteLine(obj.Convierte(50));

        }

        class ConversorEurodolar
        {
            private double euro = 1.253; //encapsulamos con con private para que no se pueda modificaar o acceder 

            public double Convierte(double cantidad)
            {
                return cantidad * euro;
            }
            public void CambiaValorEuro(double nuevoValor) //1. creamos un metodo para cambiar el valor del euro dentro de 
                                                            //la misma clase
            {
                if (nuevoValor < 0) euro = 1.253;      //si el euro es menr a 1.253 el valor por defecto será 1.253
                {
                 euro = nuevoValor;                    // de lo contrario si es mayor, el valor se reemplazará por uno nuevo
                }
               
            }
        }
    }
}
    
       
    