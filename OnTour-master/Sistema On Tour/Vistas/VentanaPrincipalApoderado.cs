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
    public partial class VentanaPrincipalApoderado : Form
    {
        public VentanaPrincipalApoderado()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaContratos v = new VentanaContratos();
            v.Show();
               
        }

        private void BtnDepositos_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaDepositos v = new VentanaDepositos();
            v.ShowDialog();
        }

        private void BtnInformaciones_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaInformacionesApoderado v = new VentanaInformacionesApoderado();
            v.Show();
        }
    }
}
