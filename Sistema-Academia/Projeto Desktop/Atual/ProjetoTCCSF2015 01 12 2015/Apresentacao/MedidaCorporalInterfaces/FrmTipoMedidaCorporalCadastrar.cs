using Negocios;
using ObjetoTransferencia;
using System;
using System.Windows.Forms;

namespace Apresentacao.MedidaCorporalInterfaces
{
    public partial class FrmTipoMedidaCorporalCadastrar : Form
    {
        AcaoNaTela acaoNaTelaInformada;
        public FrmTipoMedidaCorporalCadastrar(AcaoNaTela acaoNaTela, TipoMedidaCorporal tipoMedidaCorporal)
        {
            acaoNaTelaInformada = acaoNaTela;
            InitializeComponent();

            if(acaoNaTelaInformada == AcaoNaTela.Inserir)
            {
                this.Text = "Cadastrar Tipo Medida Corporal";
                this.lblTipoMedidaCadastrarTitulo.Text = "Cadastrar Tipo De Medida Corporal";
                this.btnTipoMedidaCadastrar.Text = "Salvar";
                pbxCadastrarTipoMedida.Image = global::Apresentacao.Properties.Resources._1440663403_add_property;
            }
            else if(acaoNaTelaInformada == AcaoNaTela.Alterar)
            {
                this.Text = "Alterar Tipo Medida Corporal";
                this.lblTipoMedidaCadastrarTitulo.Text = "Alterar Tipo De Medida Corporal";
                this.btnTipoMedidaCadastrar.Text = "Salvar";
                this.pbxCadastrarTipoMedida.Image = global::Apresentacao.Properties.Resources._1440663068_edit_property;
                this.txtCadastrarCodigo.Text = tipoMedidaCorporal.IDTipoMedidaCorporal.ToString();
                this.txtCadastrarDescricao.Text = tipoMedidaCorporal.Descricao;
                this.rbtCadastrarAtivoSim.Checked = tipoMedidaCorporal.Ativo == true ? true : false;
                this.rbtCadastrarAtivoNao.Checked = tipoMedidaCorporal.Ativo == false ? true : false;


            }


        }

        private void btnTipoMedidaCancelar_Click(object sender, EventArgs e)
        {
            if (acaoNaTelaInformada == AcaoNaTela.Inserir)
            {
                if (MessageBox.Show("Deseja realmente sair do cadastro", "Saindo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                    this.Close(); 
            }
            else if(acaoNaTelaInformada == AcaoNaTela.Alterar)
            {
                 if(MessageBox.Show("Deseja realmente sair da alteração", "Saindo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                 this.Close(); 
            }                
        }

        private void btnTipoMedidaCadastrar_Click(object sender, EventArgs e)
        {
            using (TipoMedidaCorporalNegocio tipoMedidaCorporalNegocio = new TipoMedidaCorporalNegocio())
            {
                ValidacaoInterfaces validarInterfaces = new ValidacaoInterfaces();

                if(validarInterfaces.validarCampoCadastrar(grpTipoMedida.Controls) == true)
                {
                    return;
                }
                else if (validarInterfaces.ValidarRadioButton(rbtCadastrarAtivoSim, rbtCadastrarAtivoNao) == true)
                {
                    return;
                }

                if(acaoNaTelaInformada == AcaoNaTela.Inserir)
                {
                    TipoMedidaCorporal tipoMedidaCorporalInserir = new TipoMedidaCorporal()
                    {
                        Descricao = txtCadastrarDescricao.Text,
                        Ativo = rbtCadastrarAtivoSim.Checked == true? true: false
                    };

                    string retorno = tipoMedidaCorporalNegocio.Inserir(tipoMedidaCorporalInserir);
                    try
                    {
                        int codigo = Convert.ToInt32(retorno);
                        MessageBox.Show("Tipo de medida corporal cadastrada com sucesso. Código: " + codigo.ToString(), "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível cadastrar tipo de medida corporal. Detalhes: " + retorno, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                }
                else if (acaoNaTelaInformada == AcaoNaTela.Alterar)
                {
                    TipoMedidaCorporal tipoMedidaCorporalAlterar = new TipoMedidaCorporal()
                    {
                        IDTipoMedidaCorporal = Convert.ToInt32(txtCadastrarCodigo.Text),
                        Descricao = txtCadastrarDescricao.Text,
                        Ativo = rbtCadastrarAtivoSim.Checked == true ? true : false
                    };

                    string retorno = tipoMedidaCorporalNegocio.Alterar(tipoMedidaCorporalAlterar);

                    try
                    {
                        int codigo = Convert.ToInt32(retorno);
                        MessageBox.Show("Tipo de medida corporal alterada com sucesso. Código: " + codigo.ToString(), "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível alterar tipo de medida corporal. Detalhes: " + retorno, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void FrmTipoMedidaCorporalCadastrar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.btnTipoMedidaCancelar.PerformClick();
            if (e.KeyCode == Keys.F1)
                btnTipoMedidaCadastrar.PerformClick();
            else if (e.KeyCode == Keys.F2)
                btnTipoMedidaCancelar.PerformClick();
        }
    }
}
