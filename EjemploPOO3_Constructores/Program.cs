using System;

namespace EjemploPOO3_Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            //una vez hecho todo, vamos a construir el coche. 
            Coche coche1 = new Coche();
            //Nombre de la clase      //Nombre Objeto/instancia   = new nombre constructor; 
            //esto crea un objeto o instancia perteneciente a la clase coche.
            //le dimos un estado inicial al coche. 

            Coche coche2 = new Coche();
            Console.WriteLine(coche1.getRuedas());   //para ver cuantas ruedas tiene, no podemos acceder ya que ruedas 
                                                     // está en private

            Console.WriteLine(coche1.getInformacionCoche()); //Muestra información del coche


            /*NOTA: no es bueno poner en public las propiedades sino que hay que crear un metodo de acceso. 
            porque se podrá modificar con public en la propiedad la propiedad*/ 
        }
    }
    class Coche
    {   //Constructor y que sea accesible desde fuera de la clase 
        public Coche()
        {
            //comportamientos iniciales. 
            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;


        }
        //Metodo de acceso 
        public int getRuedas() //metodos getter son metodos que nos dan información de propiedades. 
        {
            return ruedas;
        }

        public String getInformacionCoche()  /*Tambien podemos crear un metodo get para que muestre informacion concatenando
                                             propiedaddes del coche y retornandolas*/
        {
        return ("La información del coche es la siguiente:\n"+"Ruedas: " +ruedas +" Largo: "+largo+ " Ancho: "+ancho );
        }




        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;  //algunos coches tienen y otros no V o F; 
        private string tapiceria; 



    }
}
