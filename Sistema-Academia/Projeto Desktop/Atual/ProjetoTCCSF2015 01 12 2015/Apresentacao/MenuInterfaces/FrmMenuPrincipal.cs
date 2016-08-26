using Apresentacao.Aluno_Interfaces;
using Apresentacao.EquipamentoInterfaces;
using Apresentacao.ExercicioInterfaces;
using Apresentacao.MedidaCorporalInterfaces;
using Apresentacao.MedidaCorporalInterfaces.Relatório;
using Apresentacao.NoticiaInterfaces;
using Apresentacao.Relatórios;
using Apresentacao.TreinamentoInterfaces;
using Apresentacao.TreinamentoInterfaces.TipoTreinamentoInterfaces;
using Apresentacao.Usuário_Interfaces;
using ObjetoTransferencia;
using System;
using System.Linq;
using System.Windows.Forms;




namespace Apresentacao.MenuInterfaces
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal(ListaUsuario listaUsuario, Aluno aluno)
        {
            InitializeComponent();
            Usuario usuario = listaUsuario.First();
            barraStatusUsuario.Text = "Usuário: "+ usuario.Pessoa.Nome;
             
           
        }

  

        private void menuItemPesquisarAluno_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmAlunoSelecionar>().Count() == 0)
            {
                FrmAlunoSelecionar frmAlunoSelecionar = new FrmAlunoSelecionar(AcaoNaTela.Alterar);
                frmAlunoSelecionar.MdiParent = this;
                frmAlunoSelecionar.Show();
            }
        }

        private void menuItemPesquisarObjetivo_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<FrmObjetivoSelecionar>().Count() ==0)
            {
                FrmObjetivoSelecionar frmObjetivoSelecionar = new FrmObjetivoSelecionar();
                frmObjetivoSelecionar.MdiParent = this;
                frmObjetivoSelecionar.Show();
            }
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (Application.OpenForms.OfType<FrmUsuarioSelecionar>().Count() == 0)
            {
                FrmUsuarioSelecionar frmUsuarioSelecionar = new FrmUsuarioSelecionar();
                frmUsuarioSelecionar.MdiParent = this;
                frmUsuarioSelecionar.Show();
            }
            
             
        }

        private void menuUsuarioTipoUsuario_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<FrmTipoUsuarioSelecionar>().Count() == 0)
            {
                FrmTipoUsuarioSelecionar frmTipoUsuarioSelecionar = new FrmTipoUsuarioSelecionar();
                frmTipoUsuarioSelecionar.MdiParent = this;
                frmTipoUsuarioSelecionar.Show();              
            }
        }

        private void menuExercicioExercicio_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<FrmExercicioSelecionar>().Count() == 0)
            {
                FrmExercicioSelecionar frmExercicioSelecionar = new FrmExercicioSelecionar();
                frmExercicioSelecionar.MdiParent = this;
                frmExercicioSelecionar.Show();
            }
        }

        private void menuExercicioTipoExercicio_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<FrmTipoExercicioSelecionar>().Count() == 0)
            {
                FrmTipoExercicioSelecionar frmTipoExercicioSelecionar = new FrmTipoExercicioSelecionar();
                frmTipoExercicioSelecionar.MdiParent = this;
                frmTipoExercicioSelecionar.Show();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmEquipamentoSelecionar>().Count() == 0)
            {
                FrmEquipamentoSelecionar frmEquipamentoSelecionar = new FrmEquipamentoSelecionar();
                frmEquipamentoSelecionar.MdiParent = this;
                frmEquipamentoSelecionar.Show();
            }
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmNoticiaSelecionar>().Count() == 0)
            {
                FrmNoticiaSelecionar frmNoticiaSelecionar = new FrmNoticiaSelecionar();
                frmNoticiaSelecionar.MdiParent = this;
                frmNoticiaSelecionar.Show();

            }

        }

        private void tipoMedidaCorporalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<FrmTipoMedidaCorporalSelecionar>().Count() == 0)
            {
                FrmTipoMedidaCorporalSelecionar frmTipoMedidaCorporalSelecionar = new FrmTipoMedidaCorporalSelecionar();
                frmTipoMedidaCorporalSelecionar.MdiParent =this;
                frmTipoMedidaCorporalSelecionar.Show();
            }
        }

        private void pesquisarMedidaCorporal_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<FrmMedidaCorporalSelecionar>().Count() == 0)
            {
                FrmMedidaCorporalSelecionar frmMedidaCorporalSelecionar = new FrmMedidaCorporalSelecionar();
                frmMedidaCorporalSelecionar.MdiParent = this;
                frmMedidaCorporalSelecionar.Show();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<FrmRelatorioEquipamento>().Count() == 0)
            {
                FrmRelatorioEquipamento frmRelatorioEquipamento = new FrmRelatorioEquipamento();
                frmRelatorioEquipamento.Show();
            }
        }

        private void relatórioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<FrmRelatorioAllAluno>().Count() == 0)
            {
                FrmRelatorioAllAluno frmRelatorioAluno = new FrmRelatorioAllAluno();
                frmRelatorioAluno.Show();
            }
        }

        private void FrmMenuPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
             Application.Exit();
            }
        }

        private void treinamentoFísicoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmTreinamentoSelecionar>().Count() == 0)
            {
                FrmTreinamentoSelecionar frmTreinamenroSelecionar = new FrmTreinamentoSelecionar();
                frmTreinamenroSelecionar.MdiParent = this;
                frmTreinamenroSelecionar.Show();
            }
        }

        private void tipoDeTreinamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<FrmTreinamentoSelecionar>().Count() == 0)
            {
                FrmTipoTreinamentoSelecionar frmTipoTreinamentoSelecionar = new FrmTipoTreinamentoSelecionar();
                frmTipoTreinamentoSelecionar.MdiParent = this;
                frmTipoTreinamentoSelecionar.Show();
            }
        }

        private void relatórioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmFiltroRelatorioAvaliacaoFisica>().Count() == 0)
            {

                FrmFiltroRelatorioAvaliacaoFisica frmFiltroRelatorioAvalicaoFisica = new FrmFiltroRelatorioAvaliacaoFisica();
                frmFiltroRelatorioAvalicaoFisica.MdiParent = this;
                frmFiltroRelatorioAvalicaoFisica.Show();
            }
        }
       
    }
}
