using Negocios;
using ObjetoTransferencia;
using System;
using System.Windows.Forms;




namespace Apresentacao.MenuInterfaces
{
    public partial class FrmMenuSplash : Form
    {
        
        public FrmMenuSplash()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (UsuarioNegocio usuarioNegocio = new UsuarioNegocio())
            {

            if(txtLoginUsuario.Text == "")
            {
                MessageBox.Show("Digite o usuário", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLoginUsuario.Focus();
                return;
            }
            else if(txtLoginSenha.Text == "")
            {
                MessageBox.Show("Digite a Senha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLoginSenha.Focus();
                return;
            }

            ListaUsuario listaUsuario = usuarioNegocio.Login(txtLoginUsuario.Text, txtLoginSenha.Text);
                if(listaUsuario.Count == 1)
                {
                    
                    FrmMenuPrincipal frMenuPrincipal = new FrmMenuPrincipal(listaUsuario, null);
                    frMenuPrincipal.Show();
                    this.Visible = false;

                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorreto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLoginUsuario.Select();
                    txtLoginSenha.Clear();
                    return;
                }
            }
        }

        private void FrmMenuSplash_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtLoginUsuario.Text != "" && e.KeyCode == Keys.Enter)
            {
                txtLoginSenha.Select();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if (txtLoginSenha.Text != "" && e.KeyCode == Keys.Enter)
            {
                btnLoginEntrar.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

       
 
    }
}
