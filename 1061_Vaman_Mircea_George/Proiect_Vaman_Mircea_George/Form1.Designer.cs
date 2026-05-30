namespace Proiect_Vaman_Mircea_George
{
    partial class Form1
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
            this.menuStrip1                       = new System.Windows.Forms.MenuStrip();
            this.fisierToolStripMenuItem           = new System.Windows.Forms.ToolStripMenuItem();
            this.incarcaTxtToolStripMenuItem       = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaTxtToolStripMenuItem      = new System.Windows.Forms.ToolStripMenuItem();
            this.incarcaBinToolStripMenuItem       = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaBinToolStripMenuItem      = new System.Windows.Forms.ToolStripMenuItem();
            this.incarcaSetariToolStripMenuItem    = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem           = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizareToolStripMenuItem      = new System.Windows.Forms.ToolStripMenuItem();
            this.vizAcasaToolStripMenuItem         = new System.Windows.Forms.ToolStripMenuItem();
            this.vizRaioaneToolStripMenuItem       = new System.Windows.Forms.ToolStripMenuItem();
            this.vizProduseToolStripMenuItem       = new System.Windows.Forms.ToolStripMenuItem();
            this.vizVanzariToolStripMenuItem       = new System.Windows.Forms.ToolStripMenuItem();
            this.rapoarteToolStripMenuItem         = new System.Windows.Forms.ToolStripMenuItem();
            this.afisareGraficToolStripMenuItem    = new System.Windows.Forms.ToolStripMenuItem();
            this.graphicBarsToolStripMenuItem      = new System.Windows.Forms.ToolStripMenuItem();
            this.graphicPieToolStripMenuItem       = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem     = new System.Windows.Forms.ToolStripMenuItem();
            this.configurareToolStripMenuItem      = new System.Windows.Forms.ToolStripMenuItem();
            this.modificareFontToolStripMenuItem   = new System.Windows.Forms.ToolStripMenuItem();
            this.despreToolStripMenuItem           = new System.Windows.Forms.ToolStripMenuItem();
            this.bazaDeDateToolStripMenuItem       = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBDToolStripMenuItem           = new System.Windows.Forms.ToolStripMenuItem();
            this.loadBDToolStripMenuItem           = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBDToolStripMenuItem         = new System.Windows.Forms.ToolStripMenuItem();
            this.updateBDToolStripMenuItem         = new System.Windows.Forms.ToolStripMenuItem();
            this.gbHome                            = new System.Windows.Forms.GroupBox();
            this.lblFirmaNume                      = new System.Windows.Forms.Label();
            this.lblMagazinInfo                    = new System.Windows.Forms.Label();
            this.lblTotalRaioane                   = new System.Windows.Forms.Label();
            this.lblTotalProduse                   = new System.Windows.Forms.Label();
            this.lblTotalVanzari                   = new System.Windows.Forms.Label();
            this.lblValoareStoc                    = new System.Windows.Forms.Label();
            this.lblLogActivitate                  = new System.Windows.Forms.Label();
            this.tbLog                             = new System.Windows.Forms.TextBox();
            this.saveFileDialog1                   = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1                   = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.gbHome.SuspendLayout();
            this.SuspendLayout();
            //
            // menuStrip1
            //
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.fisierToolStripMenuItem,
                this.vizualizareToolStripMenuItem,
                this.rapoarteToolStripMenuItem,
                this.configurareToolStripMenuItem,
                this.bazaDeDateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(2017, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            //
            // fisierToolStripMenuItem
            //
            this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.incarcaTxtToolStripMenuItem,
                this.salveazaTxtToolStripMenuItem,
                this.incarcaBinToolStripMenuItem,
                this.salveazaBinToolStripMenuItem,
                this.incarcaSetariToolStripMenuItem,
                this.iesireToolStripMenuItem});
            this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(78, 34);
            this.fisierToolStripMenuItem.Text = "Fisier";
            //
            // incarcaTxtToolStripMenuItem
            //
            this.incarcaTxtToolStripMenuItem.Name = "incarcaTxtToolStripMenuItem";
            this.incarcaTxtToolStripMenuItem.Size = new System.Drawing.Size(409, 40);
            this.incarcaTxtToolStripMenuItem.Text = "Incarca produse din fisier text";
            this.incarcaTxtToolStripMenuItem.Click += new System.EventHandler(this.incarcaTxtToolStripMenuItem_Click);
            //
            // salveazaTxtToolStripMenuItem
            //
            this.salveazaTxtToolStripMenuItem.Name = "salveazaTxtToolStripMenuItem";
            this.salveazaTxtToolStripMenuItem.Size = new System.Drawing.Size(409, 40);
            this.salveazaTxtToolStripMenuItem.Text = "Salveaza produse in fisier text";
            this.salveazaTxtToolStripMenuItem.Click += new System.EventHandler(this.salveazaTxtToolStripMenuItem_Click);
            //
            // incarcaBinToolStripMenuItem
            //
            this.incarcaBinToolStripMenuItem.Name = "incarcaBinToolStripMenuItem";
            this.incarcaBinToolStripMenuItem.Size = new System.Drawing.Size(409, 40);
            this.incarcaBinToolStripMenuItem.Text = "Incarca vanzari din fisier binar";
            this.incarcaBinToolStripMenuItem.Click += new System.EventHandler(this.incarcaBinToolStripMenuItem_Click);
            //
            // salveazaBinToolStripMenuItem
            //
            this.salveazaBinToolStripMenuItem.Name = "salveazaBinToolStripMenuItem";
            this.salveazaBinToolStripMenuItem.Size = new System.Drawing.Size(409, 40);
            this.salveazaBinToolStripMenuItem.Text = "Salveaza vanzari in fisier binar";
            this.salveazaBinToolStripMenuItem.Click += new System.EventHandler(this.salveazaBinToolStripMenuItem_Click);
            //
            // incarcaSetariToolStripMenuItem
            //
            this.incarcaSetariToolStripMenuItem.Name = "incarcaSetariToolStripMenuItem";
            this.incarcaSetariToolStripMenuItem.Size = new System.Drawing.Size(409, 40);
            this.incarcaSetariToolStripMenuItem.Text = "Incarca setari din fisier XML";
            this.incarcaSetariToolStripMenuItem.Click += new System.EventHandler(this.incarcaSetariToolStripMenuItem_Click);
            //
            // iesireToolStripMenuItem
            //
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(355, 40);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            //
            // vizualizareToolStripMenuItem
            //
            this.vizualizareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.vizAcasaToolStripMenuItem,
                this.vizRaioaneToolStripMenuItem,
                this.vizProduseToolStripMenuItem,
                this.vizVanzariToolStripMenuItem});
            this.vizualizareToolStripMenuItem.Name = "vizualizareToolStripMenuItem";
            this.vizualizareToolStripMenuItem.Size = new System.Drawing.Size(131, 34);
            this.vizualizareToolStripMenuItem.Text = "Vizualizare";
            //
            // vizAcasaToolStripMenuItem
            //
            this.vizAcasaToolStripMenuItem.Name = "vizAcasaToolStripMenuItem";
            this.vizAcasaToolStripMenuItem.Size = new System.Drawing.Size(206, 40);
            this.vizAcasaToolStripMenuItem.Text = "Acasa";
            this.vizAcasaToolStripMenuItem.Click += new System.EventHandler(this.vizAcasaToolStripMenuItem_Click);
            //
            // vizRaioaneToolStripMenuItem
            //
            this.vizRaioaneToolStripMenuItem.Name = "vizRaioaneToolStripMenuItem";
            this.vizRaioaneToolStripMenuItem.Size = new System.Drawing.Size(206, 40);
            this.vizRaioaneToolStripMenuItem.Text = "Raioane";
            this.vizRaioaneToolStripMenuItem.Click += new System.EventHandler(this.vizRaioaneToolStripMenuItem_Click);
            //
            // vizProduseToolStripMenuItem
            //
            this.vizProduseToolStripMenuItem.Name = "vizProduseToolStripMenuItem";
            this.vizProduseToolStripMenuItem.Size = new System.Drawing.Size(206, 40);
            this.vizProduseToolStripMenuItem.Text = "Produse";
            this.vizProduseToolStripMenuItem.Click += new System.EventHandler(this.vizProduseToolStripMenuItem_Click);
            //
            // vizVanzariToolStripMenuItem
            //
            this.vizVanzariToolStripMenuItem.Name = "vizVanzariToolStripMenuItem";
            this.vizVanzariToolStripMenuItem.Size = new System.Drawing.Size(206, 40);
            this.vizVanzariToolStripMenuItem.Text = "Vanzari";
            this.vizVanzariToolStripMenuItem.Click += new System.EventHandler(this.vizVanzariToolStripMenuItem_Click);
            //
            // rapoarteToolStripMenuItem
            //
            this.rapoarteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.afisareGraficToolStripMenuItem,
                this.printPreviewToolStripMenuItem});
            this.rapoarteToolStripMenuItem.Name = "rapoarteToolStripMenuItem";
            this.rapoarteToolStripMenuItem.Size = new System.Drawing.Size(115, 34);
            this.rapoarteToolStripMenuItem.Text = "Rapoarte";
            //
            // afisareGraficToolStripMenuItem
            //
            this.afisareGraficToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.graphicBarsToolStripMenuItem,
                this.graphicPieToolStripMenuItem});
            this.afisareGraficToolStripMenuItem.Name = "afisareGraficToolStripMenuItem";
            this.afisareGraficToolStripMenuItem.Size = new System.Drawing.Size(253, 40);
            this.afisareGraficToolStripMenuItem.Text = "Afisare grafic";
            //
            // graphicBarsToolStripMenuItem
            //
            this.graphicBarsToolStripMenuItem.Name = "graphicBarsToolStripMenuItem";
            this.graphicBarsToolStripMenuItem.Size = new System.Drawing.Size(247, 40);
            this.graphicBarsToolStripMenuItem.Text = "Graphic bars";
            this.graphicBarsToolStripMenuItem.Click += new System.EventHandler(this.graphicBarsToolStripMenuItem_Click);
            //
            // graphicPieToolStripMenuItem
            //
            this.graphicPieToolStripMenuItem.Name = "graphicPieToolStripMenuItem";
            this.graphicPieToolStripMenuItem.Size = new System.Drawing.Size(247, 40);
            this.graphicPieToolStripMenuItem.Text = "Graphic pie";
            this.graphicPieToolStripMenuItem.Click += new System.EventHandler(this.graphicPieToolStripMenuItem_Click);
            //
            // printPreviewToolStripMenuItem
            //
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(253, 40);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            //
            // configurareToolStripMenuItem
            //
            this.configurareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.modificareFontToolStripMenuItem,
                this.despreToolStripMenuItem});
            this.configurareToolStripMenuItem.Name = "configurareToolStripMenuItem";
            this.configurareToolStripMenuItem.Size = new System.Drawing.Size(140, 34);
            this.configurareToolStripMenuItem.Text = "Configurare";
            //
            // modificareFontToolStripMenuItem
            //
            this.modificareFontToolStripMenuItem.Name = "modificareFontToolStripMenuItem";
            this.modificareFontToolStripMenuItem.Size = new System.Drawing.Size(332, 40);
            this.modificareFontToolStripMenuItem.Text = "Modificare font grafic";
            this.modificareFontToolStripMenuItem.Click += new System.EventHandler(this.modificareFontToolStripMenuItem_Click);
            //
            // despreToolStripMenuItem
            //
            this.despreToolStripMenuItem.Name = "despreToolStripMenuItem";
            this.despreToolStripMenuItem.Size = new System.Drawing.Size(332, 40);
            this.despreToolStripMenuItem.Text = "Despre";
            this.despreToolStripMenuItem.Click += new System.EventHandler(this.despreToolStripMenuItem_Click);
            //
            // bazaDeDateToolStripMenuItem
            //
            this.bazaDeDateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.saveBDToolStripMenuItem,
                this.loadBDToolStripMenuItem,
                this.deleteBDToolStripMenuItem,
                this.updateBDToolStripMenuItem});
            this.bazaDeDateToolStripMenuItem.Name = "bazaDeDateToolStripMenuItem";
            this.bazaDeDateToolStripMenuItem.Size = new System.Drawing.Size(151, 34);
            this.bazaDeDateToolStripMenuItem.Text = "Baza de date";
            //
            // saveBDToolStripMenuItem
            //
            this.saveBDToolStripMenuItem.Name = "saveBDToolStripMenuItem";
            this.saveBDToolStripMenuItem.Size = new System.Drawing.Size(382, 40);
            this.saveBDToolStripMenuItem.Text = "Salveaza vanzari in BD";
            this.saveBDToolStripMenuItem.Click += new System.EventHandler(this.saveBDToolStripMenuItem_Click);
            //
            // loadBDToolStripMenuItem
            //
            this.loadBDToolStripMenuItem.Name = "loadBDToolStripMenuItem";
            this.loadBDToolStripMenuItem.Size = new System.Drawing.Size(382, 40);
            this.loadBDToolStripMenuItem.Text = "Incarca vanzari din BD";
            this.loadBDToolStripMenuItem.Click += new System.EventHandler(this.loadBDToolStripMenuItem_Click);
            //
            // deleteBDToolStripMenuItem
            //
            this.deleteBDToolStripMenuItem.Name = "deleteBDToolStripMenuItem";
            this.deleteBDToolStripMenuItem.Size = new System.Drawing.Size(382, 40);
            this.deleteBDToolStripMenuItem.Text = "Sterge vanzare din BD";
            this.deleteBDToolStripMenuItem.Click += new System.EventHandler(this.deleteBDToolStripMenuItem_Click);
            //
            // updateBDToolStripMenuItem
            //
            this.updateBDToolStripMenuItem.Name = "updateBDToolStripMenuItem";
            this.updateBDToolStripMenuItem.Size = new System.Drawing.Size(382, 40);
            this.updateBDToolStripMenuItem.Text = "Actualizeaza vanzare in BD";
            this.updateBDToolStripMenuItem.Click += new System.EventHandler(this.updateBDToolStripMenuItem_Click);
            //
            // gbHome
            //
            this.gbHome.Controls.Add(this.lblFirmaNume);
            this.gbHome.Controls.Add(this.lblMagazinInfo);
            this.gbHome.Controls.Add(this.lblTotalRaioane);
            this.gbHome.Controls.Add(this.lblTotalProduse);
            this.gbHome.Controls.Add(this.lblTotalVanzari);
            this.gbHome.Controls.Add(this.lblValoareStoc);
            this.gbHome.Controls.Add(this.lblLogActivitate);
            this.gbHome.Controls.Add(this.tbLog);
            this.gbHome.Location = new System.Drawing.Point(28, 55);
            this.gbHome.Margin = new System.Windows.Forms.Padding(6);
            this.gbHome.Name = "gbHome";
            this.gbHome.Padding = new System.Windows.Forms.Padding(6);
            this.gbHome.Size = new System.Drawing.Size(1943, 1145);
            this.gbHome.TabIndex = 0;
            this.gbHome.TabStop = false;
            this.gbHome.Text = "Acasa";
            //
            // lblFirmaNume
            //
            this.lblFirmaNume.AutoSize = true;
            this.lblFirmaNume.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblFirmaNume.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblFirmaNume.Location = new System.Drawing.Point(55, 37);
            this.lblFirmaNume.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFirmaNume.Name = "lblFirmaNume";
            this.lblFirmaNume.Size = new System.Drawing.Size(343, 70);
            this.lblFirmaNume.TabIndex = 0;
            this.lblFirmaNume.Text = "Magazin SRL";
            //
            // lblMagazinInfo
            //
            this.lblMagazinInfo.AutoSize = true;
            this.lblMagazinInfo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblMagazinInfo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMagazinInfo.Location = new System.Drawing.Point(59, 126);
            this.lblMagazinInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMagazinInfo.Name = "lblMagazinInfo";
            this.lblMagazinInfo.Size = new System.Drawing.Size(429, 36);
            this.lblMagazinInfo.TabIndex = 1;
            this.lblMagazinInfo.Text = "Magazin: —  |  Oras: —  |  Adresa: —";
            //
            // lblTotalRaioane
            //
            this.lblTotalRaioane.AutoSize = true;
            this.lblTotalRaioane.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTotalRaioane.Location = new System.Drawing.Point(59, 212);
            this.lblTotalRaioane.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotalRaioane.Name = "lblTotalRaioane";
            this.lblTotalRaioane.Size = new System.Drawing.Size(212, 38);
            this.lblTotalRaioane.TabIndex = 2;
            this.lblTotalRaioane.Text = "Total raioane:  0";
            //
            // lblTotalProduse
            //
            this.lblTotalProduse.AutoSize = true;
            this.lblTotalProduse.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTotalProduse.Location = new System.Drawing.Point(59, 273);
            this.lblTotalProduse.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotalProduse.Name = "lblTotalProduse";
            this.lblTotalProduse.Size = new System.Drawing.Size(221, 38);
            this.lblTotalProduse.TabIndex = 3;
            this.lblTotalProduse.Text = "Total produse:  0";
            //
            // lblTotalVanzari
            //
            this.lblTotalVanzari.AutoSize = true;
            this.lblTotalVanzari.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTotalVanzari.Location = new System.Drawing.Point(59, 334);
            this.lblTotalVanzari.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotalVanzari.Name = "lblTotalVanzari";
            this.lblTotalVanzari.Size = new System.Drawing.Size(207, 38);
            this.lblTotalVanzari.TabIndex = 4;
            this.lblTotalVanzari.Text = "Total vanzari:  0";
            //
            // lblValoareStoc
            //
            this.lblValoareStoc.AutoSize = true;
            this.lblValoareStoc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblValoareStoc.Location = new System.Drawing.Point(59, 395);
            this.lblValoareStoc.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblValoareStoc.Name = "lblValoareStoc";
            this.lblValoareStoc.Size = new System.Drawing.Size(314, 38);
            this.lblValoareStoc.TabIndex = 5;
            this.lblValoareStoc.Text = "Valoare stoc:   0.00 RON";
            //
            // lblLogActivitate
            //
            this.lblLogActivitate.AutoSize = true;
            this.lblLogActivitate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLogActivitate.Location = new System.Drawing.Point(59, 484);
            this.lblLogActivitate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLogActivitate.Name = "lblLogActivitate";
            this.lblLogActivitate.Size = new System.Drawing.Size(175, 32);
            this.lblLogActivitate.TabIndex = 6;
            this.lblLogActivitate.Text = "Log activitate:";
            //
            // tbLog
            //
            this.tbLog.Location = new System.Drawing.Point(59, 526);
            this.tbLog.Margin = new System.Windows.Forms.Padding(6);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLog.Size = new System.Drawing.Size(1812, 541);
            this.tbLog.TabIndex = 7;
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2017, 1230);
            this.Controls.Add(this.gbHome);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RetailManager - Gestiune magazine";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbHome.ResumeLayout(false);
            this.gbHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // MenuStrip
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incarcaTxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaTxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incarcaBinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaBinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incarcaSetariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizualizareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizAcasaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizRaioaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizProduseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizVanzariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapoarteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afisareGraficToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphicBarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphicPieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificareFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bazaDeDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveBDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadBDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteBDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateBDToolStripMenuItem;

        // gbHome
        private System.Windows.Forms.GroupBox gbHome;
        private System.Windows.Forms.Label lblFirmaNume;
        private System.Windows.Forms.Label lblMagazinInfo;
        private System.Windows.Forms.Label lblTotalRaioane;
        private System.Windows.Forms.Label lblTotalProduse;
        private System.Windows.Forms.Label lblTotalVanzari;
        private System.Windows.Forms.Label lblValoareStoc;
        private System.Windows.Forms.Label lblLogActivitate;
        private System.Windows.Forms.TextBox tbLog;

        // Dialogs
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
