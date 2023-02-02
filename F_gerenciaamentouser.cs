using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEscola1
{
    public partial class F_gerenciaamentouser : Form
    {
        public F_gerenciaamentouser()
        {
            InitializeComponent();
        }

        private void tb_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void F_gerenciaamentouser_Load(object sender, EventArgs e)
        {
            dgv_usuario.DataSource = Banco_de_dados.ObterUserID();

            //Define a largura das colunas do DataGridView usuário
            dgv_usuario.Columns[0].Width= 40;
            dgv_usuario.Columns[1].Width = 180;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_novouser f_Novouser= new F_novouser();
            f_Novouser.ShowDialog();
            //Atualiza o DVG com o novo usuário
            dgv_usuario.DataSource = Banco_de_dados.ObterUserID();

        }


        private void dgv_usuario_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dvg = sender as DataGridView;
            int qtdLinhas = dvg.SelectedRows.Count;
            // Realize o procedimento caso tenha ao menos uma linha selecionada

            if (qtdLinhas > 0 )
            {
                DataTable dt = new DataTable();

                // O dado da coluna indice 0 é o Id do usuário
                string userId= dvg.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco_de_dados.ObterDadosPorId(userId);

                tb_id.Text = dt.Rows[0].Field<Int64>("id_usuario").ToString();
                tb_nome.Text = dt.Rows[0].Field<string>("nome_usuario").ToString();
                tb_username.Text = dt.Rows[0].Field<string>("username_usuario").ToString();
                tb_senha.Text = dt.Rows[0].Field<string>("senha_usuario").ToString();
                cb_status.Text = dt.Rows[0].Field<string>("status_usuario").ToString();
                nud_nivel.Text = dt.Rows[0].Field<Int64>("nivel_usuario").ToString();


            }
        }

        private void bt_atualizar_Click(object sender, EventArgs e)
        {
            //obter a linha selecionada no DGV
            int linha = dgv_usuario.SelectedRows[0].Index;

            Usuario user = new Usuario();
            user.id_usuario = Convert.ToInt32(tb_id.Text);
            user.nome_usuario = tb_nome.Text;
            user.username_usuario= tb_username.Text;
            user.senha_usuario = tb_senha.Text;
            user.status_usuario = cb_status.Text;
            user.nivel_usuario = Convert.ToInt32(Math.Round(nud_nivel.Value,0));
            //Invocar o método
            Banco_de_dados.AtualizarUsuario(user);

            //Atualizar o DVG com os dados atuais
            //dgv_usuario.DataSource = banco.ObterUserID();
            //Setar a linha selecionada anteriormente
            //dgv_usuario.CurrentCell = dgv_usuario[0, linha];
            // Outra forma de fazer a mesma coisa sem carregar todos os dados
            dgv_usuario[1, linha].Value = tb_nome.Text;





        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Confirmar Exclusão ?", "Excluir Usuário", MessageBoxButtons.YesNo);


            if (resposta == DialogResult.Yes)
            {
                Banco_de_dados.RemoverUsuario(tb_id.Text);
                // Para evitar carregar o banco de dados novamente podemos atualizar o dgv diretamente
                dgv_usuario.Rows.Remove(dgv_usuario.CurrentRow);




            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tb_nome.Text = null;
            tb_username = null;
            tb_senha.Text = null;
            cb_status.Text = null;
            nud_nivel.Text = null;
        }
    }
}
