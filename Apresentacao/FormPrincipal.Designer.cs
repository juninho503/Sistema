namespace Apresentacao
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.barraStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.cadastrosIniciaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parceirosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.logradouroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.estadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.cidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.cepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cadastroDeFamiliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.localDeEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barraStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 397);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(791, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // barraStatus
            // 
            this.barraStatus.Name = "barraStatus";
            this.barraStatus.Size = new System.Drawing.Size(59, 17);
            this.barraStatus.Text = "Versão 1.0";
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosIniciaisToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(791, 24);
            this.menuPrincipal.TabIndex = 2;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // cadastrosIniciaisToolStripMenuItem
            // 
            this.cadastrosIniciaisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parceirosToolStripMenuItem,
            this.toolStripSeparator2,
            this.logradouroToolStripMenuItem,
            this.toolStripSeparator3,
            this.bancoToolStripMenuItem,
            this.toolStripSeparator10});
            this.cadastrosIniciaisToolStripMenuItem.Image = global::Apresentacao.Properties.Resources.Air_Pilot_Hat_25px_1;
            this.cadastrosIniciaisToolStripMenuItem.Name = "cadastrosIniciaisToolStripMenuItem";
            this.cadastrosIniciaisToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.cadastrosIniciaisToolStripMenuItem.Text = "Cadastros Iniciais";
            // 
            // parceirosToolStripMenuItem
            // 
            this.parceirosToolStripMenuItem.Image = global::Apresentacao.Properties.Resources.Handshake_25px;
            this.parceirosToolStripMenuItem.Name = "parceirosToolStripMenuItem";
            this.parceirosToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.parceirosToolStripMenuItem.Text = "Parceiros";
            this.parceirosToolStripMenuItem.Click += new System.EventHandler(this.parceirosToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(133, 6);
            // 
            // logradouroToolStripMenuItem
            // 
            this.logradouroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paisToolStripMenuItem,
            this.toolStripSeparator4,
            this.estadoToolStripMenuItem,
            this.toolStripSeparator5,
            this.cidadeToolStripMenuItem,
            this.toolStripSeparator6,
            this.cepToolStripMenuItem,
            this.toolStripSeparator7});
            this.logradouroToolStripMenuItem.Image = global::Apresentacao.Properties.Resources.Map_Marker_25px;
            this.logradouroToolStripMenuItem.Name = "logradouroToolStripMenuItem";
            this.logradouroToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.logradouroToolStripMenuItem.Text = "Logradouro";
            // 
            // paisToolStripMenuItem
            // 
            this.paisToolStripMenuItem.Image = global::Apresentacao.Properties.Resources.Globe_25px;
            this.paisToolStripMenuItem.Name = "paisToolStripMenuItem";
            this.paisToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.paisToolStripMenuItem.Text = "Pais";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(108, 6);
            // 
            // estadoToolStripMenuItem
            // 
            this.estadoToolStripMenuItem.Image = global::Apresentacao.Properties.Resources.Worldwide_Location_25px;
            this.estadoToolStripMenuItem.Name = "estadoToolStripMenuItem";
            this.estadoToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.estadoToolStripMenuItem.Text = "Estado";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(108, 6);
            // 
            // cidadeToolStripMenuItem
            // 
            this.cidadeToolStripMenuItem.Image = global::Apresentacao.Properties.Resources.Point_Objects_25px;
            this.cidadeToolStripMenuItem.Name = "cidadeToolStripMenuItem";
            this.cidadeToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.cidadeToolStripMenuItem.Text = "Cidade";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(108, 6);
            // 
            // cepToolStripMenuItem
            // 
            this.cepToolStripMenuItem.Image = global::Apresentacao.Properties.Resources.Marker_25px;
            this.cepToolStripMenuItem.Name = "cepToolStripMenuItem";
            this.cepToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.cepToolStripMenuItem.Text = "Cep";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(108, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(133, 6);
            // 
            // bancoToolStripMenuItem
            // 
            this.bancoToolStripMenuItem.Image = global::Apresentacao.Properties.Resources.Library_25px;
            this.bancoToolStripMenuItem.Name = "bancoToolStripMenuItem";
            this.bancoToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.bancoToolStripMenuItem.Text = "Banco";
            this.bancoToolStripMenuItem.Click += new System.EventHandler(this.bancoToolStripMenuItem_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(133, 6);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeProdutosToolStripMenuItem,
            this.toolStripSeparator1,
            this.cadastroDeFamiliaToolStripMenuItem,
            this.toolStripSeparator8,
            this.localDeEstoqueToolStripMenuItem,
            this.toolStripSeparator9});
            this.estoqueToolStripMenuItem.Image = global::Apresentacao.Properties.Resources.Move_by_Trolley_25px;
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // cadastroDeProdutosToolStripMenuItem
            // 
            this.cadastroDeProdutosToolStripMenuItem.Image = global::Apresentacao.Properties.Resources.Box_25px;
            this.cadastroDeProdutosToolStripMenuItem.Name = "cadastroDeProdutosToolStripMenuItem";
            this.cadastroDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.cadastroDeProdutosToolStripMenuItem.Text = "Cadastro de Produtos";
            this.cadastroDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeProdutosToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // cadastroDeFamiliaToolStripMenuItem
            // 
            this.cadastroDeFamiliaToolStripMenuItem.Image = global::Apresentacao.Properties.Resources.Stack_25px;
            this.cadastroDeFamiliaToolStripMenuItem.Name = "cadastroDeFamiliaToolStripMenuItem";
            this.cadastroDeFamiliaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.cadastroDeFamiliaToolStripMenuItem.Text = "Cadastro de Familia";
            this.cadastroDeFamiliaToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeFamiliaToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(185, 6);
            // 
            // localDeEstoqueToolStripMenuItem
            // 
            this.localDeEstoqueToolStripMenuItem.Image = global::Apresentacao.Properties.Resources.Warehouse_25px;
            this.localDeEstoqueToolStripMenuItem.Name = "localDeEstoqueToolStripMenuItem";
            this.localDeEstoqueToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.localDeEstoqueToolStripMenuItem.Text = "Local de Estoque";
            this.localDeEstoqueToolStripMenuItem.Click += new System.EventHandler(this.localDeEstoqueToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(185, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(791, 419);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FormPrincipal";
            this.Text = "SAERP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel barraStatus;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem cadastrosIniciaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logradouroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parceirosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeFamiliaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem localDeEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem bancoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
    }
}