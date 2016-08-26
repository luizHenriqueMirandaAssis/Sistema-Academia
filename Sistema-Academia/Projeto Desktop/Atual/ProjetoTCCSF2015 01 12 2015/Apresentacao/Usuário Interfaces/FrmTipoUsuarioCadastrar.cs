using Negocios;
using ObjetoTransferencia;
using System;
using System.Windows.Forms;

namespace Apresentacao.Usuário_Interfaces
{
    public partial class FrmTipoUsuarioCadastrar : Form
    {
        AcaoNaTela acaoNaTelaInformada;

        public FrmTipoUsuarioCadastrar(AcaoNaTela acaoNatela, TipoUsuario tipoUsuario)
        {
            acaoNaTelaInformada = acaoNatela;
            InitializeComponent();

            if(acaoNaTelaInformada == AcaoNaTela.Inserir)
            {
                this.Text = "Cadastrar tipo de usuário";
                this.lblTipoUsuarioCadastrarTitulo.Text = "Cadastrar Tipo De Usuário";
                this.pbxCadastrarTipoUsuario.Image = global::Apresentacao.Properties.Resources._1440663403_add_property;
                this.btnTipoUsuarioCadastrar.Text = "Salvar";
            }
            else if (acaoNaTelaInformada == AcaoNaTela.Alterar)
            {
                this.Text = "Alterar tipo de usuário";
                this.lblTipoUsuarioCadastrarTitulo.Text = "Alterar Tipo De Usuário";
                this.pbxCadastrarTipoUsuario.Image = global::Apresentacao.Properties.Resources._1440663068_edit_property;
                this.btnTipoUsuarioCadastrar.Text = "Salvar";
                this.txtCadastrarDescricao.Text = tipoUsuario.Descricao;
                this.txtCadastrarCodigo.Text = tipoUsuario.IDTipoUsuario.ToString();
                this.rbtCadastrarAtivoSim.Checked = tipoUsuario.Ativo == true ? true : false;
                this.rbtCadastrarAtivoNao.Checked = tipoUsuario.Ativo == false ? true : false;
            }

        }

        private void btnTipoUsuarioCadastrar_Click(object sender, EventArgs e)
        {
            
            using (TipoUsuarioNegocio tipoUsuarioNegocio = new TipoUsuarioNegocio())
            {
                ValidacaoInterfaces validarInterfaces = new ValidacaoInterfaces();
                if (validarInterfaces.validarCampoCadastrar(grpTipoUsuario.Controls) == true)
                {
                    return;
                }
                else if(validarInterfaces.ValidarRadioButton(this.rbtCadastrarAtivoSim, this.rbtCadastrarAtivoNao) == true)
                {
                    return;
                }

                if (acaoNaTelaInformada == AcaoNaTela.Inserir)
                {
                    TipoUsuario tipoUsuarioInserir = new TipoUsuario();
                    tipoUsuarioInserir.Descricao = txtCadastrarDescricao.Text;
                    tipoUsuarioInserir.Ativo = rbtCadastrarAtivoSim.Checked == true ? true : false;

                    string retorno = tipoUsuarioNegocio.InserirTipoUsuario(tipoUsuarioInserir);

                    try
                    {
                        int codigo = Convert.ToInt32(retorno);
                        MessageBox.Show("Tipo de usuário cadastrado com sucesso. Código: " + codigo.ToString());
                        this.DialogResult = System.Windows.Forms.DialogResult.Yes;

                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível cadastrar o tipo de usuário. Detlhes: " + retorno, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }

                }
                else if (acaoNaTelaInformada == AcaoNaTela.Alterar)
                {
                    
                   TipoUsuario  tipoUsuarioAlterar = new TipoUsuario()                  
                    {
                    IDTipoUsuario = Convert.ToInt32(txtCadastrarCodigo.Text),
                    Descricao = txtCadastrarDescricao.Text,
                    Ativo = rbtCadastrarAtivoSim.Checked == true? true: false
                    
                    };

                   string retorno = tipoUsuarioNegocio.AlterarTipoUsuario(tipoUsuarioAlterar);

                    try
                    {
                        int codigo = Convert.ToInt32(retorno);
                        MessageBox.Show("Tipo de usuário alterado com sucesso. Código: "+ codigo.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível alterar o tipo de usuário. Detalhes: " + retorno, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void btnTipoUsuarioCancelar_Click(object sender, EventArgs e)
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

        private void FrmTipoUsuarioCadastrar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            this.btnTipoUsuarioCancelar.PerformClick();
            if (e.KeyCode == Keys.F1)
                this.btnTipoUsuarioCadastrar.PerformClick();
            if (e.KeyCode == Keys.F2)
                this.btnTipoUsuarioCancelar.PerformClick();
        }
    }
}
