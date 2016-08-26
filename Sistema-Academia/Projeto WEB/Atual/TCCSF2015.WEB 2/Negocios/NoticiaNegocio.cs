using AcessoDados;
using ObjetoTransferencia;
using System;
using System.Data;

namespace Negocios
{
    public class NoticiaNegocio : IDisposable
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
        ListaNoticia listaNoticia = new ListaNoticia();

        public void Dispose()
        {
            acessoDadosSqlServer = null;
            listaNoticia = null;
        }

        public string Inserir(Noticia noticia)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Titulo", noticia.Titulo);
                acessoDadosSqlServer.AdicionarParametros("@Descricao", noticia.Descricao);
                acessoDadosSqlServer.AdicionarParametros("@Ativo", noticia.Ativo);
                string IDNoticia = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspNoticiaInserir").ToString();
                return IDNoticia;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Alterar(Noticia noticia)
        {
            try
            {
                acessoDadosSqlServer.AdicionarParametros("@IDNoticia", noticia.IDNoticia);
                acessoDadosSqlServer.AdicionarParametros("@Titulo", noticia.Titulo);
                acessoDadosSqlServer.AdicionarParametros("@Descricao", noticia.Descricao);
                acessoDadosSqlServer.AdicionarParametros("@Ativo", noticia.Ativo);
                string IDNoticia = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspNoticiaAlterar").ToString();
                return IDNoticia;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public ListaNoticia ConsultarNoticia(int? codigo, string titulo)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@IDNoticia", codigo);
            acessoDadosSqlServer.AdicionarParametros("@Titulo", titulo);

            DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspNoticiaPesquisarCodigoOuTitulo");

            foreach (DataRow linha in dataTable.Rows)
            {
                Noticia noticia = new Noticia()
                {
                    IDNoticia = Convert.ToInt32(linha["IDNoticia"]),
                    Titulo = linha["Titulo"].ToString(),
                    Descricao = linha["Descricao"].ToString(),
                    DataNoticia = Convert.ToDateTime(linha["DataNoticia"]),
                    Ativo = Convert.ToBoolean(linha["Ativo"])

                };

                listaNoticia.Add(noticia);
            }
            return listaNoticia;
        }

    }
}
