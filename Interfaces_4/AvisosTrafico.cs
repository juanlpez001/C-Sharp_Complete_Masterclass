using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_4
{
    class AvisosTrafico : IAvisos
    {
        public AvisosTrafico()
        {


            remitente = "Policia Transito y Transporte";

            mensaje = "Sanción comentida. Paguese antes de 3 días"; 

            fecha =  "";

        }

        public AvisosTrafico(string remitente, string mensaje, string fecha)
        {
            this.remitente = remitente; //almacenamos lo que pasemos como parametro en el campo de 
                                        //de clase remitente que se encuentra abajo 
            this.mensaje = mensaje;

            this.fecha = fecha; 
        }







        public string getFecha()
        {
            return fecha; //nos devolverá el valor que está almacenado en campo de clase fecha
        }

        public void mostrarAviso()
        {                    //0 correspondiente al primer argumento, 1 para el siguiente y 2 para el siguiente
            Console.WriteLine("Mensaje {0} ha sido enviado por {1} el día {2}", mensaje, remitente, fecha ); //argumentos de posicion 1,0,2
        }

        //campos de clase
        private string remitente;

        private string mensaje;

        private string fecha; 
    }
}
