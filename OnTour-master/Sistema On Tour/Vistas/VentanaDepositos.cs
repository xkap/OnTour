using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_On_Tour.Vistas
{
    public partial class VentanaDepositos : Form
    {
        public VentanaDepositos()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaPrincipalApoderado v = new VentanaPrincipalApoderado();
            v.Show();
        }

        private void BtnDepositar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaDepositar v = new VentanaDepositar();
            v.Show();
        }

        private void BtnListado_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaListadoDepositos v = new VentanaListadoDepositos();
            v.Show();
        }
    }
}
