using AcessoDados;
using ObjetoTransferencia;
using System;
using System.Data;

namespace Negocios
{
    public class UsuarioNegocio: IDisposable
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
        ListaUsuario listaUsuario = new ListaUsuario();

        public void Dispose()
        {
            acessoDadosSqlServer = null;
            listaUsuario = null;
        }

        public string Inserir(Usuario usuario)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CEP", usuario.Pessoa.Endereco.CEP);
                acessoDadosSqlServer.AdicionarParametros("@Bairro", usuario.Pessoa.Endereco.Bairro);
                acessoDadosSqlServer.AdicionarParametros("@Rua", usuario.Pessoa.Endereco.Rua);
                acessoDadosSqlServer.AdicionarParametros("@Numero", usuario.Pessoa.Endereco.Numero);
                acessoDadosSqlServer.AdicionarParametros("@Cidade", usuario.Pessoa.Endereco.Cidade);
                acessoDadosSqlServer.AdicionarParametros("@Complemento", usuario.Pessoa.Endereco.Complemento);
                acessoDadosSqlServer.AdicionarParametros("@UF", usuario.Pessoa.Endereco.UF);

                acessoDadosSqlServer.AdicionarParametros("@Nome", usuario.Pessoa.Nome);
                acessoDadosSqlServer.AdicionarParametros("@DataNascimento", usuario.Pessoa.DataNascimento);
                acessoDadosSqlServer.AdicionarParametros("@Ativo", usuario.Pessoa.Ativo);
                acessoDadosSqlServer.AdicionarParametros("@Sexo", usuario.Pessoa.Sexo);
                acessoDadosSqlServer.AdicionarParametros("@RG", usuario.Pessoa.RG);
                acessoDadosSqlServer.AdicionarParametros("@CPF", usuario.Pessoa.CPF);
                acessoDadosSqlServer.AdicionarParametros("@TelefoneResidencial", usuario.Pessoa.TelefoneResidencial);
                acessoDadosSqlServer.AdicionarParametros("@TelefoneCelular", usuario.Pessoa.TelefoneCelular);
                acessoDadosSqlServer.AdicionarParametros("@Email", usuario.Pessoa.Email);
                acessoDadosSqlServer.AdicionarParametros("@Usuario", usuario.Pessoa.Usuario);
                acessoDadosSqlServer.AdicionarParametros("@Senha", usuario.Pessoa.Senha);
                    
