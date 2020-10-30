using System;

namespace gettersySetters
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Coche coche1 = new Coche();

            Coche coche2 = new Coche();
            Console.WriteLine(coche1.getRuedas());   //para ver cuantas ruedas tiene, no podemos acceder ya que ruedas 
                                                     // está en private

            Console.WriteLine(coche1.getInformacionCoche()); //Muestra información del coche


            Coche coche3 = new Coche(4.25, 1200.35);   //Son los parametros que quise poner largo y ancho, son los unicos qu van a cambiar
                                                       //va a seguir teniendo la misma cantidad de ruedas pero modificando el largo y ancho
            Console.WriteLine(coche3.getInformacionCoche());

            /*NOTA: no es bueno poner en public las propiedades sino que hay que crear un metodo de acceso. 
            porque se podrá modificar con public en la propiedad la propiedad*/


            coche3.setExtraCoche(true, "cuero"); //asi le asignamos los valores con set 

            //después va a devolver el metodo getExtraCoche; 
           

                Console.WriteLine(coche3.getExtraCoche());
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
            tapiceria = "tela";


            

            

        }
        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;

            largo = largoCoche; //largo va a ser igual al parametro que le voy a pasar a Coche 
            ancho = anchoCoche;  //ancho va a ser igual al parametro que ponga en Coche 
        }
        //Metodo de acceso 
        public int getRuedas() //metodos getter son metodos que nos dan información de propiedades. 
        {
            return ruedas;
        }

        public String getInformacionCoche()  /*Tambien podemos crear un metodo get para que muestre informacion concatenando
                                             propiedaddes del coche y retornandolas*/
        {
            return ("La información del coche es la siguiente:\n" + "Ruedas: " + ruedas + " Largo: " + largo + " Ancho: " + ancho);
        }
        //Metodo Setter : dedicados a establecer propiedades 
        //Los setter no tienen que retornar un valor, tienen que establecer un valor 

        public void setExtraCoche(bool paramClimatizador, String paramTapiceria) //Planeamos almacenar si el coche tiene o no climatizador 
                                                                                 //y tapiceria que es tipo string
        {
            climatizador = paramClimatizador; //almacenamos en climatizador el parametro paramClimatizador

            tapiceria = paramTapiceria; //lo mismo para tapiceria 
        }
        //a continuacion creamos un metodo que nos devolverá el set
        public String getExtraCoche()
        {
            return "Extras del coche: \n" + "Tapiceria: " + tapiceria + " Climatizador: " + climatizador; 

        }

        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;  //algunos coches tienen y otros no V o F; 
        private string tapiceria;



    }

}

//Al ejecutar el programa tapiceria saldrá vacio y climatizador como false  es porque no hemos especificado el 
// el valor de las variables tapiceria y climatizador el valor por defecto de boolean es false y de string es vacío