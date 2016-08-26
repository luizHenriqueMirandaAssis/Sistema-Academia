using AcessoDados;
using ObjetoTransferencia;
using System;
using System.Data;

namespace Negocios
{
    public class MedidaCorporalNegocio: IDisposable
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
        ListaMedidaCorporal listaMedidaCorporal = new ListaMedidaCorporal();

        public void Dispose()
        {
            acessoDadosSqlServer = null;
            listaMedidaCorporal = null;
        }

        public string Inserir(MedidaCorporal medidaCorporal)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDAluno", medidaCorporal.Aluno.Pessoa.IDPessoa);
                acessoDadosSqlServer.AdicionarParametros("@IDTipoMedidaCorporal", medidaCorporal.TipoMedidaCorporal.IDTipoMedidaCorporal);
                acessoDadosSqlServer.AdicionarParametros("@DataMedida", medidaCorporal.DataMedida);
                acessoDadosSqlServer.AdicionarParametros("@MedidaCm", medidaCorporal.MedidaCm);
                acessoDadosSqlServer.AdicionarParametros("@Ativo", medidaCorporal.Ativo);
                string IDMedidaCorporal = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspMedidaCorporalInserir").ToString();
                return IDMedidaCorporal;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Alterar(MedidaCorporal medidaCorporal)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDMedidaCorporal", medidaCorporal.IDMedidaCorporal);
              
                acessoDadosSqlServer.AdicionarParametros("@MedidaCm", medidaCorporal.MedidaCm);
              
                string IDMedidaCorporal = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspMedidaCorporalAlterar").ToString();
                return IDMedidaCorporal;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Remover(MedidaCorporal medidaCorporal)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDMedidaCorporal", medidaCorporal.IDMedidaCorporal);
                string IDMedidaCorporal = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspMedidaCorporalRemover").ToString();
                return IDMedidaCorporal;               
            }
            catch(Exception ex)
            {
                throw new Exception("Não foi possível excluir a medida corporal. Detalhes: " + ex.Message);
            }
        }

        public string Cancelar(MedidaCorporal medidaCoporl)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDAluno", medidaCoporl.Aluno.Pessoa.IDPessoa);
                acessoDadosSqlServer.AdicionarParametros("@DataMedida", medidaCoporl.DataMedida);

                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspMedidaCorporalCancelar").ToString();
                return retorno;
            }
            catch(Exception ex)
            {
                 throw new Exception("Não foi possível cancelar a medida corporal. Detalhes: " + ex.Message);
            }

        }

        public ListaMedidaCorporal PesquisarMedidaCorporalCodigoNome(int? codigo, string nome)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDAluno", codigo);
                acessoDadosSqlServer.AdicionarParametros("@NomeAluno", nome);

                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspMedidaCorporalPesquisarCodigoAlunoOuNomeAluno");
                foreach (DataRow linha in dataTable.Rows)
                {
                    MedidaCorporal medidaCorporal = new MedidaCorporal();                    

                       medidaCorporal.DataMedida = Convert.ToDateTime(linha["DataMedida"]);
                       medidaCorporal.Ativo = Convert.ToBoolean(linha["Ativo"]);
                  

                 

                    medidaCorporal.Aluno = new Aluno();
                    medidaCorporal.Aluno.Pessoa = new Pessoa()
                    {
                        IDPessoa = Convert.ToInt32(linha["IDPessoaAluno"]),
                        Nome = linha["Nome"].ToString()
                    };


                    listaMedidaCorporal.Add(medidaCorporal);
                }
                return listaMedidaCorporal;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível pesquisar por código do aluno  ou nome. Detalhes: " + ex.Message);
            }
        }

        public ListaMedidaCorporal ListaMedidaCorporalAlunoData(int? codigo, DateTime dataMedida)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDAluno", codigo);
                acessoDadosSqlServer.AdicionarParametros("@DataMedida", dataMedida);
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspMedidaCorporalListaAlunoData");

                foreach (DataRow linha in dataTable.Rows)
                {
                    MedidaCorporal medidaCorporal = new MedidaCorporal()
                    {
                        IDMedidaCorporal = Convert.ToInt32(linha["IDMedidaCorporal"]),
                        DataMedida = Convert.ToDateTime(linha["DataMedida"]),
                        MedidaCm = Convert.ToDecimal(linha["MedidaCm"]),
                        Ativo = Convert.ToBoolean(linha["Ativo"])

                    };

                    medidaCorporal.Aluno = new Aluno();
                    medidaCorporal.Aluno.Pessoa = new Pessoa()
                    {
                        IDPessoa = Convert.ToInt32(linha["IDPessoaAluno"]),
                        Nome = linha["Nome"].ToString()
                    };

                    medidaCorporal.TipoMedidaCorporal = new TipoMedidaCorporal()
                    {
                        IDTipoMedidaCorporal = Convert.ToInt32(linha["IDTipoMedidaCorporal"]),
                        Descricao = linha["Descricao"].ToString()
                    };

                    listaMedidaCorporal.Add(medidaCorporal);

                }
                return listaMedidaCorporal;
            }
            catch(Exception ex)
            {
                throw new Exception("Não foi possível carregar a lista de medidas corporal. Detalhes: " + ex.Message);
            }

        }

       public ListaMedidaCorporal FiltroPorData(int codigoAluno)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@IDAluno", codigoAluno);

            DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspFiltrosRelatorioAvalicaoFisicaPorData");

           foreach(DataRow linha in dataTable.Rows)
           {
               MedidaCorporal medidaCorporal = new MedidaCorporal()
               {
                   DataMedida = Convert.ToDateTime(linha["DataMedida"])
               };

               listaMedidaCorporal.Add(medidaCorporal);
           }
           return listaMedidaCorporal;
        }




    }
}
