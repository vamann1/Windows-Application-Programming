namespace Sub4_2026
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnAdaugaObs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbObs = new System.Windows.Forms.TextBox();
            this.Observatii = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frecvente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnStergeDefinitiv = new System.Windows.Forms.Button();
            this.err1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbMedie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grafic1 = new Sub4_2026.Grafic();
            this.grafic2 = new Sub4_2026.Grafic();
            this.btnAfiseazaGrafice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Observatii,
            this.Frecvente});
            this.dgv.Location = new System.Drawing.Point(490, 12);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 72;
            this.dgv.RowTemplate.Height = 31;
            this.dgv.Size = new System.Drawing.Size(593, 333);
            this.dgv.TabIndex = 0;
            this.dgv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgv_KeyPress);
            // 
            // btnAdaugaObs
            // 
            this.btnAdaugaObs.Location = new System.Drawing.Point(55, 128);
            this.btnAdaugaObs.Name = "btnAdaugaObs";
            this.btnAdaugaObs.Size = new System.Drawing.Size(186, 48);
            this.btnAdaugaObs.TabIndex = 1;
            this.btnAdaugaObs.Text = "Adauga observatie";
            this.btnAdaugaObs.UseVisualStyleBackColor = true;
            this.btnAdaugaObs.Click += new System.EventHandler(this.btnColectivitateNoua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adauga observatie:";
            // 
            // tbObs
            // 
            this.tbObs.Location = new System.Drawing.Point(55, 78);
            this.tbObs.Name = "tbObs";
            this.tbObs.Size = new System.Drawing.Size(175, 29);
            this.tbObs.TabIndex = 4;
            this.tbObs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbObs_KeyPress);
            // 
            // Observatii
            // 
            this.Observatii.HeaderText = "Observatii";
            this.Observatii.MinimumWidth = 9;
            this.Observatii.Name = "Observatii";
            this.Observatii.Width = 175;
            // 
            // Frecvente
            // 
            this.Frecvente.HeaderText = "Frecvente";
            this.Frecvente.MinimumWidth = 9;
            this.Frecvente.Name = "Frecvente";
            this.Frecvente.Width = 175;
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(490, 367);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(228, 40);
            this.btnModifica.TabIndex = 5;
            this.btnModifica.Text = "Modifica observatie";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnStergeDefinitiv
            // 
            this.btnStergeDefinitiv.Location = new System.Drawing.Point(861, 368);
            this.btnStergeDefinitiv.Name = "btnStergeDefinitiv";
            this.btnStergeDefinitiv.Size = new System.Drawing.Size(222, 39);
            this.btnStergeDefinitiv.TabIndex = 6;
            this.btnStergeDefinitiv.Text = "Sterge observatie";
            this.btnStergeDefinitiv.UseVisualStyleBackColor = true;
            this.btnStergeDefinitiv.Click += new System.EventHandler(this.btnStergeDefinitiv_Click);
            // 
            // err1
            // 
            this.err1.ContainerControl = this;
            // 
            // tbMedie
            // 
            this.tbMedie.Location = new System.Drawing.Point(55, 231);
            this.tbMedie.Name = "tbMedie";
            this.tbMedie.ReadOnly = true;
            this.tbMedie.Size = new System.Drawing.Size(194, 29);
            this.tbMedie.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Media aritmetica ponderata:";
            // 
            // grafic1
            // 
            this.grafic1.Location = new System.Drawing.Point(55, 362);
            this.grafic1.Name = "grafic1";
            this.grafic1.Size = new System.Drawing.Size(380, 254);
            this.grafic1.TabIndex = 9;
            this.grafic1.Text = "grafic1";
            // 
            // grafic2
            // 
            this.grafic2.Location = new System.Drawing.Point(502, 420);
            this.grafic2.Name = "grafic2";
            this.grafic2.Size = new System.Drawing.Size(566, 183);
            this.grafic2.TabIndex = 10;
            this.grafic2.Text = "grafic2";
            // 
            // btnAfiseazaGrafice
            // 
            this.btnAfiseazaGrafice.Location = new System.Drawing.Point(41, 289);
            this.btnAfiseazaGrafice.Name = "btnAfiseazaGrafice";
            this.btnAfiseazaGrafice.Size = new System.Drawing.Size(261, 55);
            this.btnAfiseazaGrafice.TabIndex = 11;
            this.btnAfiseazaGrafice.Text = "Afiseaza grafice";
            this.btnAfiseazaGrafice.UseVisualStyleBackColor = true;
            this.btnAfiseazaGrafice.Click += new System.EventHandler(this.btnAfiseazaGrafice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 714);
            this.Controls.Add(this.btnAfiseazaGrafice);
            this.Controls.Add(this.grafic2);
            this.Controls.Add(this.grafic1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMedie);
            this.Controls.Add(this.btnStergeDefinitiv);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.tbObs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdaugaObs);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnAdaugaObs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbObs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observatii;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frecvente;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnStergeDefinitiv;
        private System.Windows.Forms.ErrorProvider err1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMedie;
        private System.Windows.Forms.Button btnAfiseazaGrafice;
        private Grafic grafic2;
        private Grafic grafic1;
    }
}

