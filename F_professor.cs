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
    public partial class F_novoprofessor : Form
    {
        public F_novoprofessor()
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

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor();
            professor.nome_professor = tb_nome.Text;
            professor.cpf_professor = tb_cpf.Text;
            professor.status_professor = cb_status.Text;
            professor.contato_professor = tb_contato.Text;



            Banco_de_dados.NovoProfessor(professor);
        }
    }
}
