using projeto_agenda.dados.DataSet_agendaTableAdapters;
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
    public partial class exibir : Form
    {
        private BindingSource dS_PESSOABindingSource;
        private TableAdapterManager tableAdapterManager;

        public exibir()
        {
            InitializeComponent();
            dS_PESSOABindingSource = new BindingSource();
            tableAdapterManager = new TableAdapterManager();
            tableAdapterManager.DS_PESSOATableAdapter = this.dS_PESSOATableAdapter;
        }

        private void dS_PESSOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dS_PESSOABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_agenda);

        }

        private void dS_PESSOABindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.dS_PESSOABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_agenda);

        }

        private void dS_PESSOABindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.dS_PESSOABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_agenda);

        }

        private void exibir_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_250221DataSet.DS_PESSOA'. Você pode movê-la ou removê-la conforme necessário.
            this.dS_PESSOATableAdapter1.Fill(this.db_250221DataSet.DS_PESSOA);
            // TODO: esta linha de código carrega dados na tabela 'dataSet_agenda.DS_PESSOA'. Você pode movê-la ou removê-la conforme necessário.
            this.dS_PESSOATableAdapter.Fill(this.dataSet_agenda.DS_PESSOA);

        }

        private void btnfiltro_Click(object sender, EventArgs e)
        {
            string filtro;
            if(CMBB1.SelectedIndex == -1) 
            {
                MessageBox.Show("Escolha a coluna para pesquisa");
                return;
            }
            filtro = CMBB1.Text;
            string busca = CBbuscar.Text;
            if (busca == "igual") 
            {
                filtro += " = '1" + tbvalor.Text + "'";
            }
            else if (busca=="que começa com") 
            {
                filtro += " like '" + tbvalor.Text + "%'";
            }
            else if (busca == "que termina com")
            {
                filtro += " like '%" + tbvalor.Text + "'";
            }
            else if (busca == "que contém")
            {
                filtro += " like '%" + tbvalor.Text + "%'";
            }
            dS_PESSOABindingSource1.Filter = filtro;
        }

        private void dS_PESSOADataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
