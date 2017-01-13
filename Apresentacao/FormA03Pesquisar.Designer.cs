namespace Apresentacao
{
    partial class FormA03Pesquisar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormA03Pesquisar));
            this.lblCriteriosPesquisa = new System.Windows.Forms.Label();
            this.cbxCriterioPesquisa = new System.Windows.Forms.ComboBox();
            this.cbxOpcaoCriterio = new System.Windows.Forms.ComboBox();
            this.txtCriterioPesquisa = new System.Windows.Forms.TextBox();
            this.txtFiltroGrid = new System.Windows.Forms.TextBox();
            this.dgvPesquisaA03 = new System.Windows.Forms.DataGridView();
            this.ColumnSeleciona = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columncpf_cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDesmarcaTudo = new System.Windows.Forms.Button();
            this.btnInverterSelecao = new System.Windows.Forms.Button();
            this.btnExportarParaExcel = new System.Windows.Forms.Button();
            this.btnMarcaTudo = new System.Windows.Forms.Button();
            this.btnCarregaFiltrado = new System.Windows.Forms.Button();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.toolTipA03Pesqusiar = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisaA03)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCriteriosPesquisa
            // 
            this.lblCriteriosPesquisa.AutoSize = true;
            this.lblCriteriosPesquisa.Location = new System.Drawing.Point(9, 6);
            this.lblCriteriosPesquisa.Name = "lblCriteriosPesquisa";
            this.lblCriteriosPesquisa.Size = new System.Drawing.Size(95, 13);
            this.lblCriteriosPesquisa.TabIndex = 0;
            this.lblCriteriosPesquisa.Text = "Criterios da Busca:";
            // 
            // cbxCriterioPesquisa
            // 
            this.cbxCriterioPesquisa.FormattingEnabled = true;
            this.cbxCriterioPesquisa.Items.AddRange(new object[] {
            "Código",
            "Nome",
            "Uf",
            "Cnpj\\Cpf"});
            this.cbxCriterioPesquisa.Location = new System.Drawing.Point(105, 2);
            this.cbxCriterioPesquisa.Name = "cbxCriterioPesquisa";
            this.cbxCriterioPesquisa.Size = new System.Drawing.Size(121, 21);
            this.cbxCriterioPesquisa.TabIndex = 1;
            // 
            // cbxOpcaoCriterio
            // 
            this.cbxOpcaoCriterio.FormattingEnabled = true;
            this.cbxOpcaoCriterio.Items.AddRange(new object[] {
            "Iniciado Por",
            "Contem",
            "Igual",
            "Terminado Por",
            "Diferente De"});
            this.cbxOpcaoCriterio.Location = new System.Drawing.Point(235, 2);
            this.cbxOpcaoCriterio.Name = "cbxOpcaoCriterio";
            this.cbxOpcaoCriterio.Size = new System.Drawing.Size(121, 21);
            this.cbxOpcaoCriterio.TabIndex = 2;
            // 
            // txtCriterioPesquisa
            // 
            this.txtCriterioPesquisa.Location = new System.Drawing.Point(362, 2);
            this.txtCriterioPesquisa.Name = "txtCriterioPesquisa";
            this.txtCriterioPesquisa.Size = new System.Drawing.Size(474, 20);
            this.txtCriterioPesquisa.TabIndex = 3;
            // 
            // txtFiltroGrid
            // 
            this.txtFiltroGrid.Location = new System.Drawing.Point(363, 64);
            this.txtFiltroGrid.Name = "txtFiltroGrid";
            this.txtFiltroGrid.Size = new System.Drawing.Size(374, 20);
            this.txtFiltroGrid.TabIndex = 5;
            // 
            // dgvPesquisaA03
            // 
            this.dgvPesquisaA03.AllowUserToDeleteRows = false;
            this.dgvPesquisaA03.AllowUserToOrderColumns = true;
            this.dgvPesquisaA03.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisaA03.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSeleciona,
            this.ColumnCodigo,
            this.ColumnNome,
            this.Columncpf_cnpj,
            this.ColumnUf,
            this.ColumnCidade});
            this.dgvPesquisaA03.Location = new System.Drawing.Point(12, 101);
            this.dgvPesquisaA03.MultiSelect = false;
            this.dgvPesquisaA03.Name = "dgvPesquisaA03";
            this.dgvPesquisaA03.Size = new System.Drawing.Size(945, 319);
            this.dgvPesquisaA03.TabIndex = 6;
            // 
            // ColumnSeleciona
            // 
            this.ColumnSeleciona.HeaderText = "SL";
            this.ColumnSeleciona.Name = "ColumnSeleciona";
            this.ColumnSeleciona.Width = 50;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.DataPropertyName = "A03_001_C";
            this.ColumnCodigo.HeaderText = "CÓDIGO";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.Width = 150;
            // 
            // ColumnNome
            // 
            this.ColumnNome.DataPropertyName = "A03_003_C";
            this.ColumnNome.HeaderText = "NOME";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.Width = 300;
            // 
            // Columncpf_cnpj
            // 
            this.Columncpf_cnpj.DataPropertyName = "A03_007_C";
            this.Columncpf_cnpj.HeaderText = "CPF\\CNPJ";
            this.Columncpf_cnpj.Name = "Columncpf_cnpj";
            this.Columncpf_cnpj.Width = 150;
            // 
            // ColumnUf
            // 
            this.ColumnUf.DataPropertyName = "ufEstado";
            this.ColumnUf.HeaderText = "UF";
            this.ColumnUf.Name = "ColumnUf";
            this.ColumnUf.Width = 50;
            // 
            // ColumnCidade
            // 
            this.ColumnCidade.DataPropertyName = "nomeCidade";
            this.ColumnCidade.HeaderText = "CIDADE";
            this.ColumnCidade.Name = "ColumnCidade";
            this.ColumnCidade.Width = 200;
            // 
            // btnDesmarcaTudo
            // 
            this.btnDesmarcaTudo.Image = global::Apresentacao.Properties.Resources.Unchecked_Checkbox_25px;
            this.btnDesmarcaTudo.Location = new System.Drawing.Point(110, 56);
            this.btnDesmarcaTudo.Name = "btnDesmarcaTudo";
            this.btnDesmarcaTudo.Size = new System.Drawing.Size(45, 37);
            this.btnDesmarcaTudo.TabIndex = 9;
            this.btnDesmarcaTudo.UseVisualStyleBackColor = true;
            // 
            // btnInverterSelecao
            // 
            this.btnInverterSelecao.Image = global::Apresentacao.Properties.Resources.Invert_Selection_25px;
            this.btnInverterSelecao.Location = new System.Drawing.Point(159, 56);
            this.btnInverterSelecao.Name = "btnInverterSelecao";
            this.btnInverterSelecao.Size = new System.Drawing.Size(45, 37);
            this.btnInverterSelecao.TabIndex = 10;
            this.btnInverterSelecao.UseVisualStyleBackColor = true;
            // 
            // btnExportarParaExcel
            // 
            this.btnExportarParaExcel.Image = global::Apresentacao.Properties.Resources.MS_Excel_25px_1;
            this.btnExportarParaExcel.Location = new System.Drawing.Point(208, 56);
            this.btnExportarParaExcel.Name = "btnExportarParaExcel";
            this.btnExportarParaExcel.Size = new System.Drawing.Size(45, 37);
            this.btnExportarParaExcel.TabIndex = 11;
            this.btnExportarParaExcel.UseVisualStyleBackColor = true;
            // 
            // btnMarcaTudo
            // 
            this.btnMarcaTudo.Image = global::Apresentacao.Properties.Resources.Checked_Checkbox_25px;
            this.btnMarcaTudo.Location = new System.Drawing.Point(61, 56);
            this.btnMarcaTudo.Name = "btnMarcaTudo";
            this.btnMarcaTudo.Size = new System.Drawing.Size(45, 37);
            this.btnMarcaTudo.TabIndex = 8;
            this.btnMarcaTudo.UseVisualStyleBackColor = true;
            // 
            // btnCarregaFiltrado
            // 
            this.btnCarregaFiltrado.Image = global::Apresentacao.Properties.Resources.Uninstalling_Updates_25px_1;
            this.btnCarregaFiltrado.Location = new System.Drawing.Point(12, 56);
            this.btnCarregaFiltrado.Name = "btnCarregaFiltrado";
            this.btnCarregaFiltrado.Size = new System.Drawing.Size(45, 37);
            this.btnCarregaFiltrado.TabIndex = 7;
            this.btnCarregaFiltrado.UseVisualStyleBackColor = true;
            this.btnCarregaFiltrado.Click += new System.EventHandler(this.btnCarregaFiltrado_Click);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Image = global::Apresentacao.Properties.Resources.Search_25px;
            this.btnPesquisa.Location = new System.Drawing.Point(870, 2);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(87, 37);
            this.btnPesquisa.TabIndex = 4;
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // FormA03Pesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 520);
            this.Controls.Add(this.btnExportarParaExcel);
            this.Controls.Add(this.btnInverterSelecao);
            this.Controls.Add(this.btnDesmarcaTudo);
            this.Controls.Add(this.btnMarcaTudo);
            this.Controls.Add(this.btnCarregaFiltrado);
            this.Controls.Add(this.dgvPesquisaA03);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.txtFiltroGrid);
            this.Controls.Add(this.txtCriterioPesquisa);
            this.Controls.Add(this.cbxOpcaoCriterio);
            this.Controls.Add(this.cbxCriterioPesquisa);
            this.Controls.Add(this.lblCriteriosPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormA03Pesquisar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa Parceiro";
            this.Load += new System.EventHandler(this.FormA03Pesquisar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisaA03)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCriteriosPesquisa;
        private System.Windows.Forms.ComboBox cbxCriterioPesquisa;
        private System.Windows.Forms.ComboBox cbxOpcaoCriterio;
        private System.Windows.Forms.TextBox txtCriterioPesquisa;
        private System.Windows.Forms.TextBox txtFiltroGrid;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.DataGridView dgvPesquisaA03;
        private System.Windows.Forms.Button btnCarregaFiltrado;
        private System.Windows.Forms.Button btnMarcaTudo;
        private System.Windows.Forms.Button btnDesmarcaTudo;
        private System.Windows.Forms.Button btnInverterSelecao;
        private System.Windows.Forms.Button btnExportarParaExcel;
        private System.Windows.Forms.ToolTip toolTipA03Pesqusiar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnSeleciona;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columncpf_cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUf;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCidade;
    }
}