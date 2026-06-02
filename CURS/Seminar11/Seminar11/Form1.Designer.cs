namespace Seminar11
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incarcaDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afisareGraficToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficDesenatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphicBarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphicPieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareBmpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificareCuloareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificareFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.modificareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1095, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incarcaDateToolStripMenuItem,
            this.afisareGraficToolStripMenuItem,
            this.salvareBmpToolStripMenuItem,
            this.printPreviewToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(62, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // incarcaDateToolStripMenuItem
            // 
            this.incarcaDateToolStripMenuItem.Name = "incarcaDateToolStripMenuItem";
            this.incarcaDateToolStripMenuItem.Size = new System.Drawing.Size(253, 40);
            this.incarcaDateToolStripMenuItem.Text = "Incarca date";
            this.incarcaDateToolStripMenuItem.Click += new System.EventHandler(this.incarcaDateToolStripMenuItem_Click);
            // 
            // afisareGraficToolStripMenuItem
            // 
            this.afisareGraficToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graficDesenatToolStripMenuItem,
            this.graphicBarsToolStripMenuItem,
            this.graphicPieToolStripMenuItem});
            this.afisareGraficToolStripMenuItem.Name = "afisareGraficToolStripMenuItem";
            this.afisareGraficToolStripMenuItem.Size = new System.Drawing.Size(253, 40);
            this.afisareGraficToolStripMenuItem.Text = "Afisare grafic";
            // 
            // graficDesenatToolStripMenuItem
            // 
            this.graficDesenatToolStripMenuItem.Name = "graficDesenatToolStripMenuItem";
            this.graficDesenatToolStripMenuItem.Size = new System.Drawing.Size(264, 40);
            this.graficDesenatToolStripMenuItem.Text = "Grafic desenat";
            this.graficDesenatToolStripMenuItem.Click += new System.EventHandler(this.graficDesenatToolStripMenuItem_Click);
            // 
            // graphicBarsToolStripMenuItem
            // 
            this.graphicBarsToolStripMenuItem.Name = "graphicBarsToolStripMenuItem";
            this.graphicBarsToolStripMenuItem.Size = new System.Drawing.Size(264, 40);
            this.graphicBarsToolStripMenuItem.Text = "Graphic bars";
            this.graphicBarsToolStripMenuItem.Click += new System.EventHandler(this.graphicBarsToolStripMenuItem_Click);
            // 
            // graphicPieToolStripMenuItem
            // 
            this.graphicPieToolStripMenuItem.Name = "graphicPieToolStripMenuItem";
            this.graphicPieToolStripMenuItem.Size = new System.Drawing.Size(264, 40);
            this.graphicPieToolStripMenuItem.Text = "Graphic pie";
            this.graphicPieToolStripMenuItem.Click += new System.EventHandler(this.graphicPieToolStripMenuItem_Click);
            // 
            // salvareBmpToolStripMenuItem
            // 
            this.salvareBmpToolStripMenuItem.Name = "salvareBmpToolStripMenuItem";
            this.salvareBmpToolStripMenuItem.Size = new System.Drawing.Size(253, 40);
            this.salvareBmpToolStripMenuItem.Text = "Salvare bmp";
            this.salvareBmpToolStripMenuItem.Click += new System.EventHandler(this.zToolStripMenuItem_Click);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(253, 40);
            this.printPreviewToolStripMenuItem.Text = "Print preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // modificareToolStripMenuItem
            // 
            this.modificareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificareCuloareToolStripMenuItem,
            this.modificareFontToolStripMenuItem});
            this.modificareToolStripMenuItem.Name = "modificareToolStripMenuItem";
            this.modificareToolStripMenuItem.Size = new System.Drawing.Size(130, 34);
            this.modificareToolStripMenuItem.Text = "Modificare";
            // 
            // modificareCuloareToolStripMenuItem
            // 
            this.modificareCuloareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barsToolStripMenuItem,
            this.textToolStripMenuItem});
            this.modificareCuloareToolStripMenuItem.Name = "modificareCuloareToolStripMenuItem";
            this.modificareCuloareToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.modificareCuloareToolStripMenuItem.Text = "Modificare culoare";
            this.modificareCuloareToolStripMenuItem.Click += new System.EventHandler(this.modificareCuloareToolStripMenuItem_Click);
            // 
            // barsToolStripMenuItem
            // 
            this.barsToolStripMenuItem.Name = "barsToolStripMenuItem";
            this.barsToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.barsToolStripMenuItem.Text = "Bars";
            this.barsToolStripMenuItem.Click += new System.EventHandler(this.barsToolStripMenuItem_Click);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.textToolStripMenuItem.Text = "Text";
            this.textToolStripMenuItem.Click += new System.EventHandler(this.textToolStripMenuItem_Click);
            // 
            // modificareFontToolStripMenuItem
            // 
            this.modificareFontToolStripMenuItem.Name = "modificareFontToolStripMenuItem";
            this.modificareFontToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.modificareFontToolStripMenuItem.Text = "Modificare font";
            this.modificareFontToolStripMenuItem.Click += new System.EventHandler(this.modificareFontToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(15, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 626);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(43, 29);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Vanzari";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(960, 570);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 726);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incarcaDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afisareGraficToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareBmpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificareToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficDesenatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphicBarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphicPieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificareCuloareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificareFontToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

