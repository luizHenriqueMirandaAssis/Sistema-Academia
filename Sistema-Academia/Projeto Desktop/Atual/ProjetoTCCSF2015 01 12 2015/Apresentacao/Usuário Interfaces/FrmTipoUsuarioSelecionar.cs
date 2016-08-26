using Negocios;
using ObjetoTransferencia;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Apresentacao.Usuário_Interfaces
{
    public partial class FrmTipoUsuarioSelecionar : Form
    {
        public FrmTipoUsuarioSelecionar()
        {
            InitializeComponent();
            dgwSelecionarTipoUsuario.AutoGenerateColumns = false;
        }

        public void AtualizarGridTipoUsuario(DialogResult dialogResult)
        {
            using(TipoUsuarioNegocio tipoUsuarioNegocio = new TipoUsuarioNegocio())
            {
                ValidacaoInterfaces validarCampo = new ValidacaoInterfaces();
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        ListaTipoUsuario listaTipoUsuario = tipoUsuarioNegocio.ConsultarTipoUsuarioCodigoDescricao(null, "%");
                        dgwSelecionarTipoUsuario.DataSource = null;
                        dgwSelecionarTipoUsuario.DataSource = listaTipoUsuario;
                        dgwSelecionarTipoUsuario.Update();
                        dgwSelecionarTipoUsuario.Refresh();
                        txtSelecionarCodDescricao.Clear();
                        txtSelecionarCodDescricao.Focus();
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível atualizar, após ter inserido ou alterado o tipo de usuário. Detalhes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSelecionarCodDescricao.Focus();
                        return;
                    }

                }
                else if (validarCampo.ValidarCampoPesquisar(this.txtSelecionarCodDescricao, "descrição") == true)
                {
                    return;
                }
                else if(this.txtSelecionarCodDescricao.Text.Where(c=> char.IsNumber(c)).Count() > 0)
                {
                    try
                    {
                        ListaTipoUsuario listaTipoUsuario = tipoUsuarioNegocio.ConsultarTipoUsuarioCodigoDescricao(Convert.ToInt32(this.txtSelecionarCodDescricao.Text), null);

                        if (listaTipoUsuario.Count() > 0)
                        {
                            this.dgwSelecionarTipoUsuario.DataSource = null;
                            this.dgwSelecionarTipoUsuario.DataSource = listaTipoUsuario;
                            this.dgwSelecionarTipoUsuario.Update();
                            this.dgwSelecionarTipoUsuario.Refresh();
                            txtSelecionarCodDescricao.Focus();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Não existe nenhum tipo de usuário com esse código: " + txtSelecionarCodDescricao.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtSelecionarCodDescricao.Focus();
                            return;
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Não foi possível pesquisar o tipo de usuário por código. Detalhes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSelecionarCodDescricao.Focus();
                        return;
                    }
                }    
                else
                {
                    try
                    {
                        ListaTipoUsuario listaTipoUsuario = tipoUsuarioNegocio.ConsultarTipoUsuarioCodigoDescricao(null, this.txtSelecionarCodDescricao.Text);
                        if (listaTipoUsuario.Count() > 0)
                        {
                            this.dgwSelecionarTipoUsuario.DataSource = null;
                            this.dgwSelecionarTipoUsuario.DataSource = listaTipoUsuario;
                            this.dgwSelecionarTipoUsuario.Update();
                            this.dgwSelecionarTipoUsuario.Refresh();
                            txtSelecionarCodDescricao.Focus();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Não existe nenhum tipo de usuário com essa descrição: " + txtSelecionarCodDescricao.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtSelecionarCodDescricao.Focus();
                            return;
                        }

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Não foi possível pesquisar o tipo de usuário por descrição. Detalhes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSelecionarCodDescricao.Focus();
                        return;
                    }
                }

            }
        }

      

        private void btnSelecionarPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGridTipoUsuario(DialogResult.No);
        }

        private void dgwSelecionarTipoUsuario_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value is bool)
            {
                if ( e.Value.Equals(true))
                    e.Value = "Sim";
                else
                    e.Value = "Não";
            }
        }

        private void btnSelecionarCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelecionarInserir_Click(object sender, EventArgs e)
        {
            FrmTipoUsuarioCadastrar frmTipoUsuarioCadastrar = new FrmTipoUsuarioCadastrar(AcaoNaTela.Inserir, null);
            DialogResult dialogResult = frmTipoUsuarioCadastrar.ShowDialog();

            if(dialogResult == DialogResult.Yes)
             AtualizarGridTipoUsuario(DialogResult.Yes);
           
        }

        private void btnSelecionarAlterar_Click(object sender, EventArgs e)
        {
            if (dgwSelecionarTipoUsuario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum tipo de usuário está selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSelecionarCodDescricao.Focus();
                return;
            }

            TipoUsuario tipoUsuarioSelecionado = (dgwSelecionarTipoUsuario.SelectedRows[0].DataBoundItem as TipoUsuario);
            FrmTipoUsuarioCadastrar frmTipoUsuarioCadastrar = new FrmTipoUsuarioCadastrar(AcaoNaTela.Alterar, tipoUsuarioSelecionado);
            DialogResult dialogResult = frmTipoUsuarioCadastrar.ShowDialog();

            if (dialogResult == DialogResult.Yes)
                AtualizarGridTipoUsuario(DialogResult.Yes);

        }

        private void dgwSelecionarTipoUsuario_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.btnSelecionarAlterar.PerformClick();
        }

        private void btnSelecionarPesquisar_MouseHover(object sender, EventArgs e)
        {
            ttpSelecionarPesquisar.Show("Pesquisar", btnSelecionarPesquisar);
            btnSelecionarPesquisar.Image= global::Apresentacao.Properties.Resources.ic_search_grey600_24dp;
        }

        private void btnSelecionarPesquisar_MouseLeave(object sender, EventArgs e)
        {
            btnSelecionarPesquisar.Image= global::Apresentacao.Properties.Resources.ic_search_black_24dp1;
        }

        private void FrmTipoUsuarioSelecionar_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.F1)
            {
                AtualizarGridTipoUsuario(DialogResult.No);
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
                AtualizarGridTipoUsuario(DialogResult.No);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        
        


       
    }
}
