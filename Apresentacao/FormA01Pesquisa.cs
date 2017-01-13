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
    public partial class FormA01Pesquisa : Form
    {
        FormA01Banco frmBanco;
        FormA03Cadastrar frmParceiro;
        public FormA01Pesquisa(FormA01Banco formBanco)
        {
            InitializeComponent();
            frmBanco = formBanco;
            dgvDadosBanco.AutoGenerateColumns = false;
        }

        public FormA01Pesquisa(FormA03Cadastrar formParceiro)
        {
            InitializeComponent();
            frmParceiro = formParceiro;
        }

        private void FormA01Pesquisa_Load(object sender, EventArgs e)
        {
            cbxCriterioBusca.SelectedIndex = 0;
            cbxFiltroBusca.SelectedIndex = 0;

            //SETAR DICAS PARA OS BOTOES DO FORM
            toolTipBanco.SetToolTip(btnCarregaFiltrado, Utilitarios.CARREGAR_FILTRADO);
            toolTipBanco.SetToolTip(btnDesmarcaTudo, Utilitarios.DESMARCAR_TUDO);
            toolTipBanco.SetToolTip(btnExportarParaExcel, Utilitarios.EXPORTAR_EXCEL);
            toolTipBanco.SetToolTip(btnMarcaTudo, Utilitarios.SELECIONAR_TODOS);
            toolTipBanco.SetToolTip(btnPesquisar, Utilitarios.BUSCAR_DADOS);
            toolTipBanco.SetToolTip(btnInverterSelecao, Utilitarios.INVERTER_SELECAO);
        }
        //BOTAO PESQUISA
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                PreencheGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Utilitarios.SELECT_ERRO + ex.Message, Utilitarios.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //botao carrega grid
        private void PreencheGrid()
        {

            A01Collection a01Collection = new A01Collection();
            A01BancoNegocio d07Negocio = new A01BancoNegocio();
            a01Collection = d07Negocio.Pesquisa(cbxCriterioBusca.SelectedIndex, cbxFiltroBusca.SelectedIndex, txtParametroPesquisa.Text);
            dgvDadosBanco.DataSource = null;
            dgvDadosBanco.DataSource = a01Collection;
        }

        private void btnCarregaFiltrado_Click(object sender, EventArgs e)
        {
            if (frmParceiro == null)
            {
                if (dgvDadosBanco.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum Registro Selecionado!", Utilitarios.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                A01Banco a01Banco = new A01Banco();
                a01Banco = dgvDadosBanco.SelectedRows[0].DataBoundItem as A01Banco;
                frmBanco.txtCodigoObg.Text = a01Banco.a01_001_c;
                frmBanco.txtDescricaoObg.Text = a01Banco.a01_002_c;
                FormA01Banco.ukey = a01Banco.ukey;
                frmBanco.btnEditar.Enabled = true;
                frmBanco.btnExcluir.Enabled = true;
                Close();
            }
            //entra aqui se for o cadastro de parceiro que chamou
            else if (frmBanco == null)
            {
                if (dgvDadosBanco.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum Registro Selecionado!", Utilitarios.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                A01Banco a01Banco = new A01Banco();
                a01Banco = dgvDadosBanco.SelectedRows[0].DataBoundItem as A01Banco;
                frmParceiro.txtBanco.Text = a01Banco.a01_002_c;
                FormA03Cadastrar.a01_ukey = a01Banco.ukey;
                Close();
            }
        }
    }

}
