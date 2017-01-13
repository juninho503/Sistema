using AcessaBancoDados;
using ObjetoTransferencia;
using System;
using System.Data;

namespace Negocios
{
    public class D04ProdutoNegocio
    {
        AcessaBanco connD04 = new AcessaBanco();

        //QUERYS PARA MANIPULAÇAO NO BANCO

        //INSERT
        private string insert = "INSERT INTO D04 (D04_001_C,D04_002_C,D04_003_C,D04_004_N,D04_005_N,D04_006_C,D04_007_N,D04_008_N,D03_UKEY) VALUES (@D04_001_C,@D04_002_C,"
            + " @D04_003_C,@D04_004_N,@D04_005_N,@D04_006_C,@D04_007_N,@D04_008_N,@D03_UKEY)";

        //UPDATE
        private string update = "UPDATE D04 SET D04_001_C = @D04_001_C, D04_002_C = @D04_002_C, D04_003_C = @D04_003_C, D04_004_N = @D04_004_N, D04_005_N = @D04_005_N,"
             + " D04_006_C = @D04_006_C, D04_007_N = @D04_007_N, D04_008_N = @D04_008_N, D03_UKEY = @D03_UKEY WHERE UKEY  = @UKEY";

        //DELETE
        private string delete = "DELETE FROM D04 WHERE UKEY = @UKEY";

        //SELECT LIKE EM TODOS CAMPOS
        private string selectLike = "SELECT D04.UKEY AS IDPRODUTO, D03.UKEY AS UKEYFAMILIA, * FROM D04"
            + " LEFT JOIN D03 ON D04.D03_UKEY = D03.UKEY"
            + " WHERE D04_002_C LIKE @D04_002_C OR D04_001_C LIKE @D04_001_C";

        //SELECT IGUAL EM TODOS CAMPOS
        private string selectIgual = "SELECT D04.UKEY AS IDPRODUTO, D03.UKEY AS UKEYFAMILIA, * FROM D04"
            + " LEFT JOIN D03 ON D04.D03_UKEY = D03.UKEY"
            + " WHERE D04_002_C = @D04_002_C OR D04_001_C = @D04_001_C";

        //SELECT DIFERENTE TODOS CAMPOS
        private string selectDiferente = "SELECT D04.UKEY AS IDPRODUTO, D03.UKEY AS UKEYFAMILIA, * FROM D04"
            + " LEFT JOIN D03 ON D04.D03_UKEY = D03.UKEY"
            + " WHERE D04_002_C <> @D04_002_C OR D04_001_C <> @D04_001_C";