                acessoDadosSqlServer.AdicionarParametros("@IDTipoUsuario", usuario.TipoUsuario.IDTipoUsuario);
                string IDPessoaUsuario = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspUsuarioInserir").ToString();
                return IDPessoaUsuario;
           }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Alterar(Usuario usuario)
        {
            try 
            {
                acessoDadosSqlServer.LimparParametros();
             
                acessoDadosSqlServer.AdicionarParametros("@IDPessoa", usuario.Pessoa.IDPessoa);
                acessoDadosSqlServer.AdicionarParametros("@IDPessoaUsuario", usuario.Pessoa.IDPessoa);

                acessoDadosSqlServer.AdicionarParametros("@CEP", usuario.Pessoa.Endereco.CEP);
                acessoDadosSqlServer.AdicionarParametros("@Bairro", usuario.Pessoa.Endereco.Bairro);
                acessoDadosSqlServer.AdicionarParametros("@Rua", usuario.Pessoa.Endereco.Rua);
                acessoDadosSqlServer.AdicionarParametros("@Numero", usuario.Pessoa.Endereco.Numero);
                acessoDadosSqlServer.AdicionarParametros("@Cidade", usuario.Pessoa.Endereco.Cidade);
                acessoDadosSqlServer.AdicionarParametros("@Complemento", usuario.Pessoa.Endereco.Complemento);
                acessoDadosSqlServer.AdicionarParametros("@UF", usuario.Pessoa.Endereco.UF);

                acessoDadosSqlServer.AdicionarParametros("@Nome", usuario.Pessoa.Nome);
                acessoDadosSqlServer.AdicionarParametros("@DataNascimento", usuario.Pessoa.DataNascimento);
                acessoDadosSqlServer.AdicionarParametros("@Ativo", usuario.Pessoa.Ativo);
                acessoDadosSqlServer.AdicionarParametros("@Sexo", usuario.Pessoa.Sexo);
                acessoDadosSqlServer.AdicionarParametros("@RG", usuario.Pessoa.RG);
                acessoDadosSqlServer.AdicionarParametros("@CPF", usuario.Pessoa.CPF);
                acessoDadosSqlServer.AdicionarParametros("@TelefoneResidencial", usuario.Pessoa.TelefoneResidencial);
                acessoDadosSqlServer.AdicionarParametros("@TelefoneCelular", usuario.Pessoa.TelefoneCelular);
                acessoDadosSqlServer.AdicionarParametros("@Email", usuario.Pessoa.Email);
                acessoDadosSqlServer.AdicionarParametros("@Usuario", usuario.Pessoa.Usuario);
                acessoDadosSqlServer.AdicionarParametros("@Senha", usuario.Pessoa.Senha);

                acessoDadosSqlServer.AdicionarParametros("@IDTipoUsuario", usuario.TipoUsuario.IDTipoUsuario);
                string IDPessoaUsuario = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspUsuarioAlterar").ToString();
                return IDPessoaUsuario;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public ListaUsuario Consultar(int? codigo, string nome)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Nome", nome);
                acessoDadosSqlServer.AdicionarParametros("@IDUsuario", codigo);
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspUsuarioPesquisarNomeOuCodigo");

                foreach (DataRow linha in dataTable.Rows)
                {
                    Usuario usuario = new Usuario();
                    usuario.Pessoa = new Pessoa()
                    {
                        IDPessoa = Convert.ToInt32(linha["IDPessoaUsuario"]),
                        Ativo = Convert.ToBoolean(linha["Ativo"]),
                        CPF = linha["CPF"].ToString(),
                        DataNascimento = Convert.ToDateTime(linha["DataNascimento"]),
                        Email = linha["Email"].ToString(),
                        Nome = linha["Nome"].ToString(),
                        RG = linha["RG"].ToString(),
                        Usuario = linha["Usuario"].ToString(),                      
                        TelefoneCelular = linha["TelefoneCelular"].ToString(),
                        TelefoneResidencial = linha["TelefoneResidencial"].ToString(),
                        Sexo = Convert.ToBoolean(linha["Sexo"])
                        
                    };

                    usuario.Pessoa.Endereco = new Endereco()
                    {
                        Bairro = linha["Bairro"].ToString(),
                        CEP = linha["CEP"].ToString(),
                        Cidade = linha["Cidade"].ToString(),
                        Complemento = linha["Complemento"].ToString(),
                        IDEndereco = Convert.ToInt32(linha["IDEndereco"]),
                        Numero = Convert.ToInt32(linha["Numero"]),
                        Rua = linha["Rua"].ToString(),
                        UF = linha["UF"].ToString()
                    };

                    usuario.TipoUsuario = new TipoUsuario()
                    {
                       IDTipoUsuario = Convert.ToInt32(linha["IDTipoUsuario"]),
                        Descricao = linha["Descricao"].ToString()
                    };

                    listaUsuario.Add(usuario);
                }
                return listaUsuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar por código ou nome. Detalhes: " + ex.Message);
            }
       }
        public ListaUsuario Login (string usuario, string senha)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@Usuario", usuario);
            acessoDadosSqlServer.AdicionarParametros("@Senha", senha);

            DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "upsLoginUsuario");
            foreach(DataRow linha in dataTable.Rows)
            {
                Usuario usuarioLogin = new Usuario();
                usuarioLogin.Pessoa = new Pessoa()
                {
                    IDPessoa = Convert.ToInt32(linha["IDPessoaUsuario"]),
                    Nome = linha["Nome"].ToString(),
                    CPF = linha["CPF"].ToString(),
                    TelefoneCelular = linha["TelefoneCelular"].ToString(),
                    Sexo = Convert.ToBoolean(linha["Sexo"]),
                    Ativo = Convert.ToBoolean(linha["Ativo"])
                };
                usuarioLogin.TipoUsuario = new TipoUsuario()
                {
                    IDTipoUsuario = Convert.ToInt32(linha["IDTipoUsuario"]),
                    Descricao = linha["Descricao"].ToString()
                };

                listaUsuario.Add(usuarioLogin);
            }
            return listaUsuario;
        }

    }
}
