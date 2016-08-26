namespace Apresentacao.TreinamentoInterfaces
{
    partial class FrmTreinamentoAlterar
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblAlunoObs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTreinamentoAlterar = new System.Windows.Forms.GroupBox();
            this.mskCadastrarIntervalo = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxCadastrarExercicio = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCadastrarSeries = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCadastrarRepeticoes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoTreinamento = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblCadastrarTipoMedida = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBoxSelecionar = new System.Windows.Forms.ListBox();
            this.grpTreinamentoAlterar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(333, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(454, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Obs: Os campos marcados com * são obrigatórios.";
            // 
            // lblAlunoObs
            // 
            this.lblAlunoObs.AutoSize = true;
            this.lblAlunoObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlunoObs.ForeColor = System.Drawing.Color.Black;
            this.lblAlunoObs.Location = new System.Drawing.Point(360, 198);
            this.lblAlunoObs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlunoObs.Name = "lblAlunoObs";
            this.lblAlunoObs.Size = new System.Drawing.Size(0, 25);
            this.lblAlunoObs.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alterar Treinamento Físico";
            // 
            // grpTreinamentoAlterar
            // 
            this.grpTreinamentoAlterar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpTreinamentoAlterar.Controls.Add(this.mskCadastrarIntervalo);
            this.grpTreinamentoAlterar.Controls.Add(this.label5);
            this.grpTreinamentoAlterar.Controls.Add(this.cbxCadastrarExercicio);
            this.grpTreinamentoAlterar.Controls.Add(this.label4);
            this.grpTreinamentoAlterar.Controls.Add(this.txtCadastrarSeries);
            this.grpTreinamentoAlterar.Controls.Add(this.label10);
            this.grpTreinamentoAlterar.Controls.Add(this.txtCadastrarRepeticoes);
            this.grpTreinamentoAlterar.Controls.Add(this.label2);
            this.grpTreinamentoAlterar.Controls.Add(this.txtCodigoTreinamento);
            this.grpTreinamentoAlterar.Controls.Add(this.btnSalvar);
            this.grpTreinamentoAlterar.Controls.Add(this.lblCadastrarTipoMedida);
            this.grpTreinamentoAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTreinamentoAlterar.Location = new System.Drawing.Point(12, 74);
            this.grpTreinamentoAlterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTreinamentoAlterar.Name = "grpTreinamentoAlterar";
            this.grpTreinamentoAlterar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTreinamentoAlterar.Size = new System.Drawing.Size(1189, 134);
            this.grpTreinamentoAlterar.TabIndex = 1;
            this.grpTreinamentoAlterar.TabStop = false;
            // 
            // mskCadastrarIntervalo
            // 
            this.mskCadastrarIntervalo.Location = new System.Drawing.Point(901, 58);
            this.mskCadastrarIntervalo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskCadastrarIntervalo.Mask = "00:00:00";
            this.mskCadastrarIntervalo.Name = "mskCadastrarIntervalo";
            this.mskCadastrarIntervalo.Size = new System.Drawing.Size(151, 30);
            this.mskCadastrarIntervalo.TabIndex = 11;
            this.mskCadastrarIntervalo.Text = "000000";
            this.mskCadastrarIntervalo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(896, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "*Intervalo";
            // 
            // cbxCadastrarExercicio
            // 
            this.cbxCadastrarExercicio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxCadastrarExercicio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCadastrarExercicio.Enabled = false;
            this.cbxCadastrarExercicio.FormattingEnabled = true;
            this.cbxCadastrarExercicio.Location = new System.Drawing.Point(99, 58);
            this.cbxCadastrarExercicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxCadastrarExercicio.Name = "cbxCadastrarExercicio";
            this.cbxCadastrarExercicio.Size = new System.Drawing.Size(497, 33);
            this.cbxCadastrarExercicio.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(747, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "*Repetições";
            // 
            // txtCadastrarSeries
            // 
            this.txtCadastrarSeries.Location = new System.Drawing.Point(603, 58);
            this.txtCadastrarSeries.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCadastrarSeries.MaxLength = 2;
            this.txtCadastrarSeries.Name = "txtCadastrarSeries";
            this.txtCadastrarSeries.Size = new System.Drawing.Size(139, 30);
            this.txtCadastrarSeries.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(600, 33);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 25);
            this.label10.TabIndex = 4;
            this.label10.Text = "*Series";
            // 
            // txtCadastrarRepeticoes
            // 
            this.txtCadastrarRepeticoes.Location = new System.Drawing.Point(749, 58);
            this.txtCadastrarRepeticoes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCadastrarRepeticoes.MaxLength = 3;
            this.txtCadastrarRepeticoes.Name = "txtCadastrarRepeticoes";
            this.txtCadastrarRepeticoes.Size = new System.Drawing.Size(144, 30);
            this.txtCadastrarRepeticoes.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código";
            // 
            // txtCodigoTreinamento
            // 
            this.txtCodigoTreinamento.Location = new System.Drawing.Point(7, 60);
            this.txtCodigoTreinamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoTreinamento.Name = "txtCodigoTreinamento";
            this.txtCodigoTreinamento.ReadOnly = true;
            this.txtCodigoTreinamento.Size = new System.Drawing.Size(77, 30);
            this.txtCodigoTreinamento.TabIndex = 1;
            this.txtCodigoTreinamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = global::Apresentacao.Properties.Resources._1440735927_save1;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.Location = new System.Drawing.Point(1059, 50);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(124, 44);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblCadastrarTipoMedida
            // 
            this.lblCadastrarTipoMedida.AutoSize = true;
            this.lblCadastrarTipoMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarTipoMedida.ForeColor = System.Drawing.Color.Black;
            this.lblCadastrarTipoMedida.Location = new System.Drawing.Point(93, 32);
            this.lblCadastrarTipoMedida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastrarTipoMedida.Name = "lblCadastrarTipoMedida";
            this.lblCadastrarTipoMedida.Size = new System.Drawing.Size(91, 25);
            this.lblCadastrarTipoMedida.TabIndex = 2;
            this.lblCadastrarTipoMedida.Text = "Exercício";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Apresentacao.Properties.Resources.weightlifting_icon__2_2;
            this.pictureBox1.Location = new System.Drawing.Point(11, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 65);
            this.pictureBox1.TabIndex = 106;
            this.pictureBox1.TabStop = false;
            // 
            // listBoxSelecionar
            // 
            this.listBoxSelecionar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBoxSelecionar.Enabled = false;
            this.listBoxSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSelecionar.FormattingEnabled = true;
            this.listBoxSelecionar.ItemHeight = 25;
            this.listBoxSelecionar.Items.AddRange(new object[] {
            "F1: Salvar"});
            this.listBoxSelecionar.Location = new System.Drawing.Point(12, 214);
            this.listBoxSelecionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxSelecionar.Name = "listBoxSelecionar";
            this.listBoxSelecionar.Size = new System.Drawing.Size(105, 29);
            this.listBoxSelecionar.TabIndex = 107;
            this.listBoxSelecionar.TabStop = false;
            // 
            // FrmTreinamentoAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1211, 254);
            this.Controls.Add(this.listBoxSelecionar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAlunoObs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpTreinamentoAlterar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTreinamentoAlterar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Treinamento Físico";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTreinamentoAlterar_KeyDown);
            this.grpTreinamentoAlterar.ResumeLayout(false);
            this.grpTreinamentoAlterar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAlunoObs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpTreinamentoAlterar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoTreinamento;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblCadastrarTipoMedida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCadastrarSeries;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCadastrarRepeticoes;
        private System.Windows.Forms.ComboBox cbxCadastrarExercicio;
        private System.Windows.Forms.ListBox listBoxSelecionar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskCadastrarIntervalo;
    }
}