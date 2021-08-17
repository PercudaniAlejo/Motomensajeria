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
    public partial class formViajesMoto : Form
    {
        private Motoquero obj;
        public formViajesMoto(Motoquero objEnvio = null)
        {
            InitializeComponent();
            obj = objEnvio;
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
        private void FormViajesMoto_Load(object sender, EventArgs e)
        {
            Search();
        }
        private void Search()
        {
            dgvViajesMotos.DataSource = Envio.EnviosPorMoto(obj);
        }

    }
}
