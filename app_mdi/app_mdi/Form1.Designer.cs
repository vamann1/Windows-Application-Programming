namespace app_mdi
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operatiiDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citesteDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scrieDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operatiiFerestreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fereastraNouaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aranjareFerestreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inchideFerestreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operatiiDateToolStripMenuItem,
            this.operatiiFerestreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1271, 38);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operatiiDateToolStripMenuItem
            // 
            this.operatiiDateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.citesteDateToolStripMenuItem,
            this.scrieDateToolStripMenuItem});
            this.operatiiDateToolStripMenuItem.Name = "operatiiDateToolStripMenuItem";
            this.operatiiDateToolStripMenuItem.Size = new System.Drawing.Size(152, 34);
            this.operatiiDateToolStripMenuItem.Text = "Operatii date";
            // 
            // citesteDateToolStripMenuItem
            // 
            this.citesteDateToolStripMenuItem.Name = "citesteDateToolStripMenuItem";
            this.citesteDateToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.citesteDateToolStripMenuItem.Text = "Citeste date";
            // 
            // scrieDateToolStripMenuItem
            // 
            this.scrieDateToolStripMenuItem.Name = "scrieDateToolStripMenuItem";
            this.scrieDateToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.scrieDateToolStripMenuItem.Text = "Scrie date";
            this.scrieDateToolStripMenuItem.Click += new System.EventHandler(this.scrieDateToolStripMenuItem_Click);
            // 
            // operatiiFerestreToolStripMenuItem
            // 
            this.operatiiFerestreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fereastraNouaToolStripMenuItem,
            this.aranjareFerestreToolStripMenuItem,
            this.inchideFerestreToolStripMenuItem});
            this.operatiiFerestreToolStripMenuItem.Name = "operatiiFerestreToolStripMenuItem";
            this.operatiiFerestreToolStripMenuItem.Size = new System.Drawing.Size(181, 34);
            this.operatiiFerestreToolStripMenuItem.Text = "Operatii ferestre";
            // 
            // fereastraNouaToolStripMenuItem
            // 
            this.fereastraNouaToolStripMenuItem.Name = "fereastraNouaToolStripMenuItem";
            this.fereastraNouaToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.fereastraNouaToolStripMenuItem.Text = "Fereastra Noua";
            this.fereastraNouaToolStripMenuItem.Click += new System.EventHandler(this.fereastraNouaToolStripMenuItem_Click);
            // 
            // aranjareFerestreToolStripMenuItem
            // 
            this.aranjareFerestreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orizontalToolStripMenuItem,
            this.verticalToolStripMenuItem,
            this.cascadaToolStripMenuItem});
            this.aranjareFerestreToolStripMenuItem.Name = "aranjareFerestreToolStripMenuItem";
            this.aranjareFerestreToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.aranjareFerestreToolStripMenuItem.Text = "Aranjare ferestre";
            // 
            // orizontalToolStripMenuItem
            // 
            this.orizontalToolStripMenuItem.Name = "orizontalToolStripMenuItem";
            this.orizontalToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.orizontalToolStripMenuItem.Text = "Orizontal";
            this.orizontalToolStripMenuItem.Click += new System.EventHandler(this.orizontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // cascadaToolStripMenuItem
            // 
            this.cascadaToolStripMenuItem.Name = "cascadaToolStripMenuItem";
            this.cascadaToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.cascadaToolStripMenuItem.Text = "Cascada";
            this.cascadaToolStripMenuItem.Click += new System.EventHandler(this.cascadaToolStripMenuItem_Click);
            // 
            // inchideFerestreToolStripMenuItem
            // 
            this.inchideFerestreToolStripMenuItem.Name = "inchideFerestreToolStripMenuItem";
            this.inchideFerestreToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.inchideFerestreToolStripMenuItem.Text = "Inchide ferestre";
            this.inchideFerestreToolStripMenuItem.Click += new System.EventHandler(this.inchideFerestreToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 816);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operatiiDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citesteDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scrieDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operatiiFerestreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fereastraNouaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aranjareFerestreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inchideFerestreToolStripMenuItem;
    }
}

