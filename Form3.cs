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
    public partial class F_novocurso : Form
    {
        public F_novocurso()
        {
            InitializeComponent();
        }
       

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            curso.nome_curso = tb_nome.Text;
            curso.area_curso = tb_area.Text;
            curso.status_curso = cb_status.Text;
            
            
            Banco_de_dados.NovoCurso(curso);
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            tb_nome.Text = null;
            tb_area.Text = null;
            cb_status.Text = null;

        }
    }
}
