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

        private void button2_Click(object sender, EventArgs e)
        {
            //obter a linha selecionada no DGV
            int linha = dgv_usuario.SelectedRows[0];


        }

        private void dgv_usuario_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
