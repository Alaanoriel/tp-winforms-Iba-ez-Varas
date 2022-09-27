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
using Conexion;

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


        private void ActualizarListado(List<Artiuclo> artiuclos)
        {
            try
            {
                //Agregar columnas
                listaArticulos = artiuclos;
                dgvDatos.DataSource = listaArticulos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloDatos busqueda = new ArticuloDatos();
            try
            {
                
                string valorbuscado = txtbDatosABuscar.Text;
                string criterio = "";
                if (cbxTipoBusqueda.SelectedIndex==0)
                {
                    criterio = "A.ID";
                }else if (cbxTipoBusqueda.SelectedIndex == 1)
                {
                    criterio = "A.Nombre";
                }else if (cbxTipoBusqueda.SelectedIndex == 2)
                {
                    criterio = "C.Descripcion";
                }else if (cbxTipoBusqueda.SelectedIndex == 3)
                {
                    criterio = "M.Descripcion";
                }
                if(criterio=="")
                {
                    MessageBox.Show("Por favor seleccione un cirterio de busqueda");
                    return;
                }
                ActualizarListado(busqueda.Buscar(criterio, valorbuscado));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloDatos datos = new ArticuloDatos();
            Artiuclo seleccionado;
            try
            {
                seleccionado = (Artiuclo)dgvDatos.CurrentRow.DataBoundItem;
                datos.Eliminar(seleccionado.ID);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                ActualizarListado(datos.Listar());
            }
        }
    }
}
