namespace projeto_agenda.formularios
{
    partial class frmcadpessoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcadpessoa));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nOMELabel;
            System.Windows.Forms.Label eNDERECOLabel;
            System.Windows.Forms.Label cIDADELabel;
            System.Windows.Forms.Label eMAILLabel;
            System.Windows.Forms.Label dATA_NASCIMENTOLabel;
            this.dataSet_agenda = new projeto_agenda.dados.DataSet_agenda();
            this.dS_PESSOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_PESSOATableAdapter = new projeto_agenda.dados.DataSet_agendaTableAdapters.DS_PESSOATableAdapter();
            this.tableAdapterManager = new projeto_agenda.dados.DataSet_agendaTableAdapters.TableAdapterManager();
            this.dS_PESSOABindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.dS_PESSOABindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.nOMETextBox = new System.Windows.Forms.TextBox();
            this.eNDERECOTextBox = new System.Windows.Forms.TextBox();
            this.cIDADETextBox = new System.Windows.Forms.TextBox();
            this.eMAILTextBox = new System.Windows.Forms.TextBox();
            this.dATA_NASCIMENTODateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dS_PESSOADataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iDLabel = new System.Windows.Forms.Label();
            nOMELabel = new System.Windows.Forms.Label();
            eNDERECOLabel = new System.Windows.Forms.Label();
            cIDADELabel = new System.Windows.Forms.Label();
            eMAILLabel = new System.Windows.Forms.Label();
            dATA_NASCIMENTOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_agenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_PESSOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_PESSOABindingNavigator)).BeginInit();
            this.dS_PESSOABindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_PESSOADataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet_agenda
            // 
            this.dataSet_agenda.DataSetName = "DataSet_agenda";
            this.dataSet_agenda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dS_PESSOABindingSource
            // 
            this.dS_PESSOABindingSource.DataMember = "DS_PESSOA";
            this.dS_PESSOABindingSource.DataSource = this.dataSet_agenda;
            // 
            // dS_PESSOATableAdapter
            // 
            this.dS_PESSOATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DS_PESSOATableAdapter = this.dS_PESSOATableAdapter;
            this.tableAdapterManager.UpdateOrder = projeto_agenda.dados.DataSet_agendaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dS_PESSOABindingNavigator
            // 
            this.dS_PESSOABindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dS_PESSOABindingNavigator.BindingSource = this.dS_PESSOABindingSource;
            this.dS_PESSOABindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dS_PESSOABindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dS_PESSOABindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.dS_PESSOABindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.dS_PESSOABindingNavigatorSaveItem});
            this.dS_PESSOABindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dS_PESSOABindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dS_PESSOABindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dS_PESSOABindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dS_PESSOABindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dS_PESSOABindingNavigator.Name = "dS_PESSOABindingNavigator";
            this.dS_PESSOABindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dS_PESSOABindingNavigator.Size = new System.Drawing.Size(1124, 33);
            this.dS_PESSOABindingNavigator.TabIndex = 0;
            this.dS_PESSOABindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 20);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 20);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(57, 25);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // dS_PESSOABindingNavigatorSaveItem
            // 
            this.dS_PESSOABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dS_PESSOABindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dS_PESSOABindingNavigatorSaveItem.Image")));
            this.dS_PESSOABindingNavigatorSaveItem.Name = "dS_PESSOABindingNavigatorSaveItem";
            this.dS_PESSOABindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.dS_PESSOABindingNavigatorSaveItem.Text = "Salvar Dados";
            this.dS_PESSOABindingNavigatorSaveItem.Click += new System.EventHandler(this.dS_PESSOABindingNavigatorSaveItem_Click);
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(168, 74);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(30, 20);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dS_PESSOABindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(339, 71);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(200, 26);
            this.iDTextBox.TabIndex = 2;
            // 
            // nOMELabel
            // 
            nOMELabel.AutoSize = true;
            nOMELabel.Location = new System.Drawing.Point(168, 106);
            nOMELabel.Name = "nOMELabel";
            nOMELabel.Size = new System.Drawing.Size(60, 20);
            nOMELabel.TabIndex = 3;
            nOMELabel.Text = "NOME:";
            // 
            // nOMETextBox
            // 
            this.nOMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dS_PESSOABindingSource, "NOME", true));
            this.nOMETextBox.Location = new System.Drawing.Point(339, 103);
            this.nOMETextBox.Name = "nOMETextBox";
            this.nOMETextBox.Size = new System.Drawing.Size(200, 26);
            this.nOMETextBox.TabIndex = 4;
            // 
            // eNDERECOLabel
            // 
            eNDERECOLabel.AutoSize = true;
            eNDERECOLabel.Location = new System.Drawing.Point(168, 138);
            eNDERECOLabel.Name = "eNDERECOLabel";
            eNDERECOLabel.Size = new System.Drawing.Size(104, 20);
            eNDERECOLabel.TabIndex = 5;
            eNDERECOLabel.Text = "ENDERECO:";
            // 
            // eNDERECOTextBox
            // 
            this.eNDERECOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dS_PESSOABindingSource, "ENDERECO", true));
            this.eNDERECOTextBox.Location = new System.Drawing.Point(339, 132);
            this.eNDERECOTextBox.Name = "eNDERECOTextBox";
            this.eNDERECOTextBox.Size = new System.Drawing.Size(200, 26);
            this.eNDERECOTextBox.TabIndex = 6;
            // 
            // cIDADELabel
            // 
            cIDADELabel.AutoSize = true;
            cIDADELabel.Location = new System.Drawing.Point(168, 170);
            cIDADELabel.Name = "cIDADELabel";
            cIDADELabel.Size = new System.Drawing.Size(75, 20);
            cIDADELabel.TabIndex = 7;
            cIDADELabel.Text = "CIDADE:";
            // 
            // cIDADETextBox
            // 
            this.cIDADETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dS_PESSOABindingSource, "CIDADE", true));
            this.cIDADETextBox.Location = new System.Drawing.Point(339, 167);
            this.cIDADETextBox.Name = "cIDADETextBox";
            this.cIDADETextBox.Size = new System.Drawing.Size(200, 26);
            this.cIDADETextBox.TabIndex = 8;
            // 
            // eMAILLabel
            // 
            eMAILLabel.AutoSize = true;
            eMAILLabel.Location = new System.Drawing.Point(168, 202);
            eMAILLabel.Name = "eMAILLabel";
            eMAILLabel.Size = new System.Drawing.Size(62, 20);
            eMAILLabel.TabIndex = 9;
            eMAILLabel.Text = "EMAIL:";
            // 
            // eMAILTextBox
            // 
            this.eMAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dS_PESSOABindingSource, "EMAIL", true));
            this.eMAILTextBox.Location = new System.Drawing.Point(339, 199);
            this.eMAILTextBox.Name = "eMAILTextBox";
            this.eMAILTextBox.Size = new System.Drawing.Size(200, 26);
            this.eMAILTextBox.TabIndex = 10;
            // 
            // dATA_NASCIMENTOLabel
            // 
            dATA_NASCIMENTOLabel.AutoSize = true;
            dATA_NASCIMENTOLabel.Location = new System.Drawing.Point(168, 235);
            dATA_NASCIMENTOLabel.Name = "dATA_NASCIMENTOLabel";
            dATA_NASCIMENTOLabel.Size = new System.Drawing.Size(165, 20);
            dATA_NASCIMENTOLabel.TabIndex = 11;
            dATA_NASCIMENTOLabel.Text = "DATA NASCIMENTO:";
            // 
            // dATA_NASCIMENTODateTimePicker
            // 
            this.dATA_NASCIMENTODateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dS_PESSOABindingSource, "DATA_NASCIMENTO", true));
            this.dATA_NASCIMENTODateTimePicker.Location = new System.Drawing.Point(339, 231);
            this.dATA_NASCIMENTODateTimePicker.Name = "dATA_NASCIMENTODateTimePicker";
            this.dATA_NASCIMENTODateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.dATA_NASCIMENTODateTimePicker.TabIndex = 12;
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
            this.dS_PESSOADataGridView.DataSource = this.dS_PESSOABindingSource;
            this.dS_PESSOADataGridView.Location = new System.Drawing.Point(12, 346);
            this.dS_PESSOADataGridView.Name = "dS_PESSOADataGridView";
            this.dS_PESSOADataGridView.RowHeadersWidth = 62;
            this.dS_PESSOADataGridView.RowTemplate.Height = 28;
            this.dS_PESSOADataGridView.Size = new System.Drawing.Size(964, 156);
            this.dS_PESSOADataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
            this.dataGridViewTextBoxColumn6.Width = 170;
            // 
            // frmcadpessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 606);
            this.Controls.Add(this.dS_PESSOADataGridView);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(nOMELabel);
            this.Controls.Add(this.nOMETextBox);
            this.Controls.Add(eNDERECOLabel);
            this.Controls.Add(this.eNDERECOTextBox);
            this.Controls.Add(cIDADELabel);
            this.Controls.Add(this.cIDADETextBox);
            this.Controls.Add(eMAILLabel);
            this.Controls.Add(this.eMAILTextBox);
            this.Controls.Add(dATA_NASCIMENTOLabel);
            this.Controls.Add(this.dATA_NASCIMENTODateTimePicker);
            this.Controls.Add(this.dS_PESSOABindingNavigator);
            this.Name = "frmcadpessoa";
            this.Text = "frmcadpessoa";
            this.Load += new System.EventHandler(this.frmcadpessoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_agenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_PESSOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_PESSOABindingNavigator)).EndInit();
            this.dS_PESSOABindingNavigator.ResumeLayout(false);
            this.dS_PESSOABindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_PESSOADataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dados.DataSet_agenda dataSet_agenda;
        private System.Windows.Forms.BindingSource dS_PESSOABindingSource;
        private dados.DataSet_agendaTableAdapters.DS_PESSOATableAdapter dS_PESSOATableAdapter;
        private dados.DataSet_agendaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dS_PESSOABindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton dS_PESSOABindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nOMETextBox;
        private System.Windows.Forms.TextBox eNDERECOTextBox;
        private System.Windows.Forms.TextBox cIDADETextBox;
        private System.Windows.Forms.TextBox eMAILTextBox;
        private System.Windows.Forms.DateTimePicker dATA_NASCIMENTODateTimePicker;
        private System.Windows.Forms.DataGridView dS_PESSOADataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}