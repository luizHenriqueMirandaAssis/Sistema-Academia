using AcessoDados;
using ObjetoTransferencia;
using System;
using System.Data;

namespace Negocios
{
    public class TipoMedidaCorporalNegocio : IDisposable
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
        ListaTipoMedidaCorporal listaTipoMedidaCorporal = new ListaTipoMedidaCorporal();

        public void Dispose()
        {
            acessoDadosSqlServer = null;
            listaTipoMedidaCorporal = null;
        }


        public string Inserir(TipoMedidaCorporal tipoMedidaCorporal)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Descricao", tipoMedidaCorporal.Descricao);
                acessoDadosSqlServer.AdicionarParametros("@Ativo", tipoMedidaCorporal.Ativo);
                string IDTipoMedidaCorporal = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspTipoMedidaCorporalInserir").ToString();
                return IDTipoMedidaCorporal;

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Alterar(TipoMedidaCorporal tipoMedidaCorporal)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDTipoMedidaCorporal", tipoMedidaCorporal.IDTipoMedidaCorporal);
                acessoDadosSqlServer.AdicionarParametros("@Descricao", tipoMedidaCorporal.Descricao);
                acessoDadosSqlServer.AdicionarParametros("@Ativo", tipoMedidaCorporal.Ativo);
                string IDTipoMedidaCorporal = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspTipoMedidaCorporalAlterar").ToString();
                return IDTipoMedidaCorporal;

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public ListaTipoMedidaCorporal PesquisarTipoMedidaCorporal(int? codigo, string descricao)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDTipoMedidaCorporal", codigo);
                acessoDadosSqlServer.AdicionarParametros("@Descricao", descricao);

                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspTipoMedidaCorporalConsultarCodigoOuDescricao");

                foreach (DataRow linha in dataTable.Rows)
                {
                    TipoMedidaCorporal tipoMedidaCorporal = new TipoMedidaCorporal()
                    {
                        IDTipoMedidaCorporal = Convert.ToInt32(linha["IDTipoMedidaCorporal"]),
                        Descricao = linha["Descricao"].ToString(),
                        Ativo = Convert.ToBoolean(linha["Ativo"])

                    };

                    listaTipoMedidaCorporal.Add(tipoMedidaCorporal);
                }
                return listaTipoMedidaCorporal;
            }
            catch(Exception ex)
            {
                throw new Exception("Não foi possível consultar por código ou descrição. Detalhes: " + ex.Message);
            }

        }

    }
}
