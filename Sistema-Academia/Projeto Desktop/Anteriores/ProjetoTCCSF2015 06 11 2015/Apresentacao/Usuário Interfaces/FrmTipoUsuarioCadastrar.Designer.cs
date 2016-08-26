namespace Apresentacao.Usuário_Interfaces
{
    partial class FrmTipoUsuarioCadastrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTipoUsuarioCadastrar = new System.Windows.Forms.Button();
            this.lblTipoUsuarioObs = new System.Windows.Forms.Label();
            this.btnTipoUsuarioCancelar = new System.Windows.Forms.Button();
            this.grpTipoUsuario = new System.Windows.Forms.GroupBox();
            this.grpBoxAtivo = new System.Windows.Forms.GroupBox();
            this.rbtCadastrarAtivoNao = new System.Windows.Forms.RadioButton();
            this.rbtCadastrarAtivoSim = new System.Windows.Forms.RadioButton();
            this.txtCadastrarCodigo = new System.Windows.Forms.TextBox();
            this.lblCadastrarDescricao = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCadastrarDescricao = new System.Windows.Forms.TextBox();
            this.lblTipoUsuarioCadastrarTitulo = new System.Windows.Forms.Label();
            this.pbxCadastrarTipoUsuario = new System.Windows.Forms.PictureBox();
            this.listBoxSelecionar = new System.Windows.Forms.ListBox();
            this.grpTipoUsuario.SuspendLayout();
            this.grpBoxAtivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCadastrarTipoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTipoUsuarioCadastrar
            // 
            this.btnTipoUsuarioCadastrar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTipoUsuarioCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoUsuarioCadastrar.Image = global::Apresentacao.Properties.Resources._1440735931_save1;
            this.btnTipoUsuarioCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTipoUsuarioCadastrar.Location = new System.Drawing.Point(552, 89);
            this.btnTipoUsuarioCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnTipoUsuarioCadastrar.Name = "btnTipoUsuarioCadastrar";
            this.btnTipoUsuarioCadastrar.Size = new System.Drawing.Size(168, 68);
            this.btnTipoUsuarioCadastrar.TabIndex = 3;
            this.btnTipoUsuarioCadastrar.Text = "Salvar";
            this.btnTipoUsuarioCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTipoUsuarioCadastrar.UseVisualStyleBackColor = false;
            this.btnTipoUsuarioCadastrar.Click += new System.EventHandler(this.btnTipoUsuarioCadastrar_Click);
            // 
            // lblTipoUsuarioObs
            // 
            this.lblTipoUsuarioObs.AutoSize = true;
            this.lblTipoUsuarioObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUsuarioObs.ForeColor = System.Drawing.Color.Black;
            this.lblTipoUsuarioObs.Location = new System.Drawing.Point(213, 320);
            this.lblTipoUsuarioObs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoUsuarioObs.Name = "lblTipoUsuarioObs";
            this.lblTipoUsuarioObs.Size = new System.Drawing.Size(454, 25);
            this.lblTipoUsuarioObs.TabIndex = 2;
            this.lblTipoUsuarioObs.Text = "Obs: Os campos marcados com * são obrigatórios.";
            // 
            // btnTipoUsuarioCancelar
            // 
            this.btnTipoUsuarioCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTipoUsuarioCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoUsuarioCancelar.Image = global::Apresentacao.Properties.Resources._1440736764_delete;
            this.btnTipoUsuarioCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTipoUsuarioCancelar.Location = new System.Drawing.Point(728, 89);
            this.btnTipoUsuarioCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnTipoUsuarioCancelar.Name = "btnTipoUsuarioCancelar";
            this.btnTipoUsuarioCancelar.Size = new System.Drawing.Size(168, 68);
            this.btnTipoUsuarioCancelar.TabIndex = 4;
            this.btnTipoUsuarioCancelar.Text = "Cancelar";
            this.btnTipoUsuarioCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTipoUsuarioCancelar.UseVisualStyleBackColor = false;
            this.btnTipoUsuarioCancelar.Click += new System.EventHandler(this.btnTipoUsuarioCancelar_Click);
            // 
            // grpTipoUsuario
            // 
            this.grpTipoUsuario.Controls.Add(this.grpBoxAtivo);
            this.grpTipoUsuario.Controls.Add(this.txtCadastrarCodigo);
            this.grpTipoUsuario.Controls.Add(this.lblCadastrarDescricao);
            this.grpTipoUsuario.Controls.Add(this.lblCodigo);
            this.grpTipoUsuario.Controls.Add(this.txtCadastrarDescricao);
            this.grpTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTipoUsuario.Location = new System.Drawing.Point(16, 164);
            this.grpTipoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.grpTipoUsuario.Name = "grpTipoUsuario";
            this.grpTipoUsuario.Padding = new System.Windows.Forms.Padding(4);
            this.grpTipoUsuario.Size = new System.Drawing.Size(880, 150);
            this.grpTipoUsuario.TabIndex = 1;
            this.grpTipoUsuario.TabStop = false;
            this.grpTipoUsuario.Text = "Tipo de usuário";
            // 
            // grpBoxAtivo
            // 
            this.grpBoxAtivo.Controls.Add(this.rbtCadastrarAtivoNao);
            this.grpBoxAtivo.Controls.Add(this.rbtCadastrarAtivoSim);
            this.grpBoxAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxAtivo.Location = new System.Drawing.Point(736, 43);
            this.grpBoxAtivo.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxAtivo.Name = "grpBoxAtivo";
            this.grpBoxAtivo.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxAtivo.Size = new System.Drawing.Size(136, 60);
            this.grpBoxAtivo.TabIndex = 4;
            this.grpBoxAtivo.TabStop = false;
            this.grpBoxAtivo.Text = "*Ativo";
            // 
            // rbtCadastrarAtivoNao
            // 
            this.rbtCadastrarAtivoNao.AutoSize = true;
            this.rbtCadastrarAtivoNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtCadastrarAtivoNao.Location = new System.Drawing.Point(72, 28);
            this.rbtCadastrarAtivoNao.Margin = new System.Windows.Forms.Padding(4);
            this.rbtCadastrarAtivoNao.Name = "rbtCadastrarAtivoNao";
            this.rbtCadastrarAtivoNao.Size = new System.Drawing.Size(55, 21);
            this.rbtCadastrarAtivoNao.TabIndex = 1;
            this.rbtCadastrarAtivoNao.TabStop = true;
            this.rbtCadastrarAtivoNao.Text = "Não";
            this.rbtCadastrarAtivoNao.UseVisualStyleBackColor = true;
            // 
            // rbtCadastrarAtivoSim
            // 
            this.rbtCadastrarAtivoSim.AutoSize = true;
            this.rbtCadastrarAtivoSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtCadastrarAtivoSim.Location = new System.Drawing.Point(8, 28);
            this.rbtCadastrarAtivoSim.Margin = new System.Windows.Forms.Padding(4);
            this.rbtCadastrarAtivoSim.Name = "rbtCadastrarAtivoSim";
            this.rbtCadastrarAtivoSim.Size = new System.Drawing.Size(52, 21);
            this.rbtCadastrarAtivoSim.TabIndex = 0;
            this.rbtCadastrarAtivoSim.TabStop = true;
            this.rbtCadastrarAtivoSim.Text = "Sim";
            this.rbtCadastrarAtivoSim.UseVisualStyleBackColor = true;
            // 
            // txtCadastrarCodigo
            // 
            this.txtCadastrarCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastrarCodigo.Location = new System.Drawing.Point(13, 71);
            this.txtCadastrarCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCadastrarCodigo.Name = "txtCadastrarCodigo";
            this.txtCadastrarCodigo.ReadOnly = true;
            this.txtCadastrarCodigo.Size = new System.Drawing.Size(85, 30);
            this.txtCadastrarCodigo.TabIndex = 1;
            this.txtCadastrarCodigo.TabStop = false;
            this.txtCadastrarCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCadastrarDescricao
            // 
            this.lblCadastrarDescricao.AutoSize = true;
            this.lblCadastrarDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarDescricao.ForeColor = System.Drawing.Color.Black;
            this.lblCadastrarDescricao.Location = new System.Drawing.Point(101, 43);
            this.lblCadastrarDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastrarDescricao.Name = "lblCadastrarDescricao";
            this.lblCadastrarDescricao.Size = new System.Drawing.Size(112, 25);
            this.lblCadastrarDescricao.TabIndex = 2;
            this.lblCadastrarDescricao.Text = "* Descrição";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Black;
            this.lblCodigo.Location = new System.Drawing.Point(8, 48);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(75, 25);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // txtCadastrarDescricao
            // 
            this.txtCadastrarDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastrarDescricao.Location = new System.Drawing.Point(107, 71);
            this.txtCadastrarDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtCadastrarDescricao.Name = "txtCadastrarDescricao";
            this.txtCadastrarDescricao.Size = new System.Drawing.Size(620, 30);
            this.txtCadastrarDescricao.TabIndex = 3;
            // 
            // lblTipoUsuarioCadastrarTitulo
            // 
            this.lblTipoUsuarioCadastrarTitulo.AutoSize = true;
            this.lblTipoUsuarioCadastrarTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUsuarioCadastrarTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTipoUsuarioCadastrarTitulo.Location = new System.Drawing.Point(109, 15);
            this.lblTipoUsuarioCadastrarTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoUsuarioCadastrarTitulo.Name = "lblTipoUsuarioCadastrarTitulo";
            this.lblTipoUsuarioCadastrarTitulo.Size = new System.Drawing.Size(431, 38);
            this.lblTipoUsuarioCadastrarTitulo.TabIndex = 0;
            this.lblTipoUsuarioCadastrarTitulo.Text = "Cadastrar Tipo De Usuário";
            // 
            // pbxCadastrarTipoUsuario
            // 
            this.pbxCadastrarTipoUsuario.Image = global::Apresentacao.Properties.Resources._1440663403_add_property;
            this.pbxCadastrarTipoUsuario.Location = new System.Drawing.Point(16, 15);
            this.pbxCadastrarTipoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.pbxCadastrarTipoUsuario.Name = "pbxCadastrarTipoUsuario";
            this.pbxCadastrarTipoUsuario.Size = new System.Drawing.Size(91, 81);
            this.pbxCadastrarTipoUsuario.TabIndex = 86;
            this.pbxCadastrarTipoUsuario.TabStop = false;
            // 
            // listBoxSelecionar
            // 
            this.listBoxSelecionar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBoxSelecionar.Enabled = false;
            this.listBoxSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSelecionar.FormattingEnabled = true;
            this.listBoxSelecionar.ItemHeight = 20;
            this.listBoxSelecionar.Items.AddRange(new object[] {
            "F1: Salvar - F2: Cancelar"});
            this.listBoxSelecionar.Location = new System.Drawing.Point(715, 15);
            this.listBoxSelecionar.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxSelecionar.Name = "listBoxSelecionar";
            this.listBoxSelecionar.Size = new System.Drawing.Size(181, 24);
            this.listBoxSelecionar.TabIndex = 102;
            this.listBoxSelecionar.TabStop = false;
            // 
            // FrmTipoUsuarioCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(912, 356);
            this.ControlBox = false;
            this.Controls.Add(this.listBoxSelecionar);
            this.Controls.Add(this.pbxCadastrarTipoUsuario);
            this.Controls.Add(this.btnTipoUsuarioCadastrar);
            this.Controls.Add(this.lblTipoUsuarioObs);
            this.Controls.Add(this.btnTipoUsuarioCancelar);
            this.Controls.Add(this.grpTipoUsuario);
            this.Controls.Add(this.lblTipoUsuarioCadastrarTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTipoUsuarioCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Tipo Usuário";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmTipoUsuarioCadastrar_KeyUp);
            this.grpTipoUsuario.ResumeLayout(false);
            this.grpTipoUsuario.PerformLayout();
            this.grpBoxAtivo.ResumeLayout(false);
            this.grpBoxAtivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCadastrarTipoUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxCadastrarTipoUsuario;
        private System.Windows.Forms.Button btnTipoUsuarioCadastrar;
        private System.Windows.Forms.Label lblTipoUsuarioObs;
        private System.Windows.Forms.Button btnTipoUsuarioCancelar;
        private System.Windows.Forms.GroupBox grpTipoUsuario;
        private System.Windows.Forms.Label lblCadastrarDescricao;
        private System.Windows.Forms.TextBox txtCadastrarDescricao;
        private System.Windows.Forms.Label lblTipoUsuarioCadastrarTitulo;
        private System.Windows.Forms.TextBox txtCadastrarCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox grpBoxAtivo;
        private System.Windows.Forms.RadioButton rbtCadastrarAtivoNao;
        private System.Windows.Forms.RadioButton rbtCadastrarAtivoSim;
        private System.Windows.Forms.ListBox listBoxSelecionar;
    }
}