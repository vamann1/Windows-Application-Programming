namespace Sub1_2026
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Observatii = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Indici = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbObs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnColectivitateNoua = new System.Windows.Forms.Button();
            this.btnObsNoi = new System.Windows.Forms.Button();
            this.tbAfisareNume = new System.Windows.Forms.TextBox();
            this.err1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnModificaObs = new System.Windows.Forms.Button();
            this.btnStergeObs = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.ppd = new System.Windows.Forms.PrintPreviewDialog();
            this.pdoc = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Observatii,
            this.Indici});
            this.dgv.Location = new System.Drawing.Point(431, 76);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 72;
            this.dgv.RowTemplate.Height = 31;
            this.dgv.Size = new System.Drawing.Size(581, 383);
            this.dgv.TabIndex = 0;
            this.dgv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgv_KeyPress);
            // 
            // Observatii
            // 
            this.Observatii.HeaderText = "Observatii";
            this.Observatii.MinimumWidth = 9;
            this.Observatii.Name = "Observatii";
            this.Observatii.Width = 175;
            // 
            // Indici
            // 
            this.Indici.HeaderText = "Indici";
            this.Indici.MinimumWidth = 9;
            this.Indici.Name = "Indici";
            this.Indici.Width = 175;
            // 
            // tbObs
            // 
            this.tbObs.Location = new System.Drawing.Point(47, 153);
            this.tbObs.Name = "tbObs";
            this.tbObs.Size = new System.Drawing.Size(305, 29);
            this.tbObs.TabIndex = 1;
            this.tbObs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbObs_KeyPress);
            this.tbObs.Validating += new System.ComponentModel.CancelEventHandler(this.tbObs_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Introduce observatii separate prin ,";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(45, 76);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(195, 29);
            this.tbNume.TabIndex = 3;
            this.tbNume.Validating += new System.ComponentModel.CancelEventHandler(this.tbNume_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Introduce numele colectivitatii:";
            // 
            // btnColectivitateNoua
            // 
            this.btnColectivitateNoua.Location = new System.Drawing.Point(49, 208);
            this.btnColectivitateNoua.Name = "btnColectivitateNoua";
            this.btnColectivitateNoua.Size = new System.Drawing.Size(303, 33);
            this.btnColectivitateNoua.TabIndex = 5;
            this.btnColectivitateNoua.Text = "Adauga colectivitate noua ";
            this.btnColectivitateNoua.UseVisualStyleBackColor = true;
            this.btnColectivitateNoua.Click += new System.EventHandler(this.btnColectivitateNoua_Click);
            // 
            // btnObsNoi
            // 
            this.btnObsNoi.Location = new System.Drawing.Point(49, 275);
            this.btnObsNoi.Name = "btnObsNoi";
            this.btnObsNoi.Size = new System.Drawing.Size(303, 33);
            this.btnObsNoi.TabIndex = 6;
            this.btnObsNoi.Text = "Adauga observatii noi ";
            this.btnObsNoi.UseVisualStyleBackColor = true;
            this.btnObsNoi.Click += new System.EventHandler(this.btnObsNoi_Click);
            // 
            // tbAfisareNume
            // 
            this.tbAfisareNume.Location = new System.Drawing.Point(431, 36);
            this.tbAfisareNume.Name = "tbAfisareNume";
            this.tbAfisareNume.ReadOnly = true;
            this.tbAfisareNume.Size = new System.Drawing.Size(193, 29);
            this.tbAfisareNume.TabIndex = 7;
            // 
            // err1
            // 
            this.err1.ContainerControl = this;
            // 
            // btnModificaObs
            // 
            this.btnModificaObs.Location = new System.Drawing.Point(426, 494);
            this.btnModificaObs.Name = "btnModificaObs";
            this.btnModificaObs.Size = new System.Drawing.Size(198, 38);
            this.btnModificaObs.TabIndex = 8;
            this.btnModificaObs.Text = "Modifica observatie";
            this.btnModificaObs.UseVisualStyleBackColor = true;
            this.btnModificaObs.Click += new System.EventHandler(this.btnModificaObs_Click);
            // 
            // btnStergeObs
            // 
            this.btnStergeObs.Location = new System.Drawing.Point(821, 494);
            this.btnStergeObs.Name = "btnStergeObs";
            this.btnStergeObs.Size = new System.Drawing.Size(191, 38);
            this.btnStergeObs.TabIndex = 9;
            this.btnStergeObs.Text = "Sterge observatie";
            this.btnStergeObs.UseVisualStyleBackColor = true;
            this.btnStergeObs.Click += new System.EventHandler(this.btnStergeObs_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(58, 427);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(293, 88);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // ppd
            // 
            this.ppd.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppd.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppd.ClientSize = new System.Drawing.Size(400, 300);
            this.ppd.Document = this.pdoc;
            this.ppd.Enabled = true;
            this.ppd.Icon = ((System.Drawing.Icon)(resources.GetObject("ppd.Icon")));
            this.ppd.Name = "ppd";
            this.ppd.Visible = false;
            // 
            // pdoc
            // 
            this.pdoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdoc_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 639);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnStergeObs);
            this.Controls.Add(this.btnModificaObs);
            this.Controls.Add(this.tbAfisareNume);
            this.Controls.Add(this.btnObsNoi);
            this.Controls.Add(this.btnColectivitateNoua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbObs);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Observatii;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indici;
        private System.Windows.Forms.TextBox tbObs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnColectivitateNoua;
        private System.Windows.Forms.Button btnObsNoi;
        private System.Windows.Forms.TextBox tbAfisareNume;
        private System.Windows.Forms.ErrorProvider err1;
        private System.Windows.Forms.Button btnStergeObs;
        private System.Windows.Forms.Button btnModificaObs;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintPreviewDialog ppd;
        private System.Drawing.Printing.PrintDocument pdoc;
    }
}

