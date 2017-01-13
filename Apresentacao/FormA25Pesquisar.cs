using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using ObjetoTransferencia;
namespace Apresentacao
{
    public partial class FormA25Pesquisar : Form
    {
        //cria um objeto de referencia do form d cadastro de parceiro
        FormA03Cadastrar formA03Cadastrar;


        public FormA25Pesquisar(FormA03Cadastrar frmA03Cadastrar, string cep)
        {
            InitializeComponent();
            dgvCep.AutoGenerateColumns = false;
            //recebo o form que esta vindo no construtor e atribuo ele a o objeto de referencia criado
            formA03Cadastrar = frmA03Cadastrar;
            txtCepPesquisa.Text = cep;

        }

        private void btnPesquisaCep_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nenhum Registro Encontrado!" + ex.Message);
            }
        }
        /// <summary>
        /// Metodo de atualizar a grid pega o valor que tem a textBox manda para o banco e preenche a grid
        /// </summary>
        private void AtualizaGrid()
        {

            A25CepNegocios a25CepNegocio = new A25CepNegocios();
            A25CepCollection a25Collection = new A25CepCollection();
            a25Collection = a25CepNegocio.PesquisaCep(cbxCepPesquisa.SelectedIndex, txtCepPesquisa.Text);
            dgvCep.DataSource = null;
            dgvCep.DataSource = a25Collection;

        }
        /// <summary>
        /// Metodo de carregamento do frame tudo que for colocado aqui na hora de carregar o form 
        /// ele executa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormA25Pesquisar_Load(object sender, EventArgs e)
        {
            cbxCepPesquisa.SelectedIndex = 0;
        }

        private void btnCarregaSelecionado_Click(object sender, EventArgs e)
        {
            CarregaCamposSelecionado();
        }
        /// <summary>
        /// Metodo Responsavel por pegar o registro selecionado na grid e mandar para o frame de cadastro de parceiro
        /// 
        /// </summary>
        private void CarregaCamposSelecionado()
        {
            //verifico se tem algum registro selecionado na grid
            if (dgvCep.SelectedRows.Count == 0)
            {
                //caso nao tenha nenhum registro selecionado na grid dispara uma mensagem 
                // e da um return vazio
                MessageBox.Show("Nenhum Registro Selecionado");
                return;
            }

            //se houver registro selecionado
            A25Cep a25Cep = new A25Cep();
            a25Cep = (dgvCep.SelectedRows[0].DataBoundItem as A25Cep);

            // a partir do objeto de referencia eu acesso os campos do form e atribuo a eles o valor do objeto a25Cep

            formA03Cadastrar.txtBairroObg.Text = a25Cep.a25_003_c;
            formA03Cadastrar.txtCep.Text = a25Cep.a25_001_c;
            formA03Cadastrar.txtCidade.Text = a25Cep.nomeCidade;
            formA03Cadastrar.txtEnderecoObg.Text = a25Cep.a25_002_c;
            formA03Cadastrar.txtEstado.Text = a25Cep.nomeEstado;
            formA03Cadastrar.txtPais.Text = a25Cep.nomePais;
            formA03Cadastrar.txtUf.Text = a25Cep.ufEstado;
            FormA03Cadastrar.a25_ukey = a25Cep.ukey;

            //mando dar um refresh em cada campo para que possa atualizar seus valores la no form de referencia que foi 
            //passado no construtor
            formA03Cadastrar.txtBairroObg.Refresh();
            formA03Cadastrar.txtCep.Refresh();
            formA03Cadastrar.txtCidade.Refresh();
            formA03Cadastrar.txtEnderecoObg.Refresh();
            formA03Cadastrar.txtEstado.Refresh();
            formA03Cadastrar.txtPais.Refresh();
            formA03Cadastrar.txtUf.Refresh();

            //fecho o form de pesquisa depois de atualizar os campos do form de referencia 
            Close();

        }


    }
}
