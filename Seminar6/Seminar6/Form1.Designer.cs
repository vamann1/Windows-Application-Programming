namespace Seminar6
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
            this.Matricol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Medie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Observatie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tv = new System.Windows.Forms.TreeView();
            this.btnPopulareLv = new System.Windows.Forms.Button();
            this.btnStergeElement = new System.Windows.Forms.Button();
            this.btnPopulareTv = new System.Windows.Forms.Button();
            this.tbStudenti = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv
            // 
            this.lv.CheckBoxes = true;
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Matricol,
            this.Nume,
            this.Medie,
            this.Observatie});
            this.lv.GridLines = true;
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(15, 29);
            this.lv.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(439, 376);
            this.lv.TabIndex = 0;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            this.lv.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lv_ItemChecked);
            // 
            // Matricol
            // 
            this.Matricol.Text = "Matricol";
            this.Matricol.Width = 109;
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            this.Nume.Width = 73;
            // 
            // Medie
            // 
            this.Medie.Text = "Medie";
            this.Medie.Width = 113;
            // 
            // Observatie
            // 
            this.Observatie.Text = "Observatie";
            this.Observatie.Width = 121;
            // 
            // tv
            // 
            this.tv.Location = new System.Drawing.Point(689, 29);
            this.tv.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tv.Name = "tv";
            this.tv.Size = new System.Drawing.Size(347, 376);
            this.tv.TabIndex = 1;
            this.tv.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_AfterSelect);
            // 
            // btnPopulareLv
            // 
            this.btnPopulareLv.Location = new System.Drawing.Point(15, 426);
            this.btnPopulareLv.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnPopulareLv.Name = "btnPopulareLv";
            this.btnPopulareLv.Size = new System.Drawing.Size(306, 131);
            this.btnPopulareLv.TabIndex = 2;
            this.btnPopulareLv.Text = "Populeaza LV";
            this.btnPopulareLv.UseVisualStyleBackColor = true;
            this.btnPopulareLv.Click += new System.EventHandler(this.btnPopulareLv_Click);
            // 
            // btnStergeElement
            // 
            this.btnStergeElement.Location = new System.Drawing.Point(392, 426);
            this.btnStergeElement.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnStergeElement.Name = "btnStergeElement";
            this.btnStergeElement.Size = new System.Drawing.Size(240, 138);
            this.btnStergeElement.TabIndex = 3;
            this.btnStergeElement.Text = "button1";
            this.btnStergeElement.UseVisualStyleBackColor = true;
            this.btnStergeElement.Click += new System.EventHandler(this.btnStergeElement_Click);
            // 
            // btnPopulareTv
            // 
            this.btnPopulareTv.Location = new System.Drawing.Point(689, 426);
            this.btnPopulareTv.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnPopulareTv.Name = "btnPopulareTv";
            this.btnPopulareTv.Size = new System.Drawing.Size(314, 122);
            this.btnPopulareTv.TabIndex = 4;
            this.btnPopulareTv.Text = "Populeaza TV";
            this.btnPopulareTv.UseVisualStyleBackColor = true;
            this.btnPopulareTv.Click += new System.EventHandler(this.btnPopulareTv_Click);
            // 
            // tbStudenti
            // 
            this.tbStudenti.Location = new System.Drawing.Point(1844, 199);
            this.tbStudenti.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbStudenti.Multiline = true;
            this.tbStudenti.Name = "tbStudenti";
            this.tbStudenti.ReadOnly = true;
            this.tbStudenti.Size = new System.Drawing.Size(453, 790);
            this.tbStudenti.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(271, 78);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(253, 36);
            this.toolStripMenuItem1.Text = "Sterge Element LV";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(256, 40);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(255, 36);
            this.toolStripMenuItem2.Text = "Sterge Element TV";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 600);
            this.Controls.Add(this.tbStudenti);
            this.Controls.Add(this.btnPopulareTv);
            this.Controls.Add(this.btnStergeElement);
            this.Controls.Add(this.btnPopulareLv);
            this.Controls.Add(this.tv);
            this.Controls.Add(this.lv);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader Matricol;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader Medie;
        private System.Windows.Forms.ColumnHeader Observatie;
        private System.Windows.Forms.TreeView tv;
        private System.Windows.Forms.Button btnPopulareLv;
        private System.Windows.Forms.Button btnStergeElement;
        private System.Windows.Forms.Button btnPopulareTv;
        private System.Windows.Forms.TextBox tbStudenti;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

