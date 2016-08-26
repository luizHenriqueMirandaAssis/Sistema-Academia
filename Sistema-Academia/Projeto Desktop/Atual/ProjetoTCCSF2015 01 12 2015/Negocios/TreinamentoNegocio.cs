using AcessoDados;
using ObjetoTransferencia;
using System;
using System.Data;

namespace Negocios
{
    public class TreinamentoNegocio: IDisposable
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
        ListaTreinamento listaTreinamento = new ListaTreinamento();

        public void Dispose()
        {
            acessoDadosSqlServer = null;
            listaTreinamento = null;
        }

        public string Inserir(Treinamento treinamento)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDTipoTreinamento", treinamento.TipoTreinamento.IDTipoTreinamento);
                acessoDadosSqlServer.AdicionarParametros("@Ativo", treinamento.Ativo);
                acessoDadosSqlServer.AdicionarParametros("@IDAluno", treinamento.Aluno.Pessoa.IDPessoa);
                string IDTreinamento = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspTreinamentoInserir").ToString();
                return IDTreinamento;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Alterar(Treinamento treinamento)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDTreinamento", treinamento.IDTreinamento);
                acessoDadosSqlServer.AdicionarParametros("@IDAluno", treinamento.Aluno.Pessoa.IDPessoa);
                acessoDadosSqlServer.AdicionarParametros("@IDTipoTreinamento", treinamento.TipoTreinamento.IDTipoTreinamento);
                acessoDadosSqlServer.AdicionarParametros("@Ativo", treinamento.Ativo);
                string IDTreinamento = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspTreinamentoAlterar").ToString();
                return IDTreinamento;
                
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public ListaTreinamento  PesquisarTreinamentoCodigoNomeAluno(int? codigo, string nome)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@IDAluno", codigo);
            acessoDadosSqlServer.AdicionarParametros("@NomeAluno", nome);

            DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspTreinamentoPesquisarIDAlunoNomeAluno");

            foreach(DataRow linha in dataTable.Rows)
            {
                Treinamento treinamento = new Treinamento()
                {
                    IDTreinamento = Convert.ToInt32(linha["IDTreinamento"]),
                    DataCadastro = Convert.ToDateTime(linha["DataCadastro"]),
                    Ativo = Convert.ToBoolean(linha["Ativo"])
                };

                treinamento.TipoTreinamento = new TipoTreinamento()
                {
                    IDTipoTreinamento = Convert.ToInt32(linha["IDTipoTreinamento"]),
                    Descricao = linha["Descricao"].ToString()
                };

                treinamento.Aluno = new Aluno();
                treinamento.Aluno.Objetivo = new Objetivo()
                {
                    Descricao = linha["objetivo"].ToString()
                };
                treinamento.Aluno.Pessoa = new Pessoa()
                {
                    IDPessoa = Convert.ToInt32(linha["IDAluno"]),
                    Nome = linha["Nome"].ToString()
                };

                listaTreinamento.Add(treinamento);

            }
            return listaTreinamento;
        }

    }
}
