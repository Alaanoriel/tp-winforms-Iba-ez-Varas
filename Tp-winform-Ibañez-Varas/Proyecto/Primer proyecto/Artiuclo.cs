using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_proyecto
{
    class Artiuclo
    {
        private string nombre;
        private string codigo;
        private string descripcion;
        private decimal precio;
        private string urlimagen;
        


        public string Nombre
        {
            set
            {
                try
                {
                    nombre = value;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            get { return nombre; }
        }
        public string Codigo
        {
            set
            {
                try
                {
                    codigo = value;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            get { return codigo; }
        }
        public string Descripcion
        {
            set
            {
                try
                {
                    descripcion = value;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            get { return descripcion; }
        }
        public decimal Precio
        {
            set
            {
                try
                {
                    precio = value;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            get { return precio; }
        }
        public string UrlImagen
        {
            set
            {
                try
                {
                    urlimagen = value;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            get { return urlimagen; }
        }
    }
}