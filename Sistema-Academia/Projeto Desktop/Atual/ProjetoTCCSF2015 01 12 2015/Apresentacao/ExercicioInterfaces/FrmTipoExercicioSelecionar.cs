using Negocios;
using ObjetoTransferencia;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Apresentacao.ExercicioInterfaces
{
    public partial class FrmTipoExercicioSelecionar : Form
    {
        public FrmTipoExercicioSelecionar()
        {
            InitializeComponent();
            this.dgwSelecionarTipoExercicio.AutoGenerateColumns = false;
        }

        public void AtualizarGridTipoExercicio(DialogResult dialogResult)
        {
            using (TipoExercicioNegocio tipoExercicioNegocio = new TipoExercicioNegocio())
            {
                ValidacaoInterfaces validarInterfaces = new ValidacaoInterfaces();
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        ListaTipoExercicio listaTipoExercicio = tipoExercicioNegocio.PesquisarTipoExercicioPorCodigoOuDescricao(null, "%");
                        this.dgwSelecionarTipoExercicio.DataSource = null;
                        this.dgwSelecionarTipoExercicio.DataSource = listaTipoExercicio;
                        this.dgwSelecionarTipoExercicio.Update();
                        this.dgwSelecionarTipoExercicio.Refresh();
                        txtSelecionarCodDescricao.Focus();
                        txtSelecionarCodDescricao.Clear();
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível atualizar, após ter inserido ou alterado o tipo de exercício. Detalhes: "+ ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information );
                        txtSelecionarCodDescricao.Focus();
                        return;
                    }
                }              
                else if (validarInterfaces.ValidarCampoPesquisar(this.txtSelecionarCodDescricao, "descrição") == true)
                {
                    return;
                }

                else if(this.txtSelecionarCodDescricao.Text.Where(c=> char.IsNumber(c)).Count() > 0)
                {
                    try
                    {
                        ListaTipoExercicio listaTipoExercicio = tipoExercicioNegocio.PesquisarTipoExercicioPorCodigoOuDescricao(Convert.ToInt32(this.txtSelecionarCodDescricao.Text), null);
                        if(listaTipoExercicio.Count() > 0)
                        {
                            this.dgwSelecionarTipoExercicio.DataSource = null;
                            this.dgwSelecionarTipoExercicio.DataSource = listaTipoExercicio;
                            this.dgwSelecionarTipoExercicio.Update();
                            this.dgwSelecionarTipoExercicio.Refresh();
                            txtSelecionarCodDescricao.Focus();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Não existe nenhum tipo de exercício com esse código: " + txtSelecionarCodDescricao.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtSelecionarCodDescricao.Focus();
                            return;
                        }

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Não foi possível pesquisar por código. Detalhes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSelecionarCodDescricao.Focus();
                        return;
                    }
                }
                else
                {
                    try
                    {
                        ListaTipoExercicio listaTipoExercicio = tipoExercicioNegocio.PesquisarTipoExercicioPorCodigoOuDescricao(null, this.txtSelecionarCodDescricao.Text);
                        if (listaTipoExercicio.Count() > 0)
                        {
                            this.dgwSelecionarTipoExercicio.DataSource = null;
                            this.dgwSelecionarTipoExercicio.DataSource = listaTipoExercicio;
                            this.dgwSelecionarTipoExercicio.Update();
                            this.dgwSelecionarTipoExercicio.Refresh();
                            txtSelecionarCodDescricao.Focus();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Não existe nenhum tipo de exercício com essa descrição: " + txtSelecionarCodDescricao.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtSelecionarCodDescricao.Focus();
                            return;
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível pesquisar por descrição. Detalhes: " +ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSelecionarCodDescricao.Focus();
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
            FrmTipoExercicioCadastrar frmTipoExercicioCadastrar = new FrmTipoExercicioCadastrar(AcaoNaTela.Inserir, null);
            DialogResult dialogResult = frmTipoExercicioCadastrar.ShowDialog();
            if (dialogResult == DialogResult.Yes)
                AtualizarGridTipoExercicio(DialogResult.Yes);

        }

        private void btnSelecionarPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGridTipoExercicio(DialogResult.No);
        }

        private void dgwSelecionarTipoExercicio_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value is bool)
               if(e.Value.Equals(true))
                e.Value = "Sim";
            else
                e.Value = "Não";
                
            
        }

        private void btnSelecionarAlterar_Click(object sender, EventArgs e)
        {
            if (this.dgwSelecionarTipoExercicio.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum tipo de exercício está selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSelecionarCodDescricao.Focus();
                return;
            }

            TipoExercicio tipoExercicioSelecionado = (this.dgwSelecionarTipoExercicio.SelectedRows[0].DataBoundItem) as TipoExercicio;
            FrmTipoExercicioCadastrar frmTipoExercicioCadastrar = new FrmTipoExercicioCadastrar(AcaoNaTela.Alterar, tipoExercicioSelecionado);
            DialogResult dialogResult = frmTipoExercicioCadastrar.ShowDialog();
            if (dialogResult == DialogResult.Yes)
                AtualizarGridTipoExercicio(DialogResult.Yes);        
        }

        private void dgwSelecionarTipoExercicio_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
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

        private void FrmTipoExercicioSelecionar_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.F1)
            {
                AtualizarGridTipoExercicio(DialogResult.No);
            }
            else if (e.KeyCode == Keys.F2)
            {
                this.btnSelecionarInserir.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                this.btnSelecionarAlterar.PerformClick();
            }
            else if (this.txtSelecionarCodDescricao.Text != "" && e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                AtualizarGridTipoExercicio(DialogResult.No);

            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
