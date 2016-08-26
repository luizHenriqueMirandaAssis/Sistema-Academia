using Negocios;
using ObjetoTransferencia;
using System;
using System.Windows.Forms;

namespace Apresentacao.ExercicioInterfaces
{
    public partial class FrmTipoExercicioCadastrar : Form
    {
        AcaoNaTela acaoNaTelaInformada;

        public FrmTipoExercicioCadastrar(AcaoNaTela acaoNaTela, TipoExercicio tipoExercicio)
        {
            acaoNaTelaInformada = acaoNaTela;
            InitializeComponent();

            if(acaoNaTelaInformada == AcaoNaTela.Inserir)
            {
                this.Text = "Cadastrar tipo de exercício";
                this.lblTipoExercicioCadastrarTitulo.Text = "Cadastrar Tipo De Exercício";
                this.pbxCadastrarTipoExercicio.Image = global::Apresentacao.Properties.Resources._1440663403_add_property;
                this.btnTipoExercicioCadastrar.Text = "Salvar";

            }
            else if(acaoNaTelaInformada == AcaoNaTela.Alterar)
            {
                this.Text = "Alterar tipo de exercício";
                this.lblTipoExercicioCadastrarTitulo.Text = "Alterar Tipo De Exercício";
                this.pbxCadastrarTipoExercicio.Image = global::Apresentacao.Properties.Resources._1440663068_edit_property;
                this.btnTipoExercicioCadastrar.Text = "Salvar";
                this.txtCadastrarDescricao.Text = tipoExercicio.Descricao;
                this.txtCadastrarCodigo.Text = tipoExercicio.IDTipoExercicio.ToString();
                this.rbtnAlunoAtivoSim.Checked = tipoExercicio.Ativo == true ? true : false;
                this.rbtnAlunoAtivoNao.Checked = tipoExercicio.Ativo == false ? true : false;
            }

        }

        private void btnTipoExercicioCancelar_Click(object sender, EventArgs e)
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

        private void btnTipoExercicioCadastrar_Click(object sender, EventArgs e)
        {
            using(TipoExercicioNegocio tipoExercicioNegocio = new TipoExercicioNegocio())
            {
                ValidacaoInterfaces validarInterface = new ValidacaoInterfaces();
                if(validarInterface.validarCampoCadastrar(this.grpTipoExercicio.Controls) == true)
                {
                    return;
                }
                else if (validarInterface.ValidarRadioButton(this.rbtnAlunoAtivoSim, this.rbtnAlunoAtivoNao) == true)
                {
                    return;
                }

                if(acaoNaTelaInformada == AcaoNaTela.Inserir)
                {
                    TipoExercicio tipoExercicioInserir = new TipoExercicio()
                    {
                        Descricao = this.txtCadastrarDescricao.Text,
                        Ativo = this.rbtnAlunoAtivoSim.Checked == true? true: false
                    };

                    string retorno = tipoExercicioNegocio.Inserir(tipoExercicioInserir);

                    try
                    {
                        int codigo = Convert.ToInt32(retorno);
                        MessageBox.Show("Tipo de exercício cadastrado com sucesso. Código: " + codigo.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível cadastrar tipo de exercício. Detalhes: " + retorno, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                else if(acaoNaTelaInformada == AcaoNaTela.Alterar)
                {
                    TipoExercicio tipoExercicioAlterar = new TipoExercicio()
                    {
                        IDTipoExercicio = Convert.ToInt32(this.txtCadastrarCodigo.Text),
                        Descricao = this.txtCadastrarDescricao.Text,
                        Ativo = this.rbtnAlunoAtivoSim.Checked == true ? true : false
                    };

                    string retorno = tipoExercicioNegocio.Alterar(tipoExercicioAlterar);
                    try
                    {
                        int codigo = Convert.ToInt32(retorno);
                        MessageBox.Show("Tipo de exercício alterado com sucesso. Código: " + codigo.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = System.Windows.Forms.DialogResult.Yes;

                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível alterar tipo de exercício. Detalhes: " + retorno, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }

                }

            }
        }

        private void FrmTipoExercicioCadastrar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.btnTipoExercicioCancelar.PerformClick();
            }
            if (e.KeyCode == Keys.F1)
            {
                this.btnTipoExercicioCadastrar.PerformClick();
            }
            if (e.KeyCode == Keys.F2)
            {
                this.btnTipoExercicioCancelar.PerformClick();
            }

        }

        private void listBoxSelecionar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
