namespace Apresentacao
{
    partial class FormD03Pesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormD03Pesquisa));
            this.lblCriterio = new System.Windows.Forms.Label();
            this.cbxCriterioBusca = new System.Windows.Forms.ComboBox();
            this.cbxFiltroBusca = new System.Windows.Forms.ComboBox();
            this.txtParametroPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvDadosFamilia = new System.Windows.Forms.DataGridView();
            this.Columnseleciona = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExportarParaExcel = new System.Windows.Forms.Button();
            this.btnInverterSelecao = new System.Windows.Forms.Button();
            this.btnDesmarcaTudo = new System.Windows.Forms.Button();
            this.btnMarcaTudo = new System.Windows.Forms.Button();
            this.btnCarregaFiltrado = new System.Windows.Forms.Button();
            this.txtFiltroGrid = new System.Windows.Forms.TextBox();
            this.toolTipD03Pesquisa = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosFamilia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(5, 5);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(95, 13);
            this.lblCriterio.TabIndex = 0;
            this.lblCriterio.Text = "Criterios de Busca:";
            // 
            // cbxCriterioBusca
            // 
            this.cbxCriterioBusca.FormattingEnabled = true;
            this.cbxCriterioBusca.Items.AddRange(new object[] {
            "Por Descrição",
            "Por Código"});
            this.cbxCriterioBusca.Location = new System.Drawing.Point(100, 1);
            this.cbxCriterioBusca.Name = "cbxCriterioBusca";
            this.cbxCriterioBusca.Size = new System.Drawing.Size(90, 21);
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
            this.cbxFiltroBusca.Location = new System.Drawing.Point(198, 1);
            this.cbxFiltroBusca.Name = "cbxFiltroBusca";
            this.cbxFiltroBusca.Size = new System.Drawing.Size(121, 21);
            this.cbxFiltroBusca.TabIndex = 2;
            // 
            // txtParametroPesquisa
            // 
            this.txtParametroPesquisa.Location = new System.Drawing.Point(327, 1);
            this.txtParametroPesquisa.Name = "txtParametroPesquisa";
            this.txtParametroPesquisa.Size = new System.Drawing.Size(405, 20);
            this.txtParametroPesquisa.TabIndex = 3;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::Apresentacao.Properties.Resources.Search_15px_1;
            this.btnPesquisar.Location = new System.Drawing.Point(740, 1);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(71, 23);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dgvDadosFamilia
            // 
            this.dgvDadosFamilia.AllowUserToDeleteRows = false;
            this.dgvDadosFamilia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosFamilia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columnseleciona,
            this.ColumnCodigo,
            this.ColumnDescricao});
            this.dgvDadosFamilia.Location = new System.Drawing.Point(5, 82);
            this.dgvDadosFamilia.Name = "dgvDadosFamilia";
            this.dgvDadosFamilia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDadosFamilia.Size = new System.Drawing.Size(806, 306);
            this.dgvDadosFamilia.TabIndex = 5;
            // 
            // Columnseleciona
            // 
            this.Columnseleciona.HeaderText = "SL";
            this.Columnseleciona.Name = "Columnseleciona";
            this.Columnseleciona.Width = 50;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.DataPropertyName = "D03_001_C";
            this.ColumnCodigo.HeaderText = "CÓDIGO";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.Width = 150;
            // 
            // ColumnDescricao
            // 
            this.ColumnDescricao.DataPropertyName = "D03_002_C";
            this.ColumnDescricao.HeaderText = "DESCRIÇÃO";
            this.ColumnDescricao.Name = "ColumnDescricao";
            this.ColumnDescricao.Width = 300;
            // 
            // btnExportarParaExcel
            // 
            this.btnExportarParaExcel.Image = global::Apresentacao.Properties.Resources.MS_Excel_25px_1;
            this.btnExportarParaExcel.Location = new System.Drawing.Point(217, 41);
            this.btnExportarParaExcel.Name = "btnExportarParaExcel";
            this.btnExportarParaExcel.Size = new System.Drawing.Size(45, 37);
            this.btnExportarParaExcel.TabIndex = 23;
            this.btnExportarParaExcel.UseVisualStyleBackColor = true;
            // 
            // btnInverterSelecao
            // 
            this.btnInverterSelecao.Image = global::Apresentacao.Properties.Resources.Invert_Selection_25px;
            this.btnInverterSelecao.Location = new System.Drawing.Point(164, 41);
            this.btnInverterSelecao.Name = "btnInverterSelecao";
            this.btnInverterSelecao.Size = new System.Drawing.Size(45, 37);
            this.btnInverterSelecao.TabIndex = 22;
            this.btnInverterSelecao.UseVisualStyleBackColor = true;
            // 
            // btnDesmarcaTudo
            // 
            this.btnDesmarcaTudo.Image = global::Apresentacao.Properties.Resources.Unchecked_Checkbox_25px;
            this.btnDesmarcaTudo.Location = new System.Drawing.Point(111, 41);
            this.btnDesmarcaTudo.Name = "btnDesmarcaTudo";
            this.btnDesmarcaTudo.Size = new System.Drawing.Size(45, 37);
            this.btnDesmarcaTudo.TabIndex = 21;
            this.btnDesmarcaTudo.UseVisualStyleBackColor = true;
            // 
            // btnMarcaTudo
            // 
            this.btnMarcaTudo.Image = global::Apresentacao.Properties.Resources.Checked_Checkbox_25px;
            this.btnMarcaTudo.Location = new System.Drawing.Point(58, 41);
            this.btnMarcaTudo.Name = "btnMarcaTudo";
            this.btnMarcaTudo.Size = new System.Drawing.Size(45, 37);
            this.btnMarcaTudo.TabIndex = 20;
            this.btnMarcaTudo.UseVisualStyleBackColor = true;
            // 
            // btnCarregaFiltrado
            // 
            this.btnCarregaFiltrado.Image = global::Apresentacao.Properties.Resources.Uninstalling_Updates_25px_1;
            this.btnCarregaFiltrado.Location = new System.Drawing.Point(5, 41);
            this.btnCarregaFiltrado.Name = "btnCarregaFiltrado";
            this.btnCarregaFiltrado.Size = new System.Drawing.Size(45, 37);
            this.btnCarregaFiltrado.TabIndex = 19;
            this.btnCarregaFiltrado.UseVisualStyleBackColor = true;
            this.btnCarregaFiltrado.Click += new System.EventHandler(this.btnCarregaFiltrado_Click);
            // 
            // txtFiltroGrid
            // 
            this.txtFiltroGrid.Location = new System.Drawing.Point(308, 50);
            this.txtFiltroGrid.Name = "txtFiltroGrid";
            this.txtFiltroGrid.Size = new System.Drawing.Size(374, 20);
            this.txtFiltroGrid.TabIndex = 18;
            // 
            // FormD03Pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 393);
            this.Controls.Add(this.btnExportarParaExcel);
            this.Controls.Add(this.btnInverterSelecao);
            this.Controls.Add(this.btnDesmarcaTudo);
            this.Controls.Add(this.btnMarcaTudo);
            this.Controls.Add(this.btnCarregaFiltrado);
            this.Controls.Add(this.txtFiltroGrid);
            this.Controls.Add(this.dgvDadosFamilia);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtParametroPesquisa);
            this.Controls.Add(this.cbxFiltroBusca);
            this.Controls.Add(this.cbxCriterioBusca);
            this.Controls.Add(this.lblCriterio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormD03Pesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Familia";
            this.Load += new System.EventHandler(this.FormD03Pesquisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosFamilia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.ComboBox cbxCriterioBusca;
        private System.Windows.Forms.ComboBox cbxFiltroBusca;
        private System.Windows.Forms.TextBox txtParametroPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvDadosFamilia;
        private System.Windows.Forms.Button btnExportarParaExcel;
        private System.Windows.Forms.Button btnInverterSelecao;
        private System.Windows.Forms.Button btnDesmarcaTudo;
        private System.Windows.Forms.Button btnMarcaTudo;
        private System.Windows.Forms.Button btnCarregaFiltrado;
        private System.Windows.Forms.TextBox txtFiltroGrid;
        private System.Windows.Forms.ToolTip toolTipD03Pesquisa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Columnseleciona;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescricao;
    }
}