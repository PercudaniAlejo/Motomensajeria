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
    public partial class formVisorGanancias : Form
    {
        public formVisorGanancias()
        {
            InitializeComponent();
        }

        private void formVisorGanancia_Load(object sender, EventArgs e)
        {
            this.DSGananciaTableAdapter.Connection.ConnectionString = ConexionCN.StrConexion();
            this.DSGananciaTableAdapter.Fill(this.DSEnvios.DSGanancia);
            this.rvGanancias.RefreshReport();
        }
    }
}
