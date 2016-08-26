namespace Apresentacao.MedidaCorporalInterfaces.Relatório
{
    partial class FrmFiltroRelatorioAvaliacaoFisica
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
            this.listBoxSelecionarAluno = new System.Windows.Forms.ListBox();
            this.grpFiltroAvalicaoFisica = new System.Windows.Forms.GroupBox();
            this.txtSelecionarFiltroAlunoCodigo = new System.Windows.Forms.TextBox();
            this.cbxDataFinal = new System.Windows.Forms.ComboBox();
            this.lblAlunoObs = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSelecionarAlunoNome = new System.Windows.Forms.Label();
            this.txtSelecionarFiltroAlunoNome = new System.Windows.Forms.TextBox();
            this.cbxDataInicio = new System.Windows.Forms.ComboBox();
            this.lblTituloRelatorio = new System.Windows.Forms.Label();
            this.btnSelecionarAluno = new System.Windows.Forms.Button();
            this.btnRelatorioCancelar = new System.Windows.Forms.Button();
            this.pbcSelecionar = new System.Windows.Forms.PictureBox();
            this.btnRelatorioGerar = new System.Windows.Forms.Button();
            this.grpFiltroAvalicaoFisica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcSelecionar)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxSelecionarAluno
            // 
            this.listBoxSelecionarAluno.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBoxSelecionarAluno.Enabled = false;
            this.listBoxSelecionarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSelecionarAluno.FormattingEnabled = true;
            this.listBoxSelecionarAluno.ItemHeight = 20;
            this.listBoxSelecionarAluno.Items.AddRange(new object[] {
            "F1: Gerar - F2: Cancelar"});
            this.listBoxSelecionarAluno.Location = new System.Drawing.Point(6, 235);
            this.listBoxSelecionarAluno.Name = "listBoxSelecionarAluno";
            this.listBoxSelecionarAluno.Size = new System.Drawing.Size(178, 24);
            this.listBoxSelecionarAluno.TabIndex = 24;
            this.listBoxSelecionarAluno.TabStop = false;
            // 
            // grpFiltroAvalicaoFisica
            // 
            this.grpFiltroAvalicaoFisica.Controls.Add(this.lblTituloRelatorio);
            this.grpFiltroAvalicaoFisica.Controls.Add(this.txtSelecionarFiltroAlunoCodigo);
            this.grpFiltroAvalicaoFisica.Controls.Add(this.cbxDataFinal);
            this.grpFiltroAvalicaoFisica.Controls.Add(this.btnSelecionarAluno);
            this.grpFiltroAvalicaoFisica.Controls.Add(this.lblAlunoObs);
            this.grpFiltroAvalicaoFisica.Controls.Add(this.label3);
            this.grpFiltroAvalicaoFisica.Controls.Add(this.btnRelatorioCancelar);
            this.grpFiltroAvalicaoFisica.Controls.Add(this.label2);
            this.grpFiltroAvalicaoFisica.Controls.Add(this.label1);
            this.grpFiltroAvalicaoFisica.Controls.Add(this.pbcSelecionar);
            this.grpFiltroAvalicaoFisica.Controls.Add(this.lblSelecionarAlunoNome);
            this.grpFiltroAvalicaoFisica.Controls.Add(this.btnRelatorioGerar);
            this.grpFiltroAvalicaoFisica.Controls.Add(this.txtSelecionarFiltroAlunoNome);
            this.grpFiltroAvalicaoFisica.Controls.Add(this.cbxDataInicio);
            this.grpFiltroAvalicaoFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFiltroAvalicaoFisica.Location = new System.Drawing.Point(6, 10);
            this.grpFiltroAvalicaoFisica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpFiltroAvalicaoFisica.Name = "grpFiltroAvalicaoFisica";
            this.grpFiltroAvalicaoFisica.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpFiltroAvalicaoFisica.Size = new System.Drawing.Size(772, 219);
            this.grpFiltroAvalicaoFisica.TabIndex = 33;
            this.grpFiltroAvalicaoFisica.TabStop = false;
            this.grpFiltroAvalicaoFisica.Text = "Filtros";
            // 
            // txtSelecionarFiltroAlunoCodigo
            // 
            this.txtSelecionarFiltroAlunoCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelecionarFiltroAlunoCodigo.Location = new System.Drawing.Point(5, 124);
            this.txtSelecionarFiltroAlunoCodigo.Name = "txtSelecionarFiltroAlunoCodigo";
            this.txtSelecionarFiltroAlunoCodigo.ReadOnly = true;
            this.txtSelecionarFiltroAlunoCodigo.Size = new System.Drawing.Size(51, 26);
            this.txtSelecionarFiltroAlunoCodigo.TabIndex = 47;
            // 
            // cbxDataFinal
            // 
            this.cbxDataFinal.Enabled = false;
            this.cbxDataFinal.FormattingEnabled = true;
            this.cbxDataFinal.Location = new System.Drawing.Point(664, 124);
            this.cbxDataFinal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxDataFinal.Name = "cbxDataFinal";
            this.cbxDataFinal.Size = new System.Drawing.Size(103, 28);
            this.cbxDataFinal.TabIndex = 46;
            // 
            // lblAlunoObs
            // 
            this.lblAlunoObs.AutoSize = true;
            this.lblAlunoObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlunoObs.ForeColor = System.Drawing.Color.Black;
            this.lblAlunoObs.Location = new System.Drawing.Point(217, 181);
            this.lblAlunoObs.Name = "lblAlunoObs";
            this.lblAlunoObs.Size = new System.Drawing.Size(365, 20);
            this.lblAlunoObs.TabIndex = 34;
            this.lblAlunoObs.Text = "Obs: Os campos marcados com * são obrigatórios.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(660, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "*Data final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(554, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "*Data inicio";
            // 
            // lblSelecionarAlunoNome
            // 
            this.lblSelecionarAlunoNome.AutoSize = true;
            this.lblSelecionarAlunoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecionarAlunoNome.ForeColor = System.Drawing.Color.Black;
            this.lblSelecionarAlunoNome.Location = new System.Drawing.Point(5, 102);
            this.lblSelecionarAlunoNome.Name = "lblSelecionarAlunoNome";
            this.lblSelecionarAlunoNome.Size = new System.Drawing.Size(60, 20);
            this.lblSelecionarAlunoNome.TabIndex = 34;
            this.lblSelecionarAlunoNome.Text = "*Aluno:";
            // 
            // txtSelecionarFiltroAlunoNome
            // 
            this.txtSelecionarFiltroAlunoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelecionarFiltroAlunoNome.Location = new System.Drawing.Point(60, 124);
            this.txtSelecionarFiltroAlunoNome.Name = "txtSelecionarFiltroAlunoNome";
            this.txtSelecionarFiltroAlunoNome.Size = new System.Drawing.Size(450, 26);
            this.txtSelecionarFiltroAlunoNome.TabIndex = 35;
            // 
            // cbxDataInicio
            // 
            this.cbxDataInicio.Enabled = false;
            this.cbxDataInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDataInicio.FormattingEnabled = true;
            this.cbxDataInicio.Location = new System.Drawing.Point(557, 124);
            this.cbxDataInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxDataInicio.Name = "cbxDataInicio";
            this.cbxDataInicio.Size = new System.Drawing.Size(103, 28);
            this.cbxDataInicio.TabIndex = 33;
            // 
            // lblTituloRelatorio
            // 
            this.lblTituloRelatorio.AutoSize = true;
            this.lblTituloRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloRelatorio.Location = new System.Drawing.Point(85, 24);
            this.lblTituloRelatorio.Name = "lblTituloRelatorio";
            this.lblTituloRelatorio.Size = new System.Drawing.Size(257, 31);
            this.lblTituloRelatorio.TabIndex = 48;
            this.lblTituloRelatorio.Text = "Avaliações Físicas";
            // 
            // btnSelecionarAluno
            // 
            this.btnSelecionarAluno.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelecionarAluno.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelecionarAluno.FlatAppearance.BorderSize = 0;
            this.btnSelecionarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarAluno.Image = global::Apresentacao.Properties.Resources._1440734281_checked_checkbox;
            this.btnSelecionarAluno.Location = new System.Drawing.Point(516, 122);
            this.btnSelecionarAluno.Name = "btnSelecionarAluno";
            this.btnSelecionarAluno.Size = new System.Drawing.Size(30, 29);
            this.btnSelecionarAluno.TabIndex = 45;
            this.btnSelecionarAluno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelecionarAluno.UseVisualStyleBackColor = false;
            this.btnSelecionarAluno.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRelatorioCancelar
            // 
            this.btnRelatorioCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRelatorioCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorioCancelar.Image = global::Apresentacao.Properties.Resources._1440735668_delete;
            this.btnRelatorioCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRelatorioCancelar.Location = new System.Drawing.Point(657, 18);
            this.btnRelatorioCancelar.Name = "btnRelatorioCancelar";
            this.btnRelatorioCancelar.Size = new System.Drawing.Size(109, 72);
            this.btnRelatorioCancelar.TabIndex = 43;
            this.btnRelatorioCancelar.Text = "Cancelar";
            this.btnRelatorioCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorioCancelar.UseVisualStyleBackColor = false;
            this.btnRelatorioCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pbcSelecionar
            // 
            this.pbcSelecionar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbcSelecionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbcSelecionar.Image = global::Apresentacao.Properties.Resources._1440734911_cllipboard;
            this.pbcSelecionar.Location = new System.Drawing.Point(9, 24);
            this.pbcSelecionar.Name = "pbcSelecionar";
            this.pbcSelecionar.Size = new System.Drawing.Size(70, 67);
            this.pbcSelecionar.TabIndex = 39;
            this.pbcSelecionar.TabStop = false;
            // 
            // btnRelatorioGerar
            // 
            this.btnRelatorioGerar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRelatorioGerar.Enabled = false;
            this.btnRelatorioGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorioGerar.Image = global::Apresentacao.Properties.Resources._1440663409_add_property;
            this.btnRelatorioGerar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRelatorioGerar.Location = new System.Drawing.Point(542, 18);
            this.btnRelatorioGerar.Name = "btnRelatorioGerar";
            this.btnRelatorioGerar.Size = new System.Drawing.Size(109, 72);
            this.btnRelatorioGerar.TabIndex = 38;
            this.btnRelatorioGerar.Text = "Gerar";
            this.btnRelatorioGerar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorioGerar.UseVisualStyleBackColor = false;
            this.btnRelatorioGerar.Click += new System.EventHandler(this.btnSelecionarAlunoInserir_Click);
            // 
            // FrmFiltroRelatorioAvaliacaoFisica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(788, 267);
            this.ControlBox = false;
            this.Controls.Add(this.grpFiltroAvalicaoFisica);
            this.Controls.Add(this.listBoxSelecionarAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFiltroRelatorioAvaliacaoFisica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtros Relatório Avaliação Física";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmFiltroRelatorioAvaliacaoFisica_KeyDown);
            this.grpFiltroAvalicaoFisica.ResumeLayout(false);
            this.grpFiltroAvalicaoFisica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcSelecionar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSelecionarAluno;
        private System.Windows.Forms.GroupBox grpFiltroAvalicaoFisica;
        private System.Windows.Forms.Button btnRelatorioCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbcSelecionar;
        private System.Windows.Forms.Label lblSelecionarAlunoNome;
        private System.Windows.Forms.Button btnRelatorioGerar;
        private System.Windows.Forms.TextBox txtSelecionarFiltroAlunoNome;
        private System.Windows.Forms.ComboBox cbxDataInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAlunoObs;
        private System.Windows.Forms.Button btnSelecionarAluno;
        private System.Windows.Forms.ComboBox cbxDataFinal;
        private System.Windows.Forms.TextBox txtSelecionarFiltroAlunoCodigo;
        private System.Windows.Forms.Label lblTituloRelatorio;

    }
}