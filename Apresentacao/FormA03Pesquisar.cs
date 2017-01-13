using Negocios;
using ObjetoTransferencia;
using System;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FormA03Pesquisar : Form
    {
        //cria um objeto de referencia do form d cadastro de parceiro
        FormA03Cadastrar formA03Cadastrar;
        //CONSTRUTOR
        public FormA03Pesquisar(FormA03Cadastrar frmA03Cadastrar)
        {
            InitializeComponent();
            dgvPesquisaA03.AutoGenerateColumns = false;
            //recebo o form que esta vindo no construtor e atribuo ele a o objeto de referencia criado
            formA03Cadastrar = frmA03Cadastrar;
        }
        //METODO LOAD 
        private void FormA03Pesquisar_Load(object sender, EventArgs e)
        {
            //setar as combobox para que iniciem no indice 0
            cbxCriterioPesquisa.SelectedIndex = 0;
            cbxOpcaoCriterio.SelectedIndex = 0;
            //setar dicas dos botoes do form
            toolTipA03Pesqusiar.SetToolTip(btnCarregaFiltrado, Utilitarios.CARREGAR_FILTRADO);
            toolTipA03Pesqusiar.SetToolTip(btnDesmarcaTudo, Utilitarios.DESMARCAR_TUDO);
            toolTipA03Pesqusiar.SetToolTip(btnExportarParaExcel, Utilitarios.EXPORTAR_EXCEL);
            toolTipA03Pesqusiar.SetToolTip(btnMarcaTudo, Utilitarios.SELECIONAR_TODOS);
            toolTipA03Pesqusiar.SetToolTip(btnPesquisa, Utilitarios.BUSCAR_DADOS);
            toolTipA03Pesqusiar.SetToolTip(btnInverterSelecao, Utilitarios.INVERTER_SELECAO);
        }
        //BOTAO PESQUISA 
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizaGid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Utilitarios.SELECT_ERRO + ex.Message, Utilitarios.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //METODO QUE PREENCHE A GRID
        public void AtualizaGid()
        {
            A03ParceiroNegocios a03ParceiroNegocio = new A03ParceiroNegocios();
            A03ParceiroCollection a03ParceiroCollection = new A03ParceiroCollection();
            a03ParceiroCollection = a03ParceiroNegocio.PesquisaA03(cbxCriterioPesquisa.SelectedIndex, cbxOpcaoCriterio.SelectedIndex, txtCriterioPesquisa.Text);
            dgvPesquisaA03.DataSource = null;
            dgvPesquisaA03.DataSource = a03ParceiroCollection;
        }

        //BOTAO CARREGAR SELECIONADO
        private void btnCarregaFiltrado_Click(object sender, EventArgs e)
        {
            CarregaCamposSelecionado();
        }

        //METODO PARA CARREGAR O SELECIONADO NO FORMULARIO
        private void CarregaCamposSelecionado()
        {
            //verifico se tem algum registro selecionado na grid
            if (dgvPesquisaA03.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Registro Selecionado", Utilitarios.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //se houver registro selecionado
            A03Parceiros a03Parceiro = new A03Parceiros();
            a03Parceiro = (dgvPesquisaA03.SelectedRows[0].DataBoundItem as A03Parceiros);

            // a partir do objeto de referencia eu acesso os campos do form e atribuo a eles o valor do objeto 

            formA03Cadastrar.txtBairroObg.Text = a03Parceiro.a03_005_c;
            formA03Cadastrar.txtCep.Text = a03Parceiro.cep;
            formA03Cadastrar.txtCidade.Text = a03Parceiro.nomeCidade;
            formA03Cadastrar.txtEnderecoObg.Text = a03Parceiro.a03_004_c;
            formA03Cadastrar.txtEstado.Text = a03Parceiro.nomeEstado;
            formA03Cadastrar.txtPais.Text = a03Parceiro.nomePais;
            formA03Cadastrar.txtUf.Text = a03Parceiro.ufEstado;
            formA03Cadastrar.txtCodigo.Text = a03Parceiro.a03_001_c;
            formA03Cadastrar.txtFantasia.Text = a03Parceiro.a03_002_c;
            formA03Cadastrar.txtNomeObg.Text = a03Parceiro.a03_003_c;
            formA03Cadastrar.txtComplemento.Text = a03Parceiro.a03_010_c;
            formA03Cadastrar.txtEmail.Text = a03Parceiro.a03_006_c;
            formA03Cadastrar.mtbFax.Text = a03Parceiro.a03_009_c;
            formA03Cadastrar.mtbFoneObg.Text = a03Parceiro.a03_008_c;
            formA03Cadastrar.dtpCadastroObg.Value = Convert.ToDateTime(a03Parceiro.a03_013_d);
            formA03Cadastrar.txtBanco.Text = a03Parceiro.nomeBanco;
            FormA03Cadastrar.ukey = a03Parceiro.ukey;
            FormA03Cadastrar.a25_ukey = a03Parceiro.a25_ukey ;
            

            //VEIRIFICO SE É CLIENTE OU FORNECEDOR
            if (a03Parceiro.a03_011_n == 1)
            {
                formA03Cadastrar.ckbCliente.Checked = true;

            }
            if (a03Parceiro.a03_012_n == 1)
            {
                formA03Cadastrar.ckbFornecedor.Checked = true;
            }

            //verifico o tipo de pessoa e seto o campo cpf e cnpj de acordo com o tipo de cadastro

            if (a03Parceiro.tipoPessoa == 0)
            {
                formA03Cadastrar.cbxPessoa.SelectedIndex = 1;
                formA03Cadastrar.lblCpfCnpj.Text = "CNPJ:";

            }
            if (a03Parceiro.tipoPessoa == 1)
            {
                formA03Cadastrar.cbxPessoa.SelectedIndex = 0;
                formA03Cadastrar.lblCpfCnpj.Text = "CPF:";
            }
            formA03Cadastrar.mtbCpfCnpjObg.Text = a03Parceiro.a03_007_c;


            //mando dar um refresh em cada campo para que possa atualizar seus valores la no form de referencia que foi 
            //passado no construtor
            formA03Cadastrar.txtBairroObg.Refresh();
            formA03Cadastrar.txtCep.Refresh();
            formA03Cadastrar.txtCidade.Refresh();
            formA03Cadastrar.txtEnderecoObg.Refresh();
            formA03Cadastrar.txtEstado.Refresh();
            formA03Cadastrar.txtPais.Refresh();
            formA03Cadastrar.txtUf.Refresh();
            formA03Cadastrar.btnEditar.Enabled = true;
            formA03Cadastrar.btnExcluir.Enabled = true;

            //fecho o form de pesquisa depois de atualizar os campos do form de referencia 
            Close();
        }

        

    }

}
    

