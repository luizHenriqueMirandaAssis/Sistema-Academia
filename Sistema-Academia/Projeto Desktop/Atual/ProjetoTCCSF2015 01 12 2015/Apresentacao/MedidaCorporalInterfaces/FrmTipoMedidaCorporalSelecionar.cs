using Negocios;
using ObjetoTransferencia;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Apresentacao.MedidaCorporalInterfaces
{
    public partial class FrmTipoMedidaCorporalSelecionar : Form
    {
        public FrmTipoMedidaCorporalSelecionar()
        {
            InitializeComponent();
            dgwSelecionarTipoMedidaCorporal.AutoGenerateColumns = false;
        }


        public void AtualizarGridTipoMedidaCorporal(DialogResult dialogResult)
        {
            using(TipoMedidaCorporalNegocio tipoMedidaNegocio = new TipoMedidaCorporalNegocio())
            {
                ValidacaoInterfaces validarInterfaces = new ValidacaoInterfaces();
                if(dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        ListaTipoMedidaCorporal listaTipoMedidaCorporal = tipoMedidaNegocio.PesquisarTipoMedidaCorporal(null, "%");
                        this.dgwSelecionarTipoMedidaCorporal.DataSource = null;
                        this.dgwSelecionarTipoMedidaCorporal.DataSource = listaTipoMedidaCorporal;
                        this.dgwSelecionarTipoMedidaCorporal.Update();
                        this.dgwSelecionarTipoMedidaCorporal.Refresh();
                        txtSelecionarCodDescricao.Focus();
                        txtSelecionarCodDescricao.Clear();
                        return;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Não foi possível atualizar, após ter inserido ou alterado tipo de medida corporal. Detalhes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else if(validarInterfaces.ValidarCampoPesquisar(txtSelecionarCodDescricao, "descrição") == true)
                {
                    return;
                }
                else if (txtSelecionarCodDescricao.Text.Where(c => char.IsNumber(c)).Count() > 0)
                {
                    try
                    {
                        ListaTipoMedidaCorporal listaTipoMedidaCorporal = tipoMedidaNegocio.PesquisarTipoMedidaCorporal(Convert.ToInt32(txtSelecionarCodDescricao.Text), null);
                        if (listaTipoMedidaCorporal.Count() > 0)
                        {
                            this.dgwSelecionarTipoMedidaCorporal.DataSource = null;
                            this.dgwSelecionarTipoMedidaCorporal.DataSource = listaTipoMedidaCorporal;
                            this.dgwSelecionarTipoMedidaCorporal.Update();
                            this.dgwSelecionarTipoMedidaCorporal.Refresh();
                            txtSelecionarCodDescricao.Focus();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Não existe nenhum tipo de medida corporal com esse código: " + txtSelecionarCodDescricao.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtSelecionarCodDescricao.Focus();
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível pesquisar tipo de medida corporal por código. Detalhes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSelecionarCodDescricao.Focus();
                        return;
                    }
                    
                }
                else
                {
                    try
                    {
                        ListaTipoMedidaCorporal listaTipoMedidaCorporal = tipoMedidaNegocio.PesquisarTipoMedidaCorporal(null, txtSelecionarCodDescricao.Text);
                        if (listaTipoMedidaCorporal.Count() > 0)
                        {
                            this.dgwSelecionarTipoMedidaCorporal.DataSource = null;
                            this.dgwSelecionarTipoMedidaCorporal.DataSource = listaTipoMedidaCorporal;
                            this.dgwSelecionarTipoMedidaCorporal.Update();
                            this.dgwSelecionarTipoMedidaCorporal.Refresh();
                            txtSelecionarCodDescricao.Focus();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Não existe nenhum tipo de medida corporal com essa descrição: " + txtSelecionarCodDescricao.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtSelecionarCodDescricao.Focus();
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível pesquisar tipo de medida corporal por descrição. Detalhes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSelecionarCodDescricao.Focus();
                        return;
                    }
                }



            }
        }

        private void FrmTipoMedidaCorporalSelecionar_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void btnSelecionarPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGridTipoMedidaCorporal(DialogResult.No);
        }

        private void btnSelecionarCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgwSelecionarTipoMedidaCorporal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 2 && e.Value is Boolean)
            {
                if (e.Value.Equals(true))
                    e.Value = "Sim";
                else
                    e.Value = "Não";               
                
            }
        }

        private void btnSelecionarInserir_Click(object sender, EventArgs e)
        {
            FrmTipoMedidaCorporalCadastrar frmTipoMedidaCorporal = new FrmTipoMedidaCorporalCadastrar(AcaoNaTela.Inserir, null);
            DialogResult dialogResult = frmTipoMedidaCorporal.ShowDialog();
            if (dialogResult == DialogResult.Yes)
                AtualizarGridTipoMedidaCorporal(DialogResult.Yes);
        }

        private void btnSelecionarAlterar_Click(object sender, EventArgs e)
        {
            if(this.dgwSelecionarTipoMedidaCorporal.SelectedRows.Count ==0)
            {
                MessageBox.Show("Nenhum tipo de medida corporal está selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSelecionarCodDescricao.Focus();
                return;
            }

            TipoMedidaCorporal tipoMedidaCorporalSelecionado = (this.dgwSelecionarTipoMedidaCorporal.SelectedRows[0].DataBoundItem) as TipoMedidaCorporal;
            FrmTipoMedidaCorporalCadastrar frmTipoMedidaCorporal = new FrmTipoMedidaCorporalCadastrar(AcaoNaTela.Alterar, tipoMedidaCorporalSelecionado);
            DialogResult dialogResult = frmTipoMedidaCorporal.ShowDialog();
            if (dialogResult == DialogResult.Yes)
                AtualizarGridTipoMedidaCorporal(DialogResult.Yes);

        }

        private void dgwSelecionarTipoMedidaCorporal_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.btnSelecionarAlterar.PerformClick();
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

        private void FrmTipoMedidaCorporalSelecionar_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            if (e.KeyCode == Keys.F1)
            {
                AtualizarGridTipoMedidaCorporal(DialogResult.No);
            }
            else if (e.KeyCode == Keys.F2)
            {
                this.btnSelecionarInserir.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                this.btnSelecionarAlterar.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Enter && txtSelecionarCodDescricao.Text != "")
            {
                this.btnSelecionarPesquisar.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
