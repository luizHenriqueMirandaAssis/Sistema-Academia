using System;
using System.Linq;
using System.Windows.Forms;


namespace Apresentacao.Relatórios
{
    public partial class FrmRelatorioAllAluno : Form
    {
        public FrmRelatorioAllAluno()
        {
            InitializeComponent();
            txtRelatorioFiltroCodigoNome.Select();
        }

        private void FrmRelatorioAllAluno_Load(object sender, EventArgs e)
        {
            

          
        }

        private void btnRelatorioExecutar_Click(object sender, EventArgs e)
        {
            ValidacaoInterfaces validarInterfaces = new ValidacaoInterfaces();
           // if(validarInterfaces.ValidarCampoPesquisar(txtRelatorioFiltroCodigoNome, "nome") == true)
           // {
            //    return;
            //}

            
            if(txtRelatorioFiltroCodigoNome.Text.Where(c=> char.IsNumber(c)).Count() > 0)
            {
                this.rpvRelatorioPorAluno.Enabled = false;
                this.rpvRelatorioPorAluno.Visible = false;
                this.uspAlunoPesquisarNomeOuCodigoTableAdapter1.Fill(this.tCCSF2015DataSet.uspAlunoPesquisarNomeOuCodigo, Convert.ToInt32(txtRelatorioFiltroCodigoNome.Text), null);
                this.rpvRelatorioAluno.RefreshReport();
                 this.txtRelatorioFiltroCodigoNome.Clear();
            
            }
            else if(txtRelatorioFiltroCodigoNome.Text.Where(c=> char.IsLetter(c)).Count() > 0)
            {
               // this.rpvRelatorioAluno.Visible = false;
               // this.rpvRelatorioAluno.Enabled = false;
               // this.rpvRelatorioPorAluno.Visible = true;
                //this.rpvRelatorioPorAluno.Enabled = true;
                //this.uspTreinamentoPesquisarIDAlunoNomeAlunoTableAdapter.Fill(this.tCCSF2015PC1DataSet1.uspTreinamentoPesquisarIDAlunoNomeAluno, null, txtRelatorioFiltroCodigoNome.Text);

               // this.uspMedidaCorporalPesquisarCodigoAlunoOuNomeAlunoTableAdapter.Fill(this.tCCSF2015PC1DataSet1.uspMedidaCorporalPesquisarCodigoAlunoOuNomeAluno, null, txtRelatorioFiltroCodigoNome.Text);
                this.rpvRelatorioPorAluno.Enabled = false;
                this.rpvRelatorioPorAluno.Visible = false;
                this.uspAlunoPesquisarNomeOuCodigoTableAdapter1.Fill(this.tCCSF2015DataSet.uspAlunoPesquisarNomeOuCodigo, null, txtRelatorioFiltroCodigoNome.Text);
                this.rpvRelatorioAluno.RefreshReport();              
            }
            else if(txtRelatorioFiltroCodigoNome.Text == "")
            {
                this.rpvRelatorioPorAluno.Enabled = false;
                this.rpvRelatorioPorAluno.Visible = false;
                this.rpvRelatorioAluno.Visible = true;
                this.rpvRelatorioAluno.Enabled = true;
                this.uspAlunoPesquisarNomeOuCodigoTableAdapter1.Fill(this.tCCSF2015DataSet.uspAlunoPesquisarNomeOuCodigo, null, "%");
                this.rpvRelatorioAluno.RefreshReport();
                this.txtRelatorioFiltroCodigoNome.Clear();
            }
           
       
        }

        private void FrmRelatorioAllAluno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRelatorioExecutar.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
