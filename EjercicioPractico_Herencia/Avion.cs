using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioPractico_Herencia
{
    class Avion : Vehiculo
    {
     
        public void Despegar()
        {
            Console.WriteLine("El avión está despegando");
        }

        public void Aterrizar()
        {
            Console.WriteLine("El avión está aterrizando");
        }

        public override void Conducir()
        {
            //base.Conducir();
            Console.WriteLine("Surcando los cielos");
        }
    }
}
