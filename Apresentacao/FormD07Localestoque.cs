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
    public partial class FormD07Localestoque : Form
    {
        Utilitarios util = new Utilitarios();
        public static string ukey = null;
        private int flag = 1;

        public FormD07Localestoque()
        {
            InitializeComponent();
        }

        private void FormD07Localestoque_Load(object sender, EventArgs e)
        {
            //setar dicas nos botoes
            toolTipLocal.SetToolTip(btnNovo, Utilitarios.BOTAO_NOVO);
            toolTipLocal.SetToolTip(btnEditar, Utilitarios.BOTAO_EDITAR);
            toolTipLocal.SetToolTip(btnsalvar, Utilitarios.BOTAO_SALVAR);
            toolTipLocal.SetToolTip(btnExcluir, Utilitarios.BOTAO_EXCLUIR);
            toolTipLocal.SetToolTip(btnSair, Utilitarios.BOTAO_SAIR);
            toolTipLocal.SetToolTip(btnPesquisaParceiro, Utilitarios.BOTAO_PESQUISAR);
        }
        //botao sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        //botao novo
        private void btnNovo_Click(object sender, EventArgs e)
        {
            util.HabilitaCampos(this.Controls);
            btnsalvar.Enabled = true;
            btnNovo.Enabled = false;
            util.LimpaCampos(this.Controls);
        }

        private void btnsalvar_Click(object sender, EventArgs e)
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
        //metodo salvar
        private void Gravar()
        {
            D07LocalEstoque d07Local = new D07LocalEstoque();
            d07Local.d07_001_c = txtCodigoObg.Text;
            d07Local.d07_002_c = txtDescricaoObg.Text;
            D07LocalNegocio d07Negocio = new D07LocalNegocio();
            d07Negocio.Inserir(d07Local);
        }
        //botao novo
        private void btnPesquisaParceiro_Click(object sender, EventArgs e)
        {
            FormD07LocalestoquePesquisa formd07 = new FormD07LocalestoquePesquisa(this);
            formd07.Show();
        }
        //botao editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }
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
            D07LocalEstoque d07Local = new D07LocalEstoque();
            d07Local.d07_001_c = txtCodigoObg.Text;
            d07Local.d07_002_c = txtDescricaoObg.Text;
            d07Local.ukey = ukey;
            D07LocalNegocio d07Negocio = new D07LocalNegocio();
            d07Negocio.Alterar(d07Local);
        }
        //metodo de exclusao
        private void Excluir()
        {
            D07LocalEstoque d07Local = new D07LocalEstoque();
            d07Local.ukey = ukey;
            D07LocalNegocio d07Negocio = new D07LocalNegocio();
            d07Negocio.Excluir(d07Local);
        }
        // botao excluir
        private void btnExcluir_Click(object sender, EventArgs e)
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
