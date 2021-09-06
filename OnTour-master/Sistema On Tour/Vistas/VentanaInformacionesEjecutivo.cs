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
    public partial class VentanaInformacionesEjecutivo : Form
    {
        public VentanaInformacionesEjecutivo()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaPrincipalEjecutivo v = new VentanaPrincipalEjecutivo();
            v.Show();
        }

        private void VentanaInformacionesEjecutivo_Load(object sender, EventArgs e)
        {

        }

        private void BtnInformar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaInformar v = new VentanaInformar();
            v.Show();
        }

        private void BtnPublicar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaPublicar v = new VentanaPublicar();
            v.Show();
        }
    }
}
