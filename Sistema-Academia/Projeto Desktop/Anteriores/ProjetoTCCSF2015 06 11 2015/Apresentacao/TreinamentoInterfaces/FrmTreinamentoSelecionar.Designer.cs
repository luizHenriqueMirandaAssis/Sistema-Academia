namespace Apresentacao.TreinamentoInterfaces
{
    partial class FrmTreinamentoSelecionar
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listBoxSelecionar = new System.Windows.Forms.ListBox();
            this.lblSelecionarCodNome = new System.Windows.Forms.Label();
            this.btnSelecionarInserir = new System.Windows.Forms.Button();
            this.btnSelecionarAlterar = new System.Windows.Forms.Button();
            this.btnSelecionarCancelar = new System.Windows.Forms.Button();
            this.dgwSelecionarTreinamentoFísico = new System.Windows.Forms.DataGridView();
            this.colIDPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeExercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAtivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSelecionarTitulo = new System.Windows.Forms.Label();
            this.txtSelecionarCodAluno = new System.Windows.Forms.TextBox();
            this.ttpSelecionarPesquisar = new System.Windows.Forms.ToolTip(this.components);
            this.pbxSelecionarTreinamentoFisico = new System.Windows.Forms.PictureBox();
            this.btnSelecionarPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSelecionarTreinamentoFísico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSelecionarTreinamentoFisico)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxSelecionar
            // 
            this.listBoxSelecionar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBoxSelecionar.Enabled = false;
            this.listBoxSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSelecionar.FormattingEnabled = true;
            this.listBoxSelecionar.ItemHeight = 25;
            this.listBoxSelecionar.Items.AddRange(new object[] {
            "F1: Pesquisar - F2: Inserir - F3: Alterar"});
            this.listBoxSelecionar.Location = new System.Drawing.Point(8, 620);
            this.listBoxSelecionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxSelecionar.Name = "listBoxSelecionar";
            this.listBoxSelecionar.Size = new System.Drawing.Size(368, 29);
            this.listBoxSelecionar.TabIndex = 5;
            this.listBoxSelecionar.TabStop = false;
            // 
            // lblSelecionarCodNome
            // 
            this.lblSelecionarCodNome.AutoSize = true;
            this.lblSelecionarCodNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecionarCodNome.ForeColor = System.Drawing.Color.Black;
            this.lblSelecionarCodNome.Location = new System.Drawing.Point(13, 111);
            this.lblSelecionarCodNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelecionarCodNome.Name = "lblSelecionarCodNome";
            this.lblSelecionarCodNome.Size = new System.Drawing.Size(138, 25);
            this.lblSelecionarCodNome.TabIndex = 1;
            this.lblSelecionarCodNome.Text = "Código/Aluno:";
            // 
            // btnSelecionarInserir
            // 
            this.btnSelecionarInserir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelecionarInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarInserir.Location = new System.Drawing.Point(711, 608);
            this.btnSelecionarInserir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelecionarInserir.Name = "btnSelecionarInserir";
            this.btnSelecionarInserir.Size = new System.Drawing.Size(113, 41);
            this.btnSelecionarInserir.TabIndex = 6;
            this.btnSelecionarInserir.Text = "Inserir";
            this.btnSelecionarInserir.UseVisualStyleBackColor = false;
            this.btnSelecionarInserir.Click += new System.EventHandler(this.btnSelecionarInserir_Click);
            // 
            // btnSelecionarAlterar
            // 
            this.btnSelecionarAlterar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelecionarAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarAlterar.Location = new System.Drawing.Point(832, 608);
            this.btnSelecionarAlterar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelecionarAlterar.Name = "btnSelecionarAlterar";
            this.btnSelecionarAlterar.Size = new System.Drawing.Size(113, 41);
            this.btnSelecionarAlterar.TabIndex = 7;
            this.btnSelecionarAlterar.Text = "Alterar";
            this.btnSelecionarAlterar.UseVisualStyleBackColor = false;
            this.btnSelecionarAlterar.Click += new System.EventHandler(this.btnSelecionarAlterar_Click);
            // 
            // btnSelecionarCancelar
            // 
            this.btnSelecionarCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelecionarCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarCancelar.Location = new System.Drawing.Point(953, 608);
            this.btnSelecionarCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelecionarCancelar.Name = "btnSelecionarCancelar";
            this.btnSelecionarCancelar.Size = new System.Drawing.Size(113, 41);
            this.btnSelecionarCancelar.TabIndex = 8;
            this.btnSelecionarCancelar.Text = "Cancelar";
            this.btnSelecionarCancelar.UseVisualStyleBackColor = false;
            this.btnSelecionarCancelar.Click += new System.EventHandler(this.btnSelecionarCancelar_Click);
            // 
            // dgwSelecionarTreinamentoFísico
            // 
            this.dgwSelecionarTreinamentoFísico.AllowUserToAddRows = false;
            this.dgwSelecionarTreinamentoFísico.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgwSelecionarTreinamentoFísico.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwSelecionarTreinamentoFísico.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwSelecionarTreinamentoFísico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwSelecionarTreinamentoFísico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwSelecionarTreinamentoFísico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSelecionarTreinamentoFísico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDPessoa,
            this.colNomeExercicio,
            this.ColAtivo,
            this.Ativo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwSelecionarTreinamentoFísico.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgwSelecionarTreinamentoFísico.Location = new System.Drawing.Point(8, 155);
            this.dgwSelecionarTreinamentoFísico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgwSelecionarTreinamentoFísico.MultiSelect = false;
            this.dgwSelecionarTreinamentoFísico.Name = "dgwSelecionarTreinamentoFísico";
            this.dgwSelecionarTreinamentoFísico.ReadOnly = true;
            this.dgwSelecionarTreinamentoFísico.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwSelecionarTreinamentoFísico.RowHeadersVisible = false;
            this.dgwSelecionarTreinamentoFísico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwSelecionarTreinamentoFísico.Size = new System.Drawing.Size(1059, 446);
            this.dgwSelecionarTreinamentoFísico.TabIndex = 4;
            this.dgwSelecionarTreinamentoFísico.TabStop = false;
            this.dgwSelecionarTreinamentoFísico.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgwSelecionarTreinamentoFísico_CellFormatting);
            this.dgwSelecionarTreinamentoFísico.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwSelecionarTreinamentoFísico_CellMouseDoubleClick);
            // 
            // colIDPessoa
            // 
            this.colIDPessoa.DataPropertyName = "Aluno";
            this.colIDPessoa.HeaderText = "Código";
            this.colIDPessoa.Name = "colIDPessoa";
            this.colIDPessoa.ReadOnly = true;
            this.colIDPessoa.Width = 60;
            // 
            // colNomeExercicio
            // 
            this.colNomeExercicio.DataPropertyName = "Aluno";
            this.colNomeExercicio.HeaderText = "Aluno";
            this.colNomeExercicio.Name = "colNomeExercicio";
            this.colNomeExercicio.ReadOnly = true;
            this.colNomeExercicio.Width = 500;
            // 
            // ColAtivo
            // 
            this.ColAtivo.DataPropertyName = "TipoTreinamento";
            this.ColAtivo.HeaderText = "Treinamento";
            this.ColAtivo.Name = "ColAtivo";
            this.ColAtivo.ReadOnly = true;
            this.ColAtivo.Width = 133;
            // 
            // Ativo
            // 
            this.Ativo.DataPropertyName = "Ativo";
            this.Ativo.HeaderText = "Ativo";
            this.Ativo.Name = "Ativo";
            this.Ativo.ReadOnly = true;
            // 
            // lblSelecionarTitulo
            // 
            this.lblSelecionarTitulo.AutoSize = true;
            this.lblSelecionarTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecionarTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblSelecionarTitulo.Location = new System.Drawing.Point(127, 12);
            this.lblSelecionarTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelecionarTitulo.Name = "lblSelecionarTitulo";
            this.lblSelecionarTitulo.Size = new System.Drawing.Size(486, 38);
            this.lblSelecionarTitulo.TabIndex = 0;
            this.lblSelecionarTitulo.Text = "Selecionar Treinamento Físico";
            // 
            // txtSelecionarCodAluno
            // 
            this.txtSelecionarCodAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelecionarCodAluno.Location = new System.Drawing.Point(157, 107);
            this.txtSelecionarCodAluno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSelecionarCodAluno.Name = "txtSelecionarCodAluno";
            this.txtSelecionarCodAluno.Size = new System.Drawing.Size(908, 30);
            this.txtSelecionarCodAluno.TabIndex = 2;
            // 
            // pbxSelecionarTreinamentoFisico
            // 
            this.pbxSelecionarTreinamentoFisico.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbxSelecionarTreinamentoFisico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxSelecionarTreinamentoFisico.Image = global::Apresentacao.Properties.Resources.Computer_Hardware_System_Information_icon__3_;
            this.pbxSelecionarTreinamentoFisico.Location = new System.Drawing.Point(16, 12);
            this.pbxSelecionarTreinamentoFisico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxSelecionarTreinamentoFisico.Name = "pbxSelecionarTreinamentoFisico";
            this.pbxSelecionarTreinamentoFisico.Size = new System.Drawing.Size(103, 95);
            this.pbxSelecionarTreinamentoFisico.TabIndex = 46;
            this.pbxSelecionarTreinamentoFisico.TabStop = false;
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
            this.btnSelecionarPesquisar.Location = new System.Drawing.Point(1024, 111);
            this.btnSelecionarPesquisar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelecionarPesquisar.Name = "btnSelecionarPesquisar";
            this.btnSelecionarPesquisar.Size = new System.Drawing.Size(35, 25);
            this.btnSelecionarPesquisar.TabIndex = 3;
            this.btnSelecionarPesquisar.UseVisualStyleBackColor = false;
            this.btnSelecionarPesquisar.Click += new System.EventHandler(this.btnSelecionarPesquisar_Click);
            this.btnSelecionarPesquisar.MouseLeave += new System.EventHandler(this.btnSelecionarPesquisar_MouseLeave);
            this.btnSelecionarPesquisar.MouseHover += new System.EventHandler(this.btnSelecionarPesquisar_MouseHover);
            // 
            // FrmTreinamentoSelecionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1075, 661);
            this.Controls.Add(this.btnSelecionarPesquisar);
            this.Controls.Add(this.listBoxSelecionar);
            this.Controls.Add(this.lblSelecionarCodNome);
            this.Controls.Add(this.btnSelecionarInserir);
            this.Controls.Add(this.btnSelecionarAlterar);
            this.Controls.Add(this.btnSelecionarCancelar);
            this.Controls.Add(this.dgwSelecionarTreinamentoFísico);
            this.Controls.Add(this.lblSelecionarTitulo);
            this.Controls.Add(this.txtSelecionarCodAluno);
            this.Controls.Add(this.pbxSelecionarTreinamentoFisico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTreinamentoSelecionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Treinamento";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTreinamentoSelecionar_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSelecionarTreinamentoFísico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSelecionarTreinamentoFisico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSelecionar;
        private System.Windows.Forms.Label lblSelecionarCodNome;
        private System.Windows.Forms.Button btnSelecionarInserir;
        private System.Windows.Forms.Button btnSelecionarAlterar;
        private System.Windows.Forms.Button btnSelecionarCancelar;
        private System.Windows.Forms.DataGridView dgwSelecionarTreinamentoFísico;
        private System.Windows.Forms.Label lblSelecionarTitulo;
        private System.Windows.Forms.TextBox txtSelecionarCodAluno;
        private System.Windows.Forms.ToolTip ttpSelecionarPesquisar;
        private System.Windows.Forms.PictureBox pbxSelecionarTreinamentoFisico;
        private System.Windows.Forms.Button btnSelecionarPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDPessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeExercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAtivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ativo;
    }
}