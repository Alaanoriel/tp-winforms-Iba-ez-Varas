using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Artiuclo Producto = new Artiuclo();
            try
            {
               // Producto.Codigo = int.Parse(Txtbox_CodigoArticulo.Text);


            }

            catch 
            {
            
            
           
            
            }

        }
    }
}
