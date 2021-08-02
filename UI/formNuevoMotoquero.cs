using CapaNegocio;
using System;
using System.Windows.Forms;
namespace UI
{
    public partial class formNuevoMotoquero : Form
    {
        private Motoquero obj;
        public formNuevoMotoquero()
        {
            InitializeComponent();
        }
        private void formNuevoMotoquero_Load(object sender, EventArgs e)
        {
            dgvMotoqueros.DataSource = Motoquero.Buscar(txtBuscar.Text);
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            SetDatos();
            obj.Guardar();
            MessageBox.Show("Guardado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            pnlAddMoto.Enabled = false;
            Clear();
            Search();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            obj = new Motoquero();
            pnlAddMoto.Enabled = true;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Clear();
            pnlAddMoto.Enabled = false;
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
                    Motoquero m = dgvMotoqueros.CurrentRow.DataBoundItem as Motoquero;
                    m.Eliminar();
                    Search();
                    MessageBox.Show(m.Nombre + " " + m.Apellido + " fue eliminado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Debe seleccionar una fila antes de eliminar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    obj = dgvMotoqueros.CurrentRow.DataBoundItem as Motoquero;
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
            dgvMotoqueros.DataSource = Motoquero.Buscar(txtBuscar.Text);
        }

        private void CargarDatosText() {
            txtNomMoto.Text = obj.Nombre;
            txtApeMoto.Text = obj.Apellido;
            txtModeloMoto.Text = obj.ModeloMoto;
            numCelMoto.Value = obj.NumCelular;

        }
        #endregion

    }
}
