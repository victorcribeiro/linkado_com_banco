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
    public partial class F_novouser : Form
    {
        public F_novouser()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.nome_usuario = tb_nome.Text;
            usuario.username_usuario = tb_username.Text;
            usuario.senha_usuario = tb_senha.Text;
            usuario.status_usuario = cb_status.Text;
            //usuario.nivel_usurio = (Int32)nud_nivel.Value;
            usuario.nivel_usuario = Convert.ToInt32(Math.Round(nud_nivel.Value, 0));
            Banco_de_dados.NovoUser(usuario);

              


        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_nome.Text = null;
            tb_username.Text = null;
            tb_senha.Text = null;
            cb_status.Text = null;
        }
    }

}
