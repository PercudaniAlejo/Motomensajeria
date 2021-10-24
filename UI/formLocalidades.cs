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
    public partial class formLocalidades : Form
    {
        private Localidad obj;
        public formLocalidades()
        {
            InitializeComponent();
            Buscar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Clear();
            obj = new Localidad();
            pnlDatos.Enabled = true;
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLocalidades.CurrentRow != null)
                {
                    Localidad l = dgvLocalidades.CurrentRow.DataBoundItem as Localidad;
                    if (MessageBox.Show("Eliminar la localidad: " + l.Nombre, "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        l.Eliminar();
                        MessageBox.Show(l.Nombre + " fue eliminado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Buscar();
                    }
                }
                else
                    MessageBox.Show("Debe seleccionar una fila antes de eliminar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Elimine todos los envios relacionados con la localidad antes de eliminarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtLocalidad.Text != "")
            {
                SetDatos();
                obj.Guardar();
                MessageBox.Show("Guardado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pnlDatos.Enabled = false;
                Clear();
                Buscar();
            }
            else
            {
                MessageBox.Show("Campos incompletas", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            obj = dgvLocalidades.CurrentRow.DataBoundItem as Localidad;
            txtLocalidad.Text = obj.Nombre;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        #region METHODS
        private void Clear() {
            txtLocalidad.Text = "";
        }
        private void Buscar() {
            dgvLocalidades.DataSource = Localidad.Buscar(txtBuscar.Text);
        }
        private void SetDatos() {
            obj.Nombre = txtLocalidad.Text;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Clear();
            pnlDatos.Enabled = false;
        }
        #endregion

    }
}
