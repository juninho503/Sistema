using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Apresentacao
{
    public class Utilitarios

    {
        //atributos staticos para ser chamados no form
        public static string BOTAO_NOVO = "Adicionar Novo Registro!";
        public static string BOTAO_EDITAR = "Alterar Registro da Tela!";
        public static string BOTAO_SALVAR = "Salvar Registro da Tela!";
        public static string BOTAO_EXCLUIR = "Excluir Registro da Tela!";
        public static string BOTAO_PESQUISAR = "Pesquisar Registros!";
        public static string BOTAO_SAIR = "Sair da Tela!";
        public static string TITULO = "SAERP Informa!";
        public static string INSERT_SUCESSO = "Registro Gravado com Sucesso!";
        public static string INSERT_ERRO = "Nao Foi Possivel Gravar o Registro!\n Causa: ";
        public static string DELETE_SUCESSO = "Registro Excluido com Sucesso!";
        public static string DELETE_ERRO = "Não Foi Possivel Excluir o Registro!\n Causa: ";
        public static string UPDATE_SUCESSO = "Registro Alterado com Sucesso!";
        public static string UPDATE_ERRO = "Não Foi Possivel Alterar o Registro!\n Causa: ";
        public static string SELECT_ERRO = "Erro ao Buscar Registros!\n Causa: ";
        public static string CARREGAR_FILTRADO = "Carregar Registros Selecionado!";
        public static string SELECIONAR_TODOS = "Selecionar Todos Registros!";
        public static string DESMARCAR_TUDO = "Desmarcar Todos Registros!";
        public static string EXPORTAR_EXCEL = "Exportar Para o Excel Registros Selecionado!";
        public static string BUSCAR_DADOS = "Buscar!";
        public static string INVERTER_SELECAO = "Inverter Seleção!";

        /// <summary>
        /// Metodo que habilita todos campos do formulario
        /// </summary>
        /// <param name="controles"></param>
        public void HabilitaCampos(Control.ControlCollection controles)
        {
            foreach(Control ctrl in controles)
            {
                //verifico se for o campo entra e atribui TRUE na propriedade enabled
                if(ctrl is TextBox)
                {
                    ((TextBox)ctrl).Enabled = true;
                }else if(ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).Enabled = true;
                } else if(ctrl is MaskedTextBox)
                {
                    ((MaskedTextBox)ctrl).Enabled = true;
                } else if (ctrl is CheckBox)
                {
                    ((CheckBox)ctrl).Enabled = true;
                } else if (ctrl is DateTimePicker)
                {
                    ((DateTimePicker)ctrl).Enabled = true;
                } else if (ctrl is NumericUpDown)
                {
                    ((NumericUpDown)ctrl).Enabled = true;
                }
            }
        }

        /// <summary>
        /// Metodo que retorna uma lista com os Campos que sao Obrigatorios no formulario
        /// Para isso acontecer no nome do componente tem que ter "Obj" no final Ex: txtNomeObj ai ele verifica se contem pega o nome do componente
        /// </summary>
        /// <param name="controles"></param>
        /// <returns></returns>
        public  List<String> CamposObrigatorios(Control.ControlCollection controles)
        {
            List<String> camposObrigatorios = new List<String>();
            foreach(Control ctrl in controles)
            {
                if (ctrl.Name.Contains("Obg"))
                {
                    camposObrigatorios.Add(ctrl.Name);
                }
                if (ctrl.HasChildren)
                {
                    camposObrigatorios = CamposObrigatorios(ctrl.Controls);
                }
            }
            return camposObrigatorios;
        }

        /// <summary>
        /// Metodo que valida os campos do formulario recebe a lista de campos obrigatorios e o formulario que vai ser validado
        /// </summary>
        /// <param name="ctrl"></param>
        /// <param name="camposObrigatorios"></param>
        public void ValidarCamposObrigatorios(Control.ControlCollection ctrl, List<string> camposObrigatorios)
        {
            foreach (Control control in ctrl)
            {
                if (control is TextBox)
                    if (camposObrigatorios.Contains(control.Name) && control.Text == string.Empty)
                        throw new CamposObrigatoriosException();
                if (control is MaskedTextBox)
                    if (camposObrigatorios.Contains(control.Name) && control.Text == string.Empty)
                        throw new CamposObrigatoriosException();
                if (control.HasChildren)
                    ValidarCamposObrigatorios(control.Controls, camposObrigatorios);
            }
        }

        /// <summary>
        /// Metodo Responsavel por desabilitar os controles do formulario
        /// </summary>
        /// <param name="controles"></param>
        public void DesabilitaCampos(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                //verifico se for o campo entra e atribui false na propriedade enabled
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Enabled = false;
                }
                else if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).Enabled = false;
                }
                else if (ctrl is MaskedTextBox)
                {
                    ((MaskedTextBox)ctrl).Enabled = false;
                }
                else if (ctrl is CheckBox)
                {
                    ((CheckBox)ctrl).Enabled = false;
                }
                else if (ctrl is DateTimePicker)
                {
                    ((DateTimePicker)ctrl).Enabled = false;
                } else if (ctrl is NumericUpDown)
                {
                    ((NumericUpDown)ctrl).Enabled = false;
                }
            }
        }

        /// <summary>
        /// Metodo Responsavel por limpar todos textbox do formulario
        /// </summary>
        /// <param name="controles"></param>
        public void LimpaCampos(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                //verifico se for o campo entra e atribui false na propriedade enabled
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Text = "";
                } else if (ctrl is NumericUpDown)
                {
                    ((NumericUpDown)ctrl).Value = 0;
                }
                
                
            }
        }

       
    }
 }