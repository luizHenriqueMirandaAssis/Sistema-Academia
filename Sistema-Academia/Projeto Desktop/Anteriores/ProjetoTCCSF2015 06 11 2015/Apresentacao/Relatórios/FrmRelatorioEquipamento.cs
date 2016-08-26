using System;
using System.Windows.Forms;

namespace Apresentacao.Relatórios
{
    public partial class FrmRelatorioEquipamento : Form
    {
        public FrmRelatorioEquipamento()
        {
            InitializeComponent();
        }

        private void FrmRelatorioEquipamento_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // PC DELL this.tblEquipamentoTableAdapter.Fill(this.tCCSF2015DataSet.tblEquipamento, txtRelatorioFiltroNome.Text);
            this.tblEquipamentoTableAdapter.Fill(this.tCCSF2015DataSet.tblEquipamento, txtRelatorioFiltroNome.Text);
           
            this.rpvEquipamento.RefreshReport();
        }


        private void FrmRelatorioEquipamento_KeyDown(object sender, KeyEventArgs e)
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
