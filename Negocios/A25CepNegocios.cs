using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessaBancoDados;
using ObjetoTransferencia;
using System.Data;

namespace Negocios
{
   public class A25CepNegocios
    {
        AcessaBanco connA25 = new AcessaBanco();
        //query de pesquisa no banco iniciado por
        private string select0 = "SELECT A25.UKEY AS IDCEP, * FROM A25"
            + " INNER JOIN A24 ON A25.A24_UKEY=A24.UKEY"
            + " INNER JOIN A23 ON A24.A23_UKEY=A23.UKEY"
            + " INNER JOIN A22 ON A23.A22_UKEY=A22.UKEY"
            + " WHERE A25_001_C LIKE @A25_001_C";

        //query de pesquisa no banco contem
        private string select1 = "SELECT A25.UKEY AS IDCEP, * FROM A25"
            + " INNER JOIN A24 ON A25.A24_UKEY=A24.UKEY"
            + " INNER JOIN A23 ON A24.A23_UKEY=A23.UKEY"
            + " INNER JOIN A22 ON A23.A22_UKEY=A22.UKEY"
            + " WHERE A25_001_C LIKE @A25_001_C";

        //query de pesquisa no banco igual
        private string select2 = "SELECT A25.UKEY AS IDCEP, * FROM A25"
            + " INNER JOIN A24 ON A25.A24_UKEY=A24.UKEY"
            + " INNER JOIN A23 ON A24.A23_UKEY=A23.UKEY"
            + " INNER JOIN A22 ON A23.A22_UKEY=A22.UKEY"
            + " WHERE A25_001_C = @A25_001_C";

        //query de pesquisa no banco terminado por
        private string select3 = "SELECT A25.UKEY AS IDCEP, * FROM A25"
            + " INNER JOIN A24 ON A25.A24_UKEY=A24.UKEY"
            + " INNER JOIN A23 ON A24.A23_UKEY=A23.UKEY"
            + " INNER JOIN A22 ON A23.A22_UKEY=A22.UKEY"
            + " WHERE A25_001_C LIKE @A25_001_C";

        //query de pesquisa no banco diferente de 
        private string select4 = "SELECT A25.UKEY AS IDCEP, * FROM A25"
            + " INNER JOIN A24 ON A25.A24_UKEY=A24.UKEY"
            + " INNER JOIN A23 ON A24.A23_UKEY=A23.UKEY"
            + " INNER JOIN A22 ON A23.A22_UKEY=A22.UKEY"
            + " WHERE A25_001_C <> @A25_001_C";

