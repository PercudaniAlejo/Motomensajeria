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
    public partial class FormConFiltro : Form
    {
        public FormConFiltro()
        {
            InitializeComponent();
        }

        private void FormConFiltro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DSEnvios.DSFiltrado' Puede moverla o quitarla según sea necesario.
          
            cmbMotoqueros.DataSource = Motoquero.Buscar();
            Cargar();
        }

        private void Cargar() {
            if (cmbMotoqueros.SelectedItem != null)
            {
                int idM = (cmbMotoqueros.SelectedItem as Motoquero).Id;
                this.DSFiltradoTableAdapter.Connection.ConnectionString = ConexionCN.StrConexion();
                this.DSFiltradoTableAdapter.Fill(this.DSEnvios.DSFiltrado, idM);

                this.rv.RefreshReport();
            }
        }

        private void cmbMotoqueros_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
