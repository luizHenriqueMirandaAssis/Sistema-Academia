using Negocios;
using ObjetoTransferencia;
using System;
using System.Windows.Forms;

namespace Apresentacao.TreinamentoInterfaces.TipoTreinamentoInterfaces
{
    public partial class FrmTipoTreinamentoCadastrar : Form
    {
        AcaoNaTela acaoNaTelaInformada;
        public FrmTipoTreinamentoCadastrar(AcaoNaTela acaoNaTela, TipoTreinamento tipoTreinamento)
        {
            acaoNaTelaInformada = acaoNaTela;
            InitializeComponent();

            if(acaoNaTelaInformada == AcaoNaTela.Inserir)
            {
                this.Text = "Cadastrar Tipo De Treinamento Físico";
                this.lblTipoTreinamentoFisicoTitulo.Text = "Cadastrar Tipo De Treinamento Físico";
                btnTipoTreinamentoCadastrar.Text = "Cadastrar";
                pbxCadastrarTipoTreinamento.Image = global::Apresentacao.Properties.Resources._1440663403_add_property;
                txtCadastrarTipoTreinamentoDescricao.Select();
            }
            else if(acaoNaTelaInformada == AcaoNaTela.Alterar)
            {
                this.Text = "Alterar Tipo De Treinamento Físico";
                this.lblTipoTreinamentoFisicoTitulo.Text = "Alterar Tipo De Treinamento Físico";
                this.btnTipoTreinamentoCadastrar.Text = "Alterar";
                this.pbxCadastrarTipoTreinamento.Image = global::Apresentacao.Properties.Resources._1440663068_edit_property;
                this.txtCadastrarCodigo.Text = tipoTreinamento.IDTipoTreinamento.ToString();
                this.txtCadastrarTipoTreinamentoDescricao.Text = tipoTreinamento.Descricao;
                this.rbtCadastrarAtivoSim.Checked = tipoTreinamento.Ativo == true ? true : false;
                this.rbtCadastrarAtivoNao.Checked = tipoTreinamento.Ativo == false ? true : false;
                this.txtCadastrarTipoTreinamentoDescricao.Select();

            }
        }

        private void FrmTipoTreinamentoCadastrar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                btnTipoTreinamentoCancelar.PerformClick();
            }
            else if(e.KeyCode == Keys.F1)
            {
                btnTipoTreinamentoCadastrar.PerformClick();
            }
            else if(e.KeyCode == Keys.F2)
            {
                btnTipoTreinamentoCancelar.PerformClick();
            }
        }

        private void btnTipoTreinamentoCancelar_Click(object sender, EventArgs e)
        {
            if (acaoNaTelaInformada == AcaoNaTela.Inserir)
            {
                if (MessageBox.Show("Deseja realmente sair do cadastro", "Saindo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                    this.Close();
            }
            else if (acaoNaTelaInformada == AcaoNaTela.Alterar)
            {
                if (MessageBox.Show("Deseja realmente sair da alteração", "Saindo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                    this.Close();
            }          
        }

        private void btnTipoTreinamentoCadastrar_Click(object sender, EventArgs e)
        {
            using (TipoTreinamentoNegocio tipoTreinamentoNegocio = new TipoTreinamentoNegocio())
            {
                ValidacaoInterfaces validarInterfaces = new ValidacaoInterfaces();
                if(validarInterfaces.validarCampoCadastrar(grpTipoTreinamentoFisico.Controls) == true)
                {
                    return;
                }
                else if(validarInterfaces.ValidarRadioButton(rbtCadastrarAtivoSim, rbtCadastrarAtivoNao) == true)
                {
                    return;
                }

                if (acaoNaTelaInformada == AcaoNaTela.Inserir)
                {
                    TipoTreinamento tipoTreinamentoInserir = new TipoTreinamento()
                    {
                        Descricao = txtCadastrarTipoTreinamentoDescricao.Text,
                        Ativo = rbtCadastrarAtivoSim.Checked == true? true: false
                    };

                    string retornoInserir = tipoTreinamentoNegocio.Inserir(tipoTreinamentoInserir);
                    try
                    {
                        int codigo = Convert.ToInt32(retornoInserir);
                        MessageBox.Show("Tipo de treinamento cadastrado com sucesso. Código: " + retornoInserir, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.Yes;
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível cadastrar o tipo de treinamento. Detalhes: " + retornoInserir, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                if (acaoNaTelaInformada == AcaoNaTela.Alterar)
                {
                    TipoTreinamento tipoTreinamentoAlterar = new TipoTreinamento()
                    {
                        IDTipoTreinamento = Convert.ToInt32(txtCadastrarCodigo.Text),
                        Descricao = txtCadastrarTipoTreinamentoDescricao.Text,
                        Ativo = rbtCadastrarAtivoSim.Checked == true ? true : false
                    };

                    string retornoAlterar = tipoTreinamentoNegocio.Alterar(tipoTreinamentoAlterar);
                    try
                    {
                        int codigo = Convert.ToInt32(retornoAlterar);
                        MessageBox.Show("Tipo de treinamento alterado com sucesso. Código: " + retornoAlterar, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.Yes;
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível alterar o tipo de treinamento. Detalhes: " + retornoAlterar, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            
        }
    }
}
