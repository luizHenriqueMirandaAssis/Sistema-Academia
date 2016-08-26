using Negocios;
using ObjetoTransferencia;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Apresentacao.ExercicioInterfaces
{
    public partial class FrmExercicioSelecionar : Form
    {
        public FrmExercicioSelecionar()
        {
            InitializeComponent();
            dgwSelecionarExercicio.AutoGenerateColumns = false;
        }


        public void AtualizarGridExercicio(DialogResult dialogResult)
        {
            using (ExercicioNegocio exercicioNegocio = new ExercicioNegocio())
            {
                ValidacaoInterfaces validarInterfaces = new ValidacaoInterfaces();
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        ListaExercicio listaExercicio = exercicioNegocio.PesquisarExercicioCodigoNome(null, "%");
                        this.dgwSelecionarExercicio.DataSource = null;
                        this.dgwSelecionarExercicio.DataSource = listaExercicio;
                        this.dgwSelecionarExercicio.Update();
                        this.dgwSelecionarExercicio.Refresh();
                        txtSelecionarCodNome.Focus();
                        txtSelecionarCodNome.Clear();
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível atualizar, após ter inserido ou alterado exercício. Detalhes: " +ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSelecionarCodNome.Focus();
                        return;
                    }
                }

                

                else if (validarInterfaces.ValidarCampoPesquisar(txtSelecionarCodNome, "nome") == true)
                {
                    return;
                }

                else if(this.txtSelecionarCodNome.Text.Where(c=> char.IsNumber(c)).Count() > 0)
                {
                    try
                    {
                        ListaExercicio listaExercicio = exercicioNegocio.PesquisarExercicioCodigoNome(Convert.ToInt32(this.txtSelecionarCodNome.Text), null);
                        if(listaExercicio.Count() > 0)
                        {
                            this.dgwSelecionarExercicio.DataSource = null;
                            this.dgwSelecionarExercicio.DataSource = listaExercicio;
                            this.dgwSelecionarExercicio.Update();
                            this.dgwSelecionarExercicio.Refresh();
                            txtSelecionarCodNome.Focus();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Não existe nenhum exercício com esse código: " + txtSelecionarCodNome.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtSelecionarCodNome.Focus();
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível pesquisar exercício por código. Detalhes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSelecionarCodNome.Focus();
                        return;
                    }
                }
                else
                {
                    try
                    {
                        ListaExercicio listaExercicio = exercicioNegocio.PesquisarExercicioCodigoNome(null, this.txtSelecionarCodNome.Text);
                        if (listaExercicio.Count() > 0)
                        {
                            this.dgwSelecionarExercicio.DataSource = null;
                            this.dgwSelecionarExercicio.DataSource = listaExercicio;
                            this.dgwSelecionarExercicio.Update();
                            this.dgwSelecionarExercicio.Refresh();
                            txtSelecionarCodNome.Focus();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Não existe nenhum exercício com esse nome: " + txtSelecionarCodNome.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtSelecionarCodNome.Focus();                           
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível pesquisar exercício por nome. Detalhes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSelecionarCodNome.Focus();
                        return;
                    }
                }
            }
        }

        private void btnSelecionarCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelecionarInserir_Click(object sender, EventArgs e)
        {
            FrmExercicioCadastrar frmExercicioCadastrar = new FrmExercicioCadastrar(AcaoNaTela.Inserir, null);
            DialogResult dialogResult = frmExercicioCadastrar.ShowDialog();

            if (dialogResult == DialogResult.Yes)
                AtualizarGridExercicio(DialogResult.Yes);
            
        }

        private void btnSelecionarAlterar_Click(object sender, EventArgs e)
        {
            if(this.dgwSelecionarExercicio.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum exercício está selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSelecionarCodNome.Focus();
                return;
                
            }

            Exercicio exercicioSelecionado = (this.dgwSelecionarExercicio.SelectedRows[0].DataBoundItem) as Exercicio;
            FrmExercicioCadastrar frmExercicioCadastrar = new FrmExercicioCadastrar(AcaoNaTela.Alterar, exercicioSelecionado);
            DialogResult dialogResult = frmExercicioCadastrar.ShowDialog();

            if (dialogResult == DialogResult.Yes)
                AtualizarGridExercicio(DialogResult.Yes);
            
        }

        private void dgwSelecionarExercicio_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.Value is Exercicio)
            {
                e.Value = (e.Value as Exercicio).IDExercicio;
            }

            if (e.ColumnIndex == 1 && e.Value is Exercicio)
            {
                e.Value = (e.Value as Exercicio).Nome;
            }

            if (e.ColumnIndex == 2 && e.Value is TipoExercicio)
            {
                e.Value = (e.Value as TipoExercicio).Descricao;
            }
        }

        private void btnSelecionarPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGridExercicio(DialogResult.No);
        }

        private void dgwSelecionarExercicio_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.btnSelecionarAlterar.PerformClick();
        }

        private void btnSelecionarPesquisar_MouseHover(object sender, EventArgs e)
        {
            ttpSelecionarPesquisar.Show("Pesquisar", btnSelecionarPesquisar);
            btnSelecionarPesquisar.Image = global::Apresentacao.Properties.Resources.ic_search_grey600_24dp;
        }

           private void btnSelecionarPesquisar_MouseLeave_1(object sender, EventArgs e)
        {
            btnSelecionarPesquisar.Image = global::Apresentacao.Properties.Resources.ic_search_black_24dp1;
        }

           private void FrmExercicioSelecionar_KeyDown(object sender, KeyEventArgs e)
           {
               
               if (e.KeyCode == Keys.F1)
               {
                   AtualizarGridExercicio(DialogResult.No);
               }
               else if (e.KeyCode == Keys.F2)
               {
                   this.btnSelecionarInserir.PerformClick();
               }
               else if (e.KeyCode == Keys.F3)
               {
                   this.btnSelecionarAlterar.PerformClick();
               }
               else if (this.txtSelecionarCodNome.Text != "" && e.KeyCode == Keys.Enter)
               {
                   e.Handled = true;
                   e.SuppressKeyPress = true;
                   AtualizarGridExercicio(DialogResult.No);

               }
               else if (e.KeyCode == Keys.Escape)
               {
                   this.Close();

               }
           }
    }
}
