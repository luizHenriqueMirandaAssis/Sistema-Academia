using AcessoDados.Properties;
using System;
using System.Data;
using System.Data.SqlClient;

namespace AcessoDados
{
    public class AcessoDadosSqlServer
    {
        private SqlConnection CriarConexao()
        {
            return new SqlConnection(Settings.Default.stringConexao);
        }

        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        public void LimparParametros()
        {
            sqlParameterCollection.Clear();
        }

        public void AdicionarParametros(String NomeParametro, object ValorParametro)
        {
            sqlParameterCollection.Add(new SqlParameter(NomeParametro, ValorParametro));
        }

        //Percistencia Inserir e Alterar 

        public object ExecutarManipulacao(CommandType commanType, string nomeStoreProcedure)
        {

            try
            {
                SqlConnection sqlConnection = CriarConexao();
                sqlConnection.Open();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = commanType;
                sqlCommand.CommandText = nomeStoreProcedure;
                sqlCommand.CommandTimeout = 7200; // em segundos

                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                // Executa o comando, ou seja mandar o comando ir até o banco de dados
                return sqlCommand.ExecuteScalar();

            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
        }

        public DataTable ExecutarConsulta(CommandType commandType, string nomeStoreProcedure)
        {
            try
            {
                SqlConnection sqlConnection = CriarConexao();
                sqlConnection.Open();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoreProcedure;
                sqlCommand.CommandTimeout = 7200; // em segundos


                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);


                return dataTable;
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }

        }

    }
}
