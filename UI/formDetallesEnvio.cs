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
    public partial class formDetallesEnvio : Form
    {
        Envio obj;
        public formDetallesEnvio(Envio objEnvio = null)
        {
            InitializeComponent();
            obj = objEnvio;
        }

        private void formDetallesEnvio_Load(object sender, EventArgs e)
        {
            txtApeCliente.Text = obj.ApellidoCliente;
            txtNomCliente.Text = obj.NombreCliente;
            txtDomicilio.Text = obj.DomicEntrega;
            //txtLocalidad.Text = obj.LocalidadEntrega;
            dtpFecha.Value = obj.Fecha;
            numCelCliente.Value = (int)obj.NumCelCliente;
            numUnidades.Value = (int)obj.Unidades;
            checkFragil.Checked = obj.Fragil;
            numPrecioViaje.Value = (int)obj.PrecioViaje;
            numPrecioFinal.Value = (int)obj.PrecioFinal;
        }

        private void btnOkEnvio_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
