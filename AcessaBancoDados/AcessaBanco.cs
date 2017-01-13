using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AcessaBancoDados.Properties;
namespace AcessaBancoDados
{
    public class AcessaBanco
    {
        public SqlConnection CriarConexao()
        {
            return new SqlConnection(Settings.Default.stringConexao);
        }
        private SqlParameterCollection sqlParametros = new SqlCommand().Parameters;

        public void LimparParametros()
        {
            sqlParametros.Clear();
        }

        public void AdicionarParametros(string nomeParametro, object valorParametro)
        {
            sqlParametros.Add(new SqlParameter(nomeParametro, valorParametro));
        }
        /// <summary>
        /// Metodo que manipula o banco Insert, update, delete
        /// </summary>
        /// <param name="commandType"></param>
        /// <param name="sql"></param>
        /// <returns></returns>
        public void ExecutaManipulacao(CommandType commandType, string sql)
        {
            SqlConnection sqlconnection = CriarConexao();
            try
            {
                //criar conexao
                
                //abre a conexao
                sqlconnection.Open();
                //cria comando que vai levar informação para o banco de dados
                SqlCommand sqlCommand = sqlconnection.CreateCommand();
                //colocando as coisas dentro do comando
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = sql;
                sqlCommand.CommandTimeout = 7200;//tempo maximo de uma execução
                                                 //adicionar os parametros no comando
                foreach (SqlParameter sqlParameter in sqlParametros)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
                // executar comando pra levar para o banco
                 sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                sqlconnection.Close();
            }
            
        }
        /// <summary>
        /// Metodo que executa consulta no banco de dados retorna uma dataTable(tabela de dados)
        /// </summary>
        /// <param name="commandType"></param>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable ExecutaConsulta(CommandType commandType, string sql)
        {
            try
            {
                //criar conexao
                SqlConnection sqlconnection = CriarConexao();
                //abre a conexao
                sqlconnection.Open();
                //cria comando que vai levar informação para o banco de dados
                SqlCommand sqlCommand = sqlconnection.CreateCommand();
                //colocando as coisas dentro do comando
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = sql;
                sqlCommand.CommandTimeout = 7200;//tempo maximo de uma execução
                //adicionar os parametros no comando
                foreach (SqlParameter sqlParameter in sqlParametros)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
                //criar um adapatador
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                //crias um data table vazia
                DataTable dataTable = new DataTable();
                //preenchimento da DataTable que estava vazia
                sqlDataAdapter.Fill(dataTable);
                return dataTable;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
