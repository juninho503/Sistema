namespace Apresentacao
{
    partial class FormA01Banco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormA01Banco));
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtDescricaoObg = new System.Windows.Forms.TextBox();
            this.txtCodigoObg = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnPesquisaParceiro = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.toolTipBanco = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::Apresentacao.Properties.Resources.Plus_25px;
            this.btnNovo.Location = new System.Drawing.Point(7, 4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(45, 37);
            this.btnNovo.TabIndex = 10;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtDescricaoObg
            // 
            this.txtDescricaoObg.Enabled = false;
            this.txtDescricaoObg.Location = new System.Drawing.Point(66, 78);
            this.txtDescricaoObg.Name = "txtDescricaoObg";
            this.txtDescricaoObg.Size = new System.Drawing.Size(342, 20);
            this.txtDescricaoObg.TabIndex = 14;
            // 
            // txtCodigoObg
            // 
            this.txtCodigoObg.Enabled = false;
            this.txtCodigoObg.Location = new System.Drawing.Point(66, 55);
            this.txtCodigoObg.Name = "txtCodigoObg";
            this.txtCodigoObg.Size = new System.Drawing.Size(342, 20);
            this.txtCodigoObg.TabIndex = 12;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(23, 59);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 11;
            this.lblCodigo.Text = "Código:";
            // 
            // btnPesquisaParceiro
            // 
            this.btnPesquisaParceiro.Image = global::Apresentacao.Properties.Resources.Search_25px;
            this.btnPesquisaParceiro.Location = new System.Drawing.Point(219, 4);
            this.btnPesquisaParceiro.Name = "btnPesquisaParceiro";
            this.btnPesquisaParceiro.Size = new System.Drawing.Size(45, 37);
            this.btnPesquisaParceiro.TabIndex = 18;
            this.btnPesquisaParceiro.UseVisualStyleBackColor = true;
            this.btnPesquisaParceiro.Click += new System.EventHandler(this.btnPesquisaParceiro_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Image = global::Apresentacao.Properties.Resources.Delete_25px;
            this.btnExcluir.Location = new System.Drawing.Point(166, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(45, 37);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Image = global::Apresentacao.Properties.Resources.Edit_25px;
            this.btnEditar.Location = new System.Drawing.Point(60, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(45, 37);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Enabled = false;
            this.btnsalvar.Image = global::Apresentacao.Properties.Resources.Save_25px;
            this.btnsalvar.Location = new System.Drawing.Point(113, 4);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(45, 37);
            this.btnsalvar.TabIndex = 15;
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click_1);
            // 
            // btnSair
            // 
            this.btnSair.Image = global::Apresentacao.Properties.Resources.Exit_25px;
            this.btnSair.Location = new System.Drawing.Point(363, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(45, 37);
            this.btnSair.TabIndex = 19;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FormA01Banco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 112);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtDescricaoObg);
            this.Controls.Add(this.txtCodigoObg);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnPesquisaParceiro);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormA01Banco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Banco";
            this.Load += new System.EventHandler(this.FormA01Banco_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnNovo;
        public System.Windows.Forms.TextBox txtDescricaoObg;
        public System.Windows.Forms.TextBox txtCodigoObg;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ToolTip toolTipLocal;
        public System.Windows.Forms.Button btnPesquisaParceiro;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btnsalvar;
        public System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ToolTip toolTipBanco;
    }
}