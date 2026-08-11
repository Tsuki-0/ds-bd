using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_agenda.formularios
{
    public partial class MDI_menu : Form
    {
        public MDI_menu()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcadpessoa cadpessoa = new frmcadpessoa();
            cadpessoa.MdiParent = this;
            cadpessoa.Show();
        }

        private void exibirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exibir exibirForm = new exibir();
            exibirForm.MdiParent = this;
            exibirForm.Show();
        }
    }
}
