using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
//using System.Data.OracleClient; DEPRECATED
using Sistema_On_Tour.Vistas;
using Sistema_On_Tour.Controlador;

namespace Sistema_On_Tour
{
    public partial class Login : Form
    {
        public static string usuario;

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(Conexion.conn);

            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("sp_login", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter paruser = new OracleParameter("puser", OracleDbType.Varchar2);
                paruser.Value= TxtUser.Text;
                paruser.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(paruser);


                OracleParameter parpass = new OracleParameter("ppass", OracleDbType.Varchar2);
                parpass.Value = TxtPass.Text;
                parpass.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(parpass);

                OracleParameter parexito = new OracleParameter("pexito", OracleDbType.Varchar2);
                parexito.Direction = ParameterDirection.Output;
                parexito.Size = 1; //muy importante asignarle tamaño siempre a un parametro que es de salida **
                cmd.Parameters.Add(parexito);

                OracleParameter ptipo = new OracleParameter("ptipo", OracleDbType.Int32);
                ptipo.Direction = ParameterDirection.Output;
                ptipo.Size = 1; //muy importante asignarle tamaño siempre a un parametro que es de salida **
                cmd.Parameters.Add(ptipo);

                cmd.ExecuteNonQuery();
                string exito = cmd.Parameters["pexito"].Value.ToString();
                int tipouser = int.Parse(cmd.Parameters["ptipo"].Value.ToString());

                if (exito.Equals("T"))
                {
                    usuario=TxtUser.Text;
                    if (tipouser == 1)
                    {
                        this.Hide();
                        VentanaPrincipalApoderado v = new VentanaPrincipalApoderado();
                        v.Show();
                    }
                    else if(tipouser==2)
                    {
                        this.Hide();
                        VentanaPrincipalEjecutivo v = new VentanaPrincipalEjecutivo();
                        v.Show();
                    }
                }
                
                
            }
            catch(Exception error)
            {
                MessageBox.Show("Nombre de Usuario o Contraseña incorrectos. Verifique las credenciales por favor");

            }
            finally
            {
                conn.Close();
            }
            
        }
    }
}

