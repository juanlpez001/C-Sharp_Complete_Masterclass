using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioPractico_Herencia
{
    class Coche : Vehiculo
    {
        public void Acelerar()
        {
            Console.WriteLine("Acelerando");
        }

        public void Frenar()
        {
            Console.WriteLine("Frenando");
        }
        public override void Conducir()
        {
            Console.WriteLine("Conduciendo por la ciudad");
        }
    }
}
