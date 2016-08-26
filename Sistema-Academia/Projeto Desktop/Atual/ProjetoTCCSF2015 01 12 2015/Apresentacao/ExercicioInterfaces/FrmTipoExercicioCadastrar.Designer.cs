namespace Apresentacao.ExercicioInterfaces
{
    partial class FrmTipoExercicioCadastrar
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
            this.btnTipoExercicioCadastrar = new System.Windows.Forms.Button();
            this.lblTipoExercicioObs = new System.Windows.Forms.Label();
            this.btnTipoExercicioCancelar = new System.Windows.Forms.Button();
            this.grpTipoExercicio = new System.Windows.Forms.GroupBox();
            this.txtCadastrarCodigo = new System.Windows.Forms.TextBox();
            this.lblCadastrarCodigo = new System.Windows.Forms.Label();
            this.grpBoxAtivo = new System.Windows.Forms.GroupBox();
            this.rbtnAlunoAtivoNao = new System.Windows.Forms.RadioButton();
            this.rbtnAlunoAtivoSim = new System.Windows.Forms.RadioButton();
            this.lblCadastrarDescricao = new System.Windows.Forms.Label();
            this.txtCadastrarDescricao = new System.Windows.Forms.TextBox();
            this.lblTipoExercicioCadastrarTitulo = new System.Windows.Forms.Label();
            this.pbxCadastrarTipoExercicio = new System.Windows.Forms.PictureBox();
            this.listBoxSelecionar = new System.Windows.Forms.ListBox();
            this.grpTipoExercicio.SuspendLayout();
            this.grpBoxAtivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCadastrarTipoExercicio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTipoExercicioCadastrar
            // 
            this.btnTipoExercicioCadastrar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTipoExercicioCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoExercicioCadastrar.Image = global::Apresentacao.Properties.Resources._1440735931_save1;
            this.btnTipoExercicioCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTipoExercicioCadastrar.Location = new System.Drawing.Point(552, 62);
            this.btnTipoExercicioCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnTipoExercicioCadastrar.Name = "btnTipoExercicioCadastrar";
            this.btnTipoExercicioCadastrar.Size = new System.Drawing.Size(168, 68);
            this.btnTipoExercicioCadastrar.TabIndex = 3;
            this.btnTipoExercicioCadastrar.Text = "Salvar";
            this.btnTipoExercicioCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTipoExercicioCadastrar.UseVisualStyleBackColor = false;
            this.btnTipoExercicioCadastrar.Click += new System.EventHandler(this.btnTipoExercicioCadastrar_Click);
            // 
            // lblTipoExercicioObs
            // 
            this.lblTipoExercicioObs.AutoSize = true;
            this.lblTipoExercicioObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoExercicioObs.ForeColor = System.Drawing.Color.Black;
            this.lblTipoExercicioObs.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTipoExercicioObs.Location = new System.Drawing.Point(213, 266);
            this.lblTipoExercicioObs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoExercicioObs.Name = "lblTipoExercicioObs";
            this.lblTipoExercicioObs.Size = new System.Drawing.Size(454, 25);
            this.lblTipoExercicioObs.TabIndex = 2;
            this.lblTipoExercicioObs.Text = "Obs: Os campos marcados com * são obrigatórios.";
            this.lblTipoExercicioObs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTipoExercicioCancelar
            // 
            this.btnTipoExercicioCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTipoExercicioCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoExercicioCancelar.Image = global::Apresentacao.Properties.Resources._1440735675_delete;
            this.btnTipoExercicioCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTipoExercicioCancelar.Location = new System.Drawing.Point(728, 62);
            this.btnTipoExercicioCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnTipoExercicioCancelar.Name = "btnTipoExercicioCancelar";
            this.btnTipoExercicioCancelar.Size = new System.Drawing.Size(168, 68);
            this.btnTipoExercicioCancelar.TabIndex = 4;
            this.btnTipoExercicioCancelar.Text = "Cancelar";
            this.btnTipoExercicioCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTipoExercicioCancelar.UseVisualStyleBackColor = false;
            this.btnTipoExercicioCancelar.Click += new System.EventHandler(this.btnTipoExercicioCancelar_Click);
            // 
            // grpTipoExercicio
            // 
            this.grpTipoExercicio.Controls.Add(this.txtCadastrarCodigo);
            this.grpTipoExercicio.Controls.Add(this.lblCadastrarCodigo);
            this.grpTipoExercicio.Controls.Add(this.grpBoxAtivo);
            this.grpTipoExercicio.Controls.Add(this.lblCadastrarDescricao);
            this.grpTipoExercicio.Controls.Add(this.txtCadastrarDescricao);
            this.grpTipoExercicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTipoExercicio.Location = new System.Drawing.Point(16, 137);
            this.grpTipoExercicio.Margin = new System.Windows.Forms.Padding(4);
            this.grpTipoExercicio.Name = "grpTipoExercicio";
            this.grpTipoExercicio.Padding = new System.Windows.Forms.Padding(4);
            this.grpTipoExercicio.Size = new System.Drawing.Size(880, 119);
            this.grpTipoExercicio.TabIndex = 1;
            this.grpTipoExercicio.TabStop = false;
            this.grpTipoExercicio.Text = "Tipo de exercício";
            // 
            // txtCadastrarCodigo
            // 
            this.txtCadastrarCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastrarCodigo.Location = new System.Drawing.Point(17, 55);
            this.txtCadastrarCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCadastrarCodigo.Name = "txtCadastrarCodigo";
            this.txtCadastrarCodigo.ReadOnly = true;
            this.txtCadastrarCodigo.Size = new System.Drawing.Size(72, 30);
            this.txtCadastrarCodigo.TabIndex = 4;
            this.txtCadastrarCodigo.TabStop = false;
            this.txtCadastrarCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCadastrarCodigo
            // 
            this.lblCadastrarCodigo.AutoSize = true;
            this.lblCadastrarCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarCodigo.ForeColor = System.Drawing.Color.Black;
            this.lblCadastrarCodigo.Location = new System.Drawing.Point(12, 27);
            this.lblCadastrarCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastrarCodigo.Name = "lblCadastrarCodigo";
            this.lblCadastrarCodigo.Size = new System.Drawing.Size(75, 25);
            this.lblCadastrarCodigo.TabIndex = 0;
            this.lblCadastrarCodigo.Text = "Código";
            // 
            // grpBoxAtivo
            // 
            this.grpBoxAtivo.Controls.Add(this.rbtnAlunoAtivoNao);
            this.grpBoxAtivo.Controls.Add(this.rbtnAlunoAtivoSim);
            this.grpBoxAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxAtivo.Location = new System.Drawing.Point(736, 27);
            this.grpBoxAtivo.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxAtivo.Name = "grpBoxAtivo";
            this.grpBoxAtivo.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxAtivo.Size = new System.Drawing.Size(136, 60);
            this.grpBoxAtivo.TabIndex = 3;
            this.grpBoxAtivo.TabStop = false;
            this.grpBoxAtivo.Text = "*Ativo";
            // 
            // rbtnAlunoAtivoNao
            // 
            this.rbtnAlunoAtivoNao.AutoSize = true;
            this.rbtnAlunoAtivoNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAlunoAtivoNao.Location = new System.Drawing.Point(72, 28);
            this.rbtnAlunoAtivoNao.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnAlunoAtivoNao.Name = "rbtnAlunoAtivoNao";
            this.rbtnAlunoAtivoNao.Size = new System.Drawing.Size(55, 21);
            this.rbtnAlunoAtivoNao.TabIndex = 1;
            this.rbtnAlunoAtivoNao.TabStop = true;
            this.rbtnAlunoAtivoNao.Text = "Não";
            this.rbtnAlunoAtivoNao.UseVisualStyleBackColor = true;
            // 
            // rbtnAlunoAtivoSim
            // 
            this.rbtnAlunoAtivoSim.AutoSize = true;
            this.rbtnAlunoAtivoSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAlunoAtivoSim.Location = new System.Drawing.Point(8, 28);
            this.rbtnAlunoAtivoSim.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnAlunoAtivoSim.Name = "rbtnAlunoAtivoSim";
            this.rbtnAlunoAtivoSim.Size = new System.Drawing.Size(52, 21);
            this.rbtnAlunoAtivoSim.TabIndex = 0;
            this.rbtnAlunoAtivoSim.TabStop = true;
            this.rbtnAlunoAtivoSim.Text = "Sim";
            this.rbtnAlunoAtivoSim.UseVisualStyleBackColor = true;
            // 
            // lblCadastrarDescricao
            // 
            this.lblCadastrarDescricao.AutoSize = true;
            this.lblCadastrarDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarDescricao.ForeColor = System.Drawing.Color.Black;
            this.lblCadastrarDescricao.Location = new System.Drawing.Point(96, 27);
            this.lblCadastrarDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastrarDescricao.Name = "lblCadastrarDescricao";
            this.lblCadastrarDescricao.Size = new System.Drawing.Size(112, 25);
            this.lblCadastrarDescricao.TabIndex = 2;
            this.lblCadastrarDescricao.Text = "* Descrição";
            // 
            // txtCadastrarDescricao
            // 
            this.txtCadastrarDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastrarDescricao.Location = new System.Drawing.Point(101, 55);
            this.txtCadastrarDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtCadastrarDescricao.Name = "txtCadastrarDescricao";
            this.txtCadastrarDescricao.Size = new System.Drawing.Size(625, 30);
            this.txtCadastrarDescricao.TabIndex = 0;
            // 
            // lblTipoExercicioCadastrarTitulo
            // 
            this.lblTipoExercicioCadastrarTitulo.AutoSize = true;
            this.lblTipoExercicioCadastrarTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoExercicioCadastrarTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTipoExercicioCadastrarTitulo.Location = new System.Drawing.Point(109, 10);
            this.lblTipoExercicioCadastrarTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoExercicioCadastrarTitulo.Name = "lblTipoExercicioCadastrarTitulo";
            this.lblTipoExercicioCadastrarTitulo.Size = new System.Drawing.Size(454, 38);
            this.lblTipoExercicioCadastrarTitulo.TabIndex = 0;
            this.lblTipoExercicioCadastrarTitulo.Text = "Cadastrar Tipo De Exercício";
            // 
            // pbxCadastrarTipoExercicio
            // 
            this.pbxCadastrarTipoExercicio.Image = global::Apresentacao.Properties.Resources._1440663403_add_property;
            this.pbxCadastrarTipoExercicio.Location = new System.Drawing.Point(16, 10);
            this.pbxCadastrarTipoExercicio.Margin = new System.Windows.Forms.Padding(4);
            this.pbxCadastrarTipoExercicio.Name = "pbxCadastrarTipoExercicio";
            this.pbxCadastrarTipoExercicio.Size = new System.Drawing.Size(91, 81);
            this.pbxCadastrarTipoExercicio.TabIndex = 100;
            this.pbxCadastrarTipoExercicio.TabStop = false;
            // 
            // listBoxSelecionar
            // 
            this.listBoxSelecionar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBoxSelecionar.Enabled = false;
            this.listBoxSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSelecionar.FormattingEnabled = true;
            this.listBoxSelecionar.ItemHeight = 18;
            this.listBoxSelecionar.Items.AddRange(new object[] {
            "F1: Salvar - F2: Cancelar"});
            this.listBoxSelecionar.Location = new System.Drawing.Point(723, 10);
            this.listBoxSelecionar.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxSelecionar.Name = "listBoxSelecionar";
            this.listBoxSelecionar.Size = new System.Drawing.Size(173, 22);
            this.listBoxSelecionar.TabIndex = 102;
            this.listBoxSelecionar.TabStop = false;
            this.listBoxSelecionar.SelectedIndexChanged += new System.EventHandler(this.listBoxSelecionar_SelectedIndexChanged);
            // 
            // FrmTipoExercicioCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(912, 309);
            this.ControlBox = false;
            this.Controls.Add(this.listBoxSelecionar);
            this.Controls.Add(this.pbxCadastrarTipoExercicio);
            this.Controls.Add(this.btnTipoExercicioCadastrar);
            this.Controls.Add(this.lblTipoExercicioObs);
            this.Controls.Add(this.btnTipoExercicioCancelar);
            this.Controls.Add(this.grpTipoExercicio);
            this.Controls.Add(this.lblTipoExercicioCadastrarTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTipoExercicioCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Tipo Exercício";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmTipoExercicioCadastrar_KeyUp);
            this.grpTipoExercicio.ResumeLayout(false);
            this.grpTipoExercicio.PerformLayout();
            this.grpBoxAtivo.ResumeLayout(false);
            this.grpBoxAtivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCadastrarTipoExercicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTipoExercicioCadastrar;
        private System.Windows.Forms.Label lblTipoExercicioObs;
        private System.Windows.Forms.Button btnTipoExercicioCancelar;
        private System.Windows.Forms.GroupBox grpTipoExercicio;
        private System.Windows.Forms.Label lblCadastrarDescricao;
        private System.Windows.Forms.TextBox txtCadastrarDescricao;
        private System.Windows.Forms.Label lblTipoExercicioCadastrarTitulo;
        private System.Windows.Forms.GroupBox grpBoxAtivo;
        private System.Windows.Forms.RadioButton rbtnAlunoAtivoNao;
        private System.Windows.Forms.RadioButton rbtnAlunoAtivoSim;
        private System.Windows.Forms.Label lblCadastrarCodigo;
        private System.Windows.Forms.TextBox txtCadastrarCodigo;
        private System.Windows.Forms.PictureBox pbxCadastrarTipoExercicio;
        private System.Windows.Forms.ListBox listBoxSelecionar;
    }
}