using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaNegocio;

namespace UI
{
    public partial class formNuevoViaje : Form
    {
        Envio obj;
        public formNuevoViaje(Envio objEnvio = null)
        {
            InitializeComponent();
            obj = objEnvio;
        }
        private void formNuevoViaje_Load(object sender, EventArgs e)
        {
            if (obj != null)
                CargarDatosModificar(obj);
            else
                obj = new Envio();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            SetDatos();
            obj.Guardar();
            MessageBox.Show("Viaje registrado correctamente correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Clear();
            this.Close();
        }
     
        #region METHODS
        private void SetDatos()
        {
            obj.ApellidoCliente = txtApeCliente.Text;
            obj.NombreCliente = txtNomCliente.Text;
            obj.NumCelCliente = (int)numCelCliente.Value;
            obj.Fecha = dtpFecha.Value;
            obj.DomicEntrega = txtDomicilio.Text;
            obj.LocalidadEntrega = txtLocalidad.Text;
            obj.Unidades = (int)numUnidades.Value;
            obj.Fragil = checkFragil.Checked;
            obj.PrecioViaje = (int)numPrecioViaje.Value;
            obj.PrecioFinal = (int)numPrecioFinal.Value;
        }

        private void Clear()
        {
            dtpFecha.Value = DateTime.Now;
            txtNomCliente.Text = "";
            txtApeCliente.Text = "";
            numCelCliente.Value = 0;
            txtDomicilio.Text = "";
            txtLocalidad.Text = "";
            numUnidades.Value = 0;
            checkFragil.Checked = false;
            numPrecioViaje.Value = 0;
            numPrecioFinal.Value = 0;
        }

        private void CargarDatosModificar(Envio obj)
        {
            txtApeCliente.Text = obj.ApellidoCliente;
            txtNomCliente.Text = obj.NombreCliente;
            txtDomicilio.Text = obj.DomicEntrega;
            txtLocalidad.Text = obj.LocalidadEntrega;
            dtpFecha.Value = obj.Fecha;
            numCelCliente.Value = (int)obj.NumCelCliente;
            numUnidades.Value = (int)obj.Unidades;
            checkFragil.Checked = obj.Fragil;
            numPrecioViaje.Value = (int)obj.PrecioViaje;
            numPrecioFinal.Value = (int)obj.PrecioFinal;
        }

        #endregion
    }
}
