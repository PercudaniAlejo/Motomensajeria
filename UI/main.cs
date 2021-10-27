using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void btnNuevaMoto_Click_1(object sender, EventArgs e)
        {
            formMotoqueros f = new formMotoqueros();
            f.ShowDialog();
        }

        private void btnNuevoViaje_Click_1(object sender, EventArgs e)
        {
            formViajes f = new formViajes();
            f.ShowDialog();
        }

        private void btnGanancia_Click(object sender, EventArgs e)
        {
            formGanancia f = new formGanancia();
            f.ShowDialog();
        }

        private void main_Load(object sender, EventArgs e)
        {
        }
    }
}
