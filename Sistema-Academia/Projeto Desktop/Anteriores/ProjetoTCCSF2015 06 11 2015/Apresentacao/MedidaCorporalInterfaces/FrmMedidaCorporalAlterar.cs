using Negocios;
using ObjetoTransferencia;
using System;
using System.Windows.Forms;

namespace Apresentacao.MedidaCorporalInterfaces
{
    public partial class FrmMedidaCorporalAlterar : Form
    {
        public FrmMedidaCorporalAlterar(MedidaCorporal medidaCorporal)
        {
            InitializeComponent();
            this.txtCadastrarCentimetro.Text = medidaCorporal.MedidaCm.ToString();
            this.txtAlterarTipoMedidaCorporal.Text = medidaCorporal.TipoMedidaCorporal.Descricao;
            this.txtCodigo.Text = medidaCorporal.IDMedidaCorporal.ToString();
        }


        private void btnAlterar_Click(object sender, EventArgs e)
        {
            using (MedidaCorporalNegocio medidaCorporalNegocio = new MedidaCorporalNegocio())
            {
                ValidacaoInterfaces validarInterfaces = new ValidacaoInterfaces();
                if(validarInterfaces.validarCampoCadastrar(grpMedidaCorporalAlterar.Controls) == true)
                {
                    return;
                }
                MedidaCorporal medidaCorporalAlterar = new MedidaCorporal()
                {
                    IDMedidaCorporal = Convert.ToInt32(txtCodigo.Text),
                    MedidaCm = Convert.ToDecimal(txtCadastrarCentimetro.Text)
                };

                string retorno = medidaCorporalNegocio.Alterar(medidaCorporalAlterar);
                try
                {
                    int codigo = Convert.ToInt32(retorno);
                    MessageBox.Show("Medida corporal alterada com sucesso. Detalhes: " + codigo.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Não foi possível Alterar Medida Corporal");
                    return;
                }


               
            }
              
        }

        private void FrmMedidaCorporalAlterar_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if(e.KeyCode == Keys.F1)
            {
                btnAlterar.PerformClick();
            }
            if (e.KeyCode == Keys.Enter)
            {
                txtCadastrarCentimetro.Select();
            }
            if (txtCadastrarCentimetro.Text != "" && e.KeyCode == Keys.Enter)
            {
                btnAlterar.PerformClick();
            }
        }
    }
}
