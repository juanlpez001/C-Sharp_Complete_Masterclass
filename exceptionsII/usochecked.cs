﻿using System;

namespace exceptionsII
{
    class usochecked
    {
        static void Main(string[] args)
        {
            checked
            {
                int numero = int.MaxValue;
                int resultado = numero + 20;
                Console.WriteLine(resultado);
            }
        }
    }
}
