namespace Bar_gr
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gv = new System.Windows.Forms.DataGridView();
            this.Valori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gr = new Bar_gr.Grafic();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.gv);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.gr);
            this.splitContainer1.Size = new System.Drawing.Size(1086, 588);
            this.splitContainer1.SplitterDistance = 299;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // gv
            // 
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Valori});
            this.gv.Location = new System.Drawing.Point(0, 0);
            this.gv.Name = "gv";
            this.gv.RowHeadersWidth = 72;
            this.gv.Size = new System.Drawing.Size(168, 188);
            this.gv.TabIndex = 1;
            this.gv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_CellValueChanged);
            // 
            // Valori
            // 
            this.Valori.HeaderText = "Valori";
            this.Valori.MinimumWidth = 9;
            this.Valori.Name = "Valori";
            this.Valori.Width = 175;
            // 
            // gr
            // 
            this.gr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gr.Location = new System.Drawing.Point(0, 0);
            this.gr.Name = "gr";
            this.gr.Size = new System.Drawing.Size(781, 588);
            this.gr.TabIndex = 0;
            this.gr.Text = "grafic1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 588);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valori;
        private Grafic gr;
    }
}

