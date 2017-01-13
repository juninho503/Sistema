using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjetoTransferencia;
using AcessaBancoDados;
using System.Data;

namespace Negocios
{
   public class D07LocalNegocio
    {
        AcessaBanco connD07 = new AcessaBanco();

        //query pra inserção no banco de dados
        private string insert = "INSERT INTO D07(D07_001_C,D07_002_C) VALUES (@D07_001_C, @D07_002_C)";

        //query pra alterar no banco de dados
        private string update = "UPDATE D07 SET D07_001_C = @D07_001_C, D07_002_C = @D07_002_C WHERE UKEY = @UKEY";

        //query para excluir no banco de dados
        private string delete = "DELETE FROM D07 WHERE UKEY = @UKEY";

        //query like
        private string selectLike = "SELECT D07.UKEY AS UKEYLOCAL, * FROM D07 WHERE D07_001_C LIKE @D07_001_C OR D07_002_C LIKE @D07_002_C";

        //quere igual
        private string selectIgual = "SELECT D07.UKEY AS UKEYLOCAL, * FROM D07 WHERE D07_001_C = @D07_001_C OR D07_002_C = @D07_002_C";

        //query diferente por codigo
        private string selectDiferenteCodigo = "SELECT D07.UKEY AS UKEYLOCAL, * FROM D07 WHERE D07_001_C <> @D07_001_C";

        //QUERY DIFERENTE POR DESCRIÇÃO
        private string selectDiferenteDescricao = "SELECT D07.UKEY AS UKEYLOCAL, * FROM D07 WHERE D07_002_C <> @D07_002_C";
        /// <summary>
        /// Metodo de inserção no banco de dados
        /// </summary>
        /// <param name="d07Local"></param>
        public void Inserir(D07LocalEstoque d07Local)
        {
            connD07.LimparParametros();
            connD07.AdicionarParametros("@D07_001_C", d07Local.d07_001_c);
            connD07.AdicionarParametros("@D07_002_C", d07Local.d07_002_c);
            connD07.ExecutaManipulacao(CommandType.Text, insert);
        }
        /// <summary>
        /// Metodo de PEsquisa local de estoque
        /// </summary>
        /// <param name="opcaoBusca"></param>
        /// <param name="opcaoFiltro"></param>
        /// <param name="parametro"></param>
        /// <returns></returns>
        public D07Collection Pesquisa(int opcaoBusca, int opcaoFiltro, string parametro)
        {
            D07Collection d07Collection = new D07Collection();

            DataTable dataTable = null;

            switch (opcaoBusca)
            {
                //caso 0 entra na pesquisa por descrição
                case 0:
                    //se for 0 iniciado por
                    if (opcaoFiltro == 0)
                    {
                        connD07.LimparParametros();
                        connD07.AdicionarParametros("@D07_002_C", parametro + "%");
                        connD07.AdicionarParametros("@D07_001_C", "");
                        dataTable = connD07.ExecutaConsulta(CommandType.Text, selectLike);
                    }
                    else if (opcaoFiltro == 1)
                    {
                        connD07.LimparParametros();
                        connD07.AdicionarParametros("@D07_002_C", "%" + parametro + "%");
                        connD07.AdicionarParametros("@D07_001_C", "");
                        dataTable = connD07.ExecutaConsulta(CommandType.Text, selectLike);
                    }
                    else if (opcaoFiltro == 2)
                    {
                        connD07.LimparParametros();
                        connD07.AdicionarParametros("@D07_002_C", parametro);
                        connD07.AdicionarParametros("@D07_001_C", "");
                        dataTable = connD07.ExecutaConsulta(CommandType.Text, selectIgual);
                    }
                    else if (opcaoFiltro == 3)
                    {
                        connD07.LimparParametros();
                        connD07.AdicionarParametros("@D07_002_C", "%" + parametro);
                        connD07.AdicionarParametros("@D07_001_C", "");
                        dataTable = connD07.ExecutaConsulta(CommandType.Text, selectLike);
                    }
                    else if (opcaoFiltro == 4)
                    {
                        connD07.LimparParametros();
                        connD07.AdicionarParametros("@D07_002_C", parametro);
                        //connD07.AdicionarParametros("@D07_001_C", "");
                        dataTable = connD07.ExecutaConsulta(CommandType.Text, selectDiferenteDescricao);
                    }
                    break;
                //se for 1 pesquisa por codigo                      
                case 1:

                    if (opcaoFiltro == 0)
                    {
                        connD07.LimparParametros();
                        connD07.AdicionarParametros("@D07_002_C", "");
                        connD07.AdicionarParametros("@D07_001_C", parametro + "%");
                        dataTable = connD07.ExecutaConsulta(CommandType.Text, selectLike);
                    }
                    else if (opcaoFiltro == 1)
                    {
                        connD07.LimparParametros();
                        connD07.AdicionarParametros("@D07_002_C", "");
                        connD07.AdicionarParametros("@D07_001_C", "%" + parametro + "%");
                        dataTable = connD07.ExecutaConsulta(CommandType.Text, selectLike);
                    }
                    else if (opcaoFiltro == 2)
                    {
                        connD07.LimparParametros();
                        connD07.AdicionarParametros("@D07_002_C", "");
                        connD07.AdicionarParametros("@D07_001_C", parametro);
                        dataTable = connD07.ExecutaConsulta(CommandType.Text, selectIgual);
                    }
                    else if (opcaoFiltro == 3)
                    {
                        connD07.LimparParametros();
                        connD07.AdicionarParametros("@D07_002_C", "");
                        connD07.AdicionarParametros("@D07_001_C", "%" + parametro);
                        dataTable = connD07.ExecutaConsulta(CommandType.Text, selectLike);
                    }
                    else if (opcaoFiltro == 4)
                    {
                        connD07.LimparParametros();
                        //connD07.AdicionarParametros("@D07_002_C", "");
                        connD07.AdicionarParametros("@D07_001_C", parametro);
                        dataTable = connD07.ExecutaConsulta(CommandType.Text, selectDiferenteCodigo);
                    }
                    break;

            }

            foreach (DataRow linha in dataTable.Rows)
            {
                D07LocalEstoque d07Local = new D07LocalEstoque();
                d07Local.ukey = Convert.ToString(linha["UKEYLOCAL"]);
                d07Local.d07_001_c = Convert.ToString(linha["D07_001_C"]);
                d07Local.d07_002_c = Convert.ToString(linha["D07_002_C"]);
                d07Collection.Add(d07Local);
            }
            return d07Collection;
        }
        /// <summary>
        /// Metodo de Alteração no banco de dados!
        /// </summary>
        /// <param name="d07Local"></param>
        public void Alterar(D07LocalEstoque d07Local)
        {
            connD07.LimparParametros();
            connD07.AdicionarParametros("@D07_001_C", d07Local.d07_001_c);
            connD07.AdicionarParametros("@D07_002_C", d07Local.d07_002_c);
            connD07.AdicionarParametros("@UKEY", d07Local.ukey);
            connD07.ExecutaManipulacao(CommandType.Text, update);
        }
        /// <summary>
        /// Metodo de Exclusao no banco de dados!
        /// </summary>
        /// <param name="d07Local"></param>
        public void Excluir (D07LocalEstoque d07Local)
        {
            connD07.LimparParametros();
            connD07.AdicionarParametros("@UKEY", d07Local.ukey);
            connD07.ExecutaManipulacao(CommandType.Text, delete);
        }
    }
}
