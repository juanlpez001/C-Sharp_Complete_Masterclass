using System;
using System.Collections.Generic;
using System.Text;

namespace clasesAnonimasPOO
{
    class Punto
    {
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;

            contadorDeObjetos++;
        }

        public Punto()
        {
            this.x = 0;
            this.y = 0;

            contadorDeObjetos++;

        }
        //metodo para acceder 
        public static int ContadorDeObjetos()
        {
            //nos devolverá un valor entero
            return contadorDeObjetos;
        }




        public double DistanciaHasta(Punto otroPunto) //Estamos como poniendo como parametro un objeto (otroPunto) 
        { //no hay diferencia entre un objeto y String

            //https://docs.microsoft.com/es-mx/dotnet/api/system.math?view=netcore-3.1
            int xDif = this.x - otroPunto.x;  //a las cornedadas x e y le restamos las coordenadas de otroPunto que es el destino

            int yDif = this.y - otroPunto.y;

            double distanciaPuntos = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2)); /*Teorema de pitagoras
            el cuadrado de la hipotenusa es igual a la suma de los cuadrados de los catetos*/

            return distanciaPuntos;

        }
        private int x, y;

        private static int contadorDeObjetos = 0;
    }
}





