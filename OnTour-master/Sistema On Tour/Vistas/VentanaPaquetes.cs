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
    public partial class VentanaPaquetes : Form
    {
        public VentanaPaquetes()
        {
            InitializeComponent();
            LlenarComboPaquetes();
            LlenarComboCurso();
        }

        public void LlenarComboPaquetes()
        {
            OracleConnection conn = new OracleConnection(Conexion.conn);

            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("sp_combopaquetes", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                

                OracleParameter parresult = new OracleParameter("resul", OracleDbType.RefCursor);
                parresult.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parresult);

                DataTable dt = new DataTable();
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                da.Fill(dt);

                ComboPaquetes.DisplayMember = dt.Columns[0].ColumnName;
                ComboPaquetes.ValueMember = dt.Columns[0].ColumnName;

                ComboPaquetes.DataSource = dt;




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

        public void LlenarComboCurso()
        {
            OracleConnection conn = new OracleConnection(Conexion.conn);

            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("sp_combocurso", conn);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter parresult = new OracleParameter("resul", OracleDbType.RefCursor);
                parresult.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parresult);

                DataTable dt = new DataTable();
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                da.Fill(dt);

                ComboCursos.DisplayMember = dt.Columns[0].ColumnName;
                ComboCursos.ValueMember = dt.Columns[0].ColumnName;

                ComboCursos.DataSource = dt;




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
            VentanaPrincipalEjecutivo v = new VentanaPrincipalEjecutivo();
            v.Show();
        }

        private void BtnContratar_Click(object sender, EventArgs e)
        {
            //recordar asignarle el paq a un curso, actualizarlo
            OracleConnection conn = new OracleConnection(Conexion.conn);
            string resultado;

            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("sp_contpaq", conn);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter parpaq = new OracleParameter("ppaq", OracleDbType.Varchar2);
                parpaq.Value = ComboPaquetes.Text;
                cmd.Parameters.Add(parpaq);

                OracleParameter parcurso = new OracleParameter("pcurso", OracleDbType.Varchar2);
                parcurso.Value = ComboCursos.Text;
                cmd.Parameters.Add(parcurso);

                resultado = (cmd.ExecuteNonQuery() == -1) ? "Paquete contratado" : "Error";
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

        private void ComboPaquetes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ComboCursos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
