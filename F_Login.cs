using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEscola1
{
    public partial class F_Login : Form
    {
        F_escola f_login;
        DataTable dt = new DataTable();

        public F_Login(F_escola f)
        {
            InitializeComponent();
            f_login = f;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox_user.Text;
            string senha = textBox_senha.Text;

            if (username == "" || senha == "")
            {
                MessageBox.Show("Preencher todos os campos");
                textBox_user.Focus();
                return;
            }

            string sql = "SELECT * FROM tb_usuario WHERE username_usuario ='" + username + "'AND senha_usuario='" + senha +"'";
            dt = Banco_de_dados.ConsultaSql(sql);

            if (dt.Rows.Count == 1)
            {
                f_login.label4.Text = dt.Rows[0].ItemArray[5].ToString();
                f_login.pictureBox_login.Image = Properties.Resources.bverde;

                Globais.nivel = int.Parse(dt.Rows[0].Field<Int64>("nivel_usuario").ToString());
                Globais.logado = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha incorreta");
            }
        }
    }
}
