using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_agenda.formularios
{
    public partial class Login : Form
    {
        string nome;
        string senha;
        bool nmatv = false;
        bool senhatv = false;
        public Login()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nome = textBox1.Text;
            nmatv = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            senha = textBox2.Text;
            senhatv = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           DataTable dt = new DataTable
           dt.
           UserDataAdapter = new taUserDataAdapter();
        }
    }
}
