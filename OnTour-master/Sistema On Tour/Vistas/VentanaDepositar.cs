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
    public partial class VentanaDepositar : Form
    {
        public VentanaDepositar()
        {
            InitializeComponent();
        }

        private void VentanaDepositar_Load(object sender, EventArgs e)
        {

        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaDepositos v = new VentanaDepositos();
            v.Show();
        }

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaDepositoRealizado v = new VentanaDepositoRealizado();
            v.Show();
        }
    }
}
