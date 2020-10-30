using System;

namespace genericos3_restricciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //almacena elementos de tipo Director, nombreinstancia =new AlmacenEmpleados de director van a ser 3
            AlmacenEmpeados<Director> miEmpleado = new AlmacenEmpeados<Director>(3);

            //3 directores:
            //agregamos un nuevo director con su respectivo salario 
            miEmpleado.agregar(new Director(4500));
            //agregamos un nuevo director con su respectivo salario 
            miEmpleado.agregar(new Director(5500));
            //agregamos un nuevo director con su respectivo salario 
            miEmpleado.agregar(new Director(6500));

            //RESTRICCIONES:
            //no podemos agregar clase estudiante 
            //AlmacenEmpeados<Estudiante> miEmpleado = new AlmacenEmpeados<Estudiante>(3);
            //no implementa la interfaz ni salario
        }



    }

    class AlmacenEmpeados<T> where T: IParaEmpleados //restriccion
    {

        public AlmacenEmpeados(int z) //recibe por parametro un entero
        {
            datosEmpleado = new T[z]; //es un array de genericos con z elementos
        }

        public void agregar( T obj) //metodo de agregar elementos de cualquier tipo obj
        {
            datosEmpleado[i] = obj; //es igual al metodo que le pasamos por parametro

            i++; //incrementamos la variable en 1, almacena un objeto en la posicion 0, luego 1 segun vayamos almacenando 
        }

        public T getEmpleado(int i)
        {
            return datosEmpleado[i]; //nos devuelve una posicion del array de genericos
        }

        private int i = 0; //variable contador

        private T[] datosEmpleado;  //array de tipo generico para almacenar objetos de diferente tipo
        
    }



    class Director: IParaEmpleados
    {
        public Director(double salario)
        {
            this.salario = salario; 
        }

        private double salario;

        public double getSalario()
        {
            return salario; 
        }
    }




    class Secretaria: IParaEmpleados
    {
        public Secretaria(double salario)
        {
            this.salario = salario;
        }

        private double salario;

        public double getSalario()
        {
            return salario; 
        }
    }



    class Electricista: IParaEmpleados
    {
        public Electricista(double salario)
        {
            this.salario = salario;
        }

        private double salario;

        public double getSalario()
        {
            return salario; 
        }
    }


    class Estudiante //no está heredando la interfaz IParaEmpleados ni salario
    {
        public Estudiante(double edad)
        {

            this.edad = edad; 
        }

        public double getEdad()
        {
            return edad;
        }
        
        
        private double edad; 
    }




    interface IParaEmpleados
    {
        double getSalario();  //obligo a que todas las clases que implementen esta interfaz
                              //desarrollen el metodo getSalario()
    }
}
