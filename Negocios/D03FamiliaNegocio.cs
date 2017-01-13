using AcessaBancoDados;
using ObjetoTransferencia;
using System;
using System.Data;

namespace Negocios
{
    //teste commit
    //teste commit pc not
    public class D03FamiliaNegocio
    {
        AcessaBanco connD03 = new AcessaBanco();

        //query para inserir no banco de dados
        private string insert = "INSERT INTO D03 (D03_001_C, D03_002_C) VALUES (@D03_001_C, @D03_002_C)";

        //query para alterar no banco de dados
        private string update = "UPDATE D03 SET D03_001_C = @D03_001_C, D03_002_C = @D03_002_C WHERE UKEY = @UKEY";

        //query para deletar no banco de dados
        private string delete = "DELETE FROM D03 WHERE UKEY = @UKEY";

        //query para selecao de registros
        private string selectLike = "SELECT UKEY AS UKEYFAMILIA, * FROM D03 WHERE D03_001_C LIKE @D03_001_C OR D03_002_C LIKE @D03_002_C";
        
        //QUERY PARA SELEÇÃO DE REGISTROS IGUAL
        private string selectIgual = "SELECT UKEY AS UKEYFAMILIA, * FROM D03 WHERE D03_001_C = @D03_001_C OR D03_002_C = @D03_002_C";

        //query diferente por nome
        private string selectDiferentePorNome = "SELECT UKEY AS UKEYFAMILIA, * FROM D03 WHERE D03_002_C <> @D03_002_C";

        //query diferente por codigo
        private string selectDiferentePorCodigo = "SELECT UKEY AS UKEYFAMILIA, * FROM D03 WHERE D03_002_C <> @D03_002_C";
        /// <summary>
        /// Metodo de inserir no banco de dados
        /// </summary>
        /// <param name="d03Familia"></param>
        public void Inserir(D03Familia d03Familia)
        {
            connD03.LimparParametros();

            connD03.AdicionarParametros("@D03_001_C", d03Familia.d03_001_c);
            connD03.AdicionarParametros("@D03_002_C", d03Familia.d03_002_c);

            connD03.ExecutaManipulacao(CommandType.Text, insert);
        }
        /// <summary>
        /// Metodo de Busca de Familias
        /// </summary>
        /// <param name="opcaoBusca"></param>
        /// <param name="opcaoFiltro"></param>
        /// <param name="parametro"></param>
        /// <returns></returns>
        public D03FamiliaCollection Pesquisa (int opcaoBusca, int opcaoFiltro, string parametro)
        {
            D03FamiliaCollection d03Collection = new D03FamiliaCollection();
            DataTable dataTable = null;

            switch (opcaoBusca)
            {
                //caso 0 entra na pesquisa por descrição
                case 0:
                    //se for 0 iniciado por
                    if(opcaoFiltro == 0)
                    {
                        connD03.LimparParametros();
                        connD03.AdicionarParametros("@D03_002_C", parametro + "%");
                        connD03.AdicionarParametros("@D03_001_C", "");
                        dataTable = connD03.ExecutaConsulta(CommandType.Text, selectLike);
                    } else if (opcaoFiltro == 1)
                    {
                        connD03.LimparParametros();
                        connD03.AdicionarParametros("@D03_002_C", "%" + parametro + "%");
                        connD03.AdicionarParametros("@D03_001_C", "");
                        dataTable = connD03.ExecutaConsulta(CommandType.Text, selectLike);
                    } else if (opcaoFiltro == 2)
                    {
                        connD03.LimparParametros();
                        connD03.AdicionarParametros("@D03_002_C", parametro);
                        connD03.AdicionarParametros("@D03_001_C", "");
                        dataTable = connD03.ExecutaConsulta(CommandType.Text, selectIgual);
                    } else if (opcaoFiltro == 3)
                    {
                        connD03.LimparParametros();
                        connD03.AdicionarParametros("@D03_002_C", "%" + parametro);
                        connD03.AdicionarParametros("@D03_001_C", "");
                        dataTable = connD03.ExecutaConsulta(CommandType.Text, selectLike);
                    } else if (opcaoFiltro == 4)
                    {
                        connD03.LimparParametros();
                        connD03.AdicionarParametros("@D03_002_C", parametro);
                        //connD03.AdicionarParametros("@D03_001_C", "");
                        dataTable = connD03.ExecutaConsulta(CommandType.Text, selectDiferentePorNome);
                    }
                    break;
                //se for 1 pesquisa por codigo                      
                case 1:

                    if (opcaoFiltro == 0)
                    {
                        connD03.LimparParametros();
                        connD03.AdicionarParametros("@D03_002_C", "");
                        connD03.AdicionarParametros("@D03_001_C", parametro + "%");
                        dataTable = connD03.ExecutaConsulta(CommandType.Text, selectLike);
                    }
                    else if (opcaoFiltro == 1)
                    {
                        connD03.LimparParametros();
                        connD03.AdicionarParametros("@D03_002_C", "");
                        connD03.AdicionarParametros("@D03_001_C", "%" + parametro + "%");
                        dataTable = connD03.ExecutaConsulta(CommandType.Text, selectLike);
                    }
                    else if (opcaoFiltro == 2)
                    {
                        connD03.LimparParametros();
                        connD03.AdicionarParametros("@D03_002_C", "");
                        connD03.AdicionarParametros("@D03_001_C", parametro);
                        dataTable = connD03.ExecutaConsulta(CommandType.Text, selectIgual);
                    }
                    else if (opcaoFiltro == 3)
                    {
                        connD03.LimparParametros();
                        connD03.AdicionarParametros("@D03_002_C", "");
                        connD03.AdicionarParametros("@D03_001_C", "%" + parametro);
                        dataTable = connD03.ExecutaConsulta(CommandType.Text, selectLike);
                    }
                    else if (opcaoFiltro == 4)
                    {
                        connD03.LimparParametros();
                        //connD03.AdicionarParametros("@D03_002_C", "");
                        connD03.AdicionarParametros("@D03_001_C", parametro);
                        dataTable = connD03.ExecutaConsulta(CommandType.Text, selectDiferentePorCodigo);
                    }
                    break;
                    
            }

            foreach (DataRow linha in dataTable.Rows)
            {
                D03Familia d03Familia = new D03Familia();
                d03Familia.ukey = Convert.ToString(linha["UKEYFAMILIA"]);
                d03Familia.d03_001_c = Convert.ToString(linha["D03_001_C"]);
                d03Familia.d03_002_c = Convert.ToString(linha["D03_002_C"]);
                d03Collection.Add(d03Familia);
            }
            return d03Collection;
           
        }
        /// <summary>
        /// Metodo de alteração no banco de dados
        /// </summary>
        /// <param name="d03Familia"></param>
        public  void Alterar(D03Familia d03Familia)
        {
            connD03.LimparParametros();

            connD03.AdicionarParametros("@D03_001_C", d03Familia.d03_001_c);
            connD03.AdicionarParametros("@D03_002_C", d03Familia.d03_002_c);
            connD03.AdicionarParametros("UKEY", d03Familia.ukey);

            connD03.ExecutaManipulacao(CommandType.Text, update);
        }
        /// <summary>
        /// Metodo de exclusao no banco de dados
        /// </summary>
        /// <param name="d03Familia"></param>
        public void Excluir(D03Familia d03Familia)
        {
            connD03.LimparParametros();

            connD03.AdicionarParametros("UKEY", d03Familia.ukey);
            connD03.ExecutaManipulacao(CommandType.Text, delete);
        }

    }
}
