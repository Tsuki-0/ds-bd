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
    public partial class frmcadpessoa : Form
    {
        public frmcadpessoa()
        {
            InitializeComponent();
        }

        private void dS_PESSOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dS_PESSOABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_agenda);

        }

        private void frmcadpessoa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_agenda.DS_PESSOA'. Você pode movê-la ou removê-la conforme necessário.
            this.dS_PESSOATableAdapter.Fill(this.dataSet_agenda.DS_PESSOA);

        }
    }
}
