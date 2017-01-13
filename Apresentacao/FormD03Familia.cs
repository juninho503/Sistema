using Negocios;
using ObjetoTransferencia;
using System;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FormD03Familia : Form
    {
        Utilitarios util = new Utilitarios();
        public static string ukey = null;
        private int flag = 1;

        public FormD03Familia()
        {
            InitializeComponent();
        }

        private void FormD03Familia_Load(object sender, EventArgs e)
        {
            //setar dicas nos botoes
            toolTipD03Familia.SetToolTip(btnNovo, Utilitarios.BOTAO_NOVO);
            toolTipD03Familia.SetToolTip(btnEditar, Utilitarios.BOTAO_EDITAR);
            toolTipD03Familia.SetToolTip(btnsalvar, Utilitarios.BOTAO_SALVAR);
            toolTipD03Familia.SetToolTip(btnExcluir, Utilitarios.BOTAO_EXCLUIR);
            toolTipD03Familia.SetToolTip(btnSair, Utilitarios.BOTAO_SAIR);
            toolTipD03Familia.SetToolTip(btnPesquisaParceiro, Utilitarios.BOTAO_PESQUISAR);
        }
        //botao novo
        private void btnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }
        //metodo do botao novo
        public void Novo()
        {
            util.HabilitaCampos(this.Controls);
            util.LimpaCampos(this.Controls);
            btnsalvar.Enabled = true;
            btnNovo.Enabled = false;
        }
        //metodo de gravar no banco de dados
        public void Gravar()
        {
            D03Familia d03Familia = new D03Familia();
            d03Familia.d03_001_c = txtCodigoObg.Text;
            d03Familia.d03_002_c = txtDescricaoObg.Text;

            D03FamiliaNegocio d03Negocio = new D03FamiliaNegocio();
            d03Negocio.Inserir(d03Familia);

        }
        //botao salvar
        private void btnsalvar_Click(object sender, EventArgs e)
        {
            //se for 1 insere
            if(flag == 1)
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
                    }catch(Exception ex)
                    {
                        MessageBox.Show(Utilitarios.INSERT_ERRO + ex.Message, Utilitarios.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } catch(Exception ex)
                {
                    MessageBox.Show("Campos Obrigatorios Não Preenchidos!" + ex.Message, Utilitarios.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }else if (flag == 2)
            {
                try
                {
                    util.ValidarCamposObrigatorios(Controls, util.CamposObrigatorios(Controls));
                    try
                    {
                        Alterar();
                        util.DesabilitaCampos(this.Controls);
                        MessageBox.Show(Utilitarios.UPDATE_SUCESSO, Utilitarios.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        //botao pesquisa
        private void btnPesquisaParceiro_Click(object sender, EventArgs e)
        {
            FormD03Pesquisa formD03Pesquisa = new FormD03Pesquisa(this);
            formD03Pesquisa.Show();
        }
        //botao sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        //metodo editar
        private void Editar()
        {
            flag = 2;
            util.HabilitaCampos(this.Controls);
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnsalvar.Enabled = true;
            btnNovo.Enabled = false;
        }
        //metodo Alterar
        private void Alterar()
        {
            D03Familia d03Familia = new D03Familia();
            d03Familia.d03_001_c = txtCodigoObg.Text;
            d03Familia.d03_002_c = txtDescricaoObg.Text;
            d03Familia.ukey = ukey;
            D03FamiliaNegocio d03Negocio = new D03FamiliaNegocio();
            d03Negocio.Alterar(d03Familia);
        }
        //botao editar
        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            Editar();
        }
        //metodo de excluisao
        private void Excluir()
        {
            D03Familia d03Familia = new D03Familia();
            D03FamiliaNegocio d03Negocio = new D03FamiliaNegocio();
            d03Familia.ukey = ukey;
            d03Negocio.Excluir(d03Familia);
        }
        //botao exclui
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Excluir();
                MessageBox.Show(Utilitarios.DELETE_SUCESSO, Utilitarios.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                util.LimpaCampos(this.Controls);
            }catch(Exception ex)
            {
                MessageBox.Show(Utilitarios.DELETE_ERRO + ex.Message, Utilitarios.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
