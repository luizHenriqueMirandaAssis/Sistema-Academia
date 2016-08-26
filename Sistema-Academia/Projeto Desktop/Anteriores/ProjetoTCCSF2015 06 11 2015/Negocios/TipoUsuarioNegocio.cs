using AcessoDados;
using ObjetoTransferencia;
using System;
using System.Data;


namespace Negocios
{
    public class TipoUsuarioNegocio : IDisposable
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();
        ListaTipoUsuario listaTipoUsuario = new ListaTipoUsuario();

        public void Dispose()
        {
            acessoDados = null;
            listaTipoUsuario = null;
        }

        public string InserirTipoUsuario(TipoUsuario tipoUsuario)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@Descricao", tipoUsuario.Descricao);
                acessoDados.AdicionarParametros("@Ativo", tipoUsuario.Ativo);

                string IDTipoUsuario = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "uspTipoUsuarioInserir").ToString();
                return IDTipoUsuario;
                   
            }
            catch(Exception ex)
            {
                return ex.Message;
            }

        }

        public string AlterarTipoUsuario(TipoUsuario tipoUsuario)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@IDTipoUsuario", tipoUsuario.IDTipoUsuario);
                acessoDados.AdicionarParametros("@Descricao", tipoUsuario.Descricao);
                acessoDados.AdicionarParametros("@Ativo", tipoUsuario.Ativo);

                string IDTipoUsuario = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "uspTipoUsuarioAlterar").ToString();
                return IDTipoUsuario;
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public ListaTipoUsuario CarregarCampoDescricao()
        {
            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "uspTipoUsuarioCarregarCampoDescricao");
            foreach (DataRow linha in dataTable.Rows)
            {
                TipoUsuario tipoUsuario = new TipoUsuario();
                tipoUsuario.Descricao = linha["Descricao"].ToString();
               tipoUsuario.IDTipoUsuario = Convert.ToInt32(linha["IDTipoUsuario"]);

                listaTipoUsuario.Add(tipoUsuario);
            }
            return listaTipoUsuario;
        }

        public ListaTipoUsuario ConsultarTipoUsuarioCodigoDescricao(int? codigo, string descricao)
        {
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@IDTipoUsuario", codigo);
            acessoDados.AdicionarParametros("@Descricao", descricao);
            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "uspTipoUsuarioPesquisarTipoUsuario");

            foreach(DataRow linha in dataTable.Rows)
            {
                TipoUsuario tipoUsuario = new TipoUsuario()
                {
                    IDTipoUsuario = Convert.ToInt32(linha["IDTipoUsuario"]),
                    Descricao = linha["Descricao"].ToString(),
                    Ativo = Convert.ToBoolean(linha["Ativo"])
                };

                listaTipoUsuario.Add(tipoUsuario);
            }
            return listaTipoUsuario;
        }


    }
}
