﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private double precioViaje;
        private double precioFinal;
        private int fkMotoquero;
        private Motoquero motoquero;
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
        public double PrecioViaje { get => precioViaje; set => precioViaje = value; }
        public double PrecioFinal { get => precioFinal; set => precioFinal = value; }

        [Browsable(false)]
        public int FkMotoquero { get => fkMotoquero; set => fkMotoquero = value; }
        public Motoquero Motoquero {
            get {
                if (fkMotoquero != 0 && motoquero == null)
                    motoquero = Motoquero.BuscarPorId(fkMotoquero);
                return motoquero;
            }
            set {
                motoquero = value;
                fkMotoquero = value.Id;
            }
        }


        #endregion

        #region BUILDERS
        public Envio(int idEnvio, DateTime fecha, string nombreCliente,
            string apellidoCliente, int numCelCliente, string domicEntrega,
            string localidadEntrega, int unidades, bool fragil,
            double precioViaje, double precioFinal, int fkMotoquero)
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
            this.precioViaje = precioViaje;
            this.precioFinal = precioFinal;
            this.fkMotoquero = fkMotoquero;
        }

        public Envio() {
            idEnvio = 0;
            fecha = DateTime.Today;
            nombreCliente = "";
            apellidoCliente = "";
            numCelCliente = 0;
            domicEntrega = "";
            localidadEntrega = "";
            unidades = 1;
            fragil = false;
            precioViaje = 0.0;
            precioFinal = 0.0;
            fkMotoquero = 0;
        }
        #endregion

        #region METHODS
        public static List<Envio> Buscar(string buscado)
        {
            List<Envio> resultados = new List<Envio>();
            buscado = buscado.ToLower();

            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var filas = from x in dc.eEnvio
                        where x.idEnvio.ToString().Contains(buscado) ||
                              x.nombreCliente.ToLower().Contains(buscado) ||
                              x.apellidoCliente.ToLower().Contains(buscado) ||
                              x.domicEntrega.ToLower().Contains(buscado) ||
                              x.localidadEntrega.ToLower().Contains(buscado) ||
                              x.eMotoquero.nombre.ToLower().Contains(buscado) ||
                              x.eMotoquero.apellido.ToLower().Contains(buscado) 
                        select x;

            if (filas != null)
            {
                foreach (var f in filas)
                {
                    resultados.Add(new Envio(f.idEnvio, f.fecha, f.nombreCliente, f.apellidoCliente,
                                            f.numCelCliente, f.domicEntrega, f.localidadEntrega,
                                            f.unidades, f.fragil, f.precioViaje, f.precioFinal, f.FKMotoquero));
                }
            }

            return resultados;
        }
        public static List<Envio> EnviosHoy() {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            List<Envio> resultados = new List<Envio>();
            DateTime dateNow = DateTime.Today;
            var filasEnviosHoy = from x in dc.eEnvio
                        where x.fecha.Year == dateNow.Year &&
                        x.fecha.Month == dateNow.Month &&
                        x.fecha.Day == dateNow.Day select x
                        ;
            foreach (var f in filasEnviosHoy)
            {
                resultados.Add(new Envio(f.idEnvio, f.fecha, f.nombreCliente, f.apellidoCliente,
                                            f.numCelCliente, f.domicEntrega, f.localidadEntrega,
                                            f.unidades, f.fragil, f.precioViaje, f.precioFinal, f.FKMotoquero));               
            }
            return resultados;
        }
        public static List<Motoquero> CargarComboMotos()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            List<Motoquero> motoqueros = new List<Motoquero>();

            var filasMotoqueros = from x in dc.eMotoquero select x;
            foreach (var f in filasMotoqueros)
            {
                motoqueros.Add(new Motoquero(f.id, f.nombre, f.apellido, f.numCelular, f.modeloMoto));
            }
            return motoqueros;
        }
        public void CargaFilaEnvio(eEnvio envio) {
            envio.idEnvio = this.IdEnvio;
            envio.fecha = this.Fecha;
            envio.nombreCliente = this.NombreCliente;
            envio.apellidoCliente = this.ApellidoCliente;
            envio.numCelCliente = this.NumCelCliente;
            envio.domicEntrega = this.DomicEntrega;
            envio.localidadEntrega = this.LocalidadEntrega;
            envio.unidades = this.Unidades;
            envio.fragil = this.Fragil;
            //envio.idMotoquero = this.IdMotoquero;
            envio.precioViaje = this.PrecioViaje;
            envio.precioFinal = this.PrecioFinal;
            envio.FKMotoquero = this.fkMotoquero;
        }
        public void Guardar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            eEnvio envio = new eEnvio();

            if (this.idEnvio == 0)
            {
                CargaFilaEnvio(envio);
                dc.eEnvio.InsertOnSubmit(envio);
            }
            else {
                envio = (from x in dc.eEnvio where x.idEnvio == this.idEnvio select x).FirstOrDefault();
                CargaFilaEnvio(envio);
            }
            dc.SubmitChanges();
        }
        public void Eliminar()
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var enc = (from x in dc.eEnvio where x.idEnvio == this.idEnvio select x).FirstOrDefault();
            if (enc != null)
            {
                dc.eEnvio.DeleteOnSubmit(enc);
                dc.SubmitChanges();
            }
            else
            {
                throw new Exception("No se pudo eliminar el dato, no fue encontrado el id: " + this.idEnvio);
            }
        }

        #endregion
    }
}
