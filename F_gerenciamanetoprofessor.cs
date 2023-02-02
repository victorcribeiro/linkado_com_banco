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
    public partial class F_gerenciamentoprofessor : Form
    {
        public F_gerenciamentoprofessor()
        {
            InitializeComponent();
        }

        private void F_gerenciamentoprofessor_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void dgv_professor_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void bt_atualizar_Click(object sender, EventArgs e)
        {
            //obter a linha selecionada no DGV
            




        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }






        private void F_gerenciamentoprofessor_Load_1(object sender, EventArgs e)
        {

            dgv_professor.DataSource = Banco_de_dados.ObterProfessorID();

            //Define a largura das colunas do DataGridView usuário
            dgv_professor.Columns[0].Width = 40;
            dgv_professor.Columns[1].Width = 180;


        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            F_novoprofessor f_Professor = new F_novoprofessor();
            f_Professor.ShowDialog();
            //Atualiza o DVG com o novo usuário
            dgv_professor.DataSource = Banco_de_dados.ObterProfessorID();
        }

        private void bt_atualizar_Click_1(object sender, EventArgs e)
        {
            int linha = dgv_professor.SelectedRows[0].Index;

            Professor user = new Professor();
            user.id_professor = Convert.ToInt32(tb_id.Text);
            user.nome_professor = tb_nome.Text;
            user.contato_professor = tb_contato.Text;
            user.cpf_professor = tb_cpf.Text;
            user.status_professor = cb_status.Text;

            //Invocar o método
            Banco_de_dados.AtualizarProfessor(user);

            //Atualizar o DVG com os dados atuais
            //dgv_usuario.DataSource = banco.ObterUserID();
            //Setar a linha selecionada anteriormente
            //dgv_usuario.CurrentCell = dgv_usuario[0, linha];
            // Outra forma de fazer a mesma coisa sem carregar todos os dados
            dgv_professor[1, linha].Value = tb_nome.Text;

        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Confirmar Exclusão ?", "Excluir Usuário", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                Banco_de_dados.RemoverProfessor(tb_id.Text);
                // Para evitar carregar o banco de dados novamente podemos atualizar o dgv diretamente
                dgv_professor.Rows.Remove(dgv_professor.CurrentRow);




            }
        }

        private void dgv_professor_SelectionChanged_1(object sender, EventArgs e)
        {
            DataGridView dvg = sender as DataGridView;
            int qtdLinhas = dvg.SelectedRows.Count;
            // Realize o procedimento caso tenha ao menos uma linha selecionada

            if (qtdLinhas > 0)
            {
                DataTable dt = new DataTable();

                // O dado da coluna indice 0 é o Id do usuário
                string userId = dvg.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco_de_dados.ObterDadosPorIdProfessor(userId);

                tb_id.Text = dt.Rows[0].Field<Int64>("id_professor").ToString();
                tb_nome.Text = dt.Rows[0].Field<string>("nome_professor").ToString();
                tb_contato.Text = dt.Rows[0].Field<string>("contato_professor").ToString();
                tb_cpf.Text = dt.Rows[0].Field<string>("cpf_professor").ToString();
                cb_status.Text = dt.Rows[0].Field<string>("status_professor").ToString();



            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tb_nome.Text = null;
            tb_contato.Text = null;
            tb_cpf.Text = null;
            cb_status.Text = null;
        }
    }



}
