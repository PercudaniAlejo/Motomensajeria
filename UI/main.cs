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
            formNuevoMotoquero f = new formNuevoMotoquero();
            f.ShowDialog();
        }

        private void btnNuevoViaje_Click_1(object sender, EventArgs e)
        {
            formNuevoViaje f = new formNuevoViaje();
            f.ShowDialog();
        }
    }
}
