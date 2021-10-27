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
    public partial class formClientes : Form
    {
        private Cliente obj;
        public formClientes()
        {
            InitializeComponent();
            Buscar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Clear();
            obj = new Cliente();
            pnlDatos.Enabled = true;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            obj = dgvClientes.CurrentRow.DataBoundItem as Cliente;
            txtNombre.Text = obj.Nombre;
            txtApellido.Text = obj.Apellido;
            numCelular.Value = obj.Celular;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Clear();
            pnlDatos.Enabled = false;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text != "" && txtApellido.Text != "" && numCelular.Value != 0)
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
                    MessageBox.Show("Complete los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex){ 
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        #region METHODS
        private void Clear()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            numCelular.Value = 0;
        }
        private void SetDatos()
        {
            obj.Nombre = txtNombre.Text;
            obj.Apellido = txtApellido.Text;
            obj.Celular = (int)numCelular.Value;
        }
        private void Buscar()
        {
            dgvClientes.DataSource = Cliente.Buscar(txtBuscar.Text);
        }
        #endregion

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.CurrentRow != null)
                {
                    Cliente c = dgvClientes.CurrentRow.DataBoundItem as Cliente;
                    if (MessageBox.Show("Eliminar a: " + c.Nombre + " " + c.Apellido, "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        c.Eliminar();
                        MessageBox.Show(c.Nombre + " " + c.Apellido + " fue eliminado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Buscar();
                    }
                }
                else
                    MessageBox.Show("Debe seleccionar una fila antes de eliminar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Elimine todos los envios relacionados con el cliente antes de eliminarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
