using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace Sistema_On_Tour.Vistas
{
    public partial class VentanaPrincipalEjecutivo : Form
    {
        public VentanaPrincipalEjecutivo()
        {
            InitializeComponent();
        }

        private void BtnDepositos_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaRegistrarApoderado v = new VentanaRegistrarApoderado();
            v.Show();
        }

        private void BtnContratos_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaPaquetes v = new VentanaPaquetes();
            v.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnInformaciones_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaInformacionesEjecutivo v = new VentanaInformacionesEjecutivo();
            v.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
