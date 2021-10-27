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
    public partial class formViajes : Form
    {
        Envio objEnvio;
        public formViajes()
        {
            InitializeComponent();
            Search();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            objEnvio = null;
            formNuevoViaje n = new formNuevoViaje(objEnvio);
            n.ShowDialog();
            Search();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            objEnvio = Selected();
            formNuevoViaje n = new formNuevoViaje(objEnvio);
            n.ShowDialog();
            Search();
        }

        private void checkBoxViajesHoy_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxViajesHoy.Checked)
                dgvEnvios.DataSource = Envio.EnviosHoy();
            else
                dgvEnvios.DataSource = Envio.Buscar(txtBuscar.Text);
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                Search();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Search()
        {
            dgvEnvios.DataSource = Envio.Buscar(txtBuscar.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEnvios.CurrentRow != null)
                {
                    Envio envio = Envio.BuscarPorId((int)dgvEnvios.CurrentRow.Cells["ID"].Value);
                    if (MessageBox.Show("Eliminar el envio con ID: " + envio.IdEnvio.ToString(), "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        envio.Eliminar();
                        MessageBox.Show("Envio eliminado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Search();
                    }
                }
                else
                    MessageBox.Show("Debe seleccionar una fila antes de eliminar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Envio Selected() {
            if (dgvEnvios.CurrentRow != null) {
                objEnvio = Envio.BuscarPorId((int)dgvEnvios.CurrentRow.Cells["ID"].Value);
                return objEnvio;
            }
            return null;
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            objEnvio = Selected();
            formDetallesEnvio d = new formDetallesEnvio(objEnvio);
            d.ShowDialog();
        }

        private void btnReportViajes_Click(object sender, EventArgs e)
        {
            formVisorViajesHoy f = new formVisorViajesHoy();
            f.ShowDialog();
        }
    }
}
