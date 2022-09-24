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

        private Artiuclo Producto = null;
        public Ventana_agregar()
        {
            InitializeComponent();
        }

        public Ventana_agregar(Artiuclo Producto)
        {
            InitializeComponent();
            this.Producto = Producto;
            Text = "Modificar producto";
        }

        private void Txtbox_CodigoArticulo_TextChanged(object sender, EventArgs e)
        {
         ///Clicklee mal xd
        }

        private void Button_Agregar_Click(object sender, EventArgs e)
        {
            //Artiuclo Producto = new Artiuclo();
            ArticuloDatos Dato = new ArticuloDatos();

            try
            {
                if (Producto == null)
                    Producto = new Artiuclo();


                Producto.Codigo = Txtbox_CodigoArticulo.Text;
                Producto.Nombre = Txtbox_Nombre.Text;
                Producto.Precio = Convert.ToDecimal(Txtbox_Precio.Text);
                Producto.Descripcion = Txtbox_Descripcion.Text;
                Producto.UrlImagen = Txtbox_Urlimagen.Text;
                Producto.Marca = (Marca)ComboBox_Marca.SelectedItem;
                Producto.Tipo = (Categorias)ComboBox_Categoria.SelectedItem;

                if(Producto.ID != 0)
                {
                    Dato.Modificar(Producto);
                    MessageBox.Show("Modifico con exito");


                }

                else

                {

                    Dato.Agregar(Producto);
                    MessageBox.Show("Agregado con exito");

                }

               
                

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
               
                ComboBox_Categoria.DataSource = Categoria.Listar();
                ComboBox_Categoria.ValueMember = "Id";
                ComboBox_Categoria.DisplayMember = "Descripcion";
                ComboBox_Marca.DataSource = Marca.Listar();
                ComboBox_Marca.ValueMember = "Id";
                ComboBox_Marca.DisplayMember = "Descripcion";

                if (Producto != null) 
                {
                    Txtbox_CodigoArticulo.Text = Producto.Codigo;
                    Txtbox_Nombre.Text = Producto.Nombre;
                    //Producto.Precio = Convert.ToDecimal(Txtbox_Precio.Text); Ver esto despues.
                    Txtbox_Descripcion.Text = Producto.Descripcion;
                    Txtbox_Urlimagen.Text = Producto.UrlImagen;
                    CargarImagen(Producto.UrlImagen);
                    ComboBox_Categoria.SelectedValue = Producto.Tipo.Id;
                    ComboBox_Marca.SelectedValue = Producto.Marca.Id;
                
                
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void Txtbox_Urlimagen_Leave(object sender, EventArgs e)
        {


            CargarImagen(Txtbox_Urlimagen.Text);

        }


        private void CargarImagen(string imagen)
        {
            try
            {
                PictureBox_Urlimagen.Load(imagen);
            }
            catch (Exception ex)
            {

                PictureBox_Urlimagen.Load("https://media.istockphoto.com/vectors/thumbnail-image-vector-graphic-vector-id1147544807?k=20&m=1147544807&s=612x612&w=0&h=pBhz1dkwsCMq37Udtp9sfxbjaMl27JUapoyYpQm0anc=");
            }
        }
    }
}
