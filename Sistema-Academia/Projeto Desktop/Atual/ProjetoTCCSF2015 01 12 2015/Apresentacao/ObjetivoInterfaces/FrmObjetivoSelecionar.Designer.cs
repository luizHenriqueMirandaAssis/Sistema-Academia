﻿namespace Apresentacao.Aluno_Interfaces
{
    partial class FrmObjetivoSelecionar
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
            this.dgwSelecionarObjetivo = new System.Windows.Forms.DataGridView();
            this.colIDPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSelecionarCodNome = new System.Windows.Forms.TextBox();
            this.btnSelecionarPesquisar = new System.Windows.Forms.Button();
            this.lblSelecionarTitulo = new System.Windows.Forms.Label();
            this.ttpSelecionarPesquisar = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSelecionarObjetivo)).BeginInit();
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
            this.listBoxSelecionar.Location = new System.Drawing.Point(8, 623);
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
            this.lblSelecionarNome.Location = new System.Drawing.Point(3, 113);
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
            this.btnSelecionarInserir.Location = new System.Drawing.Point(444, 612);
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
            this.btnSelecionarAlterar.Location = new System.Drawing.Point(565, 612);
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
            this.btnSelecionarCancelar.Location = new System.Drawing.Point(687, 612);
            this.btnSelecionarCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelecionarCancelar.Name = "btnSelecionarCancelar";
            this.btnSelecionarCancelar.Size = new System.Drawing.Size(113, 41);
            this.btnSelecionarCancelar.TabIndex = 8;
            this.btnSelecionarCancelar.Text = "Cancelar";
            this.btnSelecionarCancelar.UseVisualStyleBackColor = false;
            this.btnSelecionarCancelar.Click += new System.EventHandler(this.btnSelecionarCancelar_Click);
            // 
            // dgwSelecionarObjetivo
            // 
            this.dgwSelecionarObjetivo.AllowUserToAddRows = false;
            this.dgwSelecionarObjetivo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgwSelecionarObjetivo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwSelecionarObjetivo.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwSelecionarObjetivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwSelecionarObjetivo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwSelecionarObjetivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSelecionarObjetivo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDPessoa,
            this.colNome,
            this.colDataNascimento});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwSelecionarObjetivo.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgwSelecionarObjetivo.Location = new System.Drawing.Point(8, 159);
            this.dgwSelecionarObjetivo.Margin = new System.Windows.Forms.Padding(4);
            this.dgwSelecionarObjetivo.MultiSelect = false;
            this.dgwSelecionarObjetivo.Name = "dgwSelecionarObjetivo";
            this.dgwSelecionarObjetivo.ReadOnly = true;
            this.dgwSelecionarObjetivo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwSelecionarObjetivo.RowHeadersVisible = false;
            this.dgwSelecionarObjetivo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwSelecionarObjetivo.Size = new System.Drawing.Size(792, 446);
            this.dgwSelecionarObjetivo.TabIndex = 4;
            this.dgwSelecionarObjetivo.TabStop = false;
            this.dgwSelecionarObjetivo.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwSelecionarObjetivo_CellMouseDoubleClick);
            // 
            // colIDPessoa
            // 
            this.colIDPessoa.DataPropertyName = "IDObjetivo";
            this.colIDPessoa.HeaderText = "Código";
            this.colIDPessoa.Name = "colIDPessoa";
            this.colIDPessoa.ReadOnly = true;
            this.colIDPessoa.Width = 60;
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "Descricao";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.colNome.DefaultCellStyle = dataGridViewCellStyle3;
            this.colNome.HeaderText = "Descrição";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 398;
            // 
            // colDataNascimento
            // 
            this.colDataNascimento.DataPropertyName = "DataCadastro";
            this.colDataNascimento.HeaderText = "Data Cadastro";
            this.colDataNascimento.Name = "colDataNascimento";
            this.colDataNascimento.ReadOnly = true;
            this.colDataNascimento.Width = 135;
            // 
            // txtSelecionarCodNome
            // 
            this.txtSelecionarCodNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelecionarCodNome.Location = new System.Drawing.Point(185, 110);
            this.txtSelecionarCodNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtSelecionarCodNome.Name = "txtSelecionarCodNome";
            this.txtSelecionarCodNome.Size = new System.Drawing.Size(614, 30);
            this.txtSelecionarCodNome.TabIndex = 2;
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
            this.btnSelecionarPesquisar.Location = new System.Drawing.Point(761, 113);
            this.btnSelecionarPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelecionarPesquisar.Name = "btnSelecionarPesquisar";
            this.btnSelecionarPesquisar.Size = new System.Drawing.Size(31, 25);
            this.btnSelecionarPesquisar.TabIndex = 3;
            this.btnSelecionarPesquisar.UseVisualStyleBackColor = false;
            this.btnSelecionarPesquisar.Click += new System.EventHandler(this.btnSelecionarPesquisar_Click);
            this.btnSelecionarPesquisar.MouseLeave += new System.EventHandler(this.btnSelecionarPesquisar_MouseLeave);
            this.btnSelecionarPesquisar.MouseHover += new System.EventHandler(this.btnSelecionarPesquisar_MouseHover);
            // 
            // lblSelecionarTitulo
            // 
            this.lblSelecionarTitulo.AutoSize = true;
            this.lblSelecionarTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecionarTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblSelecionarTitulo.Location = new System.Drawing.Point(127, 15);
            this.lblSelecionarTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelecionarTitulo.Name = "lblSelecionarTitulo";
            this.lblSelecionarTitulo.Size = new System.Drawing.Size(319, 38);
            this.lblSelecionarTitulo.TabIndex = 0;
            this.lblSelecionarTitulo.Text = "Selecionar Objetivo";
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
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // FrmObjetivoSelecionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(809, 661);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSelecionarTitulo);
            this.Controls.Add(this.listBoxSelecionar);
            this.Controls.Add(this.lblSelecionarNome);
            this.Controls.Add(this.btnSelecionarInserir);
            this.Controls.Add(this.btnSelecionarAlterar);
            this.Controls.Add(this.btnSelecionarCancelar);
            this.Controls.Add(this.dgwSelecionarObjetivo);
            this.Controls.Add(this.btnSelecionarPesquisar);
            this.Controls.Add(this.txtSelecionarCodNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmObjetivoSelecionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Objetivo";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmObjetivoSelecionar_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSelecionarObjetivo)).EndInit();
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
        private System.Windows.Forms.DataGridView dgwSelecionarObjetivo;
        private System.Windows.Forms.Button btnSelecionarPesquisar;
        private System.Windows.Forms.TextBox txtSelecionarCodNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDPessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataNascimento;
        private System.Windows.Forms.Label lblSelecionarTitulo;
        private System.Windows.Forms.ToolTip ttpSelecionarPesquisar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}