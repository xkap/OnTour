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
    public partial class VentanaDepositoRealizado : Form
    {
        public VentanaDepositoRealizado()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {

        }

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaDepositos v = new VentanaDepositos();
            v.Show();
        }
    }
}
