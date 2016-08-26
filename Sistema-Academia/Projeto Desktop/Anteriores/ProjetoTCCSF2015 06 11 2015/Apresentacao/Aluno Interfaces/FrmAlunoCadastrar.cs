using Negocios;
using ObjetoTransferencia;
using System;
using System.Windows.Forms;


namespace Apresentacao
{
    public partial class FrmAlunoCadastrar : Form
    {
        AcaoNaTela acaoNaTelaInformada;
        public FrmAlunoCadastrar(AcaoNaTela acaoNaTela, Aluno aluno)
        {
            InitializeComponent();
            acaoNaTelaInformada = acaoNaTela;
            ObjetivoNegocio objetivoNegocio = new ObjetivoNegocio();
            
            
             ListaObjetivo listaObjetivo = objetivoNegocio.CarregarCampoDescricao();
             cmbCadastrarDescricao.DataSource = listaObjetivo;
             cmbCadastrarDescricao.ValueMember = "IDObjetivo";
             cmbCadastrarDescricao.DisplayMember = "Descricao";



            if (acaoNaTelaInformada == AcaoNaTela.Inserir)
            {
                this.Text = "Cadastrar Aluno";
                this.lblAlunoCadastrarAlunoTitulo.Text = "Cadastrar Aluno";
                this.btnAlunoCadastrar.Text = "Salvar";
                this.txtCadastrarNome.Select();
                this.cmbCadastrarDescricao.SelectedItem = null;
                
            }

            else if (acaoNaTelaInformada == AcaoNaTela.Alterar)
            {

                this.Text = "Alterar Aluno";
                this.pbxCadastrarAluno.Image = global::Apresentacao.Properties.Resources._1440662980_edit_user;
                    
                this.lblAlunoCadastrarAlunoTitulo.Text = "Alterar Aluno";
                this.btnAlunoCadastrar.Text = "Salvar";
                this.txtCadastrarCodigo.Text = aluno.Pessoa.IDPessoa.ToString();
                this.txtCadastrarNome.Text = aluno.Pessoa.Nome;
                this.txtCadastrarRG.Text = aluno.Pessoa.RG;
                this.mskCadastrarCPF.Text = aluno.Pessoa.CPF;
                this.rbtCadastrarSexoMasculino.Checked = aluno.Pessoa.Sexo == true ? true : false;
                this.rbtCadastrarSexoFeminino.Checked = aluno.Pessoa.Sexo == false ? true : false;
                this.rbtCadastrarAtivoSim.Checked = aluno.Pessoa.Ativo == true ? true : false;
                this.rbtCadastrarAtivoNao.Checked = aluno.Pessoa.Ativo == false ? true : false;
                this.dtpCadastrarDataNascimento.Value = aluno.Pessoa.DataNascimento;
                this.mskCadastrarTelefoneCelular.Text = aluno.Pessoa.TelefoneCelular;
                this.mskCadastrarTelefoneResidencial.Text = aluno.Pessoa.TelefoneResidencial;
                this.txtCadastrarEmail.Text = aluno.Pessoa.Email;
                this.txtCadastrarUsuario.Text = aluno.Pessoa.Usuario;
                this.cmbCadastrarUF.Text = aluno.Pessoa.Endereco.UF;
                this.cmbCadastrarDescricao.Text = aluno.Objetivo.Descricao;
                this.txtCadastrarStatus.Text = aluno.Status;
                this.txtCadastrarSenha.Text = aluno.Pessoa.Senha;
 
                this.txtCadastrarCEP.Text = aluno.Pessoa.Endereco.CEP;
                this.txtCadastrarRua.Text = aluno.Pessoa.Endereco.Rua;
                this.txtCadastrarNumero.Text = aluno.Pessoa.Endereco.Numero.ToString();
                this.txtCadastrarComplemento.Text = aluno.Pessoa.Endereco.Complemento;
                this.txtCadastrarBairro.Text = aluno.Pessoa.Endereco.Bairro;
                this.txtCadastrarCidade.Text = aluno.Pessoa.Endereco.Cidade;

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

        private void btnAlunoCadastrar_Click(object sender, EventArgs e)
        {
            using (AlunoNegocio alunoNegocio = new AlunoNegocio())
            {
                ValidacaoInterfaces validar = new ValidacaoInterfaces();
                if (validar.validarCampoCadastrar(this.grpIdentificacao.Controls) == true)
                {
                    return;
                }             
                else if(validar.ValidarRadioButton(this.rbtCadastrarSexoMasculino, this.rbtCadastrarSexoFeminino) ==true)
                {
                    return;
                }
                else if (validar.ValidarRadioButton(this.rbtCadastrarAtivoSim, rbtCadastrarAtivoNao) == true)
                {
                    return;
                }
                else if (validar.validarCampoCadastrar(this.grpLocalizacao.Controls) == true)
                {
                    return;
                }
                else if (validar.validarCampoCadastrar(this.grpContato.Controls) == true)
                {
                    return;
                }
                else if (validar.validarCampoCadastrar(this.grpObjetivo.Controls) == true)
                {
                    return;
                }
                else if (validar.validarCampoCadastrar(this.grpLogin.Controls) == true)
                {
                    return;
                }
                


                if (acaoNaTelaInformada == AcaoNaTela.Inserir)
                {
                   
                    Aluno alunoInserir = new Aluno()
                    {
                        Status = this.txtCadastrarStatus.Text,
                       
                    };
                    alunoInserir.Pessoa = new Pessoa()
                    {                       
                        Nome = this.txtCadastrarNome.Text,
                        RG = this.txtCadastrarRG.Text,
                        CPF = this.mskCadastrarCPF.Text,
                        DataNascimento = this.dtpCadastrarDataNascimento.Value,
                        Ativo = this.rbtCadastrarAtivoSim.Checked == true ? true : false,
                        Sexo = this.rbtCadastrarSexoMasculino.Checked == true ? true : false,
                        Email = this.txtCadastrarEmail.Text,
                        Usuario = this.txtCadastrarUsuario.Text,
                        Senha = this.txtCadastrarSenha.Text,
                        TelefoneCelular = this.mskCadastrarTelefoneCelular.Text,
                        TelefoneResidencial = this.mskCadastrarTelefoneResidencial.Text
                    };

                    alunoInserir.Pessoa.Endereco = new Endereco()
                    {
                        CEP = this.txtCadastrarCEP.Text,
                        Rua = this.txtCadastrarRua.Text,
                        Numero = Convert.ToInt32(this.txtCadastrarNumero.Text),
                        Complemento = this.txtCadastrarComplemento.Text,
                        Bairro = this.txtCadastrarBairro.Text,
                        Cidade = this.txtCadastrarCidade.Text,
                        UF = this.cmbCadastrarUF.Text
                    };

                    alunoInserir.Objetivo = new Objetivo()
                    {
                        IDObjetivo = Convert.ToInt32(this.cmbCadastrarDescricao.SelectedValue)
                    };

                    string retorno = alunoNegocio.Inserir(alunoInserir);

                    try
                    {
                        int codigo = Convert.ToInt32(retorno);
                        MessageBox.Show("Aluno cadastrado com sucesso. Código: " + codigo.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível cadastrar o aluno. Detalhes: " +retorno, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                }
                else if (acaoNaTelaInformada == AcaoNaTela.Alterar)
                {


                    Aluno alunoAlterar = new Aluno()
                    {
                        Status = this.txtCadastrarStatus.Text
                    };
                    alunoAlterar.Pessoa = new Pessoa()
                    {
                        IDPessoa = Convert.ToInt32(this.txtCadastrarCodigo.Text),
                        Nome = this.txtCadastrarNome.Text,
                        RG = this.txtCadastrarRG.Text,
                        CPF = this.mskCadastrarCPF.Text,
                        DataNascimento = this.dtpCadastrarDataNascimento.Value,
                        Ativo = this.rbtCadastrarAtivoSim.Checked == true ? true : false,
                        Sexo = this.rbtCadastrarSexoMasculino.Checked == true ? true : false,
                        Email = this.txtCadastrarEmail.Text,
                        Usuario = this.txtCadastrarUsuario.Text,
                        Senha = this.txtCadastrarSenha.Text,
                        TelefoneCelular = this.mskCadastrarTelefoneCelular.Text,
                        TelefoneResidencial = this.mskCadastrarTelefoneResidencial.Text
                    };

                    alunoAlterar.Pessoa.Endereco = new Endereco()
                    {
                        CEP = this.txtCadastrarCEP.Text,
                        Rua = this.txtCadastrarRua.Text,
                        Numero = Convert.ToInt32(this.txtCadastrarNumero.Text),
                        Complemento = this.txtCadastrarComplemento.Text,
                        Bairro = this.txtCadastrarBairro.Text,
                        Cidade = this.txtCadastrarCidade.Text,
                        UF = this.cmbCadastrarUF.Text
                    };

                    alunoAlterar.Objetivo = new Objetivo()
                    {
                        IDObjetivo = Convert.ToInt32(this.cmbCadastrarDescricao.SelectedValue)
                    };

                    string retorno = alunoNegocio.Alterar(alunoAlterar);
                    try
                    {
                        int codigo = Convert.ToInt32(retorno);
                        MessageBox.Show("Aluno alterado com sucesso. Código: " + codigo.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível alterar o aluno. Detalhes: " + retorno, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                }

            }

        }

        private void FrmAlunoCadastrar_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.btnAlunoCancelar.PerformClick();
            }
            if(e.KeyCode == Keys.F1)
            {
                btnAlunoCadastrar.PerformClick();
            }
            if (e.KeyCode == Keys.F2)
            {
                btnAlunoCancelar.PerformClick();
            }
            
        }

    }
}
