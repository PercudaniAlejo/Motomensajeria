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
        public formNuevoMotoquero()
        {
            InitializeComponent();
        }

        private void btnAddMoto_Click(object sender, EventArgs e)
        {
            Save();
            Clear();
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
        #endregion

    }
}
