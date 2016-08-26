using Negocios;
using ObjetoTransferencia;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Apresentacao.NoticiaInterfaces
{
    public partial class FrmNoticiaSelecionar : Form
    {
        public FrmNoticiaSelecionar()
        {
            InitializeComponent();
            this.dgwSelecionarNoticia.AutoGenerateColumns = false;
           
        }

        public void AtualizarGridNoticia(DialogResult dialogResult)
        {
            using (NoticiaNegocio noticiaNegocio = new NoticiaNegocio())
            {
                ValidacaoInterfaces validarInterfaces = new ValidacaoInterfaces();
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        ListaNoticia listaNoticia = noticiaNegocio.ConsultarNoticia(null, "%");
                        this.dgwSelecionarNoticia.DataSource = null;
                        this.dgwSelecionarNoticia.DataSource = listaNoticia;
                        this.dgwSelecionarNoticia.Update();
                        txtSelecionarCodTitulo.Focus();
                        txtSelecionarCodTitulo.Clear();
                        return;
                        
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Não foi possível atualizar, após ter inserido ou alterado notícia. Detalhes: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else if (validarInterfaces.ValidarCampoPesquisar(this.txtSelecionarCodTitulo, "título") == true)
                {
                    return;
                }
                else if (this.txtSelecionarCodTitulo.Text.Where(c => char.IsNumber(c)).Count() > 0)
                {

                    try
                    {
                        ListaNoticia listaNoticia = noticiaNegocio.ConsultarNoticia(Convert.ToInt32(this.txtSelecionarCodTitulo.Text), null);
                        if (listaNoticia.Count() > 0)
                        {
                            this.dgwSelecionarNoticia.DataSource = null;
                            this.dgwSelecionarNoticia.DataSource = listaNoticia;
                            this.dgwSelecionarNoticia.Update();
                            this.dgwSelecionarNoticia.Refresh();
                            txtSelecionarCodTitulo.Focus();                           
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Não existe nenhuma notícia com esse código: " + txtSelecionarCodTitulo.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtSelecionarCodTitulo.Focus();
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível pesquisar notícia por código. Detalhes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSelecionarCodTitulo.Focus();
                        return;
                    }
                }
                else
                {
                    try
                    {
                        ListaNoticia listaNoticia = noticiaNegocio.ConsultarNoticia(null, txtSelecionarCodTitulo.Text);
                        if (listaNoticia.Count() > 0)
                        {
                            this.dgwSelecionarNoticia.DataSource = null;
                            this.dgwSelecionarNoticia.DataSource = listaNoticia;
                            this.dgwSelecionarNoticia.Update();
                            this.dgwSelecionarNoticia.Refresh();
                            txtSelecionarCodTitulo.Focus();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Não existe nenhuma notícia com esse título: " + txtSelecionarCodTitulo.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtSelecionarCodTitulo.Focus();
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível pesquisar notícia por título. Detalhes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSelecionarCodTitulo.Focus();
                        return;
                    }
                }
            }
            
        }

        private void btnSelecionarPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGridNoticia(DialogResult.No);
        }

        private void btnSelecionarInserir_Click(object sender, EventArgs e)
        {
            FrmNoticiaCadastrar frmNoticiaCadastrar = new FrmNoticiaCadastrar(AcaoNaTela.Inserir, null);
            DialogResult dialogResult = frmNoticiaCadastrar.ShowDialog();
            if (dialogResult == DialogResult.Yes)
                AtualizarGridNoticia(DialogResult.Yes);

        }

        private void btnSelecionarCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelecionarAlterar_Click(object sender, EventArgs e)
        {
            if(this.dgwSelecionarNoticia.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma notícia está selecionada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSelecionarCodTitulo.Focus();
                return;
            }

            Noticia noticiaSelecionada = (this.dgwSelecionarNoticia.SelectedRows[0].DataBoundItem) as Noticia;
            FrmNoticiaCadastrar frmNoticiaCadastrar = new FrmNoticiaCadastrar(AcaoNaTela.Alterar, noticiaSelecionada);
            DialogResult dialogResult = frmNoticiaCadastrar.ShowDialog();
            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                AtualizarGridNoticia(DialogResult.Yes);
            
        }

        private void dgwSelecionarNoticia_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.btnSelecionarAlterar.PerformClick();
        }

        private void dgwSelecionarNoticia_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 3 && e.Value is Boolean)
            {
                if (e.Value.Equals(true))
                    e.Value = "Sim";
                else
                    e.Value = "Não";
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

        private void FrmNoticiaSelecionar_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.F1)
            {
                AtualizarGridNoticia(DialogResult.No);
            }
            else if (e.KeyCode == Keys.F2)
            {
                this.btnSelecionarInserir.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                this.btnSelecionarAlterar.PerformClick();
            }
            else if (this.txtSelecionarCodTitulo.Text != "" && e.KeyCode == Keys.Enter)
            {
                AtualizarGridNoticia(DialogResult.No);
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
