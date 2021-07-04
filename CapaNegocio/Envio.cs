﻿using System;
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

        private string nombreCliente;
        private string apellidoCliente;
        private int numCelCliente;

        private string domicEntrega;
        private string localidadEntrega;
        private int unidades;
        private Boolean fragil;
        private int idMotoquero;
        private double precioViaje;
        private double precioFinal;
        #endregion

        #region PROPERTIES
        public int IdEnvio { get => idEnvio; set => idEnvio = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidoCliente { get => apellidoCliente; set => apellidoCliente = value; }
        public int NumCelCliente { get => numCelCliente; set => numCelCliente = value; }
        public string DomicEntrega { get => domicEntrega; set => domicEntrega = value; }
        public string LocalidadEntrega { get => localidadEntrega; set => localidadEntrega = value; }
        public int Unidades { get => unidades; set => unidades = value; }
        public bool Fragil { get => fragil; set => fragil = value; }
        public int IdMotoquero { get => idMotoquero; set => idMotoquero = value; }
        public double PrecioViaje { get => precioViaje; set => precioViaje = value; }
        public double PrecioFinal { get => precioFinal; set => precioFinal = value; }

        #endregion

        #region BUILDERS
        public Envio(int idEnvio, DateTime fecha, string nombreCliente,
            string apellidoCliente, int numCelCliente, string domicEntrega,
            string localidadEntrega, int unidades, bool fragil, int idMotoquero,
            double precioViaje, double precioFinal)
        {
            this.idEnvio = idEnvio;
            this.fecha = fecha;
            this.nombreCliente = nombreCliente;
            this.apellidoCliente = apellidoCliente;
            this.numCelCliente = numCelCliente;
            this.domicEntrega = domicEntrega;
            this.localidadEntrega = localidadEntrega;
            this.unidades = unidades;
            this.fragil = fragil;
            this.idMotoquero = idMotoquero;
            this.precioViaje = precioViaje;
            this.precioFinal = precioFinal;
        }

        public Envio() {
            idEnvio = 0;
            fecha = DateTime.Now;
            nombreCliente = "";
            apellidoCliente = "";
            numCelCliente = 0;
            domicEntrega = "";
            localidadEntrega = "";
            unidades = 1;
            fragil = false;
            idMotoquero = 0;
            precioViaje = 0.0;
            precioFinal = 0.0;
        }
        #endregion

        #region METHODS
        public void Guardar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            eEnvio envio = new eEnvio();
            envio.idEnvio = this.IdEnvio;
            envio.fecha = this.Fecha;
            envio.nombreCliente = this.NombreCliente;
            envio.apellidoCliente = this.ApellidoCliente;
            envio.numCelCliente = this.NumCelCliente;
            envio.domicEntrega = this.DomicEntrega;
            envio.localidadEntrega = this.LocalidadEntrega;
            envio.unidades = this.Unidades;
            envio.fragil = this.Fragil;
            envio.idMotoquero = this.IdMotoquero;
            envio.precioViaje = this.PrecioViaje;
            envio.precioFinal = this.PrecioFinal;

            dc.eEnvio.InsertOnSubmit(envio);
            dc.SubmitChanges();
        }

        #endregion
    }
}
