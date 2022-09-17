using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Clases;

namespace Conexion
{
    public class ArticuloDatos
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
                comando.CommandText = "Select Codigo, Nombre, A.Descripcion, ImagenUrl, Precio, B.Descripcion Tipo, C.Descripcion Marca From ARTICULOS A, Categorias B, Marcas C Where A.Id = B.Id and B.Id = C.Id";
                comando.Connection = conexion;
                
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Artiuclo aux = new Artiuclo();
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.UrlImagen = (string)lector["ImagenUrl"];
                    aux.Precio = Decimal.Round((decimal)lector["Precio"], 2);
                    aux.Tipo = new Categorias();
                    aux.Tipo.Descripcion = (string)lector["Tipo"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)lector["Marca"];



                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            
        }
    }



}


