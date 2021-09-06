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
    public partial class VentanaInformar : Form
    {
        public VentanaInformar()
        {
            InitializeComponent();
            LlenarComboContacto();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaInformacionesEjecutivo v = new VentanaInformacionesEjecutivo();
            v.Show();
        }

        public void LlenarComboContacto()
        {
            OracleConnection conn = new OracleConnection(Conexion.conn);

            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("sp_combocontacto", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter parrun = new OracleParameter("reje", OracleDbType.Varchar2);
                parrun.Direction = ParameterDirection.Input;
                parrun.Value = Login.usuario;
                cmd.Parameters.Add(parrun);

                OracleParameter parresult = new OracleParameter("resul", OracleDbType.RefCursor);
                parresult.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parresult);

                DataTable dt = new DataTable();
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                da.Fill(dt);

                ComboContacto.DisplayMember = dt.Columns[0].ColumnName;
                ComboContacto.ValueMember = dt.Columns[0].ColumnName;

                ComboContacto.DataSource = dt;




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

        private void BtnInformar_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(Conexion.conn);
            string resultado = "";
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("sp_informar", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter parrun = new OracleParameter("prun_apo", OracleDbType.Varchar2);
                parrun.Value = ComboContacto.Text;
                cmd.Parameters.Add(parrun);

                OracleParameter parruneje = new OracleParameter("prun_eje", OracleDbType.Varchar2);
                parruneje.Value = Login.usuario;
                cmd.Parameters.Add(parruneje);

                OracleParameter parmsg = new OracleParameter("pmsg", OracleDbType.Varchar2);
                parmsg.Value = TxtMensaje.Text;
                cmd.Parameters.Add(parmsg);


                resultado = (cmd.ExecuteNonQuery() == -1) ? "Cliente informado" : "Error";
                MessageBox.Show(resultado);
            }
            catch(Exception error)
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
