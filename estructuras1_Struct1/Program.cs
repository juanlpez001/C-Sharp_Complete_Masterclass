using System;

namespace estructuras1_Struct1
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado(1200, 250);

            empleado1.cambiaSalario(empleado1, 200);

            Console.WriteLine(empleado1);
        }
    }

    public class Empleado //internamente se está almacenando en el stack
        //los cambios que hagamos solo se van a reflejar en la estructura (se hace una copia)
    {
        public double salarioBase, comision;

        public Empleado(int salarioBase, int comision)
        {
            this.salarioBase = salarioBase;

            this.comision = comision; 
        }

        public override string ToString()
        {
            return string.Format("Salario y comisión del empleado ({0}, {1})", this.salarioBase, this.comision);
        }

        public void cambiaSalario(Empleado emp, double incremento)
        {
            emp.salarioBase += incremento;

            emp.comision += incremento; 
        }
    }
} 
