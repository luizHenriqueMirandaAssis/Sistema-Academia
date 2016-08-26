using Negocios;
using ObjetoTransferencia;
using System;
using System.Linq;
using System.Windows.Forms;


namespace Apresentacao
{
    public partial class FrmAlunoSelecionar : Form 
    {
        public Aluno alunoFiltroSelecionado = new Aluno();
        AcaoNaTela acaoNaTelaInformada;
        

        public FrmAlunoSelecionar( AcaoNaTela AcaoNatela)
        {
            InitializeComponent();
            dgwSelecionarAluno.AutoGenerateColumns = false;
            acaoNaTelaInformada = AcaoNatela;


            if(acaoNaTelaInformada == AcaoNaTela.Selecionar)
            {
               
                btnSelecionarAlunoInserir.Enabled = false;
                btnSelecionarAlunoInserir.Visible = false;
                btnSelecionarAlunoAlterar.Text = "Selecionar";
            }

        }


        public void AtualizarGridAluno(DialogResult dialogResult)
        {
            using (AlunoNegocio alunoNegocio = new AlunoNegocio())
            {
                ValidacaoInterfaces validarInterfaces = new ValidacaoInterfaces();
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        
                        ListaAluno listaAluno = alunoNegocio.PesquisarAlunoNomeOuCodigo(null, "%");
                        dgwSelecionarAluno.DataSource = null;
                        dgwSelecionarAluno.DataSource = listaAluno;
                        dgwSelecionarAluno.Update();
                        dgwSelecionarAluno.Refresh();
                        txtSelecionarAlunoCodNome.Focus();
                        txtSelecionarAlunoCodNome.Clear();
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível pesquisar apos ter inserido um novo aluno. Detalhes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSelecionarAlunoCodNome.Focus();
                        return;
                    }
                }

                else if (validarInterfaces.ValidarCampoPesquisar(this.txtSelecionarAlunoCodNome, "nome") == true)
                {
                    return;
                } 

                else if (txtSelecionarAlunoCodNome.Text.Where(c => char.IsNumber(c)).Count() > 0)
                {
                    try
                    {                        
                        ListaAluno listaAluno = alunoNegocio.PesquisarAlunoNomeOuCodigo(Convert.ToInt32(txtSelecionarAlunoCodNome.Text), null);
                        if(listaAluno.Count() >0)
                        {
                            dgwSelecionarAluno.DataSource = null;
                        dgwSelecionarAluno.DataSource = listaAluno;
                        dgwSelecionarAluno.Update();
                        dgwSelecionarAluno.Refresh();

                        txtSelecionarAlunoCodNome.Focus();
                        return;
                        }
                        else
                        {
                            MessageBox.Show("Não existe nenhum aluno com esse código: " + txtSelecionarAlunoCodNome.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtSelecionarAlunoCodNome.Focus();
                            return;
                        }
                        
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Não foi possível pesquisar aluno por código. Detalhes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSelecionarAlunoCodNome.Focus();
                        return;
                    }

                }
                else
                {
                    try
                    {
                        ListaAluno listaAluno = alunoNegocio.PesquisarAlunoNomeOuCodigo(null, txtSelecionarAlunoCodNome.Text);
                        if (listaAluno.Count() > 0)
                        {
                            dgwSelecionarAluno.DataSource = null;
                            dgwSelecionarAluno.DataSource = listaAluno;
                            dgwSelecionarAluno.Update();
                            dgwSelecionarAluno.Refresh();
                            txtSelecionarAlunoCodNome.Focus();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Não existe nenhum aluno com esse nome: " + txtSelecionarAlunoCodNome.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtSelecionarAlunoCodNome.Focus();
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível pesquisae aluno por nome. Detalhes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSelecionarAlunoCodNome.Focus();
                        return;
                    }

                }

            }

        }


        private void btnSelecionarAlunoPesquisar_Click(object sender, EventArgs e)
        {          
            AtualizarGridAluno(DialogResult.No);
        }

