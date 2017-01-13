namespace Apresentacao
{
    partial class FormD07LocalestoquePesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormD07LocalestoquePesquisa));
            this.txtFiltroGrid = new System.Windows.Forms.TextBox();
            this.dgvDadosLocal = new System.Windows.Forms.DataGridView();
            this.Columnseleciona = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtParametroPesquisa = new System.Windows.Forms.TextBox();
            this.cbxFiltroBusca = new System.Windows.Forms.ComboBox();
            this.cbxCriterioBusca = new System.Windows.Forms.ComboBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.btnExportarParaExcel = new System.Windows.Forms.Button();
            this.btnInverterSelecao = new System.Windows.Forms.Button();
            this.btnDesmarcaTudo = new System.Windows.Forms.Button();
            this.btnMarcaTudo = new System.Windows.Forms.Button();
            this.btnCarregaFiltrado = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.toolTipLocalEstoque = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosLocal)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFiltroGrid
            // 
            this.txtFiltroGrid.Location = new System.Drawing.Point(307, 53);
            this.txtFiltroGrid.Name = "txtFiltroGrid";
            this.txtFiltroGrid.Size = new System.Drawing.Size(374, 20);
            this.txtFiltroGrid.TabIndex = 30;
            // 
            // dgvDadosLocal
            // 
            this.dgvDadosLocal.AllowUserToDeleteRows = false;
            this.dgvDadosLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosLocal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columnseleciona,
            this.ColumnCodigo,
            this.ColumnDescricao});
            this.dgvDadosLocal.Location = new System.Drawing.Point(4, 85);
            this.dgvDadosLocal.Name = "dgvDadosLocal";
            this.dgvDadosLocal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDadosLocal.Size = new System.Drawing.Size(806, 306);
            this.dgvDadosLocal.TabIndex = 29;
            // 
            // Columnseleciona
            // 
            this.Columnseleciona.HeaderText = "SL";
            this.Columnseleciona.Name = "Columnseleciona";
            this.Columnseleciona.Width = 50;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.DataPropertyName = "D07_001_C";
            this.ColumnCodigo.HeaderText = "CÓDIGO";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.Width = 150;
            // 
            // ColumnDescricao
            // 
            this.ColumnDescricao.DataPropertyName = "D07_002_C";
            this.ColumnDescricao.HeaderText = "DESCRIÇÃO";
            this.ColumnDescricao.Name = "ColumnDescricao";
            this.ColumnDescricao.Width = 300;
            // 
            // txtParametroPesquisa
            // 
            this.txtParametroPesquisa.Location = new System.Drawing.Point(326, 4);
            this.txtParametroPesquisa.Name = "txtParametroPesquisa";
            this.txtParametroPesquisa.Size = new System.Drawing.Size(405, 20);
            this.txtParametroPesquisa.TabIndex = 27;
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
            this.cbxFiltroBusca.Location = new System.Drawing.Point(197, 4);
            this.cbxFiltroBusca.Name = "cbxFiltroBusca";
            this.cbxFiltroBusca.Size = new System.Drawing.Size(121, 21);
            this.cbxFiltroBusca.TabIndex = 26;
            // 
            // cbxCriterioBusca
            // 
            this.cbxCriterioBusca.FormattingEnabled = true;
            this.cbxCriterioBusca.Items.AddRange(new object[] {
            "Por Descrição",
            "Por Código"});
            this.cbxCriterioBusca.Location = new System.Drawing.Point(99, 4);
            this.cbxCriterioBusca.Name = "cbxCriterioBusca";
            this.cbxCriterioBusca.Size = new System.Drawing.Size(90, 21);
            this.cbxCriterioBusca.TabIndex = 25;
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(4, 8);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(95, 13);
            this.lblCriterio.TabIndex = 24;
            this.lblCriterio.Text = "Criterios de Busca:";
            // 
            // btnExportarParaExcel
            // 
            this.btnExportarParaExcel.Image = global::Apresentacao.Properties.Resources.MS_Excel_25px_1;
            this.btnExportarParaExcel.Location = new System.Drawing.Point(216, 44);
            this.btnExportarParaExcel.Name = "btnExportarParaExcel";
            this.btnExportarParaExcel.Size = new System.Drawing.Size(45, 37);
            this.btnExportarParaExcel.TabIndex = 35;
            this.btnExportarParaExcel.UseVisualStyleBackColor = true;
            // 
            // btnInverterSelecao
            // 
            this.btnInverterSelecao.Image = global::Apresentacao.Properties.Resources.Invert_Selection_25px;
            this.btnInverterSelecao.Location = new System.Drawing.Point(163, 44);
            this.btnInverterSelecao.Name = "btnInverterSelecao";
            this.btnInverterSelecao.Size = new System.Drawing.Size(45, 37);
            this.btnInverterSelecao.TabIndex = 34;
            this.btnInverterSelecao.UseVisualStyleBackColor = true;
            // 
            // btnDesmarcaTudo
            // 
            this.btnDesmarcaTudo.Image = global::Apresentacao.Properties.Resources.Unchecked_Checkbox_25px;
            this.btnDesmarcaTudo.Location = new System.Drawing.Point(110, 44);
            this.btnDesmarcaTudo.Name = "btnDesmarcaTudo";
            this.btnDesmarcaTudo.Size = new System.Drawing.Size(45, 37);
            this.btnDesmarcaTudo.TabIndex = 33;
            this.btnDesmarcaTudo.UseVisualStyleBackColor = true;
            // 
            // btnMarcaTudo
            // 
            this.btnMarcaTudo.Image = global::Apresentacao.Properties.Resources.Checked_Checkbox_25px;
            this.btnMarcaTudo.Location = new System.Drawing.Point(57, 44);
            this.btnMarcaTudo.Name = "btnMarcaTudo";
            this.btnMarcaTudo.Size = new System.Drawing.Size(45, 37);
            this.btnMarcaTudo.TabIndex = 32;
            this.btnMarcaTudo.UseVisualStyleBackColor = true;
            // 
            // btnCarregaFiltrado
            // 
            this.btnCarregaFiltrado.Image = global::Apresentacao.Properties.Resources.Uninstalling_Updates_25px_1;
            this.btnCarregaFiltrado.Location = new System.Drawing.Point(4, 44);
            this.btnCarregaFiltrado.Name = "btnCarregaFiltrado";
            this.btnCarregaFiltrado.Size = new System.Drawing.Size(45, 37);
            this.btnCarregaFiltrado.TabIndex = 31;
            this.btnCarregaFiltrado.UseVisualStyleBackColor = true;
            this.btnCarregaFiltrado.Click += new System.EventHandler(this.btnCarregaFiltrado_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::Apresentacao.Properties.Resources.Search_15px_1;
            this.btnPesquisar.Location = new System.Drawing.Point(739, 4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(71, 23);
            this.btnPesquisar.TabIndex = 28;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // FormD07LocalestoquePesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 393);
            this.Controls.Add(this.btnExportarParaExcel);
            this.Controls.Add(this.btnInverterSelecao);
            this.Controls.Add(this.btnDesmarcaTudo);
            this.Controls.Add(this.btnMarcaTudo);
            this.Controls.Add(this.btnCarregaFiltrado);
            this.Controls.Add(this.txtFiltroGrid);
            this.Controls.Add(this.dgvDadosLocal);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtParametroPesquisa);
            this.Controls.Add(this.cbxFiltroBusca);
            this.Controls.Add(this.cbxCriterioBusca);
            this.Controls.Add(this.lblCriterio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormD07LocalestoquePesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa Local de Estoque";
            this.Load += new System.EventHandler(this.FormD07LocalestoquePesquisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosLocal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExportarParaExcel;
        private System.Windows.Forms.Button btnInverterSelecao;
        private System.Windows.Forms.Button btnDesmarcaTudo;
        private System.Windows.Forms.Button btnMarcaTudo;
        private System.Windows.Forms.Button btnCarregaFiltrado;
        private System.Windows.Forms.TextBox txtFiltroGrid;
        private System.Windows.Forms.DataGridView dgvDadosLocal;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtParametroPesquisa;
        private System.Windows.Forms.ComboBox cbxFiltroBusca;
        private System.Windows.Forms.ComboBox cbxCriterioBusca;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Columnseleciona;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescricao;
        private System.Windows.Forms.ToolTip toolTipLocalEstoque;
    }
}