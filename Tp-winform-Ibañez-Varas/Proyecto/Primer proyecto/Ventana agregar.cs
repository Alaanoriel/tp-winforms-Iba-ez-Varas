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
            ArticuloDatos Dato = new ArticuloDatos();

            try
            {
                
                Producto.Codigo = Txtbox_CodigoArticulo.Text;
                Producto.Nombre = Txtbox_Nombre.Text;
                Producto.Precio = Convert.ToDecimal(Txtbox_Precio.Text);
                Producto.Descripcion = Txtbox_Descripcion.Text;
                Producto.Marca = (Marca)ComboBox_Marca.SelectedItem;
                Producto.Tipo = (Categorias)ComboBox_Categoria.SelectedItem;
                Dato.Agregar(Producto);
                MessageBox.Show("Agregado con exito");
                

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
                    


        }

        private void Ventana_agregar_Load(object sender, EventArgs e)
        {
            CategoriasDatos Categoria = new CategoriasDatos();
            MarcaDatos Marca = new MarcaDatos();

            try
            {
                ///Error en "AccesoSQL"  get { return lector; } StackOverFlowException
                ComboBox_Categoria.DataSource = Categoria.Listar();
                ComboBox_Marca.DataSource = Marca.Listar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
