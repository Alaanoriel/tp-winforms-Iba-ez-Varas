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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventana_agregar Agregar = new Ventana_agregar();
            try
            {
                Agregar.ShowDialog();
            }
            catch (Exception ex)
            {
                Agregar.Close();
                MessageBox.Show("Error en Ventana Agregar");
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventana_Buscar Buscar = new Ventana_Buscar();

            try
            {
                Buscar.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Ventana Busqueda");
                Buscar.Close();
            }
            
        }
    }
}
