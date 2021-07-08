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
        Motoquero obj = new Motoquero();
        public formNuevoViaje()
        {
            InitializeComponent();
        }
        private void btnOkEnvio_Click(object sender, EventArgs e)
        {
            Save();
        }
      

        #region METHODS
        private void Save()
        {
            Envio e = new Envio(0, dtpFecha.Value, txtNomCliente.Text, txtApeCliente.Text,
                                (int)numCelCliente.Value, txtDomicilio.Text, txtLocalidad.Text,
                                (int)numUnidades.Value, checkFragil.Checked,
                                (double)numPrecioViaje.Value, (double)numPrecioFinal.Value);
            e.Guardar();
            MessageBox.Show("Guardado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        #endregion
    }
}
