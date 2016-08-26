using Negocios;
using ObjetoTransferencia;
using System;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Drawing;

namespace Apresentacao.ExercicioInterfaces
{
    public partial class FrmExercicioCadastrar : Form
    {
        AcaoNaTela acaoNaTelaInformada;
        public FrmExercicioCadastrar(AcaoNaTela acaoNaTela, Exercicio exercicio)
        {
            acaoNaTelaInformada = acaoNaTela;
            InitializeComponent();

            using (TipoExercicioNegocio tipoExercicioNegocio = new TipoExercicioNegocio())
            {
                ListaTipoExercicio listaTipoExercicio = tipoExercicioNegocio.CarregarCampoTipoExercicio();
                this.cmbCadastrarTipo.DataSource = listaTipoExercicio;
                this.cmbCadastrarTipo.ValueMember = "IDTipoExercicio";
                this.cmbCadastrarTipo.DisplayMember = "Descricao";
            }
            


            if(acaoNaTelaInformada == AcaoNaTela.Inserir)
            {
                this.Text = "Cadastrar exercício";
                this.lblExercicioCadastrarTitulo.Text = "Cadastrar Exercício";
                this.pbxCadastrarExercicio.Image = global::Apresentacao.Properties.Resources._1440663403_add_property;
                this.btnExercicioCadastrar.Text = "Salvar";
                this.cmbCadastrarTipo.SelectedItem = null;
            }
            else if(acaoNaTelaInformada == AcaoNaTela.Alterar)
            {
                this.Text = "Alterar exercício";
                this.lblExercicioCadastrarTitulo.Text = "Alterar Exercício";
                this.pbxCadastrarExercicio.Image = global::Apresentacao.Properties.Resources._1440663068_edit_property;
                this.btnExercicioCadastrar.Text = "Salvar";
                this.txtCadastrarNome.Text = exercicio.Nome;
                this.rckCadastrarDescricao.Text = exercicio.Descricao;
                this.cmbCadastrarTipo.Text = exercicio.TipoExercicio.Descricao; ;
                this.txtCadastrarCodigo.Text = exercicio.IDExercicio.ToString();
                this.txtCadastrarUrlImagem.Text = exercicio.DemonstracaoUrlImagem;
                this.txtCadastrarUrlVideo.Text = exercicio.DemonstracaoUrlVideo;


            }


        }

        private void btnExercicioCancelar_Click(object sender, EventArgs e)
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


        private void btnExercicioCadastrar_Click(object sender, EventArgs e)
        {
            using (ExercicioNegocio exercicioNegocio = new ExercicioNegocio())
            {
                ValidacaoInterfaces validarInterface = new ValidacaoInterfaces();
                if(validarInterface.validarCampoCadastrar(this.grpExercicio.Controls) == true)
                {
                    return;
                }
                if(validarInterface.validarCampoCadastrar(this.grpDemonstracao.Controls) == true)
                {
                    return;
                }


                if (acaoNaTelaInformada == AcaoNaTela.Inserir)
                {
                    var bytes = Encoding.UTF8.GetBytes(txtCadastrarUrlImagem.Text);
                    var base64 = Convert.ToBase64String(bytes);
                    Exercicio exercicioInserir = new Exercicio()
                    {
                        Nome = this.txtCadastrarNome.Text,
                        Descricao = this.rckCadastrarDescricao.Text,
                        DemonstracaoUrlImagem = txtCadastrarUrlImagem.Text,
                        DemonstracaoUrlVideo = this.txtCadastrarUrlVideo.Text  
                                   
                     };

                    exercicioInserir.TipoExercicio = new TipoExercicio()
                    {
                        IDTipoExercicio = Convert.ToInt32(cmbCadastrarTipo.SelectedValue)
                    };

                    string retorno = exercicioNegocio.Inserir(exercicioInserir);
                    try
                    {
                        int codigo = Convert.ToInt32(retorno);
                        MessageBox.Show("Exercicio cadastrado com sucesso. Código: " +codigo.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível cadastrar o exercício. Detalhes: " + retorno, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                else if (acaoNaTelaInformada == AcaoNaTela.Alterar)
                {
                    
                    

                    Exercicio exercicioAlterar = new Exercicio()
                    {
                         IDExercicio = Convert.ToInt32(this.txtCadastrarCodigo.Text),
                         Nome = this.txtCadastrarNome.Text,
                         Descricao = this.rckCadastrarDescricao.Text,
                         DemonstracaoUrlImagem = this.txtCadastrarUrlImagem.Text,
                         DemonstracaoUrlVideo = txtCadastrarUrlVideo.Text
                    };

                    exercicioAlterar.TipoExercicio = new TipoExercicio()
                    {
                        IDTipoExercicio = Convert.ToInt32(cmbCadastrarTipo.SelectedValue)
                    };

                    string retorno = exercicioNegocio.Alterar(exercicioAlterar);
                    try
                    {
                        int codigo = Convert.ToInt32(retorno);
                        MessageBox.Show("Exercício alterado com sucesso. Código: " + codigo.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                    } 
                    catch
                    {
                        MessageBox.Show("Não foi possível alterar o exercício. Detalhes: " + retorno, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    
                }
            }

        }

        private void FrmExercicioCadastrar_KeyUp(object sender, KeyEventArgs e)
        {
            
                if (e.KeyCode == Keys.Escape)
                {
                    this.btnExercicioCancelar.PerformClick();
                }

                if (e.KeyCode == Keys.F1)
                {
                    this.btnExercicioCadastrar.PerformClick();
                }

                if (e.KeyCode == Keys.F2)
                {
                    this.btnExercicioCancelar.PerformClick();
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
