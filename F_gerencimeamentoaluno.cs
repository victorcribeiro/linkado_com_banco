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
    public partial class F_gerencimeamentoaluno : Form
    {
        public F_gerencimeamentoaluno()
        {
            InitializeComponent();
        }

        private void dgv_aluno_SelectionChanged(object sender, EventArgs e)
        {
           


        }

        private void F_gerencimeamentoaluno_Load(object sender, EventArgs e)
        {
            dgv_aluno.DataSource = Banco_de_dados.ObterAlunoID();

            //Define a largura das colunas do DataGridView usuário
            dgv_aluno.Columns[0].Width = 40;
            dgv_aluno.Columns[1].Width = 180;

        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            F_Aluno f_aluno = new F_Aluno();
            f_aluno.ShowDialog();
            //Atualiza o DVG com o novo usuário
            dgv_aluno.DataSource = Banco_de_dados.ObterProfessorID();
        }

        private void bt_atualizar_Click(object sender, EventArgs e)
        {
            int linha = dgv_aluno.SelectedRows[0].Index;

            Aluno user = new Aluno();
            user.id_aluno = Convert.ToInt32(tb_id.Text);
            user.nome_aluno = tb_nome.Text;
            user.contato_aluno = tb_contato.Text;
            user.cpf_aluno = tb_cpf.Text;
            user.status_aluno = cb_status.Text;

            //Invocar o método
            Banco_de_dados.AtualizarAluno(user);

            //Atualizar o DVG com os dados atuais
            //dgv_usuario.DataSource = banco.ObterUserID();
            //Setar a linha selecionada anteriormente
            //dgv_usuario.CurrentCell = dgv_usuario[0, linha];
            // Outra forma de fazer a mesma coisa sem carregar todos os dados
            dgv_aluno[1, linha].Value = tb_nome.Text;
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Confirmar Exclusão ?", "Excluir Usuário", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                Banco_de_dados.RemoverAluno(tb_id.Text);
                // Para evitar carregar o banco de dados novamente podemos atualizar o dgv diretamente
                dgv_aluno.Rows.Remove(dgv_aluno.CurrentRow);




            }
        }

        private void bt_fechar_Click(object sender, EventArgs e)

        {
            this.Close();
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            tb_nome.Text = null;
            tb_contato.Text = null;
            tb_cpf.Text = null;
            cb_status.Text = null;
        }

        private void tb_contato_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_aluno_SizeChanged(object sender, EventArgs e)
        {
           



        }

        private void dgv_aluno_SelectionChanged_1(object sender, EventArgs e)
        {
            DataGridView dvg = sender as DataGridView;
            int qtdLinhas = dvg.SelectedRows.Count;
            // Realize o procedimento caso tenha ao menos uma linha selecionada

            if (qtdLinhas > 0)
            {
                DataTable dt = new DataTable();

                // O dado da coluna indice 0 é o Id do usuário
                string userId = dvg.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco_de_dados.ObterDadosPorIdAluno(userId);

                tb_id.Text = dt.Rows[0].Field<Int64>("id_aluno").ToString();
                tb_nome.Text = dt.Rows[0].Field<string>("nome_aluno");
                tb_contato.Text = dt.Rows[0].Field<string>("contato_aluno");
                cb_status.Text = dt.Rows[0].Field<string>("status_aluno");
                tb_cpf.Text = dt.Rows[0].Field<string>("cpf_aluno");



            }

        }
    }
    
}
