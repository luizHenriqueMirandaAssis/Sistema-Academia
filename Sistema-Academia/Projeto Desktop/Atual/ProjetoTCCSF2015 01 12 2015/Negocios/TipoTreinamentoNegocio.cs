using AcessoDados;
using ObjetoTransferencia;
using System;
using System.Data;

namespace Negocios
{
    public class TipoTreinamentoNegocio: IDisposable
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
        ListaTipoTreinamento listaTipoTreinamento = new ListaTipoTreinamento();

        public void Dispose()
        {
            acessoDadosSqlServer = null;
            listaTipoTreinamento = null;
        }

        public string Inserir(TipoTreinamento tipoTreinamento)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@Descricao", tipoTreinamento.Descricao);
            acessoDadosSqlServer.AdicionarParametros("@Ativo", tipoTreinamento.Ativo);

            string retorno = acessoDadosSqlServer.ExecutarManipulacao(System.Data.CommandType.StoredProcedure, "uspTipoTreinamentoInserir").ToString();
            return retorno;
        }
        public string Alterar(TipoTreinamento tipoTreinamento)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@IDTipoTreinamento", tipoTreinamento.IDTipoTreinamento);
            acessoDadosSqlServer.AdicionarParametros("Descricao", tipoTreinamento.Descricao);
            acessoDadosSqlServer.AdicionarParametros("Ativo", tipoTreinamento.Ativo);

            string retorno = acessoDadosSqlServer.ExecutarManipulacao(System.Data.CommandType.StoredProcedure, "uspTipoTreinamentoAlterar").ToString();
            return retorno;

        }
        public ListaTipoTreinamento PesquisarTreinamentoCodigoNome(int? codigo, string nome)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@IDTipoTreinamento", codigo);
            acessoDadosSqlServer.AdicionarParametros("@Descricao", nome);

            DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspTipoTreinamentoPesquisarCodigoNome");
           foreach(DataRow linha in dataTable.Rows)
           {
               TipoTreinamento tipoTreinamento = new TipoTreinamento()
               {
                   IDTipoTreinamento = Convert.ToInt32(linha["IDTipoTreinamento"]),
                   Descricao  = linha["Descricao"].ToString(),
                   Ativo = Convert.ToBoolean(linha["Ativo"])
               };
               listaTipoTreinamento.Add(tipoTreinamento);
           }
           return listaTipoTreinamento;
        }

    }
}
