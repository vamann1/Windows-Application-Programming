namespace SubAngajat
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
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbOreLucrate = new System.Windows.Forms.TextBox();
            this.tbSalariuOrar = new System.Windows.Forms.TextBox();
            this.lv = new System.Windows.Forms.ListView();
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OreLucrate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SalariuOrar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Salariu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdaugaAngajat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAfiseazaAngajati = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salveazaFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaFisierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.citesteFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(16, 93);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(151, 29);
            this.tbNume.TabIndex = 0;
            // 
            // tbOreLucrate
            // 
            this.tbOreLucrate.Location = new System.Drawing.Point(191, 96);
            this.tbOreLucrate.Name = "tbOreLucrate";
            this.tbOreLucrate.Size = new System.Drawing.Size(124, 29);
            this.tbOreLucrate.TabIndex = 1;
            // 
            // tbSalariuOrar
            // 
            this.tbSalariuOrar.Location = new System.Drawing.Point(352, 96);
            this.tbSalariuOrar.Name = "tbSalariuOrar";
            this.tbSalariuOrar.Size = new System.Drawing.Size(119, 29);
            this.tbSalariuOrar.TabIndex = 2;
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nume,
            this.OreLucrate,
            this.SalariuOrar,
            this.Salariu});
            this.lv.GridLines = true;
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(544, 54);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(418, 357);
            this.lv.TabIndex = 3;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            this.lv.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lv_ItemChecked);
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            this.Nume.Width = 103;
            // 
            // OreLucrate
            // 
            this.OreLucrate.Text = "Ore lucrate";
            this.OreLucrate.Width = 113;
            // 
            // SalariuOrar
            // 
            this.SalariuOrar.Text = "Salariu Orar";
            this.SalariuOrar.Width = 112;
            // 
            // Salariu
            // 
            this.Salariu.Text = "Salariu";
            this.Salariu.Width = 92;
            // 
            // btnAdaugaAngajat
            // 
            this.btnAdaugaAngajat.Location = new System.Drawing.Point(12, 146);
            this.btnAdaugaAngajat.Name = "btnAdaugaAngajat";
            this.btnAdaugaAngajat.Size = new System.Drawing.Size(175, 57);
            this.btnAdaugaAngajat.TabIndex = 4;
            this.btnAdaugaAngajat.Text = "Adauga angajat";
            this.btnAdaugaAngajat.UseVisualStyleBackColor = true;
            this.btnAdaugaAngajat.Click += new System.EventHandler(this.btnAdaugaAngajat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ore lucrate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Salariu orar";
            // 
            // btnAfiseazaAngajati
            // 
            this.btnAfiseazaAngajati.Location = new System.Drawing.Point(544, 448);
            this.btnAfiseazaAngajati.Name = "btnAfiseazaAngajati";
            this.btnAfiseazaAngajati.Size = new System.Drawing.Size(218, 61);
            this.btnAfiseazaAngajati.TabIndex = 8;
            this.btnAfiseazaAngajati.Text = "Afiseaza angajati";
            this.btnAfiseazaAngajati.UseVisualStyleBackColor = true;
            this.btnAfiseazaAngajati.Click += new System.EventHandler(this.btnAfiseazaAngajati_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaFisierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1122, 38);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salveazaFisierToolStripMenuItem
            // 
            this.salveazaFisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaFisierToolStripMenuItem1,
            this.citesteFisierToolStripMenuItem});
            this.salveazaFisierToolStripMenuItem.Name = "salveazaFisierToolStripMenuItem";
            this.salveazaFisierToolStripMenuItem.Size = new System.Drawing.Size(90, 34);
            this.salveazaFisierToolStripMenuItem.Text = "Meniu";
            // 
            // salveazaFisierToolStripMenuItem1
            // 
            this.salveazaFisierToolStripMenuItem1.Name = "salveazaFisierToolStripMenuItem1";
            this.salveazaFisierToolStripMenuItem1.Size = new System.Drawing.Size(315, 40);
            this.salveazaFisierToolStripMenuItem1.Text = "Salveaza fisier";
            this.salveazaFisierToolStripMenuItem1.Click += new System.EventHandler(this.salveazaFisierToolStripMenuItem1_Click);
            // 
            // citesteFisierToolStripMenuItem
            // 
            this.citesteFisierToolStripMenuItem.Name = "citesteFisierToolStripMenuItem";
            this.citesteFisierToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.citesteFisierToolStripMenuItem.Text = "Citeste fisier";
            this.citesteFisierToolStripMenuItem.Click += new System.EventHandler(this.citesteFisierToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 303);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 29);
            this.textBox1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nume firma";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 769);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAfiseazaAngajati);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdaugaAngajat);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.tbSalariuOrar);
            this.Controls.Add(this.tbOreLucrate);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbOreLucrate;
        private System.Windows.Forms.TextBox tbSalariuOrar;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader OreLucrate;
        private System.Windows.Forms.ColumnHeader SalariuOrar;
        private System.Windows.Forms.ColumnHeader Salariu;
        private System.Windows.Forms.Button btnAdaugaAngajat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAfiseazaAngajati;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salveazaFisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaFisierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem citesteFisierToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}

