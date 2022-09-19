using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;
namespace Conexion
{
   public class MarcaDatos
    {

        public List<Marca> Listar()
        {
            List<Marca> Listar = new List<Marca>();
            AccesoSQL Datos = new AccesoSQL();

            try
            {
                //Faltaba el alias de Descripcion "Marca" (Select Id,Descripcion from MARCAS)
                Datos.Consulta("Select Id,Descripcion as Marca from MARCAS");
                Datos.EjecutarLectura();

                while (Datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)Datos.Lector["Id"];
                    aux.Descripcion = (string)Datos.Lector["Marca"];
                    Listar.Add(aux);

                }

                return Listar;
            }

            catch (Exception ex)
            {
                
                throw ex;
            }
            finally
            {
                Datos.CerrarConexion();
            }

        }


    }
}
