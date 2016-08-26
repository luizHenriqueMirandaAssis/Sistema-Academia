namespace Apresentacao.Relatórios
{
    partial class FrmRelatorioEquipamento
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tblEquipamentoBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.tCCSF2015DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tCCSF2015DataSet = new Apresentacao.TCCSF2015DataSet();
            this.tblEquipamentoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tCCSF2015PC1DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tCCSF2015PC1DataSet1 = new Apresentacao.TCCSF2015PC1DataSet1();
            this.tblEquipamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtRelatorioFiltroNome = new System.Windows.Forms.TextBox();
            this.btnRelatorioExecutar = new System.Windows.Forms.Button();
            this.grpRelatorioEquipamento = new System.Windows.Forms.GroupBox();
            this.pbxRelatorio = new System.Windows.Forms.PictureBox();
            this.lblRelatorioFiltroNome = new System.Windows.Forms.Label();
            this.rpvEquipamento = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblEquipamentoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblEquipamentoTableAdapter = new Apresentacao.TCCSF2015DataSetTableAdapters.tblEquipamentoTableAdapter();
            this.tblEquipamentoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblEquipamentoTableAdapter1 = new Apresentacao.TCCSF2015PC1DataSet1TableAdapters.tblEquipamentoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblEquipamentoBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCCSF2015DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCCSF2015DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEquipamentoBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCCSF2015PC1DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCCSF2015PC1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEquipamentoBindingSource)).BeginInit();
            this.grpRelatorioEquipamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRelatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEquipamentoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEquipamentoBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // tblEquipamentoBindingSource4
            // 
            this.tblEquipamentoBindingSource4.DataMember = "tblEquipamento";
            this.tblEquipamentoBindingSource4.DataSource = this.tCCSF2015DataSetBindingSource;
            // 
            // tCCSF2015DataSetBindingSource
            // 
            this.tCCSF2015DataSetBindingSource.DataSource = this.tCCSF2015DataSet;
            this.tCCSF2015DataSetBindingSource.Position = 0;
            // 
            // tCCSF2015DataSet
            // 
            this.tCCSF2015DataSet.DataSetName = "TCCSF2015DataSet";
            this.tCCSF2015DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblEquipamentoBindingSource3
            // 
            this.tblEquipamentoBindingSource3.DataMember = "tblEquipamento";
            this.tblEquipamentoBindingSource3.DataSource = this.tCCSF2015PC1DataSet1BindingSource;
            // 
            // tCCSF2015PC1DataSet1BindingSource
            // 
            this.tCCSF2015PC1DataSet1BindingSource.DataSource = this.tCCSF2015PC1DataSet1;
            this.tCCSF2015PC1DataSet1BindingSource.Position = 0;
            // 
            // tCCSF2015PC1DataSet1
            // 
            this.tCCSF2015PC1DataSet1.DataSetName = "TCCSF2015PC1DataSet1";
            this.tCCSF2015PC1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblEquipamentoBindingSource
            // 
            this.tblEquipamentoBindingSource.DataMember = "tblEquipamento";
            this.tblEquipamentoBindingSource.DataSource = this.tCCSF2015DataSetBindingSource;
            // 
            // txtRelatorioFiltroNome
            // 
            this.txtRelatorioFiltroNome.Location = new System.Drawing.Point(105, 54);
            this.txtRelatorioFiltroNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRelatorioFiltroNome.Name = "txtRelatorioFiltroNome";
            this.txtRelatorioFiltroNome.Size = new System.Drawing.Size(551, 30);
            this.txtRelatorioFiltroNome.TabIndex = 0;
            // 
            // btnRelatorioExecutar
            // 
            this.btnRelatorioExecutar.AutoSize = true;
            this.btnRelatorioExecutar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRelatorioExecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorioExecutar.Location = new System.Drawing.Point(663, 52);
            this.btnRelatorioExecutar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRelatorioExecutar.Name = "btnRelatorioExecutar";
            this.btnRelatorioExecutar.Size = new System.Drawing.Size(143, 43);
            this.btnRelatorioExecutar.TabIndex = 1;
            this.btnRelatorioExecutar.Text = "Executar";
            this.btnRelatorioExecutar.UseVisualStyleBackColor = false;
            this.btnRelatorioExecutar.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpRelatorioEquipamento
            // 
            this.grpRelatorioEquipamento.Controls.Add(this.pbxRelatorio);
            this.grpRelatorioEquipamento.Controls.Add(this.lblRelatorioFiltroNome);
            this.grpRelatorioEquipamento.Controls.Add(this.txtRelatorioFiltroNome);
            this.grpRelatorioEquipamento.Controls.Add(this.btnRelatorioExecutar);
            this.grpRelatorioEquipamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRelatorioEquipamento.Location = new System.Drawing.Point(11, 15);
            this.grpRelatorioEquipamento.Margin = new System.Windows.Forms.Padding(4);
            this.grpRelatorioEquipamento.Name = "grpRelatorioEquipamento";
            this.grpRelatorioEquipamento.Padding = new System.Windows.Forms.Padding(4);
            this.grpRelatorioEquipamento.Size = new System.Drawing.Size(812, 114);
            this.grpRelatorioEquipamento.TabIndex = 3;
            this.grpRelatorioEquipamento.TabStop = false;
            this.grpRelatorioEquipamento.Text = "Relatório de equipamento";
            // 
            // pbxRelatorio
            // 
            this.pbxRelatorio.Image = global::Apresentacao.Properties.Resources._1440737483_exercise_3D2;
            this.pbxRelatorio.Location = new System.Drawing.Point(8, 31);
            this.pbxRelatorio.Margin = new System.Windows.Forms.Padding(4);
            this.pbxRelatorio.Name = "pbxRelatorio";
            this.pbxRelatorio.Size = new System.Drawing.Size(87, 60);
            this.pbxRelatorio.TabIndex = 2;
            this.pbxRelatorio.TabStop = false;
            // 
            // lblRelatorioFiltroNome
            // 
            this.lblRelatorioFiltroNome.AutoSize = true;
            this.lblRelatorioFiltroNome.Location = new System.Drawing.Point(103, 27);
            this.lblRelatorioFiltroNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRelatorioFiltroNome.Name = "lblRelatorioFiltroNome";
            this.lblRelatorioFiltroNome.Size = new System.Drawing.Size(64, 25);
            this.lblRelatorioFiltroNome.TabIndex = 1;
            this.lblRelatorioFiltroNome.Text = "Nome";
            // 
            // rpvEquipamento
            // 
            this.rpvEquipamento.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rpvEquipamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rpvEquipamento.DocumentMapWidth = 30;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblEquipamentoBindingSource4;
            this.rpvEquipamento.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvEquipamento.LocalReport.ReportEmbeddedResource = "Apresentacao.Relatórios.repRelatorioEquipamentoDELL.rdlc";
            this.rpvEquipamento.Location = new System.Drawing.Point(11, 135);
            this.rpvEquipamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rpvEquipamento.Name = "rpvEquipamento";
            this.rpvEquipamento.Size = new System.Drawing.Size(812, 665);
            this.rpvEquipamento.TabIndex = 2;
            // 
            // tblEquipamentoBindingSource1
            // 
            this.tblEquipamentoBindingSource1.DataMember = "tblEquipamento";
            this.tblEquipamentoBindingSource1.DataSource = this.tCCSF2015DataSetBindingSource;
            // 
            // tblEquipamentoTableAdapter
            // 
            this.tblEquipamentoTableAdapter.ClearBeforeFill = true;
            // 
            // tblEquipamentoBindingSource2
            // 
            this.tblEquipamentoBindingSource2.DataMember = "tblEquipamento";
            this.tblEquipamentoBindingSource2.DataSource = this.tCCSF2015PC1DataSet1BindingSource;
            // 
            // tblEquipamentoTableAdapter1
            // 
            this.tblEquipamentoTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmRelatorioEquipamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(836, 815);
            this.Controls.Add(this.grpRelatorioEquipamento);
            this.Controls.Add(this.rpvEquipamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmRelatorioEquipamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de equipamento";
            this.Load += new System.EventHandler(this.FrmRelatorioEquipamento_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmRelatorioEquipamento_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tblEquipamentoBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCCSF2015DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCCSF2015DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEquipamentoBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCCSF2015PC1DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCCSF2015PC1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEquipamentoBindingSource)).EndInit();
            this.grpRelatorioEquipamento.ResumeLayout(false);
            this.grpRelatorioEquipamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRelatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEquipamentoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEquipamentoBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtRelatorioFiltroNome;
        private System.Windows.Forms.Button btnRelatorioExecutar;
        private System.Windows.Forms.BindingSource tCCSF2015DataSetBindingSource;
        private TCCSF2015DataSet tCCSF2015DataSet;
        private System.Windows.Forms.BindingSource tblEquipamentoBindingSource;
        private TCCSF2015DataSetTableAdapters.tblEquipamentoTableAdapter tblEquipamentoTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rpvEquipamento;
        private System.Windows.Forms.GroupBox grpRelatorioEquipamento;
        private System.Windows.Forms.Label lblRelatorioFiltroNome;
        private System.Windows.Forms.BindingSource tblEquipamentoBindingSource1;
        private TCCSF2015PC1DataSet1 tCCSF2015PC1DataSet1;
        private System.Windows.Forms.BindingSource tCCSF2015PC1DataSet1BindingSource;
        private System.Windows.Forms.BindingSource tblEquipamentoBindingSource2;
        private TCCSF2015PC1DataSet1TableAdapters.tblEquipamentoTableAdapter tblEquipamentoTableAdapter1;
        private System.Windows.Forms.BindingSource tblEquipamentoBindingSource3;
        private System.Windows.Forms.PictureBox pbxRelatorio;
        private System.Windows.Forms.BindingSource tblEquipamentoBindingSource4;
    }
}