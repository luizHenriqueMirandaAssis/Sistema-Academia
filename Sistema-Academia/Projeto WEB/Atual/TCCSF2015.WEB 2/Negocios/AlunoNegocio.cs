using AcessoDados;
using ObjetoTransferencia;
using System;
using System.Data;

namespace Negocios
{
    public class AlunoNegocio : IDisposable
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
        ListaAluno listaAluno = new ListaAluno();

        public void Dispose()
        {
            acessoDadosSqlServer = null;
            listaAluno = null;
        }

        public string Inserir(Aluno aluno)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CEP", aluno.Pessoa.Endereco.CEP);
                acessoDadosSqlServer.AdicionarParametros("@Bairro", aluno.Pessoa.Endereco.Bairro);
                acessoDadosSqlServer.AdicionarParametros("@Rua", aluno.Pessoa.Endereco.Rua);
                acessoDadosSqlServer.AdicionarParametros("@Numero", aluno.Pessoa.Endereco.Numero);
                acessoDadosSqlServer.AdicionarParametros("@Cidade", aluno.Pessoa.Endereco.Cidade);
                acessoDadosSqlServer.AdicionarParametros("@Complemento", aluno.Pessoa.Endereco.Complemento);
                acessoDadosSqlServer.AdicionarParametros("@UF", aluno.Pessoa.Endereco.UF);

                acessoDadosSqlServer.AdicionarParametros("@Nome", aluno.Pessoa.Nome);
                acessoDadosSqlServer.AdicionarParametros("@DataNascimento", aluno.Pessoa.DataNascimento);
                acessoDadosSqlServer.AdicionarParametros("@AtivoAluno", aluno.Pessoa.Ativo);
                acessoDadosSqlServer.AdicionarParametros("@Sexo", aluno.Pessoa.Sexo);
                acessoDadosSqlServer.AdicionarParametros("@RG", aluno.Pessoa.RG);
                acessoDadosSqlServer.AdicionarParametros("@CPF", aluno.Pessoa.CPF);
                acessoDadosSqlServer.AdicionarParametros("@TelefoneResidencial", aluno.Pessoa.TelefoneResidencial);
                acessoDadosSqlServer.AdicionarParametros("@TelefoneCelular", aluno.Pessoa.TelefoneCelular);
                acessoDadosSqlServer.AdicionarParametros("@Email", aluno.Pessoa.Email);
                acessoDadosSqlServer.AdicionarParametros("@Usuario", aluno.Pessoa.Usuario);
                acessoDadosSqlServer.AdicionarParametros("@Senha", aluno.Pessoa.Senha);
                acessoDadosSqlServer.AdicionarParametros("@IDObjetivo", aluno.Objetivo.IDObjetivo);
                acessoDadosSqlServer.AdicionarParametros("@Status", aluno.Status);


                string IDPessoaAluno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspAlunoInserir").ToString();
                return IDPessoaAluno;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Alterar(Aluno aluno)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@IDPessoa", aluno.Pessoa.IDPessoa);
                acessoDadosSqlServer.AdicionarParametros("@IDPessoaAluno", aluno.Pessoa.IDPessoa);
                acessoDadosSqlServer.AdicionarParametros("@CEP", aluno.Pessoa.Endereco.CEP);
                acessoDadosSqlServer.AdicionarParametros("@Bairro", aluno.Pessoa.Endereco.Bairro);
                acessoDadosSqlServer.AdicionarParametros("@Rua", aluno.Pessoa.Endereco.Rua);
                acessoDadosSqlServer.AdicionarParametros("@Numero", aluno.Pessoa.Endereco.Numero);
                acessoDadosSqlServer.AdicionarParametros("@Cidade", aluno.Pessoa.Endereco.Cidade);
                acessoDadosSqlServer.AdicionarParametros("@Complemento", aluno.Pessoa.Endereco.Complemento);
                acessoDadosSqlServer.AdicionarParametros("@UF", aluno.Pessoa.Endereco.UF);

