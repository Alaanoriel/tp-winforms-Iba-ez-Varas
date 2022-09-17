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
    public partial class Ventana_Buscar : Form
    {
        private List<Artiuclo> listaArticulos;
        private void CargarImagen(string imagen)
        {
            try
            {
                pbxImagen.Load(imagen);
            }
            catch (Exception ex)
            {

                pbxImagen.Load("https://media.istockphoto.com/vectors/thumbnail-image-vector-graphic-vector-id1147544807?k=20&m=1147544807&s=612x612&w=0&h=pBhz1dkwsCMq37Udtp9sfxbjaMl27JUapoyYpQm0anc=");
            }
        }


        public Ventana_Buscar()
        {
            InitializeComponent();
        }

        private void Ventana_Buscar_Load(object sender, EventArgs e)
        {
            try
            {
                ArticuloDatos datos = new ArticuloDatos();
                listaArticulos = datos.Listar();
                dgvDatos.DataSource = listaArticulos;
                dgvDatos.Columns["UrlImagen"].Visible = false;
               CargarImagen(listaArticulos[0].UrlImagen);
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la carga de datos");
                throw;
            }
            
        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {           
            Artiuclo Seleccionado = (Artiuclo)dgvDatos.CurrentRow.DataBoundItem;
            CargarImagen(Seleccionado.UrlImagen);
    

        }

        
    }
}
