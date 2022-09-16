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
        private float precio;
        private string imagen;
        private string marca;
        //private string categoria;


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
        public float Precio
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
        public string Imagen
        {
            set
            {
                try
                {
                    imagen = value;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            get { return imagen; }
        }
        public string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                try
                {
                    marca = value;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }
        //public string Categoria
        //{
        //    get { return categoria; }

        //    set
        //    {
        //        try
        //        {
        //            categoria = value;
        //        }
        //        catch (Exception ex)
        //        {

        //            throw ex;
        //        }
        //    }
        //}
    }
}