namespace SubiectPoligon
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaPoligonNouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lv = new System.Windows.Forms.ListView();
            this.Eticheta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CodFigura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.err1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pt = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ptStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err1)).BeginInit();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierToolStripMenuItem,
            this.vizualizareToolStripMenuItem,
            this.adaugaPoligonNouToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1331, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fisierToolStripMenuItem
            // 
            this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareToolStripMenuItem,
            this.deserializareToolStripMenuItem});
            this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(78, 34);
            this.fisierToolStripMenuItem.Text = "Fisier";
            // 
            // serializareToolStripMenuItem
            // 
            this.serializareToolStripMenuItem.Name = "serializareToolStripMenuItem";
            this.serializareToolStripMenuItem.Size = new System.Drawing.Size(249, 40);
            this.serializareToolStripMenuItem.Text = "Serializare";
            this.serializareToolStripMenuItem.Click += new System.EventHandler(this.serializareToolStripMenuItem_Click);
            // 
            // deserializareToolStripMenuItem
            // 
            this.deserializareToolStripMenuItem.Name = "deserializareToolStripMenuItem";
            this.deserializareToolStripMenuItem.Size = new System.Drawing.Size(249, 40);
            this.deserializareToolStripMenuItem.Text = "Deserializare";
            this.deserializareToolStripMenuItem.Click += new System.EventHandler(this.deserializareToolStripMenuItem_Click);
            // 
            // vizualizareToolStripMenuItem
            // 
            this.vizualizareToolStripMenuItem.Name = "vizualizareToolStripMenuItem";
            this.vizualizareToolStripMenuItem.Size = new System.Drawing.Size(131, 34);
            this.vizualizareToolStripMenuItem.Text = "Vizualizare";
            this.vizualizareToolStripMenuItem.Click += new System.EventHandler(this.vizualizareToolStripMenuItem_Click);
            // 
            // adaugaPoligonNouToolStripMenuItem
            // 
            this.adaugaPoligonNouToolStripMenuItem.Name = "adaugaPoligonNouToolStripMenuItem";
            this.adaugaPoligonNouToolStripMenuItem.Size = new System.Drawing.Size(221, 34);
            this.adaugaPoligonNouToolStripMenuItem.Text = "Adauga poligon nou";
            this.adaugaPoligonNouToolStripMenuItem.Click += new System.EventHandler(this.adaugaPoligonNouToolStripMenuItem_Click);
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Eticheta,
            this.CodFigura});
            this.lv.GridLines = true;
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(465, 54);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(409, 352);
            this.lv.TabIndex = 19;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            // 
            // Eticheta
            // 
            this.Eticheta.Text = "Eticheta";
            this.Eticheta.Width = 139;
            // 
            // CodFigura
            // 
            this.CodFigura.Text = "Cod Figura";
            this.CodFigura.Width = 165;
            // 
            // err1
            // 
            this.err1.ContainerControl = this;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(932, 377);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(315, 29);
            this.textBox1.TabIndex = 20;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // pt
            // 
            this.pt.AutoSize = true;
            this.pt.Location = new System.Drawing.Point(927, 334);
            this.pt.Name = "pt";
            this.pt.Size = new System.Drawing.Size(194, 25);
            this.pt.TabIndex = 21;
            this.pt.Text = "Calcul perimetru total";
            // 
            // status
            // 
            this.status.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.ptStatus});
            this.status.Location = new System.Drawing.Point(0, 779);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(1331, 39);
            this.status.TabIndex = 22;
            this.status.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(161, 30);
            this.toolStripStatusLabel1.Text = "Perimetru total: ";
            // 
            // ptStatus
            // 
            this.ptStatus.Name = "ptStatus";
            this.ptStatus.Size = new System.Drawing.Size(61, 30);
            this.ptStatus.Text = "------";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 818);
            this.Controls.Add(this.status);
            this.Controls.Add(this.pt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err1)).EndInit();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizualizareToolStripMenuItem;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader Eticheta;
        private System.Windows.Forms.ColumnHeader CodFigura;
        private System.Windows.Forms.ErrorProvider err1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem serializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializareToolStripMenuItem;
        private System.Windows.Forms.Label pt;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel ptStatus;
        private System.Windows.Forms.ToolStripMenuItem adaugaPoligonNouToolStripMenuItem;
    }
}

