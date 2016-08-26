using Negocios;
using ObjetoTransferencia;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Apresentacao.TreinamentoInterfaces
{
    public partial class FrmTreinamentoCadastrar : Form
    {
        AcaoNaTela acaoNaTelaInformada;
      
        public FrmTreinamentoCadastrar(AcaoNaTela acaoNaTela, Treinamento treinamento)
        {
            acaoNaTelaInformada = acaoNaTela;
            InitializeComponent();
            this.dgwTreinamentoExercicios.AutoGenerateColumns = false;

            using(ExercicioNegocio exercicioNegocio = new ExercicioNegocio())
            {
                try
                {
                    ListaExercicio listaExercicio = exercicioNegocio.PesquisarExercicioCodigoNome(null, "%");
                    cbxCadastrarExercicio.DataSource = listaExercicio;
                    cbxCadastrarExercicio.DisplayMember = "Nome";
                    cbxCadastrarExercicio.ValueMember = "IDExercicio";
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Não foi possível carregar a lista de exercício. Detalhes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            using (TipoTreinamentoNegocio tipoTreinamentoNegocio = new TipoTreinamentoNegocio())
            {
                try
                {
                    ListaTipoTreinamento listaTipoTreinamento = tipoTreinamentoNegocio.PesquisarTreinamentoCodigoNome(null, "%");
                    cbxCadastrarTipoTreinamento.DataSource = listaTipoTreinamento;
                    cbxCadastrarTipoTreinamento.DisplayMember = "Descricao";
                    cbxCadastrarTipoTreinamento.ValueMember = "IDTipoTreinamento";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível carregar a lista de tipo de treinamento. Detalhes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            cbxCadastrarExercicio.SelectedItem = null;
            cbxCadastrarTipoTreinamento.SelectedItem = null;
                

            if(acaoNaTelaInformada == AcaoNaTela.Inserir)
            {
                this.Text = "Cadastrar Treinamento Físico";
                this.lblCadastrarTitulo.Text = "Cadastrar Treinamento Físico";
                grpTreinamentoFisico.Enabled = true;
                grpFichaTreinamento.Enabled = false;
                pbxCadastrarTreinamento.Image = global::Apresentacao.Properties.Resources._1440663403_add_property;
                txtCodigoAluno.Text = treinamento.Aluno.Pessoa.IDPessoa.ToString();
                txtCadastrarAluno.Text = treinamento.Aluno.Pessoa.Nome;
                txtMostrarObjetivo.Text = treinamento.Aluno.Objetivo.Descricao;
                btnCadastrarTreinamento.Text = "Cadastrar";
                txtCadastrarQuantidadeExercicios.Text = "0";
                cbxCadastrarTipoTreinamento.Select();
                  
                

            }
            else if (acaoNaTelaInformada == AcaoNaTela.Alterar)
            {
                this.Text = "Alterar Treinamento Físico";
                this.lblCadastrarTitulo.Text = "Alterar Treinamento Físico";
              //  grpTreinamentoFisico.Enabled = false;
                grpFichaTreinamento.Enabled = true;
                pbxCadastrarTreinamento.Image = global::Apresentacao.Properties.Resources._1440663068_edit_property;
                txtCodigoAluno.Text = treinamento.Aluno.Pessoa.IDPessoa.ToString();
                txtCadastrarAluno.Text = treinamento.Aluno.Pessoa.Nome;
                txtMostrarObjetivo.Text = treinamento.Aluno.Objetivo.Descricao;
                cbxCadastrarTipoTreinamento.Text = treinamento.TipoTreinamento.Descricao;
                btnCadastrarTreinamento.Text = "Alterar";
                txtCadastrarTreinamentoCodigo.Text = treinamento.IDTreinamento.ToString();
                AtualizarGridTreinamentos(DialogResult.Yes, treinamento.IDTreinamento);
                cbxCadastrarExercicio.Select();
                grpBoxAtivo.Enabled = true;
                btnCadastrarTreinamento.Enabled = true;
                dtpCadastrarDataTreinamento.Enabled = false;
                cbxCadastrarTipoTreinamento.Enabled = false;
                rbtCadastrarAtivoSim.Checked = treinamento.Ativo == true ? true : false;
                rbtCadastrarAtivoNao.Checked = treinamento.Ativo == false ? true : false;
                dtpCadastrarDataTreinamento.Value = treinamento.DataCadastro;

            }

        }

        public void AtualizarGridTreinamentos(DialogResult dialogResult, int codigo)
        {
            using (ExerciciosTreinamentoNegocio exerciciosTreinamentoNegocio = new ExerciciosTreinamentoNegocio())
            {
                try
                {
                    ListaExerciciosTreinamento listaExerciciosTreinamento = exerciciosTreinamentoNegocio.TreinamentoPesquisaeListaExercicios(codigo);
                    this.dgwTreinamentoExercicios.DataSource = null;
                    this.dgwTreinamentoExercicios.DataSource = listaExerciciosTreinamento;
                    this.dgwTreinamentoExercicios.Update();
                    this.dgwTreinamentoExercicios.Refresh();
                    txtCadastrarQuantidadeExercicios.Text = listaExerciciosTreinamento.Count().ToString();
                    cbxCadastrarExercicio.SelectedItem = null;
                    cbxCadastrarExercicio.Focus();
                    txtCadastrarSeries.Clear();
                    txtCadastrarRepeticoes.Clear();
                    mskCadastrarIntervalo.Text = "00:00:00";
                    return;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Não foi possível visualizar a lista de exercícios do treinamento. Detalhes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
           
        }

        public void Sair()
        {
            if (acaoNaTelaInformada == AcaoNaTela.Inserir)
            {

                if (MessageBox.Show("Deseja realmente sair da tela de cadastro ", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if(txtCadastrarTreinamentoCodigo.Text != "")
                    {
                        using(ExerciciosTreinamentoNegocio exerciciosTreinamentoNegocio = new ExerciciosTreinamentoNegocio())
                        {
                            ExerciciosTreinamento exerciciosTreinamentoCancelar = new ExerciciosTreinamento();
                            exerciciosTreinamentoCancelar.Treinamento = new Treinamento()
                            {
                                IDTreinamento = Convert.ToInt32(txtCadastrarTreinamentoCodigo.Text)
                            };

                            string retorno = exerciciosTreinamentoNegocio.Cancelar(exerciciosTreinamentoCancelar);
                            try
                            {
                                int codigo = Convert.ToInt32(retorno);
                                MessageBox.Show("O treinamento foi cancelado com sucessso. Código: "+ retorno, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.DialogResult = DialogResult.No;
                            }
                            catch
                            {
                                MessageBox.Show("Não foi possível cancalar o treinamento. Detalhes: " + retorno, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                                return;
                            }
                        }
                        
                    }
                    else if(txtCadastrarTreinamentoCodigo.Text == "")
                    {
                        this.DialogResult = DialogResult.No;
                    }
                    
                }
            }
            else if(acaoNaTelaInformada == AcaoNaTela.Alterar)
            {
                if (MessageBox.Show("Deseja realmente sair da tela de alteração", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.No;
                }
            }
        }

  

        private void dgwTreinamentoExercicios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 0 && e.Value is Treinamento)
            {
                e.Value = (e.Value as Treinamento).IDTreinamento;
            }
            if(e.ColumnIndex == 1 && e.Value is Exercicio)
            {
                e.Value = (e.Value as Exercicio).Nome;
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void btnCadastrarTreinamento_Click(object sender, EventArgs e)
        {
            using (TreinamentoNegocio treinamentoNegocio = new TreinamentoNegocio())
            {
                ValidacaoInterfaces validarInterfaces = new ValidacaoInterfaces();
                if (acaoNaTelaInformada == AcaoNaTela.Inserir)
                {

                    if (validarInterfaces.ValidarRadioButton(rbtCadastrarAtivoSim, rbtCadastrarAtivoNao) == true)
                    {
                        return;
                    }
                    if (cbxCadastrarTipoTreinamento.Text == "")
                    {
                        MessageBox.Show("Campo obrigatório nulo: Treinamento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cbxCadastrarTipoTreinamento.Focus();
                        return;
                    }
                    if (cbxCadastrarTipoTreinamento.SelectedValue == null)
                    {
                        MessageBox.Show("Tipo de treinamento físico não existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cbxCadastrarTipoTreinamento.Focus();
                        return;
                    }
                    Treinamento treinamentoInserir = new Treinamento()
                    {
                        Ativo = rbtCadastrarAtivoSim.Checked == true ? true : false
                    };            
                    treinamentoInserir.TipoTreinamento = new TipoTreinamento()
                    {
                        IDTipoTreinamento = Convert.ToInt32(cbxCadastrarTipoTreinamento.SelectedValue)
                    };

                    treinamentoInserir.Aluno = new Aluno();
                    treinamentoInserir.Aluno.Pessoa = new Pessoa()
                    {
                        IDPessoa = Convert.ToInt32(txtCodigoAluno.Text)
                    };                

                    string retorno = treinamentoNegocio.Inserir(treinamentoInserir);

                    try
                    {
                        int IDTreinamento = Convert.ToInt32(retorno);
                        grpFichaTreinamento.Enabled = true;
                        grpTreinamentoFisico.Enabled = false;
                        btnCadastrarTreinamento.Text = "";
                        txtCadastrarTreinamentoCodigo.Text = IDTreinamento.ToString();
                        cbxCadastrarExercicio.Focus();
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível cadastrar as informações do treinamento. Detalhes: " + retorno, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cbxCadastrarTipoTreinamento.Focus();
                        return;
                    }
                }

                else if (acaoNaTelaInformada == AcaoNaTela.Alterar)
                {
                    if (validarInterfaces.ValidarRadioButton(rbtCadastrarAtivoSim, rbtCadastrarAtivoNao) == true)
                    {
                        return;
                    }

                    Treinamento treinamentoAlterar = new Treinamento()
                    {
                        IDTreinamento = Convert.ToInt32(txtCadastrarTreinamentoCodigo.Text),
                        Ativo = rbtCadastrarAtivoSim.Checked == true? true: false
                    };
                    treinamentoAlterar.TipoTreinamento = new TipoTreinamento()
                    {
                        IDTipoTreinamento = Convert.ToInt32(cbxCadastrarTipoTreinamento.SelectedValue)
                    };

                    treinamentoAlterar.Aluno = new Aluno();
                    treinamentoAlterar.Aluno.Pessoa = new Pessoa()
                    {
                        IDPessoa = Convert.ToInt32(txtCodigoAluno.Text)
                    };

                    string retorno = treinamentoNegocio.Alterar(treinamentoAlterar);
                    try
                    {
                        int IDTreinamento = Convert.ToInt32(retorno);
                        grpFichaTreinamento.Enabled = true;
                        grpTreinamentoFisico.Enabled = false;                 
                        cbxCadastrarExercicio.Focus();
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível alterar as informações do treinamento. Detalhes: " + retorno, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cbxCadastrarTipoTreinamento.Focus();
                        return;
                    }
                }
            }
                

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            using (ExerciciosTreinamentoNegocio exerciciosTreinamentoNegocio = new ExerciciosTreinamentoNegocio())
            {
                ValidacaoInterfaces validarInterfaces = new ValidacaoInterfaces();
                    if(validarInterfaces.validarCampoCadastrar(grpFichaTreinamento.Controls) == true)
                    {
                        return;
                    }
              
                    ExerciciosTreinamento exerciciosTreinamentoInserir = new ExerciciosTreinamento()
                    {
                        Series = Convert.ToInt32(txtCadastrarSeries.Text),
                        Repeticoes = Convert.ToInt32(txtCadastrarRepeticoes.Text),
                        Intervalo = mskCadastrarIntervalo.Text
                    };

                    exerciciosTreinamentoInserir.Treinamento = new Treinamento()
                    {
                        IDTreinamento = Convert.ToInt32(txtCadastrarTreinamentoCodigo.Text)
                    };

                    exerciciosTreinamentoInserir.Exercicio = new Exercicio()
                    {
                        IDExercicio = Convert.ToInt32(cbxCadastrarExercicio.SelectedValue)
                    };

                    string retorno = exerciciosTreinamentoNegocio.Inserir(exerciciosTreinamentoInserir);
                    try
                    {
                        int codigo = Convert.ToInt32(retorno);
                        cbxCadastrarExercicio.Select();
                        AtualizarGridTreinamentos(DialogResult.Yes, codigo);
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível cadastrar o exercício no treinamento. Detalhes: " + retorno, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cbxCadastrarExercicio.SelectedItem = null;
                        mskCadastrarIntervalo.Text = "00:00:00";
                        return;
                    }
                
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if(this.dgwTreinamentoExercicios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum exercício está selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ExerciciosTreinamento exerciciosTreinamentoSelecionado = (this.dgwTreinamentoExercicios.SelectedRows[0].DataBoundItem) as ExerciciosTreinamento;
            FrmTreinamentoAlterar frmTreinamentoAlterar = new FrmTreinamentoAlterar(exerciciosTreinamentoSelecionado);
            DialogResult dialogResult = frmTreinamentoAlterar.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {           
                AtualizarGridTreinamentos(DialogResult.Yes, exerciciosTreinamentoSelecionado.Treinamento.IDTreinamento);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(this.dgwTreinamentoExercicios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum exercício está selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Tem certeza que quer excluir esse registro", "Pergunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                using (ExerciciosTreinamentoNegocio exerciciosTreinamentoNegocio = new ExerciciosTreinamentoNegocio())
                {
                    ExerciciosTreinamento exerciciosTreinamentoRemover = (this.dgwTreinamentoExercicios.SelectedRows[0].DataBoundItem) as ExerciciosTreinamento;

                    string retorno = exerciciosTreinamentoNegocio.Remover(exerciciosTreinamentoRemover);
                    try
                    {
                        int codigo = Convert.ToInt32(retorno);
                        AtualizarGridTreinamentos(DialogResult.Yes, codigo);
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível excluir o exercício do treinamento. Detalhes: " + retorno, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

        }

        private void dgwTreinamentoExercicios_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnAlterar.PerformClick();
        }

        private void FrmTreinamentoCadastrar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Sair();
            }
            if (cbxCadastrarExercicio.Text == "" && e.KeyCode == Keys.Enter)
            {
                cbxCadastrarExercicio.Select();
                e.Handled = true;
            
            }
            if (cbxCadastrarExercicio.Text != "" && txtCadastrarSeries.Text == "" && e.KeyCode == Keys.Enter)
            {
                txtCadastrarSeries.Select();
                e.Handled = true;

            }
            if (txtCadastrarSeries.Text != "" && txtCadastrarRepeticoes.Text == "" && e.KeyCode == Keys.Enter)
            {
                txtCadastrarRepeticoes.Select();
                e.Handled = true;

            }
            if (e.KeyCode == Keys.Enter && txtCadastrarRepeticoes.Text != "" && txtCadastrarSeries.Text != "")
            {
                mskCadastrarIntervalo.Select();

            }
            if (e.KeyCode == Keys.Enter && txtCadastrarRepeticoes.Text != "" && txtCadastrarSeries.Text != "" && mskCadastrarIntervalo.Text != "00:00:00")
            {
                btnInserir.PerformClick();
                e.Handled = true;
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
        }
    }
}
