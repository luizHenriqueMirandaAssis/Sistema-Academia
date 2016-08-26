using Apresentacao.ObjetivoInterfaces;
using Negocios;
using ObjetoTransferencia;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Apresentacao.Aluno_Interfaces
{
    public partial class FrmObjetivoSelecionar : Form
    {
       

        public FrmObjetivoSelecionar()
        {
           
            InitializeComponent();
            this.dgwSelecionarObjetivo.AutoGenerateColumns = false;
         
        }

      public void  AtualizarGridObjetivo(DialogResult dialogResult)
        {
          using(ObjetivoNegocio objetivoNegocio = new ObjetivoNegocio())
          {
              ValidacaoInterfaces validarInterfaces = new ValidacaoInterfaces();
              if (dialogResult == DialogResult.Yes)
              {
                  try
                  { 
                          ListaObjetivo listaObjetivo = objetivoNegocio.ConsultarObjetivoCodigoDescricao(null, "%");                  
                          dgwSelecionarObjetivo.DataSource = null;
                          dgwSelecionarObjetivo.DataSource = listaObjetivo;
                          dgwSelecionarObjetivo.Update();
                          dgwSelecionarObjetivo.Refresh();
                          txtSelecionarCodNome.Clear();
                          txtSelecionarCodNome.Focus();
                          return;                 
                  }
                  catch(Exception ex)
                  {
                      MessageBox.Show("Não foi possível atualizar, após ter inserido ou alterado objetivo. Detalhes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      return;
                  }               
              }

              
             else if( validarInterfaces.ValidarCampoPesquisar(this.txtSelecionarCodNome, "descrição") == true)
             {
                 return;
             }

              else if (this.txtSelecionarCodNome.Text.Where(c => char.IsNumber(c)).Count() > 0)
              {
                  try
                  {
                      ListaObjetivo listaObjetivo = objetivoNegocio.ConsultarObjetivoCodigoDescricao(Convert.ToInt32(this.txtSelecionarCodNome.Text), null);
                      if (listaObjetivo.Count() > 0)
                      {
                          dgwSelecionarObjetivo.DataSource = null;
                          dgwSelecionarObjetivo.DataSource = listaObjetivo;
                          dgwSelecionarObjetivo.Update();
                          dgwSelecionarObjetivo.Refresh();
                          txtSelecionarCodNome.Focus();
                          return;
                      }
                      else
                      {
                          MessageBox.Show("Não existe nenhum objetivo com esse código: " + txtSelecionarCodNome.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                          txtSelecionarCodNome.Focus();
                          return;
                      }
                  }
                  catch (Exception ex)
                  {
                      MessageBox.Show("Não foi possível pesquisar objetivo por código. Detalhes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      txtSelecionarCodNome.Focus();
                      return;
                  }
              }
              else
              {
                  try 
                  {
                      ListaObjetivo listaObjetivo = objetivoNegocio.ConsultarObjetivoCodigoDescricao(null, this.txtSelecionarCodNome.Text);
                      if (listaObjetivo.Count() > 0)
                      {
                          dgwSelecionarObjetivo.DataSource = null;
                          dgwSelecionarObjetivo.DataSource = listaObjetivo;
                          dgwSelecionarObjetivo.Update();
                          dgwSelecionarObjetivo.Refresh();
                          txtSelecionarCodNome.Focus();
                          return;
                      }
                      else
                      {
                          MessageBox.Show("Não existe nenhum objetivo com essa descrição: " + txtSelecionarCodNome.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                          txtSelecionarCodNome.Focus();                          
                          return;
                      }
                  }
                  catch(Exception ex)
                  {
                      MessageBox.Show("Não foi possível pesquisar objetivo por descrição. Detalhes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
          FrmObjetivoCadastrar frmObjetivoCadastrar = new FrmObjetivoCadastrar(AcaoNaTela.Inserir, null);
          DialogResult dialogResult = frmObjetivoCadastrar.ShowDialog();
          if(dialogResult == DialogResult.Yes)
          AtualizarGridObjetivo(DialogResult.Yes); 

      }

      private void btnSelecionarAlterar_Click(object sender, EventArgs e)   
      {
          if(this.dgwSelecionarObjetivo.SelectedRows.Count == 0)
          {
              MessageBox.Show("Nenhum objetivo está selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information );
              return;
          }

          Objetivo objetivoSelecionado = (this.dgwSelecionarObjetivo.SelectedRows[0].DataBoundItem) as Objetivo;
          FrmObjetivoCadastrar frmObjetivoCadastrar = new FrmObjetivoCadastrar(AcaoNaTela.Alterar, objetivoSelecionado);
          DialogResult dialogResult = frmObjetivoCadastrar.ShowDialog();
          if(dialogResult == DialogResult.Yes)         
              AtualizarGridObjetivo(DialogResult.Yes);
          
       }

      private void btnSelecionarPesquisar_Click(object sender, EventArgs e)
      {
          AtualizarGridObjetivo(DialogResult.No);
      }


      private void dgwSelecionarObjetivo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
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

      private void FrmObjetivoSelecionar_KeyDown(object sender, KeyEventArgs e)
      {
          
          if (e.KeyCode == Keys.F1)
          {
              AtualizarGridObjetivo(DialogResult.No);
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
              AtualizarGridObjetivo(DialogResult.No);
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
