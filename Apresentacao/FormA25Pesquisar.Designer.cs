namespace Apresentacao
{
    partial class FormA25Pesquisar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormA25Pesquisar));
            this.lblCepPesquisa = new System.Windows.Forms.Label();
            this.txtCepPesquisa = new System.Windows.Forms.TextBox();
            this.cbxCepPesquisa = new System.Windows.Forms.ComboBox();
            this.dgvCep = new System.Windows.Forms.DataGridView();
            this.selecionaColum = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCarregaSelecionado = new System.Windows.Forms.Button();
            this.btnPesquisaCep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCep)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCepPesquisa
            // 
            this.lblCepPesquisa.AutoSize = true;
            this.lblCepPesquisa.Location = new System.Drawing.Point(12, 10);
            this.lblCepPesquisa.Name = "lblCepPesquisa";
            this.lblCepPesquisa.Size = new System.Drawing.Size(29, 13);
            this.lblCepPesquisa.TabIndex = 0;
            this.lblCepPesquisa.Text = "Cep:";
            // 
            // txtCepPesquisa
            // 
            this.txtCepPesquisa.Location = new System.Drawing.Point(172, 6);
            this.txtCepPesquisa.Name = "txtCepPesquisa";
            this.txtCepPesquisa.Size = new System.Drawing.Size(209, 20);
            this.txtCepPesquisa.TabIndex = 1;
            // 
            // cbxCepPesquisa
            // 
            this.cbxCepPesquisa.FormattingEnabled = true;
            this.cbxCepPesquisa.Items.AddRange(new object[] {
            "Iniciado Por",
            "Contem",
            "Igual",
            "Terminado Por",
            "Diferente De"});
            this.cbxCepPesquisa.Location = new System.Drawing.Point(45, 6);
            this.cbxCepPesquisa.Name = "cbxCepPesquisa";
            this.cbxCepPesquisa.Size = new System.Drawing.Size(121, 21);
            this.cbxCepPesquisa.TabIndex = 2;
            // 
            // dgvCep
            // 
            this.dgvCep.AllowUserToDeleteRows = false;
            this.dgvCep.AllowUserToOrderColumns = true;
            this.dgvCep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selecionaColum,
            this.Cep,
            this.cidadeColum,
            this.estadoColum,
            this.paisColum});
            this.dgvCep.Location = new System.Drawing.Point(12, 90);
            this.dgvCep.MultiSelect = false;
            this.dgvCep.Name = "dgvCep";
            this.dgvCep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCep.Size = new System.Drawing.Size(771, 424);
            this.dgvCep.TabIndex = 4;
            // 
            // selecionaColum
            // 
            this.selecionaColum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.selecionaColum.FalseValue = "0";
            this.selecionaColum.HeaderText = "SL";
            this.selecionaColum.Name = "selecionaColum";
            this.selecionaColum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.selecionaColum.TrueValue = "1";
            // 
            // Cep
            // 
            this.Cep.DataPropertyName = "A25_001_C";
            this.Cep.HeaderText = "CEP";
            this.Cep.Name = "Cep";
            this.Cep.ReadOnly = true;
            this.Cep.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // cidadeColum
            // 
            this.cidadeColum.DataPropertyName = "nomeCidade";
            this.cidadeColum.HeaderText = "CIDADE";
            this.cidadeColum.Name = "cidadeColum";
            this.cidadeColum.ReadOnly = true;
            this.cidadeColum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.cidadeColum.Width = 250;
            // 
            // estadoColum
            // 
            this.estadoColum.DataPropertyName = "nomeEstado";
            this.estadoColum.HeaderText = "ESTADO";
            this.estadoColum.Name = "estadoColum";
            this.estadoColum.ReadOnly = true;
            this.estadoColum.Width = 150;
            // 
            // paisColum
            // 
            this.paisColum.DataPropertyName = "nomePais";
            this.paisColum.HeaderText = "PAIS";
            this.paisColum.Name = "paisColum";
            this.paisColum.ReadOnly = true;
            this.paisColum.Width = 180;
            // 
            // btnCarregaSelecionado
            // 
            this.btnCarregaSelecionado.Image = global::Apresentacao.Properties.Resources.Uninstalling_Updates_25px_1;
            this.btnCarregaSelecionado.Location = new System.Drawing.Point(12, 43);
            this.btnCarregaSelecionado.Name = "btnCarregaSelecionado";
            this.btnCarregaSelecionado.Size = new System.Drawing.Size(45, 37);
            this.btnCarregaSelecionado.TabIndex = 5;
            this.btnCarregaSelecionado.UseVisualStyleBackColor = true;
            this.btnCarregaSelecionado.Click += new System.EventHandler(this.btnCarregaSelecionado_Click);
            // 
            // btnPesquisaCep
            // 
            this.btnPesquisaCep.Image = global::Apresentacao.Properties.Resources.Search_15px_1;
            this.btnPesquisaCep.Location = new System.Drawing.Point(387, 5);
            this.btnPesquisaCep.Name = "btnPesquisaCep";
            this.btnPesquisaCep.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisaCep.TabIndex = 3;
            this.btnPesquisaCep.UseVisualStyleBackColor = true;
            this.btnPesquisaCep.Click += new System.EventHandler(this.btnPesquisaCep_Click);
            // 
            // FormA25Pesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 526);
            this.Controls.Add(this.btnCarregaSelecionado);
            this.Controls.Add(this.dgvCep);
            this.Controls.Add(this.btnPesquisaCep);
            this.Controls.Add(this.cbxCepPesquisa);
            this.Controls.Add(this.txtCepPesquisa);
            this.Controls.Add(this.lblCepPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormA25Pesquisar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa Cep";
            this.Load += new System.EventHandler(this.FormA25Pesquisar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCepPesquisa;
        private System.Windows.Forms.TextBox txtCepPesquisa;
        private System.Windows.Forms.ComboBox cbxCepPesquisa;
        private System.Windows.Forms.Button btnPesquisaCep;
        private System.Windows.Forms.DataGridView dgvCep;
        private System.Windows.Forms.Button btnCarregaSelecionado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selecionaColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisColum;
    }
}