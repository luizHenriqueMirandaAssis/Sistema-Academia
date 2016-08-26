using Negocios;
using ObjetoTransferencia;
using System;
using System.Windows.Forms;

namespace Apresentacao.TreinamentoInterfaces
{
    public partial class FrmTreinamentoAlterar : Form
    {
        public FrmTreinamentoAlterar(ExerciciosTreinamento exerciciosTreinamento)
        {
            InitializeComponent();

            
            this.txtCodigoTreinamento.Text = exerciciosTreinamento.Treinamento.IDTreinamento.ToString();
            this.txtCadastrarSeries.Text = exerciciosTreinamento.Series.ToString();
            this.txtCadastrarRepeticoes.Text = exerciciosTreinamento.Repeticoes.ToString();
            this.mskCadastrarIntervalo.Text = exerciciosTreinamento.Intervalo;

            using (ExercicioNegocio exercicioNegocio = new ExercicioNegocio())
            {
                try
                {
                    ListaExercicio listaExercicio = exercicioNegocio.PesquisarExercicioCodigoNome(null, "%");
                    cbxCadastrarExercicio.DataSource = listaExercicio;
                    cbxCadastrarExercicio.DisplayMember = "Nome";
                    cbxCadastrarExercicio.ValueMember = "IDExercicio";
                    this.cbxCadastrarExercicio.Text = exerciciosTreinamento.Exercicio.Nome;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível carregar a lista de exercício. Detalhes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

          

        }

       

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            using(ExerciciosTreinamentoNegocio exercicioTreinamentoNegocio = new ExerciciosTreinamentoNegocio())
            {
                ValidacaoInterfaces validarInterfaces = new ValidacaoInterfaces();
                if(validarInterfaces.validarCampoCadastrar(grpTreinamentoAlterar.Controls) == true)
                {
                    return;
                }
                ExerciciosTreinamento exerciciosTreinamentoAlterar = new ExerciciosTreinamento()
                {
                    Series = Convert.ToInt32(txtCadastrarSeries.Text),
                    Repeticoes = Convert.ToInt32(txtCadastrarRepeticoes.Text),
                    Intervalo = mskCadastrarIntervalo.Text
                };

                exerciciosTreinamentoAlterar.Treinamento = new Treinamento()
                {
                    IDTreinamento = Convert.ToInt32(txtCodigoTreinamento.Text)
                };
                exerciciosTreinamentoAlterar.Exercicio = new Exercicio()
                {
                    IDExercicio = Convert.ToInt32(cbxCadastrarExercicio.SelectedValue)
                };

                string retorno = exercicioTreinamentoNegocio.Alterar(exerciciosTreinamentoAlterar);
                try
                {
                    int codigo = Convert.ToInt32(retorno);
                    MessageBox.Show("Exercício alterado com sucesso. Código: " + retorno, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Não foi possível alterar exercício. Detalhes: " + retorno, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


            }
        }

        private void FrmTreinamentoAlterar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.F1)
            {
                btnSalvar.PerformClick();
            }

        }
    }
}
