using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
    public class Envio
    {
        #region VM
        private int idEnvio;
        private DateTime fecha;
        private int idCliente;
        private string domicEntrega;
        private string localidadEntrega;
        private int unidades;
        private Boolean fragil;
        private double precioViaje;
        private double precioFinal;
        #endregion

        #region PROPERTIES
        public int IdEnvio { get => idEnvio; set => idEnvio = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string DomicEntrega { get => domicEntrega; set => domicEntrega = value; }
        public string LocalidadEntrega { get => localidadEntrega; set => localidadEntrega = value; }
        public int Unidades { get => unidades; set => unidades = value; }
        public bool Fragil { get => fragil; set => fragil = value; }
        public double PrecioViaje { get => precioViaje; set => precioViaje = value; }
        public double PrecioFinal { get => precioFinal; set => precioFinal = value; }
        #endregion

        #region BUILDERS
        public Envio(int idEnvio, DateTime fecha, int idCliente, string domicEntrega, string localidadEntrega,
                     int unidades, Boolean fragil, double precioViaje, double precioFinal)
        {
            this.idEnvio = idEnvio;
            this.fecha = fecha;
            this.idCliente = idCliente;
            this.domicEntrega = domicEntrega;
            this.localidadEntrega = localidadEntrega;
            this.unidades = unidades;
            this.fragil = fragil;
            this.precioViaje = precioViaje;
            this.precioFinal = precioFinal;
        }

        public Envio()
        {
            idEnvio = 0;
            fecha = DateTime.Now;
            idCliente = 0;
            domicEntrega = "";
            localidadEntrega = "";
            unidades = 1;
            fragil = true;
            precioViaje = 0.0;
            precioFinal = 0.0;
        }
        #endregion

        #region METHODS
        public void Guardar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            eEnvio envio = new eEnvio();
            envio.idEnvio = this.idEnvio;
            envio.fecha = this.fecha;
            envio.idCliente = this.idCliente;
            envio.domicEntrega = this.domicEntrega;
            envio.localidadEntrega = this.localidadEntrega;
            envio.unidades = this.unidades;
            envio.fragil = this.fragil;
            envio.precioViaje = this.precioViaje;
            envio.precioFinal = precioFinal;

            dc.eEnvio.InsertOnSubmit(envio);
            dc.SubmitChanges();
        }

        #endregion
    }
}
