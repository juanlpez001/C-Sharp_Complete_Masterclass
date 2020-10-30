using System;

namespace genericos2_II
{
    class Program
    {
        static void Main(string[] args)
        {
            //7. Ejecutarla 
            //AlmacenaObjetos<Empleado> miAlmacen = new AlmacenaObjetos<Empleado>(4); //le indicamos por instancia el numero de elementos que queremos
            AlmacenaObjetos<String> miAlmacen = new AlmacenaObjetos<String>(4);
            //agregar un objeto de tipo string por ejeemplo: 

            miAlmacen.agregar("Juan");
            miAlmacen.agregar("Pablo");
            miAlmacen.agregar("JoJo");

            //la variable persona me va a mostrar lo que hay en la posición 2 del arreglo 

            //String nombrePersona = (archivos.getElemento(2)); 
            /*Nos genera un error porque no se puede almacenar un Object en una variable tipo String 
             * nos obliga a utilizar casting para almacenarlo */

            String nombrePersona = miAlmacen.getElemento(2); //forma correcta agregando (String)
            Console.WriteLine(nombrePersona);

            // Casting: 
            //Empleado salarioEmpleado = (Empleado)miAlmacen.getElemento(2);
            //Console.WriteLine(salarioEmpleado.getSalario());
        }
    }
    //1.
    class AlmacenaObjetos<T>
    {
        //2. constructor
        public AlmacenaObjetos(int z)
        {
            //4. 
            datosElemento = new T[z]; //datos elemento = new objecto de z que es el parametro
                                           //que le estamos pasando al constructor y que vamos a instanciar


        }
        //5. metodo para agregar elementos
        public void agregar(T obj)
        {
            datosElemento[i] = obj; //en datos elemento va a almacenar el objeto que le de por parametro obj
            i++; //despues incrementar i en 1 
        }

        //6. metodo para mostrar elementos 
        public T getElemento(int i)
        {
            return datosElemento[i]; //nos devolverá el objeto que le indiquemos por parametro
        }

        //3. campos encapsulados 
        private T[] datosElemento;  //quiero que el array almacene cualquier tipo de datos

        private int i = 0; //contador iniciado en 0 almacenando posiciones de arrays en un elemento


    }

    class Empleado
    {
        public Empleado(double salario)
        {
            this.salario = salario; //campo de clase salario será igual a lo que almacenemos por parametro salario
        }

        public double getSalario()
        {
            return salario;  //metodo get para devolver salario 
        }

        private double salario;
    }


}
