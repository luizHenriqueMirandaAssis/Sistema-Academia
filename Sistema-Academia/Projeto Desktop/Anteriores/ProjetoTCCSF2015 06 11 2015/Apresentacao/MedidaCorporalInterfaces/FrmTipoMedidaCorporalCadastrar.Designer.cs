namespace Apresentacao.MedidaCorporalInterfaces
{
    partial class FrmTipoMedidaCorporalCadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipoMedidaCorporalCadastrar));
            this.btnTipoMedidaCadastrar = new System.Windows.Forms.Button();
            this.lblTipoUsuarioObs = new System.Windows.Forms.Label();
            this.btnTipoMedidaCancelar = new System.Windows.Forms.Button();
            this.grpTipoMedida = new System.Windows.Forms.GroupBox();
            this.grpBoxAtivo = new System.Windows.Forms.GroupBox();
            this.rbtCadastrarAtivoNao = new System.Windows.Forms.RadioButton();
            this.rbtCadastrarAtivoSim = new System.Windows.Forms.RadioButton();
            this.txtCadastrarCodigo = new System.Windows.Forms.TextBox();
            this.lblCadastrarDescricao = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCadastrarDescricao = new System.Windows.Forms.TextBox();
            this.lblTipoMedidaCadastrarTitulo = new System.Windows.Forms.Label();
            this.pbxCadastrarTipoMedida = new System.Windows.Forms.PictureBox();
            this.listBoxSelecionar = new System.Windows.Forms.ListBox();
            this.grpTipoMedida.SuspendLayout();
            this.grpBoxAtivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCadastrarTipoMedida)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTipoMedidaCadastrar
            // 
            this.btnTipoMedidaCadastrar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTipoMedidaCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoMedidaCadastrar.Image = global::Apresentacao.Properties.Resources._1440735931_save1;
            this.btnTipoMedidaCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTipoMedidaCadastrar.Location = new System.Drawing.Point(552, 81);
            this.btnTipoMedidaCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnTipoMedidaCadastrar.Name = "btnTipoMedidaCadastrar";
            this.btnTipoMedidaCadastrar.Size = new System.Drawing.Size(168, 68);
            this.btnTipoMedidaCadastrar.TabIndex = 3;
            this.btnTipoMedidaCadastrar.Text = "Salvar";
            this.btnTipoMedidaCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTipoMedidaCadastrar.UseVisualStyleBackColor = false;
            this.btnTipoMedidaCadastrar.Click += new System.EventHandler(this.btnTipoMedidaCadastrar_Click);
            // 
            // lblTipoUsuarioObs
            // 
            this.lblTipoUsuarioObs.AutoSize = true;
            this.lblTipoUsuarioObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUsuarioObs.ForeColor = System.Drawing.Color.Black;
            this.lblTipoUsuarioObs.Location = new System.Drawing.Point(213, 314);
            this.lblTipoUsuarioObs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoUsuarioObs.Name = "lblTipoUsuarioObs";
            this.lblTipoUsuarioObs.Size = new System.Drawing.Size(454, 25);
            this.lblTipoUsuarioObs.TabIndex = 2;
            this.lblTipoUsuarioObs.Text = "Obs: Os campos marcados com * são obrigatórios.";
            // 
            // btnTipoMedidaCancelar
            // 
            this.btnTipoMedidaCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTipoMedidaCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoMedidaCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnTipoMedidaCancelar.Image")));
            this.btnTipoMedidaCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTipoMedidaCancelar.Location = new System.Drawing.Point(728, 81);
            this.btnTipoMedidaCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnTipoMedidaCancelar.Name = "btnTipoMedidaCancelar";
            this.btnTipoMedidaCancelar.Size = new System.Drawing.Size(168, 68);
            this.btnTipoMedidaCancelar.TabIndex = 4;
            this.btnTipoMedidaCancelar.Text = "Cancelar";
            this.btnTipoMedidaCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTipoMedidaCancelar.UseVisualStyleBackColor = false;
            this.btnTipoMedidaCancelar.Click += new System.EventHandler(this.btnTipoMedidaCancelar_Click);
            // 
            // grpTipoMedida
            // 
            this.grpTipoMedida.Controls.Add(this.grpBoxAtivo);
            this.grpTipoMedida.Controls.Add(this.txtCadastrarCodigo);
            this.grpTipoMedida.Controls.Add(this.lblCadastrarDescricao);
            this.grpTipoMedida.Controls.Add(this.lblCodigo);
            this.grpTipoMedida.Controls.Add(this.txtCadastrarDescricao);
            this.grpTipoMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTipoMedida.Location = new System.Drawing.Point(16, 156);
            this.grpTipoMedida.Margin = new System.Windows.Forms.Padding(4);
            this.grpTipoMedida.Name = "grpTipoMedida";
            this.grpTipoMedida.Padding = new System.Windows.Forms.Padding(4);
            this.grpTipoMedida.Size = new System.Drawing.Size(880, 150);
            this.grpTipoMedida.TabIndex = 1;
            this.grpTipoMedida.TabStop = false;
            this.grpTipoMedida.Text = "Tipo de medida corporal";
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
            // txtCadastrarDescricao
            // 
            this.txtCadastrarDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastrarDescricao.Location = new System.Drawing.Point(107, 71);
            this.txtCadastrarDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtCadastrarDescricao.Name = "txtCadastrarDescricao";
            this.txtCadastrarDescricao.Size = new System.Drawing.Size(620, 30);
            this.txtCadastrarDescricao.TabIndex = 4;
            // 
            // lblTipoMedidaCadastrarTitulo
            // 
            this.lblTipoMedidaCadastrarTitulo.AutoSize = true;
            this.lblTipoMedidaCadastrarTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoMedidaCadastrarTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTipoMedidaCadastrarTitulo.Location = new System.Drawing.Point(109, 10);
            this.lblTipoMedidaCadastrarTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoMedidaCadastrarTitulo.Name = "lblTipoMedidaCadastrarTitulo";
            this.lblTipoMedidaCadastrarTitulo.Size = new System.Drawing.Size(566, 38);
            this.lblTipoMedidaCadastrarTitulo.TabIndex = 0;
            this.lblTipoMedidaCadastrarTitulo.Text = "Cadastrar Tipo De Medida Corporal";
            // 
            // pbxCadastrarTipoMedida
            // 
            this.pbxCadastrarTipoMedida.Image = global::Apresentacao.Properties.Resources._1440663403_add_property;
            this.pbxCadastrarTipoMedida.Location = new System.Drawing.Point(16, 10);
            this.pbxCadastrarTipoMedida.Margin = new System.Windows.Forms.Padding(4);
            this.pbxCadastrarTipoMedida.Name = "pbxCadastrarTipoMedida";
            this.pbxCadastrarTipoMedida.Size = new System.Drawing.Size(91, 81);
            this.pbxCadastrarTipoMedida.TabIndex = 92;
            this.pbxCadastrarTipoMedida.TabStop = false;
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
            this.listBoxSelecionar.Location = new System.Drawing.Point(13, 319);
            this.listBoxSelecionar.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxSelecionar.Name = "listBoxSelecionar";
            this.listBoxSelecionar.Size = new System.Drawing.Size(184, 24);
            this.listBoxSelecionar.TabIndex = 103;
            this.listBoxSelecionar.TabStop = false;
            // 
            // FrmTipoMedidaCorporalCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(912, 356);
            this.ControlBox = false;
            this.Controls.Add(this.listBoxSelecionar);
            this.Controls.Add(this.btnTipoMedidaCadastrar);
            this.Controls.Add(this.lblTipoUsuarioObs);
            this.Controls.Add(this.btnTipoMedidaCancelar);
            this.Controls.Add(this.grpTipoMedida);
            this.Controls.Add(this.pbxCadastrarTipoMedida);
            this.Controls.Add(this.lblTipoMedidaCadastrarTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTipoMedidaCorporalCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Tipo Medida Corporal";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTipoMedidaCorporalCadastrar_KeyDown);
            this.grpTipoMedida.ResumeLayout(false);
            this.grpTipoMedida.PerformLayout();
            this.grpBoxAtivo.ResumeLayout(false);
            this.grpBoxAtivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCadastrarTipoMedida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTipoMedidaCadastrar;
        private System.Windows.Forms.Label lblTipoUsuarioObs;
        private System.Windows.Forms.Button btnTipoMedidaCancelar;
        private System.Windows.Forms.GroupBox grpTipoMedida;
        private System.Windows.Forms.GroupBox grpBoxAtivo;
        private System.Windows.Forms.RadioButton rbtCadastrarAtivoNao;
        private System.Windows.Forms.RadioButton rbtCadastrarAtivoSim;
        private System.Windows.Forms.TextBox txtCadastrarCodigo;
        private System.Windows.Forms.Label lblCadastrarDescricao;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCadastrarDescricao;
        private System.Windows.Forms.PictureBox pbxCadastrarTipoMedida;
        private System.Windows.Forms.Label lblTipoMedidaCadastrarTitulo;
        private System.Windows.Forms.ListBox listBoxSelecionar;
    }
}