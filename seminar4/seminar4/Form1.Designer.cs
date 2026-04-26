namespace seminar4
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
            this.tbFacultate = new System.Windows.Forms.TextBox();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.tbStud = new System.Windows.Forms.TextBox();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(66, 25);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(156, 26);
            this.tbNume.TabIndex = 0;
            this.tbNume.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbFacultate
            // 
            this.tbFacultate.Location = new System.Drawing.Point(66, 57);
            this.tbFacultate.Name = "tbFacultate";
            this.tbFacultate.Size = new System.Drawing.Size(156, 26);
            this.tbFacultate.TabIndex = 1;
            this.tbFacultate.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(66, 89);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(156, 26);
            this.tbNote.TabIndex = 2;
            this.tbNote.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(66, 121);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(156, 58);
            this.btnAdauga.TabIndex = 3;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // tbStud
            // 
            this.tbStud.Location = new System.Drawing.Point(355, 25);
            this.tbStud.Multiline = true;
            this.tbStud.Name = "tbStud";
            this.tbStud.Size = new System.Drawing.Size(298, 90);
            this.tbStud.TabIndex = 4;
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Location = new System.Drawing.Point(355, 121);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(157, 58);
            this.btnAfiseaza.TabIndex = 5;
            this.btnAfiseaza.Text = "Afiseaza mai multi";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            this.btnAfiseaza.Click += new System.EventHandler(this.btnAfiseaza_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 426);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.tbStud);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.tbFacultate);
            this.Controls.Add(this.tbNume);
            this.Name = "Form1";
            this.Text = "PrimaFereastra";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbFacultate;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.TextBox tbStud;
        private System.Windows.Forms.Button btnAfiseaza;
    }
}

