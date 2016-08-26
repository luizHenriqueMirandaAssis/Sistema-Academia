using Negocios;
using ObjetoTransferencia;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Apresentacao.MedidaCorporalInterfaces
{
    public partial class FrmMedidaCorporalCadastrar : Form
    {
        AcaoNaTela acaoNaTelaInformada;
        public FrmMedidaCorporalCadastrar(AcaoNaTela acaoNaTela, MedidaCorporal medidaCorporal)
        {
            acaoNaTelaInformada = acaoNaTela;
            InitializeComponent();
            this.dgwMedidaCorporal.AutoGenerateColumns = false;
            this.cbxCadastrarTipoMedida.Select();
            

            using(TipoMedidaCorporalNegocio tipoMedidaNegocio = new TipoMedidaCorporalNegocio())
            {
                ListaTipoMedidaCorporal listaTipoMedidaCorporal = tipoMedidaNegocio.PesquisarTipoMedidaCorporal(null, "%");
                cbxCadastrarTipoMedida.DataSource = null;
                cbxCadastrarTipoMedida.DataSource = listaTipoMedidaCorporal;
                cbxCadastrarTipoMedida.Update();
                cbxCadastrarTipoMedida.Refresh();

                cbxCadastrarTipoMedida.ValueMember = "IDTipoMedidaCorporal";
                cbxCadastrarTipoMedida.DisplayMember = "Descricao";
                cbxCadastrarTipoMedida.SelectedItem = null;

            }

        

            if(acaoNaTelaInformada == AcaoNaTela.Inserir)
            {
                this.Text = "Cadastrar Medida Corporal";
                this.txtCadastrarAluno.ReadOnly = true;
                this.dtpCadastrarDataMedida.Enabled = false;
                this.lblCadastrarTitulo.Text = "Cadastrar Medida Corporal";
                this.txtCadastrarAluno.Text = medidaCorporal.Aluno.Pessoa.Nome;
                this.txtCodigoAluno.Text = medidaCorporal.Aluno.Pessoa.IDPessoa.ToString();
                this.pbxCadastrarTipoMedida.Image = global::Apresentacao.Properties.Resources._1440663403_add_property;
                this.txtCadastrarQuantidadeMedidas.Text = "0";
                

            }
            else if(acaoNaTelaInformada == AcaoNaTela.Alterar)
            {
                this.Text = "Alterar Medida Corporal";
                this.txtCadastrarAluno.ReadOnly = true;
                this.dtpCadastrarDataMedida.Enabled = false;
                this.lblCadastrarTitulo.Text = "Alterar Medida Corporal";
                this.dtpCadastrarDataMedida.Value = medidaCorporal.DataMedida;
                this.pbxCadastrarTipoMedida.Image = global::Apresentacao.Properties.Resources._1440663068_edit_property;
                this.txtCadastrarAluno.Text = medidaCorporal.Aluno.Pessoa.Nome;
                this.txtCodigoAluno.Text = medidaCorporal.Aluno.Pessoa.IDPessoa.ToString();
                AtualizarGridMedidas(DialogResult.Yes, medidaCorporal.Aluno.Pessoa.IDPessoa, medidaCorporal.DataMedida);
 
            }


        }

        public void AtualizarGridMedidas(DialogResult dialogResult, int codigo, DateTime data)
        {
            using (MedidaCorporalNegocio medidaCorporalNegocio = new MedidaCorporalNegocio())
            {
            if(dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        ListaMedidaCorporal listaMedidaCorporal = medidaCorporalNegocio.ListaMedidaCorporalAlunoData(codigo, data);

                        this.dgwMedidaCorporal.DataSource = null;
                        this.dgwMedidaCorporal.DataSource = listaMedidaCorporal;
                        this.dgwMedidaCorporal.Update();
                        this.dgwMedidaCorporal.Refresh();
                        txtCadastrarQuantidadeMedidas.Text = listaMedidaCorporal.Count().ToString();
                        return;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Não foi possível mostrar as medidas corporais do aluno. Detalhes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
            
                }
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            using(MedidaCorporalNegocio medidaCorporalNegocio = new MedidaCorporalNegocio())
            {
                ValidacaoInterfaces validarInterfaces = new ValidacaoInterfaces();
                if(validarInterfaces.validarCampoCadastrar(grpFichaMedidaCorporal.Controls) == true)
                {
                    return;
                }
                else if(cbxCadastrarTipoMedida.DisplayMember.Equals(cbxCadastrarTipoMedida.Text))
                {
                    MessageBox.Show("Errado");
                    return;
                }
                if (txtCadastrarCentimetro.Text.Count() == 2 || txtCadastrarCentimetro.Text.Substring(2, 1) == "." || txtCadastrarCentimetro.Text.Substring(3, 1) == ".")
                {
                    txtCadastrarCentimetro.Text = txtCadastrarCentimetro.Text.Replace(".", ",");
                    txtCadastrarCentimetro.Text = string.Format("{0:0.00}", txtCadastrarCentimetro.Text);
                }
                if (txtCadastrarCentimetro.Text.Substring(1, 1) == "." || txtCadastrarCentimetro.Text.Substring(2, 1) == "." || txtCadastrarCentimetro.Text.Substring(3, 1) == ".")
                {
                    txtCadastrarCentimetro.Text = txtCadastrarCentimetro.Text.Replace(".",",");
                    txtCadastrarCentimetro.Text = string.Format("{0:0.00}" ,txtCadastrarCentimetro.Text);
                }
               
                

                MedidaCorporal medidaCorporal = new MedidaCorporal()
                {
                    DataMedida = dtpCadastrarDataMedida.Value,
                    MedidaCm = Convert.ToDecimal(txtCadastrarCentimetro.Text)
                };

                medidaCorporal.Aluno = new Aluno();
                medidaCorporal.Aluno.Pessoa = new Pessoa()
                {
                    IDPessoa = Convert.ToInt32(this.txtCodigoAluno.Text)
                };

                medidaCorporal.TipoMedidaCorporal = new TipoMedidaCorporal()
                {
                    IDTipoMedidaCorporal = Convert.ToInt32(cbxCadastrarTipoMedida.SelectedValue)
                };


                string idMedidaCorporal = medidaCorporalNegocio.Inserir(medidaCorporal);

                try
                {
                    int codigo = Convert.ToInt32(idMedidaCorporal);
                    txtCadastrarCentimetro.Clear();
                    cbxCadastrarTipoMedida.SelectedItem = null;
                    AtualizarGridMedidas(DialogResult.Yes, Convert.ToInt32(txtCodigoAluno.Text), dtpCadastrarDataMedida.Value.Date);
                    cbxCadastrarTipoMedida.Focus();
                }
                catch
                {
                    MessageBox.Show("Não foi possível cadastrar medida corporal. Detalhes: " + idMedidaCorporal, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCadastrarCentimetro.Clear();
                    cbxCadastrarTipoMedida.SelectedItem = null;
                    return;
                }



            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if(this.dgwMedidaCorporal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma medida corporal está selecionada", "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            MedidaCorporal medidaCorporalSelecionada = (this.dgwMedidaCorporal.SelectedRows[0].DataBoundItem) as MedidaCorporal;
            FrmMedidaCorporalAlterar frmMedidaCorporalAlterar = new FrmMedidaCorporalAlterar(medidaCorporalSelecionada);
            DialogResult dialogResult = frmMedidaCorporalAlterar.ShowDialog();
            if (dialogResult == DialogResult.Yes)
                AtualizarGridMedidas(DialogResult.Yes, Convert.ToInt32(txtCodigoAluno.Text), dtpCadastrarDataMedida.Value.Date);
            cbxCadastrarTipoMedida.Focus();

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(dgwMedidaCorporal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma medida corporal está selecionada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(MessageBox.Show("Tem certeza que quer excluir esse registro", "Pergunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                using(MedidaCorporalNegocio medidaCorporalNegocio = new MedidaCorporalNegocio())
                {
                 MedidaCorporal medidaCorporalSelecionada = (this.dgwMedidaCorporal.SelectedRows[0].DataBoundItem) as MedidaCorporal;
                 string idMedidaCorporal = medidaCorporalNegocio.Remover(medidaCorporalSelecionada);

                    try
                    {
                        int codigo = Convert.ToInt32(idMedidaCorporal);
                        MessageBox.Show("Medida corporal foi excluída com sucesso. Código: " + codigo.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AtualizarGridMedidas(DialogResult.Yes, Convert.ToInt32(txtCodigoAluno.Text), dtpCadastrarDataMedida.Value.Date);
                        cbxCadastrarTipoMedida.Focus();
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível excluir a medida corporal. Detalhes: " + idMedidaCorporal, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            else
            {
                return;
            }
        }

        private void dgwMedidaCorporal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.Value is Aluno)
            {
                e.Value = (e.Value as Aluno).Pessoa.IDPessoa;
            }
            if (e.ColumnIndex == 1 && e.Value is TipoMedidaCorporal)
            {
                e.Value = (e.Value as TipoMedidaCorporal).Descricao;
            }
            
            if(e.ColumnIndex == 4 && e.Value is Boolean)
            {
                if (e.Value.Equals(true))
                    e.Value = "Sim";
                else
                    e.Value = "Não";
            }
            
        }

        private void dgwMedidaCorporal_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.btnAlterar.PerformClick();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            if(acaoNaTelaInformada == AcaoNaTela.Inserir)
            {
                if (MessageBox.Show("Deseja realmente cancelar o cadastro", "Sair", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (this.txtCadastrarQuantidadeMedidas.Text == "0")
                    {
                        this.DialogResult = DialogResult.No;
                        return;
                    }
                    else if (txtCadastrarQuantidadeMedidas.Text != "0")
                    {
                        using (MedidaCorporalNegocio medidaCorporalNegocio = new MedidaCorporalNegocio())
                        {
                            MedidaCorporal medidaCorporalCancelar = new MedidaCorporal()
                            {
                                DataMedida = Convert.ToDateTime(dtpCadastrarDataMedida.Value)
                            };

                            medidaCorporalCancelar.Aluno = new Aluno();
                            medidaCorporalCancelar.Aluno.Pessoa = new Pessoa()
                            {
                                IDPessoa = Convert.ToInt32(txtCodigoAluno.Text)
                            };

                            string retorno = medidaCorporalNegocio.Cancelar(medidaCorporalCancelar);
                            try
                            {
                                int codigo = Convert.ToInt32(retorno);
                                MessageBox.Show("Cancelamento executado com sucesso. Código: " + retorno, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.DialogResult = DialogResult.No;
                                return;
                            }
                            catch
                            {
                                MessageBox.Show("Não foi possível cancalar a ficha de medida corporal. Detalhes: " + retorno, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                    }
                }
            }
            else if(acaoNaTelaInformada == AcaoNaTela.Alterar)
            {
                if (MessageBox.Show("Deseja realmente sair da alteração", "Sair", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.No;
                    return;
                }
            
            }

           
        }

        private void FrmMedidaCorporalCadastrar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.btnCancelar.PerformClick();
            }
            if (e.KeyCode == Keys.F1)
            {
                btnInserir.PerformClick();
            }
            if (e.KeyCode == Keys.F2)
            {
                btnAlterar.PerformClick();
            }
            if (e.KeyCode == Keys.F3)
            {
                btnRemover.PerformClick();
            }
            if (cbxCadastrarTipoMedida.Text == "" && e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                cbxCadastrarTipoMedida.Select();
            }
            if (cbxCadastrarTipoMedida.Text != "" && e.KeyCode == Keys.Enter)
            {
                txtCadastrarCentimetro.Select();
                e.Handled = true;
            }

            if (txtCadastrarCentimetro.Text != "" && cbxCadastrarTipoMedida.Text == "" && e.KeyCode == Keys.Enter)
            {
                cbxCadastrarTipoMedida.Select();
                e.Handled = true;
            }
            if (txtCadastrarCentimetro.Text != "" && cbxCadastrarTipoMedida.Text != "" && txtCadastrarCentimetro.Text != "" && e.KeyCode == Keys.Enter)
            {
                btnInserir.PerformClick();
                e.Handled = true;
              
            }

        }

        private void maskedTextBox2_MouseLeave(object sender, EventArgs e)
        {
            
            if(mskAltura.Text != "" && mskPeso.Text != "")
            {
                float altura = float.Parse(mskAltura.Text);
                float peso = float.Parse(mskPeso.Text);
                float IMC = (peso/(altura * altura));
                txtIMC.Text = IMC.ToString();

           if (IMC < 18.5)
                {
                    lblResultado.Text = "Peso abaixo do normal";
                }
           else if( IMC > 18.5 && IMC < 25)
             {
               lblResultado.Text = "Peso abaixo do normal";
            }
                else if(IMC > 25 || IMC <30)
            {
               lblResultado.Text = "Sobre peso";
            }

            }
              

        }

        private void mskAltura_MouseLeave(object sender, EventArgs e)
        {
            if (mskAltura.Text != "" && mskPeso.Text != "")
            {
                float altura = float.Parse(mskAltura.Text);
                float peso = float.Parse(mskPeso.Text);
                float IMC = (peso / (altura * altura));
                txtIMC.Text = IMC.ToString();

                if (IMC < 18.5)
                {
                    lblResultado.Text = "Peso abaixo do normal";
                }
                 if (IMC == 18.5 || IMC == 25)
                {
                    lblResultado.Text = "Peso abaixo do normal";
                }
                if (IMC > 25 || IMC == 30)
                {
                    lblResultado.Text = "Sobre peso";
                }

            }
        }

       
       
    }
}
