using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace Sistema_On_Tour.Vistas
{
    public partial class VentanaContratos : Form
    {
        public VentanaContratos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaPrincipalApoderado v = new VentanaPrincipalApoderado();
            v.Show();
        }

        private void BtnDescargarCont_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contrato descargado");
        }

        private void BtnDescargarCond_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Condiciones Descargadas");
        }

        private void BtnDescargarPlan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Planes de Acción en caso de Emergencia descargados");
        }
    }
}
