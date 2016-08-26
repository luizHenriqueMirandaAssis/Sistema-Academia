using AcessoDados;
using ObjetoTransferencia;
using System;
using System.Data;

namespace Negocios
{
    public class EquipamentoNegocio :IDisposable
    {

        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
        ListaEquipamento listaEquipamento = new ListaEquipamento();

        public void Dispose()
        {
            acessoDadosSqlServer = null;
            listaEquipamento = null;
        }

        public string Inserir(Equipamento equipamento)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Nome", equipamento.Nome);
                acessoDadosSqlServer.AdicionarParametros("@Quantidade", equipamento.Quantidade);
                acessoDadosSqlServer.AdicionarParametros("@Ativo", equipamento.Quantidade);
                string IDProduto = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspEquipamentoInserir").ToString();
                return IDProduto;

            }
            catch (Exception ex)
            {
                return ex.Message;
            }          
        }

        public string Alterar(Equipamento equipamento)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDEquipamento", equipamento.IDEquipamento);
                acessoDadosSqlServer.AdicionarParametros("@Nome", equipamento.Nome);
                acessoDadosSqlServer.AdicionarParametros("Quantidade", equipamento.Quantidade);
                acessoDadosSqlServer.AdicionarParametros("@Ativo", equipamento.Ativo);

                string IDEquipamento = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspEquipamentoAlterar").ToString();
                return IDEquipamento;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public ListaEquipamento ConsultarPorCodigoOuDescricao(int? IDEquipamento, string nome)
        {
            try
            {

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDEquipamento", IDEquipamento);
                acessoDadosSqlServer.AdicionarParametros("@Nome", nome);
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspEquipamentoConsultarPorCodigoOuNome");

                foreach (DataRow linha in dataTable.Rows)
                {
                    Equipamento equipamento = new Equipamento();
                    equipamento.IDEquipamento = Convert.ToInt32(linha["IDEquipamento"]);
                    equipamento.Nome = linha["Nome"].ToString();
                    equipamento.Quantidade = Convert.ToInt32(linha["Quantidade"]);
                    equipamento.Ativo = Convert.ToBoolean(linha["Ativo"]);

                    listaEquipamento.Add(equipamento);
                }


                return listaEquipamento;
            }
            catch (Exception ex)
            {
                throw new Exception(" Não foi possível consultar por código ou descrição. Detalhes: " + ex.Message);
            }
        }

    }
}
