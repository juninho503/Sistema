namespace Apresentacao
{
    partial class FormD04Pesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormD04Pesquisa));
            this.lblCriterioBusca = new System.Windows.Forms.Label();
            this.cbxCriterioBusca = new System.Windows.Forms.ComboBox();
            this.cbxFiltroBusca = new System.Windows.Forms.ComboBox();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExportarParaExcel = new System.Windows.Forms.Button();
            this.btnInverterSelecao = new System.Windows.Forms.Button();
            this.btnDesmarcaTudo = new System.Windows.Forms.Button();
            this.btnMarcaTudo = new System.Windows.Forms.Button();
            this.btnCarregaFiltrado = new System.Windows.Forms.Button();
            this.txtFiltroGrid = new System.Windows.Forms.TextBox();
            this.dgvDadosProduto = new System.Windows.Forms.DataGridView();
            this.ColumnSeleciona = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnCodigoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFamilia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescFamilia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTipD04Pesquisar = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCriterioBusca
            // 
            this.lblCriterioBusca.AutoSize = true;
            this.lblCriterioBusca.Location = new System.Drawing.Point(5, 5);
            this.lblCriterioBusca.Name = "lblCriterioBusca";
            this.lblCriterioBusca.Size = new System.Drawing.Size(90, 13);
            this.lblCriterioBusca.TabIndex = 0;
            this.lblCriterioBusca.Text = "Criterio de Busca:";
            // 
            // cbxCriterioBusca
            // 
            this.cbxCriterioBusca.FormattingEnabled = true;
            this.cbxCriterioBusca.Items.AddRange(new object[] {
            "Por Descrição",
            "Por Codigo"});
            this.cbxCriterioBusca.Location = new System.Drawing.Point(99, 1);
            this.cbxCriterioBusca.Name = "cbxCriterioBusca";
            this.cbxCriterioBusca.Size = new System.Drawing.Size(121, 21);
            this.cbxCriterioBusca.TabIndex = 1;
            // 
            // cbxFiltroBusca
            // 
            this.cbxFiltroBusca.FormattingEnabled = true;
            this.cbxFiltroBusca.Items.AddRange(new object[] {
            "Iniciado Por",
            "Contem",
            "Igual",
            "Terminado Por",
            "Diferente De"});
            this.cbxFiltroBusca.Location = new System.Drawing.Point(226, 1);
            this.cbxFiltroBusca.Name = "cbxFiltroBusca";
            this.cbxFiltroBusca.Size = new System.Drawing.Size(121, 21);
            this.cbxFiltroBusca.TabIndex = 2;
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(353, 1);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(321, 20);
            this.txtBusca.TabIndex = 3;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::Apresentacao.Properties.Resources.Search_15px_1;
            this.btnPesquisar.Location = new System.Drawing.Point(698, 0);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 24);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnExportarParaExcel
            // 
            this.btnExportarParaExcel.Image = global::Apresentacao.Properties.Resources.MS_Excel_25px_1;
            this.btnExportarParaExcel.Location = new System.Drawing.Point(217, 43);
            this.btnExportarParaExcel.Name = "btnExportarParaExcel";
            this.btnExportarParaExcel.Size = new System.Drawing.Size(45, 37);
            this.btnExportarParaExcel.TabIndex = 17;
            this.btnExportarParaExcel.UseVisualStyleBackColor = true;
            // 
            // btnInverterSelecao
            // 
            this.btnInverterSelecao.Image = global::Apresentacao.Properties.Resources.Invert_Selection_25px;
            this.btnInverterSelecao.Location = new System.Drawing.Point(164, 43);
            this.btnInverterSelecao.Name = "btnInverterSelecao";
            this.btnInverterSelecao.Size = new System.Drawing.Size(45, 37);
            this.btnInverterSelecao.TabIndex = 16;
            this.btnInverterSelecao.UseVisualStyleBackColor = true;
            // 
            // btnDesmarcaTudo
            // 
            this.btnDesmarcaTudo.Image = global::Apresentacao.Properties.Resources.Unchecked_Checkbox_25px;
            this.btnDesmarcaTudo.Location = new System.Drawing.Point(111, 43);
            this.btnDesmarcaTudo.Name = "btnDesmarcaTudo";
            this.btnDesmarcaTudo.Size = new System.Drawing.Size(45, 37);
            this.btnDesmarcaTudo.TabIndex = 15;
            this.btnDesmarcaTudo.UseVisualStyleBackColor = true;
            // 
            // btnMarcaTudo
            // 
            this.btnMarcaTudo.Image = global::Apresentacao.Properties.Resources.Checked_Checkbox_25px;
            this.btnMarcaTudo.Location = new System.Drawing.Point(58, 43);
            this.btnMarcaTudo.Name = "btnMarcaTudo";
            this.btnMarcaTudo.Size = new System.Drawing.Size(45, 37);
            this.btnMarcaTudo.TabIndex = 14;
            this.btnMarcaTudo.UseVisualStyleBackColor = true;
            // 
            // btnCarregaFiltrado
            // 
            this.btnCarregaFiltrado.Image = global::Apresentacao.Properties.Resources.Uninstalling_Updates_25px_1;
            this.btnCarregaFiltrado.Location = new System.Drawing.Point(5, 43);
            this.btnCarregaFiltrado.Name = "btnCarregaFiltrado";
            this.btnCarregaFiltrado.Size = new System.Drawing.Size(45, 37);
            this.btnCarregaFiltrado.TabIndex = 13;
            this.btnCarregaFiltrado.UseVisualStyleBackColor = true;
            this.btnCarregaFiltrado.Click += new System.EventHandler(this.btnCarregaFiltrado_Click);
            // 
            // txtFiltroGrid
            // 
            this.txtFiltroGrid.Location = new System.Drawing.Point(300, 52);
            this.txtFiltroGrid.Name = "txtFiltroGrid";
            this.txtFiltroGrid.Size = new System.Drawing.Size(374, 20);
            this.txtFiltroGrid.TabIndex = 12;
            // 
            // dgvDadosProduto
            // 
            this.dgvDadosProduto.AllowUserToDeleteRows = false;
            this.dgvDadosProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSeleciona,
            this.ColumnCodigoProduto,
            this.ColumnDescricao,
            this.ColumnFamilia,
            this.ColumnDescFamilia});
            this.dgvDadosProduto.Location = new System.Drawing.Point(4, 86);
            this.dgvDadosProduto.Name = "dgvDadosProduto";
            this.dgvDadosProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDadosProduto.Size = new System.Drawing.Size(769, 361);
            this.dgvDadosProduto.TabIndex = 18;
            // 
            // ColumnSeleciona
            // 
            this.ColumnSeleciona.HeaderText = "SL";
            this.ColumnSeleciona.Name = "ColumnSeleciona";
            this.ColumnSeleciona.Width = 50;
            // 
            // ColumnCodigoProduto
            // 
            this.ColumnCodigoProduto.DataPropertyName = "D04_001_C";
            this.ColumnCodigoProduto.HeaderText = "CÓDIGO";
            this.ColumnCodigoProduto.Name = "ColumnCodigoProduto";
            // 
            // ColumnDescricao
            // 
            this.ColumnDescricao.DataPropertyName = "D04_002_C";
            this.ColumnDescricao.HeaderText = "DESCRIÇÃO";
            this.ColumnDescricao.Name = "ColumnDescricao";
            this.ColumnDescricao.Width = 325;
            // 
            // ColumnFamilia
            // 
            this.ColumnFamilia.DataPropertyName = "codigoFamilia";
            this.ColumnFamilia.HeaderText = "COD.FAMILIA";
            this.ColumnFamilia.Name = "ColumnFamilia";
            // 
            // ColumnDescFamilia
            // 
            this.ColumnDescFamilia.DataPropertyName = "nomeFamilia";
            this.ColumnDescFamilia.HeaderText = "DESCRIÇÃO.FAMILIA";
            this.ColumnDescFamilia.Name = "ColumnDescFamilia";
            this.ColumnDescFamilia.Width = 150;
            // 
            // FormD04Pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 449);
            this.Controls.Add(this.dgvDadosProduto);
            this.Controls.Add(this.btnExportarParaExcel);
            this.Controls.Add(this.btnInverterSelecao);
            this.Controls.Add(this.btnDesmarcaTudo);
            this.Controls.Add(this.btnMarcaTudo);
            this.Controls.Add(this.btnCarregaFiltrado);
            this.Controls.Add(this.txtFiltroGrid);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.cbxFiltroBusca);
            this.Controls.Add(this.cbxCriterioBusca);
            this.Controls.Add(this.lblCriterioBusca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormD04Pesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Produto";
            this.Load += new System.EventHandler(this.FormD04Pesquisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCriterioBusca;
        private System.Windows.Forms.ComboBox cbxCriterioBusca;
        private System.Windows.Forms.ComboBox cbxFiltroBusca;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExportarParaExcel;
        private System.Windows.Forms.Button btnInverterSelecao;
        private System.Windows.Forms.Button btnDesmarcaTudo;
        private System.Windows.Forms.Button btnMarcaTudo;
        private System.Windows.Forms.Button btnCarregaFiltrado;
        private System.Windows.Forms.TextBox txtFiltroGrid;
        private System.Windows.Forms.DataGridView dgvDadosProduto;
        private System.Windows.Forms.ToolTip toolTipD04Pesquisar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnSeleciona;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFamilia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescFamilia;
    }
}