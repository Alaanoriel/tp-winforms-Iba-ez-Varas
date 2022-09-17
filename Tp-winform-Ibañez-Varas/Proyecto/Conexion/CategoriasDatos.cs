using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Conexion
{
   public class CategoriasDatos
    {
        public List<Categorias>Listar()
        {
            List<Categorias> Listar = new List<Categorias>();
            AccesoSQL Datos = new AccesoSQL();

            try
            {
                Datos.Consulta("Select Id, Descripcion From CATEGORIAS");
                Datos.EjecutarLectura();
               
                while (Datos.lector.Read())
                {
                    Categorias aux = new Categorias();
                    aux.Id = (int)Datos.lector["Id"];
                    aux.Descripcion = (string)Datos.lector["Tipo"];
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
