namespace Apresentacao.MedidaCorporalInterfaces
{
    partial class FrmTipoMedidaCorporalSelecionar
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
            this.dgwSelecionarTipoMedidaCorporal = new System.Windows.Forms.DataGridView();
            this.colIDTipoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSelecionarCodDescricao = new System.Windows.Forms.TextBox();
            this.lblSelecionarTitulo = new System.Windows.Forms.Label();
            this.ttpSelecionarPesquisar = new System.Windows.Forms.ToolTip(this.components);
            this.btnSelecionarPesquisar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSelecionarTipoMedidaCorporal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.listBoxSelecionar.Location = new System.Drawing.Point(13, 613);
            this.listBoxSelecionar.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxSelecionar.Name = "listBoxSelecionar";
            this.listBoxSelecionar.Size = new System.Drawing.Size(368, 29);
            this.listBoxSelecionar.TabIndex = 5;
            this.listBoxSelecionar.TabStop = false;
            // 
            // lblSelecionarNome
            // 
            this.lblSelecionarNome.AutoSize = true;
            this.lblSelecionarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecionarNome.ForeColor = System.Drawing.Color.Black;
            this.lblSelecionarNome.Location = new System.Drawing.Point(13, 113);
            this.lblSelecionarNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelecionarNome.Name = "lblSelecionarNome";
            this.lblSelecionarNome.Size = new System.Drawing.Size(174, 25);
            this.lblSelecionarNome.TabIndex = 1;
            this.lblSelecionarNome.Text = "Código/Descrição:";
            // 
            // btnSelecionarInserir
            // 
            this.btnSelecionarInserir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelecionarInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarInserir.Location = new System.Drawing.Point(459, 602);
            this.btnSelecionarInserir.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnSelecionarAlterar.Location = new System.Drawing.Point(580, 602);
            this.btnSelecionarAlterar.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnSelecionarCancelar.Location = new System.Drawing.Point(701, 602);
            this.btnSelecionarCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelecionarCancelar.Name = "btnSelecionarCancelar";
            this.btnSelecionarCancelar.Size = new System.Drawing.Size(113, 41);
            this.btnSelecionarCancelar.TabIndex = 8;
            this.btnSelecionarCancelar.Text = "Cancelar";
            this.btnSelecionarCancelar.UseVisualStyleBackColor = false;
            this.btnSelecionarCancelar.Click += new System.EventHandler(this.btnSelecionarCancelar_Click);
            // 
            // dgwSelecionarTipoMedidaCorporal
            // 
            this.dgwSelecionarTipoMedidaCorporal.AllowUserToAddRows = false;
            this.dgwSelecionarTipoMedidaCorporal.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgwSelecionarTipoMedidaCorporal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwSelecionarTipoMedidaCorporal.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwSelecionarTipoMedidaCorporal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwSelecionarTipoMedidaCorporal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwSelecionarTipoMedidaCorporal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSelecionarTipoMedidaCorporal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgwSelecionarTipoMedidaCorporal.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgwSelecionarTipoMedidaCorporal.Location = new System.Drawing.Point(13, 149);
            this.dgwSelecionarTipoMedidaCorporal.Margin = new System.Windows.Forms.Padding(4);
            this.dgwSelecionarTipoMedidaCorporal.MultiSelect = false;
            this.dgwSelecionarTipoMedidaCorporal.Name = "dgwSelecionarTipoMedidaCorporal";
            this.dgwSelecionarTipoMedidaCorporal.ReadOnly = true;
            this.dgwSelecionarTipoMedidaCorporal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwSelecionarTipoMedidaCorporal.RowHeadersVisible = false;
            this.dgwSelecionarTipoMedidaCorporal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwSelecionarTipoMedidaCorporal.Size = new System.Drawing.Size(801, 446);
            this.dgwSelecionarTipoMedidaCorporal.TabIndex = 4;
            this.dgwSelecionarTipoMedidaCorporal.TabStop = false;
            this.dgwSelecionarTipoMedidaCorporal.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgwSelecionarTipoMedidaCorporal_CellFormatting);
            this.dgwSelecionarTipoMedidaCorporal.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwSelecionarTipoMedidaCorporal_CellMouseDoubleClick);
            // 
            // colIDTipoUsuario
            // 
            this.colIDTipoUsuario.DataPropertyName = "IDTipoMedidaCorporal";
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
            // txtSelecionarCodDescricao
            // 
            this.txtSelecionarCodDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelecionarCodDescricao.Location = new System.Drawing.Point(205, 111);
            this.txtSelecionarCodDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtSelecionarCodDescricao.Name = "txtSelecionarCodDescricao";
            this.txtSelecionarCodDescricao.Size = new System.Drawing.Size(608, 30);
            this.txtSelecionarCodDescricao.TabIndex = 2;
            // 
            // lblSelecionarTitulo
            // 
            this.lblSelecionarTitulo.AutoSize = true;
            this.lblSelecionarTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecionarTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblSelecionarTitulo.Location = new System.Drawing.Point(127, 15);
            this.lblSelecionarTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelecionarTitulo.Name = "lblSelecionarTitulo";
            this.lblSelecionarTitulo.Size = new System.Drawing.Size(577, 38);
            this.lblSelecionarTitulo.TabIndex = 0;
            this.lblSelecionarTitulo.Text = "Selecionar Tipo De Medida Corporal";
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
            this.btnSelecionarPesquisar.Location = new System.Drawing.Point(765, 112);
            this.btnSelecionarPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelecionarPesquisar.Name = "btnSelecionarPesquisar";
            this.btnSelecionarPesquisar.Size = new System.Drawing.Size(41, 25);
            this.btnSelecionarPesquisar.TabIndex = 3;
            this.btnSelecionarPesquisar.UseVisualStyleBackColor = false;
            this.btnSelecionarPesquisar.Click += new System.EventHandler(this.btnSelecionarPesquisar_Click);
            this.btnSelecionarPesquisar.MouseLeave += new System.EventHandler(this.btnSelecionarPesquisar_MouseLeave);
            this.btnSelecionarPesquisar.MouseHover += new System.EventHandler(this.btnSelecionarPesquisar_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Apresentacao.Properties.Resources.Computer_Hardware_System_Information_icon__3_;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 95);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // FrmTipoMedidaCorporalSelecionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(827, 652);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSelecionarTitulo);
            this.Controls.Add(this.listBoxSelecionar);
            this.Controls.Add(this.lblSelecionarNome);
            this.Controls.Add(this.btnSelecionarInserir);
            this.Controls.Add(this.btnSelecionarAlterar);
            this.Controls.Add(this.btnSelecionarCancelar);
            this.Controls.Add(this.dgwSelecionarTipoMedidaCorporal);
            this.Controls.Add(this.btnSelecionarPesquisar);
            this.Controls.Add(this.txtSelecionarCodDescricao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTipoMedidaCorporalSelecionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Tipo Medida Corporal";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTipoMedidaCorporalSelecionar_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmTipoMedidaCorporalSelecionar_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSelecionarTipoMedidaCorporal)).EndInit();
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
        private System.Windows.Forms.DataGridView dgwSelecionarTipoMedidaCorporal;
        private System.Windows.Forms.Button btnSelecionarPesquisar;
        private System.Windows.Forms.TextBox txtSelecionarCodDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDTipoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ativo;
        private System.Windows.Forms.Label lblSelecionarTitulo;
        private System.Windows.Forms.ToolTip ttpSelecionarPesquisar;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}