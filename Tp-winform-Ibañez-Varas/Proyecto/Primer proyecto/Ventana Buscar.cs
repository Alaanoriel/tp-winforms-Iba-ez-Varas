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
        public Ventana_Buscar()
        {
            InitializeComponent();
        }

        private void Ventana_Buscar_Load(object sender, EventArgs e)
        {
            try
            {
                ArticuloDatos datos = new ArticuloDatos();
                dgvDatos.DataSource = datos.Listar();
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la carga de datos");
                throw;
            }
            
        }
    }
}
