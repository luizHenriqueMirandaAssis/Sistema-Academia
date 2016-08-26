using System;
using System.Windows.Forms;

namespace Apresentacao.MedidaCorporalInterfaces.Relatório
{
    public partial class FrmRelatorioAvalicaoFisica : Form
    {
        int codigoInformado;
        DateTime dataInicialInformado;
        DateTime dataFinalInformado;
        public FrmRelatorioAvalicaoFisica(int codigo, DateTime dataInicial, DateTime dataFinal)
        {
            InitializeComponent();
            codigoInformado = codigo;
            dataInicialInformado = dataInicial;
            dataFinalInformado = dataFinal;
        }

        private void FrmRelatorioAvalicaoFisica_Load(object sender, EventArgs e)
        {
            
            this.uspMedidaCorporalRelatorioDataInicialTableAdapter.Fill(tCCSF2015DataSet1.uspMedidaCorporalRelatorioDataInicial, codigoInformado, dataInicialInformado);
            this.uspMedidaCorporalRelatorioDataFinalTableAdapter.Fill(tCCSF2015DataSet1.uspMedidaCorporalRelatorioDataFinal, codigoInformado, dataFinalInformado);
            this.rpvAvaliacoesFisicas.RefreshReport();

        }
    }
}
