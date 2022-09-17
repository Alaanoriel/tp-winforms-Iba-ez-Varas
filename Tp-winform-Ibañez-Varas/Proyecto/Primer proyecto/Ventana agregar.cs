using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;


namespace Primer_proyecto
{
    public partial class Ventana_agregar : Form
    {
        public Ventana_agregar()
        {
            InitializeComponent();
        }

        private void Txtbox_CodigoArticulo_TextChanged(object sender, EventArgs e)
        {
         ///Clicklee mal xd
        }

        private void Button_Agregar_Click(object sender, EventArgs e)
        {
            Artiuclo Producto = new Artiuclo();

            try
            {
                Producto.Codigo = Txtbox_CodigoArticulo.Text;
                Producto.Nombre = Txtbox_Nombre.Text;
                // Producto.Precio = int.Parse(Txtbox_Precio);
                Producto.Descripcion = Txtbox_Descripcion.Text;


            }

            catch
            {


            }
                    


        }
    }
}
