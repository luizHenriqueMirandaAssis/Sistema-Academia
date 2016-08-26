using AcessoDados;
using ObjetoTransferencia;
using System;
using System.Data;

namespace Negocios
{
    public class TipoExercicioNegocio: IDisposable
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
        ListaTipoExercicio listaTipoExercicio = new ListaTipoExercicio();

        public void Dispose()
        {
            acessoDadosSqlServer = null;
            listaTipoExercicio = null;
        }

        public string Inserir(TipoExercicio tipoExercicio)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Descricao", tipoExercicio.Descricao);
                acessoDadosSqlServer.AdicionarParametros("@Ativo", tipoExercicio.Ativo);
                string IDTipoExercicio = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspTipoExercicioInserir").ToString();
                return IDTipoExercicio;

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Alterar(TipoExercicio tipoExercicio)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDTipoExercicio", tipoExercicio.IDTipoExercicio);
                acessoDadosSqlServer.AdicionarParametros("@Descricao", tipoExercicio.Descricao);
                acessoDadosSqlServer.AdicionarParametros("@Ativo", tipoExercicio.Ativo);
                string IDTipoExercicio = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspTipoExercicioAlterar").ToString();
                return IDTipoExercicio;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public ListaTipoExercicio PesquisarTipoExercicioPorCodigoOuDescricao(int? IDTipoExercicio, string Descricao)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDTipoExercicio", IDTipoExercicio);
                acessoDadosSqlServer.AdicionarParametros("@Descricao", Descricao);

                DataTable DataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspTipoExercicioPesquisarCodigoOuDescricao");

                foreach(DataRow linha in DataTable.Rows)
                {
                    TipoExercicio tipoExercicio = new TipoExercicio();
                    tipoExercicio.IDTipoExercicio = Convert.ToInt32(linha["IDTipoExercicio"]);
                    tipoExercicio.Descricao = linha["Descricao"].ToString();
                    tipoExercicio.Ativo = Convert.ToBoolean(linha["Ativo"]);

                    listaTipoExercicio.Add(tipoExercicio);
                }

                return listaTipoExercicio;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar por código ou descrição. Detalhes: " + ex.Message);
            }
        }

        public ListaTipoExercicio CarregarCampoTipoExercicio()
        {
            try
            {

                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "[uspTipoExercicioCarregarCampoDescricao]");
                foreach (DataRow linha in dataTable.Rows)
                {
                    TipoExercicio tipoExercicio = new TipoExercicio();
                    tipoExercicio.Descricao = linha["Descricao"].ToString();
                    tipoExercicio.IDTipoExercicio = Convert.ToInt32(linha["IDTipoExercicio"]);

                    listaTipoExercicio.Add(tipoExercicio);
                }
                return listaTipoExercicio;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar o campo descrição. Detalhes: " + ex.Message);
            }
        }
    }
}
