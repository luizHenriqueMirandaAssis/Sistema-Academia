namespace Apresentacao.TreinamentoInterfaces.TipoTreinamentoInterfaces
{
    partial class FrmTipoTreinamentoCadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipoTreinamentoCadastrar));
            this.btnTipoTreinamentoCadastrar = new System.Windows.Forms.Button();
            this.lblTipoUsuarioObs = new System.Windows.Forms.Label();
            this.btnTipoTreinamentoCancelar = new System.Windows.Forms.Button();
            this.grpTipoTreinamentoFisico = new System.Windows.Forms.GroupBox();
            this.grpBoxAtivo = new System.Windows.Forms.GroupBox();
            this.rbtCadastrarAtivoNao = new System.Windows.Forms.RadioButton();
            this.rbtCadastrarAtivoSim = new System.Windows.Forms.RadioButton();
            this.txtCadastrarCodigo = new System.Windows.Forms.TextBox();
            this.lblCadastrarDescricao = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCadastrarTipoTreinamentoDescricao = new System.Windows.Forms.TextBox();
            this.pbxCadastrarTipoTreinamento = new System.Windows.Forms.PictureBox();
            this.lblTipoTreinamentoFisicoTitulo = new System.Windows.Forms.Label();
            this.listBoxSelecionar = new System.Windows.Forms.ListBox();
            this.grpTipoTreinamentoFisico.SuspendLayout();
            this.grpBoxAtivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCadastrarTipoTreinamento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTipoTreinamentoCadastrar
            // 
            this.btnTipoTreinamentoCadastrar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTipoTreinamentoCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoTreinamentoCadastrar.Image = global::Apresentacao.Properties.Resources._1440735931_save1;
            this.btnTipoTreinamentoCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTipoTreinamentoCadastrar.Location = new System.Drawing.Point(552, 85);
            this.btnTipoTreinamentoCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnTipoTreinamentoCadastrar.Name = "btnTipoTreinamentoCadastrar";
            this.btnTipoTreinamentoCadastrar.Size = new System.Drawing.Size(168, 68);
            this.btnTipoTreinamentoCadastrar.TabIndex = 96;
            this.btnTipoTreinamentoCadastrar.Text = "Cadastrar";
            this.btnTipoTreinamentoCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTipoTreinamentoCadastrar.UseVisualStyleBackColor = false;
            this.btnTipoTreinamentoCadastrar.Click += new System.EventHandler(this.btnTipoTreinamentoCadastrar_Click);
            // 
            // lblTipoUsuarioObs
            // 
            this.lblTipoUsuarioObs.AutoSize = true;
            this.lblTipoUsuarioObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUsuarioObs.ForeColor = System.Drawing.Color.Black;
            this.lblTipoUsuarioObs.Location = new System.Drawing.Point(213, 318);
            this.lblTipoUsuarioObs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoUsuarioObs.Name = "lblTipoUsuarioObs";
            this.lblTipoUsuarioObs.Size = new System.Drawing.Size(454, 25);
            this.lblTipoUsuarioObs.TabIndex = 95;
            this.lblTipoUsuarioObs.Text = "Obs: Os campos marcados com * são obrigatórios.";
            // 
            // btnTipoTreinamentoCancelar
            // 
            this.btnTipoTreinamentoCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTipoTreinamentoCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoTreinamentoCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnTipoTreinamentoCancelar.Image")));
            this.btnTipoTreinamentoCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTipoTreinamentoCancelar.Location = new System.Drawing.Point(728, 85);
            this.btnTipoTreinamentoCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnTipoTreinamentoCancelar.Name = "btnTipoTreinamentoCancelar";
            this.btnTipoTreinamentoCancelar.Size = new System.Drawing.Size(168, 68);
            this.btnTipoTreinamentoCancelar.TabIndex = 97;
            this.btnTipoTreinamentoCancelar.Text = "Cancelar";
            this.btnTipoTreinamentoCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTipoTreinamentoCancelar.UseVisualStyleBackColor = false;
            this.btnTipoTreinamentoCancelar.Click += new System.EventHandler(this.btnTipoTreinamentoCancelar_Click);
            // 
            // grpTipoTreinamentoFisico
            // 
            this.grpTipoTreinamentoFisico.Controls.Add(this.grpBoxAtivo);
            this.grpTipoTreinamentoFisico.Controls.Add(this.txtCadastrarCodigo);
            this.grpTipoTreinamentoFisico.Controls.Add(this.lblCadastrarDescricao);
            this.grpTipoTreinamentoFisico.Controls.Add(this.lblCodigo);
            this.grpTipoTreinamentoFisico.Controls.Add(this.txtCadastrarTipoTreinamentoDescricao);
            this.grpTipoTreinamentoFisico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTipoTreinamentoFisico.Location = new System.Drawing.Point(16, 160);
            this.grpTipoTreinamentoFisico.Margin = new System.Windows.Forms.Padding(4);
            this.grpTipoTreinamentoFisico.Name = "grpTipoTreinamentoFisico";
            this.grpTipoTreinamentoFisico.Padding = new System.Windows.Forms.Padding(4);
            this.grpTipoTreinamentoFisico.Size = new System.Drawing.Size(880, 150);
            this.grpTipoTreinamentoFisico.TabIndex = 94;
            this.grpTipoTreinamentoFisico.TabStop = false;
            this.grpTipoTreinamentoFisico.Text = "Tipo de treinamento físico";
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
            this.grpBoxAtivo.TabIndex = 2;
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
            this.txtCadastrarCodigo.TabIndex = 3;
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
            this.lblCadastrarDescricao.TabIndex = 1;
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
            // txtCadastrarTipoTreinamentoDescricao
            // 
            this.txtCadastrarTipoTreinamentoDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastrarTipoTreinamentoDescricao.Location = new System.Drawing.Point(107, 71);
            this.txtCadastrarTipoTreinamentoDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtCadastrarTipoTreinamentoDescricao.Name = "txtCadastrarTipoTreinamentoDescricao";
            this.txtCadastrarTipoTreinamentoDescricao.Size = new System.Drawing.Size(620, 30);
            this.txtCadastrarTipoTreinamentoDescricao.TabIndex = 4;
            // 
            // pbxCadastrarTipoTreinamento
            // 
            this.pbxCadastrarTipoTreinamento.Image = global::Apresentacao.Properties.Resources._1440663403_add_property;
            this.pbxCadastrarTipoTreinamento.Location = new System.Drawing.Point(16, 14);
            this.pbxCadastrarTipoTreinamento.Margin = new System.Windows.Forms.Padding(4);
            this.pbxCadastrarTipoTreinamento.Name = "pbxCadastrarTipoTreinamento";
            this.pbxCadastrarTipoTreinamento.Size = new System.Drawing.Size(91, 81);
            this.pbxCadastrarTipoTreinamento.TabIndex = 98;
            this.pbxCadastrarTipoTreinamento.TabStop = false;
            // 
            // lblTipoTreinamentoFisicoTitulo
            // 
            this.lblTipoTreinamentoFisicoTitulo.AutoSize = true;
            this.lblTipoTreinamentoFisicoTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoTreinamentoFisicoTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTipoTreinamentoFisicoTitulo.Location = new System.Drawing.Point(109, 14);
            this.lblTipoTreinamentoFisicoTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoTreinamentoFisicoTitulo.Name = "lblTipoTreinamentoFisicoTitulo";
            this.lblTipoTreinamentoFisicoTitulo.Size = new System.Drawing.Size(606, 38);
            this.lblTipoTreinamentoFisicoTitulo.TabIndex = 93;
            this.lblTipoTreinamentoFisicoTitulo.Text = "Cadastrar Tipo De Treinamento Físico";
            // 
            // listBoxSelecionar
            // 
            this.listBoxSelecionar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBoxSelecionar.Enabled = false;
            this.listBoxSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSelecionar.FormattingEnabled = true;
            this.listBoxSelecionar.ItemHeight = 20;
            this.listBoxSelecionar.Items.AddRange(new object[] {
            "F1: Cadastrar - F2: Cancelar"});
            this.listBoxSelecionar.Location = new System.Drawing.Point(667, 56);
            this.listBoxSelecionar.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxSelecionar.Name = "listBoxSelecionar";
            this.listBoxSelecionar.Size = new System.Drawing.Size(229, 24);
            this.listBoxSelecionar.TabIndex = 103;
            this.listBoxSelecionar.TabStop = false;
            // 
            // FrmTipoTreinamentoCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(912, 356);
            this.ControlBox = false;
            this.Controls.Add(this.listBoxSelecionar);
            this.Controls.Add(this.btnTipoTreinamentoCadastrar);
            this.Controls.Add(this.lblTipoUsuarioObs);
            this.Controls.Add(this.btnTipoTreinamentoCancelar);
            this.Controls.Add(this.grpTipoTreinamentoFisico);
            this.Controls.Add(this.pbxCadastrarTipoTreinamento);
            this.Controls.Add(this.lblTipoTreinamentoFisicoTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmTipoTreinamentoCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Tipo De Treinamento";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTipoTreinamentoCadastrar_KeyDown);
            this.grpTipoTreinamentoFisico.ResumeLayout(false);
            this.grpTipoTreinamentoFisico.PerformLayout();
            this.grpBoxAtivo.ResumeLayout(false);
            this.grpBoxAtivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCadastrarTipoTreinamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTipoTreinamentoCadastrar;
        private System.Windows.Forms.Label lblTipoUsuarioObs;
        private System.Windows.Forms.Button btnTipoTreinamentoCancelar;
        private System.Windows.Forms.GroupBox grpTipoTreinamentoFisico;
        private System.Windows.Forms.GroupBox grpBoxAtivo;
        private System.Windows.Forms.RadioButton rbtCadastrarAtivoNao;
        private System.Windows.Forms.RadioButton rbtCadastrarAtivoSim;
        private System.Windows.Forms.TextBox txtCadastrarCodigo;
        private System.Windows.Forms.Label lblCadastrarDescricao;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCadastrarTipoTreinamentoDescricao;
        private System.Windows.Forms.PictureBox pbxCadastrarTipoTreinamento;
        private System.Windows.Forms.Label lblTipoTreinamentoFisicoTitulo;
        private System.Windows.Forms.ListBox listBoxSelecionar;
    }
}