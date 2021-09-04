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
    public partial class formGanancia : Form
    {
        public formGanancia()
        {
            InitializeComponent();
        }

        private void formFinanzas_Load(object sender, EventArgs e)
        {
            dgvGanancias.DataSource = null;
            dgvGanancias.DataSource = Envio.Ganancias();
        }
    }
}
