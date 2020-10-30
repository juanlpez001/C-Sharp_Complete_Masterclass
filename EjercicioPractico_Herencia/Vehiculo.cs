using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioPractico_Herencia
{
    class Vehiculo
    {
        public void ArrancarMotor(string SonidoAlArrancar)
        {
            Console.WriteLine($"Arranca el motor: {SonidoAlArrancar}");
        }

        public void PararMotor(string SonidoAlParar)
        {
            Console.WriteLine($"Parando el motor: {SonidoAlParar}");
        }
        
        public virtual void Conducir()
        {
            Console.WriteLine("Código defecto para conducir");

        }
        
    }
}
