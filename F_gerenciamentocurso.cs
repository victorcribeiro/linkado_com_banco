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
    public partial class F_gerenciamentocurso : Form
    {
        public F_gerenciamentocurso()
        {
            InitializeComponent();
        }

        private void dgv_curso_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dvg = sender as DataGridView;
            int qtdLinhas = dvg.SelectedRows.Count;
            // Realize o procedimento caso tenha ao menos uma linha selecionada

            if (qtdLinhas > 0)
            {
                DataTable dt = new DataTable();

                // O dado da coluna indice 0 é o Id do usuário
                string userId = dvg.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco_de_dados.ObterDadosPorIdCurso(userId);

                tb_id.Text = dt.Rows[0].Field<Int64>("id_curso").ToString();
                tb_nome.Text = dt.Rows[0].Field<string>("nome_curso").ToString();
                tb_area.Text = dt.Rows[0].Field<string>("area_curso").ToString();
                cb_status.Text = dt.Rows[0].Field<string>("status_curso").ToString();



            }
        }

        private void F_gerenciamentocurso_Load(object sender, EventArgs e)
        {
            dgv_curso.DataSource = Banco_de_dados.ObterCursoID();

            //Define a largura das colunas do DataGridView usuário
            dgv_curso.Columns[0].Width = 40;
            dgv_curso.Columns[1].Width = 180;
        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            F_novocurso f_Curso = new F_novocurso();
            f_Curso.ShowDialog();
            //Atualiza o DVG com o novo usuário
            dgv_curso.DataSource = Banco_de_dados.ObterCursoID();
        }

        private void bt_atualizar_Click(object sender, EventArgs e)
        {
            int linha = dgv_curso.SelectedRows[0].Index;

            Curso user = new Curso();
            user.id_curso = Convert.ToInt32(tb_id.Text);
            user.nome_curso = tb_nome.Text;
            user.area_curso = tb_area.Text;
            user.status_curso = cb_status.Text;

            //Invocar o método
            Banco_de_dados.AtualizarCurso(user);

            //Atualizar o DVG com os dados atuais
            //dgv_usuario.DataSource = banco.ObterUserID();
            //Setar a linha selecionada anteriormente
            //dgv_usuario.CurrentCell = dgv_usuario[0, linha];
            // Outra forma de fazer a mesma coisa sem carregar todos os dados
            dgv_curso[1, linha].Value = tb_nome.Text;
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            tb_nome.Text = null;
            tb_area.Text = null;
            cb_status.Text = null;
            tb_id.Text = null;
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Confirmar Exclusão ?", "Excluir Curso", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                Banco_de_dados.RemoverCurso(tb_id.Text);
                // Para evitar carregar o banco de dados novamente podemos atualizar o dgv diretamente
                dgv_curso.Rows.Remove(dgv_curso.CurrentRow);




            }
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
