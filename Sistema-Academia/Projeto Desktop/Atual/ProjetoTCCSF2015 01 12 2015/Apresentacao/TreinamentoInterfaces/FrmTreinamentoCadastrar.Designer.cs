namespace Apresentacao.TreinamentoInterfaces
{
    partial class FrmTreinamentoCadastrar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblAlunoObs = new System.Windows.Forms.Label();
            this.ttpCadastrarMedida = new System.Windows.Forms.ToolTip(this.components);
            this.txtCodigoAluno = new System.Windows.Forms.TextBox();
            this.txtCadastrarAluno = new System.Windows.Forms.TextBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.cbxCadastrarExercicio = new System.Windows.Forms.ComboBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.grpFichaTreinamento = new System.Windows.Forms.GroupBox();
            this.mskCadastrarIntervalo = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCadastrarSeries = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCadastrarQuantidadeExercicios = new System.Windows.Forms.TextBox();
            this.dgwTreinamentoExercicios = new System.Windows.Forms.DataGridView();
            this.collIDMedidaCorporal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Series = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collDataMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIntervalo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCadastrarRepeticoes = new System.Windows.Forms.TextBox();
            this.lblMedidasCorporal = new System.Windows.Forms.Label();
            this.lblCadastrarTipoMedida = new System.Windows.Forms.Label();
            this.dtpCadastrarDataTreinamento = new System.Windows.Forms.DateTimePicker();
            this.lblCadastrarDataNascimento = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCadastrarTitulo = new System.Windows.Forms.Label();
            this.grpTreinamentoFisico = new System.Windows.Forms.GroupBox();
            this.grpBoxAtivo = new System.Windows.Forms.GroupBox();
            this.rbtCadastrarAtivoNao = new System.Windows.Forms.RadioButton();
            this.rbtCadastrarAtivoSim = new System.Windows.Forms.RadioButton();
            this.txtCadastrarTreinamentoCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMostrarObjetivo = new System.Windows.Forms.TextBox();
            this.cbxCadastrarTipoTreinamento = new System.Windows.Forms.ComboBox();
            this.btnCadastrarTreinamento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.pbxCadastrarTreinamento = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpFichaTreinamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTreinamentoExercicios)).BeginInit();
            this.grpTreinamentoFisico.SuspendLayout();
            this.grpBoxAtivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCadastrarTreinamento)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAlunoObs
            // 
            this.lblAlunoObs.AutoSize = true;
            this.lblAlunoObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlunoObs.ForeColor = System.Drawing.Color.Black;
            this.lblAlunoObs.Location = new System.Drawing.Point(381, 811);
            this.lblAlunoObs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlunoObs.Name = "lblAlunoObs";
            this.lblAlunoObs.Size = new System.Drawing.Size(454, 25);
            this.lblAlunoObs.TabIndex = 3;
            this.lblAlunoObs.Text = "Obs: Os campos marcados com * são obrigatórios.";
            // 
            // txtCodigoAluno
            // 
            this.txtCodigoAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoAluno.Location = new System.Drawing.Point(16, 52);
            this.txtCodigoAluno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoAluno.Name = "txtCodigoAluno";
            this.txtCodigoAluno.ReadOnly = true;
            this.txtCodigoAluno.Size = new System.Drawing.Size(67, 30);
            this.txtCodigoAluno.TabIndex = 1;
            this.txtCodigoAluno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCadastrarAluno
            // 
            this.txtCadastrarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastrarAluno.Location = new System.Drawing.Point(89, 52);
            this.txtCadastrarAluno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCadastrarAluno.Name = "txtCadastrarAluno";
            this.txtCadastrarAluno.ReadOnly = true;
            this.txtCadastrarAluno.Size = new System.Drawing.Size(603, 30);
            this.txtCadastrarAluno.TabIndex = 2;
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(1052, 479);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(151, 43);
            this.btnRemover.TabIndex = 11;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // cbxCadastrarExercicio
            // 
            this.cbxCadastrarExercicio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxCadastrarExercicio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCadastrarExercicio.FormattingEnabled = true;
            this.cbxCadastrarExercicio.Location = new System.Drawing.Point(16, 59);
            this.cbxCadastrarExercicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxCadastrarExercicio.Name = "cbxCadastrarExercicio";
            this.cbxCadastrarExercicio.Size = new System.Drawing.Size(577, 33);
            this.cbxCadastrarExercicio.TabIndex = 1;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(893, 479);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(151, 43);
            this.btnAlterar.TabIndex = 10;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(1052, 53);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(151, 43);
            this.btnInserir.TabIndex = 6;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // grpFichaTreinamento
            // 
            this.grpFichaTreinamento.Controls.Add(this.mskCadastrarIntervalo);
            this.grpFichaTreinamento.Controls.Add(this.label4);
            this.grpFichaTreinamento.Controls.Add(this.listBox1);
            this.grpFichaTreinamento.Controls.Add(this.label2);
            this.grpFichaTreinamento.Controls.Add(this.txtCadastrarSeries);
            this.grpFichaTreinamento.Controls.Add(this.btnRemover);
            this.grpFichaTreinamento.Controls.Add(this.cbxCadastrarExercicio);
            this.grpFichaTreinamento.Controls.Add(this.btnAlterar);
            this.grpFichaTreinamento.Controls.Add(this.btnInserir);
            this.grpFichaTreinamento.Controls.Add(this.label10);
            this.grpFichaTreinamento.Controls.Add(this.txtCadastrarQuantidadeExercicios);
            this.grpFichaTreinamento.Controls.Add(this.dgwTreinamentoExercicios);
            this.grpFichaTreinamento.Controls.Add(this.txtCadastrarRepeticoes);
            this.grpFichaTreinamento.Controls.Add(this.lblMedidasCorporal);
            this.grpFichaTreinamento.Controls.Add(this.lblCadastrarTipoMedida);
            this.grpFichaTreinamento.Enabled = false;
            this.grpFichaTreinamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFichaTreinamento.Location = new System.Drawing.Point(16, 274);
            this.grpFichaTreinamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpFichaTreinamento.Name = "grpFichaTreinamento";
            this.grpFichaTreinamento.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpFichaTreinamento.Size = new System.Drawing.Size(1217, 532);
            this.grpFichaTreinamento.TabIndex = 2;
            this.grpFichaTreinamento.TabStop = false;
            this.grpFichaTreinamento.Text = "Ficha De Treinamento Físico";
            // 
            // mskCadastrarIntervalo
            // 
            this.mskCadastrarIntervalo.Location = new System.Drawing.Point(899, 59);
            this.mskCadastrarIntervalo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskCadastrarIntervalo.Mask = "00:00:00";
            this.mskCadastrarIntervalo.Name = "mskCadastrarIntervalo";
            this.mskCadastrarIntervalo.Size = new System.Drawing.Size(145, 30);
            this.mskCadastrarIntervalo.TabIndex = 103;
            this.mskCadastrarIntervalo.Text = "000000";
            this.mskCadastrarIntervalo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(895, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 102;
            this.label4.Text = "*Intervalo";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBox1.Enabled = false;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Items.AddRange(new object[] {
            "F1: Inserir - F2: Alterar - F3: Remover"});
            this.listBox1.Location = new System.Drawing.Point(209, 486);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(363, 29);
            this.listBox1.TabIndex = 101;
            this.listBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(743, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "*Repetições";
            // 
            // txtCadastrarSeries
            // 
            this.txtCadastrarSeries.AccessibleDescription = "";
            this.txtCadastrarSeries.AccessibleName = "";
            this.txtCadastrarSeries.Location = new System.Drawing.Point(601, 59);
            this.txtCadastrarSeries.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCadastrarSeries.MaxLength = 2;
            this.txtCadastrarSeries.Name = "txtCadastrarSeries";
            this.txtCadastrarSeries.Size = new System.Drawing.Size(139, 30);
            this.txtCadastrarSeries.TabIndex = 3;
            this.txtCadastrarSeries.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(596, 30);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "*Series";
            // 
            // txtCadastrarQuantidadeExercicios
            // 
            this.txtCadastrarQuantidadeExercicios.Location = new System.Drawing.Point(131, 484);
            this.txtCadastrarQuantidadeExercicios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCadastrarQuantidadeExercicios.Name = "txtCadastrarQuantidadeExercicios";
            this.txtCadastrarQuantidadeExercicios.ReadOnly = true;
            this.txtCadastrarQuantidadeExercicios.Size = new System.Drawing.Size(69, 30);
            this.txtCadastrarQuantidadeExercicios.TabIndex = 9;
            this.txtCadastrarQuantidadeExercicios.TabStop = false;
            this.txtCadastrarQuantidadeExercicios.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgwTreinamentoExercicios
            // 
            this.dgwTreinamentoExercicios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgwTreinamentoExercicios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwTreinamentoExercicios.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwTreinamentoExercicios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwTreinamentoExercicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwTreinamentoExercicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTreinamentoExercicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.collIDMedidaCorporal,
            this.Nome,
            this.Series,
            this.collDataMedida,
            this.colIntervalo});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwTreinamentoExercicios.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgwTreinamentoExercicios.Location = new System.Drawing.Point(16, 105);
            this.dgwTreinamentoExercicios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgwTreinamentoExercicios.MultiSelect = false;
            this.dgwTreinamentoExercicios.Name = "dgwTreinamentoExercicios";
            this.dgwTreinamentoExercicios.ReadOnly = true;
            this.dgwTreinamentoExercicios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwTreinamentoExercicios.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgwTreinamentoExercicios.RowHeadersVisible = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgwTreinamentoExercicios.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgwTreinamentoExercicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwTreinamentoExercicios.Size = new System.Drawing.Size(1187, 367);
            this.dgwTreinamentoExercicios.TabIndex = 7;
            this.dgwTreinamentoExercicios.TabStop = false;
            this.dgwTreinamentoExercicios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgwTreinamentoExercicios_CellFormatting);
            this.dgwTreinamentoExercicios.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwTreinamentoExercicios_CellMouseDoubleClick);
            // 
            // collIDMedidaCorporal
            // 
            this.collIDMedidaCorporal.DataPropertyName = "Treinamento";
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
            // Nome
            // 
            this.Nome.DataPropertyName = "Exercicio";
            this.Nome.HeaderText = "Exercício";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 402;
            // 
            // Series
            // 
            this.Series.DataPropertyName = "Series";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Series.DefaultCellStyle = dataGridViewCellStyle4;
            this.Series.HeaderText = "Series";
            this.Series.Name = "Series";
            this.Series.ReadOnly = true;
            this.Series.Width = 129;
            // 
            // collDataMedida
            // 
            this.collDataMedida.DataPropertyName = "Repeticoes";
            this.collDataMedida.HeaderText = "Repetições";
            this.collDataMedida.Name = "collDataMedida";
            this.collDataMedida.ReadOnly = true;
            this.collDataMedida.Width = 129;
            // 
            // colIntervalo
            // 
            this.colIntervalo.DataPropertyName = "Intervalo";
            this.colIntervalo.HeaderText = "Intervalo";
            this.colIntervalo.Name = "colIntervalo";
            this.colIntervalo.ReadOnly = true;
            this.colIntervalo.Width = 129;
            // 
            // txtCadastrarRepeticoes
            // 
            this.txtCadastrarRepeticoes.Location = new System.Drawing.Point(748, 59);
            this.txtCadastrarRepeticoes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCadastrarRepeticoes.MaxLength = 3;
            this.txtCadastrarRepeticoes.Name = "txtCadastrarRepeticoes";
            this.txtCadastrarRepeticoes.Size = new System.Drawing.Size(144, 30);
            this.txtCadastrarRepeticoes.TabIndex = 5;
            this.txtCadastrarRepeticoes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMedidasCorporal
            // 
            this.lblMedidasCorporal.AutoSize = true;
            this.lblMedidasCorporal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedidasCorporal.ForeColor = System.Drawing.Color.Black;
            this.lblMedidasCorporal.Location = new System.Drawing.Point(11, 487);
            this.lblMedidasCorporal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedidasCorporal.Name = "lblMedidasCorporal";
            this.lblMedidasCorporal.Size = new System.Drawing.Size(107, 25);
            this.lblMedidasCorporal.TabIndex = 8;
            this.lblMedidasCorporal.Text = "Exercícios:";
            // 
            // lblCadastrarTipoMedida
            // 
            this.lblCadastrarTipoMedida.AutoSize = true;
            this.lblCadastrarTipoMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarTipoMedida.ForeColor = System.Drawing.Color.Black;
            this.lblCadastrarTipoMedida.Location = new System.Drawing.Point(11, 32);
            this.lblCadastrarTipoMedida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastrarTipoMedida.Name = "lblCadastrarTipoMedida";
            this.lblCadastrarTipoMedida.Size = new System.Drawing.Size(109, 25);
            this.lblCadastrarTipoMedida.TabIndex = 0;
            this.lblCadastrarTipoMedida.Text = "*Exercícios";
            // 
            // dtpCadastrarDataTreinamento
            // 
            this.dtpCadastrarDataTreinamento.Enabled = false;
            this.dtpCadastrarDataTreinamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCadastrarDataTreinamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCadastrarDataTreinamento.Location = new System.Drawing.Point(1051, 49);
            this.dtpCadastrarDataTreinamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpCadastrarDataTreinamento.Name = "dtpCadastrarDataTreinamento";
            this.dtpCadastrarDataTreinamento.Size = new System.Drawing.Size(157, 30);
            this.dtpCadastrarDataTreinamento.TabIndex = 6;
            // 
            // lblCadastrarDataNascimento
            // 
            this.lblCadastrarDataNascimento.AutoSize = true;
            this.lblCadastrarDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarDataNascimento.ForeColor = System.Drawing.Color.Black;
            this.lblCadastrarDataNascimento.Location = new System.Drawing.Point(1045, 21);
            this.lblCadastrarDataNascimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastrarDataNascimento.Name = "lblCadastrarDataNascimento";
            this.lblCadastrarDataNascimento.Size = new System.Drawing.Size(61, 25);
            this.lblCadastrarDataNascimento.TabIndex = 5;
            this.lblCadastrarDataNascimento.Text = "*Data";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(9, 23);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "*Aluno";
            // 
            // lblCadastrarTitulo
            // 
            this.lblCadastrarTitulo.AutoSize = true;
            this.lblCadastrarTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblCadastrarTitulo.Location = new System.Drawing.Point(115, 10);
            this.lblCadastrarTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastrarTitulo.Name = "lblCadastrarTitulo";
            this.lblCadastrarTitulo.Size = new System.Drawing.Size(475, 38);
            this.lblCadastrarTitulo.TabIndex = 0;
            this.lblCadastrarTitulo.Text = "Cadastrar Treinamento Físico";
            // 
            // grpTreinamentoFisico
            // 
            this.grpTreinamentoFisico.Controls.Add(this.grpBoxAtivo);
            this.grpTreinamentoFisico.Controls.Add(this.txtCadastrarTreinamentoCodigo);
            this.grpTreinamentoFisico.Controls.Add(this.label3);
            this.grpTreinamentoFisico.Controls.Add(this.txtMostrarObjetivo);
            this.grpTreinamentoFisico.Controls.Add(this.cbxCadastrarTipoTreinamento);
            this.grpTreinamentoFisico.Controls.Add(this.btnCadastrarTreinamento);
            this.grpTreinamentoFisico.Controls.Add(this.label1);
            this.grpTreinamentoFisico.Controls.Add(this.txtCodigoAluno);
            this.grpTreinamentoFisico.Controls.Add(this.label11);
            this.grpTreinamentoFisico.Controls.Add(this.txtCadastrarAluno);
            this.grpTreinamentoFisico.Controls.Add(this.lblCadastrarDataNascimento);
            this.grpTreinamentoFisico.Controls.Add(this.dtpCadastrarDataTreinamento);
            this.grpTreinamentoFisico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTreinamentoFisico.Location = new System.Drawing.Point(16, 98);
            this.grpTreinamentoFisico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpTreinamentoFisico.Name = "grpTreinamentoFisico";
            this.grpTreinamentoFisico.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpTreinamentoFisico.Size = new System.Drawing.Size(1217, 169);
            this.grpTreinamentoFisico.TabIndex = 1;
            this.grpTreinamentoFisico.TabStop = false;
            this.grpTreinamentoFisico.Text = "Treinamento";
            // 
            // grpBoxAtivo
            // 
            this.grpBoxAtivo.Controls.Add(this.rbtCadastrarAtivoNao);
            this.grpBoxAtivo.Controls.Add(this.rbtCadastrarAtivoSim);
            this.grpBoxAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxAtivo.Location = new System.Drawing.Point(900, 96);
            this.grpBoxAtivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBoxAtivo.Name = "grpBoxAtivo";
            this.grpBoxAtivo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBoxAtivo.Size = new System.Drawing.Size(136, 60);
            this.grpBoxAtivo.TabIndex = 12;
            this.grpBoxAtivo.TabStop = false;
            this.grpBoxAtivo.Text = "*Ativo";
            // 
            // rbtCadastrarAtivoNao
            // 
            this.rbtCadastrarAtivoNao.AutoSize = true;
            this.rbtCadastrarAtivoNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtCadastrarAtivoNao.Location = new System.Drawing.Point(72, 28);
            this.rbtCadastrarAtivoNao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.rbtCadastrarAtivoSim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtCadastrarAtivoSim.Name = "rbtCadastrarAtivoSim";
            this.rbtCadastrarAtivoSim.Size = new System.Drawing.Size(52, 21);
            this.rbtCadastrarAtivoSim.TabIndex = 0;
            this.rbtCadastrarAtivoSim.TabStop = true;
            this.rbtCadastrarAtivoSim.Text = "Sim";
            this.rbtCadastrarAtivoSim.UseVisualStyleBackColor = true;
            // 
            // txtCadastrarTreinamentoCodigo
            // 
            this.txtCadastrarTreinamentoCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastrarTreinamentoCodigo.Location = new System.Drawing.Point(16, 122);
            this.txtCadastrarTreinamentoCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCadastrarTreinamentoCodigo.Name = "txtCadastrarTreinamentoCodigo";
            this.txtCadastrarTreinamentoCodigo.ReadOnly = true;
            this.txtCadastrarTreinamentoCodigo.Size = new System.Drawing.Size(67, 30);
            this.txtCadastrarTreinamentoCodigo.TabIndex = 8;
            this.txtCadastrarTreinamentoCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(693, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Objetivo";
            // 
            // txtMostrarObjetivo
            // 
            this.txtMostrarObjetivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMostrarObjetivo.Location = new System.Drawing.Point(699, 52);
            this.txtMostrarObjetivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMostrarObjetivo.Name = "txtMostrarObjetivo";
            this.txtMostrarObjetivo.ReadOnly = true;
            this.txtMostrarObjetivo.Size = new System.Drawing.Size(336, 30);
            this.txtMostrarObjetivo.TabIndex = 4;
            // 
            // cbxCadastrarTipoTreinamento
            // 
            this.cbxCadastrarTipoTreinamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxCadastrarTipoTreinamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCadastrarTipoTreinamento.FormattingEnabled = true;
            this.cbxCadastrarTipoTreinamento.Location = new System.Drawing.Point(89, 119);
            this.cbxCadastrarTipoTreinamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxCadastrarTipoTreinamento.Name = "cbxCadastrarTipoTreinamento";
            this.cbxCadastrarTipoTreinamento.Size = new System.Drawing.Size(801, 33);
            this.cbxCadastrarTipoTreinamento.TabIndex = 9;
            // 
            // btnCadastrarTreinamento
            // 
            this.btnCadastrarTreinamento.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrarTreinamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarTreinamento.Location = new System.Drawing.Point(1049, 113);
            this.btnCadastrarTreinamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCadastrarTreinamento.Name = "btnCadastrarTreinamento";
            this.btnCadastrarTreinamento.Size = new System.Drawing.Size(159, 43);
            this.btnCadastrarTreinamento.TabIndex = 10;
            this.btnCadastrarTreinamento.Text = "Cadastrar";
            this.btnCadastrarTreinamento.UseVisualStyleBackColor = false;
            this.btnCadastrarTreinamento.Click += new System.EventHandler(this.btnCadastrarTreinamento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "*Descrição";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Image = global::Apresentacao.Properties.Resources._1440735931_save1;
            this.btnFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinalizar.Location = new System.Drawing.Point(892, 23);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(167, 68);
            this.btnFinalizar.TabIndex = 4;
            this.btnFinalizar.Text = "Salvar";
            this.btnFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // pbxCadastrarTreinamento
            // 
            this.pbxCadastrarTreinamento.Image = global::Apresentacao.Properties.Resources._1440663403_add_property;
            this.pbxCadastrarTreinamento.Location = new System.Drawing.Point(16, 10);
            this.pbxCadastrarTreinamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxCadastrarTreinamento.Name = "pbxCadastrarTreinamento";
            this.pbxCadastrarTreinamento.Size = new System.Drawing.Size(91, 81);
            this.pbxCadastrarTreinamento.TabIndex = 105;
            this.pbxCadastrarTreinamento.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Apresentacao.Properties.Resources._1440735675_delete;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(1067, 23);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(167, 68);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmTreinamentoCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1249, 849);
            this.ControlBox = false;
            this.Controls.Add(this.grpTreinamentoFisico);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.lblAlunoObs);
            this.Controls.Add(this.pbxCadastrarTreinamento);
            this.Controls.Add(this.grpFichaTreinamento);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblCadastrarTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTreinamentoCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Treinamento Físico";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTreinamentoCadastrar_KeyDown);
            this.grpFichaTreinamento.ResumeLayout(false);
            this.grpFichaTreinamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTreinamentoExercicios)).EndInit();
            this.grpTreinamentoFisico.ResumeLayout(false);
            this.grpTreinamentoFisico.PerformLayout();
            this.grpBoxAtivo.ResumeLayout(false);
            this.grpBoxAtivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCadastrarTreinamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lblAlunoObs;
        private System.Windows.Forms.PictureBox pbxCadastrarTreinamento;
        private System.Windows.Forms.ToolTip ttpCadastrarMedida;
        private System.Windows.Forms.TextBox txtCodigoAluno;
        private System.Windows.Forms.TextBox txtCadastrarAluno;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.ComboBox cbxCadastrarExercicio;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.GroupBox grpFichaTreinamento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCadastrarQuantidadeExercicios;
        private System.Windows.Forms.DataGridView dgwTreinamentoExercicios;
        private System.Windows.Forms.TextBox txtCadastrarRepeticoes;
        private System.Windows.Forms.Label lblMedidasCorporal;
        private System.Windows.Forms.Label lblCadastrarTipoMedida;
        private System.Windows.Forms.DateTimePicker dtpCadastrarDataTreinamento;
        private System.Windows.Forms.Label lblCadastrarDataNascimento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCadastrarTitulo;
        private System.Windows.Forms.GroupBox grpTreinamentoFisico;
        private System.Windows.Forms.Button btnCadastrarTreinamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCadastrarSeries;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCadastrarTipoTreinamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMostrarObjetivo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskCadastrarIntervalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn collIDMedidaCorporal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Series;
        private System.Windows.Forms.DataGridViewTextBoxColumn collDataMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIntervalo;
        private System.Windows.Forms.TextBox txtCadastrarTreinamentoCodigo;
        private System.Windows.Forms.GroupBox grpBoxAtivo;
        private System.Windows.Forms.RadioButton rbtCadastrarAtivoNao;
        private System.Windows.Forms.RadioButton rbtCadastrarAtivoSim;
    }
}