                acessoDadosSqlServer.AdicionarParametros("@Nome", aluno.Pessoa.Nome);
                acessoDadosSqlServer.AdicionarParametros("@DataNascimento", aluno.Pessoa.DataNascimento);
                acessoDadosSqlServer.AdicionarParametros("@AtivoAluno", aluno.Pessoa.Ativo);
                acessoDadosSqlServer.AdicionarParametros("@Sexo", aluno.Pessoa.Sexo);
                acessoDadosSqlServer.AdicionarParametros("@RG", aluno.Pessoa.RG);
                acessoDadosSqlServer.AdicionarParametros("@CPF", aluno.Pessoa.CPF);
                acessoDadosSqlServer.AdicionarParametros("@TelefoneResidencial", aluno.Pessoa.TelefoneResidencial);
                acessoDadosSqlServer.AdicionarParametros("@TelefoneCelular", aluno.Pessoa.TelefoneCelular);
                acessoDadosSqlServer.AdicionarParametros("@Email", aluno.Pessoa.Email);
                acessoDadosSqlServer.AdicionarParametros("@Usuario", aluno.Pessoa.Usuario);
                acessoDadosSqlServer.AdicionarParametros("@Senha", aluno.Pessoa.Senha);
                acessoDadosSqlServer.AdicionarParametros("@IDObjetivo", aluno.Objetivo.IDObjetivo);
                acessoDadosSqlServer.AdicionarParametros("@Status", aluno.Status);

                string IDPessoaAluno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspAlunoAlterar").ToString();
                return IDPessoaAluno;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public ListaAluno PesquisarAlunoNomeOuCodigo(int? codigo, string nome)
        {
            try
            {

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDAluno", codigo);
                acessoDadosSqlServer.AdicionarParametros("@NomeAluno", nome);
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspAlunoPesquisarNomeOuCodigo");

                foreach (DataRow linha in dataTable.Rows)
                {
                    Aluno aluno = new Aluno()
                    {
                        Status = linha["Status"].ToString()
                    };

                    aluno.Pessoa = new Pessoa
                    {
                        IDPessoa = Convert.ToInt32(linha["IDPessoaAluno"]),
                        Nome = linha["Nome"].ToString(),
                        Sexo = Convert.ToBoolean(linha["Sexo"]),
                        DataNascimento = Convert.ToDateTime(linha["DataNascimento"]),
                        RG = linha["RG"].ToString(),
                        CPF = linha["CPF"].ToString(),
                        TelefoneCelular = linha["TelefoneCelular"].ToString(),
                        TelefoneResidencial = linha["TelefoneResidencial"].ToString(),
                        Ativo = Convert.ToBoolean(linha["Ativo"]),
                        Email = linha["Email"].ToString(),
                        Usuario = linha["Usuario"].ToString(),
                        Senha = linha["Senha"].ToString()

                    };

                    aluno.Pessoa.Endereco = new Endereco()
                    {
                        CEP = linha["CEP"].ToString(),
                        Rua = linha["Rua"].ToString(),
                        Numero = Convert.ToInt32(linha["Numero"]),
                        Complemento = linha["Complemento"].ToString(),
                        Bairro = linha["Bairro"].ToString(),
                        Cidade = linha["Cidade"].ToString(),
                        UF = linha["UF"].ToString()

                    };

                    aluno.Objetivo = new Objetivo()
                    {
                        Descricao = linha["Objetivo"].ToString(),
                        IDObjetivo = Convert.ToInt32(linha["IDObjetivo"])
                    };

                    listaAluno.Add(aluno);


                }

                return listaAluno;
            }
            catch (Exception ex)
            {
                throw new Exception(" Não foi possível consultar por código ou nome. Detalhes: " + ex.Message);
            }
        }

        public Aluno LoginAluno(Aluno aluno)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@Usuario", aluno.Pessoa.Usuario);
            acessoDadosSqlServer.AdicionarParametros("@Senha", aluno.Pessoa.Senha);

            DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "upsLoginAluno");

            Aluno alunoLogin = new Aluno();
            alunoLogin.Pessoa = new Pessoa();
            foreach (DataRow linha in dataTable.Rows)
            {
                Aluno AlunoLogado = new Aluno();
                AlunoLogado.Pessoa = new Pessoa()
                {
                    IDPessoa = Convert.ToInt32(linha["IDPessoaAluno"]),
                    Nome = linha["Nome"].ToString()
                };

                alunoLogin = AlunoLogado;
            }
            return alunoLogin;
        }
    }
}

