namespace Sub3_2026
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
            this.lv = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbObs = new System.Windows.Forms.TextBox();
            this.btnAdaugaObs = new System.Windows.Forms.Button();
            this.Observatie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pondere = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.err1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.tbModificare = new System.Windows.Forms.TextBox();
            this.btnGrafic = new System.Windows.Forms.Button();
            this.grafic1 = new Sub3_2026.Grafic();
            ((System.ComponentModel.ISupportInitialize)(this.err1)).BeginInit();
            this.SuspendLayout();
            // 
            // lv
            // 
            this.lv.CheckBoxes = true;
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Observatie,
            this.Pondere});
            this.lv.GridLines = true;
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(473, 43);
            this.lv.MultiSelect = false;
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(499, 317);
            this.lv.TabIndex = 0;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            this.lv.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lv_ItemChecked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adauga observatie";
            // 
            // tbObs
            // 
            this.tbObs.Location = new System.Drawing.Point(27, 100);
            this.tbObs.Name = "tbObs";
            this.tbObs.Size = new System.Drawing.Size(167, 29);
            this.tbObs.TabIndex = 2;
            this.tbObs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbObs_KeyPress);
            // 
            // btnAdaugaObs
            // 
            this.btnAdaugaObs.Location = new System.Drawing.Point(27, 165);
            this.btnAdaugaObs.Name = "btnAdaugaObs";
            this.btnAdaugaObs.Size = new System.Drawing.Size(211, 51);
            this.btnAdaugaObs.TabIndex = 3;
            this.btnAdaugaObs.Text = "Adauga obs";
            this.btnAdaugaObs.UseVisualStyleBackColor = true;
            this.btnAdaugaObs.Click += new System.EventHandler(this.btnAdaugaObs_Click);
            // 
            // Observatie
            // 
            this.Observatie.Text = "Observatie";
            this.Observatie.Width = 121;
            // 
            // Pondere
            // 
            this.Pondere.Text = "Pondere";
            this.Pondere.Width = 97;
            // 
            // err1
            // 
            this.err1.ContainerControl = this;
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(473, 387);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(165, 63);
            this.btnModifica.TabIndex = 4;
            this.btnModifica.Text = "Modifica observatie";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(792, 387);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(162, 66);
            this.btnStergere.TabIndex = 5;
            this.btnStergere.Text = "Sterge observatie";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // tbModificare
            // 
            this.tbModificare.Location = new System.Drawing.Point(485, 473);
            this.tbModificare.Name = "tbModificare";
            this.tbModificare.Size = new System.Drawing.Size(152, 29);
            this.tbModificare.TabIndex = 6;
            this.tbModificare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbModificare_KeyPress);
            // 
            // btnGrafic
            // 
            this.btnGrafic.Location = new System.Drawing.Point(260, 166);
            this.btnGrafic.Name = "btnGrafic";
            this.btnGrafic.Size = new System.Drawing.Size(161, 50);
            this.btnGrafic.TabIndex = 8;
            this.btnGrafic.Text = "Afiseaza grafic";
            this.btnGrafic.UseVisualStyleBackColor = true;
            this.btnGrafic.Click += new System.EventHandler(this.btnGrafic_Click);
            // 
            // grafic1
            // 
            this.grafic1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grafic1.Location = new System.Drawing.Point(24, 251);
            this.grafic1.Name = "grafic1";
            this.grafic1.Size = new System.Drawing.Size(397, 332);
            this.grafic1.TabIndex = 7;
            this.grafic1.Text = "grafic1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 698);
            this.Controls.Add(this.btnGrafic);
            this.Controls.Add(this.grafic1);
            this.Controls.Add(this.tbModificare);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnAdaugaObs);
            this.Controls.Add(this.tbObs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.err1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbObs;
        private System.Windows.Forms.Button btnAdaugaObs;
        private System.Windows.Forms.ColumnHeader Observatie;
        private System.Windows.Forms.ColumnHeader Pondere;
        private System.Windows.Forms.ErrorProvider err1;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.TextBox tbModificare;
        private Grafic grafic1;
        private System.Windows.Forms.Button btnGrafic;
    }
}

