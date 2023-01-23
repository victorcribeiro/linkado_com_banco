using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ProjetoEscola1
{
    internal class Banco_de_dados
    {
        private static SQLiteConnection conex;
        private static SQLiteConnection ConectarBanco()
        {
            conex = new SQLiteConnection("Data Source=" + Globais.caminhoBanco);
            conex.Open();
            return conex;
            //Fim do método ConectarBanco
        }

        public static DataTable RelacaoUser()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConectarBanco();
                var cmd = ConectarBanco().CreateCommand();
                {
                    cmd.CommandText = "SELECT * FROM tb_usuario";
                    da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                    da.Fill(dt);
                    vcon.Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        //Metodo genérico para consultas no banco de dados
        public static DataTable ConsultaSql(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConectarBanco();
                var cmd = ConectarBanco().CreateCommand();
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                    da.Fill(dt);
                    vcon.Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void Dml(string sql, string msgOK = null, string msgErro = null)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                // O Data adapter abaixo preenche o DataTable com as informações

                cmd.ExecuteNonQuery();
                vcon.Close();
                if (msgOK != null)
                {
                    MessageBox.Show(msgOK);
                }
            }

            catch(Exception ex)
            {
                if (msgErro != null)
                {
                    { MessageBox.Show(msgErro + " " + ex.Message); }
                    throw ex;
                }
            }

        //Fim das funções genericas



    }
    }
}

