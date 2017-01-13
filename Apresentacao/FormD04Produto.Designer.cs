namespace Apresentacao
{
    partial class FormD04Produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormD04Produto));
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigoObg = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricaoObg = new System.Windows.Forms.TextBox();
            this.lblUnidadeMedida = new System.Windows.Forms.Label();
            this.txtUnidadeMedidaObg = new System.Windows.Forms.TextBox();
            this.lblPrecoCusto = new System.Windows.Forms.Label();
            this.nudPrecoCusto = new System.Windows.Forms.NumericUpDown();
            this.lblPrecoVenda = new System.Windows.Forms.Label();
            this.nudPrecoVenda = new System.Windows.Forms.NumericUpDown();
            this.lblNcm = new System.Windows.Forms.Label();
            this.txtNcmObg = new System.Windows.Forms.TextBox();
            this.lblPesoBruto = new System.Windows.Forms.Label();
            this.nudPesoBruto = new System.Windows.Forms.NumericUpDown();
            this.nudPesoLiquido = new System.Windows.Forms.NumericUpDown();
            this.lblPesoLiquido = new System.Windows.Forms.Label();
            this.lblFamilia = new System.Windows.Forms.Label();
            this.cbxFamilia = new System.Windows.Forms.ComboBox();
            this.btnPesquisaParceiro = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.toolTipCadastroProduto = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecoCusto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecoVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPesoBruto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPesoLiquido)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(69, 57);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código:";
            // 
            // txtCodigoObg
            // 
            this.txtCodigoObg.Enabled = false;
            this.txtCodigoObg.Location = new System.Drawing.Point(112, 53);
            this.txtCodigoObg.Name = "txtCodigoObg";
            this.txtCodigoObg.Size = new System.Drawing.Size(89, 20);
            this.txtCodigoObg.TabIndex = 2;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(201, 57);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 3;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtDescricaoObg
            // 
            this.txtDescricaoObg.Enabled = false;
            this.txtDescricaoObg.Location = new System.Drawing.Point(259, 53);
            this.txtDescricaoObg.Name = "txtDescricaoObg";
            this.txtDescricaoObg.Size = new System.Drawing.Size(235, 20);
            this.txtDescricaoObg.TabIndex = 4;
            // 
            // lblUnidadeMedida
            // 
            this.lblUnidadeMedida.AutoSize = true;
            this.lblUnidadeMedida.Location = new System.Drawing.Point(9, 80);
            this.lblUnidadeMedida.Name = "lblUnidadeMedida";
            this.lblUnidadeMedida.Size = new System.Drawing.Size(103, 13);
            this.lblUnidadeMedida.TabIndex = 5;
            this.lblUnidadeMedida.Text = "Unidade de Medida:";
            // 
            // txtUnidadeMedidaObg
            // 
            this.txtUnidadeMedidaObg.Enabled = false;
            this.txtUnidadeMedidaObg.Location = new System.Drawing.Point(112, 76);
            this.txtUnidadeMedidaObg.Name = "txtUnidadeMedidaObg";
            this.txtUnidadeMedidaObg.Size = new System.Drawing.Size(51, 20);
            this.txtUnidadeMedidaObg.TabIndex = 6;
            // 
            // lblPrecoCusto
            // 
            this.lblPrecoCusto.AutoSize = true;
            this.lblPrecoCusto.Location = new System.Drawing.Point(163, 80);
            this.lblPrecoCusto.Name = "lblPrecoCusto";
            this.lblPrecoCusto.Size = new System.Drawing.Size(83, 13);
            this.lblPrecoCusto.TabIndex = 7;
            this.lblPrecoCusto.Text = "Preço de Custo:";
            // 
            // nudPrecoCusto
            // 
            this.nudPrecoCusto.DecimalPlaces = 6;
            this.nudPrecoCusto.Enabled = false;
            this.nudPrecoCusto.Location = new System.Drawing.Point(248, 76);
            this.nudPrecoCusto.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudPrecoCusto.Name = "nudPrecoCusto";
            this.nudPrecoCusto.Size = new System.Drawing.Size(72, 20);
            this.nudPrecoCusto.TabIndex = 8;
            this.nudPrecoCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPrecoVenda
            // 
            this.lblPrecoVenda.AutoSize = true;
            this.lblPrecoVenda.Location = new System.Drawing.Point(320, 80);
            this.lblPrecoVenda.Name = "lblPrecoVenda";
            this.lblPrecoVenda.Size = new System.Drawing.Size(87, 13);
            this.lblPrecoVenda.TabIndex = 9;
            this.lblPrecoVenda.Text = "Preço de Venda:";
            // 
            // nudPrecoVenda
            // 
            this.nudPrecoVenda.DecimalPlaces = 6;
            this.nudPrecoVenda.Enabled = false;
            this.nudPrecoVenda.Location = new System.Drawing.Point(407, 76);
            this.nudPrecoVenda.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudPrecoVenda.Name = "nudPrecoVenda";
            this.nudPrecoVenda.Size = new System.Drawing.Size(87, 20);
            this.nudPrecoVenda.TabIndex = 10;
            this.nudPrecoVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPrecoVenda.ThousandsSeparator = true;
            // 
            // lblNcm
            // 
            this.lblNcm.AutoSize = true;
            this.lblNcm.Location = new System.Drawing.Point(78, 101);
            this.lblNcm.Name = "lblNcm";
            this.lblNcm.Size = new System.Drawing.Size(34, 13);
            this.lblNcm.TabIndex = 11;
            this.lblNcm.Text = "NCM:";
            // 
            // txtNcmObg
            // 
            this.txtNcmObg.Enabled = false;
            this.txtNcmObg.Location = new System.Drawing.Point(112, 98);
            this.txtNcmObg.MaxLength = 8;
            this.txtNcmObg.Name = "txtNcmObg";
            this.txtNcmObg.Size = new System.Drawing.Size(62, 20);
            this.txtNcmObg.TabIndex = 12;
            this.txtNcmObg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNcm_KeyPress);
            // 
            // lblPesoBruto
            // 
            this.lblPesoBruto.AutoSize = true;
            this.lblPesoBruto.Location = new System.Drawing.Point(184, 102);
            this.lblPesoBruto.Name = "lblPesoBruto";
            this.lblPesoBruto.Size = new System.Drawing.Size(62, 13);
            this.lblPesoBruto.TabIndex = 13;
            this.lblPesoBruto.Text = "Peso Bruto:";
            // 
            // nudPesoBruto
            // 
            this.nudPesoBruto.DecimalPlaces = 6;
            this.nudPesoBruto.Enabled = false;
            this.nudPesoBruto.Location = new System.Drawing.Point(248, 98);
            this.nudPesoBruto.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudPesoBruto.Name = "nudPesoBruto";
            this.nudPesoBruto.Size = new System.Drawing.Size(72, 20);
            this.nudPesoBruto.TabIndex = 14;
            this.nudPesoBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudPesoLiquido
            // 
            this.nudPesoLiquido.DecimalPlaces = 6;
            this.nudPesoLiquido.Enabled = false;
            this.nudPesoLiquido.Location = new System.Drawing.Point(407, 98);
            this.nudPesoLiquido.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudPesoLiquido.Name = "nudPesoLiquido";
            this.nudPesoLiquido.Size = new System.Drawing.Size(87, 20);
            this.nudPesoLiquido.TabIndex = 16;
            this.nudPesoLiquido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPesoLiquido
            // 
            this.lblPesoLiquido.AutoSize = true;
            this.lblPesoLiquido.Location = new System.Drawing.Point(336, 102);
            this.lblPesoLiquido.Name = "lblPesoLiquido";
            this.lblPesoLiquido.Size = new System.Drawing.Size(71, 13);
            this.lblPesoLiquido.TabIndex = 15;
            this.lblPesoLiquido.Text = "Peso Liquido:";
            // 
            // lblFamilia
            // 
            this.lblFamilia.AutoSize = true;
            this.lblFamilia.Location = new System.Drawing.Point(70, 124);
            this.lblFamilia.Name = "lblFamilia";
            this.lblFamilia.Size = new System.Drawing.Size(42, 13);
            this.lblFamilia.TabIndex = 17;
            this.lblFamilia.Text = "Familia:";
            // 
            // cbxFamilia
            // 
            this.cbxFamilia.Enabled = false;
            this.cbxFamilia.FormattingEnabled = true;
            this.cbxFamilia.Location = new System.Drawing.Point(112, 120);
            this.cbxFamilia.Name = "cbxFamilia";
            this.cbxFamilia.Size = new System.Drawing.Size(208, 21);
            this.cbxFamilia.TabIndex = 18;
            // 
            // btnPesquisaParceiro
            // 
            this.btnPesquisaParceiro.Image = global::Apresentacao.Properties.Resources.Search_25px;
            this.btnPesquisaParceiro.Location = new System.Drawing.Point(224, 6);
            this.btnPesquisaParceiro.Name = "btnPesquisaParceiro";
            this.btnPesquisaParceiro.Size = new System.Drawing.Size(45, 37);
            this.btnPesquisaParceiro.TabIndex = 20;
            this.btnPesquisaParceiro.UseVisualStyleBackColor = true;
            this.btnPesquisaParceiro.Click += new System.EventHandler(this.btnPesquisaParceiro_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Image = global::Apresentacao.Properties.Resources.Delete_25px;
            this.btnExcluir.Location = new System.Drawing.Point(171, 6);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(45, 37);
            this.btnExcluir.TabIndex = 22;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Image = global::Apresentacao.Properties.Resources.Edit_25px;
            this.btnEditar.Location = new System.Drawing.Point(65, 6);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(45, 37);
            this.btnEditar.TabIndex = 21;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::Apresentacao.Properties.Resources.Plus_25px;
            this.btnNovo.Location = new System.Drawing.Point(12, 6);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(45, 37);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Enabled = false;
            this.btnsalvar.Image = global::Apresentacao.Properties.Resources.Save_25px;
            this.btnsalvar.Location = new System.Drawing.Point(118, 6);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(45, 37);
            this.btnsalvar.TabIndex = 19;
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = global::Apresentacao.Properties.Resources.Exit_25px;
            this.btnSair.Location = new System.Drawing.Point(449, 6);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(45, 37);
            this.btnSair.TabIndex = 23;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FormD04Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 151);
            this.Controls.Add(this.cbxFamilia);
            this.Controls.Add(this.lblFamilia);
            this.Controls.Add(this.lblPesoLiquido);
            this.Controls.Add(this.nudPesoLiquido);
            this.Controls.Add(this.nudPesoBruto);
            this.Controls.Add(this.lblPesoBruto);
            this.Controls.Add(this.txtNcmObg);
            this.Controls.Add(this.lblNcm);
            this.Controls.Add(this.nudPrecoVenda);
            this.Controls.Add(this.lblPrecoVenda);
            this.Controls.Add(this.nudPrecoCusto);
            this.Controls.Add(this.lblPrecoCusto);
            this.Controls.Add(this.txtUnidadeMedidaObg);
            this.Controls.Add(this.lblUnidadeMedida);
            this.Controls.Add(this.txtDescricaoObg);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtCodigoObg);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnPesquisaParceiro);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.btnSair);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormD04Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produto";
            this.Load += new System.EventHandler(this.FormD04Produto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecoCusto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecoVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPesoBruto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPesoLiquido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnPesquisaParceiro;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btnNovo;
        public System.Windows.Forms.Button btnsalvar;
        public System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblUnidadeMedida;
        private System.Windows.Forms.Label lblPrecoCusto;
        private System.Windows.Forms.Label lblPrecoVenda;
        private System.Windows.Forms.Label lblNcm;
        private System.Windows.Forms.Label lblPesoBruto;
        private System.Windows.Forms.Label lblPesoLiquido;
        private System.Windows.Forms.Label lblFamilia;
        public System.Windows.Forms.TextBox txtCodigoObg;
        public System.Windows.Forms.TextBox txtDescricaoObg;
        public System.Windows.Forms.TextBox txtUnidadeMedidaObg;
        public System.Windows.Forms.NumericUpDown nudPrecoCusto;
        public System.Windows.Forms.NumericUpDown nudPrecoVenda;
        public System.Windows.Forms.TextBox txtNcmObg;
        public System.Windows.Forms.NumericUpDown nudPesoBruto;
        public System.Windows.Forms.NumericUpDown nudPesoLiquido;
        public System.Windows.Forms.ComboBox cbxFamilia;
        private System.Windows.Forms.ToolTip toolTipCadastroProduto;
    }
}