        /// <summary>
        /// Metodo de inserção no banco de dados
        /// </summary>
        /// <param name="d04Produto"></param>
        public void Inserir(D04Produto d04Produto)
        {
            //limpa parametros asa tenha algum
            connD04.LimparParametros();

            //adicionar parametsoa para inserção
            connD04.AdicionarParametros("@D04_001_C", d04Produto.d04_001_c);
            connD04.AdicionarParametros("@D04_002_C", d04Produto.d04_002_c);
            connD04.AdicionarParametros("@D04_003_C", d04Produto.d04_003_c);
            connD04.AdicionarParametros("@D04_004_N", d04Produto.d04_004_n);
            connD04.AdicionarParametros("@D04_005_N", d04Produto.d04_005_n);
            connD04.AdicionarParametros("@D04_006_C", d04Produto.d04_006_c);
            connD04.AdicionarParametros("@D04_007_N", d04Produto.d04_007_n);
            connD04.AdicionarParametros("@D04_008_N", d04Produto.d04_008_n);
            if (d04Produto.d03_ukey == null)
            {
                connD04.AdicionarParametros("@D03_UKEY", DBNull.Value);
            } else
            {
                connD04.AdicionarParametros("@D03_UKEY", d04Produto.d03_ukey);
            }
            

            //chama o metodo de executar comando
            connD04.ExecutaManipulacao(CommandType.Text, insert);

        }
        /// <summary>
        /// Metodo de Pesquis de Produto
        /// </summary>
        /// <param name="opcaoCriterio"></param>
        /// <param name="opcaoFiltro"></param>
        /// <param name="parametro"></param>
        /// <returns></returns>
        public D04ProdutoCollection Pesquisa(int opcaoCriterio, int opcaoFiltro, string Parametro)
        {
            //criando objeto coleção do produto que sera retornado 
            D04ProdutoCollection d04ProdutoCollection = new D04ProdutoCollection();
            DataTable dataTable = null;
            connD04.LimparParametros();
            try
            {
                //verifica a opçao do criterio se é por produto ou por familia 0 por produto 1 por familia
                //**
                //se for zero entra na busca por produto
                switch (opcaoCriterio)
                {
                    //ENTRA NA BUSCA POR DESCRIÇÃO
                    case 0:
                        //INICIADO POR
                        if (opcaoFiltro == 0)
                        {
                            connD04.AdicionarParametros("@D04_002_C", Parametro + "%");
                            connD04.AdicionarParametros("@D04_001_C", "");
                        }
                        //CONTEM
                        else if (opcaoFiltro == 1)
                        {
                            connD04.AdicionarParametros("@D04_002_C", "%" + Parametro + "%");
                            connD04.AdicionarParametros("@D04_001_C", "");
                        }
                        //IGUAL
                        else if (opcaoFiltro == 2)
                        {
                            connD04.AdicionarParametros("@D04_002_C", Parametro);
                            connD04.AdicionarParametros("@D04_001_C", "");
                        }
                        //TERMINADO
                        else if (opcaoFiltro == 3)
                        {
                            connD04.AdicionarParametros("@D04_002_C", "%" + Parametro);
                            connD04.AdicionarParametros("@D04_001_C", "");
                        }
                        //DIFERENTE
                        else if (opcaoFiltro == 4)
                        {
                            connD04.AdicionarParametros("@D04_002_C", Parametro);
                            connD04.AdicionarParametros("@D04_001_C", "");
                        }

                        //VERIFICO QUAL SELECT DEVE SER EXECUTADA DEPOIS DE PREENCHER OS PARAMETROS
                        if (opcaoFiltro == 0 || opcaoFiltro == 1 || opcaoFiltro == 3)
                        {
                            dataTable = connD04.ExecutaConsulta(CommandType.Text, selectLike);
                        }
                        else if (opcaoFiltro == 2)
                        {
                            dataTable = connD04.ExecutaConsulta(CommandType.Text, selectIgual);
                        }
                        else if (opcaoFiltro == 4)
                        {
                            dataTable = connD04.ExecutaConsulta(CommandType.Text, selectDiferente);
                        }
                        foreach (DataRow linha in dataTable.Rows)
                        {
                            D04Produto d04Produto = new D04Produto();
                            d04Produto.ukey = Convert.ToString(linha["IDPRODUTO"]);
                            d04Produto.d04_001_c = Convert.ToString(linha["D04_001_C"]);
                            d04Produto.d04_002_c = Convert.ToString(linha["D04_002_C"]);
                            d04Produto.d04_003_c = Convert.ToString(linha["D04_003_C"]);
                            d04Produto.d04_004_n = Convert.ToDouble(linha["D04_004_N"]);
                            d04Produto.d04_005_n = Convert.ToDouble(linha["D04_005_N"]);
                            d04Produto.d04_006_c = Convert.ToString(linha["D04_006_C"]);
                            d04Produto.d04_007_n = Convert.ToDouble(linha["D04_007_N"]);
                            d04Produto.d04_008_n = Convert.ToDouble(linha["d04_008_N"]);
                            d04Produto.d03_ukey = Convert.ToString(linha["UKEYFAMILIA"]);
                            d04Produto.nomeFamilia = Convert.ToString(linha["D03_002_C"]);
                            d04Produto.codigoFamilia = Convert.ToString(linha["D03_001_c"]);
                            d04ProdutoCollection.Add(d04Produto);

                        }
                        return d04ProdutoCollection;

                    //CASE POR CODIGO 
                    case 1:


                        //INICIADO POR
                        if (opcaoFiltro == 0)
                        {
                            connD04.AdicionarParametros("@D04_002_C", "");
                            connD04.AdicionarParametros("@D04_001_C", Parametro + "%");
                        }
                        //CONTEM
                        else if (opcaoFiltro == 1)
                        {
                            connD04.AdicionarParametros("@D04_002_C", "");
                            connD04.AdicionarParametros("@D04_001_C", "%" + Parametro + "%");
                        }
                        //IGUAL
                        else if (opcaoFiltro == 2)
                        {
                            connD04.AdicionarParametros("@D04_002_C", "");
                            connD04.AdicionarParametros("@D04_001_C", Parametro);
                        }
                        //TERMINADO
                        else if (opcaoFiltro == 3)
                        {
                            connD04.AdicionarParametros("@D04_002_C", "");
                            connD04.AdicionarParametros("@D04_001_C", "%" + Parametro);
                        }
                        //DIFERENTE
                        else if (opcaoFiltro == 4)
                        {
                            connD04.AdicionarParametros("@D04_002_C", "");
                            connD04.AdicionarParametros("@D04_001_C", Parametro);
                        }

                        //VERIFICO QUAL SELECT DEVE SER EXECUTADA DEPOIS DE PREENCHER OS PARAMETROS
                        if (opcaoFiltro == 0 || opcaoFiltro == 1 || opcaoFiltro == 3)
                        {
                            dataTable = connD04.ExecutaConsulta(CommandType.Text, selectLike);
                        }
                        else if (opcaoFiltro == 2)
                        {
                            dataTable = connD04.ExecutaConsulta(CommandType.Text, selectIgual);
                        }
                        else if (opcaoFiltro == 4)
                        {
                            dataTable = connD04.ExecutaConsulta(CommandType.Text, selectDiferente);
                        }
                        foreach (DataRow linha in dataTable.Rows)
                        {
                            D04Produto d04Produto = new D04Produto();
                            d04Produto.ukey = Convert.ToString(linha["IDPRODUTO"]);
                            d04Produto.d04_001_c = Convert.ToString(linha["D04_001_C"]);
                            d04Produto.d04_002_c = Convert.ToString(linha["D04_002_C"]);
                            d04Produto.d04_003_c = Convert.ToString(linha["D04_003_C"]);
                            d04Produto.d04_004_n = Convert.ToDouble(linha["D04_004_N"]);
                            d04Produto.d04_005_n = Convert.ToDouble(linha["D04_005_N"]);
                            d04Produto.d04_006_c = Convert.ToString(linha["D04_006_C"]);
                            d04Produto.d04_007_n = Convert.ToDouble(linha["D04_007_N"]);
                            d04Produto.d04_008_n = Convert.ToDouble(linha["d04_008_N"]);
                            d04Produto.d03_ukey = Convert.ToString(linha["UKEYFAMILIA"]);
                            d04Produto.nomeFamilia = Convert.ToString(linha["D03_002_C"]);
                            d04Produto.codigoFamilia = Convert.ToString(linha["D03_001_c"]);
                            d04ProdutoCollection.Add(d04Produto);

                        }
                        return d04ProdutoCollection;
                }
                return d04ProdutoCollection;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Metodo de Alterar o Registro no banco de Dados
        /// </summary>
        /// <param name="d04Produto"></param>
        public void Alterar(D04Produto d04Produto)
        {
            //limpa parametros asa tenha algum
            connD04.LimparParametros();

            //adicionar parametsoa para inserção
            connD04.AdicionarParametros("@D04_001_C", d04Produto.d04_001_c);
            connD04.AdicionarParametros("@D04_002_C", d04Produto.d04_002_c);
            connD04.AdicionarParametros("@D04_003_C", d04Produto.d04_003_c);
            connD04.AdicionarParametros("@D04_004_N", d04Produto.d04_004_n);
            connD04.AdicionarParametros("@D04_005_N", d04Produto.d04_005_n);
            connD04.AdicionarParametros("@D04_006_C", d04Produto.d04_006_c);
            connD04.AdicionarParametros("@D04_007_N", d04Produto.d04_007_n);
            connD04.AdicionarParametros("@D04_008_N", d04Produto.d04_008_n);
            if (d04Produto.d03_ukey == null)
            {
                connD04.AdicionarParametros("@D03_UKEY", DBNull.Value);
            }
            else
            {
                connD04.AdicionarParametros("@D03_UKEY", d04Produto.d03_ukey);
            }
            connD04.AdicionarParametros("UKEY", d04Produto.ukey);

            //chama o metodo de executar comando
            connD04.ExecutaManipulacao(CommandType.Text, update);
        }

        public void Excluir(D04Produto d04Produto)
        {
            connD04.LimparParametros();
            connD04.AdicionarParametros("@UKEY", d04Produto.ukey);
            connD04.ExecutaManipulacao(CommandType.Text, delete);
        }
    }
}