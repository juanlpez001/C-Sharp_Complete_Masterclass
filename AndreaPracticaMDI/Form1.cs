using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndreaPracticaMDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instancia nuevo formulario
            Form2 formularioNuevo = new Form2();

            // Lo define como hijo del principal.
            formularioNuevo.MdiParent = this;

            // Lo muestra
            formularioNuevo.Show(); 

        }
        Form3 formularioUnico; 
        private void unicoToolStripMenuItem_Click(object sender, EventArgs e)
        {    //Si aun no existe
            if (formularioUnico == null) 
            {
                //lo instancia
                formularioUnico = new Form3();

                // Lo define como hijo del principal.
                formularioUnico.MdiParent = this; 
                                                  //Define un nuevo manejador para el evento Close
                formularioUnico.FormClosed += new FormClosedEventHandler(formularioUnico_FormClosed);
                // Lo muestra
                formularioUnico.Show();
            }
            else
            {
                formularioUnico.Activate(); //Si ya existe, lo deja como formulario activo
            }
        }

        void formularioUnico_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Cierra y destruye el formulario
            formularioUnico = null; 
        }


    }
}

