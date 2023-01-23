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
    public partial class F_Login : Form
    {
        F_escola f_login;
        DataTable dt = new DataTable();

        public F_Login(F_escola f)
        {
            InitializeComponent();
            f_login = f;
        }
    }
}
