namespace tempproj
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
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.tbVarsta = new System.Windows.Forms.TextBox();
            this.tbMatricol = new System.Windows.Forms.TextBox();
            this.tbMedie = new System.Windows.Forms.TextBox();
            this.tbMaterii = new System.Windows.Forms.TextBox();
            this.btnAdaugaStudent = new System.Windows.Forms.Button();
            this.tv = new System.Windows.Forms.TreeView();
            this.btnAfiseazaStudenti = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNume
            // 
            this.tbNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNume.Location = new System.Drawing.Point(12, 63);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(181, 39);
            this.tbNume.TabIndex = 0;
            // 
            // tbPrenume
            // 
            this.tbPrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrenume.Location = new System.Drawing.Point(226, 63);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(164, 39);
            this.tbPrenume.TabIndex = 1;
            // 
            // tbVarsta
            // 
            this.tbVarsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVarsta.Location = new System.Drawing.Point(414, 63);
            this.tbVarsta.Name = "tbVarsta";
            this.tbVarsta.Size = new System.Drawing.Size(158, 39);
            this.tbVarsta.TabIndex = 2;
            // 
            // tbMatricol
            // 
            this.tbMatricol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMatricol.Location = new System.Drawing.Point(18, 127);
            this.tbMatricol.Name = "tbMatricol";
            this.tbMatricol.Size = new System.Drawing.Size(174, 39);
            this.tbMatricol.TabIndex = 3;
            // 
            // tbMedie
            // 
            this.tbMedie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMedie.Location = new System.Drawing.Point(226, 127);
            this.tbMedie.Name = "tbMedie";
            this.tbMedie.Size = new System.Drawing.Size(156, 39);
            this.tbMedie.TabIndex = 4;
            // 
            // tbMaterii
            // 
            this.tbMaterii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaterii.Location = new System.Drawing.Point(414, 127);
            this.tbMaterii.Name = "tbMaterii";
            this.tbMaterii.Size = new System.Drawing.Size(167, 39);
            this.tbMaterii.TabIndex = 5;
            // 
            // btnAdaugaStudent
            // 
            this.btnAdaugaStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaStudent.Location = new System.Drawing.Point(12, 228);
            this.btnAdaugaStudent.Name = "btnAdaugaStudent";
            this.btnAdaugaStudent.Size = new System.Drawing.Size(254, 54);
            this.btnAdaugaStudent.TabIndex = 6;
            this.btnAdaugaStudent.Text = "adauga student";
            this.btnAdaugaStudent.UseVisualStyleBackColor = true;
            this.btnAdaugaStudent.Click += new System.EventHandler(this.btnAdaugaStudent_Click);
            // 
            // tv
            // 
            this.tv.Location = new System.Drawing.Point(638, 63);
            this.tv.Name = "tv";
            this.tv.Size = new System.Drawing.Size(457, 431);
            this.tv.TabIndex = 7;
            // 
            // btnAfiseazaStudenti
            // 
            this.btnAfiseazaStudenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfiseazaStudenti.Location = new System.Drawing.Point(659, 545);
            this.btnAfiseazaStudenti.Name = "btnAfiseazaStudenti";
            this.btnAfiseazaStudenti.Size = new System.Drawing.Size(239, 58);
            this.btnAfiseazaStudenti.TabIndex = 8;
            this.btnAfiseazaStudenti.Text = "Afiseaza studenti";
            this.btnAfiseazaStudenti.UseVisualStyleBackColor = true;
            this.btnAfiseazaStudenti.Click += new System.EventHandler(this.btnAfiseazaStudenti_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1142, 38);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.readToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(62, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.readToolStripMenuItem.Text = "Read";
            this.readToolStripMenuItem.Click += new System.EventHandler(this.readToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 739);
            this.Controls.Add(this.btnAfiseazaStudenti);
            this.Controls.Add(this.tv);
            this.Controls.Add(this.btnAdaugaStudent);
            this.Controls.Add(this.tbMaterii);
            this.Controls.Add(this.tbMedie);
            this.Controls.Add(this.tbMatricol);
            this.Controls.Add(this.tbVarsta);
            this.Controls.Add(this.tbPrenume);
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
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.TextBox tbVarsta;
        private System.Windows.Forms.TextBox tbMatricol;
        private System.Windows.Forms.TextBox tbMedie;
        private System.Windows.Forms.TextBox tbMaterii;
        private System.Windows.Forms.Button btnAdaugaStudent;
        private System.Windows.Forms.TreeView tv;
        private System.Windows.Forms.Button btnAfiseazaStudenti;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
    }
}

