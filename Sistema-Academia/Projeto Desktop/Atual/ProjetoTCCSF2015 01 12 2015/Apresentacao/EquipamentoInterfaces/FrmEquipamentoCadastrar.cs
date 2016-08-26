using Negocios;
using ObjetoTransferencia;
using System;
using System.Windows.Forms;

namespace Apresentacao.EquipamentoInterfaces
{
    public partial class FrmEquipamentoCadastrar : Form
    {
        AcaoNaTela acaoNaTelaInformada;
        public FrmEquipamentoCadastrar(AcaoNaTela acaoNaTela, Equipamento equipamento)
        {
            InitializeComponent();
            acaoNaTelaInformada = acaoNaTela;

            if(acaoNaTelaInformada == AcaoNaTela.Inserir)
            {
                this.Text = "Cadastrar equipamento";
                this.lblEquipamentoCadastrarTitulo.Text = "Cadastrar Equipamento";
                this.btnEquipamentoCadastrar.Text = "Salvar";
                this.pbxCadastrarEquipamento.Image = global::Apresentacao.Properties.Resources._1440663403_add_property;
            }
            else if(acaoNaTelaInformada == AcaoNaTela.Alterar)
            {
                this.Text = "Alterar equipamento";
                this.lblEquipamentoCadastrarTitulo.Text = "Alterar Equipamento";
                this.btnEquipamentoCadastrar.Text = "Salvar";
                this.pbxCadastrarEquipamento.Image = global::Apresentacao.Properties.Resources._1440663068_edit_property;
                this.txtCadastrarCodigo.Text = equipamento.IDEquipamento.ToString();
                this.txtCadastrarNomeEquipamento.Text = equipamento.Nome;
                this.txtCadastrarQuantidade.Text = equipamento.Quantidade.ToString();
                this.rbtCadastrarAtivoSim.Checked = equipamento.Ativo == true ? true : false;
                this.rbtCadastrarAtivoNao.Checked = equipamento.Ativo == false ? true : false;
                
            }

        }

        private void btnEquipamentoCancelar_Click(object sender, EventArgs e)
        {      
               if(acaoNaTelaInformada == AcaoNaTela.Inserir)
               {
                   if (MessageBox.Show("Deseja realmente sair do cadastro", "Saindo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                   {
                       this.DialogResult = DialogResult.No;
                   }
               }
               else if(acaoNaTelaInformada == AcaoNaTela.Alterar)
               {
                   if (MessageBox.Show("Deseja realmente sair da alteração", "Saindo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                   {
                       this.DialogResult = DialogResult.No;
                   }
               }
        }

        private void btnEquipamentoCadastrar_Click(object sender, EventArgs e)
        {
            using (EquipamentoNegocio equipamentoNegocio = new EquipamentoNegocio())
            {
                ValidacaoInterfaces validarInterfaces = new ValidacaoInterfaces();
                if(validarInterfaces.validarCampoCadastrar(this.grpEquipamento.Controls) == true)
                {
                    return;
                }
                else if(validarInterfaces.ValidarRadioButton(this.rbtCadastrarAtivoSim, this.rbtCadastrarAtivoNao) == true)
                {
                    return;
                }
                    
                if(acaoNaTelaInformada == AcaoNaTela.Inserir)
                {
                    Equipamento equipamentoInserir = new Equipamento()
                    {
                        Nome = this.txtCadastrarNomeEquipamento.Text,
                        Quantidade = Convert.ToInt32(this.txtCadastrarQuantidade.Text),
                        Ativo = this.rbtCadastrarAtivoSim.Checked== true? true: false                       
                    };

                    string retorno = equipamentoNegocio.Inserir(equipamentoInserir);

                    try
                    {
                        int codigo = Convert.ToInt32(retorno);
                        MessageBox.Show("Equipamento cadastrado com sucesso. Código: " + codigo.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível cadastrar o equipamento. Detalhes: " + retorno, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else if(acaoNaTelaInformada == AcaoNaTela.Alterar)
                {
                    Equipamento equipamentoAlterar = new Equipamento()
                    {
                        IDEquipamento = Convert.ToInt32(this.txtCadastrarCodigo.Text),
                        Nome = txtCadastrarNomeEquipamento.Text,
                        Quantidade = Convert.ToInt32(this.txtCadastrarQuantidade.Text),
                        Ativo = this.rbtCadastrarAtivoSim.Checked == true? true: false
                    };

                    string retorno = equipamentoNegocio.Alterar(equipamentoAlterar);

                    try
                    {
                        int codigo = Convert.ToInt32(retorno);
                        MessageBox.Show("Equipamento alterado com sucesso. Código: " + codigo.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível alterar o equipamento. Detalhes: " + retorno, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }

            }
        }

        private void FrmEquipamentoCadastrar_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.btnEquipamentoCancelar.PerformClick();
            }
            if(e.KeyCode == Keys.F1)
            {
                btnEquipamentoCadastrar.PerformClick();
            }
            if (e.KeyCode == Keys.F2)
            {
                btnEquipamentoCancelar.PerformClick();
            }
        }

        private void listBoxSelecionar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
