using CapaNegocio;
using System;
using System.Windows.Forms;
namespace UI
{
    public partial class formMotoqueros : Form
    {
        private Motoquero obj;
        public formMotoqueros()
        {
            InitializeComponent();
        }
        private void formNuevoMotoquero_Load(object sender, EventArgs e)
        {
            Search();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNomMoto.Text != "" && txtApeMoto.Text != "" &&
                    numCelMoto.Value != 0 && txtModeloMoto.Text != "")
                {
                    SetDatos();
                    obj.Guardar();
                    MessageBox.Show("Guardado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pnlAddMoto.Enabled = false;
                    Clear();
                    Search();
                }
                else
                {
                    MessageBox.Show("Campos incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Clear();
            obj = new Motoquero();
            pnlAddMoto.Enabled = true;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Clear();
            pnlAddMoto.Enabled = false;
        }
        private void btnViajes_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMotoqueros.CurrentRow != null)
                {
                    obj = Selected();
                    formViajesMoto f = new formViajesMoto(obj);
                    f.ShowDialog();
                }
                else
                    MessageBox.Show("Seleccione una fila.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
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
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMotoqueros.CurrentRow != null)
                {
                    Motoquero m = Motoquero.BuscarPorId((int)dgvMotoqueros.CurrentRow.Cells["ID"].Value);
                    if (MessageBox.Show("Eliminar a: " + m.Nombre + " " + m.Apellido, "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        m.Eliminar();
                        MessageBox.Show(m.Nombre + " " + m.Apellido + " fue eliminado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Search();
                    }
                }
                else
                    MessageBox.Show("Debe seleccionar una fila antes de eliminar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Elimine todos los envios relacionados con el motoquero antes de eliminarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMotoqueros.CurrentRow != null)
                {
                    obj = Motoquero.BuscarPorId((int)dgvMotoqueros.CurrentRow.Cells["ID"].Value);
                    CargarDatosText();
                    pnlAddMoto.Enabled = true;
                }
                else
                    MessageBox.Show("Debe seleccionar una fila antes de modificar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region METHODS

        private void SetDatos() {
            obj.Nombre = txtNomMoto.Text;
            obj.Apellido = txtApeMoto.Text;
            obj.ModeloMoto = txtModeloMoto.Text;
            obj.NumCelular = (int)numCelMoto.Value;
        }
        private void Clear() {
            txtNomMoto.Text = "";
            txtApeMoto.Text = "";
            numCelMoto.Value = 0;
            txtModeloMoto.Text = "";
        }
        private void Search() {
            dgvMotoqueros.DataSource = Motoquero.BuscarIQ(txtBuscar.Text);
        }
        private void CargarDatosText() {
            txtNomMoto.Text = obj.Nombre;
            txtApeMoto.Text = obj.Apellido;
            txtModeloMoto.Text = obj.ModeloMoto;
            numCelMoto.Value = obj.NumCelular;

        }
        private Motoquero Selected()
        {
            if (dgvMotoqueros.CurrentRow != null) {
                Motoquero m = Motoquero.BuscarPorId((int)dgvMotoqueros.CurrentRow.Cells["ID"].Value);
                return m;
            }
            return null;
        }
        #endregion

        private void btnInforme_Click(object sender, EventArgs e)
        {
            FormConFiltro f = new FormConFiltro();
            f.ShowDialog();
        }
    }
}