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
  public class A01BancoNegocio
    {
        AcessaBanco connA01 = new AcessaBanco();

        //query pra inserção no banco de dados
        private string insert = "INSERT INTO A01(A01_001_C,A01_002_C) VALUES (@A01_001_C, @A01_002_C)";

        //query pra alterar no banco de dados
        private string update = "UPDATE A01 SET A01_001_C = @A01_001_C, A01_002_C = @A01_002_C WHERE UKEY = @UKEY";

        //query para excluir no banco de dados
        private string delete = "DELETE FROM A01 WHERE UKEY = @UKEY";

        //query like
        private string selectLike = "SELECT A01.UKEY AS UKEYBANCO, * FROM A01 WHERE A01_001_C LIKE @A01_001_C OR A01_002_C LIKE @A01_002_C";

        //quere igual
        private string selectIgual = "SELECT A01.UKEY AS UKEYBANCO, * FROM A01 WHERE A01_001_C = @A01_001_C OR A01_002_C = @A01_002_C";

        //query diferente por codigo
        private string selectDiferenteCodigo = "SELECT A01.UKEY AS UKEYBANCO, * FROM A01 WHERE A01_001_C <> @A01_001_C";

        //QUERY DIFERENTE POR DESCRIÇÃO
        private string selectDiferenteDescricao = "SELECT A01.UKEY AS UKEYBANCO, * FROM A01 WHERE A01_002_C <> @A01_002_C";
        /// <summary>
        /// Metodo de inserção no banco de dados
        /// </summary>
        /// <param name="a01Banco"></param>
        public void Inserir(A01Banco a01Banco)
        {
            connA01.LimparParametros();
            connA01.AdicionarParametros("@a01_001_c", a01Banco.a01_001_c);
            connA01.AdicionarParametros("@A01_002_C", a01Banco.a01_002_c);
            connA01.ExecutaManipulacao(CommandType.Text, insert);
        }
        /// <summary>
        /// Metodo de PEsquisa banco
        /// </summary>
        /// <param name="opcaoBusca"></param>
        /// <param name="opcaoFiltro"></param>
        /// <param name="parametro"></param>
        /// <returns></returns>
        public A01Collection Pesquisa(int opcaoBusca, int opcaoFiltro, string parametro)
        {
            A01Collection a01Collection = new A01Collection();

            DataTable dataTable = null;

            switch (opcaoBusca)
            {
                //caso 0 entra na pesquisa por descrição
                case 0:
                    //se for 0 iniciado por
                    if (opcaoFiltro == 0)
                    {
                        connA01.LimparParametros();
                        connA01.AdicionarParametros("@A01_002_C", parametro + "%");
                        connA01.AdicionarParametros("@A01_001_C", "");
                        dataTable = connA01.ExecutaConsulta(CommandType.Text, selectLike);
                    }
                    else if (opcaoFiltro == 1)
                    {
                        connA01.LimparParametros();
                        connA01.AdicionarParametros("@A01_002_C", "%" + parametro + "%");
                        connA01.AdicionarParametros("@A01_001_C", "");
                        dataTable = connA01.ExecutaConsulta(CommandType.Text, selectLike);
                    }
                    else if (opcaoFiltro == 2)
                    {
                        connA01.LimparParametros();
                        connA01.AdicionarParametros("@A01_002_C", parametro);
                        connA01.AdicionarParametros("@A01_001_C", "");
                        dataTable = connA01.ExecutaConsulta(CommandType.Text, selectIgual);
                    }
                    else if (opcaoFiltro == 3)
                    {
                        connA01.LimparParametros();
                        connA01.AdicionarParametros("@A01_002_C", "%" + parametro);
                        connA01.AdicionarParametros("@A01_001_C", "");
                        dataTable = connA01.ExecutaConsulta(CommandType.Text, selectLike);
                    }
                    else if (opcaoFiltro == 4)
                    {
                        connA01.LimparParametros();
                        connA01.AdicionarParametros("@A01_002_C", parametro);
                        //connA01.AdicionarParametros("@A01_001_C", "");
                        dataTable = connA01.ExecutaConsulta(CommandType.Text, selectDiferenteDescricao);
                    }
                    break;
                //se for 1 pesquisa por codigo                      
                case 1:

                    if (opcaoFiltro == 0)
                    {
                        connA01.LimparParametros();
                        connA01.AdicionarParametros("@A01_002_C", "");
                        connA01.AdicionarParametros("@A01_001_C", parametro + "%");
                        dataTable = connA01.ExecutaConsulta(CommandType.Text, selectLike);
                    }
                    else if (opcaoFiltro == 1)
                    {
                        connA01.LimparParametros();
                        connA01.AdicionarParametros("@A01_002_C", "");
                        connA01.AdicionarParametros("@A01_001_C", "%" + parametro + "%");
                        dataTable = connA01.ExecutaConsulta(CommandType.Text, selectLike);
                    }
                    else if (opcaoFiltro == 2)
                    {
                        connA01.LimparParametros();
                        connA01.AdicionarParametros("@A01_002_C", "");
                        connA01.AdicionarParametros("@A01_001_C", parametro);
                        dataTable = connA01.ExecutaConsulta(CommandType.Text, selectIgual);
                    }
                    else if (opcaoFiltro == 3)
                    {
                        connA01.LimparParametros();
                        connA01.AdicionarParametros("@A01_002_C", "");
                        connA01.AdicionarParametros("@A01_001_C", "%" + parametro);
                        dataTable = connA01.ExecutaConsulta(CommandType.Text, selectLike);
                    }
                    else if (opcaoFiltro == 4)
                    {
                        connA01.LimparParametros();
                        //connA01.AdicionarParametros("@A01_002_C", "");
                        connA01.AdicionarParametros("@A01_001_C", parametro);
                        dataTable = connA01.ExecutaConsulta(CommandType.Text, selectDiferenteCodigo);
                    }
                    break;

            }

            foreach (DataRow linha in dataTable.Rows)
            {
                A01Banco a01Banco = new A01Banco();
                a01Banco.ukey = Convert.ToString(linha["UKEYBANCO"]);
                a01Banco.a01_001_c = Convert.ToString(linha["A01_001_C"]);
                a01Banco.a01_002_c = Convert.ToString(linha["A01_002_C"]);
                a01Collection.Add(a01Banco);
            }
            return a01Collection;
        }
        /// <summary>
        /// Metodo de Alteração no banco de dados!
        /// </summary>
        /// <param name="a01Banco"></param>
        public void Alterar(A01Banco a01Banco)
        {
            connA01.LimparParametros();
            connA01.AdicionarParametros("@A01_001_C", a01Banco.a01_001_c);
            connA01.AdicionarParametros("@A01_002_C", a01Banco.a01_002_c);
            connA01.AdicionarParametros("@UKEY", a01Banco.ukey);
            connA01.ExecutaManipulacao(CommandType.Text, update);
        }
        /// <summary>
        /// Metodo de Exclusao no banco de dados!
        /// </summary>
        /// <param name="a01Banco"></param>
        public void Excluir(A01Banco a01Banco)
        {
            connA01.LimparParametros();
            connA01.AdicionarParametros("@UKEY", a01Banco.ukey);
            connA01.ExecutaManipulacao(CommandType.Text, delete);
        }

    }
}
