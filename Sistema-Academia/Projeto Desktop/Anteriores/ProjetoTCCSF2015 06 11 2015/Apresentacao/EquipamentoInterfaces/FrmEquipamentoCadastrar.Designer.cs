namespace Apresentacao.EquipamentoInterfaces
{
    partial class FrmEquipamentoCadastrar
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
            this.btnEquipamentoCadastrar = new System.Windows.Forms.Button();
            this.lblTipoUsuarioObs = new System.Windows.Forms.Label();
            this.btnEquipamentoCancelar = new System.Windows.Forms.Button();
            this.grpEquipamento = new System.Windows.Forms.GroupBox();
            this.txtCadastrarQuantidade = new System.Windows.Forms.TextBox();
            this.lblCadastrarQuantidade = new System.Windows.Forms.Label();
            this.grpBoxAtivo = new System.Windows.Forms.GroupBox();
            this.rbtCadastrarAtivoNao = new System.Windows.Forms.RadioButton();
            this.rbtCadastrarAtivoSim = new System.Windows.Forms.RadioButton();
            this.txtCadastrarCodigo = new System.Windows.Forms.TextBox();
            this.lblCadastrarNome = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCadastrarNomeEquipamento = new System.Windows.Forms.TextBox();
            this.lblEquipamentoCadastrarTitulo = new System.Windows.Forms.Label();
            this.pbxCadastrarEquipamento = new System.Windows.Forms.PictureBox();
            this.listBoxSelecionar = new System.Windows.Forms.ListBox();
            this.grpEquipamento.SuspendLayout();
            this.grpBoxAtivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCadastrarEquipamento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEquipamentoCadastrar
            // 
            this.btnEquipamentoCadastrar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEquipamentoCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipamentoCadastrar.Image = global::Apresentacao.Properties.Resources._1440735931_save;
            this.btnEquipamentoCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEquipamentoCadastrar.Location = new System.Drawing.Point(699, 28);
            this.btnEquipamentoCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEquipamentoCadastrar.Name = "btnEquipamentoCadastrar";
            this.btnEquipamentoCadastrar.Size = new System.Drawing.Size(168, 68);
            this.btnEquipamentoCadastrar.TabIndex = 3;
            this.btnEquipamentoCadastrar.Text = "Salvar";
            this.btnEquipamentoCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEquipamentoCadastrar.UseVisualStyleBackColor = false;
            this.btnEquipamentoCadastrar.Click += new System.EventHandler(this.btnEquipamentoCadastrar_Click);
            // 
            // lblTipoUsuarioObs
            // 
            this.lblTipoUsuarioObs.AutoSize = true;
            this.lblTipoUsuarioObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUsuarioObs.ForeColor = System.Drawing.Color.Black;
            this.lblTipoUsuarioObs.Location = new System.Drawing.Point(287, 265);
            this.lblTipoUsuarioObs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoUsuarioObs.Name = "lblTipoUsuarioObs";
            this.lblTipoUsuarioObs.Size = new System.Drawing.Size(454, 25);
            this.lblTipoUsuarioObs.TabIndex = 2;
            this.lblTipoUsuarioObs.Text = "Obs: Os campos marcados com * são obrigatórios.";
            // 
            // btnEquipamentoCancelar
            // 
            this.btnEquipamentoCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEquipamentoCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipamentoCancelar.Image = global::Apresentacao.Properties.Resources._1440735675_delete;
            this.btnEquipamentoCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEquipamentoCancelar.Location = new System.Drawing.Point(875, 28);
            this.btnEquipamentoCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEquipamentoCancelar.Name = "btnEquipamentoCancelar";
            this.btnEquipamentoCancelar.Size = new System.Drawing.Size(168, 68);
            this.btnEquipamentoCancelar.TabIndex = 4;
            this.btnEquipamentoCancelar.Text = "Cancelar";
            this.btnEquipamentoCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEquipamentoCancelar.UseVisualStyleBackColor = false;
            this.btnEquipamentoCancelar.Click += new System.EventHandler(this.btnEquipamentoCancelar_Click);
            // 
            // grpEquipamento
            // 
            this.grpEquipamento.Controls.Add(this.txtCadastrarQuantidade);
            this.grpEquipamento.Controls.Add(this.lblCadastrarQuantidade);
            this.grpEquipamento.Controls.Add(this.grpBoxAtivo);
            this.grpEquipamento.Controls.Add(this.txtCadastrarCodigo);
            this.grpEquipamento.Controls.Add(this.lblCadastrarNome);
            this.grpEquipamento.Controls.Add(this.lblCodigo);
            this.grpEquipamento.Controls.Add(this.txtCadastrarNomeEquipamento);
            this.grpEquipamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEquipamento.Location = new System.Drawing.Point(16, 103);
            this.grpEquipamento.Margin = new System.Windows.Forms.Padding(4);
            this.grpEquipamento.Name = "grpEquipamento";
            this.grpEquipamento.Padding = new System.Windows.Forms.Padding(4);
            this.grpEquipamento.Size = new System.Drawing.Size(1027, 154);
            this.grpEquipamento.TabIndex = 1;
            this.grpEquipamento.TabStop = false;
            this.grpEquipamento.Text = "Equipamento";
            // 
            // txtCadastrarQuantidade
            // 
            this.txtCadastrarQuantidade.Location = new System.Drawing.Point(736, 71);
            this.txtCadastrarQuantidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtCadastrarQuantidade.Name = "txtCadastrarQuantidade";
            this.txtCadastrarQuantidade.Size = new System.Drawing.Size(129, 30);
            this.txtCadastrarQuantidade.TabIndex = 6;
            this.txtCadastrarQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCadastrarQuantidade
            // 
            this.lblCadastrarQuantidade.AutoSize = true;
            this.lblCadastrarQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarQuantidade.ForeColor = System.Drawing.Color.Black;
            this.lblCadastrarQuantidade.Location = new System.Drawing.Point(731, 43);
            this.lblCadastrarQuantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastrarQuantidade.Name = "lblCadastrarQuantidade";
            this.lblCadastrarQuantidade.Size = new System.Drawing.Size(127, 25);
            this.lblCadastrarQuantidade.TabIndex = 2;
            this.lblCadastrarQuantidade.Text = "* Quantidade";
            // 
            // grpBoxAtivo
            // 
            this.grpBoxAtivo.Controls.Add(this.rbtCadastrarAtivoNao);
            this.grpBoxAtivo.Controls.Add(this.rbtCadastrarAtivoSim);
            this.grpBoxAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxAtivo.Location = new System.Drawing.Point(875, 43);
            this.grpBoxAtivo.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxAtivo.Name = "grpBoxAtivo";
            this.grpBoxAtivo.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxAtivo.Size = new System.Drawing.Size(136, 60);
            this.grpBoxAtivo.TabIndex = 3;
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
            this.txtCadastrarCodigo.TabIndex = 4;
            this.txtCadastrarCodigo.TabStop = false;
            this.txtCadastrarCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCadastrarNome
            // 
            this.lblCadastrarNome.AutoSize = true;
            this.lblCadastrarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarNome.ForeColor = System.Drawing.Color.Black;
            this.lblCadastrarNome.Location = new System.Drawing.Point(101, 43);
            this.lblCadastrarNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastrarNome.Name = "lblCadastrarNome";
            this.lblCadastrarNome.Size = new System.Drawing.Size(77, 25);
            this.lblCadastrarNome.TabIndex = 1;
            this.lblCadastrarNome.Text = "* Nome";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Black;
            this.lblCodigo.Location = new System.Drawing.Point(15, 43);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(75, 25);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // txtCadastrarNomeEquipamento
            // 
            this.txtCadastrarNomeEquipamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastrarNomeEquipamento.Location = new System.Drawing.Point(107, 71);
            this.txtCadastrarNomeEquipamento.Margin = new System.Windows.Forms.Padding(4);
            this.txtCadastrarNomeEquipamento.Name = "txtCadastrarNomeEquipamento";
            this.txtCadastrarNomeEquipamento.Size = new System.Drawing.Size(620, 30);
            this.txtCadastrarNomeEquipamento.TabIndex = 5;
            // 
            // lblEquipamentoCadastrarTitulo
            // 
            this.lblEquipamentoCadastrarTitulo.AutoSize = true;
            this.lblEquipamentoCadastrarTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipamentoCadastrarTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblEquipamentoCadastrarTitulo.Location = new System.Drawing.Point(109, 15);
            this.lblEquipamentoCadastrarTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEquipamentoCadastrarTitulo.Name = "lblEquipamentoCadastrarTitulo";
            this.lblEquipamentoCadastrarTitulo.Size = new System.Drawing.Size(382, 38);
            this.lblEquipamentoCadastrarTitulo.TabIndex = 0;
            this.lblEquipamentoCadastrarTitulo.Text = "Cadastrar Equipamento";
            // 
            // pbxCadastrarEquipamento
            // 
            this.pbxCadastrarEquipamento.Image = global::Apresentacao.Properties.Resources._1440663403_add_property;
            this.pbxCadastrarEquipamento.Location = new System.Drawing.Point(16, 15);
            this.pbxCadastrarEquipamento.Margin = new System.Windows.Forms.Padding(4);
            this.pbxCadastrarEquipamento.Name = "pbxCadastrarEquipamento";
            this.pbxCadastrarEquipamento.Size = new System.Drawing.Size(91, 81);
            this.pbxCadastrarEquipamento.TabIndex = 100;
            this.pbxCadastrarEquipamento.TabStop = false;
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
            this.listBoxSelecionar.Location = new System.Drawing.Point(16, 265);
            this.listBoxSelecionar.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxSelecionar.Name = "listBoxSelecionar";
            this.listBoxSelecionar.Size = new System.Drawing.Size(182, 24);
            this.listBoxSelecionar.TabIndex = 102;
            this.listBoxSelecionar.TabStop = false;
            this.listBoxSelecionar.SelectedIndexChanged += new System.EventHandler(this.listBoxSelecionar_SelectedIndexChanged);
            // 
            // FrmEquipamentoCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1059, 298);
            this.ControlBox = false;
            this.Controls.Add(this.listBoxSelecionar);
            this.Controls.Add(this.pbxCadastrarEquipamento);
            this.Controls.Add(this.btnEquipamentoCadastrar);
            this.Controls.Add(this.lblTipoUsuarioObs);
            this.Controls.Add(this.btnEquipamentoCancelar);
            this.Controls.Add(this.grpEquipamento);
            this.Controls.Add(this.lblEquipamentoCadastrarTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEquipamentoCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadatrar Equipamento";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmEquipamentoCadastrar_KeyUp);
            this.grpEquipamento.ResumeLayout(false);
            this.grpEquipamento.PerformLayout();
            this.grpBoxAtivo.ResumeLayout(false);
            this.grpBoxAtivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCadastrarEquipamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEquipamentoCadastrar;
        private System.Windows.Forms.Label lblTipoUsuarioObs;
        private System.Windows.Forms.Button btnEquipamentoCancelar;
        private System.Windows.Forms.GroupBox grpEquipamento;
        private System.Windows.Forms.GroupBox grpBoxAtivo;
        private System.Windows.Forms.RadioButton rbtCadastrarAtivoNao;
        private System.Windows.Forms.RadioButton rbtCadastrarAtivoSim;
        private System.Windows.Forms.TextBox txtCadastrarCodigo;
        private System.Windows.Forms.Label lblCadastrarNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCadastrarNomeEquipamento;
        private System.Windows.Forms.Label lblEquipamentoCadastrarTitulo;
        private System.Windows.Forms.Label lblCadastrarQuantidade;
  
        private System.Windows.Forms.TextBox txtCadastrarQuantidade;
        private System.Windows.Forms.PictureBox pbxCadastrarEquipamento;
        private System.Windows.Forms.ListBox listBoxSelecionar;
    }
}