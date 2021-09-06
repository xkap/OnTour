using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_On_Tour.Modelo;
using Sistema_On_Tour.Vistas;

namespace Sistema_On_Tour.Vistas
{
    public partial class VentanaRegistrarApoderado : Form
    {
        public VentanaRegistrarApoderado()
        {
            InitializeComponent();
            RadioSoltero.Checked = true;
        }

        public int CalcularEdad(DateTime f)
        {
            int years = DateTime.Now.Year - Fecha.Value.Year;
            if (f.Month > DateTime.Now.Month)
            {
                years--;
            }
            if (f.Month == DateTime.Now.Month && f.Day > DateTime.Now.Day)
            {
                years--;
            }
            return years;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaPrincipalEjecutivo v = new VentanaPrincipalEjecutivo();
            v.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            string pass;

            int sex;
            int ecivil;
            DateTime fec;

            if (RadioM.Checked == true)
            {
                sex = 1;
            }
            else
            {
                sex = 2;
            }

            if (RadioSoltero.Checked == true)
            {
                ecivil = 1;
            }
            else if (RadioCasado.Checked == true)
            {
                ecivil = 2;
            }
            else if (RadioDivorciado.Checked == true)
            {
                ecivil = 3;
            }
            else
            {
                ecivil = 4;
            }
            int edad = CalcularEdad(Fecha.Value.Date);

            if (CalcularEdad(Fecha.Value.Date) >= 18)
            {
                fec = Fecha.Value.Date;
            }
            else
            {
                errorFecha.SetError(Fecha, "La fecha especificada es mayor a la actual o usted es menor de edad");
                Fecha.Focus();
                return;
            }
            errorFecha.SetError(Fecha, "");

            if (CalcularEdad(Fecha.Value.Date) >= 18)
            {
                pass = TxtRun.Text.Substring(0, 3) + TxtNombres.Text.Substring(0,3)+ Fecha.Value.Date.ToString().Substring(0,2);
                LblContra.Text = pass;
                Apoderado ap = new Apoderado(TxtRun.Text, TxtNombres.Text, TxtAppaterno.Text, TxtApmaterno.Text, Fecha.Value.Date, TxtCorreo.Text, ecivil, sex,
                    Login.usuario, TxtCurso.Text, int.Parse(TxtCant.Text),TxtColegio.Text, pass);
                string result=ap.RegApoderado(ap, pass);
                MessageBox.Show(result);
            }
        }

        private void GrupoECivil_Enter(object sender, EventArgs e)
        {
            
        }

        private void LblContra_Click(object sender, EventArgs e)
        {

        }
    }
}
