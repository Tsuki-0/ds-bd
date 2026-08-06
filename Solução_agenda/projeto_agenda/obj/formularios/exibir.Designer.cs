namespace projeto_agenda.formularios
{
    partial class exibir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataSet_agenda = new projeto_agenda.dados.DataSet_agenda();
            this.dataSetagendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetagendaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dS_PESSOATableAdapter = new projeto_agenda.dados.DataSet_agendaTableAdapters.DS_PESSOATableAdapter();
            this.dataSetagendaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.CBbuscar = new System.Windows.Forms.ComboBox();
            this.CMBB1 = new System.Windows.Forms.ComboBox();
            this.btnfiltro = new System.Windows.Forms.Button();
            this.tbvalor = new System.Windows.Forms.TextBox();
            this.db_250221DataSet = new projeto_agenda.db_250221DataSet();
            this.dS_PESSOABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dS_PESSOATableAdapter1 = new projeto_agenda.db_250221DataSetTableAdapters.DS_PESSOATableAdapter();
            this.tableAdapterManager1 = new projeto_agenda.db_250221DataSetTableAdapters.TableAdapterManager();
            this.dS_PESSOADataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_agenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetagendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetagendaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetagendaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_250221DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_PESSOABindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_PESSOADataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet_agenda
            // 
            this.dataSet_agenda.DataSetName = "DataSet_agenda";
            this.dataSet_agenda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetagendaBindingSource
            // 
            this.dataSetagendaBindingSource.DataSource = this.dataSet_agenda;
            this.dataSetagendaBindingSource.Position = 0;
            // 
            // dataSetagendaBindingSource1
            // 
            this.dataSetagendaBindingSource1.DataSource = this.dataSet_agenda;
            this.dataSetagendaBindingSource1.Position = 0;
            // 
            // dS_PESSOATableAdapter
            // 
            this.dS_PESSOATableAdapter.ClearBeforeFill = true;
            // 
            // dataSetagendaBindingSource2
            // 
            this.dataSetagendaBindingSource2.DataSource = this.dataSet_agenda;
            this.dataSetagendaBindingSource2.Position = 0;
            // 
            // CBbuscar
            // 
            this.CBbuscar.FormattingEnabled = true;
            this.CBbuscar.Items.AddRange(new object[] {
            "todos",
            "igual",
            "que começa com",
            "que termina com",
            "que contém",
            "que esteja entre"});
            this.CBbuscar.Location = new System.Drawing.Point(267, 34);
            this.CBbuscar.Name = "CBbuscar";
            this.CBbuscar.Size = new System.Drawing.Size(121, 28);
            this.CBbuscar.TabIndex = 2;
            // 
            // CMBB1
            // 
            this.CMBB1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBB1.FormattingEnabled = true;
            this.CMBB1.Items.AddRange(new object[] {
            "ID",
            "NOME",
            "ENDERECO",
            "CIDADE",
            "EMAIL",
            "DATA_NASCIMENTO"});
            this.CMBB1.Location = new System.Drawing.Point(26, 34);
            this.CMBB1.Name = "CMBB1";
            this.CMBB1.Size = new System.Drawing.Size(121, 28);
            this.CMBB1.TabIndex = 3;
            // 
            // btnfiltro
            // 
            this.btnfiltro.Location = new System.Drawing.Point(730, 32);
            this.btnfiltro.Name = "btnfiltro";
            this.btnfiltro.Size = new System.Drawing.Size(75, 31);
            this.btnfiltro.TabIndex = 4;
            this.btnfiltro.Text = "filtrar";
            this.btnfiltro.UseVisualStyleBackColor = true;
            this.btnfiltro.Click += new System.EventHandler(this.btnfiltro_Click);
            // 
            // tbvalor
            // 
            this.tbvalor.Location = new System.Drawing.Point(523, 36);
            this.tbvalor.Name = "tbvalor";
            this.tbvalor.Size = new System.Drawing.Size(100, 26);
            this.tbvalor.TabIndex = 5;
            // 
            // db_250221DataSet
            // 
            this.db_250221DataSet.DataSetName = "db_250221DataSet";
            this.db_250221DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dS_PESSOABindingSource1
            // 
            this.dS_PESSOABindingSource1.DataMember = "DS_PESSOA";
            this.dS_PESSOABindingSource1.DataSource = this.db_250221DataSet;
            // 
            // dS_PESSOATableAdapter1
            // 
            this.dS_PESSOATableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.DS_PESSOATableAdapter = this.dS_PESSOATableAdapter1;
            this.tableAdapterManager1.UpdateOrder = projeto_agenda.db_250221DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dS_PESSOADataGridView
            // 
            this.dS_PESSOADataGridView.AutoGenerateColumns = false;
            this.dS_PESSOADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dS_PESSOADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dS_PESSOADataGridView.DataSource = this.dS_PESSOABindingSource1;
            this.dS_PESSOADataGridView.Location = new System.Drawing.Point(30, 115);
            this.dS_PESSOADataGridView.MultiSelect = false;
            this.dS_PESSOADataGridView.Name = "dS_PESSOADataGridView";
            this.dS_PESSOADataGridView.RowHeadersWidth = 62;
            this.dS_PESSOADataGridView.RowTemplate.Height = 28;
            this.dS_PESSOADataGridView.Size = new System.Drawing.Size(917, 265);
            this.dS_PESSOADataGridView.TabIndex = 5;
            this.dS_PESSOADataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dS_PESSOADataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 85;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOME";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ENDERECO";
            this.dataGridViewTextBoxColumn3.HeaderText = "ENDERECO";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CIDADE";
            this.dataGridViewTextBoxColumn4.HeaderText = "CIDADE";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "EMAIL";
            this.dataGridViewTextBoxColumn5.HeaderText = "EMAIL";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DATA_NASCIMENTO";
            this.dataGridViewTextBoxColumn6.HeaderText = "DATA_NASCIMENTO";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 175;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Coluna";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pesquisa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Filtro";
            // 
            // exibir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dS_PESSOADataGridView);
            this.Controls.Add(this.tbvalor);
            this.Controls.Add(this.btnfiltro);
            this.Controls.Add(this.CMBB1);
            this.Controls.Add(this.CBbuscar);
            this.Name = "exibir";
            this.Text = "exibir";
            this.Load += new System.EventHandler(this.exibir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_agenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetagendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetagendaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetagendaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_250221DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_PESSOABindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_PESSOADataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dados.DataSet_agenda dataSet_agenda;
        private System.Windows.Forms.BindingSource dataSetagendaBindingSource;
        private System.Windows.Forms.BindingSource dataSetagendaBindingSource1;
        private dados.DataSet_agendaTableAdapters.DS_PESSOATableAdapter dS_PESSOATableAdapter;
        private System.Windows.Forms.BindingSource dataSetagendaBindingSource2;
        private System.Windows.Forms.ComboBox CBbuscar;
        private System.Windows.Forms.ComboBox CMBB1;
        private System.Windows.Forms.Button btnfiltro;
        private System.Windows.Forms.TextBox tbvalor;
        private db_250221DataSet db_250221DataSet;
        private System.Windows.Forms.BindingSource dS_PESSOABindingSource1;
        private db_250221DataSetTableAdapters.DS_PESSOATableAdapter dS_PESSOATableAdapter1;
        private db_250221DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView dS_PESSOADataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}