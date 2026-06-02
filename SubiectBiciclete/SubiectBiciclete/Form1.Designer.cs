namespace SubiectBiciclete
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incarcaBicicleteDinTxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incarcaUtilizatoriDinTxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvBiciclete = new System.Windows.Forms.ListView();
            this.codB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statieParcare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kilometri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbUtilizatori = new System.Windows.Forms.ListBox();
            this.utilizatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.afisareIncasariPeBicicletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTraseazaGrafic = new System.Windows.Forms.Button();
            this.ppd = new System.Windows.Forms.PrintPreviewDialog();
            this.pdoc = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatorBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierToolStripMenuItem,
            this.previewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1231, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fisierToolStripMenuItem
            // 
            this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incarcaBicicleteDinTxtToolStripMenuItem,
            this.incarcaUtilizatoriDinTxtToolStripMenuItem,
            this.serializareDateToolStripMenuItem});
            this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(78, 34);
            this.fisierToolStripMenuItem.Text = "Fisier";
            // 
            // incarcaBicicleteDinTxtToolStripMenuItem
            // 
            this.incarcaBicicleteDinTxtToolStripMenuItem.Name = "incarcaBicicleteDinTxtToolStripMenuItem";
            this.incarcaBicicleteDinTxtToolStripMenuItem.Size = new System.Drawing.Size(355, 40);
            this.incarcaBicicleteDinTxtToolStripMenuItem.Text = "Incarca biciclete din txt";
            this.incarcaBicicleteDinTxtToolStripMenuItem.Click += new System.EventHandler(this.incarcaBicicleteDinTxtToolStripMenuItem_Click);
            // 
            // incarcaUtilizatoriDinTxtToolStripMenuItem
            // 
            this.incarcaUtilizatoriDinTxtToolStripMenuItem.Name = "incarcaUtilizatoriDinTxtToolStripMenuItem";
            this.incarcaUtilizatoriDinTxtToolStripMenuItem.Size = new System.Drawing.Size(355, 40);
            this.incarcaUtilizatoriDinTxtToolStripMenuItem.Text = "Incarca utilizatori din txt";
            this.incarcaUtilizatoriDinTxtToolStripMenuItem.Click += new System.EventHandler(this.incarcaUtilizatoriDinTxtToolStripMenuItem_Click);
            // 
            // serializareDateToolStripMenuItem
            // 
            this.serializareDateToolStripMenuItem.Name = "serializareDateToolStripMenuItem";
            this.serializareDateToolStripMenuItem.Size = new System.Drawing.Size(355, 40);
            this.serializareDateToolStripMenuItem.Text = "Serializare date";
            this.serializareDateToolStripMenuItem.Click += new System.EventHandler(this.serializareDateToolStripMenuItem_Click);
            // 
            // previewToolStripMenuItem
            // 
            this.previewToolStripMenuItem.Name = "previewToolStripMenuItem";
            this.previewToolStripMenuItem.Size = new System.Drawing.Size(102, 34);
            this.previewToolStripMenuItem.Text = "Preview";
            this.previewToolStripMenuItem.Click += new System.EventHandler(this.previewToolStripMenuItem_Click);
            // 
            // lvBiciclete
            // 
            this.lvBiciclete.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codB,
            this.statieParcare,
            this.kilometri});
            this.lvBiciclete.ContextMenuStrip = this.contextMenuStrip1;
            this.lvBiciclete.HideSelection = false;
            this.lvBiciclete.Location = new System.Drawing.Point(31, 57);
            this.lvBiciclete.Name = "lvBiciclete";
            this.lvBiciclete.Size = new System.Drawing.Size(604, 308);
            this.lvBiciclete.TabIndex = 1;
            this.lvBiciclete.UseCompatibleStateImageBehavior = false;
            this.lvBiciclete.View = System.Windows.Forms.View.Details;
            this.lvBiciclete.SelectedIndexChanged += new System.EventHandler(this.lvBiciclete_SelectedIndexChanged);
            this.lvBiciclete.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvBiciclete_MouseClick);
            // 
            // codB
            // 
            this.codB.Text = "Cod bicicleta";
            this.codB.Width = 126;
            // 
            // statieParcare
            // 
            this.statieParcare.Text = "Statie Parcare";
            this.statieParcare.Width = 136;
            // 
            // kilometri
            // 
            this.kilometri.Text = "Kilometri Parcursi";
            this.kilometri.Width = 204;
            // 
            // lbUtilizatori
            // 
            this.lbUtilizatori.DataSource = this.utilizatorBindingSource;
            this.lbUtilizatori.DisplayMember = "Nume";
            this.lbUtilizatori.FormattingEnabled = true;
            this.lbUtilizatori.ItemHeight = 24;
            this.lbUtilizatori.Location = new System.Drawing.Point(740, 63);
            this.lbUtilizatori.Name = "lbUtilizatori";
            this.lbUtilizatori.Size = new System.Drawing.Size(388, 244);
            this.lbUtilizatori.TabIndex = 2;
            this.lbUtilizatori.ValueMember = "CodU";
            this.lbUtilizatori.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.lbUtilizatori.DoubleClick += new System.EventHandler(this.lbUtilizatori_DoubleClick);
            // 
            // utilizatorBindingSource
            // 
            this.utilizatorBindingSource.DataSource = typeof(SubiectBiciclete.Utilizator);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afisareIncasariPeBicicletaToolStripMenuItem});
            this.contextMenuStrip1.Margin = new System.Windows.Forms.Padding(200, 400, 0, 0);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(338, 40);
            // 
            // afisareIncasariPeBicicletaToolStripMenuItem
            // 
            this.afisareIncasariPeBicicletaToolStripMenuItem.Name = "afisareIncasariPeBicicletaToolStripMenuItem";
            this.afisareIncasariPeBicicletaToolStripMenuItem.Size = new System.Drawing.Size(337, 36);
            this.afisareIncasariPeBicicletaToolStripMenuItem.Text = "Afisare incasari pe bicicleta";
            this.afisareIncasariPeBicicletaToolStripMenuItem.Click += new System.EventHandler(this.afisareIncasariPeBicicletaToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(379, 443);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 29);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Suma incasata pe bicicleta selectata:";
            // 
            // btnTraseazaGrafic
            // 
            this.btnTraseazaGrafic.Location = new System.Drawing.Point(768, 418);
            this.btnTraseazaGrafic.Name = "btnTraseazaGrafic";
            this.btnTraseazaGrafic.Size = new System.Drawing.Size(258, 62);
            this.btnTraseazaGrafic.TabIndex = 5;
            this.btnTraseazaGrafic.Text = "Traseaza grafic ";
            this.btnTraseazaGrafic.UseVisualStyleBackColor = true;
            this.btnTraseazaGrafic.Click += new System.EventHandler(this.btnTraseazaGrafic_Click);
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
            this.ClientSize = new System.Drawing.Size(1231, 754);
            this.Controls.Add(this.btnTraseazaGrafic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbUtilizatori);
            this.Controls.Add(this.lvBiciclete);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatorBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incarcaBicicleteDinTxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incarcaUtilizatoriDinTxtToolStripMenuItem;
        private System.Windows.Forms.ListView lvBiciclete;
        private System.Windows.Forms.ListBox lbUtilizatori;
        private System.Windows.Forms.ColumnHeader codB;
        private System.Windows.Forms.ColumnHeader statieParcare;
        private System.Windows.Forms.ColumnHeader kilometri;
        private System.Windows.Forms.BindingSource utilizatorBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem afisareIncasariPeBicicletaToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTraseazaGrafic;
        private System.Windows.Forms.ToolStripMenuItem previewToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog ppd;
        private System.Drawing.Printing.PrintDocument pdoc;
        private System.Windows.Forms.ToolStripMenuItem serializareDateToolStripMenuItem;
    }
}

