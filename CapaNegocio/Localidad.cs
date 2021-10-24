using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
    public class Localidad
    {
        #region VM
        private int id;
        private string nombre;
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        #endregion  

        #region BUILDERS
        public Localidad(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public Localidad()
        {
            id = 0;
            nombre = "";
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return string.Concat(nombre);
        }

        public void Guardar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            eLocalidad localidad = new eLocalidad();

            if (this.id == 0)
            {
                localidad.nombre = this.nombre;
                dc.eLocalidad.InsertOnSubmit(localidad);
            }
            else
            {
                localidad = (from x in dc.eLocalidad where x.id == this.id select x).FirstOrDefault();
                localidad.nombre = this.nombre;
            }
            dc.SubmitChanges();
        }

        public static List<Localidad> Buscar(string buscado = "")
        {
            buscado = buscado.ToLower();
            List<Localidad> resultados = new List<Localidad>();
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var filas = from x in dc.eLocalidad
                        where x.nombre.ToLower().Contains(buscado)
                        select x;

            if (filas != null)
            {
                foreach (var f in filas)
                {
                    resultados.Add(new Localidad(f.id, f.nombre));
                }
            }
            return resultados;
        }

        public void Eliminar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var enc = (from x in dc.eLocalidad where x.id == this.id select x).FirstOrDefault();
            if (enc != null)
            {
                dc.eLocalidad.DeleteOnSubmit(enc);
                dc.SubmitChanges();
            }
            else
            {
                throw new Exception("No se pudo eliminar el dato, no fue encontrado el id: " + this.id);
            }
        }

        public static Localidad BuscarPorId(int idBuscado)
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var enc = (from x in dc.eLocalidad where x.id == idBuscado select x).FirstOrDefault();
            if (enc != null)
                return new Localidad(enc.id, enc.nombre);
            return null;
        }
        #endregion
    }
}
