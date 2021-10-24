using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
    public class Cliente
    {
        #region VM
        private int id;
        private string nombre;
        private string apellido;
        private int celular;
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Celular { get => celular; set => celular = value; }
        #endregion

        #region BUILDERS
        public Cliente(int id, string nombre, string apellido, int celular)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.celular = celular;
        }

        public Cliente()
        {
            id = 0;
            nombre = "";
            apellido = "";
            celular = 0;
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return string.Concat(nombre + " " + apellido);
        }

        public void Guardar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            eClienteFijo cliente = new eClienteFijo();

            if (this.id == 0)
            {
                cliente.nombreCliente = this.nombre;
                cliente.apellidoCliente = this.apellido;
                cliente.numCelCliente = this.celular;
                dc.eClienteFijo.InsertOnSubmit(cliente);
            }
            else
            {
                cliente = (from x in dc.eClienteFijo where x.id == this.id select x).FirstOrDefault();
                cliente.nombreCliente = this.nombre;
                cliente.apellidoCliente = this.apellido;
                cliente.numCelCliente = this.celular;
            }
            dc.SubmitChanges();
        }

        public static List<Cliente> Buscar(string buscado = "")
        {
            buscado = buscado.ToLower();
            List<Cliente> resultados = new List<Cliente>();
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var filas = from x in dc.eClienteFijo
                        where x.nombreCliente.ToLower().Contains(buscado) ||
                        x.apellidoCliente.ToLower().Contains(buscado)
                        select x;

            if (filas != null)
            {
                foreach (var f in filas)
                {
                    if(f.id != -1)
                        resultados.Add(new Cliente(f.id, f.nombreCliente, f.apellidoCliente, (int)f.numCelCliente));
                }
            }
            return resultados;
        }

        public void Eliminar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var enc = (from x in dc.eClienteFijo where x.id == this.id select x).FirstOrDefault();
            if (enc != null)
            {
                dc.eClienteFijo.DeleteOnSubmit(enc);
                dc.SubmitChanges();
            }
            else
            {
                throw new Exception("No se pudo eliminar el dato, no fue encontrado el id: " + this.id);
            }
        }

        public static Cliente BuscarPorId(int idBuscado)
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var enc = (from x in dc.eClienteFijo where x.id == idBuscado select x).FirstOrDefault();
            if (enc != null)
                return new Cliente(enc.id, enc.nombreCliente, enc.apellidoCliente, (int)enc.numCelCliente);
            return null;
        }
        #endregion
    }
}
