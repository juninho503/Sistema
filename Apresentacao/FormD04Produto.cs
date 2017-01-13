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
    public partial class FormD04Produto : Form
    {
        Utilitarios util = new Utilitarios();
        public int flag = 1;
        public static string d03_ukey = null;
        public static string ukey = null;

        public FormD04Produto()
        {
            InitializeComponent();
        }

        //botao novo
        private void btnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        //METODO BOTAO NOVO
        public void Novo()
        {
            util.HabilitaCampos(this.Controls);
            btnsalvar.Enabled = true;
            btnNovo.Enabled = false;
        }

        private void FormD04Produto_Load(object sender, EventArgs e)
        {
            toolTipCadastroProduto.SetToolTip(btnEditar, Utilitarios.BOTAO_EDITAR);
            toolTipCadastroProduto.SetToolTip(btnExcluir, Utilitarios.BOTAO_EXCLUIR);
            toolTipCadastroProduto.SetToolTip(btnNovo, Utilitarios.BOTAO_NOVO);
            toolTipCadastroProduto.SetToolTip(btnPesquisaParceiro, Utilitarios.BOTAO_PESQUISAR);
            toolTipCadastroProduto.SetToolTip(btnSair, Utilitarios.BOTAO_SAIR);
            toolTipCadastroProduto.SetToolTip(btnsalvar, Utilitarios.BOTAO_SALVAR);
        }

        //botao sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNcm_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
        //botao salvar
        private void btnsalvar_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                try
                {
                    util.ValidarCamposObrigatorios(Controls, util.CamposObrigatorios(Controls));
                    try
                    {
                        Inserir();
                        MessageBox.Show(Utilitarios.INSERT_SUCESSO, Utilitarios.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        util.DesabilitaCampos(this.Controls);
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
            //condição para fazer o update no banco de dados
            else if (flag == 2)
            {
                try
                {
                    util.ValidarCamposObrigatorios(Controls, util.CamposObrigatorios(Controls));
                    try
                    {
                        Update();
                        MessageBox.Show(Utilitarios.UPDATE_SUCESSO, Utilitarios.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        util.DesabilitaCampos(this.Controls);
                    } catch(Exception ex)
                    {
                        MessageBox.Show(Utilitarios.UPDATE_ERRO + ex.Message, Utilitarios.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }   catch(Exception ex)
                {
                    MessageBox.Show("Campos Obrigatorios Não Preenchidos!" + ex.Message, Utilitarios.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }             
            }
            flag = 1;
        }

        //metodo de inserir
        public void Inserir()
        {
            D04Produto d04Produto = new D04Produto();
            d04Produto.d04_001_c = txtCodigoObg.Text;
            d04Produto.d04_002_c = txtDescricaoObg.Text;
            d04Produto.d04_003_c = txtUnidadeMedidaObg.Text;
            d04Produto.d04_004_n = Convert.ToDouble(nudPrecoCusto.Value);
            d04Produto.d04_005_n = Convert.ToDouble(nudPrecoVenda.Value);
            d04Produto.d04_006_c = txtNcmObg.Text;
            d04Produto.d04_007_n = Convert.ToDouble(nudPesoLiquido.Value);
            d04Produto.d04_008_n = Convert.ToDouble(nudPesoBruto.Value);

            if (cbxFamilia.SelectedText == string.Empty)
            {
                d04Produto.d03_ukey =null;
            }
            else
            {
                d04Produto.d03_ukey = d03_ukey;
            }

            D04ProdutoNegocio d04Negocio = new D04ProdutoNegocio();
            d04Negocio.Inserir(d04Produto);

        }

        private void btnPesquisaParceiro_Click(object sender, EventArgs e)
        {
            FormD04Pesquisa formD04Pesquisa = new FormD04Pesquisa(this);
            formD04Pesquisa.Show();
        }
        //botao editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }
        //metdo botao editar
        private void Editar()
        {
            flag = 2;
            util.HabilitaCampos(this.Controls);
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnsalvar.Enabled = true;
        }
        //metodo para dar update no banco de dados
        private void Alterar()
        {
            D04Produto d04Produto = new D04Produto();
            d04Produto.d04_001_c = txtCodigoObg.Text;
            d04Produto.d04_002_c = txtDescricaoObg.Text;
            d04Produto.d04_003_c = txtUnidadeMedidaObg.Text;
            d04Produto.d04_004_n = Convert.ToDouble(nudPrecoCusto.Value);
            d04Produto.d04_005_n = Convert.ToDouble(nudPrecoVenda.Value);
            d04Produto.d04_006_c = txtNcmObg.Text;
            d04Produto.d04_007_n = Convert.ToDouble(nudPesoLiquido.Value);
            d04Produto.d04_008_n = Convert.ToDouble(nudPesoBruto.Value);
            d04Produto.ukey = ukey;

            if (cbxFamilia.SelectedText == string.Empty)
            {
                d04Produto.d03_ukey = null;
            }
            else
            {
                d04Produto.d03_ukey = d03_ukey;
            }

            D04ProdutoNegocio d04Negocio = new D04ProdutoNegocio();

            d04Negocio.Alterar(d04Produto);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Delete();
                MessageBox.Show(Utilitarios.DELETE_SUCESSO, Utilitarios.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                util.LimpaCampos(this.Controls);
            }catch(Exception ex)
            {
                MessageBox.Show(Utilitarios.DELETE_ERRO + ex.Message, Utilitarios.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //metodo para excluir registro
        private void Delete()
        {
            DialogResult mensagem = MessageBox.Show("Deseja Realmente Excluir o Registro?", Utilitarios.TITULO, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(mensagem == DialogResult.No)
            {
                return;
            }
            D04Produto d04Produto = new D04Produto();
            D04ProdutoNegocio d04Negocio = new D04ProdutoNegocio();
            d04Produto.ukey = ukey;
            d04Negocio.Excluir(d04Produto);
        }
    }
}
