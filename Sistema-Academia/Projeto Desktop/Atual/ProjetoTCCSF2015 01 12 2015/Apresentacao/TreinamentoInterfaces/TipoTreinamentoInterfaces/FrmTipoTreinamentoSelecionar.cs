using Negocios;
using ObjetoTransferencia;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Apresentacao.TreinamentoInterfaces.TipoTreinamentoInterfaces
{
    public partial class FrmTipoTreinamentoSelecionar : Form
    {
        public FrmTipoTreinamentoSelecionar()
        {
            InitializeComponent();
            txtSelecionarCodDescricao.Select();
            this.dgwSelecionarTipoTreinamento.AutoGenerateColumns = false;
        }

        public void AtualizarGrid(DialogResult dialogResult)
        {
            using (TipoTreinamentoNegocio tipoTreinamentoNegocio = new TipoTreinamentoNegocio())
            {
                ValidacaoInterfaces validar = new ValidacaoInterfaces();
                ListaTipoTreinamento listaTipoTreinamento = new ListaTipoTreinamento();
                if (dialogResult == DialogResult.Yes)
                {

                    try
                    {
                         listaTipoTreinamento = tipoTreinamentoNegocio.PesquisarTreinamentoCodigoNome(null, "%");
                        this.dgwSelecionarTipoTreinamento.DataSource = null;
                        this.dgwSelecionarTipoTreinamento.DataSource = listaTipoTreinamento;
                        this.dgwSelecionarTipoTreinamento.Update();
                        this.dgwSelecionarTipoTreinamento.Refresh();
                        this.txtSelecionarCodDescricao.Clear();
                        this.txtSelecionarCodDescricao.Focus();
                        return;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível atualizar, após ter inserido ou alterado o tipo de treinamento. Detalhes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSelecionarCodDescricao.Clear();
                        txtSelecionarCodDescricao.Focus();
                        return;
                    }
                }
            
                if(validar.ValidarCampoPesquisar(txtSelecionarCodDescricao, "descrição") == true)
                {
                    return;
                }

                if(txtSelecionarCodDescricao.Text.Where(c=> char.IsNumber(c)).Count() > 0)
                {
                    try
                    {
                        listaTipoTreinamento = tipoTreinamentoNegocio.PesquisarTreinamentoCodigoNome(Convert.ToInt32(txtSelecionarCodDescricao.Text), null);
                        if(listaTipoTreinamento.Count > 0)
                        {
                            this.dgwSelecionarTipoTreinamento.DataSource = null;
                            this.dgwSelecionarTipoTreinamento.DataSource = listaTipoTreinamento;
                            this.dgwSelecionarTipoTreinamento.Update();
                            this.dgwSelecionarTipoTreinamento.Refresh();
                            this.txtSelecionarCodDescricao.Focus();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Não possui nenhum tipo de treinamento com esse código: " + txtSelecionarCodDescricao.Text, "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Information);
                            txtSelecionarCodDescricao.Clear();
                            txtSelecionarCodDescricao.Focus();
                            return;
                        }

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Não foi possível pesquisar por código. Detalhes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSelecionarCodDescricao.Focus();
                        txtSelecionarCodDescricao.Clear();
                        return;
                    }
                }
                else if(txtSelecionarCodDescricao.Text.Where(c=> char.IsLetter(c)).Count() > 0)
                {
                    try
                    {
                        listaTipoTreinamento = tipoTreinamentoNegocio.PesquisarTreinamentoCodigoNome(null, txtSelecionarCodDescricao.Text);
                        if (listaTipoTreinamento.Count > 0)
                        {
                            this.dgwSelecionarTipoTreinamento.DataSource = null;
                            this.dgwSelecionarTipoTreinamento.DataSource = listaTipoTreinamento;
                            this.dgwSelecionarTipoTreinamento.Update();
                            this.dgwSelecionarTipoTreinamento.Refresh();
                            this.txtSelecionarCodDescricao.Focus();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Não possui nenhum tipo de treinamento com essa descrição: " + txtSelecionarCodDescricao.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtSelecionarCodDescricao.Clear();
                            txtSelecionarCodDescricao.Focus();
                            return;
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Não foi possível pesquisar o tipo de treinamento por descrição. Detalhes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSelecionarCodDescricao.Clear();
                        txtSelecionarCodDescricao.Focus();
                        return;
                    }
                }

            }
        }

        private void btnSelecionarPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid(DialogResult.No);
        }

        private void btnSelecionarCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelecionarInserir_Click(object sender, EventArgs e)
        {
            FrmTipoTreinamentoCadastrar frmTipoTreinamentoCadastrar = new FrmTipoTreinamentoCadastrar(AcaoNaTela.Inserir, null);
            DialogResult dialogResult = frmTipoTreinamentoCadastrar.ShowDialog();
            if (dialogResult == DialogResult.Yes)
                AtualizarGrid(DialogResult.Yes);
        }

        private void btnSelecionarAlterar_Click(object sender, EventArgs e)
        {
            if(this.dgwSelecionarTipoTreinamento.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum tipo de treinamento está selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSelecionarCodDescricao.Focus();
                return;
            }

            TipoTreinamento tipoTreinamentoSelecionado = (this.dgwSelecionarTipoTreinamento.SelectedRows[0].DataBoundItem) as TipoTreinamento;
            FrmTipoTreinamentoCadastrar frmTipoTreinamentoCadastrar = new FrmTipoTreinamentoCadastrar(AcaoNaTela.Alterar, tipoTreinamentoSelecionado);
            DialogResult dialogResult = frmTipoTreinamentoCadastrar.ShowDialog();
            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                AtualizarGrid(DialogResult.Yes);
        }

        private void FrmTipoTreinamentoSelecionar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                btnSelecionarPesquisar.PerformClick();
            }
            else if(e.KeyCode == Keys.F2)
            {
                btnSelecionarInserir.PerformClick();
            }
            else if(e.KeyCode == Keys.F3)
            {
                btnSelecionarAlterar.PerformClick();
            }
            else if(txtSelecionarCodDescricao.Text != "" & e.KeyCode == Keys.Enter)
            {
                btnSelecionarPesquisar.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

        }

        private void dgwSelecionarTipoTreinamento_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 2 && e.Value is Boolean)
            {
                if (e.Value.Equals(true))
                    e.Value = "Sim";
                else
                    e.Value = "Não";
            }
        }
    }
}
