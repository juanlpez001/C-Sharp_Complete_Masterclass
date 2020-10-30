using System;

namespace propiedades2_Properties2
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado Juan = new Empleado("Juan");
            //PARA ESTABLECER UN SALARIO:
            Juan.SALARIO = 1200;

            //para incrementarle 500: 
            Juan.SALARIO += 500;
            Console.WriteLine("El salario del empleado es: " + Juan.SALARIO);




        }
    }
    class Empleado
    {
        public Empleado(string nombreEmpleado)
        {
            this.nombreEmpleado = nombreEmpleado;
        }
        /*
        public void setSalario(double salario)
        {
            if(salario < 0)
            {
                Console.WriteLine("El salario no puede ser negativo, se asignará 0 como salario");
                this.salario = 0; 

            }
            else
            {
                this.salario = salario; 
            }

        }

        public double getSalario()
        {
            return salario; 
        }
        */
        //en caso de quere utilizar properties podemos construir el programa de la siguiente manera:
        //crar un metodo encapsulado de tipo double que va a evaluar el salario que hemos dado al empleado con parametro salario 
        private double evaluaSalario(double salario)
        {
            if (salario < 0) return 0;
            else return salario;
        }

        //CREACIÓN DE PROPIEDAD 
        //nos va a permitir acceder a la propiedad como si fuera un public pero nos permitirá 
        //violar reglas que no queremos (if de más arriba) 

        //modificador de acceso, tipo, y por convencion en MAYUSCULAS NOMBRE
        /*
        public double SALARIO
        {
            //crear un get y un set 
            get { return this.salario; } //que nos devuelva el valor del salario

            set { this.salario = evaluaSalario(value); } //decirle que salario es igual al metodo evaluaSalario
                                                         //a la hora de pasarle un parametro utilizamos la palabra reservada value
        }

        */

        //podemos utilizar expression body operacion lambda 
        //basicamente estamos haciendo lo mismo pero con otra nomenclatura
        public double SALARIO
        {

            get => this.salario;

            set => this.salario = evaluaSalario(value); 
        }

        private double salario;
        private string nombreEmpleado;
    }





}
