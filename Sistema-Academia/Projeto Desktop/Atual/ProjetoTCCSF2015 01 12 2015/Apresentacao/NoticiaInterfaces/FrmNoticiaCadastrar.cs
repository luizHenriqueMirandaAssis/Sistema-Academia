using Negocios;
using ObjetoTransferencia;
using System;
using System.Windows.Forms;

namespace Apresentacao.NoticiaInterfaces
{
    public partial class FrmNoticiaCadastrar : Form
    {
        AcaoNaTela acaoNaTelaInformada;
        public FrmNoticiaCadastrar(AcaoNaTela acaoNaTela, Noticia noticia)
        {
            acaoNaTelaInformada = acaoNaTela;
            InitializeComponent();

            if(acaoNaTelaInformada == AcaoNaTela.Inserir)
            {
                this.Text = "Cadastrar Notícia";
                this.lblNoticiaCadastrarTitulo.Text = "Cadastrar Notícia";
                this.btnNoticiaCadastrar.Text = "Salvar";
                this.pbxCadastrarNoticia.Image = global::Apresentacao.Properties.Resources._1440663403_add_property;
            }
            else if(acaoNaTelaInformada == AcaoNaTela.Alterar)
            {
                this.Text = "Alterar Notícia";
                this.lblNoticiaCadastrarTitulo.Text = "Alterar Notícia";
                this.btnNoticiaCadastrar.Text = "Salvar";
                this.pbxCadastrarNoticia.Image = global::Apresentacao.Properties.Resources._1440663068_edit_property;
                this.txtCadastrarCodigo.Text = noticia.IDNoticia.ToString();
                this.txtCadastrarTitulo.Text = noticia.Titulo;
                this.rbtCadastrarAtivoSim.Checked = noticia.Ativo == true ? true : false;
                this.rbtCadastrarAtivoNao.Checked = noticia.Ativo == false ? true : false;
                this.rckCadastrarDescricao.Text = noticia.Descricao;
            }


        }

        private void btnNoticiaCadastrar_Click(object sender, EventArgs e)
        {
            using(NoticiaNegocio noticiaNegocio= new NoticiaNegocio())
            {
                ValidacaoInterfaces validarInterfaces = new ValidacaoInterfaces();
                if (validarInterfaces.validarCampoCadastrar(grpNoticia.Controls) == true)
                {
                    return;
                }
                else if(validarInterfaces.ValidarRadioButton(this.rbtCadastrarAtivoSim, rbtCadastrarAtivoNao) == true )
                {
                    return;
                }

                if(acaoNaTelaInformada == AcaoNaTela.Inserir)
                {
                    Noticia noticiaInserir = new Noticia()
                    {
                        Titulo = txtCadastrarTitulo.Text.ToString(),
                        Descricao = rckCadastrarDescricao.Text,
                        Ativo = rbtCadastrarAtivoSim.Checked == true? true: false

                    };

                    string retorno = noticiaNegocio.Inserir(noticiaInserir);
                    try
                    {
                        int codigo = Convert.ToInt32(retorno);
                        MessageBox.Show("Notícia cadastrada com sucesso. Código: " + codigo.ToString());
                        this.DialogResult = DialogResult.Yes;

                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível cadastrar notícia. Detalhes: " + retorno, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                else if(acaoNaTelaInformada == AcaoNaTela.Alterar)
                {
                    Noticia noticiaAlterar = new Noticia()
                    {
                        IDNoticia = Convert.ToInt32(this.txtCadastrarCodigo.Text),
                        Titulo = txtCadastrarTitulo.Text,
                        Descricao = rckCadastrarDescricao.Text,
                        Ativo = rbtCadastrarAtivoSim.Checked == true? true: false
                    };

                    string retorno = noticiaNegocio.Alterar(noticiaAlterar);
                    try
                    {
                        int codigo = Convert.ToInt32(retorno);
                        MessageBox.Show("Notícia alterada com sucesso. Código: " + codigo.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível alterar notícia. Detalhes: " + retorno, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
             



            }
        }

        private void FrmNoticiaCadastrar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            this.btnNoticiaCancelar.PerformClick();
            if (e.KeyCode == Keys.F1)
                this.btnNoticiaCadastrar.PerformClick();
            if (e.KeyCode == Keys.F2)
                this.btnNoticiaCancelar.PerformClick();
        }

        private void btnNoticiaCancelar_Click(object sender, EventArgs e)
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
    }
}
