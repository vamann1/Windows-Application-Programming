namespace SubPersoana
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
            this.tbMatricol = new System.Windows.Forms.TextBox();
            this.tbMedie = new System.Windows.Forms.TextBox();
            this.tbMaterii = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.tbVarsta = new System.Windows.Forms.TextBox();
            this.btnadaugaStudent = new System.Windows.Forms.Button();
            this.tv = new System.Windows.Forms.TreeView();
            this.btnAfiseazaStudenti = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(14, 118);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(150, 29);
            this.tbNume.TabIndex = 0;
            // 
            // tbMatricol
            // 
            this.tbMatricol.Location = new System.Drawing.Point(14, 219);
            this.tbMatricol.Name = "tbMatricol";
            this.tbMatricol.Size = new System.Drawing.Size(150, 29);
            this.tbMatricol.TabIndex = 3;
            // 
            // tbMedie
            // 
            this.tbMedie.Location = new System.Drawing.Point(193, 219);
            this.tbMedie.Name = "tbMedie";
            this.tbMedie.Size = new System.Drawing.Size(150, 29);
            this.tbMedie.TabIndex = 4;
            // 
            // tbMaterii
            // 
            this.tbMaterii.Location = new System.Drawing.Point(379, 219);
            this.tbMaterii.Name = "tbMaterii";
            this.tbMaterii.Size = new System.Drawing.Size(212, 29);
            this.tbMaterii.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prenume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Varsta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Matricol";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Medie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Materii";
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(193, 118);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(150, 29);
            this.tbPrenume.TabIndex = 12;
            // 
            // tbVarsta
            // 
            this.tbVarsta.Location = new System.Drawing.Point(379, 118);
            this.tbVarsta.Name = "tbVarsta";
            this.tbVarsta.Size = new System.Drawing.Size(150, 29);
            this.tbVarsta.TabIndex = 13;
            // 
            // btnadaugaStudent
            // 
            this.btnadaugaStudent.Location = new System.Drawing.Point(24, 289);
            this.btnadaugaStudent.Name = "btnadaugaStudent";
            this.btnadaugaStudent.Size = new System.Drawing.Size(229, 56);
            this.btnadaugaStudent.TabIndex = 14;
            this.btnadaugaStudent.Text = "Adauga student";
            this.btnadaugaStudent.UseVisualStyleBackColor = true;
            this.btnadaugaStudent.Click += new System.EventHandler(this.btnadaugaStudent_Click);
            // 
            // tv
            // 
            this.tv.Location = new System.Drawing.Point(664, 48);
            this.tv.Name = "tv";
            this.tv.Size = new System.Drawing.Size(395, 397);
            this.tv.TabIndex = 15;
            // 
            // btnAfiseazaStudenti
            // 
            this.btnAfiseazaStudenti.Location = new System.Drawing.Point(664, 467);
            this.btnAfiseazaStudenti.Name = "btnAfiseazaStudenti";
            this.btnAfiseazaStudenti.Size = new System.Drawing.Size(209, 51);
            this.btnAfiseazaStudenti.TabIndex = 16;
            this.btnAfiseazaStudenti.Text = "Afiseaza studenti";
            this.btnAfiseazaStudenti.UseVisualStyleBackColor = true;
            this.btnAfiseazaStudenti.Click += new System.EventHandler(this.btnAfiseazaStudenti_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1101, 38);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareToolStripMenuItem,
            this.deserializareToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(85, 34);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // serializareToolStripMenuItem
            // 
            this.serializareToolStripMenuItem.Name = "serializareToolStripMenuItem";
            this.serializareToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.serializareToolStripMenuItem.Text = "Serializare";
            this.serializareToolStripMenuItem.Click += new System.EventHandler(this.serializareToolStripMenuItem_Click);
            // 
            // deserializareToolStripMenuItem
            // 
            this.deserializareToolStripMenuItem.Name = "deserializareToolStripMenuItem";
            this.deserializareToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.deserializareToolStripMenuItem.Text = "Deserializare";
            this.deserializareToolStripMenuItem.Click += new System.EventHandler(this.deserializareToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 789);
            this.Controls.Add(this.btnAfiseazaStudenti);
            this.Controls.Add(this.tv);
            this.Controls.Add(this.btnadaugaStudent);
            this.Controls.Add(this.tbVarsta);
            this.Controls.Add(this.tbPrenume);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMaterii);
            this.Controls.Add(this.tbMedie);
            this.Controls.Add(this.tbMatricol);
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
        private System.Windows.Forms.TextBox tbMatricol;
        private System.Windows.Forms.TextBox tbMedie;
        private System.Windows.Forms.TextBox tbMaterii;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.TextBox tbVarsta;
        private System.Windows.Forms.Button btnadaugaStudent;
        private System.Windows.Forms.TreeView tv;
        private System.Windows.Forms.Button btnAfiseazaStudenti;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializareToolStripMenuItem;
    }
}

