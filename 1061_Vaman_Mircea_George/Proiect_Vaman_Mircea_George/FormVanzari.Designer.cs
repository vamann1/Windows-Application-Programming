namespace Proiect_Vaman_Mircea_George
{
    partial class FormVanzari
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 =
                new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 =
                new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 =
                new System.Windows.Forms.DataVisualization.Charting.Series();

            this.chart1                  = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnTVA                  = new System.Windows.Forms.Button();
            this.tbVanzareCurenta        = new System.Windows.Forms.TextBox();
            this.lblVanzareCurenta       = new System.Windows.Forms.Label();
            this.dgvVanzari              = new System.Windows.Forms.DataGridView();
            this.btnDetaliiVanzari       = new System.Windows.Forms.Button();
            this.btnInregistreazaVanzare = new System.Windows.Forms.Button();
            this.tbPlata                 = new System.Windows.Forms.TextBox();
            this.lblPlata                = new System.Windows.Forms.Label();
            this.gbClientFidel           = new System.Windows.Forms.GroupBox();
            this.rbDa                    = new System.Windows.Forms.RadioButton();
            this.rbNu                    = new System.Windows.Forms.RadioButton();
            this.tbCantitate             = new System.Windows.Forms.TextBox();
            this.lblCantitate            = new System.Windows.Forms.Label();
            this.ucSelectorProds         = new Proiect_Vaman_Mircea_George.UCSelectorProds();
            this.dtpVanzare              = new System.Windows.Forms.DateTimePicker();
            this.lblDataVanzare          = new System.Windows.Forms.Label();
            this.btnGraficBars           = new System.Windows.Forms.Button();
            this.btnGraficPie            = new System.Windows.Forms.Button();
            this.btnModificaFont         = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVanzari)).BeginInit();
            this.gbClientFidel.SuspendLayout();
            this.SuspendLayout();
            //
            // chart1
            //
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(28, 794);
            this.chart1.Margin   = new System.Windows.Forms.Padding(6);
            this.chart1.Name     = "chart1";
            series1.ChartArea    = "ChartArea1";
            series1.Legend       = "Legend1";
            series1.Name         = "Vanzari";
            this.chart1.Series.Add(series1);
            this.chart1.Size     = new System.Drawing.Size(1879, 295);
            this.chart1.TabIndex = 0;
            this.chart1.Text     = "chart1";
            //
            // btnTVA
            //
            this.btnTVA.Location             = new System.Drawing.Point(816, 665);
            this.btnTVA.Margin               = new System.Windows.Forms.Padding(6);
            this.btnTVA.Name                 = "btnTVA";
            this.btnTVA.Size                 = new System.Drawing.Size(367, 55);
            this.btnTVA.TabIndex             = 1;
            this.btnTVA.Text                 = "Calculeaza TVA total";
            this.btnTVA.UseVisualStyleBackColor = true;
            this.btnTVA.Click += new System.EventHandler(this.btnTVA_Click);
            //
            // btnGraficBars
            //
            this.btnGraficBars.Location             = new System.Drawing.Point(1200, 665);
            this.btnGraficBars.Margin               = new System.Windows.Forms.Padding(6);
            this.btnGraficBars.Name                 = "btnGraficBars";
            this.btnGraficBars.Size                 = new System.Drawing.Size(200, 55);
            this.btnGraficBars.TabIndex             = 2;
            this.btnGraficBars.Text                 = "Grafic bare";
            this.btnGraficBars.UseVisualStyleBackColor = true;
            this.btnGraficBars.Click += new System.EventHandler(this.btnGraficBars_Click);
            //
            // btnGraficPie
            //
            this.btnGraficPie.Location             = new System.Drawing.Point(1418, 665);
            this.btnGraficPie.Margin               = new System.Windows.Forms.Padding(6);
            this.btnGraficPie.Name                 = "btnGraficPie";
            this.btnGraficPie.Size                 = new System.Drawing.Size(200, 55);
            this.btnGraficPie.TabIndex             = 3;
            this.btnGraficPie.Text                 = "Grafic pie";
            this.btnGraficPie.UseVisualStyleBackColor = true;
            this.btnGraficPie.Click += new System.EventHandler(this.btnGraficPie_Click);
            //
            // btnModificaFont
            //
            this.btnModificaFont.Location             = new System.Drawing.Point(1636, 665);
            this.btnModificaFont.Margin               = new System.Windows.Forms.Padding(6);
            this.btnModificaFont.Name                 = "btnModificaFont";
            this.btnModificaFont.Size                 = new System.Drawing.Size(220, 55);
            this.btnModificaFont.TabIndex             = 4;
            this.btnModificaFont.Text                 = "Modifica font grafic";
            this.btnModificaFont.UseVisualStyleBackColor = true;
            this.btnModificaFont.Click += new System.EventHandler(this.btnModificaFont_Click);
            //
            // tbVanzareCurenta
            //
            this.tbVanzareCurenta.Location = new System.Drawing.Point(770, 594);
            this.tbVanzareCurenta.Margin   = new System.Windows.Forms.Padding(6);
            this.tbVanzareCurenta.Name     = "tbVanzareCurenta";
            this.tbVanzareCurenta.ReadOnly = true;
            this.tbVanzareCurenta.Size     = new System.Drawing.Size(1133, 29);
            this.tbVanzareCurenta.TabIndex = 5;
            //
            // lblVanzareCurenta
            //
            this.lblVanzareCurenta.AutoSize = true;
            this.lblVanzareCurenta.Location = new System.Drawing.Point(568, 600);
            this.lblVanzareCurenta.Margin   = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblVanzareCurenta.Name     = "lblVanzareCurenta";
            this.lblVanzareCurenta.TabIndex = 6;
            this.lblVanzareCurenta.Text     = "Vanzare curenta:";
            //
            // dgvVanzari
            //
            this.dgvVanzari.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVanzari.Location       = new System.Drawing.Point(568, 55);
            this.dgvVanzari.Margin         = new System.Windows.Forms.Padding(6);
            this.dgvVanzari.Name           = "dgvVanzari";
            this.dgvVanzari.RowHeadersWidth= 72;
            this.dgvVanzari.Size           = new System.Drawing.Size(1338, 517);
            this.dgvVanzari.TabIndex       = 7;
            this.dgvVanzari.CellDoubleClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVanzari_CellDoubleClick);
            //
            // btnDetaliiVanzari
            //
            this.btnDetaliiVanzari.Location             = new System.Drawing.Point(28, 702);
            this.btnDetaliiVanzari.Margin               = new System.Windows.Forms.Padding(6);
            this.btnDetaliiVanzari.Name                 = "btnDetaliiVanzari";
            this.btnDetaliiVanzari.Size                 = new System.Drawing.Size(504, 55);
            this.btnDetaliiVanzari.TabIndex             = 8;
            this.btnDetaliiVanzari.Text                 = "Detalii vanzari";
            this.btnDetaliiVanzari.UseVisualStyleBackColor = true;
            this.btnDetaliiVanzari.Click += new System.EventHandler(this.btnDetaliiVanzari_Click);
            //
            // btnInregistreazaVanzare
            //
            this.btnInregistreazaVanzare.Location             = new System.Drawing.Point(28, 628);
            this.btnInregistreazaVanzare.Margin               = new System.Windows.Forms.Padding(6);
            this.btnInregistreazaVanzare.Name                 = "btnInregistreazaVanzare";
            this.btnInregistreazaVanzare.Size                 = new System.Drawing.Size(504, 55);
            this.btnInregistreazaVanzare.TabIndex             = 9;
            this.btnInregistreazaVanzare.Text                 = "Inregistreaza vanzare";
            this.btnInregistreazaVanzare.UseVisualStyleBackColor = true;
            this.btnInregistreazaVanzare.Click += new System.EventHandler(this.btnInregistreazaVanzare_Click);
            //
            // tbPlata
            //
            this.tbPlata.Location = new System.Drawing.Point(220, 558);
            this.tbPlata.Margin   = new System.Windows.Forms.Padding(6);
            this.tbPlata.Name     = "tbPlata";
            this.tbPlata.ReadOnly = true;
            this.tbPlata.Size     = new System.Drawing.Size(308, 29);
            this.tbPlata.TabIndex = 10;
            //
            // lblPlata
            //
            this.lblPlata.AutoSize = true;
            this.lblPlata.Location = new System.Drawing.Point(28, 563);
            this.lblPlata.Margin   = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPlata.Name     = "lblPlata";
            this.lblPlata.TabIndex = 11;
            this.lblPlata.Text     = "Total plata:";
            //
            // gbClientFidel
            //
            this.gbClientFidel.Controls.Add(this.rbDa);
            this.gbClientFidel.Controls.Add(this.rbNu);
            this.gbClientFidel.Location = new System.Drawing.Point(28, 388);
            this.gbClientFidel.Margin   = new System.Windows.Forms.Padding(6);
            this.gbClientFidel.Name     = "gbClientFidel";
            this.gbClientFidel.Padding  = new System.Windows.Forms.Padding(6);
            this.gbClientFidel.Size     = new System.Drawing.Size(504, 148);
            this.gbClientFidel.TabIndex = 12;
            this.gbClientFidel.TabStop  = false;
            this.gbClientFidel.Text     = "Client fidel?";
            this.rbDa.AutoSize = true;
            this.rbDa.Checked  = true;
            this.rbDa.Location = new System.Drawing.Point(28, 46);
            this.rbDa.Margin   = new System.Windows.Forms.Padding(6);
            this.rbDa.Name     = "rbDa";
            this.rbDa.Size     = new System.Drawing.Size(62, 29);
            this.rbDa.TabIndex = 0;
            this.rbDa.TabStop  = true;
            this.rbDa.Text     = "Da";
            this.rbDa.UseVisualStyleBackColor = true;
            this.rbDa.CheckedChanged += new System.EventHandler(this.rbDa_CheckedChanged);
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(28, 92);
            this.rbNu.Margin   = new System.Windows.Forms.Padding(6);
            this.rbNu.Name     = "rbNu";
            this.rbNu.Size     = new System.Drawing.Size(62, 29);
            this.rbNu.TabIndex = 1;
            this.rbNu.Text     = "Nu";
            this.rbNu.UseVisualStyleBackColor = true;
            this.rbNu.CheckedChanged += new System.EventHandler(this.rbNu_CheckedChanged);
            //
            // tbCantitate
            //
            this.tbCantitate.Location = new System.Drawing.Point(220, 327);
            this.tbCantitate.Margin   = new System.Windows.Forms.Padding(6);
            this.tbCantitate.Name     = "tbCantitate";
            this.tbCantitate.Size     = new System.Drawing.Size(308, 29);
            this.tbCantitate.TabIndex = 13;
            //
            // lblCantitate
            //
            this.lblCantitate.AutoSize = true;
            this.lblCantitate.Location = new System.Drawing.Point(28, 332);
            this.lblCantitate.Margin   = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCantitate.Name     = "lblCantitate";
            this.lblCantitate.TabIndex = 14;
            this.lblCantitate.Text     = "Cantitate:";
            //
            // ucSelectorProds — UserControl inlocuieste lbProduseVanzare
            //
            this.ucSelectorProds.Location = new System.Drawing.Point(28, 220);
            this.ucSelectorProds.Margin   = new System.Windows.Forms.Padding(6);
            this.ucSelectorProds.Name     = "ucSelectorProds";
            this.ucSelectorProds.Size     = new System.Drawing.Size(504, 82);
            this.ucSelectorProds.TabIndex = 15;
            //
            // dtpVanzare
            //
            this.dtpVanzare.Location = new System.Drawing.Point(220, 155);
            this.dtpVanzare.Margin   = new System.Windows.Forms.Padding(6);
            this.dtpVanzare.Name     = "dtpVanzare";
            this.dtpVanzare.Size     = new System.Drawing.Size(308, 29);
            this.dtpVanzare.TabIndex = 16;
            //
            // lblDataVanzare
            //
            this.lblDataVanzare.AutoSize = true;
            this.lblDataVanzare.Location = new System.Drawing.Point(28, 160);
            this.lblDataVanzare.Margin   = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDataVanzare.Name     = "lblDataVanzare";
            this.lblDataVanzare.TabIndex = 17;
            this.lblDataVanzare.Text     = "Data:";
            //
            // FormVanzari
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(1970, 1130);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnTVA);
            this.Controls.Add(this.btnGraficBars);
            this.Controls.Add(this.btnGraficPie);
            this.Controls.Add(this.btnModificaFont);
            this.Controls.Add(this.tbVanzareCurenta);
            this.Controls.Add(this.lblVanzareCurenta);
            this.Controls.Add(this.dgvVanzari);
            this.Controls.Add(this.btnDetaliiVanzari);
            this.Controls.Add(this.btnInregistreazaVanzare);
            this.Controls.Add(this.tbPlata);
            this.Controls.Add(this.lblPlata);
            this.Controls.Add(this.gbClientFidel);
            this.Controls.Add(this.tbCantitate);
            this.Controls.Add(this.lblCantitate);
            this.Controls.Add(this.ucSelectorProds);
            this.Controls.Add(this.dtpVanzare);
            this.Controls.Add(this.lblDataVanzare);
            this.Margin        = new System.Windows.Forms.Padding(6);
            this.Name          = "FormVanzari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text          = "Vanzari";
            this.Load         += new System.EventHandler(this.FormVanzari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVanzari)).EndInit();
            this.gbClientFidel.ResumeLayout(false);
            this.gbClientFidel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button        btnTVA;
        private System.Windows.Forms.Button        btnGraficBars;
        private System.Windows.Forms.Button        btnGraficPie;
        private System.Windows.Forms.Button        btnModificaFont;
        private System.Windows.Forms.TextBox       tbVanzareCurenta;
        private System.Windows.Forms.Label         lblVanzareCurenta;
        private System.Windows.Forms.DataGridView  dgvVanzari;
        private System.Windows.Forms.Button        btnDetaliiVanzari;
        private System.Windows.Forms.Button        btnInregistreazaVanzare;
        private System.Windows.Forms.TextBox       tbPlata;
        private System.Windows.Forms.Label         lblPlata;
        private System.Windows.Forms.GroupBox      gbClientFidel;
        private System.Windows.Forms.RadioButton   rbDa;
        private System.Windows.Forms.RadioButton   rbNu;
        private System.Windows.Forms.TextBox       tbCantitate;
        private System.Windows.Forms.Label         lblCantitate;
        private UCSelectorProds                    ucSelectorProds;
        private System.Windows.Forms.DateTimePicker dtpVanzare;
        private System.Windows.Forms.Label         lblDataVanzare;
    }
}
