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
    public partial class FormA03Cadastrar : Form
    {
        Utilitarios util = new Utilitarios();
        private int flag = 1;
        public static string ukey = null;
        public static string a25_ukey = null;
        public static string a01_ukey = null;
        public static string a21_ukey = null;
        public static string a03_001_c = null;

        public FormA03Cadastrar()
        {
            InitializeComponent();
            btnPesquisaCep.Enabled = true;
            
        }
        

        private void btnPesquisaCep_Click(object sender, EventArgs e)
        {
            
                FormA25Pesquisar formA25Pesquisar = new FormA25Pesquisar(this, txtPesquisaCep.Text);
                formA25Pesquisar.Show();
          
            
        }

        private void FormA03Cadastrar_Load(object sender, EventArgs e)
        {
            //setar as dicas quando cursor passa sobre o controle do form
            toolTipA03Cadastrar.SetToolTip(btnNovo, Utilitarios.BOTAO_NOVO);
            toolTipA03Cadastrar.SetToolTip(btnEditar, Utilitarios.BOTAO_EDITAR);
            toolTipA03Cadastrar.SetToolTip(btnsalvar, Utilitarios.BOTAO_SALVAR);
            toolTipA03Cadastrar.SetToolTip(btnExcluir, Utilitarios.BOTAO_EXCLUIR);
            toolTipA03Cadastrar.SetToolTip(btnSair, Utilitarios.BOTAO_SAIR);
            toolTipA03Cadastrar.SetToolTip(btnPesquisaParceiro, Utilitarios.BOTAO_PESQUISAR);

            //setar comboBox tipo de pessoa para começar no indice 0
            cbxPessoa.SelectedIndex = 0;
                       
        }
        /// <summary>
        /// Metodo do botao novo habilita os campos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNovo_Click(object sender, EventArgs e)
        {
            //habilitar controle do form
            util.HabilitaCampos(this.Controls);
            util.LimpaCampos(this.Controls);
            txtCep.Enabled = false;
            txtCidade.Enabled = false;
            txtEstado.Enabled = false;
            txtPais.Enabled = false;
            txtUf.Enabled = false;
            txtCodigo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            btnsalvar.Enabled = true;
            btnPesquisaBanco.Enabled = true;
        }

        //evento que troca a marcara do campo cpfCnpj
        private void cbxPessoa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //verifica se o indice da combobox tipo de pessoa juridico/fisica
            //por default a combobox ja vem com indice zero carregado no load
            if(cbxPessoa.SelectedIndex == 0)
            {
                //se for zero seto a label para cpf e seto a mascara do campo para cpf
                lblCpfCnpj.Text = "CpF:";
                mtbCpfCnpjObg.Mask = "000.000.000-00";
            } else if (cbxPessoa.SelectedIndex == 1)
            {
                //se for 1 o indice seto a label para cnpj e seto a mascara do campo para cnpj
                lblCpfCnpj.Text = "Cnpj:";
                mtbCpfCnpjObg.Mask = "00.000.000/0000-00";
            }
        }

        //botao sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            //fecha o form
            Close();
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
                        Salvar();
                        txtCodigo.Text = a03_001_c.Replace("-/.", "");
                        MessageBox.Show(Utilitarios.INSERT_SUCESSO, Utilitarios.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(Utilitarios.INSERT_ERRO + ex.Message, Utilitarios.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (CamposObrigatoriosException)
                {
                    MessageBox.Show("Campos Obrigatorios Não Preenchidos!", Utilitarios.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            } else if (flag == 2)
            {
                try
                {
                    util.ValidarCamposObrigatorios(Controls, util.CamposObrigatorios(Controls));
                    try
                    {
                        Update();
                        txtCodigo.Text = a03_001_c.Replace("-/.", "");
                        MessageBox.Show(Utilitarios.UPDATE_SUCESSO, Utilitarios.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } catch(Exception ex)
                    {
                        MessageBox.Show(Utilitarios.UPDATE_ERRO + ex.Message, Utilitarios.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show("Campos Obrigatorios Não Preenchidos!" + ex.Message, Utilitarios.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            util.DesabilitaCampos(this.Controls);
            flag = 1;
        }

        //METODO PARA SALVAR
        public void Salvar()
        {
            A03Parceiros a03Parceiro = new A03Parceiros();
            a03Parceiro.a03_001_c = mtbCpfCnpjObg.Text.Replace("/.-", "");
            a03Parceiro.a03_002_c = txtFantasia.Text;
            a03Parceiro.a03_003_c = txtNomeObg.Text;
            a03Parceiro.a03_004_c = txtEnderecoObg.Text;
            a03Parceiro.a03_005_c = txtBairroObg.Text;
            a03Parceiro.a03_006_c = txtEmail.Text;
            a03Parceiro.a03_007_c = mtbCpfCnpjObg.Text.Replace("/.-","");
            a03Parceiro.a03_008_c = mtbFoneObg.Text.Replace("/.-", "");
            a03Parceiro.a03_009_c = mtbFax.Text.Replace("/.-", "");
            a03Parceiro.a03_010_c = txtComplemento.Text;
            
            //verifico o tipo de pessoa
            if(cbxPessoa.SelectedIndex == 0)
            {
                a03Parceiro.tipoPessoa = 1;
            } else
            {
                a03Parceiro.tipoPessoa = 0;
            }

            if (ckbCliente.Checked)
            {
                a03Parceiro.a03_011_n = 1;
            }else
            {
                a03Parceiro.a03_011_n = 0;
            }

            if (ckbFornecedor.Checked)
            {
                a03Parceiro.a03_012_n = 1;
            }else
            {
                a03Parceiro.a03_012_n = 0;
            }

            a03Parceiro.a03_013_d = dtpCadastroObg.Value;
            a03Parceiro.a25_ukey = a25_ukey;
            
            if (txtBanco.Text == string.Empty)
            {
                a03Parceiro.a01_ukey = null;
            }
            else
            {
                a03Parceiro.a01_ukey = a01_ukey;
            }
            if (cbxTipoDocumento.SelectedText == string.Empty)
            {
                a03Parceiro.a21_ukey = null;
            }
            else
            {
                a03Parceiro.a21_ukey = a21_ukey;
            }
            
            A03ParceiroNegocios a03ParceiroNegocio = new A03ParceiroNegocios();
            a03ParceiroNegocio.Inserir(a03Parceiro);
            a03_001_c = mtbCpfCnpjObg.Text.Trim();
            
            
        }

        private void btnPesquisaParceiro_Click(object sender, EventArgs e)
        {
            FormA03Pesquisar formA03Pesquisar = new FormA03Pesquisar(this);
            formA03Pesquisar.Show();
        }
        //botao editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        //METODO PARA BOTAO EDITAR
        private void Editar()
        {
            btnsalvar.Enabled = true;
            btnExcluir.Enabled = false;
            btnEditar.Enabled = false;
            util.HabilitaCampos(this.Controls);
            flag = 2;
        }

        private void Alterar()
        {
            A03Parceiros a03Parceiro = new A03Parceiros();
            a03Parceiro.a03_001_c = mtbCpfCnpjObg.Text.Replace("/.-", "");
            a03Parceiro.a03_002_c = txtFantasia.Text;
            a03Parceiro.a03_003_c = txtNomeObg.Text;
            a03Parceiro.a03_004_c = txtEnderecoObg.Text;
            a03Parceiro.a03_005_c = txtBairroObg.Text;
            a03Parceiro.a03_006_c = txtEmail.Text;
            a03Parceiro.a03_007_c = mtbCpfCnpjObg.Text.Replace("/.-", "");
            a03Parceiro.a03_008_c = mtbFoneObg.Text.Replace("/.-", "");
            a03Parceiro.a03_009_c = mtbFax.Text.Replace("/.-", "");
            a03Parceiro.a03_010_c = txtComplemento.Text;
            a03Parceiro.ukey = ukey;
            a03Parceiro.a25_ukey = a25_ukey;

            //verifico o tipo de pessoa
            if (cbxPessoa.SelectedIndex == 0)
            {
                a03Parceiro.tipoPessoa = 1;
            }
            else
            {
                a03Parceiro.tipoPessoa = 0;
            }

            if (ckbCliente.Checked)
            {
                a03Parceiro.a03_011_n = 1;
            }
            else
            {
                a03Parceiro.a03_011_n = 0;
            }

            if (ckbFornecedor.Checked)
            {
                a03Parceiro.a03_012_n = 1;
            }
            else
            {
                a03Parceiro.a03_012_n = 0;
            }

            a03Parceiro.a03_013_d = dtpCadastroObg.Value;
            a03Parceiro.a25_ukey = a25_ukey;

            if (txtBanco.Text == string.Empty)
            {
                a03Parceiro.a01_ukey = null;
            }
            else
            {
                a03Parceiro.a01_ukey = a01_ukey;
            }
            if (cbxTipoDocumento.SelectedText == string.Empty)
            {
                a03Parceiro.a21_ukey = "00000000-0000-0000-0000-000000000000";
            }
            else
            {
                a03Parceiro.a21_ukey = a21_ukey;
            }

            A03ParceiroNegocios a03ParceiroNegocio = new A03ParceiroNegocios();
            a03ParceiroNegocio.Alterar(a03Parceiro);
            a03_001_c = mtbCpfCnpjObg.Text.Trim();
        }
            //BOTAO EXCLUIR
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Excluir();
                MessageBox.Show(Utilitarios.DELETE_SUCESSO, Utilitarios.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                util.LimpaCampos(this.Controls);
                btnExcluir.Enabled = false;
            }catch (Exception ex)
            {
                MessageBox.Show(Utilitarios.DELETE_ERRO + ex.Message, Utilitarios.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //metodo para excluir
        public void Excluir()
        {
            A03Parceiros a03Parceiro = new A03Parceiros();
            A03ParceiroNegocios a03ParceiroNegocio = new A03ParceiroNegocios();
            DialogResult mensagemDecisaoExclusao = MessageBox.Show("Deseja Realmente Excluir o Registro?", Utilitarios.TITULO, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(mensagemDecisaoExclusao == DialogResult.No)
            {
                return;
            }
            a03Parceiro.ukey = ukey;
            a03ParceiroNegocio.Excluir(a03Parceiro);
        }
        //botao pesquisa banco
        private void btnPesquisaBanco_Click(object sender, EventArgs e)
        {
            FormA01Pesquisa formPesquisaBanco = new FormA01Pesquisa(this);
            formPesquisaBanco.Show();
        }
    }
}
