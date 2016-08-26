namespace Apresentacao.TreinamentoInterfaces.TipoTreinamentoInterfaces
{
    partial class FrmTipoTreinamentoSelecionar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listBoxSelecionar = new System.Windows.Forms.ListBox();
            this.lblSelecionarNome = new System.Windows.Forms.Label();
            this.btnSelecionarInserir = new System.Windows.Forms.Button();
            this.btnSelecionarAlterar = new System.Windows.Forms.Button();
            this.btnSelecionarCancelar = new System.Windows.Forms.Button();
            this.dgwSelecionarTipoTreinamento = new System.Windows.Forms.DataGridView();
            this.colIDTipoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSelecionarTitulo = new System.Windows.Forms.Label();
            this.txtSelecionarCodDescricao = new System.Windows.Forms.TextBox();
            this.ttpSelecionarPesquisar = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSelecionarPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSelecionarTipoTreinamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxSelecionar
            // 
            this.listBoxSelecionar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBoxSelecionar.Enabled = false;
            this.listBoxSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSelecionar.FormattingEnabled = true;
            this.listBoxSelecionar.ItemHeight = 20;
            this.listBoxSelecionar.Items.AddRange(new object[] {
            "F1: Pesquisar - F2: Inserir - F3: Alterar"});
            this.listBoxSelecionar.Location = new System.Drawing.Point(10, 496);
            this.listBoxSelecionar.Name = "listBoxSelecionar";
            this.listBoxSelecionar.Size = new System.Drawing.Size(277, 24);
            this.listBoxSelecionar.TabIndex = 40;
            this.listBoxSelecionar.TabStop = false;
            // 
            // lblSelecionarNome
            // 
            this.lblSelecionarNome.AutoSize = true;
            this.lblSelecionarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecionarNome.ForeColor = System.Drawing.Color.Black;
            this.lblSelecionarNome.Location = new System.Drawing.Point(10, 89);
            this.lblSelecionarNome.Name = "lblSelecionarNome";
            this.lblSelecionarNome.Size = new System.Drawing.Size(138, 20);
            this.lblSelecionarNome.TabIndex = 36;
            this.lblSelecionarNome.Text = "Código/Descrição:";
            // 
            // btnSelecionarInserir
            // 
            this.btnSelecionarInserir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelecionarInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarInserir.Location = new System.Drawing.Point(344, 487);
            this.btnSelecionarInserir.Name = "btnSelecionarInserir";
            this.btnSelecionarInserir.Size = new System.Drawing.Size(85, 33);
            this.btnSelecionarInserir.TabIndex = 41;
            this.btnSelecionarInserir.Text = "Inserir";
            this.btnSelecionarInserir.UseVisualStyleBackColor = false;
            this.btnSelecionarInserir.Click += new System.EventHandler(this.btnSelecionarInserir_Click);
            // 
            // btnSelecionarAlterar
            // 
            this.btnSelecionarAlterar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelecionarAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarAlterar.Location = new System.Drawing.Point(435, 487);
            this.btnSelecionarAlterar.Name = "btnSelecionarAlterar";
            this.btnSelecionarAlterar.Size = new System.Drawing.Size(85, 33);
            this.btnSelecionarAlterar.TabIndex = 42;
            this.btnSelecionarAlterar.Text = "Alterar";
            this.btnSelecionarAlterar.UseVisualStyleBackColor = false;
            this.btnSelecionarAlterar.Click += new System.EventHandler(this.btnSelecionarAlterar_Click);
            // 
            // btnSelecionarCancelar
            // 
            this.btnSelecionarCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelecionarCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarCancelar.Location = new System.Drawing.Point(526, 487);
            this.btnSelecionarCancelar.Name = "btnSelecionarCancelar";
            this.btnSelecionarCancelar.Size = new System.Drawing.Size(85, 33);
            this.btnSelecionarCancelar.TabIndex = 43;
            this.btnSelecionarCancelar.Text = "Cancelar";
            this.btnSelecionarCancelar.UseVisualStyleBackColor = false;
            this.btnSelecionarCancelar.Click += new System.EventHandler(this.btnSelecionarCancelar_Click);
            // 
            // dgwSelecionarTipoTreinamento
            // 
            this.dgwSelecionarTipoTreinamento.AllowUserToAddRows = false;
            this.dgwSelecionarTipoTreinamento.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgwSelecionarTipoTreinamento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwSelecionarTipoTreinamento.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwSelecionarTipoTreinamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwSelecionarTipoTreinamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwSelecionarTipoTreinamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSelecionarTipoTreinamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDTipoUsuario,
            this.colDescricao,
            this.Ativo});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwSelecionarTipoTreinamento.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgwSelecionarTipoTreinamento.Location = new System.Drawing.Point(10, 119);
            this.dgwSelecionarTipoTreinamento.MultiSelect = false;
            this.dgwSelecionarTipoTreinamento.Name = "dgwSelecionarTipoTreinamento";
            this.dgwSelecionarTipoTreinamento.ReadOnly = true;
            this.dgwSelecionarTipoTreinamento.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwSelecionarTipoTreinamento.RowHeadersVisible = false;
            this.dgwSelecionarTipoTreinamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwSelecionarTipoTreinamento.Size = new System.Drawing.Size(601, 362);
            this.dgwSelecionarTipoTreinamento.TabIndex = 39;
            this.dgwSelecionarTipoTreinamento.TabStop = false;
            this.dgwSelecionarTipoTreinamento.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgwSelecionarTipoTreinamento_CellFormatting);
            // 
            // colIDTipoUsuario
            // 
            this.colIDTipoUsuario.DataPropertyName = "IDTipoTreinamento";
            this.colIDTipoUsuario.HeaderText = "Código";
            this.colIDTipoUsuario.Name = "colIDTipoUsuario";
            this.colIDTipoUsuario.ReadOnly = true;
            // 
            // colDescricao
            // 
            this.colDescricao.DataPropertyName = "Descricao";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.colDescricao.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            this.colDescricao.Width = 400;
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
            this.lblSelecionarTitulo.Location = new System.Drawing.Point(95, 10);
            this.lblSelecionarTitulo.Name = "lblSelecionarTitulo";
            this.lblSelecionarTitulo.Size = new System.Drawing.Size(519, 31);
            this.lblSelecionarTitulo.TabIndex = 35;
            this.lblSelecionarTitulo.Text = "Selecionar Tipo De Treinamento Físico";
            // 
            // txtSelecionarCodDescricao
            // 
            this.txtSelecionarCodDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelecionarCodDescricao.Location = new System.Drawing.Point(154, 87);
            this.txtSelecionarCodDescricao.Name = "txtSelecionarCodDescricao";
            this.txtSelecionarCodDescricao.Size = new System.Drawing.Size(457, 26);
            this.txtSelecionarCodDescricao.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Apresentacao.Properties.Resources.Computer_Hardware_System_Information_icon__3_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 77);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
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
            this.btnSelecionarPesquisar.Location = new System.Drawing.Point(574, 89);
            this.btnSelecionarPesquisar.Name = "btnSelecionarPesquisar";
            this.btnSelecionarPesquisar.Size = new System.Drawing.Size(31, 20);
            this.btnSelecionarPesquisar.TabIndex = 45;
            this.btnSelecionarPesquisar.UseVisualStyleBackColor = false;
            this.btnSelecionarPesquisar.Click += new System.EventHandler(this.btnSelecionarPesquisar_Click);
            // 
            // FrmTipoTreinamentoSelecionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(620, 530);
            this.Controls.Add(this.btnSelecionarPesquisar);
            this.Controls.Add(this.listBoxSelecionar);
            this.Controls.Add(this.lblSelecionarNome);
            this.Controls.Add(this.btnSelecionarInserir);
            this.Controls.Add(this.btnSelecionarAlterar);
            this.Controls.Add(this.btnSelecionarCancelar);
            this.Controls.Add(this.dgwSelecionarTipoTreinamento);
            this.Controls.Add(this.lblSelecionarTitulo);
            this.Controls.Add(this.txtSelecionarCodDescricao);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTipoTreinamentoSelecionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Tipo De Treinamento Físico";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTipoTreinamentoSelecionar_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSelecionarTipoTreinamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSelecionar;
        private System.Windows.Forms.Label lblSelecionarNome;
        private System.Windows.Forms.Button btnSelecionarInserir;
        private System.Windows.Forms.Button btnSelecionarAlterar;
        private System.Windows.Forms.Button btnSelecionarCancelar;
        private System.Windows.Forms.DataGridView dgwSelecionarTipoTreinamento;
        private System.Windows.Forms.Label lblSelecionarTitulo;
        private System.Windows.Forms.TextBox txtSelecionarCodDescricao;
        private System.Windows.Forms.ToolTip ttpSelecionarPesquisar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSelecionarPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDTipoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ativo;
    }
}