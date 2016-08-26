using Negocios;
using ObjetoTransferencia;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Apresentacao.TreinamentoInterfaces
{
    public partial class FrmTreinamentoSelecionar : Form
    {
        public FrmTreinamentoSelecionar()
        {
            InitializeComponent();
            this.dgwSelecionarTreinamentoFísico.AutoGenerateColumns = false;
        }

        public void AtualizarGridTreinamento(DialogResult dialogResult)
        {
            using(TreinamentoNegocio treinamentoNegocio = new TreinamentoNegocio())
            {
                ValidacaoInterfaces validarInterfaces = new ValidacaoInterfaces();
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        ListaTreinamento listaTreinamento = treinamentoNegocio.PesquisarTreinamentoCodigoNomeAluno(null, txtSelecionarCodAluno.Text);
                        this.dgwSelecionarTreinamentoFísico.DataSource = null;
                        this.dgwSelecionarTreinamentoFísico.DataSource = listaTreinamento;
                        this.dgwSelecionarTreinamentoFísico.Update();
                        this.dgwSelecionarTreinamentoFísico.Refresh();
                        txtSelecionarCodAluno.Focus();
            
                        return;

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Não foi possível atualizar, após ter inserido ou alterado treinamento. Detalhes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                }
                else if(validarInterfaces.ValidarCampoPesquisar(txtSelecionarCodAluno, "nome do aluno") == true)
                {
                    return;
                }
                else if(txtSelecionarCodAluno.Text.Where(c=> char.IsNumber(c)).Count() > 0)
                {
                    try
                    {
                        ListaTreinamento listaTreinamento = treinamentoNegocio.PesquisarTreinamentoCodigoNomeAluno( Convert.ToInt32(txtSelecionarCodAluno.Text)   , null);
                        if(listaTreinamento.Count() > 0)
                        {
                            this.dgwSelecionarTreinamentoFísico.DataSource = null;
                            this.dgwSelecionarTreinamentoFísico.DataSource = listaTreinamento;
                            this.dgwSelecionarTreinamentoFísico.Update();
                            this.dgwSelecionarTreinamentoFísico.Refresh();
                            txtSelecionarCodAluno.Focus();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Não existe nenhum aluno com este código: " + txtSelecionarCodAluno.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtSelecionarCodAluno.Focus();
                            return;
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Não foi possível pesquisar aluno por código. Detalhes: " +ex.Message ,"Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSelecionarCodAluno.Focus();
                        return;
                    }
                }
                else
                {
                    try
                    {
                        ListaTreinamento listaTreinamento  = treinamentoNegocio.PesquisarTreinamentoCodigoNomeAluno(null, txtSelecionarCodAluno.Text);
                        if(listaTreinamento.Count() > 0)
                        {
                            this.dgwSelecionarTreinamentoFísico.DataSource = null;
                            this.dgwSelecionarTreinamentoFísico.DataSource = listaTreinamento;
                            this.dgwSelecionarTreinamentoFísico.Update();
                            this.dgwSelecionarTreinamentoFísico.Refresh();
                            txtSelecionarCodAluno.Focus();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Não existe nenhum aluno com esse nome: " + txtSelecionarCodAluno.Text, "Avso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtSelecionarCodAluno.Focus();
                            return;
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Não foi possível pesquisar aluno por nome. Detalhes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSelecionarCodAluno.Focus();
                        return;
                    }
                }

            }


        }

        private void btnSelecionarPesquisar_MouseHover(object sender, EventArgs e)
        {
            ttpSelecionarPesquisar.Show("Pesquisar", btnSelecionarPesquisar);
            btnSelecionarPesquisar.Image = global::Apresentacao.Properties.Resources.ic_search_grey600_24dp;

        }

        private void btnSelecionarPesquisar_MouseLeave(object sender, EventArgs e)
        {
            btnSelecionarPesquisar.Image = global::Apresentacao.Properties.Resources.ic_search_black_24dp1;
        }

        private void btnSelecionarPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGridTreinamento(DialogResult.No);
        }

        private void dgwSelecionarTreinamentoFísico_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnSelecionarAlterar.PerformClick();
        }

        private void dgwSelecionarTreinamentoFísico_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 0 && e.Value is Aluno)
            {
                e.Value = (e.Value as Aluno).Pessoa.IDPessoa;
            }
            if(e.ColumnIndex == 1 && e.Value is Aluno)
            {
                e.Value = (e.Value as Aluno).Pessoa.Nome;
            }
            if(e.ColumnIndex == 2 && e.Value is TipoTreinamento)
            {
                e.Value = (e.Value as TipoTreinamento).Descricao;
            }

            if(e.ColumnIndex == 3 && e.Value is bool)
            {
                if (e.Value.Equals(true))
                    e.Value = "Sim";
                else
                    e.Value = "Não";
            }
        }

        private void btnSelecionarInserir_Click(object sender, EventArgs e)
        {
            if(this.dgwSelecionarTreinamentoFísico.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum aluno está selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Treinamento treinamentoSelecionado = (this.dgwSelecionarTreinamentoFísico.SelectedRows[0].DataBoundItem) as Treinamento;
            FrmTreinamentoCadastrar frmTreinamento = new FrmTreinamentoCadastrar(AcaoNaTela.Inserir, treinamentoSelecionado);
            DialogResult dialogResult = frmTreinamento.ShowDialog();
            if (dialogResult == DialogResult.Yes)
                AtualizarGridTreinamento(DialogResult.Yes);
            else
                txtSelecionarCodAluno.Focus();


        }

        private void btnSelecionarAlterar_Click(object sender, EventArgs e)
        {
            if (this.dgwSelecionarTreinamentoFísico.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum aluno está selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Treinamento treinamentoSelecionado = (this.dgwSelecionarTreinamentoFísico.SelectedRows[0].DataBoundItem) as Treinamento;
            if(treinamentoSelecionado.TipoTreinamento.Descricao == "Nenhum")
            {
                MessageBox.Show("Não foi possível alterar, não existe nenhum treinamento cadastrado com este aluno", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FrmTreinamentoCadastrar frmTreinamento = new FrmTreinamentoCadastrar(AcaoNaTela.Alterar, treinamentoSelecionado);
            DialogResult dialogResult = frmTreinamento.ShowDialog();
            if (dialogResult == DialogResult.Yes)
                AtualizarGridTreinamento(DialogResult.Yes);
            else
                txtSelecionarCodAluno.Focus();

        }

        private void btnSelecionarCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTreinamentoSelecionar_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F1)
            {
                btnSelecionarPesquisar.PerformClick();
            }
            else if (e.KeyCode == Keys.F2)
            {
                btnSelecionarInserir.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                btnSelecionarAlterar.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter && txtSelecionarCodAluno.Text != "")
            {
                btnSelecionarPesquisar.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
