using Negocios;
using ObjetoTransferencia;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Apresentacao.MedidaCorporalInterfaces
{
    public partial class FrmMedidaCorporalSelecionar : Form
    {
        public FrmMedidaCorporalSelecionar()
        {
            InitializeComponent();
            dgwSelecionarMedidaCorporal.AutoGenerateColumns = false;
        }

        private void btnSelecionarPesquisar_MouseHover(object sender, EventArgs e)
        {
            ttpSelecionarPesquisar.Show("Pesquisar", btnSelecionarPesquisar);
            btnSelecionarPesquisar.Image = global::Apresentacao.Properties.Resources.ic_search_grey600_24dp;
        }

        private void btnSelecionarCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgwSelecionarMedidaCorporal_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.btnSelecionarAlterar.PerformClick();
        }

        public void AtualizarGridMedidaCorporal(DialogResult dialogResult)
        {
             using (MedidaCorporalNegocio medidaCorporalNegocio = new MedidaCorporalNegocio())
             {
                 ValidacaoInterfaces validarInterfaces = new ValidacaoInterfaces();
                 if(dialogResult == DialogResult.Yes)
                 {
                     try
                     {
                         ListaMedidaCorporal listaMedidaCorporal = medidaCorporalNegocio.PesquisarMedidaCorporalCodigoNome(null, txtSelecionarCodAluno.Text);
                         this.dgwSelecionarMedidaCorporal.DataSource = null;
                         this.dgwSelecionarMedidaCorporal.DataSource = listaMedidaCorporal;
                         this.dgwSelecionarMedidaCorporal.Update();
                         this.dgwSelecionarMedidaCorporal.Refresh();
                         txtSelecionarCodAluno.Focus();
                         return;
                     }
                     catch(Exception ex)
                     {
                         MessageBox.Show("Não foi possível atualizar, após ter inserido ou alterado a medida corporal. Detalhes " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         return;
                     }
                 }
                 else if(validarInterfaces.ValidarCampoPesquisar(txtSelecionarCodAluno, "nome do aluno") == true)
                 {
                     return;
                 }
                 else if (txtSelecionarCodAluno.Text.Where(c => char.IsNumber(c)).Count() > 0)
                 {
                     try
                     {
                         ListaMedidaCorporal listaMedidaCorporal = medidaCorporalNegocio.PesquisarMedidaCorporalCodigoNome(Convert.ToInt32(this.txtSelecionarCodAluno.Text), null);
                         if (listaMedidaCorporal.Count() > 0)
                         {
                             this.dgwSelecionarMedidaCorporal.DataSource = null;
                             this.dgwSelecionarMedidaCorporal.DataSource = listaMedidaCorporal;
                             this.dgwSelecionarMedidaCorporal.Update();
                             this.dgwSelecionarMedidaCorporal.Refresh();
                             this.txtSelecionarCodAluno.Focus();
                             return;
                         }
                         else
                         {
                             MessageBox.Show("Não existe nenhuma medida corporal com esse código: " + txtSelecionarCodAluno.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             this.txtSelecionarCodAluno.Focus();
                             return;
                         }
                     }
                     catch (Exception ex)
                     {
                         MessageBox.Show("Não foi possível pesquisar a medida corporal por código. Detalhes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         txtSelecionarCodAluno.Focus();
                         return;
                     }
                 }
                 else
                 {
                     try
                     {
                         ListaMedidaCorporal listaMedidaCorporal = medidaCorporalNegocio.PesquisarMedidaCorporalCodigoNome(null, txtSelecionarCodAluno.Text);
                         if(listaMedidaCorporal.Count() > 0)
                         {
                             this.dgwSelecionarMedidaCorporal.DataSource = null;
                             this.dgwSelecionarMedidaCorporal.DataSource = listaMedidaCorporal;
                             this.dgwSelecionarMedidaCorporal.Update();
                             this.dgwSelecionarMedidaCorporal.Refresh();
                             this.txtSelecionarCodAluno.Focus();
                             return;
                         }
                         else
                         {
                             MessageBox.Show("Não existe nenhuma medida corporal com esse aluno: " + txtSelecionarCodAluno.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             this.txtSelecionarCodAluno.Focus();
                             return;
                         }
                     }
                     catch (Exception ex)
                     {
                         MessageBox.Show("Não foi possível pesquisar a medida corporal por aluno. Detalhes: "+ ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         this.txtSelecionarCodAluno.Focus();
                         return;
                     }
                 }
             }
        }

        private void dgwSelecionarMedidaCorporal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
            if(e.ColumnIndex == 0 && e.Value is Aluno)
            {
                e.Value = (e.Value as Aluno).Pessoa.IDPessoa;
            }
            if(e.ColumnIndex == 1 && e.Value is Aluno)
            {
                e.Value = (e.Value as Aluno).Pessoa.Nome;
            }
            if(e.ColumnIndex == 3 && e.Value is bool)
            {
                if (e.Value.Equals(true))
                    e.Value = "Sim";
                else
                    e.Value = "não";

            }
        }

        private void btnSelecionarPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGridMedidaCorporal(DialogResult.No);
        }

        private void btnSelecionarInserir_Click(object sender, EventArgs e)
        {
            if (dgwSelecionarMedidaCorporal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum aluno está selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MedidaCorporal medidaCorporalSelecionada = (dgwSelecionarMedidaCorporal.SelectedRows[0].DataBoundItem) as MedidaCorporal;
            FrmMedidaCorporalCadastrar frmMedidaCorporal = new FrmMedidaCorporalCadastrar(AcaoNaTela.Inserir, medidaCorporalSelecionada);
            DialogResult dialogResult = frmMedidaCorporal.ShowDialog();
            if (dialogResult == DialogResult.Yes)
                AtualizarGridMedidaCorporal(DialogResult.Yes);
            else
                txtSelecionarCodAluno.Focus();
        }

        private void btnSelecionarAlterar_Click(object sender, EventArgs e)
        {
            if(dgwSelecionarMedidaCorporal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum aluno está selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MedidaCorporal medidaCorporalSelecionada = (dgwSelecionarMedidaCorporal.SelectedRows[0].DataBoundItem) as MedidaCorporal;
            DateTime dateTime = Convert.ToDateTime("01/01/1900");
            if(medidaCorporalSelecionada.DataMedida <= dateTime)
            {
                MessageBox.Show("Não é possível alterar, pois não existe nenhuma medida corporal cadastrada com este aluno", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FrmMedidaCorporalCadastrar frmMedidaCorporalCadastrar = new FrmMedidaCorporalCadastrar(AcaoNaTela.Alterar, medidaCorporalSelecionada);
            DialogResult dialogResult = frmMedidaCorporalCadastrar.ShowDialog();
            if (dialogResult == DialogResult.Yes)
                AtualizarGridMedidaCorporal(DialogResult.Yes);
            else
                txtSelecionarCodAluno.Focus();
            

        }

        private void btnSelecionarPesquisar_MouseLeave(object sender, EventArgs e)
        {
            btnSelecionarPesquisar.Image = global::Apresentacao.Properties.Resources.ic_search_black_24dp1;
        }

        private void FrmMedidaCorporalSelecionar_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.F1)
            {
                this.btnSelecionarPesquisar.PerformClick();
            }
            else if (e.KeyCode == Keys.F2)
            {
                this.btnSelecionarInserir.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                this.btnSelecionarAlterar.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter && txtSelecionarCodAluno.Text != "")
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                this.btnSelecionarPesquisar.PerformClick();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
