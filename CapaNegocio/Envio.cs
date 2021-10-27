using System;
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
        private Cliente cliente;
        private string nombreCliente;
        private string apellidoCliente;
        private int numCelCliente;
        private string domicEntrega;
        private Localidad localidadEntrega;
        private int unidades;
        private Boolean fragil;
        private double precioViaje;
        private double precioFinal;
        private Motoquero motoquero;
        #endregion

        #region PROPERTIES
        public int IdEnvio { get => idEnvio; set => idEnvio = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidoCliente { get => apellidoCliente; set => apellidoCliente = value; }
        public int NumCelCliente { get => numCelCliente; set => numCelCliente = value; }
        public string DomicEntrega { get => domicEntrega; set => domicEntrega = value; }
        public Localidad LocalidadEntrega { get => localidadEntrega; set => localidadEntrega = value; }
        public int Unidades { get => unidades; set => unidades = value; }
        public bool Fragil { get => fragil; set => fragil = value; }
        public double PrecioViaje { get => precioViaje; set => precioViaje = value; }
        public double PrecioFinal { get => precioFinal; set => precioFinal = value; }
        public Motoquero Motoquero { get => motoquero; set => motoquero = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }


        #endregion

        #region BUILDERS
        public Envio(int idEnvio, DateTime fecha, string nombreCliente,
            string apellidoCliente, int numCelCliente, string domicEntrega,
            Localidad localidadEntrega, int unidades, bool fragil,
            double precioViaje, double precioFinal, Motoquero motoquero, Cliente cliente)
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
            this.motoquero = motoquero;
            this.cliente = cliente;
        }

        public Envio() {
            idEnvio = 0;
            fecha = DateTime.Today;
            nombreCliente = "";
            apellidoCliente = "";
            numCelCliente = 0;
            domicEntrega = "";
            localidadEntrega = null;
            unidades = 1;
            fragil = false;
            precioViaje = 0.0;
            precioFinal = 0.0;
            motoquero = null;
            cliente = null;
        }
        #endregion

        #region METHODS
        public static IQueryable Buscar(string buscado)
        {
            buscado = buscado.ToLower();

            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var filas = from x in dc.eEnvio
                        where x.idEnvio.ToString().Contains(buscado) ||
                              x.nombreCliente.ToLower().Contains(buscado) ||
                              x.apellidoCliente.ToLower().Contains(buscado) ||
                              x.domicEntrega.ToLower().Contains(buscado) ||
                              x.eLocalidad.nombre.ToLower().Contains(buscado) ||
                              x.eMotoquero.nombre.ToLower().Contains(buscado) ||
                              x.eMotoquero.apellido.ToLower().Contains(buscado) ||
                              x.eClienteFijo.nombreCliente.ToLower().Contains(buscado) ||
                              x.eClienteFijo.apellidoCliente.ToLower().Contains(buscado)
                        select new {
                            ID = x.idEnvio,
                            Cliente = x.nombreCliente + ", " + x.apellidoCliente.ToUpper(),
                            Celular = x.numCelCliente,
                            Fecha = x.fecha,
                            Domicilio = x.domicEntrega,
                            Localidad = x.eLocalidad.nombre,
                            Motoquero = x.eMotoquero.nombre + ", " + x.eMotoquero.apellido.ToUpper(),
                            Precio = "$ " + (int)x.precioFinal
                        };
            return filas;
        }
        public static IQueryable EnviosHoy() {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            DateTime dateNow = DateTime.Today;
            var filasEnviosHoy = from x in dc.eEnvio
                        where x.fecha.Year == dateNow.Year &&
                        x.fecha.Month == dateNow.Month &&
                        x.fecha.Day == dateNow.Day 
                        select new
                        {
                            ID = x.idEnvio,
                            Cliente = x.nombreCliente + ", " + x.apellidoCliente.ToUpper(),
                            Celular = x.numCelCliente,
                            Fecha = x.fecha,
                            Domicilio = x.domicEntrega,
                            Localidad = x.eLocalidad.nombre,
                            Motoquero = x.eMotoquero.nombre + ", " + x.eMotoquero.apellido.ToUpper(),
                            Precio = "$ " + (int)x.precioFinal
                        }; 
            return filasEnviosHoy;
        }
        public static IQueryable EnviosPorMoto(Motoquero objM) {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var filasEnviosPorMoto = from x in dc.eEnvio
                                 where x.FKMotoquero == objM.Id
                                 select new {
                                     ID = x.idEnvio,
                                     Cliente = x.nombreCliente + ", " + x.apellidoCliente.ToUpper(),
                                     Celular = x.numCelCliente,
                                     Fecha = x.fecha,
                                     Domicilio = x.domicEntrega,
                                     Localidad = x.eLocalidad.nombre,
                                     Motoquero = x.eMotoquero.nombre + ", " + x.eMotoquero.apellido.ToUpper(),
                                     Precio = "$ " + (int)x.precioFinal
                                 };
            return filasEnviosPorMoto;
        }

        public static IQueryable EnviosHoyPorMoto(Motoquero objM)
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            DateTime dateNow = DateTime.Today;
            var filasEnviosHoy = from x in dc.eEnvio
                                 where x.fecha.Year == dateNow.Year &&
                                 x.fecha.Month == dateNow.Month &&
                                 x.fecha.Day == dateNow.Day && 
                                 x.FKMotoquero == objM.Id
                                 select new
                                 {
                                     ID = x.idEnvio,
                                     Cliente = x.nombreCliente + ", " + x.apellidoCliente.ToUpper(),
                                     Celular = x.numCelCliente,
                                     Fecha = x.fecha,
                                     Domicilio = x.domicEntrega,
                                     Localidad = x.eLocalidad.nombre,
                                     Motoquero = x.eMotoquero.nombre + ", " + x.eMotoquero.apellido.ToUpper(),
                                     Precio = "$ " + (int)x.precioFinal
                                 };
            return filasEnviosHoy;
        }
        public static IQueryable Ganancias() {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var filasGanancia = from x in dc.eEnvio
                                 group x by x.fecha into Fecha                             
                                select new
                                 {
                                     Fecha = Fecha.Key,
                                     Total = Fecha.Sum(x => x.precioFinal)
                                 };
            return filasGanancia;
        }
        public void CargaFilaEnvio(eEnvio envio) {
            envio.idEnvio = this.IdEnvio;
            envio.fecha = this.Fecha;
            envio.nombreCliente = this.NombreCliente;
            envio.apellidoCliente = this.ApellidoCliente;
            envio.numCelCliente = this.NumCelCliente;
            envio.domicEntrega = this.DomicEntrega;
            envio.idLocalidadEntrega = this.localidadEntrega.Id;
            envio.idClienteFijo = this.cliente.Id;
            envio.unidades = this.Unidades;
            envio.fragil = this.Fragil;
            envio.precioViaje = this.PrecioViaje;
            envio.precioFinal = this.PrecioFinal;
            envio.FKMotoquero = this.motoquero.Id;
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
        public static Envio BuscarPorId(int idBuscado)
        {
            DCDataContext dc = new DCDataContext(Conexion.DarStrConexion());
            var enc = (from x in dc.eEnvio where x.idEnvio == idBuscado select x).FirstOrDefault();
            if (enc != null)
                return new Envio(enc.idEnvio, enc.fecha, enc.nombreCliente, enc.apellidoCliente, enc.numCelCliente,
                                enc.domicEntrega, Localidad.BuscarPorId(enc.idLocalidadEntrega), enc.unidades, enc.fragil, enc.precioViaje, 
                                enc.precioFinal, Motoquero.BuscarPorId(enc.FKMotoquero), Cliente.BuscarPorId(enc.idClienteFijo));
            return null;
        }

        #endregion
    }
}
