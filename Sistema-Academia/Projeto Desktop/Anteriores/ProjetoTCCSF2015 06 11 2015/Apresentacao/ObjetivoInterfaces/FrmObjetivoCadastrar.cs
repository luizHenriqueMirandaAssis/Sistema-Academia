using Negocios;
using ObjetoTransferencia;
using System;
using System.Windows.Forms;

namespace Apresentacao.ObjetivoInterfaces
{
    public partial class FrmObjetivoCadastrar : Form
    {
        AcaoNaTela acaoNaTelaInformada;

        public FrmObjetivoCadastrar(AcaoNaTela acaoNaTela, Objetivo objetivo )
        {
            acaoNaTelaInformada = acaoNaTela;
            InitializeComponent();

            if (acaoNaTelaInformada == AcaoNaTela.Inserir)
            {
                this.Text = "Cadastrar objetivo";
                this.lblObjetivoCadastrarTitulo.Text = "Cadastrar Objetivo";
                this.pbxCadastrarObjetivo.Image = global::Apresentacao.Properties.Resources._1440663403_add_property;
                this.btnObjetivoCadastrar.Text = "Salvar";
            }
            else if (acaoNaTelaInformada == AcaoNaTela.Alterar)
            {
                this.Text = "Alterar objetivo";
                this.lblObjetivoCadastrarTitulo.Text = "Alterar Objetivo";
                this.pbxCadastrarObjetivo.Image = global::Apresentacao.Properties.Resources._1440663068_edit_property;
                this.btnObjetivoCadastrar.Text = "Salvar";
                this.txtCadastrarDescricao.Text = objetivo.Descricao;
                this.txtCadastrarCodigo.Text = objetivo.IDObjetivo.ToString();
               
            }


        }

        private void btnObjetivoCancelar_Click(object sender, EventArgs e)
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

        private void btnObjetivoCadastrar_Click_1(object sender, EventArgs e)
        {
             using (ObjetivoNegocio objetivoNegocio = new ObjetivoNegocio())
            {

                ValidacaoInterfaces validarInterfaces = new ValidacaoInterfaces();
                if(validarInterfaces.validarCampoCadastrar(this.grpObjetivo.Controls) == true)
                {
                    return;
                }
              
                if (acaoNaTelaInformada == AcaoNaTela.Inserir)
                {
                    Objetivo objetivoInserir = new Objetivo()
                    {
                        Descricao = txtCadastrarDescricao.Text
                                          
                    };

                    string retorno = objetivoNegocio.Inserir(objetivoInserir);
                    try
                    {
                        int codigo = Convert.ToInt32(retorno);
                        MessageBox.Show("Objetivo cadastrado com sucesso. Código: " + codigo.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível cadastrar o objetivo. Detalhes: " + retorno, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    
                }
                else if (acaoNaTelaInformada == AcaoNaTela.Alterar)
                {
                    Objetivo objetivoAlterar = new Objetivo()
                    {
                        IDObjetivo = Convert.ToInt32(this.txtCadastrarCodigo.Text),
                        Descricao = this.txtCadastrarDescricao.Text
                       
                    };

                    string retorno = objetivoNegocio.Alterar(objetivoAlterar);

                    try
                    {
                        int codigo = Convert.ToInt32(retorno);
                        MessageBox.Show("Objetivo alterado com sucesso. Código: " + codigo.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                        
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível alterar o objetivo. Detalhes: " + retorno, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }


            }
        

        }

        private void FrmObjetivoCadastrar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            this.btnObjetivoCancelar.PerformClick();
            if (e.KeyCode == Keys.F1)
                this.btnObjetivoCadastrar.PerformClick();
            if (e.KeyCode == Keys.F2)
                this.btnObjetivoCancelar.PerformClick();
        }
    }
}
