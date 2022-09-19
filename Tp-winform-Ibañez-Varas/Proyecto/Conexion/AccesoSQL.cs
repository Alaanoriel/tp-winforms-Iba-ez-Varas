using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Conexion
{
    public class AccesoSQL
    {

        private SqlConnection Conexion;
        private SqlCommand Comando;
        private SqlDataReader lector;


        public SqlDataReader Lector
        {
            get { return lector; }

        }

        public AccesoSQL()
        {
            //Constructor sobrecargado
            Conexion = new SqlConnection("server =.\\SQLEXPRESS; database = CATALOGO_DB; integrated security = true");
            Comando = new SqlCommand();

        }

        public void Consulta(string consulta)
        {

            Comando.CommandType = System.Data.CommandType.Text;
            Comando.CommandText = consulta;


        }


        public void EjecutarLectura()
        {
            Comando.Connection = Conexion;
            try
            {
                Conexion.Open();
                lector = Comando.ExecuteReader();

            }
            catch(Exception ex)
            {
                throw ex;

            }
        }

        public void EjecutarAccion() 
        {
            Comando.Connection = Conexion;
      
            try
            {
                Conexion.Open();
                Comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        
        }

        public void SetParametros(string Nombre, object Valor) 
        {
            Comando.Parameters.AddWithValue(Nombre,Valor);
        
        
        }

        public void CerrarConexion()
        {

            if (lector != null)
                lector.Close();
            Conexion.Close();
        }



    }
}
