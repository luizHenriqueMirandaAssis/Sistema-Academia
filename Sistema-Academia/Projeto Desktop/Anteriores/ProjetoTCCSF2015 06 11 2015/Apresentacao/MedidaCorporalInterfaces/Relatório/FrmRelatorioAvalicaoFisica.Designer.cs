namespace Apresentacao.MedidaCorporalInterfaces.Relatório
{
    partial class FrmRelatorioAvalicaoFisica
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.uspMedidaCorporalRelatorioDataInicialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tCCSF2015DataSet1 = new Apresentacao.TCCSF2015DataSet1();
            this.uspMedidaCorporalRelatorioDataFinalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uspMedidaCorporalListaAlunoDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tCCSF2015DataSet = new Apresentacao.TCCSF2015DataSet();
            this.rpvAvaliacoesFisicas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.uspMedidaCorporalListaAlunoDataTableAdapter = new Apresentacao.TCCSF2015DataSetTableAdapters.uspMedidaCorporalListaAlunoDataTableAdapter();
            this.uspMedidaCorporalRelatorioDataInicialTableAdapter = new Apresentacao.TCCSF2015DataSet1TableAdapters.uspMedidaCorporalRelatorioDataInicialTableAdapter();
            this.uspMedidaCorporalRelatorioDataFinalTableAdapter = new Apresentacao.TCCSF2015DataSet1TableAdapters.uspMedidaCorporalRelatorioDataFinalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uspMedidaCorporalRelatorioDataInicialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCCSF2015DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspMedidaCorporalRelatorioDataFinalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspMedidaCorporalListaAlunoDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCCSF2015DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // uspMedidaCorporalRelatorioDataInicialBindingSource
            // 
            this.uspMedidaCorporalRelatorioDataInicialBindingSource.DataMember = "uspMedidaCorporalRelatorioDataInicial";
            this.uspMedidaCorporalRelatorioDataInicialBindingSource.DataSource = this.tCCSF2015DataSet1;
            // 
            // tCCSF2015DataSet1
            // 
            this.tCCSF2015DataSet1.DataSetName = "TCCSF2015DataSet1";
            this.tCCSF2015DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uspMedidaCorporalRelatorioDataFinalBindingSource
            // 
            this.uspMedidaCorporalRelatorioDataFinalBindingSource.DataMember = "uspMedidaCorporalRelatorioDataFinal";
            this.uspMedidaCorporalRelatorioDataFinalBindingSource.DataSource = this.tCCSF2015DataSet1;
            // 
            // uspMedidaCorporalListaAlunoDataBindingSource
            // 
            this.uspMedidaCorporalListaAlunoDataBindingSource.DataMember = "uspMedidaCorporalListaAlunoData";
            this.uspMedidaCorporalListaAlunoDataBindingSource.DataSource = this.tCCSF2015DataSet;
            // 
            // tCCSF2015DataSet
            // 
            this.tCCSF2015DataSet.DataSetName = "TCCSF2015DataSet";
            this.tCCSF2015DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvAvaliacoesFisicas
            // 
            this.rpvAvaliacoesFisicas.DocumentMapWidth = 25;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.uspMedidaCorporalRelatorioDataInicialBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.uspMedidaCorporalRelatorioDataFinalBindingSource;
            this.rpvAvaliacoesFisicas.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvAvaliacoesFisicas.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvAvaliacoesFisicas.LocalReport.ReportEmbeddedResource = "Apresentacao.MedidaCorporalInterfaces.Relatório.RepRelatorioAvalicaoFisica.rdlc";
            this.rpvAvaliacoesFisicas.Location = new System.Drawing.Point(12, 12);
            this.rpvAvaliacoesFisicas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rpvAvaliacoesFisicas.Name = "rpvAvaliacoesFisicas";
            this.rpvAvaliacoesFisicas.Size = new System.Drawing.Size(934, 803);
            this.rpvAvaliacoesFisicas.TabIndex = 0;
            // 
            // uspMedidaCorporalListaAlunoDataTableAdapter
            // 
            this.uspMedidaCorporalListaAlunoDataTableAdapter.ClearBeforeFill = true;
            // 
            // uspMedidaCorporalRelatorioDataInicialTableAdapter
            // 
            this.uspMedidaCorporalRelatorioDataInicialTableAdapter.ClearBeforeFill = true;
            // 
            // uspMedidaCorporalRelatorioDataFinalTableAdapter
            // 
            this.uspMedidaCorporalRelatorioDataFinalTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelatorioAvalicaoFisica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(958, 826);
            this.Controls.Add(this.rpvAvaliacoesFisicas);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRelatorioAvalicaoFisica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de avaliações físicas";
            this.Load += new System.EventHandler(this.FrmRelatorioAvalicaoFisica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uspMedidaCorporalRelatorioDataInicialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCCSF2015DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspMedidaCorporalRelatorioDataFinalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspMedidaCorporalListaAlunoDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCCSF2015DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvAvaliacoesFisicas;
        private System.Windows.Forms.BindingSource uspMedidaCorporalListaAlunoDataBindingSource;
        private TCCSF2015DataSet tCCSF2015DataSet;
        private TCCSF2015DataSetTableAdapters.uspMedidaCorporalListaAlunoDataTableAdapter uspMedidaCorporalListaAlunoDataTableAdapter;
        private System.Windows.Forms.BindingSource uspMedidaCorporalRelatorioDataInicialBindingSource;
        private TCCSF2015DataSet1 tCCSF2015DataSet1;
        private System.Windows.Forms.BindingSource uspMedidaCorporalRelatorioDataFinalBindingSource;
        private TCCSF2015DataSet1TableAdapters.uspMedidaCorporalRelatorioDataInicialTableAdapter uspMedidaCorporalRelatorioDataInicialTableAdapter;
        private TCCSF2015DataSet1TableAdapters.uspMedidaCorporalRelatorioDataFinalTableAdapter uspMedidaCorporalRelatorioDataFinalTableAdapter;
    }
}