using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Linq.Expressions;
using System.Drawing;

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

            catch (Exception ex)
            {
                if (msgErro != null)
                {
                    { MessageBox.Show(msgErro + " " + ex.Message); }
                    throw ex;
                }
            }

        } //Fim das funções generic



        public static void NovoUser(Usuario user)
        {
            if (UsernameExiste(user) == true)
            {
                MessageBox.Show("Usuario já existe no sistema");
                return;
            }
            //Rotina para inserção do novo usuário no banco de dados

            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                //Parametros conforme a tabela do banco de dados
                cmd.CommandText = "INSERT INTO tb_usuario (nome_usuario, username_usuario,senha_usuario,status_usuario,nivel_usuario) Values(@nome,@username,@senha,@status,@nivel)";
                //cmd.Command.Text = "INSERT INTO tb_usuarios VALUES (null, 'maria', 'maria', '1234','A','3')

                cmd.Parameters.AddWithValue("@nome", user.nome_usuario);
                cmd.Parameters.AddWithValue("@username", user.username_usuario);
                cmd.Parameters.AddWithValue("@senha", user.senha_usuario);
                cmd.Parameters.AddWithValue("@status", user.status_usuario);
                cmd.Parameters.AddWithValue("@nivel", user.nivel_usuario);

                cmd.ExecuteNonQuery();
                vcon.Close();
                MessageBox.Show("Novo usuário adicionado com sucesso");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir no usuário .: " + ex.Message);
                //throw ex
            }

        }

        public static bool UsernameExiste(Usuario user)
        {
            bool resposta;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = ConectarBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT username_usuario FROM tb_usuario WHERE username_usuario ='" + user.username_usuario + "'";

            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
            //O Data adapter abaixo preenche o DataTable com as informações retornadas do banco de dados
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                resposta = true;
            }
            else
            {
                resposta = false;
            }

            vcon.Close();
            return resposta;

        }

        public static void NovoCurso(Curso curso)
        {
            if (CursoExiste(curso) == true)
            {
                MessageBox.Show("Este curso já existe no sistema");
                return;
            }
            //Rotina para inserção do novo usuário no banco de dados

            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                //Parametros conforme a tabela do banco de dados
                cmd.CommandText = "INSERT INTO tb_curso (id_curso, nome_curso,area_curso,status_curso) Values(@id,@nome,@area,@status)";
                //cmd.Command.Text = "INSERT INTO tb_usuarios VALUES (null, 'maria', 'maria', '1234','A','3')

                cmd.Parameters.AddWithValue("@id", curso.id_curso);
                cmd.Parameters.AddWithValue("@nome", curso.nome_curso);
                cmd.Parameters.AddWithValue("@area", curso.area_curso);
                cmd.Parameters.AddWithValue("@status", curso.status_curso);


                cmd.ExecuteNonQuery();
                vcon.Close();
                MessageBox.Show("Novo curso adicionado com sucesso");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir no curso .: " + ex.Message);
                //throw ex
            }

        }

        public static bool CursoExiste(Curso curso)
        {
            bool resposta;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = ConectarBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT nome_curso FROM tb_curso WHERE nome_curso ='" + curso.nome_curso + "'";

            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
            //O Data adapter abaixo preenche o DataTable com as informações retornadas do banco de dados
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                resposta = true;
            }
            else
            {
                resposta = false;
            }

            vcon.Close();
            return resposta;

        }

        public static void NovoProfessor(Professor professor)
        {
            if (ProfessorExiste(professor) == true)
            {
                MessageBox.Show("Este professor já existe no sistema");
                return;
            }
            //Rotina para inserção do novo usuário no banco de dados

            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                //Parametros conforme a tabela do banco de dados
                cmd.CommandText = "INSERT INTO tb_professor (id_professor, nome_professor,contato_professor,status_professor, cpf_professor) Values(@id,@nome,@contato,@status,@cpf)";


                cmd.Parameters.AddWithValue("@id", professor.id_professor);
                cmd.Parameters.AddWithValue("@nome", professor.nome_professor);
                cmd.Parameters.AddWithValue("@contato", professor.contato_professor);
                cmd.Parameters.AddWithValue("@status", professor.status_professor);
                cmd.Parameters.AddWithValue("@cpf", professor.cpf_professor);



                cmd.ExecuteNonQuery();
                vcon.Close();
                MessageBox.Show("Novo professor adicionado com sucesso");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir professor .: " + ex.Message);
                //throw ex
            }

        }

        public static bool ProfessorExiste(Professor professor)
        {
            bool resposta;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = ConectarBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT cpf_professor FROM tb_professor WHERE cpf_professor ='" + professor.cpf_professor + "'";

            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
            //O Data adapter abaixo preenche o DataTable com as informações retornadas do banco de dados
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                resposta = true;
            }
            else
            {
                resposta = false;
            }

            vcon.Close();
            return resposta;

        }


        public static void NovoAluno(Aluno aluno)
        {
            if (AlunoExiste(aluno) == true)
            {
                MessageBox.Show("Este aluno já existe no sistema");
                return;
            }
            //Rotina para inserção do novo usuário no banco de dados

            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                //Parametros conforme a tabela do banco de dados
                cmd.CommandText = "INSERT INTO tb_aluno (id_aluno, nome_aluno,contato_aluno,status_aluno,cpf_aluno) Values(@id,@nome,@contato,@status,@cpf)";


                cmd.Parameters.AddWithValue("@id", aluno.id_aluno);
                cmd.Parameters.AddWithValue("@nome", aluno.nome_aluno);
                cmd.Parameters.AddWithValue("@contato", aluno.contato_aluno);
                cmd.Parameters.AddWithValue("@status", aluno.status_aluno);
                cmd.Parameters.AddWithValue("@cpf", aluno.cpf_aluno);



                cmd.ExecuteNonQuery();
                vcon.Close();
                MessageBox.Show("Novo aluno adicionado com sucesso");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir aluno: " + ex.Message);
                //throw ex
            }


        } // Fim do metodo novoaluno

        public static bool AlunoExiste(Aluno aluno)
        {
            bool resposta;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = ConectarBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT cpf_aluno FROM tb_aluno WHERE cpf_aluno ='" + aluno.cpf_aluno + "'";

            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
            //O Data adapter abaixo preenche o DataTable com as informações retornadas do banco de dados
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                resposta = true;
            }
            else
            {
                resposta = false;
            }

            vcon.Close();
            return resposta;

        }

        public static DataTable ObterUserID()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT id_usuario AS ID, nome_usuario AS Nome FROM tb_usuario";

                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                //o Data adapter abaixo preeche o DataTable com as infomações retornadas do banco de dados
                da.Fill(dt);
                vcon.Close();
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;

            }
        }


        public static DataTable ObterDadosPorId(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "SELECT * FROM tb_usuario WHERE id_usuario =" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);

                da.Fill(dt);
                vcon.Close();
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }



        }

        public static DataTable AtualizarUsuario(Usuario user)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();

                cmd.CommandText = "UPDATE tb_usuarios SET nome_usuario='" + user.nome_usuario + "',username_usuario='" + user.username_usuario + "',senha_usuario='" + user.senha_usuario + "',status_usuario='" + user.status_usuario + "',nivel_usuario=" + user.nivel_usuario + " WHERE id_usuario=" + user.id_usuario;

                da = new SQLiteDataAdapter(cmd.CommandText, vcon);

                da.Fill(dt);
                vcon.Close();
                return dt;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}





    


   
