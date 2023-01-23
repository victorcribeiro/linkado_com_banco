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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Login f_Login= new F_Login(this);
            f_Login.ShowDialog();
        }
    }
}
