using AcessoDados;
using ObjetoTransferencia;
using System;
using System.Data;


namespace Negocios
{
    public class ObjetivoNegocio : IDisposable
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
        ListaObjetivo listaObjetivo = new ListaObjetivo();

        public void Dispose()
        {
            acessoDadosSqlServer = null;
            listaObjetivo = null;
        }

        public ListaObjetivo CarregarCampoDescricao()
        {
            try
            {
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspObjetivoCarregarCampoDescricao");

                foreach (DataRow linha in dataTable.Rows)
                {
                    Objetivo objetivo = new Objetivo()
                    {
                        IDObjetivo = Convert.ToInt32(linha["IDObjetivo"]),
                        Descricao = linha["Descricao"].ToString()
                    };

                    listaObjetivo.Add(objetivo);
                }
                return listaObjetivo;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível carregar o campo com a descrição do objetivo. Detalhes: " + ex.Message);
            }

        }

        public ListaObjetivo ConsultarObjetivoCodigoDescricao(int? codigo, string descricao)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("IDObjetivo", codigo);
            acessoDadosSqlServer.AdicionarParametros("Descricao", descricao);
            DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspObjetivoPesquisarCodigoNome");

            foreach (DataRow linha in dataTable.Rows)
            {
                Objetivo objetivo = new Objetivo()
                {
                    IDObjetivo = Convert.ToInt32(linha["IDObjetivo"]),
                    Descricao = linha["Descricao"].ToString(),

                    DataCadastro = Convert.ToDateTime(linha["DataCadastro"])
                };
                listaObjetivo.Add(objetivo);
            }
            return listaObjetivo;
        }

        public string Inserir(Objetivo objetivo)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("Descricao", objetivo.Descricao);


                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspObjetivoInserir").ToString();
                return retorno;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }


        }

        public string Alterar(Objetivo objetivo)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDObjetivo", objetivo.IDObjetivo);
                acessoDadosSqlServer.AdicionarParametros("@Descricao", objetivo.Descricao);


                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspObjetivoAlterar").ToString();
                return retorno;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}
