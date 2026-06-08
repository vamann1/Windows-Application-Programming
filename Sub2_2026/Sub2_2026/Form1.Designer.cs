namespace Sub2_2026
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
            this.lv = new System.Windows.Forms.ListView();
            this.Observatie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Indice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbObs = new System.Windows.Forms.TextBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Observatie,
            this.Indice});
            this.lv.FullRowSelect = true;
            this.lv.GridLines = true;
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(417, 29);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(596, 506);
            this.lv.TabIndex = 0;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            this.lv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv_KeyDown);
            // 
            // Observatie
            // 
            this.Observatie.Text = "Observatie";
            this.Observatie.Width = 159;
            // 
            // Indice
            // 
            this.Indice.Text = "Indice";
            this.Indice.Width = 181;
            // 
            // tbObs
            // 
            this.tbObs.Location = new System.Drawing.Point(44, 29);
            this.tbObs.Name = "tbObs";
            this.tbObs.Size = new System.Drawing.Size(195, 29);
            this.tbObs.TabIndex = 1;
            this.tbObs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbObs_KeyDown);
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(42, 95);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(205, 44);
            this.btnAdauga.TabIndex = 2;
            this.btnAdauga.Text = "Adauga observatie";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(52, 198);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(186, 52);
            this.btnModifica.TabIndex = 3;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(51, 292);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(186, 76);
            this.btnSterge.TabIndex = 4;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(45, 442);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(201, 92);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 733);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.tbObs);
            this.Controls.Add(this.lv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader Observatie;
        private System.Windows.Forms.ColumnHeader Indice;
        private System.Windows.Forms.TextBox tbObs;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Button btnPrint;
    }
}

