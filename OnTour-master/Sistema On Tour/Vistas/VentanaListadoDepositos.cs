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
    public partial class VentanaListadoDepositos : Form
    {
        public VentanaListadoDepositos()
        {
            InitializeComponent();
            LlenarListadoDepositos();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaDepositos v = new VentanaDepositos();
            v.Show();
        }

        public void LlenarListadoDepositos()
        {
            DataDepositos.AllowUserToAddRows = false;
            OracleConnection conn = new OracleConnection(Conexion.conn);

            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("sp_llenardepositos", conn);
                cmd.CommandType = CommandType.StoredProcedure;


                DataTable dt = new DataTable();
                cmd.Parameters.Add("resul", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                                                                                        
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);

                /*
                DataDepositos.Columns[0].Name = "Id Deposito";
                DataDepositos.Columns[1].Name= "Mail Destinatario";
                DataDepositos.Columns[2].Name = "Fecha";
                DaaDepositos.Columns[3].Name = "Monto";*/

                BindingSource bindingSource1 = new BindingSource();
                bindingSource1.DataSource = dt;


                DataDepositos.DataSource = bindingSource1;




            }
            catch  (Exception error)
            {
                MessageBox.Show(error.Message);                                                                 
            }
            finally
            {
                
                conn.Close();
            }

        }

        private void VentanaListadoDepositos_Load(object sender, EventArgs e)
        {

        }

        private void BtnRecargar_Click(object sender, EventArgs e)
        {
            LlenarListadoDepositos();
        }
    }
}
