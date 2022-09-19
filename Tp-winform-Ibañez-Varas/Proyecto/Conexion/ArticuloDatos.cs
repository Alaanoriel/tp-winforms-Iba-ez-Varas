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
            AccesoSQL Datos = new AccesoSQL();
            try
            {
                Datos.Consulta("Select A.Codigo, A.Nombre, A.Descripcion, A.ImagenUrl, A.Precio , C.Descripcion Tipo, M.Descripcion Marca From ARTICULOS A  Inner Join MARCAS M on A.IdMarca = M.Id Inner Join CATEGORIAS C on A.IdCategoria = C.Id");
                Datos.EjecutarLectura();
                while (Datos.Lector.Read())
                {
                    Artiuclo aux = new Artiuclo();
                    aux.Codigo = (string)Datos.Lector["Codigo"];
                    aux.Nombre = (string)Datos.Lector["Nombre"];
                    aux.Descripcion = (string)Datos.Lector["Descripcion"];
                    aux.UrlImagen = (string)Datos.Lector["ImagenUrl"];
                    aux.Precio = Decimal.Round((decimal)Datos.Lector["Precio"], 2);
                    aux.Tipo = new Categorias();
                    aux.Tipo.Descripcion = (string)Datos.Lector["Tipo"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)Datos.Lector["Marca"];



                    lista.Add(aux);
                }
                return lista;
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


        public void Agregar(Artiuclo Nuevo) 
        {

            AccesoSQL acceso = new AccesoSQL();

            try
            {

                acceso.Consulta("Insert into ARTICULOS(Codigo,Nombre,Descripcion,Precio,IdMarca,IdCategoria)values(" + Nuevo.Codigo + ",'" + Nuevo.Nombre + "','" + Nuevo.Descripcion + "'," + Nuevo.Precio + ", @IdMarca,@IdCategoria)");
                acceso.SetParametros("@IdMarca", Nuevo.Marca.Id);
                acceso.SetParametros("@IdCategoria", Nuevo.Tipo.Id);
                acceso.EjecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally 
            {
                acceso.CerrarConexion();
            }
        }
    
        public List<Artiuclo> Buscar(string TipoBusqueda, string Valor)
        {
            List<Artiuclo> busqueda = new List<Artiuclo>();
            AccesoSQL Datos = new AccesoSQL();
            try
            {
                Datos.Consulta("Select A.Codigo, A.Nombre, A.Descripcion, A.ImagenUrl, A.Precio , C.Descripcion Tipo, M.Descripcion Marca From ARTICULOS A  Inner Join MARCAS M on A.IdMarca = M.Id Inner Join CATEGORIAS C on A.IdCategoria = C.Id Where " + TipoBusqueda + " LIKE '" + Valor + "'");
                Datos.EjecutarLectura();
                while(Datos.Lector.Read())
                {
                    Artiuclo aux = new Artiuclo();
                    aux.Codigo = (string)Datos.Lector["Codigo"];
                    aux.Nombre = (string)Datos.Lector["Nombre"];
                    aux.Descripcion = (string)Datos.Lector["Descripcion"];
                    aux.UrlImagen = (string)Datos.Lector["ImagenUrl"];
                    aux.Precio = Decimal.Round((decimal)Datos.Lector["Precio"], 2);
                    aux.Tipo = new Categorias();
                    aux.Tipo.Descripcion = (string)Datos.Lector["Tipo"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)Datos.Lector["Marca"];

                    busqueda.Add(aux);
                }
                return busqueda;
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


