using Negocios;
using ObjetoTransferencia;
using System;
using System.Windows.Forms;


namespace Apresentacao.MedidaCorporalInterfaces.Relatório
{
    public partial class FrmFiltroRelatorioAvaliacaoFisica : Form
    {
        public FrmFiltroRelatorioAvaliacaoFisica()
        {
            InitializeComponent();
        }

        public void CarregarFiltroDataAluno(int codigo)
        {
            btnRelatorioGerar.Enabled = true;
             using (MedidaCorporalNegocio medidaCorporalNegocio = new MedidaCorporalNegocio())
            {
                ListaMedidaCorporal listaMedidaCorporal = medidaCorporalNegocio.FiltroPorData(codigo);

                 cbxDataFinal.Enabled = true;               
                 this.cbxDataFinal.DataSource = listaMedidaCorporal;
                this.cbxDataFinal.DisplayMember = "DataMedida";
                this.cbxDataFinal.ValueMember = "DataMedida";
            }

             using (MedidaCorporalNegocio medidaCorporalNegocio = new MedidaCorporalNegocio())
             {
                 ListaMedidaCorporal listaMedidaCorporal = medidaCorporalNegocio.FiltroPorData(codigo);        
                 cbxDataInicio.Enabled = true;
                 this.cbxDataInicio.DataSource = listaMedidaCorporal;
                 this.cbxDataInicio.DisplayMember = "DataMedida";
                 this.cbxDataInicio.ValueMember = "DataMedida";
             }
        }

        private void btnSelecionarAlunoInserir_Click(object sender, EventArgs e)
        {
            FrmRelatorioAvalicaoFisica frmRelatorioAvalicaoFisica = new FrmRelatorioAvalicaoFisica(Convert.ToInt32(txtSelecionarFiltroAlunoCodigo.Text), Convert.ToDateTime(cbxDataInicio.SelectedValue), Convert.ToDateTime(cbxDataFinal.SelectedValue));
            frmRelatorioAvalicaoFisica.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAlunoSelecionar frmAlunoSelecionar = new FrmAlunoSelecionar(AcaoNaTela.Selecionar);
            DialogResult dialogResult = frmAlunoSelecionar.ShowDialog();
            if(dialogResult == DialogResult.Yes)
            {
                Aluno alunoSelecionado = frmAlunoSelecionar.alunoFiltroSelecionado;
                txtSelecionarFiltroAlunoNome.Text = alunoSelecionado.Pessoa.Nome;
                txtSelecionarFiltroAlunoCodigo.Text = alunoSelecionado.Pessoa.IDPessoa.ToString();
                txtSelecionarFiltroAlunoNome.ReadOnly = true;

                CarregarFiltroDataAluno(alunoSelecionado.Pessoa.IDPessoa);
            }

        }

        private void FrmFiltroRelatorioAvaliacaoFisica_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                btnRelatorioGerar.PerformClick();
            }
            else if(e.KeyCode == Keys.F2)
            {
                btnRelatorioCancelar.PerformClick();
            }
            else if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }  

       
 


    }
}
