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
using Sistema_On_Tour.Controlador;

namespace Sistema_On_Tour.Vistas
{
    public partial class VentanaPublicar : Form
    {
        public VentanaPublicar()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaInformacionesEjecutivo v = new VentanaInformacionesEjecutivo();
            v.Show();
        }

        private void BtnPublicar_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(Conexion.conn);
            string resultado = "";
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("sp_pubinfo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                

                OracleParameter parruneje = new OracleParameter("prun_eje", OracleDbType.Varchar2);
                parruneje.Value = Login.usuario;
                cmd.Parameters.Add(parruneje);

                OracleParameter parmsg = new OracleParameter("pmsg", OracleDbType.Varchar2);
                parmsg.Value = TxtInformacion.Text;
                cmd.Parameters.Add(parmsg);


                resultado = (cmd.ExecuteNonQuery() == -1) ? "Información Publicada" : "Error";
                MessageBox.Show(resultado);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                conn.Close();

            }
        }
    }
}
