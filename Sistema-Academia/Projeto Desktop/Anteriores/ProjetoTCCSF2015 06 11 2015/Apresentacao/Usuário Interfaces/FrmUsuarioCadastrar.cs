using Negocios;
using ObjetoTransferencia;
using System;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmUsuarioCadastrar : Form
    {
        AcaoNaTela acaoNaTelaInformada;
        public FrmUsuarioCadastrar(AcaoNaTela acaoNaTela, Usuario usuario)
        {
            acaoNaTelaInformada = acaoNaTela;
            InitializeComponent();
            TipoUsuarioNegocio tipoUsuarioNegocio = new TipoUsuarioNegocio();           
            ListaTipoUsuario listaTipoUsuaro = tipoUsuarioNegocio.CarregarCampoDescricao();
            this.cmbCadastrarTipoUsuario.DataSource = listaTipoUsuaro;
            this.cmbCadastrarTipoUsuario.ValueMember = "IDTipoUsuario";
            this.cmbCadastrarTipoUsuario.DisplayMember = "Descricao";
            this.txtCadastrarNome.Select();
           

            if (acaoNaTelaInformada == AcaoNaTela.Inserir)
            {
                this.Text = "Cadastrar usuário";
                this.lblUsuarioCadastrarUsuarioTitulo.Text = "Cadastrar Usuário";
                this.btnUsuarioCadastrar.Text = "Salvar";
                this.pbxUsuarioCadastrar.Image = global::Apresentacao.Properties.Resources._1440663436_add_user;
                this.cmbCadastrarTipoUsuario.SelectedItem = null;

            }
            else if (acaoNaTelaInformada == AcaoNaTela.Alterar)
            {
                this.Text = "Alterar usuário";
                this.lblUsuarioCadastrarUsuarioTitulo.Text = "Alterar Usuário";
                this.btnUsuarioCadastrar.Text = "Salvar";
                this.pbxUsuarioCadastrar.Image = global::Apresentacao.Properties.Resources._1440662980_edit_user;

                this.txtCadastrarCodigo.Text = Convert.ToString(usuario.Pessoa.IDPessoa);
                this.txtCadastrarNome.Text = usuario.Pessoa.Nome;
                this.txtCadastrarRG.Text = usuario.Pessoa.RG;
                this.mskCadastrarCPF.Text = usuario.Pessoa.CPF;
                this.rbtCadastrarAtivoSim.Checked =  usuario.Pessoa.Ativo == true? true: false;
                this.rbtCadastrarAtivoNao.Checked = usuario.Pessoa.Ativo == false ? true : false;
                this.rbtCadastrarSexoMasculino.Checked = usuario.Pessoa.Sexo == true ? true : false;
                this.rbtCadastrarSexoFeminino.Checked = usuario.Pessoa.Sexo == false ? true : false;
                this.dtpCadastrarDataNascimento.Value = usuario.Pessoa.DataNascimento;
                this.cmbCadastrarTipoUsuario.Text = usuario.TipoUsuario.Descricao;
                this.txtCadastrarCEP.Text = usuario.Pessoa.Endereco.CEP;
                this.txtCadastrarRua.Text = usuario.Pessoa.Endereco.Rua;
                this.txtCadastrarNumero.Text =usuario.Pessoa.Endereco.Numero.ToString();
                this.txtCadastrarComplemento.Text = usuario.Pessoa.Endereco.Complemento;
                this.txtCadastrarBairro.Text = usuario.Pessoa.Endereco.Bairro;
                this.txtCadastrarCidade.Text = usuario.Pessoa.Endereco.Cidade;
                this.cmbCadastrarUF.Text = usuario.Pessoa.Endereco.UF;
                this.mskCadastrarTelefoneCelular.Text = usuario.Pessoa.TelefoneCelular;
                this.mskCadastrarTelefoneResidencial.Text = usuario.Pessoa.TelefoneResidencial;
                this.txtCadastrarEmail.Text = usuario.Pessoa.Email;
                this.txtCadastrarUsuario.Text = usuario.Pessoa.Usuario;
                this.txtCadastrarSenha.Text = usuario.Pessoa.Usuario;
               


            }



        }

        private void btnAlunoCadastrar_Click(object sender, EventArgs e)
        {          
            using (UsuarioNegocio usuarioNegocio = new UsuarioNegocio())
               {
                 ValidacaoInterfaces validar = new ValidacaoInterfaces();
               
                   // validações do cadastro
                    if (validar.validarCampoCadastrar(this.grpIdentificacao.Controls) == true)
                    {
                        return;
                    }
                    else if(validar.ValidarRadioButton(this.rbtCadastrarAtivoSim, this.rbtCadastrarAtivoNao) == true)
                    {
                        return;
                    }
                    else if( validar.ValidarRadioButton(this.rbtCadastrarSexoMasculino, this.rbtCadastrarSexoFeminino) == true)
                    {
                        return;
                    }
                    else if(validar.validarCampoCadastrar(this.grpLocalizacao.Controls) ==true)
                    {
                        return;
                    }
                    else if (validar.validarCampoCadastrar(this.grpContato.Controls) == true)
                    {
                        return;
                    }
                   
                    else if(validar.validarCampoCadastrar(this.grpLogin.Controls) == true)
                    {
                        return;
                    }
                    
             
                  

                if(acaoNaTelaInformada == AcaoNaTela.Inserir)
                {
                    Usuario usuarioInserir = new Usuario();
                    usuarioInserir.Pessoa = new Pessoa()
                    {
                        Nome = this.txtCadastrarNome.Text,
                        RG = this.txtCadastrarRG.Text,
                        CPF = this.mskCadastrarCPF.Text,
                        DataNascimento = this.dtpCadastrarDataNascimento.Value,
                        Ativo = this.rbtCadastrarAtivoSim.Checked == true? true: false,
                        Sexo =  this.rbtCadastrarSexoMasculino.Checked == true? true: false,
                        TelefoneCelular = this.mskCadastrarTelefoneCelular.Text,
                        TelefoneResidencial = this.mskCadastrarTelefoneResidencial.Text,
                        Email = this.txtCadastrarEmail.Text,
                        Usuario = this.txtCadastrarUsuario.Text,
                        Senha = this.txtCadastrarSenha.Text
                    };
                    usuarioInserir.Pessoa.Endereco = new Endereco()
                    {
                        CEP = this.txtCadastrarCEP.Text,
                        Rua = this.txtCadastrarRua.Text,
                        Numero = Convert.ToInt32(this.txtCadastrarNumero.Text),
                        Complemento = this.txtCadastrarComplemento.Text,
                        Bairro = this.txtCadastrarBairro.Text,
                        Cidade = this.txtCadastrarCidade.Text,
                        UF = this.cmbCadastrarUF.Text
                    };

                    usuarioInserir.TipoUsuario = new TipoUsuario()
                    {
                        IDTipoUsuario = Convert.ToInt32(this.cmbCadastrarTipoUsuario.SelectedValue)
                    };
                    string retorno = usuarioNegocio.Inserir(usuarioInserir);
                    try
                    {                      
                        int codigo = Convert.ToInt32(retorno);
                        MessageBox.Show("Usuário cadastrado com sucesso. Código: " +codigo.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.Yes;
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível cadastrar usuário. Detalhes: " + retorno, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else if(acaoNaTelaInformada == AcaoNaTela.Alterar)
                {
                    Usuario usuarioAlterar = new Usuario();
                    usuarioAlterar.Pessoa = new Pessoa()
                    {
                        IDPessoa = Convert.ToInt32(this.txtCadastrarCodigo.Text),
                        Nome = this.txtCadastrarNome.Text,
                        RG = this.txtCadastrarRG.Text,
                        CPF = this.mskCadastrarCPF.Text,
                        DataNascimento = this.dtpCadastrarDataNascimento.Value,
                        Ativo = this.rbtCadastrarAtivoSim.Checked == true? true: false,
                        Sexo = this.rbtCadastrarSexoMasculino.Checked == true? true: false,
                        TelefoneCelular = this.mskCadastrarTelefoneCelular.Text,
                        TelefoneResidencial = this.mskCadastrarTelefoneResidencial.Text,
                        Email = this.txtCadastrarEmail.Text,
                        Usuario = this.txtCadastrarUsuario.Text,
                        Senha = this.txtCadastrarSenha.Text
                    };
                    usuarioAlterar.Pessoa.Endereco = new Endereco()
                    {
                        
                        CEP = this.txtCadastrarCEP.Text,
                        Rua = this.txtCadastrarRua.Text,
                        Numero = Convert.ToInt32(this.txtCadastrarNumero.Text),
                        Complemento = this.txtCadastrarComplemento.Text,
                        Bairro = this.txtCadastrarBairro.Text,
                        Cidade = this.txtCadastrarCidade.Text,
                        UF = this.cmbCadastrarUF.Text
                    };

                    usuarioAlterar.TipoUsuario = new TipoUsuario()
                    {
                        IDTipoUsuario = Convert.ToInt32(this.cmbCadastrarTipoUsuario.SelectedValue)
                    };

                    string retorno = usuarioNegocio.Alterar(usuarioAlterar);
                    try
                    {
                        int codigo = Convert.ToInt32(retorno);
                        MessageBox.Show("Usuário alterado com sucesso. Código: " + codigo.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.Yes;

                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível alterar o usuário. Detalhes: " + retorno, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            
           
            }
        }

        private void btnAlunoCancelar_Click(object sender, EventArgs e)
        {
            if (acaoNaTelaInformada == AcaoNaTela.Inserir)
            {
                if (MessageBox.Show("Deseja realmente sair do cadastro", "Saindo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.No;
                }
            }
            else if (acaoNaTelaInformada == AcaoNaTela.Alterar)
            {
                if (MessageBox.Show("Deseja realmente sair da alteração", "Saindo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.No;
                }
            }
        }

        private void FrmUsuarioCadastrar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            this.btnUsuarioCancelar.PerformClick();
            if (e.KeyCode == Keys.F1)
                this.btnUsuarioCadastrar.PerformClick();
            if (e.KeyCode == Keys.F2)
                this.btnUsuarioCancelar.PerformClick();
        }
    }
}
