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
    public partial class FormD03Pesquisa : Form
    {
        FormD03Familia frmD03Familia;
        public FormD03Pesquisa(FormD03Familia formD03Familia)
        {
            InitializeComponent();
            dgvDadosFamilia.AutoGenerateColumns = false;
            frmD03Familia = formD03Familia;
        }

        private void FormD03Pesquisa_Load(object sender, EventArgs e)
        {
            cbxCriterioBusca.SelectedIndex = 0;
            cbxFiltroBusca.SelectedIndex = 0;

            //SETAR DICAS PARA OS BOTOES DO FORM
            toolTipD03Pesquisa.SetToolTip(btnCarregaFiltrado, Utilitarios.CARREGAR_FILTRADO);
            toolTipD03Pesquisa.SetToolTip(btnDesmarcaTudo, Utilitarios.DESMARCAR_TUDO);
            toolTipD03Pesquisa.SetToolTip(btnExportarParaExcel, Utilitarios.EXPORTAR_EXCEL);
            toolTipD03Pesquisa.SetToolTip(btnMarcaTudo, Utilitarios.SELECIONAR_TODOS);
            toolTipD03Pesquisa.SetToolTip(btnPesquisar, Utilitarios.BUSCAR_DADOS);
            toolTipD03Pesquisa.SetToolTip(btnInverterSelecao, Utilitarios.INVERTER_SELECAO);
        }
        //botao pesquisa
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                CarregaGrid();
            } catch(Exception ex)
            {
                MessageBox.Show(Utilitarios.SELECT_ERRO + ex.Message, Utilitarios.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //metodo de carregar a grid
        private void CarregaGrid()
        {
            D03FamiliaNegocio d03Negocio = new D03FamiliaNegocio();
            D03FamiliaCollection d03Collection = new D03FamiliaCollection();
            d03Collection = d03Negocio.Pesquisa(cbxCriterioBusca.SelectedIndex, cbxFiltroBusca.SelectedIndex, txtParametroPesquisa.Text);
            dgvDadosFamilia.DataSource = null;
            dgvDadosFamilia.DataSource = d03Collection;

        }

        private void btnCarregaFiltrado_Click(object sender, EventArgs e)
        {
            CarregaSelecionado();
        }
        //metodo para carregar campos da tela de cadastro a partir da grid
        private void CarregaSelecionado()
        {
            if(dgvDadosFamilia.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Registro Selecionado!", Utilitarios.TITULO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            D03Familia d03Familia = new D03Familia();
            d03Familia = (dgvDadosFamilia.SelectedRows[0].DataBoundItem as D03Familia);
            frmD03Familia.txtCodigoObg.Text = d03Familia.d03_001_c;
            frmD03Familia.txtDescricaoObg.Text = d03Familia.d03_002_c;
            FormD03Familia.ukey = d03Familia.ukey;
            frmD03Familia.btnEditar.Enabled = true;
            frmD03Familia.btnExcluir.Enabled = true;
            frmD03Familia.btnNovo.Enabled = true;

            Close();
        }
    }
}
