using AcessoDados;
using ObjetoTransferencia;
using System;
using System.Data;


namespace Negocios
{
    public class ExercicioNegocio : IDisposable
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
        ListaExercicio listaExercicio = new ListaExercicio();

        public void Dispose()
        {
            acessoDadosSqlServer = null;
            listaExercicio = null;
        }

        public string Inserir(Exercicio exercicio)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Nome", exercicio.Nome);
                acessoDadosSqlServer.AdicionarParametros("@Descricao", exercicio.Descricao);
                acessoDadosSqlServer.AdicionarParametros("@IDTipoExercicio", exercicio.TipoExercicio.IDTipoExercicio);
                acessoDadosSqlServer.AdicionarParametros("@DemonstracaoUrlImagem", exercicio.DemonstracaoUrlImagem);
                acessoDadosSqlServer.AdicionarParametros("@DemonstracaoUrlVideo", exercicio.DemonstracaoUrlVideo);

                string IDExercicio = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspExercicioInserir").ToString();
                return IDExercicio;
                

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Alterar(Exercicio exercicio)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDExercicio", exercicio.IDExercicio);
                acessoDadosSqlServer.AdicionarParametros("@Nome", exercicio.Nome);
                acessoDadosSqlServer.AdicionarParametros("@Descricao", exercicio.Descricao);
                acessoDadosSqlServer.AdicionarParametros("@IDTipoExercicio", exercicio.TipoExercicio.IDTipoExercicio);
                acessoDadosSqlServer.AdicionarParametros("@DemonstracaoUrlImagem", exercicio.DemonstracaoUrlImagem);
                acessoDadosSqlServer.AdicionarParametros("@DemonstracaoUrlVideo", exercicio.DemonstracaoUrlVideo);

                string IDExercicio = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspExercicioAlterar").ToString();
                return IDExercicio;


            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public ListaExercicio PesquisarExercicioCodigoNome(int? codigo, string nome)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("IDExercicio", codigo);
            acessoDadosSqlServer.AdicionarParametros("Nome", nome);

            DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspExercicioPesquisarCodigoNome");

            foreach (DataRow linha in dataTable.Rows)
            {
                Exercicio exercicio = new Exercicio()
                {
                    IDExercicio = Convert.ToInt32(linha["IDExercicio"]),
                    Nome = linha["Nome"].ToString(),
                    Descricao = linha["Descricao"].ToString(),
                    DemonstracaoUrlImagem = linha["DemonstracaoUrlImagem"].ToString(),
                    DemonstracaoUrlVideo = linha["DemonstracaoUrlVideo"].ToString()

                };

                exercicio.TipoExercicio =new TipoExercicio()
                {
                    IDTipoExercicio = Convert.ToInt32(linha["IDTipoExercicio"]),
                    Descricao = linha["DescricaoTipo"].ToString(),
                    Ativo = Convert.ToBoolean(linha["Ativo"])
                
                };

                listaExercicio.Add(exercicio);
            }
            return listaExercicio;
        }

       


    }
}
