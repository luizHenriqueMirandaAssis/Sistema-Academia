using Negocios;
using ObjetoTransferencia;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Apresentacao.EquipamentoInterfaces
{
    public partial class FrmEquipamentoSelecionar : Form
    {
        public FrmEquipamentoSelecionar()
        {
            InitializeComponent();
            dgwSelecionarEquipamento.AutoGenerateColumns = false;
        }

        public void AtualizarGridEquipamento(DialogResult dialogResult)
        {
            using (EquipamentoNegocio equipamentoNegocio = new EquipamentoNegocio())
            {
                ValidacaoInterfaces validarInterfaces = new ValidacaoInterfaces();
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        ListaEquipamento listaEquipamento = equipamentoNegocio.ConsultarPorCodigoOuDescricao(null, "%");
                        this.dgwSelecionarEquipamento.DataSource = null;
                        this.dgwSelecionarEquipamento.DataSource = listaEquipamento;
                        this.dgwSelecionarEquipamento.Update();
                        this.dgwSelecionarEquipamento.Refresh();
                        txtSelecionarCodNome.Focus();
                        txtSelecionarCodNome.Clear();
                        return;
                  

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Não foi possível atualizar, após ter inserido ou alterado equipamento. Datalhes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                else if (validarInterfaces.ValidarCampoPesquisar(this.txtSelecionarCodNome, "nome") == true)
                {
                    return;
                }
                else if (this.txtSelecionarCodNome.Text.Where(c => char.IsNumber(c)).Count() > 0)
                {
                    try
                    {
                        ListaEquipamento listaEquipamento = equipamentoNegocio.ConsultarPorCodigoOuDescricao(Convert.ToInt32(this.txtSelecionarCodNome.Text), null);
                        if(listaEquipamento.Count() > 0)
                        {
                            this.dgwSelecionarEquipamento.DataSource = null;
                            this.dgwSelecionarEquipamento.DataSource = listaEquipamento;
                            this.dgwSelecionarEquipamento.Update();
                            this.dgwSelecionarEquipamento.Refresh();
                            txtSelecionarCodNome.Focus();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Não existe nenhum equipamento com esse código: " + txtSelecionarCodNome.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);                 
                            txtSelecionarCodNome.Focus();
                            return;
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível inserir equipamento. Datalhes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSelecionarCodNome.Focus();
                        return;
                    }
                }
                else
                {
                    try
                    {
                        ListaEquipamento listaEquipamento = equipamentoNegocio.ConsultarPorCodigoOuDescricao(null, this.txtSelecionarCodNome.Text);
                        if (listaEquipamento.Count() > 0)
                        {
                            this.dgwSelecionarEquipamento.DataSource = null;
                            this.dgwSelecionarEquipamento.DataSource = listaEquipamento;
                            this.dgwSelecionarEquipamento.Update();
                            this.dgwSelecionarEquipamento.Refresh();
                            txtSelecionarCodNome.Focus();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Não existe nenhum equipamento com esse nome: " + txtSelecionarCodNome.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtSelecionarCodNome.Focus();
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível alterar equipamento. Detalhes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            FrmEquipamentoCadastrar frmEquipamentoCadastrar = new FrmEquipamentoCadastrar(AcaoNaTela.Inserir, null);
            DialogResult dialogResult = frmEquipamentoCadastrar.ShowDialog();
            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                AtualizarGridEquipamento(DialogResult.Yes);
            
        }

        private void btnSelecionarAlterar_Click(object sender, EventArgs e)
        {
            if(this.dgwSelecionarEquipamento.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum equipamento está selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Equipamento equipamentoSelecionado = (this.dgwSelecionarEquipamento.SelectedRows[0].DataBoundItem) as Equipamento;
            FrmEquipamentoCadastrar frmEquipamentoCadastrar = new FrmEquipamentoCadastrar(AcaoNaTela.Alterar, equipamentoSelecionado);
            DialogResult dialogResult = frmEquipamentoCadastrar.ShowDialog();
            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                AtualizarGridEquipamento(DialogResult.Yes);
        }

        private void dgwSelecionarEquipamento_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value is Boolean)
            {
                if(e.Value.Equals(true))
                    e.Value = "Sim";
                else
                    e.Value = "Não";
                
            }
        }

        private void dgwSelecionarEquipamento_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.btnSelecionarAlterar.PerformClick();
        }

        private void btnSelecionarPesquisar_MouseHover(object sender, EventArgs e)
        {
            ttpSelecionarPesquisar.Show("Pesquisar", btnSelecionarPesquisar);
        }

        private void btnSelecionarAlunoPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGridEquipamento(DialogResult.No);
        }

        private void btnSelecionarPesquisar_MouseHover_1(object sender, EventArgs e)
        {
            ttpSelecionarPesquisar.Show("Pesquisar", btnSelecionarPesquisar);
            btnSelecionarPesquisar.Image = global::Apresentacao.Properties.Resources.ic_search_grey600_24dp;
        }

        private void btnSelecionarPesquisar_MouseLeave(object sender, EventArgs e)
        {
            btnSelecionarPesquisar.Image = global::Apresentacao.Properties.Resources.ic_search_black_24dp1;     
        }


        private void FrmEquipamentoSelecionar_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.F1)
            {
                AtualizarGridEquipamento(DialogResult.No);
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
                AtualizarGridEquipamento(DialogResult.No);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        


    }
}
