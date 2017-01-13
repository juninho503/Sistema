using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjetoTransferencia;
using Negocios;

namespace Apresentacao
{
    public partial class FormA01Banco : Form
    {
        Utilitarios util = new Utilitarios();
        public static string ukey = null;
        int flag = 1;
        public FormA01Banco()
        {
            InitializeComponent();
        }

        private void FormA01Banco_Load(object sender, EventArgs e)
        {
            //setar dicas nos botoes
            toolTipBanco.SetToolTip(btnNovo, Utilitarios.BOTAO_NOVO);
            toolTipBanco.SetToolTip(btnEditar, Utilitarios.BOTAO_EDITAR);
            toolTipBanco.SetToolTip(btnsalvar, Utilitarios.BOTAO_SALVAR);
            toolTipBanco.SetToolTip(btnExcluir, Utilitarios.BOTAO_EXCLUIR);
            toolTipBanco.SetToolTip(btnSair, Utilitarios.BOTAO_SAIR);
            toolTipBanco.SetToolTip(btnPesquisaParceiro, Utilitarios.BOTAO_PESQUISAR);
        }
        //botao sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        //botao novo
        private void btnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }
        //metodo do botao novo
        private void Novo()
        {
            util.HabilitaCampos(this.Controls);
            btnsalvar.Enabled = true;
            btnNovo.Enabled = false;
            util.LimpaCampos(this.Controls);
        }
        //metodo salvar
        private void Gravar()
        {
            A01Banco a01Banco = new A01Banco();
            a01Banco.a01_001_c = txtCodigoObg.Text;
            a01Banco.a01_002_c = txtDescricaoObg.Text;
            A01BancoNegocio a01Negocio = new A01BancoNegocio();
            a01Negocio.Inserir(a01Banco);
        }
        //botao novo
        //metodo do botao editar
        private void Editar()
        {
            flag = 2;
            util.HabilitaCampos(this.Controls);
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnsalvar.Enabled = true;
        }
        //private void metodo de alteração
        private void Alterar()
        {
            A01Banco a01Banco = new A01Banco();
            a01Banco.a01_001_c = txtCodigoObg.Text;
            a01Banco.a01_002_c = txtDescricaoObg.Text;
            a01Banco.ukey = ukey;
            A01BancoNegocio a01Negocio = new A01BancoNegocio();
            a01Negocio.Alterar(a01Banco);
        }
        //metodo de exclusao
        private void Excluir()
        {
            A01Banco a01Banco = new A01Banco();
            a01Banco.ukey = ukey;
            A01BancoNegocio a01Negocio = new A01BancoNegocio();
            a01Negocio.Excluir(a01Banco);
        }
        //BOTAO EDITAR
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }
        private void btnPesquisaParceiro_Click(object sender, EventArgs e)
        {
            FormA01Pesquisa formPesquisa = new FormA01Pesquisa(this);
            formPesquisa.Show();
        }

        private void btnsalvar_Click_1(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                try
                {
                    util.ValidarCamposObrigatorios(Controls, util.CamposObrigatorios(Controls));
                    try
                    {
                        Gravar();
                        MessageBox.Show(Utilitarios.INSERT_SUCESSO, Utilitarios.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        util.DesabilitaCampos(this.Controls);
                        btnEditar.Enabled = true;
                        btnsalvar.Enabled = false;
                        btnNovo.Enabled = true;
                        btnExcluir.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(Utilitarios.INSERT_ERRO + ex.Message, Utilitarios.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Campos Obrigatorios Não Preenchidos!" + ex.Message, Utilitarios.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (flag == 2)
            {
                try
                {
                    util.ValidarCamposObrigatorios(Controls, util.CamposObrigatorios(Controls));
                    try
                    {
                        Alterar();
                        MessageBox.Show(Utilitarios.UPDATE_SUCESSO, Utilitarios.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        util.DesabilitaCampos(this.Controls);
                        btnEditar.Enabled = true;
                        btnsalvar.Enabled = false;
                        btnNovo.Enabled = true;
                        btnExcluir.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(Utilitarios.UPDATE_ERRO + ex.Message, Utilitarios.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Campos Obrigatorios Não Preenchidos!" + ex.Message, Utilitarios.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            try
            {
                Excluir();
                MessageBox.Show(Utilitarios.DELETE_SUCESSO, Utilitarios.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                util.LimpaCampos(this.Controls);
                btnEditar.Enabled = false;
                btnsalvar.Enabled = false;
                btnNovo.Enabled = true;
                btnExcluir.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Utilitarios.DELETE_ERRO + ex.Message, Utilitarios.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            flag = 1;
        }
    }
}
