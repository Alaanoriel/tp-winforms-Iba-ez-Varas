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
                //Faltaba el alias de Descripcion "Tipo" (Select Id,Descripcion From CATEGORIAS)
                Datos.Consulta("Select Id,Descripcion as Tipo From CATEGORIAS");
                Datos.EjecutarLectura();
               
                while (Datos.Lector.Read())
                {
                    Categorias aux = new Categorias();
                    aux.Id = (int)Datos.Lector["Id"];
                    aux.Descripcion = (string)Datos.Lector["Tipo"];
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
