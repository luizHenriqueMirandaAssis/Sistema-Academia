using AcessoDados;
using ObjetoTransferencia;
using System;
using System.Data;

namespace Negocios
{
    public class ExerciciosTreinamentoNegocio : IDisposable
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
        ListaExerciciosTreinamento listaExerciciosTreinamento = new ListaExerciciosTreinamento();

        public void Dispose()
        {
            acessoDadosSqlServer = null;
            listaExerciciosTreinamento = null;
        }

        public string Inserir(ExerciciosTreinamento exerciciosTreinamento)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDTreinamento", exerciciosTreinamento.Treinamento.IDTreinamento);
                acessoDadosSqlServer.AdicionarParametros("@IDExercicio", exerciciosTreinamento.Exercicio.IDExercicio);
                acessoDadosSqlServer.AdicionarParametros("@Series", exerciciosTreinamento.Series);
                acessoDadosSqlServer.AdicionarParametros("@Repeticoes", exerciciosTreinamento.Repeticoes);
                acessoDadosSqlServer.AdicionarParametros("@Intervalo", exerciciosTreinamento.Intervalo);
                string IDExerciciosTreinamento = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspExerciciosTreinamentoInserir").ToString();
                return IDExerciciosTreinamento;

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Alterar(ExerciciosTreinamento exerciciosTreinamento)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDTreinamento", exerciciosTreinamento.Treinamento.IDTreinamento);
                acessoDadosSqlServer.AdicionarParametros("@IDExercicio", exerciciosTreinamento.Exercicio.IDExercicio);
                acessoDadosSqlServer.AdicionarParametros("@Series", exerciciosTreinamento.Series);
                acessoDadosSqlServer.AdicionarParametros("@Repeticoes", exerciciosTreinamento.Repeticoes);
                acessoDadosSqlServer.AdicionarParametros("@Intervalo", exerciciosTreinamento.Intervalo);
                string IDExerciciosTreinamento = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspExerciciosTreinamentoAlterar").ToString();
                return IDExerciciosTreinamento;

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Remover(ExerciciosTreinamento exerciciosTreinamento)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@IDTreinamento", exerciciosTreinamento.Treinamento.IDTreinamento);
            acessoDadosSqlServer.AdicionarParametros("@IDExercicio", exerciciosTreinamento.Exercicio.IDExercicio);

            string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspExerciciosTreinamentoRemover").ToString();
            return retorno;
        }
        public string Cancelar(ExerciciosTreinamento exerciciosTreinamnto)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@IDTreinamento", exerciciosTreinamnto.Treinamento.IDTreinamento);

            string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspTreinamentoFisicoCancelar").ToString();
            return retorno;
        }

        public ListaExerciciosTreinamento TreinamentoPesquisaeListaExercicios(int codigo)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@IDTreinamento", codigo);
            DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspTreinamentoFisicoListaExercicioCodigo");
            foreach (DataRow linha in dataTable.Rows)
            {
                ExerciciosTreinamento exerciciosTreinamento = new ExerciciosTreinamento()
                {
                    Series = Convert.ToInt32(linha["Series"]),
                    Repeticoes = Convert.ToInt32(linha["Repeticoes"]),
                    Intervalo = linha["Intervalo"].ToString()
                };

                exerciciosTreinamento.Treinamento = new Treinamento()
                {
                    IDTreinamento = Convert.ToInt32(linha["IDTreinamento"])
                };

                exerciciosTreinamento.Exercicio = new Exercicio()
                {
                    Nome = linha["Nome"].ToString(),
                    IDExercicio = Convert.ToInt32(linha["IDExercicio"])
                };

                exerciciosTreinamento.Exercicio.TipoExercicio = new TipoExercicio()
                {
                    Descricao = linha["TipoExercicio"].ToString()
                };

                listaExerciciosTreinamento.Add(exerciciosTreinamento);
            }
            return listaExerciciosTreinamento;
        }

        public ListaExerciciosTreinamento TreinamentoPesquisaeListaExerciciosPorAluno(int codigo)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@IDAluno", codigo);
            DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspTreinamentoFisicoListaExercicioCodigoPorAluno");
            foreach (DataRow linha in dataTable.Rows)
            {
                ExerciciosTreinamento exerciciosTreinamento = new ExerciciosTreinamento()
                {
                    Series = Convert.ToInt32(linha["Series"]),
                    Repeticoes = Convert.ToInt32(linha["Repeticoes"]),
                    Intervalo = linha["Intervalo"].ToString()
                };

                exerciciosTreinamento.Treinamento = new Treinamento()
                {
                    IDTreinamento = Convert.ToInt32(linha["IDTreinamento"])
                };

                exerciciosTreinamento.Exercicio = new Exercicio()
                {
                    Nome = linha["Nome"].ToString(),
                    IDExercicio = Convert.ToInt32(linha["IDExercicio"])
                };
                exerciciosTreinamento.Treinamento.TipoTreinamento = new TipoTreinamento()
                {
                    Descricao = linha["Descricao"].ToString()
                };

                listaExerciciosTreinamento.Add(exerciciosTreinamento);
            }
            return listaExerciciosTreinamento;
        }

    }
}
