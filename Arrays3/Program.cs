using System;

namespace Arrays3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array implicito : no especificamos ni el tipo de dato que almacena ni cuantos
            //ni cuantos elementos va a tener el array

            //var datos = new[] { "Juan", "López", "Colombia" };
            var valores = new[] { 15, 25, 35, 45, 55 };

            /*Array de objetos*/
            Empleados[] arrayEmpleados = new Empleados[2];
            //objetos almacenados en array empleados 
            //tipo dato   nombre array    especificar cuantos objetos va a tener en su interior

            arrayEmpleados[0] = new Empleados("Pablo", 18);

            /*Array de tipos o clases anonimas*/

            var personas = new[]
            {
                new{Nombre="Juan", Edad=19 },

                new{Nombre="Maria", Edad=49},

                new{Nombre="Pablo", Edad=35}

            };

            //ARRAY VALORES 
            for(int i=0; i < 5; i++)
            {
                Console.WriteLine(valores[i]);
            }


        }
    }
    class Empleados
    {
        public Empleados(String nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        string nombre;
        int edad;
    }

}