        private void btnSelecionarAlunoInserir_Click(object sender, EventArgs e)
        {         
                FrmAlunoCadastrar frmAlunocadastrar = new FrmAlunoCadastrar(AcaoNaTela.Inserir, null);
                DialogResult dialogResult = frmAlunocadastrar.ShowDialog();

                if (dialogResult == DialogResult.Yes)
                    AtualizarGridAluno(DialogResult.Yes);           
        }

        private void btnSelecionarAlunoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnSelecionarAlunoAlterar_Click(object sender, EventArgs e)
        {
            if(dgwSelecionarAluno.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum aluno está selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(acaoNaTelaInformada == AcaoNaTela.Alterar)
            {
                Aluno alunoSelecionado = (dgwSelecionarAluno.SelectedRows[0].DataBoundItem as Aluno);
           
                FrmAlunoCadastrar frmAlunocadastrar = new FrmAlunoCadastrar(AcaoNaTela.Alterar, alunoSelecionado);
                DialogResult dialogResult = frmAlunocadastrar.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                    AtualizarGridAluno(DialogResult.Yes);   
            }
            else if(acaoNaTelaInformada == AcaoNaTela.Selecionar)
            {
                alunoFiltroSelecionado = (dgwSelecionarAluno.SelectedRows[0].DataBoundItem) as Aluno;
                this.DialogResult = DialogResult.Yes;
            }

                     

        }

        private void dgwSelecionarAluno_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.Value is Pessoa)
            {
                e.Value = (e.Value as Pessoa).IDPessoa;
            }

            if (e.ColumnIndex == 1 && e.Value is Pessoa)
            {
                e.Value = (e.Value as Pessoa).Nome;
            }

            if (e.ColumnIndex == 2 && e.Value is Pessoa)
            {
                if (true == (e.Value as Pessoa).Sexo)              
                    e.Value = "Masculino";              
                else                
                    e.Value = "Feminino";                
            }

            if (e.ColumnIndex == 3 && e.Value is Pessoa)
            {
                e.Value = (e.Value as Pessoa).DataNascimento.ToShortDateString();
            }

            if (e.ColumnIndex == 4 && e.Value is Objetivo)
            {
                e.Value = (e.Value as Objetivo).Descricao;
            }

            if (e.ColumnIndex == 5 && e.Value is Pessoa)
            {
                if( true == (e.Value as Pessoa).Ativo)              
                    e.Value = "Sim";
                else
                    e.Value = "Não";
            }
            
            
        }


        private void btnSelecionarAlunoPesquisar_MouseHover(object sender, EventArgs e)
        {
            ttpFrmSelecionar.Show("Pesquisar", btnSelecionarAlunoPesquisar);
            btnSelecionarAlunoPesquisar.Image = global::Apresentacao.Properties.Resources.ic_search_grey600_24dp;
        }


        private void dgwSelecionarAluno_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
                if (acaoNaTelaInformada == AcaoNaTela.Alterar)
                {
                    this.btnSelecionarAlunoAlterar.PerformClick();
                }
                else if (acaoNaTelaInformada == AcaoNaTela.Selecionar)
                {
                    this.btnSelecionarAlunoAlterar.PerformClick();
                }
            
         
        }

        private void btnSelecionarAlunoPesquisar_MouseLeave(object sender, EventArgs e)
        {
            btnSelecionarAlunoPesquisar.Image = global::Apresentacao.Properties.Resources.ic_search_black_24dp1;
        }

        private void FrmAlunoSelecionar_KeyDown(object sender, KeyEventArgs e)
        {
           
           
            if (e.KeyCode == Keys.F1)
            {
                AtualizarGridAluno(DialogResult.No);
            }
            else if (e.KeyCode == Keys.F2)
            {
                this.btnSelecionarAlunoInserir.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                this.btnSelecionarAlunoAlterar.PerformClick();
            }
            else if (txtSelecionarAlunoCodNome.Text != "" && e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                btnSelecionarAlunoPesquisar.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

       
    }
}
