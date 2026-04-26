namespace seminar6Tema
{
    partial class Form1
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
            this.lvStudenti = new System.Windows.Forms.ListView();
            this.Matricol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Medie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Observatie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tvStudenti = new System.Windows.Forms.TreeView();
            this.tbStudenti = new System.Windows.Forms.TextBox();
            this.btnPreluareLV = new System.Windows.Forms.Button();
            this.btnStergeElemLV = new System.Windows.Forms.Button();
            this.btnPopulareTV = new System.Windows.Forms.Button();
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergeElementLVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip5 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergeElementTVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip4.SuspendLayout();
            this.contextMenuStrip5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvStudenti
            // 
            this.lvStudenti.CheckBoxes = true;
            this.lvStudenti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Matricol,
            this.Nume,
            this.Medie,
            this.Observatie});
            this.lvStudenti.GridLines = true;
            this.lvStudenti.HideSelection = false;
            this.lvStudenti.Location = new System.Drawing.Point(12, 39);
            this.lvStudenti.Name = "lvStudenti";
            this.lvStudenti.Size = new System.Drawing.Size(401, 374);
            this.lvStudenti.TabIndex = 0;
            this.lvStudenti.UseCompatibleStateImageBehavior = false;
            this.lvStudenti.View = System.Windows.Forms.View.Details;
            this.lvStudenti.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvStudenti_ItemChecked);
            // 
            // Matricol
            // 
            this.Matricol.Text = "Matricol";
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            // 
            // Medie
            // 
            this.Medie.Text = "Medie";
            // 
            // Observatie
            // 
            this.Observatie.Text = "Observatie";
            // 
            // tvStudenti
            // 
            this.tvStudenti.Location = new System.Drawing.Point(462, 12);
            this.tvStudenti.Name = "tvStudenti";
            this.tvStudenti.Size = new System.Drawing.Size(271, 347);
            this.tvStudenti.TabIndex = 1;
            // 
            // tbStudenti
            // 
            this.tbStudenti.Location = new System.Drawing.Point(793, 12);
            this.tbStudenti.Multiline = true;
            this.tbStudenti.Name = "tbStudenti";
            this.tbStudenti.ReadOnly = true;
            this.tbStudenti.Size = new System.Drawing.Size(345, 347);
            this.tbStudenti.TabIndex = 2;
            // 
            // btnPreluareLV
            // 
            this.btnPreluareLV.Location = new System.Drawing.Point(21, 439);
            this.btnPreluareLV.Name = "btnPreluareLV";
            this.btnPreluareLV.Size = new System.Drawing.Size(165, 69);
            this.btnPreluareLV.TabIndex = 3;
            this.btnPreluareLV.Text = "PopulareLV";
            this.btnPreluareLV.UseVisualStyleBackColor = true;
            this.btnPreluareLV.Click += new System.EventHandler(this.btnPreluareLV_Click);
            // 
            // btnStergeElemLV
            // 
            this.btnStergeElemLV.Location = new System.Drawing.Point(291, 446);
            this.btnStergeElemLV.Name = "btnStergeElemLV";
            this.btnStergeElemLV.Size = new System.Drawing.Size(122, 61);
            this.btnStergeElemLV.TabIndex = 4;
            this.btnStergeElemLV.Text = "Stergere Element LV";
            this.btnStergeElemLV.UseVisualStyleBackColor = true;
            this.btnStergeElemLV.Click += new System.EventHandler(this.btnStergeElemLV_Click);
            // 
            // btnPopulareTV
            // 
            this.btnPopulareTV.Location = new System.Drawing.Point(491, 454);
            this.btnPopulareTV.Name = "btnPopulareTV";
            this.btnPopulareTV.Size = new System.Drawing.Size(178, 52);
            this.btnPopulareTV.TabIndex = 5;
            this.btnPopulareTV.Text = "PopulareTV";
            this.btnPopulareTV.UseVisualStyleBackColor = true;
            this.btnPopulareTV.Click += new System.EventHandler(this.btnPopulareTV_Click);
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergeElementLVToolStripMenuItem});
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(284, 42);
            this.contextMenuStrip4.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip4_Opening);
            // 
            // stergeElementLVToolStripMenuItem
            // 
            this.stergeElementLVToolStripMenuItem.Name = "stergeElementLVToolStripMenuItem";
            this.stergeElementLVToolStripMenuItem.Size = new System.Drawing.Size(283, 38);
            this.stergeElementLVToolStripMenuItem.Text = "Sterge element LV";
            this.stergeElementLVToolStripMenuItem.Click += new System.EventHandler(this.contextMenuStrip4_Opening);
            // 
            // contextMenuStrip5
            // 
            this.contextMenuStrip5.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergeElementTVToolStripMenuItem});
            this.contextMenuStrip5.Name = "contextMenuStrip5";
            this.contextMenuStrip5.Size = new System.Drawing.Size(287, 42);
            // 
            // stergeElementTVToolStripMenuItem
            // 
            this.stergeElementTVToolStripMenuItem.Name = "stergeElementTVToolStripMenuItem";
            this.stergeElementTVToolStripMenuItem.Size = new System.Drawing.Size(286, 38);
            this.stergeElementTVToolStripMenuItem.Text = "Sterge Element TV";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 609);
            this.Controls.Add(this.btnPopulareTV);
            this.Controls.Add(this.btnStergeElemLV);
            this.Controls.Add(this.btnPreluareLV);
            this.Controls.Add(this.tbStudenti);
            this.Controls.Add(this.tvStudenti);
            this.Controls.Add(this.lvStudenti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip4.ResumeLayout(false);
            this.contextMenuStrip5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvStudenti;
        private System.Windows.Forms.ColumnHeader Matricol;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader Medie;
        private System.Windows.Forms.ColumnHeader Observatie;
        private System.Windows.Forms.TreeView tvStudenti;
        private System.Windows.Forms.TextBox tbStudenti;
        private System.Windows.Forms.Button btnPreluareLV;
        private System.Windows.Forms.Button btnStergeElemLV;
        private System.Windows.Forms.Button btnPopulareTV;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.Windows.Forms.ToolStripMenuItem stergeElementLVToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip5;
        private System.Windows.Forms.ToolStripMenuItem stergeElementTVToolStripMenuItem;
    }
}

