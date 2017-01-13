using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            DialogResult mensagem = MessageBox.Show("Deseja Realmente Sair do Sistema ?", Utilitarios.TITULO, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mensagem == DialogResult.No)
            {
                return;
            }
            Application.Exit();
        }

        private void parceirosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormA03Cadastrar formA03 = new FormA03Cadastrar();
            formA03.MdiParent = this;
            formA03.Show();
        }

        private void cadastroDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormD04Produto formD04Produto = new FormD04Produto();
            formD04Produto.Show();
        }

        private void cadastroDeFamiliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormD03Familia formD03Familia = new FormD03Familia();
            formD03Familia.Show();
        }

        private void localDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormD07Localestoque formD07Local = new FormD07Localestoque();
            formD07Local.Show();
        }

        private void bancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormA01Banco frmbanco = new FormA01Banco();
            frmbanco.Show();
        }
    }
}
