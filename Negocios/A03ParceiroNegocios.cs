using AcessaBancoDados;
using ObjetoTransferencia;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Negocios
{
    public class A03ParceiroNegocios
    {
        AcessaBanco connA03 = new AcessaBanco();
        // query para inserir no banco
        private string insert = "INSERT INTO A03 (A03_001_C,A03_002_C,A03_003_C,A03_004_C,A03_005_C,A03_006_C,A03_007_C,A03_008_C,"
            + " A03_009_C,A03_010_C,A03_011_N,A03_012_N,A25_UKEY,"
            + " A01_UKEY,A21_UKEY,A03_013_D,A03_014_N) VALUES(@a03_001_c,"
            + " @a03_002_c,@a03_003_c,@a03_004_c,@a03_005_c,@a03_006_c,@a03_007_c,@a03_008_c,@a03_009_c,@a03_010_c,"
            + " @a03_011_n,@a03_012_n,@a25_ukey,@a01_ukey,@a21_ukey,@a03_013_d, @a03_014_n)";
        //query para alterar no banco
        private string update = "UPDATE A03 SET A03_001_C=@a03_001_c,A03_002_C=@a03_002_c,A03_003_C=@a03_003_c,A03_004_C=@a03_004_c,A03_005_C=@a03_006_c,"
           + "A03_007_C=@a03_007_c,A03_008_C=@a03_008_c,A03_009_C=@a03_009_c,A03_010_C=@a03_010_c,A03_011_N=@a03_011_n,A03_012_N=@a03_012_n,A25_UKEY=@a25_ukey,"
           + "A01_UKEY=@a01_ukey,A21_UKEY=@a21_ukey,A03_013_D=@a03_013_d, A03_014_N = @a03_014_n WHERE UKEY=@ukey";
        //query para excluir no banco
        private string delete = "DELETE FROM A03 WHERE UKEY=@ukey";
        //select iniciado por
        private string selectPorCodigo = "SELECT A03.UKEY AS IDPARCEIRO, A25.UKEY AS UKEYCEP, * FROM A03"
                               + " LEFT JOIN A25 ON A03.A25_UKEY = A25.UKEY"
                               + " LEFT JOIN A01 ON A03.A01_UKEY = A01.UKEY"
                               + " LEFT JOIN A21 ON A03.A21_UKEY = A21.UKEY"
                               + " LEFT JOIN A24 ON A25.A24_UKEY = A24.UKEY"
                               + " LEFT JOIN A23 ON A24.A23_UKEY = A23.UKEY"
                               + " LEFT JOIN A22 ON A23.A22_UKEY = A22.UKEY" 
                               + " WHERE A03_001_C LIKE @A03_001_C OR A03_003_C LIKE @A03_003_C OR A23_001_C LIKE @A23_001_C OR A03_007_C LIKE @A03_007_C";
       
        //select igual
        private string selectPorCodigoIgual = "SELECT A03.UKEY AS IDPARCEIRO, A25.UKEY AS UKEYCEP, * FROM A03"
                               + " LEFT JOIN A25 ON A03.A25_UKEY = A25.UKEY"
                               + " LEFT JOIN A01 ON A03.A01_UKEY = A01.UKEY"
                               + " LEFT JOIN A21 ON A03.A21_UKEY = A21.UKEY"
                               + " LEFT JOIN A24 ON A25.A24_UKEY = A24.UKEY"
                               + " LEFT JOIN A23 ON A24.A23_UKEY = A23.UKEY"
                               + " LEFT JOIN A22 ON A23.A22_UKEY = A22.UKEY"
                               + " WHERE A03_001_C = @A03_001_C OR A03_003_C = @A03_003_C OR A23_001_C = @A23_001_C OR A03_007_C = @A03_007_C";
        //select diferente De
        private string selectPorCodigoDiferenteDe = "SELECT A03.UKEY AS IDPARCEIRO, A25.UKEY AS UKEYCEP, * FROM A03"
                               + " LEFT JOIN A25 ON A03.A25_UKEY = A25.UKEY"
                               + " LEFT JOIN A01 ON A03.A01_UKEY = A01.UKEY"
                               + " LEFT JOIN A21 ON A03.A21_UKEY = A21.UKEY"
                               + " LEFT JOIN A24 ON A25.A24_UKEY = A24.UKEY"
                               + " LEFT JOIN A23 ON A24.A23_UKEY = A23.UKEY"
                               + " LEFT JOIN A22 ON A23.A22_UKEY = A22.UKEY"
                               + " WHERE A03_001_C <> @A03_001_C OR A03_003_C <> @A03_003_C OR A23_001_C <> @A23_001_C OR A03_007_C <> @A03_007_C";
        /// <summary>
        /// Metodo que grava o registro no banco de dados
        /// </summary>
        /// <param name="a03Parceiros"></param>
        /// <returns>string</returns>
        public void Inserir(A03Parceiros a03Parceiros)
        {

            //limpa a variavel caso tenha lixo de memoria ow parametros de outra ocorrencia
            connA03.LimparParametros();
            connA03.AdicionarParametros("@a03_001_c", a03Parceiros.a03_001_c);
            connA03.AdicionarParametros("@a03_002_c", a03Parceiros.a03_002_c);
            connA03.AdicionarParametros("@a03_003_c", a03Parceiros.a03_003_c);
            connA03.AdicionarParametros("@a03_004_c", a03Parceiros.a03_004_c);
            connA03.AdicionarParametros("@a03_005_c", a03Parceiros.a03_005_c);
            connA03.AdicionarParametros("@a03_006_c", a03Parceiros.a03_006_c);
            connA03.AdicionarParametros("@a03_007_c", a03Parceiros.a03_007_c);
            connA03.AdicionarParametros("@a03_008_c", a03Parceiros.a03_008_c);
            connA03.AdicionarParametros("@a03_009_c", a03Parceiros.a03_009_c);
            connA03.AdicionarParametros("@a03_010_c", a03Parceiros.a03_010_c);
            connA03.AdicionarParametros("@a03_011_n", a03Parceiros.a03_011_n);
            connA03.AdicionarParametros("@a03_012_n", a03Parceiros.a03_012_n);
            connA03.AdicionarParametros("@a25_ukey", a03Parceiros.a25_ukey);
            if (a03Parceiros.a01_ukey == null)
            {
                connA03.AdicionarParametros("@a01_ukey", DBNull.Value);
            }else
            {
                connA03.AdicionarParametros("@a01_ukey", a03Parceiros.a01_ukey);
            }
            if (a03Parceiros.a21_ukey == null)
            {
                connA03.AdicionarParametros("@a21_ukey", DBNull.Value);
            }
            else
            {
                connA03.AdicionarParametros("@a21_ukey", a03Parceiros.a21_ukey);
            }
            connA03.AdicionarParametros("@a03_013_d", a03Parceiros.a03_013_d);
            connA03.AdicionarParametros("@a03_014_n", a03Parceiros.tipoPessoa);
            connA03.ExecutaManipulacao(CommandType.Text, insert);




        }
        /// <summary>
        /// Metodo de alteraração no banco de dados
        /// </summary>
        /// <param name="a03Parceiros"></param>
        /// <returns>string</returns>
        public string Alterar(A03Parceiros a03Parceiros)
        {
            try
            {
                connA03.LimparParametros();
                connA03.AdicionarParametros("@a03_001_c", a03Parceiros.a03_001_c);
                connA03.AdicionarParametros("@a03_002_c", a03Parceiros.a03_002_c);
                connA03.AdicionarParametros("@a03_003_c", a03Parceiros.a03_003_c);
                connA03.AdicionarParametros("@a03_004_c", a03Parceiros.a03_004_c);
                connA03.AdicionarParametros("@a03_005_c", a03Parceiros.a03_005_c);
                connA03.AdicionarParametros("@a03_006_c", a03Parceiros.a03_006_c);
                connA03.AdicionarParametros("@a03_007_c", a03Parceiros.a03_007_c);
                connA03.AdicionarParametros("@a03_008_c", a03Parceiros.a03_008_c);
                connA03.AdicionarParametros("@a03_009_c", a03Parceiros.a03_009_c);
                connA03.AdicionarParametros("@a03_010_c", a03Parceiros.a03_010_c);
                connA03.AdicionarParametros("@a03_011_n", a03Parceiros.a03_011_n);
                connA03.AdicionarParametros("@a03_012_n", a03Parceiros.a03_012_n);
                connA03.AdicionarParametros("@a25_ukey", a03Parceiros.a25_ukey);
                if (a03Parceiros.a01_ukey == null)
                {
                    connA03.AdicionarParametros("@a01_ukey", DBNull.Value);
                }
                else
                {
                    connA03.AdicionarParametros("@a01_ukey", a03Parceiros.a01_ukey);
                }
                if (a03Parceiros.a21_ukey == null)
                {
                    connA03.AdicionarParametros("@a21_ukey", DBNull.Value);
                }
                else
                {
                    connA03.AdicionarParametros("@a21_ukey", a03Parceiros.a21_ukey);
                }
                connA03.AdicionarParametros("@a03_013_d", a03Parceiros.a03_013_d);
                connA03.AdicionarParametros("@a03_014_n", a03Parceiros.tipoPessoa);
                connA03.AdicionarParametros("@ukey", a03Parceiros.ukey);
                connA03.ExecutaManipulacao(CommandType.Text, update);
                return "Registro Alterado com Sucesso!";
            }
            catch (Exception ex)
            {
                return "Não Foi Possivel Alterar o Registro! \n Causa: " + ex.Message;
            }
        }
        /// <summary>
        /// Metodo de exclusao no banco de dados
        /// </summary>
        /// <param name="a03Parceiros"></param>
        /// <returns>string</returns>
        public void Excluir(A03Parceiros a03Parceiros)
        {
            
                connA03.LimparParametros();
                connA03.AdicionarParametros("@ukey", a03Parceiros.ukey);
                connA03.ExecutaManipulacao(CommandType.Text, delete);
                
            
        }
        /// <summary>
        /// Metodo que retorna uma coleçao de parceiros 
        /// </summary>
        /// <param name="opcao"></param>
        /// <param name="nome"></param>
        /// <returns>coleçao de parceiros</returns>
        public A03ParceiroCollection PesquisaA03(int opcaoCriterio, int opcaoFiltroCriterio, string valorCriterio)
        {
            try
            {
                A03ParceiroCollection a03Collection = new A03ParceiroCollection();


                switch (opcaoCriterio)
                {
                    //caso seja zero vai pesquisar por codigo
                    case 0:
                        connA03.LimparParametros();
                        //verifica qual query vai executar conforme o indice que vier da combobox
                        if (opcaoFiltroCriterio == 0)
                        {
                            //passa o valor ao parametro da select iniciado por
                            connA03.AdicionarParametros("@A03_001_C", valorCriterio + "%");
                            connA03.AdicionarParametros("@A03_003_C", "");
                            connA03.AdicionarParametros("@A03_007_C", "");
                            connA03.AdicionarParametros("@A23_001_C", "");
                            DataTable dataTable = connA03.ExecutaConsulta(CommandType.Text, selectPorCodigo);
                            foreach (DataRow linha in dataTable.Rows)
                            {
                                A03Parceiros a03Parceiros = new A03Parceiros();
                                a03Parceiros.ukey = Convert.ToString(linha["IDPARCEIRO"]);
                                a03Parceiros.a03_001_c = Convert.ToString(linha["A03_001_C"]);
                                a03Parceiros.a03_002_c = Convert.ToString(linha["A03_002_C"]);
                                a03Parceiros.a03_003_c = Convert.ToString(linha["A03_003_C"]);
                                a03Parceiros.a03_004_c = Convert.ToString(linha["A03_004_C"]);
                                a03Parceiros.a03_005_c = Convert.ToString(linha["A03_005_C"]);
                                a03Parceiros.a03_006_c = Convert.ToString(linha["A03_006_C"]);
                                a03Parceiros.a03_007_c = Convert.ToString(linha["A03_007_C"]);
                                a03Parceiros.a03_008_c = Convert.ToString(linha["A03_008_C"]);
                                a03Parceiros.a03_009_c = Convert.ToString(linha["A03_009_C"]);
                                a03Parceiros.a03_010_c = Convert.ToString(linha["A03_010_C"]);
                                a03Parceiros.a03_011_n = Convert.ToInt16(linha["A03_011_N"]);
                                a03Parceiros.a03_012_n = Convert.ToInt16(linha["A03_012_N"]);
                                a03Parceiros.a03_013_d = Convert.ToDateTime(linha["A03_013_D"]);
                                a03Parceiros.nomeCidade = Convert.ToString(linha["A24_001_C"]);
                                a03Parceiros.ufEstado = Convert.ToString(linha["A23_001_C"]);
                                a03Parceiros.nomeEstado = Convert.ToString(linha["A23_002_C"]);
                                a03Parceiros.nomePais = Convert.ToString(linha["A22_001_C"]);
                                a03Parceiros.a25_ukey = Convert.ToString(linha["UKEYCEP"]);
                                a03Parceiros.cep = Convert.ToString(linha["A25_001_C"]);
                                a03Parceiros.nomeBanco = Convert.ToString(linha["A01_002_C"]);
                                a03Parceiros.nomeTipoDocumento = Convert.ToString(linha["A21_001_C"]);
                                a03Parceiros.tipoPessoa = Convert.ToInt16(linha["A03_014_N"]);
                                a03Collection.Add(a03Parceiros);
                            }
                            return a03Collection;
                        }
                        else if (opcaoFiltroCriterio == 1)
                        {
                            //passa o valor ao parametro da select contem
                            connA03.AdicionarParametros("@A03_001_C", "%" + valorCriterio + "%");
                            connA03.AdicionarParametros("@A03_003_C", "");
                            connA03.AdicionarParametros("@A03_007_C", "");
                            connA03.AdicionarParametros("@A23_001_C", "");
                            DataTable dataTable = connA03.ExecutaConsulta(CommandType.Text, selectPorCodigo);
                            foreach (DataRow linha in dataTable.Rows)
                            {
                                A03Parceiros a03Parceiros = new A03Parceiros();
                                a03Parceiros.ukey = Convert.ToString(linha["IDPARCEIRO"]);
                                a03Parceiros.a03_001_c = Convert.ToString(linha["A03_001_C"]);
                                a03Parceiros.a03_002_c = Convert.ToString(linha["A03_002_C"]);
                                a03Parceiros.a03_003_c = Convert.ToString(linha["A03_003_C"]);
                                a03Parceiros.a03_004_c = Convert.ToString(linha["A03_004_C"]);
                                a03Parceiros.a03_005_c = Convert.ToString(linha["A03_005_C"]);
                                a03Parceiros.a03_006_c = Convert.ToString(linha["A03_006_C"]);
                                a03Parceiros.a03_007_c = Convert.ToString(linha["A03_007_C"]);
                                a03Parceiros.a03_008_c = Convert.ToString(linha["A03_008_C"]);
                                a03Parceiros.a03_009_c = Convert.ToString(linha["A03_009_C"]);
                                a03Parceiros.a03_010_c = Convert.ToString(linha["A03_010_C"]);
                                a03Parceiros.a03_011_n = Convert.ToInt16(linha["A03_011_N"]);
                                a03Parceiros.a03_012_n = Convert.ToInt16(linha["A03_012_N"]);
                                a03Parceiros.a03_013_d = Convert.ToDateTime(linha["A03_013_D"]);
                                a03Parceiros.nomeCidade = Convert.ToString(linha["A24_001_C"]);
                                a03Parceiros.ufEstado = Convert.ToString(linha["A23_001_C"]);
                                a03Parceiros.nomeEstado = Convert.ToString(linha["A23_002_C"]);
                                a03Parceiros.nomePais = Convert.ToString(linha["A22_001_C"]);
                                a03Parceiros.a25_ukey = Convert.ToString(linha["UKEYCEP"]);
                                a03Parceiros.cep = Convert.ToString(linha["A25_001_C"]);
                                a03Parceiros.nomeBanco = Convert.ToString(linha["A01_002_C"]);
                                a03Parceiros.nomeTipoDocumento = Convert.ToString(linha["A21_001_C"]);
                                a03Parceiros.tipoPessoa = Convert.ToInt16(linha["A03_014_N"]);
                                a03Collection.Add(a03Parceiros);
                            }
                            return a03Collection;

                            // condição se for igual
                        }
                        else if (opcaoFiltroCriterio == 2)
                        {
                            connA03.AdicionarParametros("@A03_001_C", valorCriterio);
                            connA03.AdicionarParametros("@A03_003_C", "");
                            connA03.AdicionarParametros("@A03_007_C", "");
                            connA03.AdicionarParametros("@A23_001_C", "");
                            DataTable dataTable = connA03.ExecutaConsulta(CommandType.Text, selectPorCodigoIgual);
                            foreach (DataRow linha in dataTable.Rows)
                            {
                                A03Parceiros a03Parceiros = new A03Parceiros();
                                a03Parceiros.ukey = Convert.ToString(linha["IDPARCEIRO"]);
                                a03Parceiros.a03_001_c = Convert.ToString(linha["A03_001_C"]);
                                a03Parceiros.a03_002_c = Convert.ToString(linha["A03_002_C"]);
                                a03Parceiros.a03_003_c = Convert.ToString(linha["A03_003_C"]);
                                a03Parceiros.a03_004_c = Convert.ToString(linha["A03_004_C"]);
                                a03Parceiros.a03_005_c = Convert.ToString(linha["A03_005_C"]);
                                a03Parceiros.a03_006_c = Convert.ToString(linha["A03_006_C"]);
                                a03Parceiros.a03_007_c = Convert.ToString(linha["A03_007_C"]);
                                a03Parceiros.a03_008_c = Convert.ToString(linha["A03_008_C"]);
                                a03Parceiros.a03_009_c = Convert.ToString(linha["A03_009_C"]);
                                a03Parceiros.a03_010_c = Convert.ToString(linha["A03_010_C"]);
                                a03Parceiros.a03_011_n = Convert.ToInt16(linha["A03_011_N"]);
                                a03Parceiros.a03_012_n = Convert.ToInt16(linha["A03_012_N"]);
                                a03Parceiros.a03_013_d = Convert.ToDateTime(linha["A03_013_D"]);
                                a03Parceiros.nomeCidade = Convert.ToString(linha["A24_001_C"]);
                                a03Parceiros.ufEstado = Convert.ToString(linha["A23_001_C"]);
                                a03Parceiros.nomeEstado = Convert.ToString(linha["A23_002_C"]);
                                a03Parceiros.nomePais = Convert.ToString(linha["A22_001_C"]);
                                a03Parceiros.a25_ukey = Convert.ToString(linha["UKEYCEP"]);
                                a03Parceiros.cep = Convert.ToString(linha["A25_001_C"]);
                                a03Parceiros.nomeBanco = Convert.ToString(linha["A01_002_C"]);
                                a03Parceiros.nomeTipoDocumento = Convert.ToString(linha["A21_001_C"]);
                                a03Parceiros.tipoPessoa = Convert.ToInt16(linha["A03_014_N"]);
                                a03Collection.Add(a03Parceiros);
                            }
                            return a03Collection;
                        }
                        //condição se for terminado por
                        else if (opcaoFiltroCriterio == 3)
                        {
                            connA03.AdicionarParametros("@A03_001_C", "%" + valorCriterio);
                            connA03.AdicionarParametros("@A03_003_C", "");
                            connA03.AdicionarParametros("@A03_007_C", "");
                            connA03.AdicionarParametros("@A23_001_C", "");
                            DataTable dataTable = connA03.ExecutaConsulta(CommandType.Text, selectPorCodigo);
                            foreach (DataRow linha in dataTable.Rows)
                            {
                                A03Parceiros a03Parceiros = new A03Parceiros();
                                a03Parceiros.ukey = Convert.ToString(linha["IDPARCEIRO"]);
                                a03Parceiros.a03_001_c = Convert.ToString(linha["A03_001_C"]);
                                a03Parceiros.a03_002_c = Convert.ToString(linha["A03_002_C"]);
                                a03Parceiros.a03_003_c = Convert.ToString(linha["A03_003_C"]);
                                a03Parceiros.a03_004_c = Convert.ToString(linha["A03_004_C"]);
                                a03Parceiros.a03_005_c = Convert.ToString(linha["A03_005_C"]);
                                a03Parceiros.a03_006_c = Convert.ToString(linha["A03_006_C"]);
                                a03Parceiros.a03_007_c = Convert.ToString(linha["A03_007_C"]);
                                a03Parceiros.a03_008_c = Convert.ToString(linha["A03_008_C"]);
                                a03Parceiros.a03_009_c = Convert.ToString(linha["A03_009_C"]);
                                a03Parceiros.a03_010_c = Convert.ToString(linha["A03_010_C"]);
                                a03Parceiros.a03_011_n = Convert.ToInt16(linha["A03_011_N"]);
                                a03Parceiros.a03_012_n = Convert.ToInt16(linha["A03_012_N"]);
                                a03Parceiros.a03_013_d = Convert.ToDateTime(linha["A03_013_D"]);
                                a03Parceiros.nomeCidade = Convert.ToString(linha["A24_001_C"]);
                                a03Parceiros.ufEstado = Convert.ToString(linha["A23_001_C"]);
                                a03Parceiros.nomeEstado = Convert.ToString(linha["A23_002_C"]);
                                a03Parceiros.nomePais = Convert.ToString(linha["A22_001_C"]);
                                a03Parceiros.a25_ukey = Convert.ToString(linha["UKEYCEP"]);
                                a03Parceiros.cep = Convert.ToString(linha["A25_001_C"]);
                                a03Parceiros.nomeBanco = Convert.ToString(linha["A01_002_C"]);
                                a03Parceiros.nomeTipoDocumento = Convert.ToString(linha["A21_001_C"]);
                                a03Parceiros.tipoPessoa = Convert.ToInt16(linha["A03_014_N"]);
                                a03Collection.Add(a03Parceiros);
                            }
                            return a03Collection;
                        }

                        //condioção se for diferente de
                        else if (opcaoFiltroCriterio == 4)
                        {
                            connA03.AdicionarParametros("@A03_001_C", valorCriterio);
                            connA03.AdicionarParametros("@A03_003_C", "");
                            connA03.AdicionarParametros("@A03_007_C", "");
                            connA03.AdicionarParametros("@A23_001_C", "");
                            DataTable dataTable = connA03.ExecutaConsulta(CommandType.Text, selectPorCodigoDiferenteDe);
                            foreach (DataRow linha in dataTable.Rows)
                            {
                                A03Parceiros a03Parceiros = new A03Parceiros();
                                a03Parceiros.ukey = Convert.ToString(linha["IDPARCEIRO"]);
                                a03Parceiros.a03_001_c = Convert.ToString(linha["A03_001_C"]);
                                a03Parceiros.a03_002_c = Convert.ToString(linha["A03_002_C"]);
                                a03Parceiros.a03_003_c = Convert.ToString(linha["A03_003_C"]);
                                a03Parceiros.a03_004_c = Convert.ToString(linha["A03_004_C"]);
                                a03Parceiros.a03_005_c = Convert.ToString(linha["A03_005_C"]);
                                a03Parceiros.a03_006_c = Convert.ToString(linha["A03_006_C"]);
                                a03Parceiros.a03_007_c = Convert.ToString(linha["A03_007_C"]);
                                a03Parceiros.a03_008_c = Convert.ToString(linha["A03_008_C"]);
                                a03Parceiros.a03_009_c = Convert.ToString(linha["A03_009_C"]);
                                a03Parceiros.a03_010_c = Convert.ToString(linha["A03_010_C"]);
                                a03Parceiros.a03_011_n = Convert.ToInt16(linha["A03_011_N"]);
                                a03Parceiros.a03_012_n = Convert.ToInt16(linha["A03_012_N"]);
                                a03Parceiros.a03_013_d = Convert.ToDateTime(linha["A03_013_D"]);
                                a03Parceiros.nomeCidade = Convert.ToString(linha["A24_001_C"]);
                                a03Parceiros.ufEstado = Convert.ToString(linha["A23_001_C"]);
                                a03Parceiros.nomeEstado = Convert.ToString(linha["A23_002_C"]);
                                a03Parceiros.nomePais = Convert.ToString(linha["A22_001_C"]);
                                a03Parceiros.a25_ukey = Convert.ToString(linha["UKEYCEP"]);
                                a03Parceiros.cep = Convert.ToString(linha["A25_001_C"]);
                                a03Parceiros.nomeBanco = Convert.ToString(linha["A01_002_C"]);
                                a03Parceiros.nomeTipoDocumento = Convert.ToString(linha["A21_001_C"]);
                                a03Parceiros.tipoPessoa = Convert.ToInt16(linha["A03_014_N"]);
                                a03Collection.Add(a03Parceiros);
                            }
                            return a03Collection;
                        }
                        return a03Collection;

                    //CASO SEJA POR NOME O CRITERIO DE BUSCA
                    case 1:
                        //SE FOR 0 SELECT INICIADO POR
                        if (opcaoFiltroCriterio == 0)
                        {
                            connA03.AdicionarParametros("@A03_003_C", valorCriterio + "%");
                            connA03.AdicionarParametros("@A03_001_C", "");
                            connA03.AdicionarParametros("@A03_007_C", "");
                            connA03.AdicionarParametros("@A23_001_C", "");
                            DataTable dataTable = connA03.ExecutaConsulta(CommandType.Text, selectPorCodigo);
                            foreach (DataRow linha in dataTable.Rows)
                            {
                                A03Parceiros a03Parceiros = new A03Parceiros();
                                a03Parceiros.ukey = Convert.ToString(linha["IDPARCEIRO"]);
                                a03Parceiros.a03_001_c = Convert.ToString(linha["A03_001_C"]);
                                a03Parceiros.a03_002_c = Convert.ToString(linha["A03_002_C"]);
                                a03Parceiros.a03_003_c = Convert.ToString(linha["A03_003_C"]);
                                a03Parceiros.a03_004_c = Convert.ToString(linha["A03_004_C"]);
                                a03Parceiros.a03_005_c = Convert.ToString(linha["A03_005_C"]);
                                a03Parceiros.a03_006_c = Convert.ToString(linha["A03_006_C"]);
                                a03Parceiros.a03_007_c = Convert.ToString(linha["A03_007_C"]);
                                a03Parceiros.a03_008_c = Convert.ToString(linha["A03_008_C"]);
                                a03Parceiros.a03_009_c = Convert.ToString(linha["A03_009_C"]);
                                a03Parceiros.a03_010_c = Convert.ToString(linha["A03_010_C"]);
                                a03Parceiros.a03_011_n = Convert.ToInt16(linha["A03_011_N"]);
                                a03Parceiros.a03_012_n = Convert.ToInt16(linha["A03_012_N"]);
                                a03Parceiros.a03_013_d = Convert.ToDateTime(linha["A03_013_D"]);
                                a03Parceiros.nomeCidade = Convert.ToString(linha["A24_001_C"]);
                                a03Parceiros.ufEstado = Convert.ToString(linha["A23_001_C"]);
                                a03Parceiros.nomeEstado = Convert.ToString(linha["A23_002_C"]);
                                a03Parceiros.nomePais = Convert.ToString(linha["A22_001_C"]);
                                a03Parceiros.a25_ukey = Convert.ToString(linha["UKEYCEP"]);
                                a03Parceiros.cep = Convert.ToString(linha["A25_001_C"]);
                                a03Parceiros.nomeBanco = Convert.ToString(linha["A01_002_C"]);
                                a03Parceiros.nomeTipoDocumento = Convert.ToString(linha["A21_001_C"]);
                                a03Parceiros.tipoPessoa = Convert.ToInt16(linha["A03_014_N"]);
                                a03Collection.Add(a03Parceiros);
                            }
                            return a03Collection;
                        } 
                        //CONDIÇÃO SE FOR CONTEM
                        else if (opcaoFiltroCriterio == 1)
                        {
                            connA03.AdicionarParametros("@A03_003_C", "%" + valorCriterio + "%");
                            connA03.AdicionarParametros("@A03_001_C", "");
                            connA03.AdicionarParametros("@A03_007_C", "");
                            connA03.AdicionarParametros("@A23_001_C", "");
                            DataTable dataTable = connA03.ExecutaConsulta(CommandType.Text, selectPorCodigo);
                            foreach (DataRow linha in dataTable.Rows)
                            {
                                A03Parceiros a03Parceiros = new A03Parceiros();
                                a03Parceiros.ukey = Convert.ToString(linha["IDPARCEIRO"]);
                                a03Parceiros.a03_001_c = Convert.ToString(linha["A03_001_C"]);
                                a03Parceiros.a03_002_c = Convert.ToString(linha["A03_002_C"]);
                                a03Parceiros.a03_003_c = Convert.ToString(linha["A03_003_C"]);
                                a03Parceiros.a03_004_c = Convert.ToString(linha["A03_004_C"]);
                                a03Parceiros.a03_005_c = Convert.ToString(linha["A03_005_C"]);
                                a03Parceiros.a03_006_c = Convert.ToString(linha["A03_006_C"]);
                                a03Parceiros.a03_007_c = Convert.ToString(linha["A03_007_C"]);
                                a03Parceiros.a03_008_c = Convert.ToString(linha["A03_008_C"]);
                                a03Parceiros.a03_009_c = Convert.ToString(linha["A03_009_C"]);
                                a03Parceiros.a03_010_c = Convert.ToString(linha["A03_010_C"]);
                                a03Parceiros.a03_011_n = Convert.ToInt16(linha["A03_011_N"]);
                                a03Parceiros.a03_012_n = Convert.ToInt16(linha["A03_012_N"]);
                                a03Parceiros.a03_013_d = Convert.ToDateTime(linha["A03_013_D"]);
                                a03Parceiros.nomeCidade = Convert.ToString(linha["A24_001_C"]);
                                a03Parceiros.ufEstado = Convert.ToString(linha["A23_001_C"]);
                                a03Parceiros.nomeEstado = Convert.ToString(linha["A23_002_C"]);
                                a03Parceiros.nomePais = Convert.ToString(linha["A22_001_C"]);
                                a03Parceiros.a25_ukey = Convert.ToString(linha["UKEYCEP"]);
                                a03Parceiros.cep = Convert.ToString(linha["A25_001_C"]);
                                a03Parceiros.nomeBanco = Convert.ToString(linha["A01_002_C"]);
                                a03Parceiros.nomeTipoDocumento = Convert.ToString(linha["A21_001_C"]);
                                a03Parceiros.tipoPessoa = Convert.ToInt16(linha["A03_014_N"]);
                                a03Collection.Add(a03Parceiros);
                            }
                            return a03Collection;
                        }

                        //CONDIÇÃO SE FOR IGUAL
                        else if (opcaoFiltroCriterio == 2)
                        {
                            connA03.AdicionarParametros("@A03_003_C", valorCriterio);
                            connA03.AdicionarParametros("@A03_001_C", "");
                            connA03.AdicionarParametros("@A03_007_C", "");
                            connA03.AdicionarParametros("@A23_001_C", "");
                            DataTable dataTable = connA03.ExecutaConsulta(CommandType.Text, selectPorCodigoIgual);
                            foreach (DataRow linha in dataTable.Rows)
                            {
                                A03Parceiros a03Parceiros = new A03Parceiros();
                                a03Parceiros.ukey = Convert.ToString(linha["IDPARCEIRO"]);
                                a03Parceiros.a03_001_c = Convert.ToString(linha["A03_001_C"]);
                                a03Parceiros.a03_002_c = Convert.ToString(linha["A03_002_C"]);
                                a03Parceiros.a03_003_c = Convert.ToString(linha["A03_003_C"]);
                                a03Parceiros.a03_004_c = Convert.ToString(linha["A03_004_C"]);
                                a03Parceiros.a03_005_c = Convert.ToString(linha["A03_005_C"]);
                                a03Parceiros.a03_006_c = Convert.ToString(linha["A03_006_C"]);
                                a03Parceiros.a03_007_c = Convert.ToString(linha["A03_007_C"]);
                                a03Parceiros.a03_008_c = Convert.ToString(linha["A03_008_C"]);
                                a03Parceiros.a03_009_c = Convert.ToString(linha["A03_009_C"]);
                                a03Parceiros.a03_010_c = Convert.ToString(linha["A03_010_C"]);
                                a03Parceiros.a03_011_n = Convert.ToInt16(linha["A03_011_N"]);
                                a03Parceiros.a03_012_n = Convert.ToInt16(linha["A03_012_N"]);
                                a03Parceiros.a03_013_d = Convert.ToDateTime(linha["A03_013_D"]);
                                a03Parceiros.nomeCidade = Convert.ToString(linha["A24_001_C"]);
                                a03Parceiros.ufEstado = Convert.ToString(linha["A23_001_C"]);
                                a03Parceiros.nomeEstado = Convert.ToString(linha["A23_002_C"]);
                                a03Parceiros.nomePais = Convert.ToString(linha["A22_001_C"]);
                                a03Parceiros.a25_ukey = Convert.ToString(linha["UKEYCEP"]);
                                a03Parceiros.cep = Convert.ToString(linha["A25_001_C"]);
                                a03Parceiros.nomeBanco = Convert.ToString(linha["A01_002_C"]);
                                a03Parceiros.nomeTipoDocumento = Convert.ToString(linha["A21_001_C"]);
                                a03Parceiros.tipoPessoa = Convert.ToInt16(linha["A03_014_N"]);
                                a03Collection.Add(a03Parceiros);
                            }
                            return a03Collection;
                        }

                        //CONDIÇÃO SE FOR TERMINADIO POR
                        else if (opcaoFiltroCriterio == 3)
                        {
                            connA03.AdicionarParametros("@A03_003_C", "%" + valorCriterio + "%");
                            connA03.AdicionarParametros("@A03_001_C", "");
                            connA03.AdicionarParametros("@A03_007_C", "");
                            connA03.AdicionarParametros("@A23_001_C", "");
                            DataTable dataTable = connA03.ExecutaConsulta(CommandType.Text, selectPorCodigo);
                            foreach (DataRow linha in dataTable.Rows)
                            {
                                A03Parceiros a03Parceiros = new A03Parceiros();
                                a03Parceiros.ukey = Convert.ToString(linha["IDPARCEIRO"]);
                                a03Parceiros.a03_001_c = Convert.ToString(linha["A03_001_C"]);
                                a03Parceiros.a03_002_c = Convert.ToString(linha["A03_002_C"]);
                                a03Parceiros.a03_003_c = Convert.ToString(linha["A03_003_C"]);
                                a03Parceiros.a03_004_c = Convert.ToString(linha["A03_004_C"]);
                                a03Parceiros.a03_005_c = Convert.ToString(linha["A03_005_C"]);
                                a03Parceiros.a03_006_c = Convert.ToString(linha["A03_006_C"]);
                                a03Parceiros.a03_007_c = Convert.ToString(linha["A03_007_C"]);
                                a03Parceiros.a03_008_c = Convert.ToString(linha["A03_008_C"]);
                                a03Parceiros.a03_009_c = Convert.ToString(linha["A03_009_C"]);
                                a03Parceiros.a03_010_c = Convert.ToString(linha["A03_010_C"]);
                                a03Parceiros.a03_011_n = Convert.ToInt16(linha["A03_011_N"]);
                                a03Parceiros.a03_012_n = Convert.ToInt16(linha["A03_012_N"]);
                                a03Parceiros.a03_013_d = Convert.ToDateTime(linha["A03_013_D"]);
                                a03Parceiros.nomeCidade = Convert.ToString(linha["A24_001_C"]);
                                a03Parceiros.ufEstado = Convert.ToString(linha["A23_001_C"]);
                                a03Parceiros.nomeEstado = Convert.ToString(linha["A23_002_C"]);
                                a03Parceiros.nomePais = Convert.ToString(linha["A22_001_C"]);
                                a03Parceiros.a25_ukey = Convert.ToString(linha["UKEYCEP"]);
                                a03Parceiros.cep = Convert.ToString(linha["A25_001_C"]);
                                a03Parceiros.nomeBanco = Convert.ToString(linha["A01_002_C"]);
                                a03Parceiros.nomeTipoDocumento = Convert.ToString(linha["A21_001_C"]);
                                a03Parceiros.tipoPessoa = Convert.ToInt16(linha["A03_014_N"]);
                                a03Collection.Add(a03Parceiros);
                            }
                            return a03Collection;
                        }

                        //CONDIÇÃO SE FOR DIFERENTE DE 
                        else if (opcaoFiltroCriterio == 4)
                        {
                            connA03.AdicionarParametros("@A03_003_C", valorCriterio);
                            connA03.AdicionarParametros("@A03_001_C", "");
                            connA03.AdicionarParametros("@A03_007_C", "");
                            connA03.AdicionarParametros("@A23_001_C", "");
                            DataTable dataTable = connA03.ExecutaConsulta(CommandType.Text, selectPorCodigoDiferenteDe);
                            foreach (DataRow linha in dataTable.Rows)
                            {
                                A03Parceiros a03Parceiros = new A03Parceiros();
                                a03Parceiros.ukey = Convert.ToString(linha["IDPARCEIRO"]);
                                a03Parceiros.a03_001_c = Convert.ToString(linha["A03_001_C"]);
                                a03Parceiros.a03_002_c = Convert.ToString(linha["A03_002_C"]);
                                a03Parceiros.a03_003_c = Convert.ToString(linha["A03_003_C"]);
                                a03Parceiros.a03_004_c = Convert.ToString(linha["A03_004_C"]);
                                a03Parceiros.a03_005_c = Convert.ToString(linha["A03_005_C"]);
                                a03Parceiros.a03_006_c = Convert.ToString(linha["A03_006_C"]);
                                a03Parceiros.a03_007_c = Convert.ToString(linha["A03_007_C"]);
                                a03Parceiros.a03_008_c = Convert.ToString(linha["A03_008_C"]);
                                a03Parceiros.a03_009_c = Convert.ToString(linha["A03_009_C"]);
                                a03Parceiros.a03_010_c = Convert.ToString(linha["A03_010_C"]);
                                a03Parceiros.a03_011_n = Convert.ToInt16(linha["A03_011_N"]);
                                a03Parceiros.a03_012_n = Convert.ToInt16(linha["A03_012_N"]);
                                a03Parceiros.a03_013_d = Convert.ToDateTime(linha["A03_013_D"]);
                                a03Parceiros.nomeCidade = Convert.ToString(linha["A24_001_C"]);
                                a03Parceiros.ufEstado = Convert.ToString(linha["A23_001_C"]);
                                a03Parceiros.nomeEstado = Convert.ToString(linha["A23_002_C"]);
                                a03Parceiros.nomePais = Convert.ToString(linha["A22_001_C"]);
                                a03Parceiros.a25_ukey = Convert.ToString(linha["UKEYCEP"]);
                                a03Parceiros.cep = Convert.ToString(linha["A25_001_C"]);
                                a03Parceiros.nomeBanco = Convert.ToString(linha["A01_002_C"]);
                                a03Parceiros.nomeTipoDocumento = Convert.ToString(linha["A21_001_C"]);
                                a03Parceiros.tipoPessoa = Convert.ToInt16(linha["A03_014_N"]);
                                a03Collection.Add(a03Parceiros);
                            }
                            return a03Collection;
                        }
                        return a03Collection;

                        //CASO FOR POR UF 
                    case 2:
                        //CONDIÇÃO CONTEM
                        if (opcaoFiltroCriterio == 2)
                        {
                            connA03.AdicionarParametros("@A23_001_C", "%" + valorCriterio + "%");
                            connA03.AdicionarParametros("@A03_003_C", "");
                            connA03.AdicionarParametros("@A03_007_C", "");
                            connA03.AdicionarParametros("@A03_001_C", "");
                            DataTable dataTable = connA03.ExecutaConsulta(CommandType.Text, selectPorCodigo);
                            foreach (DataRow linha in dataTable.Rows)
                            {
                                A03Parceiros a03Parceiros = new A03Parceiros();
                                a03Parceiros.ukey = Convert.ToString(linha["IDPARCEIRO"]);
                                a03Parceiros.a03_001_c = Convert.ToString(linha["A03_001_C"]);
                                a03Parceiros.a03_002_c = Convert.ToString(linha["A03_002_C"]);
                                a03Parceiros.a03_003_c = Convert.ToString(linha["A03_003_C"]);
                                a03Parceiros.a03_004_c = Convert.ToString(linha["A03_004_C"]);
                                a03Parceiros.a03_005_c = Convert.ToString(linha["A03_005_C"]);
                                a03Parceiros.a03_006_c = Convert.ToString(linha["A03_006_C"]);
                                a03Parceiros.a03_007_c = Convert.ToString(linha["A03_007_C"]);
                                a03Parceiros.a03_008_c = Convert.ToString(linha["A03_008_C"]);
                                a03Parceiros.a03_009_c = Convert.ToString(linha["A03_009_C"]);
                                a03Parceiros.a03_010_c = Convert.ToString(linha["A03_010_C"]);
                                a03Parceiros.a03_011_n = Convert.ToInt16(linha["A03_011_N"]);
                                a03Parceiros.a03_012_n = Convert.ToInt16(linha["A03_012_N"]);
                                a03Parceiros.a03_013_d = Convert.ToDateTime(linha["A03_013_D"]);
                                a03Parceiros.nomeCidade = Convert.ToString(linha["A24_001_C"]);
                                a03Parceiros.ufEstado = Convert.ToString(linha["A23_001_C"]);
                                a03Parceiros.nomeEstado = Convert.ToString(linha["A23_002_C"]);
                                a03Parceiros.nomePais = Convert.ToString(linha["A22_001_C"]);
                                a03Parceiros.a25_ukey = Convert.ToString(linha["UKEYCEP"]);
                                a03Parceiros.cep = Convert.ToString(linha["A25_001_C"]);
                                a03Parceiros.nomeBanco = Convert.ToString(linha["A01_002_C"]);
                                a03Parceiros.nomeTipoDocumento = Convert.ToString(linha["A21_001_C"]);
                                a03Parceiros.tipoPessoa = Convert.ToInt16(linha["A03_014_N"]);
                                a03Collection.Add(a03Parceiros);
                            }
                            return a03Collection;
                        }
                        //CONDIÇÃO IGUAL
                        else if (opcaoFiltroCriterio == 0)
                        {
                            connA03.AdicionarParametros("@A23_001_C", valorCriterio);
                            connA03.AdicionarParametros("@A03_003_C", "");
                            connA03.AdicionarParametros("@A03_007_C", "");
                            connA03.AdicionarParametros("@A03_001_C", "");
                            DataTable dataTable = connA03.ExecutaConsulta(CommandType.Text, selectPorCodigoIgual);
                            foreach (DataRow linha in dataTable.Rows)
                            {
                                A03Parceiros a03Parceiros = new A03Parceiros();
                                a03Parceiros.ukey = Convert.ToString(linha["IDPARCEIRO"]);
                                a03Parceiros.a03_001_c = Convert.ToString(linha["A03_001_C"]);
                                a03Parceiros.a03_002_c = Convert.ToString(linha["A03_002_C"]);
                                a03Parceiros.a03_003_c = Convert.ToString(linha["A03_003_C"]);
                                a03Parceiros.a03_004_c = Convert.ToString(linha["A03_004_C"]);
                                a03Parceiros.a03_005_c = Convert.ToString(linha["A03_005_C"]);
                                a03Parceiros.a03_006_c = Convert.ToString(linha["A03_006_C"]);
                                a03Parceiros.a03_007_c = Convert.ToString(linha["A03_007_C"]);
                                a03Parceiros.a03_008_c = Convert.ToString(linha["A03_008_C"]);
                                a03Parceiros.a03_009_c = Convert.ToString(linha["A03_009_C"]);
                                a03Parceiros.a03_010_c = Convert.ToString(linha["A03_010_C"]);
                                a03Parceiros.a03_011_n = Convert.ToInt16(linha["A03_011_N"]);
                                a03Parceiros.a03_012_n = Convert.ToInt16(linha["A03_012_N"]);
                                a03Parceiros.a03_013_d = Convert.ToDateTime(linha["A03_013_D"]);
                                a03Parceiros.nomeCidade = Convert.ToString(linha["A24_001_C"]);
                                a03Parceiros.ufEstado = Convert.ToString(linha["A23_001_C"]);
                                a03Parceiros.nomeEstado = Convert.ToString(linha["A23_002_C"]);
                                a03Parceiros.nomePais = Convert.ToString(linha["A22_001_C"]);
                                a03Parceiros.a25_ukey = Convert.ToString(linha["UKEYCEP"]);
                                a03Parceiros.cep = Convert.ToString(linha["A25_001_C"]);
                                a03Parceiros.nomeBanco = Convert.ToString(linha["A01_002_C"]);
                                a03Parceiros.nomeTipoDocumento = Convert.ToString(linha["A21_001_C"]);
                                a03Parceiros.tipoPessoa = Convert.ToInt16(linha["A03_014_N"]);
                                a03Collection.Add(a03Parceiros);
                            }
                            return a03Collection;
                        }
                        //CONDIÇÃO DIFERENTE DE
                        else if (opcaoFiltroCriterio == 1)
                        {
                            connA03.AdicionarParametros("@A23_001_C", valorCriterio);
                            connA03.AdicionarParametros("@A03_003_C", "");
                            connA03.AdicionarParametros("@A03_007_C", "");
                            connA03.AdicionarParametros("@A03_001_C", "");
                            DataTable dataTable = connA03.ExecutaConsulta(CommandType.Text, selectPorCodigoDiferenteDe);
                            foreach (DataRow linha in dataTable.Rows)
                            {
                                A03Parceiros a03Parceiros = new A03Parceiros();
                                a03Parceiros.ukey = Convert.ToString(linha["IDPARCEIRO"]);
                                a03Parceiros.a03_001_c = Convert.ToString(linha["A03_001_C"]);
                                a03Parceiros.a03_002_c = Convert.ToString(linha["A03_002_C"]);
                                a03Parceiros.a03_003_c = Convert.ToString(linha["A03_003_C"]);
                                a03Parceiros.a03_004_c = Convert.ToString(linha["A03_004_C"]);
                                a03Parceiros.a03_005_c = Convert.ToString(linha["A03_005_C"]);
                                a03Parceiros.a03_006_c = Convert.ToString(linha["A03_006_C"]);
                                a03Parceiros.a03_007_c = Convert.ToString(linha["A03_007_C"]);
                                a03Parceiros.a03_008_c = Convert.ToString(linha["A03_008_C"]);
                                a03Parceiros.a03_009_c = Convert.ToString(linha["A03_009_C"]);
                                a03Parceiros.a03_010_c = Convert.ToString(linha["A03_010_C"]);
                                a03Parceiros.a03_011_n = Convert.ToInt16(linha["A03_011_N"]);
                                a03Parceiros.a03_012_n = Convert.ToInt16(linha["A03_012_N"]);
                                a03Parceiros.a03_013_d = Convert.ToDateTime(linha["A03_013_D"]);
                                a03Parceiros.nomeCidade = Convert.ToString(linha["A24_001_C"]);
                                a03Parceiros.ufEstado = Convert.ToString(linha["A23_001_C"]);
                                a03Parceiros.nomeEstado = Convert.ToString(linha["A23_002_C"]);
                                a03Parceiros.nomePais = Convert.ToString(linha["A22_001_C"]);
                                a03Parceiros.a25_ukey = Convert.ToString(linha["UKEYCEP"]);
                                a03Parceiros.cep = Convert.ToString(linha["A25_001_C"]);
                                a03Parceiros.nomeBanco = Convert.ToString(linha["A01_002_C"]);
                                a03Parceiros.nomeTipoDocumento = Convert.ToString(linha["A21_001_C"]);
                                a03Parceiros.tipoPessoa = Convert.ToInt16(linha["A03_014_N"]);
                                a03Collection.Add(a03Parceiros);
                            }
                            return a03Collection;
                        }
                        return a03Collection;

                        //CASO FOR POR CNPJ
                    case 3:
                        connA03.LimparParametros();
                        //verifica qual query vai executar conforme o indice que vier da combobox
                        if (opcaoFiltroCriterio == 0)
                        {
                            //passa o valor ao parametro da select iniciado por
                            connA03.AdicionarParametros("@A03_007_C", valorCriterio + "%");
                            connA03.AdicionarParametros("@A03_003_C", "");
                            connA03.AdicionarParametros("@A23_001_C", "");
                            connA03.AdicionarParametros("@A03_001_C", "");
                            DataTable dataTable = connA03.ExecutaConsulta(CommandType.Text, selectPorCodigo);
                            foreach (DataRow linha in dataTable.Rows)
                            {
                                A03Parceiros a03Parceiros = new A03Parceiros();
                                a03Parceiros.ukey = Convert.ToString(linha["IDPARCEIRO"]);
                                a03Parceiros.a03_001_c = Convert.ToString(linha["A03_001_C"]);
                                a03Parceiros.a03_002_c = Convert.ToString(linha["A03_002_C"]);
                                a03Parceiros.a03_003_c = Convert.ToString(linha["A03_003_C"]);
                                a03Parceiros.a03_004_c = Convert.ToString(linha["A03_004_C"]);
                                a03Parceiros.a03_005_c = Convert.ToString(linha["A03_005_C"]);
                                a03Parceiros.a03_006_c = Convert.ToString(linha["A03_006_C"]);
                                a03Parceiros.a03_007_c = Convert.ToString(linha["A03_007_C"]);
                                a03Parceiros.a03_008_c = Convert.ToString(linha["A03_008_C"]);
                                a03Parceiros.a03_009_c = Convert.ToString(linha["A03_009_C"]);
                                a03Parceiros.a03_010_c = Convert.ToString(linha["A03_010_C"]);
                                a03Parceiros.a03_011_n = Convert.ToInt16(linha["A03_011_N"]);
                                a03Parceiros.a03_012_n = Convert.ToInt16(linha["A03_012_N"]);
                                a03Parceiros.a03_013_d = Convert.ToDateTime(linha["A03_013_D"]);
                                a03Parceiros.nomeCidade = Convert.ToString(linha["A24_001_C"]);
                                a03Parceiros.ufEstado = Convert.ToString(linha["A23_001_C"]);
                                a03Parceiros.nomeEstado = Convert.ToString(linha["A23_002_C"]);
                                a03Parceiros.nomePais = Convert.ToString(linha["A22_001_C"]);
                                a03Parceiros.a25_ukey = Convert.ToString(linha["UKEYCEP"]);
                                a03Parceiros.cep = Convert.ToString(linha["A25_001_C"]);
                                a03Parceiros.nomeBanco = Convert.ToString(linha["A01_002_C"]);
                                a03Parceiros.nomeTipoDocumento = Convert.ToString(linha["A21_001_C"]);
                                a03Parceiros.tipoPessoa = Convert.ToInt16(linha["A03_014_N"]);
                                a03Collection.Add(a03Parceiros);
                            }
                            return a03Collection;
                        }
                        else if (opcaoFiltroCriterio == 1)
                        {
                            //passa o valor ao parametro da select contem
                            connA03.AdicionarParametros("@A03_007_C", "%" + valorCriterio + "%");
                            connA03.AdicionarParametros("@A03_003_C", "");
                            connA03.AdicionarParametros("@A23_001_C", "");
                            connA03.AdicionarParametros("@A03_001_C", "");
                            DataTable dataTable = connA03.ExecutaConsulta(CommandType.Text, selectPorCodigo);
                            foreach (DataRow linha in dataTable.Rows)
                            {
                                A03Parceiros a03Parceiros = new A03Parceiros();
                                a03Parceiros.ukey = Convert.ToString(linha["IDPARCEIRO"]);
                                a03Parceiros.a03_001_c = Convert.ToString(linha["A03_001_C"]);
                                a03Parceiros.a03_002_c = Convert.ToString(linha["A03_002_C"]);
                                a03Parceiros.a03_003_c = Convert.ToString(linha["A03_003_C"]);
                                a03Parceiros.a03_004_c = Convert.ToString(linha["A03_004_C"]);
                                a03Parceiros.a03_005_c = Convert.ToString(linha["A03_005_C"]);
                                a03Parceiros.a03_006_c = Convert.ToString(linha["A03_006_C"]);
                                a03Parceiros.a03_007_c = Convert.ToString(linha["A03_007_C"]);
                                a03Parceiros.a03_008_c = Convert.ToString(linha["A03_008_C"]);
                                a03Parceiros.a03_009_c = Convert.ToString(linha["A03_009_C"]);
                                a03Parceiros.a03_010_c = Convert.ToString(linha["A03_010_C"]);
                                a03Parceiros.a03_011_n = Convert.ToInt16(linha["A03_011_N"]);
                                a03Parceiros.a03_012_n = Convert.ToInt16(linha["A03_012_N"]);
                                a03Parceiros.a03_013_d = Convert.ToDateTime(linha["A03_013_D"]);
                                a03Parceiros.nomeCidade = Convert.ToString(linha["A24_001_C"]);
                                a03Parceiros.ufEstado = Convert.ToString(linha["A23_001_C"]);
                                a03Parceiros.nomeEstado = Convert.ToString(linha["A23_002_C"]);
                                a03Parceiros.nomePais = Convert.ToString(linha["A22_001_C"]);
                                a03Parceiros.a25_ukey = Convert.ToString(linha["UKEYCEP"]);
                                a03Parceiros.cep = Convert.ToString(linha["A25_001_C"]);
                                a03Parceiros.nomeBanco = Convert.ToString(linha["A01_002_C"]);
                                a03Parceiros.nomeTipoDocumento = Convert.ToString(linha["A21_001_C"]);
                                a03Parceiros.tipoPessoa = Convert.ToInt16(linha["A03_014_N"]);
                                a03Collection.Add(a03Parceiros);
                            }
                            return a03Collection;

                            // condição se for igual
                        }
                        else if (opcaoFiltroCriterio == 2)
                        {
                            connA03.AdicionarParametros("@A03_007_C", valorCriterio);
                            connA03.AdicionarParametros("@A03_003_C", "");
                            connA03.AdicionarParametros("@A23_001_C", "");
                            connA03.AdicionarParametros("@A03_001_C", "");
                            DataTable dataTable = connA03.ExecutaConsulta(CommandType.Text, selectPorCodigoIgual);
                            foreach (DataRow linha in dataTable.Rows)
                            {
                                A03Parceiros a03Parceiros = new A03Parceiros();
                                a03Parceiros.ukey = Convert.ToString(linha["IDPARCEIRO"]);
                                a03Parceiros.a03_001_c = Convert.ToString(linha["A03_001_C"]);
                                a03Parceiros.a03_002_c = Convert.ToString(linha["A03_002_C"]);
                                a03Parceiros.a03_003_c = Convert.ToString(linha["A03_003_C"]);
                                a03Parceiros.a03_004_c = Convert.ToString(linha["A03_004_C"]);
                                a03Parceiros.a03_005_c = Convert.ToString(linha["A03_005_C"]);
                                a03Parceiros.a03_006_c = Convert.ToString(linha["A03_006_C"]);
                                a03Parceiros.a03_007_c = Convert.ToString(linha["A03_007_C"]);
                                a03Parceiros.a03_008_c = Convert.ToString(linha["A03_008_C"]);
                                a03Parceiros.a03_009_c = Convert.ToString(linha["A03_009_C"]);
                                a03Parceiros.a03_010_c = Convert.ToString(linha["A03_010_C"]);
                                a03Parceiros.a03_011_n = Convert.ToInt16(linha["A03_011_N"]);
                                a03Parceiros.a03_012_n = Convert.ToInt16(linha["A03_012_N"]);
                                a03Parceiros.a03_013_d = Convert.ToDateTime(linha["A03_013_D"]);
                                a03Parceiros.nomeCidade = Convert.ToString(linha["A24_001_C"]);
                                a03Parceiros.ufEstado = Convert.ToString(linha["A23_001_C"]);
                                a03Parceiros.nomeEstado = Convert.ToString(linha["A23_002_C"]);
                                a03Parceiros.nomePais = Convert.ToString(linha["A22_001_C"]);
                                a03Parceiros.a25_ukey = Convert.ToString(linha["UKEYCEP"]);
                                a03Parceiros.cep = Convert.ToString(linha["A25_001_C"]);
                                a03Parceiros.nomeBanco = Convert.ToString(linha["A01_002_C"]);
                                a03Parceiros.nomeTipoDocumento = Convert.ToString(linha["A21_001_C"]);
                                a03Parceiros.tipoPessoa = Convert.ToInt16(linha["A03_014_N"]);
                                a03Collection.Add(a03Parceiros);
                            }
                            return a03Collection;
                        }
                        //condição se for terminado por
                        else if (opcaoFiltroCriterio == 3)
                        {
                            connA03.AdicionarParametros("@A03_007_C", "%" + valorCriterio);
                            connA03.AdicionarParametros("@A03_003_C", "");
                            connA03.AdicionarParametros("@A23_001_C", "");
                            connA03.AdicionarParametros("@A03_001_C", "");
                            DataTable dataTable = connA03.ExecutaConsulta(CommandType.Text, selectPorCodigo);
                            foreach (DataRow linha in dataTable.Rows)
                            {
                                A03Parceiros a03Parceiros = new A03Parceiros();
                                a03Parceiros.ukey = Convert.ToString(linha["IDPARCEIRO"]);
                                a03Parceiros.a03_001_c = Convert.ToString(linha["A03_001_C"]);
                                a03Parceiros.a03_002_c = Convert.ToString(linha["A03_002_C"]);
                                a03Parceiros.a03_003_c = Convert.ToString(linha["A03_003_C"]);
                                a03Parceiros.a03_004_c = Convert.ToString(linha["A03_004_C"]);
                                a03Parceiros.a03_005_c = Convert.ToString(linha["A03_005_C"]);
                                a03Parceiros.a03_006_c = Convert.ToString(linha["A03_006_C"]);
                                a03Parceiros.a03_007_c = Convert.ToString(linha["A03_007_C"]);
                                a03Parceiros.a03_008_c = Convert.ToString(linha["A03_008_C"]);
                                a03Parceiros.a03_009_c = Convert.ToString(linha["A03_009_C"]);
                                a03Parceiros.a03_010_c = Convert.ToString(linha["A03_010_C"]);
                                a03Parceiros.a03_011_n = Convert.ToInt16(linha["A03_011_N"]);
                                a03Parceiros.a03_012_n = Convert.ToInt16(linha["A03_012_N"]);
                                a03Parceiros.a03_013_d = Convert.ToDateTime(linha["A03_013_D"]);
                                a03Parceiros.nomeCidade = Convert.ToString(linha["A24_001_C"]);
                                a03Parceiros.ufEstado = Convert.ToString(linha["A23_001_C"]);
                                a03Parceiros.nomeEstado = Convert.ToString(linha["A23_002_C"]);
                                a03Parceiros.nomePais = Convert.ToString(linha["A22_001_C"]);
                                a03Parceiros.a25_ukey = Convert.ToString(linha["UKEYCEP"]);
                                a03Parceiros.cep = Convert.ToString(linha["A25_001_C"]);
                                a03Parceiros.nomeBanco = Convert.ToString(linha["A01_002_C"]);
                                a03Parceiros.nomeTipoDocumento = Convert.ToString(linha["A21_001_C"]);
                                a03Parceiros.tipoPessoa = Convert.ToInt16(linha["A03_014_N"]);
                                a03Collection.Add(a03Parceiros);
                            }
                            return a03Collection;
                        }

                        //condioção se for diferente de
                        else if (opcaoFiltroCriterio == 4)
                        {
                            connA03.AdicionarParametros("@A03_007_C", valorCriterio);
                            connA03.AdicionarParametros("@A03_003_C", "");
                            connA03.AdicionarParametros("@A23_001_C", "");
                            connA03.AdicionarParametros("@A03_001_C", "");
                            DataTable dataTable = connA03.ExecutaConsulta(CommandType.Text, selectPorCodigoDiferenteDe);
                            foreach (DataRow linha in dataTable.Rows)
                            {
                                A03Parceiros a03Parceiros = new A03Parceiros();
                                a03Parceiros.ukey = Convert.ToString(linha["IDPARCEIRO"]);
                                a03Parceiros.a03_001_c = Convert.ToString(linha["A03_001_C"]);
                                a03Parceiros.a03_002_c = Convert.ToString(linha["A03_002_C"]);
                                a03Parceiros.a03_003_c = Convert.ToString(linha["A03_003_C"]);
                                a03Parceiros.a03_004_c = Convert.ToString(linha["A03_004_C"]);
                                a03Parceiros.a03_005_c = Convert.ToString(linha["A03_005_C"]);
                                a03Parceiros.a03_006_c = Convert.ToString(linha["A03_006_C"]);
                                a03Parceiros.a03_007_c = Convert.ToString(linha["A03_007_C"]);
                                a03Parceiros.a03_008_c = Convert.ToString(linha["A03_008_C"]);
                                a03Parceiros.a03_009_c = Convert.ToString(linha["A03_009_C"]);
                                a03Parceiros.a03_010_c = Convert.ToString(linha["A03_010_C"]);
                                a03Parceiros.a03_011_n = Convert.ToInt16(linha["A03_011_N"]);
                                a03Parceiros.a03_012_n = Convert.ToInt16(linha["A03_012_N"]);
                                a03Parceiros.a03_013_d = Convert.ToDateTime(linha["A03_013_D"]);
                                a03Parceiros.nomeCidade = Convert.ToString(linha["A24_001_C"]);
                                a03Parceiros.ufEstado = Convert.ToString(linha["A23_001_C"]);
                                a03Parceiros.nomeEstado = Convert.ToString(linha["A23_002_C"]);
                                a03Parceiros.nomePais = Convert.ToString(linha["A22_001_C"]);
                                a03Parceiros.a25_ukey = Convert.ToString(linha["UKEYCEP"]);
                                a03Parceiros.cep = Convert.ToString(linha["A25_001_C"]);
                                a03Parceiros.nomeBanco = Convert.ToString(linha["A01_002_C"]);
                                a03Parceiros.nomeTipoDocumento = Convert.ToString(linha["A21_001_C"]);
                                a03Parceiros.tipoPessoa = Convert.ToInt16(linha["A03_014_N"]);
                                a03Collection.Add(a03Parceiros);
                            }
                            return a03Collection;
                        }
                        return a03Collection;
                    
                }
                return a03Collection;
            }
            catch (Exception ex)
            {
                throw new Exception("Nenhum Cliente Encontrado" + ex.Message);
            }
        }
        //metodo para carregar combobox de banco
       
    }
}
