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
    public partial class FormD04Pesquisa : Form
    {
        FormD04Produto frmD04Produto;
        public FormD04Pesquisa(FormD04Produto formD04Produto)
        {
            InitializeComponent();
            dgvDadosProduto.AutoGenerateColumns = false;
            frmD04Produto = formD04Produto;
        }

        private void FormD04Pesquisa_Load(object sender, EventArgs e)
        {
            //SETAR AS COMBOBOX PARA INICIAR NO INDIOCE ZERO
            cbxCriterioBusca.SelectedIndex = 0;
            cbxFiltroBusca.SelectedIndex = 0;

            //SETAR DICAS PARA OS BOTOES DO FORM
            toolTipD04Pesquisar.SetToolTip(btnCarregaFiltrado, Utilitarios.CARREGAR_FILTRADO);
            toolTipD04Pesquisar.SetToolTip(btnDesmarcaTudo, Utilitarios.DESMARCAR_TUDO);
            toolTipD04Pesquisar.SetToolTip(btnExportarParaExcel, Utilitarios.EXPORTAR_EXCEL);
            toolTipD04Pesquisar.SetToolTip(btnMarcaTudo, Utilitarios.SELECIONAR_TODOS);
            toolTipD04Pesquisar.SetToolTip(btnPesquisar, Utilitarios.BUSCAR_DADOS);
            toolTipD04Pesquisar.SetToolTip(btnInverterSelecao, Utilitarios.INVERTER_SELECAO);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                PreencheGrid();

            }catch(Exception ex)
            {
                MessageBox.Show(Utilitarios.SELECT_ERRO + ex.Message, Utilitarios.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //METODO PARA PREENCHER A GRID
        public void PreencheGrid()
        {
            D04ProdutoCollection d04Collection = new D04ProdutoCollection();
            D04ProdutoNegocio d04Negocio = new D04ProdutoNegocio();

            d04Collection = d04Negocio.Pesquisa(cbxCriterioBusca.SelectedIndex, cbxFiltroBusca.SelectedIndex, txtBusca.Text);
            dgvDadosProduto.DataSource = null;
            dgvDadosProduto.DataSource = d04Collection;
        }

        //botao carrega selecionado
        private void btnCarregaFiltrado_Click(object sender, EventArgs e)
        {
            CarregaProdutoSelecionado();
        }
        //metodo para carregar produto selecionado
        public void CarregaProdutoSelecionado()
        {
            if(dgvDadosProduto.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Registro Selecionado!", Utilitarios.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            D04Produto d04Produto = new D04Produto();
            d04Produto = (dgvDadosProduto.SelectedRows[0].DataBoundItem as D04Produto);

            //pelo form que veio de referencia seto os campos

            frmD04Produto.txtCodigoObg.Text = d04Produto.d04_001_c;
            frmD04Produto.txtDescricaoObg.Text = d04Produto.d04_002_c;
            frmD04Produto.txtUnidadeMedidaObg.Text = d04Produto.d04_003_c;
            frmD04Produto.nudPrecoCusto.Value = Convert.ToDecimal(d04Produto.d04_004_n);
            frmD04Produto.nudPrecoVenda.Value = Convert.ToDecimal(d04Produto.d04_005_n);
            frmD04Produto.txtNcmObg.Text = d04Produto.d04_006_c;
            frmD04Produto.nudPesoLiquido.Value = Convert.ToDecimal(d04Produto.d04_007_n);
            frmD04Produto.nudPesoBruto.Value = Convert.ToDecimal(d04Produto.d04_008_n);
            frmD04Produto.cbxFamilia.Text = d04Produto.nomeFamilia;
            FormD04Produto.ukey = d04Produto.ukey;
            frmD04Produto.btnEditar.Enabled = true;
            frmD04Produto.btnExcluir.Enabled = true;

            Close();
        }
    }
}
