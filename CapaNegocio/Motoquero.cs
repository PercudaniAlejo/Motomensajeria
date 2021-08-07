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
        //private static List<Motoquero> motos = new List<Motoquero>();
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int NumCelular { get => numCelular; set => numCelular = value; }
        public string ModeloMoto { get => modeloMoto; set => modeloMoto = value; }
        //public static List<Motoquero> Motos { get => motos; set => motos = value; }
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
            return string.Concat(nombre, " ", apellido);
        }

        public void Guardar() {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            eMotoquero motoquero = new eMotoquero();

            if (this.id == 0)
            {
                CargaFilaMotoquero(motoquero);
                dc.eMotoquero.InsertOnSubmit(motoquero);
            }
            else { 
                motoquero = (from x in dc.eMotoquero where x.id == this.id select x).FirstOrDefault();
                CargaFilaMotoquero(motoquero);
            }
            dc.SubmitChanges();
        }

        private void CargaFilaMotoquero(eMotoquero motoquero) {
            motoquero.nombre = this.nombre;
            motoquero.apellido = this.apellido;
            motoquero.numCelular = this.numCelular;
            motoquero.modeloMoto = this.modeloMoto;
        }

        public static List<Motoquero> Buscar(string buscado)
        {
            List<Motoquero> resultados = new List<Motoquero>();
            buscado = buscado.ToLower();

            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var filas = from x in dc.eMotoquero
                        where x.id.ToString().Contains(buscado) || 
                              x.apellido.ToLower().Contains(buscado) || 
                              x.nombre.ToLower().Contains(buscado) || 
                              x.modeloMoto.ToLower().Contains(buscado)
                        select x;

            if (filas != null)
            {
                foreach (var f in filas)
                {
                    resultados.Add(new Motoquero(f.id, f.nombre, f.apellido, f.numCelular, f.modeloMoto));
                }
            }

            return resultados;

        }

        public void Eliminar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var enc = (from x in dc.eMotoquero where x.id == this.id select x).FirstOrDefault();
            if (enc != null)
            {
                dc.eMotoquero.DeleteOnSubmit(enc);
                dc.SubmitChanges();
            }
            else
            {
                throw new Exception("No se pudo eliminar el dato, no fue encontrado el id: " + this.id);
            }
        }
        #endregion
    }
}