        public A25CepCollection PesquisaCep(int opcao, string cep)
        {
            A25CepCollection a25CepCollection = new A25CepCollection();
            try
            {
                switch (opcao)
                {
                    case 0:
                        A25CepCollection a25CepCollection0 = new A25CepCollection();
                        connA25.LimparParametros();
                        connA25.AdicionarParametros("@A25_001_C", cep + "%");
                        DataTable dataTable0 = connA25.ExecutaConsulta(CommandType.Text, select0);
                        foreach(DataRow linha in dataTable0.Rows)
                        {
                            A25Cep a25Cep = new A25Cep();
                            a25Cep.ukey = Convert.ToString(linha["IDCEP"]);
                            a25Cep.a25_001_c = Convert.ToString(linha["A25_001_C"]);
                            a25Cep.a25_002_c = Convert.ToString(linha["A25_002_C"]);
                            a25Cep.a25_003_c = Convert.ToString(linha["A25_003_C"]);
                            a25Cep.nomeCidade = Convert.ToString(linha["A24_001_C"]);
                            a25Cep.nomeEstado = Convert.ToString(linha["A23_002_C"]);
                            a25Cep.nomePais = Convert.ToString(linha["A22_001_C"]);
                            a25Cep.ufEstado = Convert.ToString(linha["A23_001_C"]);
                            a25CepCollection0.Add(a25Cep);
                        }
                        return a25CepCollection0;
                    case 1:
                        A25CepCollection a25CepCollection1 = new A25CepCollection();
                        connA25.LimparParametros();
                        connA25.AdicionarParametros("@A25_001_C", "%"+ cep + "%");
                        DataTable dataTable1 = connA25.ExecutaConsulta(CommandType.Text, select1);
                        foreach (DataRow linha in dataTable1.Rows)
                        {
                            A25Cep a25Cep = new A25Cep();
                            a25Cep.ukey = Convert.ToString(linha["IDCEP"]);
                            a25Cep.a25_001_c = Convert.ToString(linha["A25_001_C"]);
                            a25Cep.a25_002_c = Convert.ToString(linha["A25_002_C"]);
                            a25Cep.a25_003_c = Convert.ToString(linha["A25_003_C"]);
                            a25Cep.nomeCidade = Convert.ToString(linha["A24_001_C"]);
                            a25Cep.nomeEstado = Convert.ToString(linha["A23_002_C"]);
                            a25Cep.nomePais = Convert.ToString(linha["A22_001_C"]);
                            a25Cep.ufEstado = Convert.ToString(linha["A23_001_C"]);
                            a25CepCollection1.Add(a25Cep);
                        }
                        return a25CepCollection1;
                    case 2:
                        A25CepCollection a25CepCollection2 = new A25CepCollection();
                        connA25.LimparParametros();
                        connA25.AdicionarParametros("@A25_001_C", cep);
                        DataTable dataTable2 = connA25.ExecutaConsulta(CommandType.Text, select2);
                        foreach (DataRow linha in dataTable2.Rows)
                        {
                            A25Cep a25Cep = new A25Cep();
                            a25Cep.ukey = Convert.ToString(linha["IDCEP"]);
                            a25Cep.a25_001_c = Convert.ToString(linha["A25_001_C"]);
                            a25Cep.a25_002_c = Convert.ToString(linha["A25_002_C"]);
                            a25Cep.a25_003_c = Convert.ToString(linha["A25_003_C"]);
                            a25Cep.nomeCidade = Convert.ToString(linha["A24_001_C"]);
                            a25Cep.nomeEstado = Convert.ToString(linha["A23_002_C"]);
                            a25Cep.nomePais = Convert.ToString(linha["A22_001_C"]);
                            a25Cep.ufEstado = Convert.ToString(linha["A23_001_C"]);
                            a25CepCollection2.Add(a25Cep);
                        }
                        return a25CepCollection2;
                    case 3:
                        A25CepCollection a25CepCollection3 = new A25CepCollection();
                        connA25.LimparParametros();
                        connA25.AdicionarParametros("@A25_001_C","%"+ cep);
                        DataTable dataTable3 = connA25.ExecutaConsulta(CommandType.Text, select3);
                        foreach (DataRow linha in dataTable3.Rows)
                        {
                            A25Cep a25Cep = new A25Cep();
                            a25Cep.ukey = Convert.ToString(linha["IDCEP"]);
                            a25Cep.a25_001_c = Convert.ToString(linha["A25_001_C"]);
                            a25Cep.a25_002_c = Convert.ToString(linha["A25_002_C"]);
                            a25Cep.a25_003_c = Convert.ToString(linha["A25_003_C"]);
                            a25Cep.nomeCidade = Convert.ToString(linha["A24_001_C"]);
                            a25Cep.nomeEstado = Convert.ToString(linha["A23_002_C"]);
                            a25Cep.nomePais = Convert.ToString(linha["A22_001_C"]);
                            a25Cep.ufEstado = Convert.ToString(linha["A23_001_C"]);
                            a25CepCollection3.Add(a25Cep);
                        }
                        return a25CepCollection3;
                    case 4:
                        A25CepCollection a25CepCollection4 = new A25CepCollection();
                        connA25.LimparParametros();
                        connA25.AdicionarParametros("@A25_001_C", cep);
                        DataTable dataTable4 = connA25.ExecutaConsulta(CommandType.Text, select4);
                        foreach (DataRow linha in dataTable4.Rows)
                        {
                            A25Cep a25Cep = new A25Cep();
                            a25Cep.ukey = Convert.ToString(linha["IDCEP"]);
                            a25Cep.a25_001_c = Convert.ToString(linha["A25_001_C"]);
                            a25Cep.a25_002_c = Convert.ToString(linha["A25_002_C"]);
                            a25Cep.a25_003_c = Convert.ToString(linha["A25_003_C"]);
                            a25Cep.nomeCidade = Convert.ToString(linha["A24_001_C"]);
                            a25Cep.nomeEstado = Convert.ToString(linha["A23_002_C"]);
                            a25Cep.nomePais = Convert.ToString(linha["A22_001_C"]);
                            a25Cep.ufEstado = Convert.ToString(linha["A23_001_C"]);
                            a25CepCollection4.Add(a25Cep);
                        }
                        return a25CepCollection4;
                }
                return a25CepCollection;

            }catch(Exception ex)
            {
                throw new Exception("Nenhum Registro Encontrado");
            }
        }
    }
}
