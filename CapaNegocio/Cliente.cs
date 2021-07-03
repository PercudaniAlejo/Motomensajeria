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
        private int numCelular; 
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int NumCelular { get => numCelular; set => numCelular = value; }
        #endregion

        #region BUILDERS
        public Cliente(int id, string nombre, string apellido, int numCelular) {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.numCelular = numCelular;
        }

        public Cliente() {
            id = 0;
            nombre = apellido =  "";
            numCelular = 0;
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return string.Concat(id, " - ", nombre, " ", apellido, " - ", numCelular);
        }

        public void Guardar() {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            eCliente cliente = new eCliente();
            cliente.nombre = this.nombre;
            cliente.apellido = this.apellido;
            cliente.numCelular = this.numCelular;

            dc.eCliente.InsertOnSubmit(cliente);
            dc.SubmitChanges();
        }
        #endregion
    }
}
