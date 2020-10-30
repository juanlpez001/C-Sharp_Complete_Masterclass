using System;

namespace Arrays4_BucleForeach
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
            arrayEmpleados[1] = new Empleados("Juan", 18);

            /*Array de tipos o clases anonimas*/

            /* 
            *var personas = new[]
            {
                new{Nombre="Juan", Edad=19 },

                new{Nombre="Maria", Edad=49},

                new{Nombre="Pablo", Edad=35}

            };
            Console.WriteLine(personas[1]); */
            //ARRAY VALORES 



            for (int i = 0; i <arrayEmpleados.Length; i++) /*longitud del array, va a ir hasta la longitud del array. si hay 400 
                                                      elementos, entonces valores irá hasta la posición 400 sirve si no sabemos la longitud del array*/
                                                    
            {
                Console.WriteLine(arrayEmpleados[i].getInfo()); /*Lo mejor es poner las variables en private y hacer un metodo get para acceder a la información
                                                                 sin modificarla*/           
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
        //acceso variables

            //metodo get para acceder a variables private
        public string getInfo()
        {
            return "Nombre del Empleado: " + nombre + " Edad del empleado: " + edad; 
        }
        private string nombre;
        private int edad;
    }

}


