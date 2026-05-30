namespace Proiect_Vaman_Mircea_George
{
    partial class FormProduse
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
            this.components               = new System.ComponentModel.Container();
            this.dateTimePicker1          = new System.Windows.Forms.DateTimePicker();
            this.lblDenumire              = new System.Windows.Forms.Label();
            this.tbDenumire               = new System.Windows.Forms.TextBox();
            this.lblCategorieProdus       = new System.Windows.Forms.Label();
            this.tbCategorie              = new System.Windows.Forms.TextBox();
            this.lblPret                  = new System.Windows.Forms.Label();
            this.tbPret                   = new System.Windows.Forms.TextBox();
            this.lblStoc                  = new System.Windows.Forms.Label();
            this.tbStoc                   = new System.Windows.Forms.TextBox();
            this.lblValoare               = new System.Windows.Forms.Label();
            this.tbValoare                = new System.Windows.Forms.TextBox();
            this.btnAdaugaLinie           = new System.Windows.Forms.Button();
            this.btnCalculeazaTotal       = new System.Windows.Forms.Button();
            this.btnStocPlus              = new System.Windows.Forms.Button();
            this.btnStocMinus             = new System.Windows.Forms.Button();
            this.btnComanda               = new System.Windows.Forms.Button();
            this.lvProduse                = new System.Windows.Forms.ListView();
            this.colProdNume              = new System.Windows.Forms.ColumnHeader();
            this.colProdCategorie         = new System.Windows.Forms.ColumnHeader();
            this.colProdPret              = new System.Windows.Forms.ColumnHeader();
            this.colProdStoc              = new System.Windows.Forms.ColumnHeader();
            this.colProdValoare           = new System.Windows.Forms.ColumnHeader();
            this.lblValoareTotala         = new System.Windows.Forms.Label();
            this.tbValoareTotala          = new System.Windows.Forms.TextBox();
            this.cmsProduse               = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergeProduseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1           = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmsProduse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            //
            // dateTimePicker1
            //
            this.dateTimePicker1.Location = new System.Drawing.Point(28, 55);
            this.dateTimePicker1.Margin   = new System.Windows.Forms.Padding(6);
            this.dateTimePicker1.Name     = "dateTimePicker1";
            this.dateTimePicker1.Size     = new System.Drawing.Size(363, 29);
            this.dateTimePicker1.TabIndex = 0;
            //
            // lblDenumire
            //
            this.lblDenumire.AutoSize = true;
            this.lblDenumire.Location = new System.Drawing.Point(28, 120);
            this.lblDenumire.Margin   = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDenumire.Name     = "lblDenumire";
            this.lblDenumire.TabIndex = 1;
            this.lblDenumire.Text     = "Nume";
            //
            // tbDenumire
            //
            this.tbDenumire.Location = new System.Drawing.Point(28, 157);
            this.tbDenumire.Margin   = new System.Windows.Forms.Padding(6);
            this.tbDenumire.Name     = "tbDenumire";
            this.tbDenumire.Size     = new System.Drawing.Size(217, 29);
            this.tbDenumire.TabIndex = 2;
            //
            // lblCategorieProdus
            //
            this.lblCategorieProdus.AutoSize = true;
            this.lblCategorieProdus.Location = new System.Drawing.Point(266, 120);
            this.lblCategorieProdus.Margin   = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCategorieProdus.Name     = "lblCategorieProdus";
            this.lblCategorieProdus.TabIndex = 3;
            this.lblCategorieProdus.Text     = "Categorie";
            //
            // tbCategorie
            //
            this.tbCategorie.Location = new System.Drawing.Point(266, 157);
            this.tbCategorie.Margin   = new System.Windows.Forms.Padding(6);
            this.tbCategorie.Name     = "tbCategorie";
            this.tbCategorie.Size     = new System.Drawing.Size(217, 29);
            this.tbCategorie.TabIndex = 4;
            //
            // lblPret
            //
            this.lblPret.AutoSize = true;
            this.lblPret.Location = new System.Drawing.Point(504, 120);
            this.lblPret.Margin   = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPret.Name     = "lblPret";
            this.lblPret.TabIndex = 5;
            this.lblPret.Text     = "Pret";
            //
            // tbPret
            //
            this.tbPret.Location = new System.Drawing.Point(504, 157);
            this.tbPret.Margin   = new System.Windows.Forms.Padding(6);
            this.tbPret.Name     = "tbPret";
            this.tbPret.Size     = new System.Drawing.Size(180, 29);
            this.tbPret.TabIndex = 6;
            //
            // lblStoc
            //
            this.lblStoc.AutoSize = true;
            this.lblStoc.Location = new System.Drawing.Point(706, 120);
            this.lblStoc.Margin   = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStoc.Name     = "lblStoc";
            this.lblStoc.TabIndex = 7;
            this.lblStoc.Text     = "Stoc";
            //
            // tbStoc
            //
            this.tbStoc.Location = new System.Drawing.Point(706, 157);
            this.tbStoc.Margin   = new System.Windows.Forms.Padding(6);
            this.tbStoc.Name     = "tbStoc";
            this.tbStoc.Size     = new System.Drawing.Size(180, 29);
            this.tbStoc.TabIndex = 8;
            //
            // lblValoare
            //
            this.lblValoare.AutoSize = true;
            this.lblValoare.Location = new System.Drawing.Point(908, 120);
            this.lblValoare.Margin   = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblValoare.Name     = "lblValoare";
            this.lblValoare.TabIndex = 9;
            this.lblValoare.Text     = "Valoare";
            //
            // tbValoare
            //
            this.tbValoare.Location = new System.Drawing.Point(908, 157);
            this.tbValoare.Margin   = new System.Windows.Forms.Padding(6);
            this.tbValoare.Name     = "tbValoare";
            this.tbValoare.ReadOnly = true;
            this.tbValoare.Size     = new System.Drawing.Size(180, 29);
            this.tbValoare.TabIndex = 10;
            //
            // btnAdaugaLinie
            //
            this.btnAdaugaLinie.Location             = new System.Drawing.Point(28, 231);
            this.btnAdaugaLinie.Margin               = new System.Windows.Forms.Padding(6);
            this.btnAdaugaLinie.Name                 = "btnAdaugaLinie";
            this.btnAdaugaLinie.Size                 = new System.Drawing.Size(275, 55);
            this.btnAdaugaLinie.TabIndex             = 11;
            this.btnAdaugaLinie.Text                 = "Adauga linie";
            this.btnAdaugaLinie.UseVisualStyleBackColor = true;
            this.btnAdaugaLinie.Click += new System.EventHandler(this.btnAdaugaLinie_Click);
            //
            // btnCalculeazaTotal
            //
            this.btnCalculeazaTotal.Location             = new System.Drawing.Point(321, 231);
            this.btnCalculeazaTotal.Margin               = new System.Windows.Forms.Padding(6);
            this.btnCalculeazaTotal.Name                 = "btnCalculeazaTotal";
            this.btnCalculeazaTotal.Size                 = new System.Drawing.Size(275, 55);
            this.btnCalculeazaTotal.TabIndex             = 12;
            this.btnCalculeazaTotal.Text                 = "Calculeaza total";
            this.btnCalculeazaTotal.UseVisualStyleBackColor = true;
            this.btnCalculeazaTotal.Click += new System.EventHandler(this.btnCalculeazaTotal_Click);
            //
            // btnStocPlus
            //
            this.btnStocPlus.Location             = new System.Drawing.Point(614, 231);
            this.btnStocPlus.Margin               = new System.Windows.Forms.Padding(6);
            this.btnStocPlus.Name                 = "btnStocPlus";
            this.btnStocPlus.Size                 = new System.Drawing.Size(238, 55);
            this.btnStocPlus.TabIndex             = 13;
            this.btnStocPlus.Text                 = "Stoc++ primul";
            this.btnStocPlus.UseVisualStyleBackColor = true;
            this.btnStocPlus.Click += new System.EventHandler(this.btnStocPlus_Click);
            //
            // btnStocMinus
            //
            this.btnStocMinus.Location             = new System.Drawing.Point(871, 231);
            this.btnStocMinus.Margin               = new System.Windows.Forms.Padding(6);
            this.btnStocMinus.Name                 = "btnStocMinus";
            this.btnStocMinus.Size                 = new System.Drawing.Size(238, 55);
            this.btnStocMinus.TabIndex             = 14;
            this.btnStocMinus.Text                 = "Stoc-- primul";
            this.btnStocMinus.UseVisualStyleBackColor = true;
            this.btnStocMinus.Click += new System.EventHandler(this.btnStocMinus_Click);
            //
            // btnComanda
            //
            this.btnComanda.Location             = new System.Drawing.Point(1128, 231);
            this.btnComanda.Margin               = new System.Windows.Forms.Padding(6);
            this.btnComanda.Name                 = "btnComanda";
            this.btnComanda.Size                 = new System.Drawing.Size(367, 55);
            this.btnComanda.TabIndex             = 15;
            this.btnComanda.Text                 = "Comanda (salveaza TXT)";
            this.btnComanda.UseVisualStyleBackColor = true;
            this.btnComanda.Click += new System.EventHandler(this.btnComanda_Click);
            //
            // lvProduse
            //
            this.lvProduse.CheckBoxes = true;
            this.lvProduse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colProdNume, this.colProdCategorie, this.colProdPret,
                this.colProdStoc, this.colProdValoare });
            this.lvProduse.FullRowSelect = true;
            this.lvProduse.GridLines     = true;
            this.lvProduse.HideSelection = false;
            this.lvProduse.Location      = new System.Drawing.Point(28, 320);
            this.lvProduse.Margin        = new System.Windows.Forms.Padding(6);
            this.lvProduse.Name          = "lvProduse";
            this.lvProduse.Size          = new System.Drawing.Size(1875, 500);
            this.lvProduse.TabIndex      = 16;
            this.lvProduse.UseCompatibleStateImageBehavior = false;
            this.lvProduse.View          = System.Windows.Forms.View.Details;
            this.lvProduse.ItemChecked  += new System.Windows.Forms.ItemCheckedEventHandler(this.lvProduse_ItemChecked);
            this.colProdNume.Text     = "Nume";     this.colProdNume.Width     = 200;
            this.colProdCategorie.Text= "Categorie";this.colProdCategorie.Width= 150;
            this.colProdPret.Text     = "Pret";     this.colProdPret.Width     = 100;
            this.colProdStoc.Text     = "Stoc";     this.colProdStoc.Width     = 80;
            this.colProdValoare.Text  = "Valoare";  this.colProdValoare.Width  = 120;
            //
            // lblValoareTotala
            //
            this.lblValoareTotala.AutoSize = true;
            this.lblValoareTotala.Location = new System.Drawing.Point(28, 844);
            this.lblValoareTotala.Margin   = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblValoareTotala.Name     = "lblValoareTotala";
            this.lblValoareTotala.TabIndex = 17;
            this.lblValoareTotala.Text     = "Valoare totala:";
            //
            // tbValoareTotala
            //
            this.tbValoareTotala.Location = new System.Drawing.Point(211, 840);
            this.tbValoareTotala.Margin   = new System.Windows.Forms.Padding(6);
            this.tbValoareTotala.Name     = "tbValoareTotala";
            this.tbValoareTotala.ReadOnly = true;
            this.tbValoareTotala.Size     = new System.Drawing.Size(363, 29);
            this.tbValoareTotala.TabIndex = 18;
            //
            // cmsProduse
            //
            this.cmsProduse.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.cmsProduse.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.stergeProduseToolStripMenuItem });
            this.cmsProduse.Name = "cmsProduse";
            this.cmsProduse.Size = new System.Drawing.Size(204, 40);
            this.stergeProduseToolStripMenuItem.Name = "stergeProduseToolStripMenuItem";
            this.stergeProduseToolStripMenuItem.Size = new System.Drawing.Size(203, 36);
            this.stergeProduseToolStripMenuItem.Text = "Sterge bifate";
            this.stergeProduseToolStripMenuItem.Click += new System.EventHandler(this.stergeProduseToolStripMenuItem_Click);
            //
            // errorProvider1
            //
            this.errorProvider1.ContainerControl = this;
            //
            // FormProduse
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(1970, 920);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDenumire);
            this.Controls.Add(this.tbDenumire);
            this.Controls.Add(this.lblCategorieProdus);
            this.Controls.Add(this.tbCategorie);
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.tbPret);
            this.Controls.Add(this.lblStoc);
            this.Controls.Add(this.tbStoc);
            this.Controls.Add(this.lblValoare);
            this.Controls.Add(this.tbValoare);
            this.Controls.Add(this.btnAdaugaLinie);
            this.Controls.Add(this.btnCalculeazaTotal);
            this.Controls.Add(this.btnStocPlus);
            this.Controls.Add(this.btnStocMinus);
            this.Controls.Add(this.btnComanda);
            this.Controls.Add(this.lvProduse);
            this.Controls.Add(this.lblValoareTotala);
            this.Controls.Add(this.tbValoareTotala);
            this.Margin        = new System.Windows.Forms.Padding(6);
            this.Name          = "FormProduse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text          = "Produse";
            this.cmsProduse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label          lblDenumire;
        private System.Windows.Forms.TextBox        tbDenumire;
        private System.Windows.Forms.Label          lblCategorieProdus;
        private System.Windows.Forms.TextBox        tbCategorie;
        private System.Windows.Forms.Label          lblPret;
        private System.Windows.Forms.TextBox        tbPret;
        private System.Windows.Forms.Label          lblStoc;
        private System.Windows.Forms.TextBox        tbStoc;
        private System.Windows.Forms.Label          lblValoare;
        private System.Windows.Forms.TextBox        tbValoare;
        private System.Windows.Forms.Button         btnAdaugaLinie;
        private System.Windows.Forms.Button         btnCalculeazaTotal;
        private System.Windows.Forms.Button         btnStocPlus;
        private System.Windows.Forms.Button         btnStocMinus;
        private System.Windows.Forms.Button         btnComanda;
        private System.Windows.Forms.ListView       lvProduse;
        private System.Windows.Forms.ColumnHeader   colProdNume;
        private System.Windows.Forms.ColumnHeader   colProdCategorie;
        private System.Windows.Forms.ColumnHeader   colProdPret;
        private System.Windows.Forms.ColumnHeader   colProdStoc;
        private System.Windows.Forms.ColumnHeader   colProdValoare;
        private System.Windows.Forms.Label          lblValoareTotala;
        private System.Windows.Forms.TextBox        tbValoareTotala;
        private System.Windows.Forms.ContextMenuStrip   cmsProduse;
        private System.Windows.Forms.ToolStripMenuItem  stergeProduseToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider      errorProvider1;
    }
}
