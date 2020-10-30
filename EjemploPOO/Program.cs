using System;

namespace EjemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo; //creacion de objeto de tipo circulo o variable objeto de tipo circulo.
                               // es de tipo circulo
            miCirculo = new Circulo(); // iniciacion de variable/objeto de tipo circulo
                                       // ya le dimos valor a la variable miCirculo, esto se le llama instancia o ejemplarización 

            //3. 
            Console.WriteLine(miCirculo.calculoArea(3));  //1. Encapsulación no se puede acceder a la clase Circulo.

            Circulo miCirculo2 = new Circulo();  //un segundo objeto perteneciente a la clase Circulo.

            Console.WriteLine(miCirculo2.calculoArea(9));  //segundo objeto con comportamiento calculoArea. 

            
        }

    }

    class Circulo
    {
        const double pi = 3.1416;  //Propiedad de la clase circulo. Esto es un campo de clase.
                                   //si le agregamos const, ese valor no se podrá cambiar el valor de pi 

        public double calculoArea(int radio) //2. si le antecedemos la palabra public a double podemos acceder a esta clase
                                             //desde otra
        {

            return pi * radio * radio;
        }


    }
    //Circulo tiene la propiedad pi y el metodo calculoArea

    //Circulo <- es la clase 
    //miCirculo1, miCirculo2<-Son objetos
}
