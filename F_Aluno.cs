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
    public partial class F_Aluno : Form
    {
        public F_Aluno()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_nome.Text = null;
            tb_contato.Text = null;
            tb_cpf.Text = null;
            cb_status.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.nome_aluno = tb_nome.Text;
            aluno.cpf_aluno = tb_cpf.Text;
            aluno.status_aluno = cb_status.Text;
            aluno.contato_aluno = tb_contato.Text;



            Banco_de_dados.NovoAluno(aluno);
        }
    }

}
