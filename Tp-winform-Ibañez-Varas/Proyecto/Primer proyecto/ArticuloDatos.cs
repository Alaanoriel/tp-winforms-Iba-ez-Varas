using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Primer_proyecto
{
    class ArticuloDatos
    {
        public List<Artiuclo> Listar()
        {
            ///Objetos de SQL
            List<Artiuclo> lista = new List<Artiuclo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            ///Variable lectora
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Codigo, Nombre, Descripcion, ImagenUrl, Precio From ARTICULOS";
                comando.Connection = conexion;
                
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Artiuclo aux = new Artiuclo();
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Imagen = (string)lector["ImagenUrl"];
                    aux.Precio = (float)lector["Precio"];
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            
        }
    }
}
