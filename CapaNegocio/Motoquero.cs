using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
    public class Motoquero
    {
        #region VM
        private int id;
        private string nombre;
        private string apellido;
        private int numCelular;
        private string modeloMoto;
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int NumCelular { get => numCelular; set => numCelular = value; }
        public string ModeloMoto { get => modeloMoto; set => modeloMoto = value; }
        #endregion

        #region BUILDERS
        public Motoquero(int id, string nombre, string apellido, int numCelular, string modeloMoto)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.numCelular = numCelular;
            this.ModeloMoto = modeloMoto;
        }

        public Motoquero() {
            id = 0;
            nombre = apellido =  "";
            numCelular = 0;
            ModeloMoto = "";
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return string.Concat(id, " - ", nombre, " ", apellido, " - ", numCelular);
        }

        public void Guardar() {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            eMotoquero motoquero = new eMotoquero();
            motoquero.nombre = this.nombre;
            motoquero.apellido = this.apellido;
            motoquero.numCelular = this.numCelular;
            motoquero.modeloMoto = this.modeloMoto;

            dc.eMotoquero.InsertOnSubmit(motoquero);
            dc.SubmitChanges();

        }
        #endregion
    }
}
