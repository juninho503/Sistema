namespace Apresentacao
{
    partial class FormD07Localestoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormD07Localestoque));
            this.txtDescricaoObg = new System.Windows.Forms.TextBox();
            this.txtCodigoObg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.toolTipLocal = new System.Windows.Forms.ToolTip(this.components);
            this.btnPesquisaParceiro = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDescricaoObg
            // 
            this.txtDescricaoObg.Enabled = false;
            this.txtDescricaoObg.Location = new System.Drawing.Point(64, 79);
            this.txtDescricaoObg.Name = "txtDescricaoObg";
            this.txtDescricaoObg.Size = new System.Drawing.Size(342, 20);
            this.txtDescricaoObg.TabIndex = 4;
            // 
            // txtCodigoObg
            // 
            this.txtCodigoObg.Enabled = false;
            this.txtCodigoObg.Location = new System.Drawing.Point(64, 56);
            this.txtCodigoObg.Name = "txtCodigoObg";
            this.txtCodigoObg.Size = new System.Drawing.Size(342, 20);
            this.txtCodigoObg.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(21, 60);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código:";
            // 
            // btnPesquisaParceiro
            // 
            this.btnPesquisaParceiro.Image = global::Apresentacao.Properties.Resources.Search_25px;
            this.btnPesquisaParceiro.Location = new System.Drawing.Point(217, 5);
            this.btnPesquisaParceiro.Name = "btnPesquisaParceiro";
            this.btnPesquisaParceiro.Size = new System.Drawing.Size(45, 37);
            this.btnPesquisaParceiro.TabIndex = 8;
            this.btnPesquisaParceiro.UseVisualStyleBackColor = true;
            this.btnPesquisaParceiro.Click += new System.EventHandler(this.btnPesquisaParceiro_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Image = global::Apresentacao.Properties.Resources.Delete_25px;
            this.btnExcluir.Location = new System.Drawing.Point(164, 5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(45, 37);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Image = global::Apresentacao.Properties.Resources.Edit_25px;
            this.btnEditar.Location = new System.Drawing.Point(58, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(45, 37);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::Apresentacao.Properties.Resources.Plus_25px;
            this.btnNovo.Location = new System.Drawing.Point(5, 5);
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
            this.btnsalvar.Location = new System.Drawing.Point(111, 5);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(45, 37);
            this.btnsalvar.TabIndex = 5;
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = global::Apresentacao.Properties.Resources.Exit_25px;
            this.btnSair.Location = new System.Drawing.Point(361, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(45, 37);
            this.btnSair.TabIndex = 9;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FormD07Localestoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 114);
            this.Controls.Add(this.btnPesquisaParceiro);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtDescricaoObg);
            this.Controls.Add(this.txtCodigoObg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormD07Localestoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Local de Estoque";
            this.Load += new System.EventHandler(this.FormD07Localestoque_Load);
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
        public System.Windows.Forms.TextBox txtDescricaoObg;
        public System.Windows.Forms.TextBox txtCodigoObg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ToolTip toolTipLocal;
    }
}