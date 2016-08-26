namespace Apresentacao.NoticiaInterfaces
{
    partial class FrmNoticiaCadastrar
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
            this.grpNoticia = new System.Windows.Forms.GroupBox();
            this.grpBoxAtivo = new System.Windows.Forms.GroupBox();
            this.rbtCadastrarAtivoNao = new System.Windows.Forms.RadioButton();
            this.rbtCadastrarAtivoSim = new System.Windows.Forms.RadioButton();
            this.txtCadastrarCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.rckCadastrarDescricao = new System.Windows.Forms.RichTextBox();
            this.lblCadastrarNome = new System.Windows.Forms.Label();
            this.txtCadastrarTitulo = new System.Windows.Forms.TextBox();
            this.lblCadastrarDescricao = new System.Windows.Forms.Label();
            this.lblExercicioObs = new System.Windows.Forms.Label();
            this.btnNoticiaCancelar = new System.Windows.Forms.Button();
            this.lblNoticiaCadastrarTitulo = new System.Windows.Forms.Label();
            this.btnNoticiaCadastrar = new System.Windows.Forms.Button();
            this.pbxCadastrarNoticia = new System.Windows.Forms.PictureBox();
            this.listBoxSelecionar = new System.Windows.Forms.ListBox();
            this.grpNoticia.SuspendLayout();
            this.grpBoxAtivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCadastrarNoticia)).BeginInit();
            this.SuspendLayout();
            // 
            // grpNoticia
            // 
            this.grpNoticia.Controls.Add(this.grpBoxAtivo);
            this.grpNoticia.Controls.Add(this.txtCadastrarCodigo);
            this.grpNoticia.Controls.Add(this.lblCodigo);
            this.grpNoticia.Controls.Add(this.rckCadastrarDescricao);
            this.grpNoticia.Controls.Add(this.lblCadastrarNome);
            this.grpNoticia.Controls.Add(this.txtCadastrarTitulo);
            this.grpNoticia.Controls.Add(this.lblCadastrarDescricao);
            this.grpNoticia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNoticia.Location = new System.Drawing.Point(8, 117);
            this.grpNoticia.Margin = new System.Windows.Forms.Padding(4);
            this.grpNoticia.Name = "grpNoticia";
            this.grpNoticia.Padding = new System.Windows.Forms.Padding(4);
            this.grpNoticia.Size = new System.Drawing.Size(1296, 513);
            this.grpNoticia.TabIndex = 1;
            this.grpNoticia.TabStop = false;
            this.grpNoticia.Text = "Notícia";
            // 
            // grpBoxAtivo
            // 
            this.grpBoxAtivo.Controls.Add(this.rbtCadastrarAtivoNao);
            this.grpBoxAtivo.Controls.Add(this.rbtCadastrarAtivoSim);
            this.grpBoxAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxAtivo.Location = new System.Drawing.Point(1152, 39);
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
            this.txtCadastrarCodigo.Location = new System.Drawing.Point(8, 68);
            this.txtCadastrarCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCadastrarCodigo.Name = "txtCadastrarCodigo";
            this.txtCadastrarCodigo.ReadOnly = true;
            this.txtCadastrarCodigo.Size = new System.Drawing.Size(85, 30);
            this.txtCadastrarCodigo.TabIndex = 1;
            this.txtCadastrarCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Black;
            this.lblCodigo.Location = new System.Drawing.Point(3, 39);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(75, 25);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // rckCadastrarDescricao
            // 
            this.rckCadastrarDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rckCadastrarDescricao.Location = new System.Drawing.Point(8, 132);
            this.rckCadastrarDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.rckCadastrarDescricao.Name = "rckCadastrarDescricao";
            this.rckCadastrarDescricao.Size = new System.Drawing.Size(1279, 373);
            this.rckCadastrarDescricao.TabIndex = 6;
            this.rckCadastrarDescricao.Text = "";
            // 
            // lblCadastrarNome
            // 
            this.lblCadastrarNome.AutoSize = true;
            this.lblCadastrarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarNome.ForeColor = System.Drawing.Color.Black;
            this.lblCadastrarNome.Location = new System.Drawing.Point(97, 39);
            this.lblCadastrarNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastrarNome.Name = "lblCadastrarNome";
            this.lblCadastrarNome.Size = new System.Drawing.Size(73, 25);
            this.lblCadastrarNome.TabIndex = 2;
            this.lblCadastrarNome.Text = "* Título";
            // 
            // txtCadastrarTitulo
            // 
            this.txtCadastrarTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastrarTitulo.Location = new System.Drawing.Point(103, 68);
            this.txtCadastrarTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCadastrarTitulo.Name = "txtCadastrarTitulo";
            this.txtCadastrarTitulo.Size = new System.Drawing.Size(1040, 30);
            this.txtCadastrarTitulo.TabIndex = 3;
            // 
            // lblCadastrarDescricao
            // 
            this.lblCadastrarDescricao.AutoSize = true;
            this.lblCadastrarDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarDescricao.ForeColor = System.Drawing.Color.Black;
            this.lblCadastrarDescricao.Location = new System.Drawing.Point(3, 103);
            this.lblCadastrarDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastrarDescricao.Name = "lblCadastrarDescricao";
            this.lblCadastrarDescricao.Size = new System.Drawing.Size(112, 25);
            this.lblCadastrarDescricao.TabIndex = 5;
            this.lblCadastrarDescricao.Text = "* Descrição";
            // 
            // lblExercicioObs
            // 
            this.lblExercicioObs.AutoSize = true;
            this.lblExercicioObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExercicioObs.ForeColor = System.Drawing.Color.Black;
            this.lblExercicioObs.Location = new System.Drawing.Point(413, 636);
            this.lblExercicioObs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExercicioObs.Name = "lblExercicioObs";
            this.lblExercicioObs.Size = new System.Drawing.Size(454, 25);
            this.lblExercicioObs.TabIndex = 2;
            this.lblExercicioObs.Text = "Obs: Os campos marcados com * são obrigatórios.";
            // 
            // btnNoticiaCancelar
            // 
            this.btnNoticiaCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNoticiaCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoticiaCancelar.Image = global::Apresentacao.Properties.Resources._1440736764_delete;
            this.btnNoticiaCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNoticiaCancelar.Location = new System.Drawing.Point(1136, 42);
            this.btnNoticiaCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnNoticiaCancelar.Name = "btnNoticiaCancelar";
            this.btnNoticiaCancelar.Size = new System.Drawing.Size(168, 68);
            this.btnNoticiaCancelar.TabIndex = 4;
            this.btnNoticiaCancelar.Text = "Cancelar";
            this.btnNoticiaCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNoticiaCancelar.UseVisualStyleBackColor = false;
            this.btnNoticiaCancelar.Click += new System.EventHandler(this.btnNoticiaCancelar_Click);
            // 
            // lblNoticiaCadastrarTitulo
            // 
            this.lblNoticiaCadastrarTitulo.AutoSize = true;
            this.lblNoticiaCadastrarTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoticiaCadastrarTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblNoticiaCadastrarTitulo.Location = new System.Drawing.Point(107, 15);
            this.lblNoticiaCadastrarTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoticiaCadastrarTitulo.Name = "lblNoticiaCadastrarTitulo";
            this.lblNoticiaCadastrarTitulo.Size = new System.Drawing.Size(287, 38);
            this.lblNoticiaCadastrarTitulo.TabIndex = 0;
            this.lblNoticiaCadastrarTitulo.Text = "Cadastrar Notícia";
            // 
            // btnNoticiaCadastrar
            // 
            this.btnNoticiaCadastrar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNoticiaCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoticiaCadastrar.Image = global::Apresentacao.Properties.Resources._1440735931_save1;
            this.btnNoticiaCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNoticiaCadastrar.Location = new System.Drawing.Point(960, 42);
            this.btnNoticiaCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnNoticiaCadastrar.Name = "btnNoticiaCadastrar";
            this.btnNoticiaCadastrar.Size = new System.Drawing.Size(168, 68);
            this.btnNoticiaCadastrar.TabIndex = 3;
            this.btnNoticiaCadastrar.Text = "Salvar";
            this.btnNoticiaCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNoticiaCadastrar.UseVisualStyleBackColor = false;
            this.btnNoticiaCadastrar.Click += new System.EventHandler(this.btnNoticiaCadastrar_Click);
            // 
            // pbxCadastrarNoticia
            // 
            this.pbxCadastrarNoticia.Image = global::Apresentacao.Properties.Resources._1440663403_add_property;
            this.pbxCadastrarNoticia.Location = new System.Drawing.Point(8, 15);
            this.pbxCadastrarNoticia.Margin = new System.Windows.Forms.Padding(4);
            this.pbxCadastrarNoticia.Name = "pbxCadastrarNoticia";
            this.pbxCadastrarNoticia.Size = new System.Drawing.Size(91, 81);
            this.pbxCadastrarNoticia.TabIndex = 93;
            this.pbxCadastrarNoticia.TabStop = false;
            // 
            // listBoxSelecionar
            // 
            this.listBoxSelecionar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBoxSelecionar.Enabled = false;
            this.listBoxSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSelecionar.FormattingEnabled = true;
            this.listBoxSelecionar.ItemHeight = 25;
            this.listBoxSelecionar.Items.AddRange(new object[] {
            "F1: Salvar - F2: Cancelar"});
            this.listBoxSelecionar.Location = new System.Drawing.Point(16, 638);
            this.listBoxSelecionar.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxSelecionar.Name = "listBoxSelecionar";
            this.listBoxSelecionar.Size = new System.Drawing.Size(276, 29);
            this.listBoxSelecionar.TabIndex = 103;
            this.listBoxSelecionar.TabStop = false;
            // 
            // FrmNoticiaCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1313, 673);
            this.ControlBox = false;
            this.Controls.Add(this.listBoxSelecionar);
            this.Controls.Add(this.pbxCadastrarNoticia);
            this.Controls.Add(this.grpNoticia);
            this.Controls.Add(this.lblExercicioObs);
            this.Controls.Add(this.btnNoticiaCancelar);
            this.Controls.Add(this.lblNoticiaCadastrarTitulo);
            this.Controls.Add(this.btnNoticiaCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNoticiaCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Notícia";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmNoticiaCadastrar_KeyUp);
            this.grpNoticia.ResumeLayout(false);
            this.grpNoticia.PerformLayout();
            this.grpBoxAtivo.ResumeLayout(false);
            this.grpBoxAtivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCadastrarNoticia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxCadastrarNoticia;
        private System.Windows.Forms.GroupBox grpNoticia;
        private System.Windows.Forms.TextBox txtCadastrarCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.RichTextBox rckCadastrarDescricao;
        private System.Windows.Forms.Label lblCadastrarNome;
        private System.Windows.Forms.TextBox txtCadastrarTitulo;
        private System.Windows.Forms.Label lblCadastrarDescricao;
        private System.Windows.Forms.Label lblExercicioObs;
        private System.Windows.Forms.Button btnNoticiaCancelar;
        private System.Windows.Forms.Label lblNoticiaCadastrarTitulo;
        private System.Windows.Forms.Button btnNoticiaCadastrar;
        private System.Windows.Forms.GroupBox grpBoxAtivo;
        private System.Windows.Forms.RadioButton rbtCadastrarAtivoNao;
        private System.Windows.Forms.RadioButton rbtCadastrarAtivoSim;
        private System.Windows.Forms.ListBox listBoxSelecionar;
    }
}