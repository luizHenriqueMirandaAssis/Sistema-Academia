namespace Apresentacao.MedidaCorporalInterfaces
{
    partial class FrmMedidaCorporalCadastrar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCadastrarTitulo = new System.Windows.Forms.Label();
            this.lblCadastrarTipoMedida = new System.Windows.Forms.Label();
            this.lblMedidasCorporal = new System.Windows.Forms.Label();
            this.dgwMedidaCorporal = new System.Windows.Forms.DataGridView();
            this.collIDMedidaCorporal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Series = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collDataMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collAtivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCadastrarQuantidadeMedidas = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCadastrarDataNascimento = new System.Windows.Forms.Label();
            this.dtpCadastrarDataMedida = new System.Windows.Forms.DateTimePicker();
            this.grpFichaMedidaCorporal = new System.Windows.Forms.GroupBox();
            this.txtCadastrarCentimetro = new System.Windows.Forms.TextBox();
            this.listBoxSelecionar = new System.Windows.Forms.ListBox();
            this.txtCodigoAluno = new System.Windows.Forms.TextBox();
            this.txtCadastrarAluno = new System.Windows.Forms.TextBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.cbxCadastrarTipoMedida = new System.Windows.Forms.ComboBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.ttpCadastrarMedida = new System.Windows.Forms.ToolTip(this.components);
            this.lblAlunoObs = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pbxCadastrarTipoMedida = new System.Windows.Forms.PictureBox();
            this.grpIMC = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtIMC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mskPeso = new System.Windows.Forms.MaskedTextBox();
            this.mskAltura = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMedidaCorporal)).BeginInit();
            this.grpFichaMedidaCorporal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCadastrarTipoMedida)).BeginInit();
            this.grpIMC.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCadastrarTitulo
            // 
            this.lblCadastrarTitulo.AutoSize = true;
            this.lblCadastrarTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblCadastrarTitulo.Location = new System.Drawing.Point(115, 15);
            this.lblCadastrarTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastrarTitulo.Name = "lblCadastrarTitulo";
            this.lblCadastrarTitulo.Size = new System.Drawing.Size(435, 38);
            this.lblCadastrarTitulo.TabIndex = 0;
            this.lblCadastrarTitulo.Text = "Cadastrar Medida Corporal";
            // 
            // lblCadastrarTipoMedida
            // 
            this.lblCadastrarTipoMedida.AutoSize = true;
            this.lblCadastrarTipoMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarTipoMedida.ForeColor = System.Drawing.Color.Black;
            this.lblCadastrarTipoMedida.Location = new System.Drawing.Point(11, 102);
            this.lblCadastrarTipoMedida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastrarTipoMedida.Name = "lblCadastrarTipoMedida";
            this.lblCadastrarTipoMedida.Size = new System.Drawing.Size(209, 25);
            this.lblCadastrarTipoMedida.TabIndex = 5;
            this.lblCadastrarTipoMedida.Text = "*Tipo Medida Corporal";
            // 
            // lblMedidasCorporal
            // 
            this.lblMedidasCorporal.AutoSize = true;
            this.lblMedidasCorporal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedidasCorporal.ForeColor = System.Drawing.Color.Black;
            this.lblMedidasCorporal.Location = new System.Drawing.Point(11, 567);
            this.lblMedidasCorporal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedidasCorporal.Name = "lblMedidasCorporal";
            this.lblMedidasCorporal.Size = new System.Drawing.Size(168, 25);
            this.lblMedidasCorporal.TabIndex = 11;
            this.lblMedidasCorporal.Text = "Medidas corporal:";
            // 
            // dgwMedidaCorporal
            // 
            this.dgwMedidaCorporal.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgwMedidaCorporal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwMedidaCorporal.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwMedidaCorporal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwMedidaCorporal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwMedidaCorporal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMedidaCorporal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.collIDMedidaCorporal,
            this.Tipo,
            this.Series,
            this.collDataMedida,
            this.collAtivo});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwMedidaCorporal.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgwMedidaCorporal.Location = new System.Drawing.Point(15, 175);
            this.dgwMedidaCorporal.Margin = new System.Windows.Forms.Padding(4);
            this.dgwMedidaCorporal.MultiSelect = false;
            this.dgwMedidaCorporal.Name = "dgwMedidaCorporal";
            this.dgwMedidaCorporal.ReadOnly = true;
            this.dgwMedidaCorporal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwMedidaCorporal.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgwMedidaCorporal.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgwMedidaCorporal.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgwMedidaCorporal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwMedidaCorporal.Size = new System.Drawing.Size(1188, 377);
            this.dgwMedidaCorporal.TabIndex = 10;
            this.dgwMedidaCorporal.TabStop = false;
            this.dgwMedidaCorporal.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgwMedidaCorporal_CellFormatting);
            this.dgwMedidaCorporal.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgwMedidaCorporal_MouseDoubleClick);
            // 
            // collIDMedidaCorporal
            // 
            this.collIDMedidaCorporal.DataPropertyName = "Aluno";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.collIDMedidaCorporal.DefaultCellStyle = dataGridViewCellStyle3;
            this.collIDMedidaCorporal.HeaderText = "Código";
            this.collIDMedidaCorporal.Name = "collIDMedidaCorporal";
            this.collIDMedidaCorporal.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "TipoMedidaCorporal";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Tipo.DefaultCellStyle = dataGridViewCellStyle4;
            this.Tipo.HeaderText = "Tipo Medida Corporal";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 340;
            // 
            // Series
            // 
            this.Series.DataPropertyName = "MedidaCm";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Series.DefaultCellStyle = dataGridViewCellStyle5;
            this.Series.HeaderText = "Centímetro(cm)";
            this.Series.Name = "Series";
            this.Series.ReadOnly = true;
            this.Series.Width = 150;
            // 
            // collDataMedida
            // 
            this.collDataMedida.DataPropertyName = "DataMedida";
            this.collDataMedida.HeaderText = "Data Medida";
            this.collDataMedida.Name = "collDataMedida";
            this.collDataMedida.ReadOnly = true;
            this.collDataMedida.Width = 150;
            // 
            // collAtivo
            // 
            this.collAtivo.DataPropertyName = "Ativo";
            this.collAtivo.HeaderText = "Ativo";
            this.collAtivo.Name = "collAtivo";
            this.collAtivo.ReadOnly = true;
            this.collAtivo.Width = 150;
            // 
            // txtCadastrarQuantidadeMedidas
            // 
            this.txtCadastrarQuantidadeMedidas.Location = new System.Drawing.Point(197, 564);
            this.txtCadastrarQuantidadeMedidas.Margin = new System.Windows.Forms.Padding(4);
            this.txtCadastrarQuantidadeMedidas.Name = "txtCadastrarQuantidadeMedidas";
            this.txtCadastrarQuantidadeMedidas.ReadOnly = true;
            this.txtCadastrarQuantidadeMedidas.Size = new System.Drawing.Size(69, 30);
            this.txtCadastrarQuantidadeMedidas.TabIndex = 12;
            this.txtCadastrarQuantidadeMedidas.TabStop = false;
            this.txtCadastrarQuantidadeMedidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(871, 103);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 25);
            this.label10.TabIndex = 6;
            this.label10.Text = "* Centímetro (cm)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(11, 33);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "*Aluno";
            // 
            // lblCadastrarDataNascimento
            // 
            this.lblCadastrarDataNascimento.AutoSize = true;
            this.lblCadastrarDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarDataNascimento.ForeColor = System.Drawing.Color.Black;
            this.lblCadastrarDataNascimento.Location = new System.Drawing.Point(885, 33);
            this.lblCadastrarDataNascimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastrarDataNascimento.Name = "lblCadastrarDataNascimento";
            this.lblCadastrarDataNascimento.Size = new System.Drawing.Size(136, 25);
            this.lblCadastrarDataNascimento.TabIndex = 1;
            this.lblCadastrarDataNascimento.Text = "* Data Medida";
            // 
            // dtpCadastrarDataMedida
            // 
            this.dtpCadastrarDataMedida.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpCadastrarDataMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCadastrarDataMedida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCadastrarDataMedida.Location = new System.Drawing.Point(876, 59);
            this.dtpCadastrarDataMedida.Margin = new System.Windows.Forms.Padding(4);
            this.dtpCadastrarDataMedida.Name = "dtpCadastrarDataMedida";
            this.dtpCadastrarDataMedida.Size = new System.Drawing.Size(325, 30);
            this.dtpCadastrarDataMedida.TabIndex = 4;
            // 
            // grpFichaMedidaCorporal
            // 
            this.grpFichaMedidaCorporal.Controls.Add(this.txtCadastrarCentimetro);
            this.grpFichaMedidaCorporal.Controls.Add(this.listBoxSelecionar);
            this.grpFichaMedidaCorporal.Controls.Add(this.txtCodigoAluno);
            this.grpFichaMedidaCorporal.Controls.Add(this.txtCadastrarAluno);
            this.grpFichaMedidaCorporal.Controls.Add(this.btnRemover);
            this.grpFichaMedidaCorporal.Controls.Add(this.cbxCadastrarTipoMedida);
            this.grpFichaMedidaCorporal.Controls.Add(this.btnAlterar);
            this.grpFichaMedidaCorporal.Controls.Add(this.btnInserir);
            this.grpFichaMedidaCorporal.Controls.Add(this.dtpCadastrarDataMedida);
            this.grpFichaMedidaCorporal.Controls.Add(this.lblCadastrarDataNascimento);
            this.grpFichaMedidaCorporal.Controls.Add(this.label11);
            this.grpFichaMedidaCorporal.Controls.Add(this.label10);
            this.grpFichaMedidaCorporal.Controls.Add(this.txtCadastrarQuantidadeMedidas);
            this.grpFichaMedidaCorporal.Controls.Add(this.dgwMedidaCorporal);
            this.grpFichaMedidaCorporal.Controls.Add(this.lblMedidasCorporal);
            this.grpFichaMedidaCorporal.Controls.Add(this.lblCadastrarTipoMedida);
            this.grpFichaMedidaCorporal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFichaMedidaCorporal.Location = new System.Drawing.Point(16, 203);
            this.grpFichaMedidaCorporal.Margin = new System.Windows.Forms.Padding(4);
            this.grpFichaMedidaCorporal.Name = "grpFichaMedidaCorporal";
            this.grpFichaMedidaCorporal.Padding = new System.Windows.Forms.Padding(4);
            this.grpFichaMedidaCorporal.Size = new System.Drawing.Size(1217, 610);
            this.grpFichaMedidaCorporal.TabIndex = 1;
            this.grpFichaMedidaCorporal.TabStop = false;
            this.grpFichaMedidaCorporal.Text = "Ficha De Medida Corporal";
            // 
            // txtCadastrarCentimetro
            // 
            this.txtCadastrarCentimetro.Location = new System.Drawing.Point(876, 132);
            this.txtCadastrarCentimetro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCadastrarCentimetro.MaxLength = 6;
            this.txtCadastrarCentimetro.Name = "txtCadastrarCentimetro";
            this.txtCadastrarCentimetro.Size = new System.Drawing.Size(160, 30);
            this.txtCadastrarCentimetro.TabIndex = 102;
            this.txtCadastrarCentimetro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBoxSelecionar
            // 
            this.listBoxSelecionar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBoxSelecionar.Enabled = false;
            this.listBoxSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSelecionar.FormattingEnabled = true;
            this.listBoxSelecionar.ItemHeight = 25;
            this.listBoxSelecionar.Items.AddRange(new object[] {
            "F1: Inserir - F2: Alterar - F3: Remover"});
            this.listBoxSelecionar.Location = new System.Drawing.Point(276, 566);
            this.listBoxSelecionar.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxSelecionar.Name = "listBoxSelecionar";
            this.listBoxSelecionar.Size = new System.Drawing.Size(338, 29);
            this.listBoxSelecionar.TabIndex = 100;
            this.listBoxSelecionar.TabStop = false;
            // 
            // txtCodigoAluno
            // 
            this.txtCodigoAluno.Location = new System.Drawing.Point(15, 62);
            this.txtCodigoAluno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoAluno.Name = "txtCodigoAluno";
            this.txtCodigoAluno.ReadOnly = true;
            this.txtCodigoAluno.Size = new System.Drawing.Size(67, 30);
            this.txtCodigoAluno.TabIndex = 2;
            this.txtCodigoAluno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCadastrarAluno
            // 
            this.txtCadastrarAluno.Location = new System.Drawing.Point(88, 62);
            this.txtCadastrarAluno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCadastrarAluno.Name = "txtCadastrarAluno";
            this.txtCadastrarAluno.ReadOnly = true;
            this.txtCadastrarAluno.Size = new System.Drawing.Size(767, 30);
            this.txtCadastrarAluno.TabIndex = 3;
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(1052, 559);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(151, 43);
            this.btnRemover.TabIndex = 14;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // cbxCadastrarTipoMedida
            // 
            this.cbxCadastrarTipoMedida.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxCadastrarTipoMedida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCadastrarTipoMedida.FormattingEnabled = true;
            this.cbxCadastrarTipoMedida.Location = new System.Drawing.Point(16, 129);
            this.cbxCadastrarTipoMedida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxCadastrarTipoMedida.Name = "cbxCadastrarTipoMedida";
            this.cbxCadastrarTipoMedida.Size = new System.Drawing.Size(836, 33);
            this.cbxCadastrarTipoMedida.TabIndex = 7;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(891, 559);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(151, 43);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(1052, 124);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(151, 43);
            this.btnInserir.TabIndex = 9;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // lblAlunoObs
            // 
            this.lblAlunoObs.AutoSize = true;
            this.lblAlunoObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlunoObs.ForeColor = System.Drawing.Color.Black;
            this.lblAlunoObs.Location = new System.Drawing.Point(385, 818);
            this.lblAlunoObs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlunoObs.Name = "lblAlunoObs";
            this.lblAlunoObs.Size = new System.Drawing.Size(454, 25);
            this.lblAlunoObs.TabIndex = 2;
            this.lblAlunoObs.Text = "Obs: Os campos marcados com * são obrigatórios.";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Image = global::Apresentacao.Properties.Resources._1440735931_save1;
            this.btnFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinalizar.Location = new System.Drawing.Point(892, 28);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(167, 68);
            this.btnFinalizar.TabIndex = 3;
            this.btnFinalizar.Text = "Salvar";
            this.btnFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Apresentacao.Properties.Resources._1440735675_delete;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(1067, 28);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(167, 68);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pbxCadastrarTipoMedida
            // 
            this.pbxCadastrarTipoMedida.Image = global::Apresentacao.Properties.Resources._1440663403_add_property;
            this.pbxCadastrarTipoMedida.Location = new System.Drawing.Point(16, 15);
            this.pbxCadastrarTipoMedida.Margin = new System.Windows.Forms.Padding(4);
            this.pbxCadastrarTipoMedida.Name = "pbxCadastrarTipoMedida";
            this.pbxCadastrarTipoMedida.Size = new System.Drawing.Size(91, 81);
            this.pbxCadastrarTipoMedida.TabIndex = 99;
            this.pbxCadastrarTipoMedida.TabStop = false;
            // 
            // grpIMC
            // 
            this.grpIMC.Controls.Add(this.lblResultado);
            this.grpIMC.Controls.Add(this.txtIMC);
            this.grpIMC.Controls.Add(this.label3);
            this.grpIMC.Controls.Add(this.label2);
            this.grpIMC.Controls.Add(this.label1);
            this.grpIMC.Controls.Add(this.mskPeso);
            this.grpIMC.Controls.Add(this.mskAltura);
            this.grpIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpIMC.Location = new System.Drawing.Point(16, 103);
            this.grpIMC.Margin = new System.Windows.Forms.Padding(4);
            this.grpIMC.Name = "grpIMC";
            this.grpIMC.Padding = new System.Windows.Forms.Padding(4);
            this.grpIMC.Size = new System.Drawing.Size(1217, 92);
            this.grpIMC.TabIndex = 103;
            this.grpIMC.TabStop = false;
            this.grpIMC.Text = "IMC";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(812, 32);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(105, 25);
            this.lblResultado.TabIndex = 110;
            this.lblResultado.Text = "Resultado:";
            // 
            // txtIMC
            // 
            this.txtIMC.Location = new System.Drawing.Point(592, 27);
            this.txtIMC.Margin = new System.Windows.Forms.Padding(4);
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.Size = new System.Drawing.Size(132, 30);
            this.txtIMC.TabIndex = 109;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(539, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 108;
            this.label3.Text = "IMC: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(269, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 105;
            this.label2.Text = "*Peso:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 104;
            this.label1.Text = "*Altura:";
            // 
            // mskPeso
            // 
            this.mskPeso.Location = new System.Drawing.Point(351, 27);
            this.mskPeso.Margin = new System.Windows.Forms.Padding(4);
            this.mskPeso.Name = "mskPeso";
            this.mskPeso.Size = new System.Drawing.Size(164, 30);
            this.mskPeso.TabIndex = 103;
            this.mskPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskPeso.MouseLeave += new System.EventHandler(this.maskedTextBox2_MouseLeave);
            // 
            // mskAltura
            // 
            this.mskAltura.Location = new System.Drawing.Point(97, 27);
            this.mskAltura.Margin = new System.Windows.Forms.Padding(4);
            this.mskAltura.Name = "mskAltura";
            this.mskAltura.Size = new System.Drawing.Size(164, 30);
            this.mskAltura.TabIndex = 102;
            this.mskAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskAltura.MouseLeave += new System.EventHandler(this.mskAltura_MouseLeave);
            // 
            // FrmMedidaCorporalCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1249, 853);
            this.ControlBox = false;
            this.Controls.Add(this.grpIMC);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.lblAlunoObs);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pbxCadastrarTipoMedida);
            this.Controls.Add(this.grpFichaMedidaCorporal);
            this.Controls.Add(this.lblCadastrarTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMedidaCorporalCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Medida Corporal";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMedidaCorporalCadastrar_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMedidaCorporal)).EndInit();
            this.grpFichaMedidaCorporal.ResumeLayout(false);
            this.grpFichaMedidaCorporal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCadastrarTipoMedida)).EndInit();
            this.grpIMC.ResumeLayout(false);
            this.grpIMC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadastrarTitulo;
        private System.Windows.Forms.PictureBox pbxCadastrarTipoMedida;
        private System.Windows.Forms.Label lblCadastrarTipoMedida;
        private System.Windows.Forms.Label lblMedidasCorporal;
        private System.Windows.Forms.TextBox txtCadastrarQuantidadeMedidas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCadastrarDataNascimento;
        private System.Windows.Forms.DateTimePicker dtpCadastrarDataMedida;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.GroupBox grpFichaMedidaCorporal;
        private System.Windows.Forms.ComboBox cbxCadastrarTipoMedida;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.ToolTip ttpCadastrarMedida;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label lblAlunoObs;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.DataGridView dgwMedidaCorporal;
        private System.Windows.Forms.TextBox txtCadastrarAluno;
        private System.Windows.Forms.TextBox txtCodigoAluno;
        private System.Windows.Forms.ListBox listBoxSelecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn collIDMedidaCorporal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Series;
        private System.Windows.Forms.DataGridViewTextBoxColumn collDataMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn collAtivo;
        private System.Windows.Forms.GroupBox grpIMC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskPeso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCadastrarCentimetro;
        private System.Windows.Forms.TextBox txtIMC;
        private System.Windows.Forms.MaskedTextBox mskAltura;
        private System.Windows.Forms.Label lblResultado;
    }
}