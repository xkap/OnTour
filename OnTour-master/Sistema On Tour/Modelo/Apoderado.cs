using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;
using Sistema_On_Tour.Controlador;
using System.Windows.Forms;

namespace Sistema_On_Tour.Modelo
{
    public class Apoderado
    {
        private string run_apo;
        private string nombres;
        private string appaterno;
        private string apmaterno;
        private DateTime fecnac;
        private string correo;
        private int idECivil;
        private int idGenero;
        private string run_eje;
        private string curso;
        private int cantalum;
        private string colegio;
        private string password;



       

        public Apoderado(string run_apo, string nombres, string appaterno, string apmaterno, DateTime fecnac,string correo, int idECivil, int idGenero, string run_eje, 
            string curso, int cantalum, string colegio, string password)
        {
            this.run_apo = run_apo;
            this.nombres = nombres;
            this.appaterno = appaterno;
            this.apmaterno = apmaterno;
            this.fecnac = fecnac;
            this.correo = correo;
            this.idECivil = idECivil;
            this.idGenero = idGenero;
            this.run_eje = run_eje;
            this.curso = curso;
            this.cantalum = cantalum;
            this.colegio = colegio;
            this.password = password;
        }


        public string RegApoderado(Apoderado ap, string pass)
        {
            string resultado="";//recordar inicializarla
            OracleConnection conn = new OracleConnection(Conexion.conn);

            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("sp_regapoderado", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter parrun = new OracleParameter("prut", OracleDbType.Varchar2);
                parrun.Value = ap.run_apo;
                cmd.Parameters.Add(parrun);

                OracleParameter parnom = new OracleParameter("pnombres", OracleDbType.Varchar2);
                parnom.Value = ap.nombres;
                cmd.Parameters.Add(parnom);

                OracleParameter parappaterno = new OracleParameter("pappaterno", OracleDbType.Varchar2);
                parappaterno.Value = ap.appaterno;
                cmd.Parameters.Add(parappaterno);

                OracleParameter parapmaterno = new OracleParameter("papmaterno", OracleDbType.Varchar2);
                parapmaterno.Value = ap.apmaterno;
                cmd.Parameters.Add(parapmaterno);


                OracleParameter parfec = new OracleParameter("pfecnac", OracleDbType.Date);
                parfec.Value = ap.fecnac;
                cmd.Parameters.Add(parfec);

                OracleParameter parcorreo = new OracleParameter("pcorreo", OracleDbType.Varchar2);
                parcorreo.Value = ap.correo;
                cmd.Parameters.Add(parcorreo);

                OracleParameter parecviil = new OracleParameter("pidecivil", OracleDbType.Int32);
                parecviil.Value = ap.idECivil;
                cmd.Parameters.Add(parecviil);

                OracleParameter pargenero = new OracleParameter("pidgenero", OracleDbType.Int32);
                pargenero.Value = ap.idGenero;
                cmd.Parameters.Add(pargenero);

                OracleParameter parruneje = new OracleParameter("prun_eje", OracleDbType.Varchar2);
                parruneje.Value = ap.run_eje;
                cmd.Parameters.Add(parruneje);

                OracleParameter parcurso = new OracleParameter("pcurso", OracleDbType.Varchar2);
                parcurso.Value = ap.curso;
                cmd.Parameters.Add(parcurso);

                OracleParameter parcantalum = new OracleParameter("pcantalum", OracleDbType.Int32);
                parcantalum.Value = ap.cantalum;
                cmd.Parameters.Add(parcantalum);

                OracleParameter parcolegio = new OracleParameter("pcolegio", OracleDbType.Varchar2);
                parcolegio.Value = ap.colegio;
                cmd.Parameters.Add(parcolegio);

                OracleParameter parpass = new OracleParameter("ppass", OracleDbType.Varchar2);
                parpass.Value = pass;
                cmd.Parameters.Add(parpass);


//If you use this method to call a store procedure that perform UPDATE/INSERT in a table the method return -1 if the stored procudere has the SET NOCOUNT at ON value.
                if(cmd.ExecuteNonQuery() == -1)
                {
                    resultado = "El apoderado ha sido registrado";

                }


                

                
            }
            catch(Exception error)
            {

                //resultado = "ERROR: El run ya existe en la base de datos. Ingrese otro por favor";
                resultado = error.Message;

            }
            finally
            {
                conn.Close();
            }
            

                return resultado;

        }
    }
}
