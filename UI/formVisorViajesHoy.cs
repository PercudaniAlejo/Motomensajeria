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
    public partial class formVisorViajesHoy : Form
    {
        public formVisorViajesHoy()
        {
            InitializeComponent();
        }

        private void formVisorViajesHoy_Load(object sender, EventArgs e)
        {
            this.DSCompletoTableAdapter.Connection.ConnectionString = ConexionCN.StrConexion();
            this.DSCompletoTableAdapter.Fill(this.DSEnvios.DSCompleto);
            this.rvViajes.RefreshReport();
        }
    }
}
