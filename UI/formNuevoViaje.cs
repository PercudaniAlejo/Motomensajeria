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
        private Envio obj;
        bool nuevoCliente = true;
        public formNuevoViaje(Envio objEnvio = null)
        {
            InitializeComponent();
            obj = objEnvio;
        }
        private void formNuevoViaje_Load(object sender, EventArgs e)
        {
            CargarCMB();
            if (obj != null)
                CargarDatosModificar(obj);
            else
            { 
                Clear();
                obj = new Envio();
                CargarTXTCliente();
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNomCliente.Text != "" && txtApeCliente.Text != "" &&
                    numCelCliente.Value!= 0 && txtDomicilio.Text != "" &&
                    numUnidades.Value != 0 && numPrecioFinal.Value != 0)
                {
                    SetDatos();
                    obj.Guardar();
                    MessageBox.Show("Viaje registrado correctamente correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Clear();
            this.Close();
        }
        private void btnLocalidad_Click(object sender, EventArgs e)
        {
            formLocalidades f = new formLocalidades();
            f.ShowDialog();
            CargarCMB();
        }
        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            formClientes f = new formClientes();
            f.ShowDialog();
            CargarCMB();
        }
        private void btnAgregarMoto_Click(object sender, EventArgs e)
        {
            formMotoqueros f = new formMotoqueros();
            f.ShowDialog();
            CargarCMB();
        }
        private void chkNuevoCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNuevoCliente.Checked)
            {
                pnlCliente.Enabled = false;
                pnlNuevoCliente.Enabled = true;
                nuevoCliente = true;
                txtNomCliente.Text = "";
                txtApeCliente.Text = "";
                numCelCliente.Value = 0;
            }
            else {
                pnlCliente.Enabled = true;
                pnlNuevoCliente.Enabled = false;
                nuevoCliente = false;
                CargarTXTCliente();
            }
        }
        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!nuevoCliente)
                CargarTXTCliente();
        }

        #region METHODS
        private void SetDatos()
        {
            obj.ApellidoCliente = txtApeCliente.Text;
            obj.NombreCliente = txtNomCliente.Text;
            obj.NumCelCliente = (int)numCelCliente.Value;
            obj.Fecha = dtpFecha.Value;
            obj.DomicEntrega = txtDomicilio.Text;
            if (nuevoCliente)
                obj.Cliente = Cliente.BuscarPorId(-1);
            else
                obj.Cliente = cmbClientes.SelectedItem as Cliente;
            obj.LocalidadEntrega = cmbLocalidades.SelectedItem as Localidad;
            obj.Unidades = (int)numUnidades.Value;
            obj.Fragil = checkFragil.Checked;
            obj.PrecioViaje = (int)numPrecioViaje.Value;
            obj.PrecioFinal = (int)numPrecioFinal.Value;
            obj.Motoquero = cmbMotoquero.SelectedItem as Motoquero;
        }
        private void Clear()
        {
            dtpFecha.Value = DateTime.Today;
            txtNomCliente.Text = "";
            txtApeCliente.Text = "";
            numCelCliente.Value = 0;
            txtDomicilio.Text = "";
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
            if (obj.LocalidadEntrega != null)
                cmbLocalidades.Text = obj.LocalidadEntrega.ToString();
            dtpFecha.Value = obj.Fecha;
            numCelCliente.Value = (int)obj.NumCelCliente;
            numUnidades.Value = (int)obj.Unidades;
            checkFragil.Checked = obj.Fragil;
            numPrecioViaje.Value = (int)obj.PrecioViaje;
            numPrecioFinal.Value = (int)obj.PrecioFinal;
            if (obj.Motoquero != null)
                cmbMotoquero.Text = obj.Motoquero.ToString();
        }
        private void CargarCMB() {
            cmbMotoquero.DataSource = null;
            cmbMotoquero.DataSource = Motoquero.Buscar("");
            cmbLocalidades.DataSource = null;
            cmbLocalidades.DataSource = Localidad.Buscar("");
            cmbClientes.DataSource = Cliente.Buscar("");
        }
        private void CargarTXTCliente()
        {
            Cliente c = cmbClientes.SelectedItem as Cliente;
            txtNomCliente.Text = c.Nombre;
            txtApeCliente.Text = c.Apellido;
            numCelCliente.Value = c.Celular;
        }
        #endregion

    }
}
