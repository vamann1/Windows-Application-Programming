namespace Proiect_Vaman_Mircea_George
{
    partial class FormRaioane
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
            this.components                  = new System.ComponentModel.Container();
            this.lblRaionId                  = new System.Windows.Forms.Label();
            this.tbRaionId                   = new System.Windows.Forms.TextBox();
            this.lblRaionNume                = new System.Windows.Forms.Label();
            this.tbRaionNume                 = new System.Windows.Forms.TextBox();
            this.lblRaionCategorie           = new System.Windows.Forms.Label();
            this.tbRaionCategorie            = new System.Windows.Forms.TextBox();
            this.btnAdaugaRaion              = new System.Windows.Forms.Button();
            this.lvRaioane                   = new System.Windows.Forms.ListView();
            this.colRaionId                  = new System.Windows.Forms.ColumnHeader();
            this.colRaionNume                = new System.Windows.Forms.ColumnHeader();
            this.colRaionCategorie           = new System.Windows.Forms.ColumnHeader();
            this.btnPopuleazaLV              = new System.Windows.Forms.Button();
            this.btnStergeLV                 = new System.Windows.Forms.Button();
            this.tvRaioane                   = new System.Windows.Forms.TreeView();
            this.btnPopuleazaTV              = new System.Windows.Forms.Button();
            this.btnStergeTV                 = new System.Windows.Forms.Button();
            this.tbDetaliiRaion              = new System.Windows.Forms.TextBox();
            this.cmsLV                       = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergeLVToolStripMenuItem   = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTV                       = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergeTVToolStripMenuItem   = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsLV.SuspendLayout();
            this.cmsTV.SuspendLayout();
            this.SuspendLayout();
            //
            // lblRaionId
            //
            this.lblRaionId.AutoSize = true;
            this.lblRaionId.Location = new System.Drawing.Point(28, 55);
            this.lblRaionId.Margin   = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRaionId.Name     = "lblRaionId";
            this.lblRaionId.TabIndex = 0;
            this.lblRaionId.Text     = "Id raion:";
            //
            // tbRaionId
            //
            this.tbRaionId.Location = new System.Drawing.Point(183, 50);
            this.tbRaionId.Margin   = new System.Windows.Forms.Padding(6);
            this.tbRaionId.Name     = "tbRaionId";
            this.tbRaionId.Size     = new System.Drawing.Size(308, 29);
            this.tbRaionId.TabIndex = 1;
            //
            // lblRaionNume
            //
            this.lblRaionNume.AutoSize = true;
            this.lblRaionNume.Location = new System.Drawing.Point(28, 111);
            this.lblRaionNume.Margin   = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRaionNume.Name     = "lblRaionNume";
            this.lblRaionNume.TabIndex = 2;
            this.lblRaionNume.Text     = "Nume:";
            //
            // tbRaionNume
            //
            this.tbRaionNume.Location = new System.Drawing.Point(183, 105);
            this.tbRaionNume.Margin   = new System.Windows.Forms.Padding(6);
            this.tbRaionNume.Name     = "tbRaionNume";
            this.tbRaionNume.Size     = new System.Drawing.Size(308, 29);
            this.tbRaionNume.TabIndex = 3;
            //
            // lblRaionCategorie
            //
            this.lblRaionCategorie.AutoSize = true;
            this.lblRaionCategorie.Location = new System.Drawing.Point(28, 166);
            this.lblRaionCategorie.Margin   = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRaionCategorie.Name     = "lblRaionCategorie";
            this.lblRaionCategorie.TabIndex = 4;
            this.lblRaionCategorie.Text     = "Categorie:";
            //
            // tbRaionCategorie
            //
            this.tbRaionCategorie.Location = new System.Drawing.Point(183, 161);
            this.tbRaionCategorie.Margin   = new System.Windows.Forms.Padding(6);
            this.tbRaionCategorie.Name     = "tbRaionCategorie";
            this.tbRaionCategorie.Size     = new System.Drawing.Size(308, 29);
            this.tbRaionCategorie.TabIndex = 5;
            //
            // btnAdaugaRaion
            //
            this.btnAdaugaRaion.Location             = new System.Drawing.Point(28, 240);
            this.btnAdaugaRaion.Margin               = new System.Windows.Forms.Padding(6);
            this.btnAdaugaRaion.Name                 = "btnAdaugaRaion";
            this.btnAdaugaRaion.Size                 = new System.Drawing.Size(468, 55);
            this.btnAdaugaRaion.TabIndex             = 6;
            this.btnAdaugaRaion.Text                 = "Adauga raion";
            this.btnAdaugaRaion.UseVisualStyleBackColor = true;
            this.btnAdaugaRaion.Click += new System.EventHandler(this.btnAdaugaRaion_Click);
            //
            // lvRaioane
            //
            this.lvRaioane.CheckBoxes    = true;
            this.lvRaioane.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colRaionId, this.colRaionNume, this.colRaionCategorie });
            this.lvRaioane.FullRowSelect = true;
            this.lvRaioane.GridLines     = true;
            this.lvRaioane.HideSelection = false;
            this.lvRaioane.Location      = new System.Drawing.Point(532, 55);
            this.lvRaioane.Margin        = new System.Windows.Forms.Padding(6);
            this.lvRaioane.Name          = "lvRaioane";
            this.lvRaioane.Size          = new System.Drawing.Size(657, 920);
            this.lvRaioane.TabIndex      = 7;
            this.lvRaioane.UseCompatibleStateImageBehavior = false;
            this.lvRaioane.View          = System.Windows.Forms.View.Details;
            this.lvRaioane.ItemChecked  += new System.Windows.Forms.ItemCheckedEventHandler(this.lvRaioane_ItemChecked);
            //
            // colRaionId / colRaionNume / colRaionCategorie
            //
            this.colRaionId.Text        = "Id";       this.colRaionId.Width        = 50;
            this.colRaionNume.Text      = "Nume";     this.colRaionNume.Width      = 130;
            this.colRaionCategorie.Text = "Categorie";this.colRaionCategorie.Width = 130;
            //
            // btnPopuleazaLV
            //
            this.btnPopuleazaLV.Location             = new System.Drawing.Point(532, 1006);
            this.btnPopuleazaLV.Margin               = new System.Windows.Forms.Padding(6);
            this.btnPopuleazaLV.Name                 = "btnPopuleazaLV";
            this.btnPopuleazaLV.Size                 = new System.Drawing.Size(312, 55);
            this.btnPopuleazaLV.TabIndex             = 8;
            this.btnPopuleazaLV.Text                 = "Populare LV";
            this.btnPopuleazaLV.UseVisualStyleBackColor = true;
            this.btnPopuleazaLV.Click += new System.EventHandler(this.btnPopuleazaLV_Click);
            //
            // btnStergeLV
            //
            this.btnStergeLV.Location             = new System.Drawing.Point(532, 1080);
            this.btnStergeLV.Margin               = new System.Windows.Forms.Padding(6);
            this.btnStergeLV.Name                 = "btnStergeLV";
            this.btnStergeLV.Size                 = new System.Drawing.Size(312, 55);
            this.btnStergeLV.TabIndex             = 9;
            this.btnStergeLV.Text                 = "Sterge LV bifate";
            this.btnStergeLV.UseVisualStyleBackColor = true;
            this.btnStergeLV.Click += new System.EventHandler(this.btnStergeLV_Click);
            //
            // tvRaioane
            //
            this.tvRaioane.Location     = new System.Drawing.Point(1228, 55);
            this.tvRaioane.Margin       = new System.Windows.Forms.Padding(6);
            this.tvRaioane.Name         = "tvRaioane";
            this.tvRaioane.Size         = new System.Drawing.Size(675, 920);
            this.tvRaioane.TabIndex     = 10;
            this.tvRaioane.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvRaioane_AfterSelect);
            //
            // btnPopuleazaTV
            //
            this.btnPopuleazaTV.Location             = new System.Drawing.Point(1228, 1006);
            this.btnPopuleazaTV.Margin               = new System.Windows.Forms.Padding(6);
            this.btnPopuleazaTV.Name                 = "btnPopuleazaTV";
            this.btnPopuleazaTV.Size                 = new System.Drawing.Size(312, 55);
            this.btnPopuleazaTV.TabIndex             = 11;
            this.btnPopuleazaTV.Text                 = "Populare TV";
            this.btnPopuleazaTV.UseVisualStyleBackColor = true;
            this.btnPopuleazaTV.Click += new System.EventHandler(this.btnPopuleazaTV_Click);
            //
            // btnStergeTV
            //
            this.btnStergeTV.Location             = new System.Drawing.Point(1228, 1080);
            this.btnStergeTV.Margin               = new System.Windows.Forms.Padding(6);
            this.btnStergeTV.Name                 = "btnStergeTV";
            this.btnStergeTV.Size                 = new System.Drawing.Size(312, 55);
            this.btnStergeTV.TabIndex             = 12;
            this.btnStergeTV.Text                 = "Sterge TV selectat";
            this.btnStergeTV.UseVisualStyleBackColor = true;
            this.btnStergeTV.Click += new System.EventHandler(this.btnStergeTV_Click);
            //
            // tbDetaliiRaion
            //
            this.tbDetaliiRaion.Location = new System.Drawing.Point(1558, 1006);
            this.tbDetaliiRaion.Margin   = new System.Windows.Forms.Padding(6);
            this.tbDetaliiRaion.Name     = "tbDetaliiRaion";
            this.tbDetaliiRaion.ReadOnly = true;
            this.tbDetaliiRaion.Size     = new System.Drawing.Size(345, 29);
            this.tbDetaliiRaion.TabIndex = 13;
            //
            // cmsLV
            //
            this.cmsLV.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.cmsLV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.stergeLVToolStripMenuItem });
            this.cmsLV.Name = "cmsLV";
            this.cmsLV.Size = new System.Drawing.Size(254, 40);
            this.stergeLVToolStripMenuItem.Name = "stergeLVToolStripMenuItem";
            this.stergeLVToolStripMenuItem.Size = new System.Drawing.Size(253, 36);
            this.stergeLVToolStripMenuItem.Text = "Sterge element LV";
            this.stergeLVToolStripMenuItem.Click += new System.EventHandler(this.stergeLVToolStripMenuItem_Click);
            //
            // cmsTV
            //
            this.cmsTV.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.cmsTV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.stergeTVToolStripMenuItem });
            this.cmsTV.Name = "cmsTV";
            this.cmsTV.Size = new System.Drawing.Size(256, 40);
            this.stergeTVToolStripMenuItem.Name = "stergeTVToolStripMenuItem";
            this.stergeTVToolStripMenuItem.Size = new System.Drawing.Size(255, 36);
            this.stergeTVToolStripMenuItem.Text = "Sterge element TV";
            this.stergeTVToolStripMenuItem.Click += new System.EventHandler(this.stergeTVToolStripMenuItem_Click);
            //
            // FormRaioane
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(1970, 1200);
            this.Controls.Add(this.lblRaionId);
            this.Controls.Add(this.tbRaionId);
            this.Controls.Add(this.lblRaionNume);
            this.Controls.Add(this.tbRaionNume);
            this.Controls.Add(this.lblRaionCategorie);
            this.Controls.Add(this.tbRaionCategorie);
            this.Controls.Add(this.btnAdaugaRaion);
            this.Controls.Add(this.lvRaioane);
            this.Controls.Add(this.btnPopuleazaLV);
            this.Controls.Add(this.btnStergeLV);
            this.Controls.Add(this.tvRaioane);
            this.Controls.Add(this.btnPopuleazaTV);
            this.Controls.Add(this.btnStergeTV);
            this.Controls.Add(this.tbDetaliiRaion);
            this.Margin        = new System.Windows.Forms.Padding(6);
            this.Name          = "FormRaioane";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text          = "Raioane";
            this.cmsLV.ResumeLayout(false);
            this.cmsTV.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label        lblRaionId;
        private System.Windows.Forms.TextBox      tbRaionId;
        private System.Windows.Forms.Label        lblRaionNume;
        private System.Windows.Forms.TextBox      tbRaionNume;
        private System.Windows.Forms.Label        lblRaionCategorie;
        private System.Windows.Forms.TextBox      tbRaionCategorie;
        private System.Windows.Forms.Button       btnAdaugaRaion;
        private System.Windows.Forms.Button       btnStergeLV;
        private System.Windows.Forms.Button       btnStergeTV;
        private System.Windows.Forms.ListView     lvRaioane;
        private System.Windows.Forms.ColumnHeader colRaionId;
        private System.Windows.Forms.ColumnHeader colRaionNume;
        private System.Windows.Forms.ColumnHeader colRaionCategorie;
        private System.Windows.Forms.Button       btnPopuleazaLV;
        private System.Windows.Forms.Button       btnPopuleazaTV;
        private System.Windows.Forms.TreeView     tvRaioane;
        private System.Windows.Forms.TextBox      tbDetaliiRaion;
        private System.Windows.Forms.ContextMenuStrip    cmsLV;
        private System.Windows.Forms.ToolStripMenuItem   stergeLVToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip    cmsTV;
        private System.Windows.Forms.ToolStripMenuItem   stergeTVToolStripMenuItem;
    }
}
