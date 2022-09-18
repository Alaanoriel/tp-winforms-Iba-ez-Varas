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
                Datos.Consulta("Select Id,Descripcion from MARCAS");
                Datos.EjecutarLectura();

                while (Datos.lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)Datos.lector["Id"];
                    aux.Descripcion = (string)Datos.lector["Marca"];
                    Listar.Add(aux);

                }

                return Listar;
            }

            catch (Exception ex)

            {

                throw ex;
            }

        }


    }
}
