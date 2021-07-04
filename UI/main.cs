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

        private void btnNuevoViaje_Click(object sender, EventArgs e)
        {
            formNuevoViaje f = new formNuevoViaje();
            f.ShowDialog();
        }

        private void btnNuevaMoto_Click(object sender, EventArgs e)
        {
            formNuevoMotoquero f = new formNuevoMotoquero();
            f.ShowDialog();
        }
    }
}
