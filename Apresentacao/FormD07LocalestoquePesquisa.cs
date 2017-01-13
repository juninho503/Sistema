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
    public partial class FormD07LocalestoquePesquisa : Form
    {
        FormD07Localestoque frmLocal;

        public FormD07LocalestoquePesquisa(FormD07Localestoque formD07Local)
        {
            InitializeComponent();
            dgvDadosLocal.AutoGenerateColumns = false;
            frmLocal = formD07Local;
        }

        private void FormD07LocalestoquePesquisa_Load(object sender, EventArgs e)
        {
            cbxCriterioBusca.SelectedIndex = 0;
            cbxFiltroBusca.SelectedIndex = 0;

            //SETAR DICAS PARA OS BOTOES DO FORM
            toolTipLocalEstoque.SetToolTip(btnCarregaFiltrado, Utilitarios.CARREGAR_FILTRADO);
            toolTipLocalEstoque.SetToolTip(btnDesmarcaTudo, Utilitarios.DESMARCAR_TUDO);
            toolTipLocalEstoque.SetToolTip(btnExportarParaExcel, Utilitarios.EXPORTAR_EXCEL);
            toolTipLocalEstoque.SetToolTip(btnMarcaTudo, Utilitarios.SELECIONAR_TODOS);
            toolTipLocalEstoque.SetToolTip(btnPesquisar, Utilitarios.BUSCAR_DADOS);
            toolTipLocalEstoque.SetToolTip(btnInverterSelecao, Utilitarios.INVERTER_SELECAO);
        }
        //botao pesquisa
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                PreencheGrid();
            }catch(Exception ex)
            {
                MessageBox.Show(Utilitarios.SELECT_ERRO + ex.Message, Utilitarios.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //botao carrega grid
        private void PreencheGrid()
        {
           
            D07Collection d07Collection = new D07Collection();
            D07LocalNegocio d07Negocio = new D07LocalNegocio();
            d07Collection = d07Negocio.Pesquisa(cbxCriterioBusca.SelectedIndex, cbxFiltroBusca.SelectedIndex, txtParametroPesquisa.Text);
            dgvDadosLocal.DataSource = null;
            dgvDadosLocal.DataSource = d07Collection;
        }
        //botao carrega selecionado
        private void btnCarregaFiltrado_Click(object sender, EventArgs e)
        {
            CarregaSelecionado();
        }
        //carrega selecionado
        private void CarregaSelecionado()
        {
            if (dgvDadosLocal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Registro Selecionado!", Utilitarios.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            D07LocalEstoque d07Local = new D07LocalEstoque();
            d07Local = dgvDadosLocal.SelectedRows[0].DataBoundItem as D07LocalEstoque;
            frmLocal.txtCodigoObg.Text = d07Local.d07_001_c;
            frmLocal.txtDescricaoObg.Text = d07Local.d07_002_c;
            FormD07Localestoque.ukey = d07Local.ukey;
            frmLocal.btnEditar.Enabled = true;
            frmLocal.btnExcluir.Enabled = true;
            Close();
        }
    }
}
