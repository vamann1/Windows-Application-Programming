namespace SubiectPizza
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comandaPizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tvComenzi = new System.Windows.Forms.TreeView();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.citireComandaDinXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bazaDeDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citireToppingDinBdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierToolStripMenuItem,
            this.comandaPizzaToolStripMenuItem,
            this.bazaDeDateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1280, 38);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fisierToolStripMenuItem
            // 
            this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.citireComandaDinXMLToolStripMenuItem});
            this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(78, 34);
            this.fisierToolStripMenuItem.Text = "Fisier";
            // 
            // comandaPizzaToolStripMenuItem
            // 
            this.comandaPizzaToolStripMenuItem.Name = "comandaPizzaToolStripMenuItem";
            this.comandaPizzaToolStripMenuItem.Size = new System.Drawing.Size(174, 34);
            this.comandaPizzaToolStripMenuItem.Text = "Comanda pizza";
            this.comandaPizzaToolStripMenuItem.Click += new System.EventHandler(this.comandaPizzaToolStripMenuItem_Click);
            // 
            // tvComenzi
            // 
            this.tvComenzi.Location = new System.Drawing.Point(38, 59);
            this.tvComenzi.Name = "tvComenzi";
            this.tvComenzi.Size = new System.Drawing.Size(291, 422);
            this.tvComenzi.TabIndex = 3;
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Location = new System.Drawing.Point(39, 502);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(194, 33);
            this.btnAfiseaza.TabIndex = 4;
            this.btnAfiseaza.Text = "btnAfiseazaTv";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            this.btnAfiseaza.Click += new System.EventHandler(this.tvComenzi_Click);
            // 
            // citireComandaDinXMLToolStripMenuItem
            // 
            this.citireComandaDinXMLToolStripMenuItem.Name = "citireComandaDinXMLToolStripMenuItem";
            this.citireComandaDinXMLToolStripMenuItem.Size = new System.Drawing.Size(353, 40);
            this.citireComandaDinXMLToolStripMenuItem.Text = "Citire comanda din XML";
            this.citireComandaDinXMLToolStripMenuItem.Click += new System.EventHandler(this.citireComandaDinXMLToolStripMenuItem_Click);
            // 
            // bazaDeDateToolStripMenuItem
            // 
            this.bazaDeDateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.citireToppingDinBdToolStripMenuItem});
            this.bazaDeDateToolStripMenuItem.Name = "bazaDeDateToolStripMenuItem";
            this.bazaDeDateToolStripMenuItem.Size = new System.Drawing.Size(151, 34);
            this.bazaDeDateToolStripMenuItem.Text = "Baza de date";
            // 
            // citireToppingDinBdToolStripMenuItem
            // 
            this.citireToppingDinBdToolStripMenuItem.Name = "citireToppingDinBdToolStripMenuItem";
            this.citireToppingDinBdToolStripMenuItem.Size = new System.Drawing.Size(322, 40);
            this.citireToppingDinBdToolStripMenuItem.Text = "Citire topping din bd";
            this.citireToppingDinBdToolStripMenuItem.Click += new System.EventHandler(this.citireToppingDinBdToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 857);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.tvComenzi);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MdiChildActivate += new System.EventHandler(this.Form1_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comandaPizzaToolStripMenuItem;
        private System.Windows.Forms.TreeView tvComenzi;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.ToolStripMenuItem citireComandaDinXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bazaDeDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citireToppingDinBdToolStripMenuItem;
    }
}

