using System;

namespace EjercicioPractico_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Probando el avión");

            //instancia 
            Avion miAvion = new Avion();

            miAvion.ArrancarMotor("Fiuuuushh");

            miAvion.Despegar();

            miAvion.Conducir();

            miAvion.Aterrizar();

            miAvion.PararMotor("Clap");

            Console.WriteLine();

            Console.WriteLine("Probando el coche");

            Coche miCoche = new Coche();

            miCoche.ArrancarMotor("Rum Rum");

            miCoche.Acelerar();

            miCoche.Conducir();

            miCoche.Frenar();

            miCoche.PararMotor("Clam");

            Console.WriteLine();

            Console.WriteLine("Polimorfismo en acción");

            Vehiculo miVehiculo = miCoche;
            //mi coche es un vehiculo, almacenarlo en un objeto tipo vehiculo

            miVehiculo.Conducir();

            miVehiculo = miAvion;

            miVehiculo.Conducir(); 
        }
    }
}
