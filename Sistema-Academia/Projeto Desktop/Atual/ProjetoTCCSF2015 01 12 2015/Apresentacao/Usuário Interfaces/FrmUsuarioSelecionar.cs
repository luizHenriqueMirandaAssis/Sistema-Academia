using Negocios;
using ObjetoTransferencia;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmUsuarioSelecionar : Form
    {
        private ListBox listBoxSelecionarUsuario;
        private Label lblSelecionarUsuarioNome;
        private Button btnSelecionarUsuarioInserir;
        private Button btnSelecionarUsuarioAlterar;
        private Button btnSelecionarUsuarioCancelar;
        private DataGridView dgwSelecionarUsuario;
        private Button btnSelecionarPesquisar;
        private ToolTip ttpSelecionarPesquisar;
        private IContainer components;
        private TextBox txtSelecionarUsuarioCodNome;
        private DataGridViewTextBoxColumn colIDPessoa;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colSexo;
        private DataGridViewTextBoxColumn colDataNascimento;
        private DataGridViewTextBoxColumn colDescricao;
        private Label lblSelecionarTitulo;
        private PictureBox pbcSelecionar;
        private DataGridViewTextBoxColumn colAtivo;

        
    
        public FrmUsuarioSelecionar()
        {          
            InitializeComponent();
            dgwSelecionarUsuario.AutoGenerateColumns = false;
           
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listBoxSelecionarUsuario = new System.Windows.Forms.ListBox();
            this.lblSelecionarUsuarioNome = new System.Windows.Forms.Label();
            this.btnSelecionarUsuarioInserir = new System.Windows.Forms.Button();
            this.btnSelecionarUsuarioAlterar = new System.Windows.Forms.Button();
            this.btnSelecionarUsuarioCancelar = new System.Windows.Forms.Button();
            this.dgwSelecionarUsuario = new System.Windows.Forms.DataGridView();
            this.colIDPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAtivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSelecionarUsuarioCodNome = new System.Windows.Forms.TextBox();
            this.ttpSelecionarPesquisar = new System.Windows.Forms.ToolTip(this.components);
            this.lblSelecionarTitulo = new System.Windows.Forms.Label();
            this.pbcSelecionar = new System.Windows.Forms.PictureBox();
            this.btnSelecionarPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSelecionarUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcSelecionar)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxSelecionarUsuario
            // 
            this.listBoxSelecionarUsuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBoxSelecionarUsuario.Enabled = false;
            this.listBoxSelecionarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSelecionarUsuario.FormattingEnabled = true;
            this.listBoxSelecionarUsuario.ItemHeight = 25;
            this.listBoxSelecionarUsuario.Items.AddRange(new object[] {
            "F1: Pesquisar - F2: Inserir - F3: Alterar"});
            this.listBoxSelecionarUsuario.Location = new System.Drawing.Point(6, 494);
            this.listBoxSelecionarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxSelecionarUsuario.Name = "listBoxSelecionarUsuario";
            this.listBoxSelecionarUsuario.Size = new System.Drawing.Size(280, 4);
            this.listBoxSelecionarUsuario.TabIndex = 5;
            this.listBoxSelecionarUsuario.TabStop = false;
            // 
            // lblSelecionarUsuarioNome
            // 
            this.lblSelecionarUsuarioNome.AutoSize = true;
            this.lblSelecionarUsuarioNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecionarUsuarioNome.ForeColor = System.Drawing.Color.Black;
            this.lblSelecionarUsuarioNome.Location = new System.Drawing.Point(13, 78);
            this.lblSelecionarUsuarioNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelecionarUsuarioNome.Name = "lblSelecionarUsuarioNome";
            this.lblSelecionarUsuarioNome.Size = new System.Drawing.Size(139, 25);
            this.lblSelecionarUsuarioNome.TabIndex = 1;
            this.lblSelecionarUsuarioNome.Text = "Código/Nome:";
            // 
            // btnSelecionarUsuarioInserir
            // 
            this.btnSelecionarUsuarioInserir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelecionarUsuarioInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarUsuarioInserir.Location = new System.Drawing.Point(604, 485);
            this.btnSelecionarUsuarioInserir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelecionarUsuarioInserir.Name = "btnSelecionarUsuarioInserir";
            this.btnSelecionarUsuarioInserir.Size = new System.Drawing.Size(85, 33);
            this.btnSelecionarUsuarioInserir.TabIndex = 6;
            this.btnSelecionarUsuarioInserir.Text = "Inserir";
            this.btnSelecionarUsuarioInserir.UseVisualStyleBackColor = false;
            this.btnSelecionarUsuarioInserir.Click += new System.EventHandler(this.btnSelecionarUsuarioInserir_Click);
            // 
            // btnSelecionarUsuarioAlterar
            // 
            this.btnSelecionarUsuarioAlterar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelecionarUsuarioAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarUsuarioAlterar.Location = new System.Drawing.Point(697, 485);
            this.btnSelecionarUsuarioAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelecionarUsuarioAlterar.Name = "btnSelecionarUsuarioAlterar";
            this.btnSelecionarUsuarioAlterar.Size = new System.Drawing.Size(85, 33);
            this.btnSelecionarUsuarioAlterar.TabIndex = 7;
            this.btnSelecionarUsuarioAlterar.Text = "Alterar";
            this.btnSelecionarUsuarioAlterar.UseVisualStyleBackColor = false;
            this.btnSelecionarUsuarioAlterar.Click += new System.EventHandler(this.btnSelecionarUsuarioAlterar_Click);
            // 
            // btnSelecionarUsuarioCancelar
            // 
            this.btnSelecionarUsuarioCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelecionarUsuarioCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarUsuarioCancelar.Location = new System.Drawing.Point(790, 485);
            this.btnSelecionarUsuarioCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelecionarUsuarioCancelar.Name = "btnSelecionarUsuarioCancelar";
            this.btnSelecionarUsuarioCancelar.Size = new System.Drawing.Size(85, 33);
            this.btnSelecionarUsuarioCancelar.TabIndex = 8;
            this.btnSelecionarUsuarioCancelar.Text = "Cancelar";
            this.btnSelecionarUsuarioCancelar.UseVisualStyleBackColor = false;
            this.btnSelecionarUsuarioCancelar.Click += new System.EventHandler(this.btnSelecionarUsuarioCancelar_Click);
            // 
            // dgwSelecionarUsuario
            // 
            this.dgwSelecionarUsuario.AllowUserToAddRows = false;
            this.dgwSelecionarUsuario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgwSelecionarUsuario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwSelecionarUsuario.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwSelecionarUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwSelecionarUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwSelecionarUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSelecionarUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDPessoa,
            this.colNome,
            this.colSexo,
            this.colDataNascimento,
            this.colDescricao,
            this.colAtivo});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwSelecionarUsuario.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgwSelecionarUsuario.GridColor = System.Drawing.SystemColors.Control;
            this.dgwSelecionarUsuario.Location = new System.Drawing.Point(6, 114);
            this.dgwSelecionarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.dgwSelecionarUsuario.MultiSelect = false;
            this.dgwSelecionarUsuario.Name = "dgwSelecionarUsuario";
            this.dgwSelecionarUsuario.ReadOnly = true;
            this.dgwSelecionarUsuario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwSelecionarUsuario.RowHeadersVisible = false;
            this.dgwSelecionarUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwSelecionarUsuario.Size = new System.Drawing.Size(869, 365);
            this.dgwSelecionarUsuario.TabIndex = 4;
            this.dgwSelecionarUsuario.TabStop = false;
            this.dgwSelecionarUsuario.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgwSelecionarUsuario_CellFormatting);
            this.dgwSelecionarUsuario.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwSelecionarUsuario_CellMouseDoubleClick);
            // 
            // colIDPessoa
            // 
            this.colIDPessoa.DataPropertyName = "Pessoa";
            this.colIDPessoa.HeaderText = "Código";
            this.colIDPessoa.Name = "colIDPessoa";
            this.colIDPessoa.ReadOnly = true;
            this.colIDPessoa.Width = 60;
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "Pessoa";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.colNome.DefaultCellStyle = dataGridViewCellStyle3;
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 298;
            // 
            // colSexo
            // 
            this.colSexo.DataPropertyName = "Pessoa";
            this.colSexo.HeaderText = "Sexo";
            this.colSexo.Name = "colSexo";
            this.colSexo.ReadOnly = true;
            this.colSexo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSexo.Width = 125;
            // 
            // colDataNascimento
            // 
            this.colDataNascimento.DataPropertyName = "Pessoa";
            this.colDataNascimento.HeaderText = "Data Nascimento";
            this.colDataNascimento.Name = "colDataNascimento";
            this.colDataNascimento.ReadOnly = true;
            this.colDataNascimento.Width = 135;
            // 
            // colDescricao
            // 
            this.colDescricao.DataPropertyName = "TipoUsuario";
            this.colDescricao.HeaderText = "Tipo de usuário";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            this.colDescricao.Width = 150;
            // 
            // colAtivo
            // 
            this.colAtivo.DataPropertyName = "Pessoa";
            this.colAtivo.HeaderText = "Ativo";
            this.colAtivo.Name = "colAtivo";
            this.colAtivo.ReadOnly = true;
            // 
            // txtSelecionarUsuarioCodNome
            // 
            this.txtSelecionarUsuarioCodNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelecionarUsuarioCodNome.Location = new System.Drawing.Point(160, 75);
            this.txtSelecionarUsuarioCodNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtSelecionarUsuarioCodNome.Name = "txtSelecionarUsuarioCodNome";
            this.txtSelecionarUsuarioCodNome.Size = new System.Drawing.Size(715, 30);
            this.txtSelecionarUsuarioCodNome.TabIndex = 2;
            // 
            // lblSelecionarTitulo
            // 
            this.lblSelecionarTitulo.AutoSize = true;
            this.lblSelecionarTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecionarTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblSelecionarTitulo.Location = new System.Drawing.Point(83, 9);
            this.lblSelecionarTitulo.Name = "lblSelecionarTitulo";
            this.lblSelecionarTitulo.Size = new System.Drawing.Size(311, 38);
            this.lblSelecionarTitulo.TabIndex = 0;
            this.lblSelecionarTitulo.Text = "Selecionar Usuário";
            // 
            // pbcSelecionar
            // 
            this.pbcSelecionar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbcSelecionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbcSelecionar.Image = global::Apresentacao.Properties.Resources._1440663087_checked_user;
            this.pbcSelecionar.Location = new System.Drawing.Point(6, 6);
            this.pbcSelecionar.Name = "pbcSelecionar";
            this.pbcSelecionar.Size = new System.Drawing.Size(71, 69);
            this.pbcSelecionar.TabIndex = 21;
            this.pbcSelecionar.TabStop = false;
            // 
            // btnSelecionarPesquisar
            // 
            this.btnSelecionarPesquisar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelecionarPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSelecionarPesquisar.FlatAppearance.BorderSize = 0;
            this.btnSelecionarPesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSelecionarPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSelecionarPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarPesquisar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelecionarPesquisar.Image = global::Apresentacao.Properties.Resources.ic_search_black_24dp1;
            this.btnSelecionarPesquisar.Location = new System.Drawing.Point(845, 78);
            this.btnSelecionarPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelecionarPesquisar.Name = "btnSelecionarPesquisar";
            this.btnSelecionarPesquisar.Size = new System.Drawing.Size(23, 20);
            this.btnSelecionarPesquisar.TabIndex = 3;
            this.btnSelecionarPesquisar.UseVisualStyleBackColor = false;
            this.btnSelecionarPesquisar.Click += new System.EventHandler(this.btnSelecionarUsuarioPesquisar_Click);
            this.btnSelecionarPesquisar.MouseLeave += new System.EventHandler(this.btnSelecionarPesquisar_MouseLeave);
            this.btnSelecionarPesquisar.MouseHover += new System.EventHandler(this.btnSelecionarUsuarioPesquisar_MouseHover);
            // 
            // FrmUsuarioSelecionar
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(881, 525);
            this.Controls.Add(this.lblSelecionarTitulo);
            this.Controls.Add(this.pbcSelecionar);
            this.Controls.Add(this.listBoxSelecionarUsuario);
            this.Controls.Add(this.lblSelecionarUsuarioNome);
            this.Controls.Add(this.btnSelecionarUsuarioInserir);
            this.Controls.Add(this.btnSelecionarUsuarioAlterar);
            this.Controls.Add(this.btnSelecionarUsuarioCancelar);
            this.Controls.Add(this.dgwSelecionarUsuario);
            this.Controls.Add(this.btnSelecionarPesquisar);
            this.Controls.Add(this.txtSelecionarUsuarioCodNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUsuarioSelecionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecinar Usuario";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmUsuarioSelecionar_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSelecionarUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcSelecionar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void AtualizarGridUsuario(DialogResult dialogResult)
        {
            using(UsuarioNegocio usuarioNegocio = new UsuarioNegocio())
            {
                ValidacaoInterfaces validarInterfaces = new ValidacaoInterfaces();

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        ListaUsuario listaUsuario = usuarioNegocio.Consultar( null, "%");
                        dgwSelecionarUsuario.DataSource = null;
                        dgwSelecionarUsuario.DataSource = listaUsuario;
                        dgwSelecionarUsuario.Update();
                        dgwSelecionarUsuario.Refresh();
                        txtSelecionarUsuarioCodNome.Focus();
                        txtSelecionarUsuarioCodNome.Clear();
                        return;

                    }
                    catch(Exception ex)
                    {

                        MessageBox.Show("Não foi possível atualizar, após ter inserido ou alterado o usuário. Detalhes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                else if (validarInterfaces.ValidarCampoPesquisar(txtSelecionarUsuarioCodNome, "nome") == true)
                {
                    return;
                }
                else if (txtSelecionarUsuarioCodNome.Text.Where(c => char.IsNumber(c)).Count() > 0)
                {
                    try
                    {
                        
                        ListaUsuario listaUsuario = usuarioNegocio.Consultar(Convert.ToInt32(txtSelecionarUsuarioCodNome.Text), null);
                        if (listaUsuario.Count() > 0)
                        {
                            dgwSelecionarUsuario.DataSource = null;
                            dgwSelecionarUsuario.DataSource = listaUsuario;
                            dgwSelecionarUsuario.Update();
                            dgwSelecionarUsuario.Refresh();
                            txtSelecionarUsuarioCodNome.Focus();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Não existe nenhum usuário com esse código: " + txtSelecionarUsuarioCodNome.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtSelecionarUsuarioCodNome.Focus();
                            return;
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível pesquisar usuário por código. Detalhes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        ListaUsuario listaUsuario = usuarioNegocio.Consultar(null, txtSelecionarUsuarioCodNome.Text);
                        if(listaUsuario.Count() > 0)
                        {
                            dgwSelecionarUsuario.DataSource = null;
                            dgwSelecionarUsuario.DataSource = listaUsuario;
                            dgwSelecionarUsuario.Update();
                            dgwSelecionarUsuario.Refresh();
                            txtSelecionarUsuarioCodNome.Focus();
                            return;
                        }
                        
                        else 
                        {
                             MessageBox.Show("Não existe nenhum usuário com esse nome: " + txtSelecionarUsuarioCodNome.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtSelecionarUsuarioCodNome.Focus();
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível pesquisar usuário por nome. Detalhes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSelecionarUsuarioCodNome.Focus();
                        return;
                    }

                }


            }

        }

        private void dgwSelecionarUsuario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 0 && e.Value is  Pessoa)
            {
                e.Value = (e.Value as Pessoa).IDPessoa;
            }

            if(e.ColumnIndex == 1 && e.Value is Pessoa)
            {
                e.Value = (e.Value as Pessoa).Nome;
            }

            if(e.ColumnIndex == 2 && e.Value is Pessoa)
            {
                if ((e.Value as Pessoa).Sexo == true)
                    e.Value = "Masculino";
                else
                    e.Value = "Feminino";              
            }

            if(e.ColumnIndex == 3 && e.Value is Pessoa)
            {
                e.Value = (e.Value as Pessoa).DataNascimento.ToShortDateString();
            }

            if (e.ColumnIndex == 4 && e.Value is TipoUsuario)
            {
                e.Value = (e.Value as TipoUsuario).Descricao;
            }

            if (e.ColumnIndex == 5 && e.Value is Pessoa)
            {
                if ((e.Value as Pessoa).Ativo == true)
                    e.Value = "Sim";
                else
                    e.Value = "Não";
               
            }


        }

        private void btnSelecionarUsuarioPesquisar_MouseHover(object sender, EventArgs e)
        {
            ttpSelecionarPesquisar.Show("Pesquisar", btnSelecionarPesquisar);
            btnSelecionarPesquisar.Image= global::Apresentacao.Properties.Resources.ic_search_grey600_24dp;
        }

        private void btnSelecionarUsuarioPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGridUsuario(DialogResult.No);
        }

        private void btnSelecionarUsuarioCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelecionarUsuarioAlterar_Click(object sender, EventArgs e)
        {
           if(dgwSelecionarUsuario.SelectedRows.Count == 0)
           {
               MessageBox.Show("Nenhum usuário está selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
               txtSelecionarUsuarioCodNome.Focus();
               return;
           }

           Usuario usuario = (dgwSelecionarUsuario.SelectedRows[0].DataBoundItem as Usuario);
           FrmUsuarioCadastrar frmUsuarioCadastrar = new FrmUsuarioCadastrar(AcaoNaTela.Alterar, usuario);
           DialogResult dialogResult = frmUsuarioCadastrar.ShowDialog();

           if (dialogResult == DialogResult.Yes)
               AtualizarGridUsuario(DialogResult.Yes);

        }

        private void btnSelecionarUsuarioInserir_Click(object sender, EventArgs e)
        {
            FrmUsuarioCadastrar frmUsuarioCadastrar = new FrmUsuarioCadastrar(AcaoNaTela.Inserir, null);
            DialogResult dialogResult = frmUsuarioCadastrar.ShowDialog();

            if (dialogResult == DialogResult.Yes)
                AtualizarGridUsuario(DialogResult.Yes);

        }

        private void dgwSelecionarUsuario_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.btnSelecionarUsuarioAlterar.PerformClick();
        }

        private void btnSelecionarPesquisar_MouseLeave(object sender, EventArgs e)
        {
            btnSelecionarPesquisar.Image= global::Apresentacao.Properties.Resources.ic_search_black_24dp1;
        }

        private void FrmUsuarioSelecionar_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.F1)
            {
                AtualizarGridUsuario(DialogResult.No);
            }
            else if (e.KeyCode == Keys.F2)
            {
                this.btnSelecionarUsuarioInserir.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                this.btnSelecionarUsuarioAlterar.PerformClick();
            }
            else if (this.txtSelecionarUsuarioCodNome.Text != "" && e.KeyCode == Keys.Enter)
            {
                AtualizarGridUsuario(DialogResult.No);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

       

       
        }

     
    }

