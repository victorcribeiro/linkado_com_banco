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
    public partial class F_escola : Form
    {
        public F_escola()
        {
            InitializeComponent();
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Login f_Login= new F_Login(this);
            f_Login.ShowDialog();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 2)
                {
                    //Instanciar o objeto Forms correspondente
                    F_novouser f_novouser = new F_novouser();
                    f_novouser.ShowDialog();
                }
                else { MessageBox.Show("Nível de acesso não permitido"); }

            }
            else
            {
                MessageBox.Show("é necessário logar no sistema");
            }
            
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_novocurso f_novocurso = new F_novocurso();
            f_novocurso.ShowDialog();
        }

        private void novoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            F_novoprofessor f_novoprofessor = new F_novoprofessor();
            f_novoprofessor.ShowDialog();
        }

        private void novoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            F_Aluno f_novoaluno = new F_Aluno();
            f_novoaluno.ShowDialog();
        }

        private void gerenciarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void gerenciamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_gerenciaamentouser f_gerenciamentouser = new F_gerenciaamentouser();
            f_gerenciamentouser.ShowDialog();
        }

        private void logoofToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que desaja sair? ", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                label3.Text = "--";
                label1.Text = "--";
                pictureBox_login.Image = Properties.Resources.bvermelha;

                Globais.nivel = 0;
                Globais.logado = false;

            }
            else
            {

            }

        }
    } 
}
