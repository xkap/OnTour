using Oracle.DataAccess.Client;
using Sistema_On_Tour.Controlador;
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
    public partial class VentanaInformacionesApoderado : Form
    {
        public VentanaInformacionesApoderado()
        {
            InitializeComponent();
            Informaciones();
        }
        //RECORDAR HACER VALIDACIONES REG APODERADO


            public void Informaciones()
        {
            string saldo;
            OracleConnection conn = new OracleConnection(Conexion.conn);

            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("SELECT valor_paq, (select mensaje from informacion where idinfor =654)from paquete", conn);
                cmd.CommandType = CommandType.Text;

                OracleDataReader rdr = cmd.ExecuteReader();

                /*OracleParameter parrun = new OracleParameter("prun_apo", OracleDbType.Varchar2);
                parrun.Value = Login.usuario;
                cmd.Parameters.Add(parrun);

                //DataTable dt = new DataTable();
                cmd.Parameters.Add("resul", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);*/

                while (rdr.Read())
                {
                    LblSaldo.Text = rdr[0].ToString();
                    LblInfo.Text = rdr[1].ToString();
                    break;
                }

                LblInfo.Text = "Ofertas por esta semana 30% de descuento";
                LblCorreo.Text = "carlosont@hotmail.com";
                LblNumero.Text = "+56984782503";
                LblCompletado.Text = "40% Completado";

                LblServicios.Text = "No posee ningún servicio contratado";

                /*
                DataDepositos.Columns[0].Name = "Id Deposito";
                DataDepositos.Columns[1].Name= "Mail Destinatario";
                DataDepositos.Columns[2].Name = "Fecha";
                DaaDepositos.Columns[3].Name = "Monto";*/

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

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaPrincipalApoderado v = new VentanaPrincipalApoderado();
            v.Show();
        }

        private void VentanaInformacionesApoderado_Load(object sender, EventArgs e)
        {

        }
    }
}
