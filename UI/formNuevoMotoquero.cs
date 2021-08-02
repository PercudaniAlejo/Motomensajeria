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
    public partial class formNuevoMotoquero : Form
    {
        private Motoquero obj;
        public formNuevoMotoquero()
        {
            InitializeComponent();
            dgvMotoqueros.DataSource = Motoquero.Buscar(txtBuscar.Text);
        }

        private void btnAddMoto_Click(object sender, EventArgs e)
        {
            Save();
            Clear();
            Search();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
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

        #region METHODS
        private void Save() {
            Motoquero m = new Motoquero(0, txtNomMoto.Text, txtApeMoto.Text,
                                            (int)numCelMoto.Value, txtModeloMoto.Text);
            m.Guardar();
            MessageBox.Show("Guardado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        #endregion


    }
}
