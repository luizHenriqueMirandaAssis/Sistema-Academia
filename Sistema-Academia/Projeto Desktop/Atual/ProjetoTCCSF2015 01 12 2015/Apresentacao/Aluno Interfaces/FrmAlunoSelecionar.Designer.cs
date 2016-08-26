namespace Apresentacao
{
    partial class FrmAlunoSelecionar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSelecionarAlunoCodNome = new System.Windows.Forms.TextBox();
            this.btnSelecionarAlunoAlterar = new System.Windows.Forms.Button();
            this.btnSelecionarAlunoCancelar = new System.Windows.Forms.Button();
            this.btnSelecionarAlunoInserir = new System.Windows.Forms.Button();
            this.lblSelecionarAlunoNome = new System.Windows.Forms.Label();
            this.ttpFrmSelecionar = new System.Windows.Forms.ToolTip(this.components);
            this.listBoxSelecionarAluno = new System.Windows.Forms.ListBox();
            this.ColAtivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgwSelecionarAluno = new System.Windows.Forms.DataGridView();
            this.lblSelecionarTitulo = new System.Windows.Forms.Label();
            this.pbcSelecionar = new System.Windows.Forms.PictureBox();
            this.btnSelecionarAlunoPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSelecionarAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcSelecionar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSelecionarAlunoCodNome
            // 
            this.txtSelecionarAlunoCodNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelecionarAlunoCodNome.Location = new System.Drawing.Point(169, 97);
            this.txtSelecionarAlunoCodNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtSelecionarAlunoCodNome.Name = "txtSelecionarAlunoCodNome";
            this.txtSelecionarAlunoCodNome.Size = new System.Drawing.Size(996, 30);
            this.txtSelecionarAlunoCodNome.TabIndex = 2;
            // 
            // btnSelecionarAlunoAlterar
            // 
            this.btnSelecionarAlunoAlterar.AutoSize = true;
            this.btnSelecionarAlunoAlterar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelecionarAlunoAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarAlunoAlterar.Location = new System.Drawing.Point(932, 603);
            this.btnSelecionarAlunoAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelecionarAlunoAlterar.Name = "btnSelecionarAlunoAlterar";
            this.btnSelecionarAlunoAlterar.Size = new System.Drawing.Size(113, 41);
            this.btnSelecionarAlunoAlterar.TabIndex = 7;
            this.btnSelecionarAlunoAlterar.Text = "Alterar";
            this.btnSelecionarAlunoAlterar.UseVisualStyleBackColor = false;
            this.btnSelecionarAlunoAlterar.Click += new System.EventHandler(this.btnSelecionarAlunoAlterar_Click);
            // 
            // btnSelecionarAlunoCancelar
            // 
            this.btnSelecionarAlunoCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelecionarAlunoCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarAlunoCancelar.Location = new System.Drawing.Point(1053, 602);
            this.btnSelecionarAlunoCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelecionarAlunoCancelar.Name = "btnSelecionarAlunoCancelar";
            this.btnSelecionarAlunoCancelar.Size = new System.Drawing.Size(113, 41);
            this.btnSelecionarAlunoCancelar.TabIndex = 8;
            this.btnSelecionarAlunoCancelar.Text = "Cancelar";
            this.btnSelecionarAlunoCancelar.UseVisualStyleBackColor = false;
            this.btnSelecionarAlunoCancelar.Click += new System.EventHandler(this.btnSelecionarAlunoCancelar_Click);
            // 
            // btnSelecionarAlunoInserir
            // 
            this.btnSelecionarAlunoInserir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelecionarAlunoInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarAlunoInserir.Location = new System.Drawing.Point(811, 603);
            this.btnSelecionarAlunoInserir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelecionarAlunoInserir.Name = "btnSelecionarAlunoInserir";
            this.btnSelecionarAlunoInserir.Size = new System.Drawing.Size(113, 41);
            this.btnSelecionarAlunoInserir.TabIndex = 6;
            this.btnSelecionarAlunoInserir.Text = "Inserir";
            this.btnSelecionarAlunoInserir.UseVisualStyleBackColor = false;
            this.btnSelecionarAlunoInserir.Click += new System.EventHandler(this.btnSelecionarAlunoInserir_Click);
            // 
            // lblSelecionarAlunoNome
            // 
            this.lblSelecionarAlunoNome.AutoSize = true;
            this.lblSelecionarAlunoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecionarAlunoNome.ForeColor = System.Drawing.Color.Black;
            this.lblSelecionarAlunoNome.Location = new System.Drawing.Point(16, 101);
            this.lblSelecionarAlunoNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelecionarAlunoNome.Name = "lblSelecionarAlunoNome";
            this.lblSelecionarAlunoNome.Size = new System.Drawing.Size(139, 25);
            this.lblSelecionarAlunoNome.TabIndex = 1;
            this.lblSelecionarAlunoNome.Text = "Código/Nome:";
            // 
            // listBoxSelecionarAluno
            // 
            this.listBoxSelecionarAluno.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBoxSelecionarAluno.Enabled = false;
            this.listBoxSelecionarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSelecionarAluno.FormattingEnabled = true;
            this.listBoxSelecionarAluno.ItemHeight = 25;
            this.listBoxSelecionarAluno.Items.AddRange(new object[] {
            "F1: Pesquisar - F2: Inserir - F3: Alterar"});
            this.listBoxSelecionarAluno.Location = new System.Drawing.Point(8, 613);
            this.listBoxSelecionarAluno.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxSelecionarAluno.Name = "listBoxSelecionarAluno";
            this.listBoxSelecionarAluno.Size = new System.Drawing.Size(368, 29);
            this.listBoxSelecionarAluno.TabIndex = 5;
            this.listBoxSelecionarAluno.TabStop = false;
            // 
            // ColAtivo
            // 
            this.ColAtivo.DataPropertyName = "Pessoa";
            this.ColAtivo.HeaderText = "Ativo";
            this.ColAtivo.Name = "ColAtivo";
            this.ColAtivo.ReadOnly = true;
            // 
            // colDescricao
            // 
            this.colDescricao.DataPropertyName = "Objetivo";
            this.colDescricao.HeaderText = "Objetivo";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            this.colDescricao.Width = 150;
            // 
            // colDataNascimento
            // 
            this.colDataNascimento.DataPropertyName = "Pessoa";
            this.colDataNascimento.HeaderText = "Data Nascimento";
            this.colDataNascimento.Name = "colDataNascimento";
            this.colDataNascimento.ReadOnly = true;
            this.colDataNascimento.Width = 135;
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
            // colNome
            // 
            this.colNome.DataPropertyName = "Pessoa";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.colNome.DefaultCellStyle = dataGridViewCellStyle1;
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 298;
            // 
            // colIDPessoa
            // 
            this.colIDPessoa.DataPropertyName = "Pessoa";
            this.colIDPessoa.HeaderText = "Código";
            this.colIDPessoa.Name = "colIDPessoa";
            this.colIDPessoa.ReadOnly = true;
            this.colIDPessoa.Width = 60;
            // 
            // dgwSelecionarAluno
            // 
            this.dgwSelecionarAluno.AllowUserToAddRows = false;
            this.dgwSelecionarAluno.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgwSelecionarAluno.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwSelecionarAluno.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwSelecionarAluno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwSelecionarAluno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwSelecionarAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSelecionarAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDPessoa,
            this.colNome,
            this.colSexo,
            this.colDataNascimento,
            this.colDescricao,
            this.ColAtivo});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwSelecionarAluno.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgwSelecionarAluno.Location = new System.Drawing.Point(8, 146);
            this.dgwSelecionarAluno.Margin = new System.Windows.Forms.Padding(4);
            this.dgwSelecionarAluno.MultiSelect = false;
            this.dgwSelecionarAluno.Name = "dgwSelecionarAluno";
            this.dgwSelecionarAluno.ReadOnly = true;
            this.dgwSelecionarAluno.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwSelecionarAluno.RowHeadersVisible = false;
            this.dgwSelecionarAluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwSelecionarAluno.Size = new System.Drawing.Size(1159, 449);
            this.dgwSelecionarAluno.TabIndex = 4;
            this.dgwSelecionarAluno.TabStop = false;
            this.dgwSelecionarAluno.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgwSelecionarAluno_CellFormatting);
            this.dgwSelecionarAluno.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwSelecionarAluno_CellMouseDoubleClick);
            // 
            // lblSelecionarTitulo
            // 
            this.lblSelecionarTitulo.AutoSize = true;
            this.lblSelecionarTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecionarTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSelecionarTitulo.Location = new System.Drawing.Point(117, 15);
            this.lblSelecionarTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelecionarTitulo.Name = "lblSelecionarTitulo";
            this.lblSelecionarTitulo.Size = new System.Drawing.Size(279, 38);
            this.lblSelecionarTitulo.TabIndex = 0;
            this.lblSelecionarTitulo.Text = "Selecionar Aluno";
            // 
            // pbcSelecionar
            // 
            this.pbcSelecionar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbcSelecionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbcSelecionar.Image = global::Apresentacao.Properties.Resources._1440663087_checked_user1;
            this.pbcSelecionar.Location = new System.Drawing.Point(16, 15);
            this.pbcSelecionar.Margin = new System.Windows.Forms.Padding(4);
            this.pbcSelecionar.Name = "pbcSelecionar";
            this.pbcSelecionar.Size = new System.Drawing.Size(93, 82);
            this.pbcSelecionar.TabIndex = 18;
            this.pbcSelecionar.TabStop = false;
            // 
            // btnSelecionarAlunoPesquisar
            // 
            this.btnSelecionarAlunoPesquisar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelecionarAlunoPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSelecionarAlunoPesquisar.FlatAppearance.BorderSize = 0;
            this.btnSelecionarAlunoPesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSelecionarAlunoPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSelecionarAlunoPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarAlunoPesquisar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelecionarAlunoPesquisar.Image = global::Apresentacao.Properties.Resources.ic_search_black_24dp1;
            this.btnSelecionarAlunoPesquisar.Location = new System.Drawing.Point(1128, 101);
            this.btnSelecionarAlunoPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelecionarAlunoPesquisar.Name = "btnSelecionarAlunoPesquisar";
            this.btnSelecionarAlunoPesquisar.Size = new System.Drawing.Size(31, 25);
            this.btnSelecionarAlunoPesquisar.TabIndex = 3;
            this.btnSelecionarAlunoPesquisar.UseVisualStyleBackColor = false;
            this.btnSelecionarAlunoPesquisar.Click += new System.EventHandler(this.btnSelecionarAlunoPesquisar_Click);
            this.btnSelecionarAlunoPesquisar.MouseLeave += new System.EventHandler(this.btnSelecionarAlunoPesquisar_MouseLeave);
            this.btnSelecionarAlunoPesquisar.MouseHover += new System.EventHandler(this.btnSelecionarAlunoPesquisar_MouseHover);
            // 
            // FrmAlunoSelecionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1175, 651);
            this.Controls.Add(this.lblSelecionarTitulo);
            this.Controls.Add(this.pbcSelecionar);
            this.Controls.Add(this.listBoxSelecionarAluno);
            this.Controls.Add(this.lblSelecionarAlunoNome);
            this.Controls.Add(this.btnSelecionarAlunoInserir);
            this.Controls.Add(this.btnSelecionarAlunoAlterar);
            this.Controls.Add(this.btnSelecionarAlunoCancelar);
            this.Controls.Add(this.dgwSelecionarAluno);
            this.Controls.Add(this.btnSelecionarAlunoPesquisar);
            this.Controls.Add(this.txtSelecionarAlunoCodNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAlunoSelecionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Aluno";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAlunoSelecionar_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSelecionarAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcSelecionar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSelecionarAlunoCodNome;
        private System.Windows.Forms.Button btnSelecionarAlunoAlterar;
        private System.Windows.Forms.Button btnSelecionarAlunoCancelar;
        private System.Windows.Forms.Button btnSelecionarAlunoInserir;
        private System.Windows.Forms.Label lblSelecionarAlunoNome;
        private System.Windows.Forms.ToolTip ttpFrmSelecionar;
        private System.Windows.Forms.ListBox listBoxSelecionarAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAtivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDPessoa;
        private System.Windows.Forms.PictureBox pbcSelecionar;
        private System.Windows.Forms.Label lblSelecionarTitulo;
        private System.Windows.Forms.Button btnSelecionarAlunoPesquisar;
        private System.Windows.Forms.DataGridView dgwSelecionarAluno;
    }
}