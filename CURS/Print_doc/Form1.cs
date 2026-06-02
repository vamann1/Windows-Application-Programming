using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;


namespace Print_doc
{
    public partial class Form1 : Form
    {
        Font ft, fr;
        public Form1()
        {
            InitializeComponent();
            ft = new Font("Times New Roman", 20, FontStyle.Bold);
            fr = new Font("Arial", 14);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ppd.ShowDialog();
        }

        private void pdoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.Blue, e.MarginBounds);
            string st = "Titlul Paginii";
            Size szt = TextRenderer.MeasureText(st, ft);
           
            g.DrawString(st, ft, Brushes.Red, e.MarginBounds.X + e.MarginBounds.Width/2-szt.Width/2, e.MarginBounds.Y);
            g.DrawString("Prima linie", fr, Brushes.Black, e.MarginBounds.X, e.MarginBounds.Y+2*ft.Height);
            g.DrawString("A doua linie de text", fr, Brushes.Black, e.MarginBounds.X, e.MarginBounds.Y + 2 * 1.5F*ft.Height+fr.Height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pdoc.DefaultPageSettings.Margins = new Margins(100, 50, 100, 50);
        }
    }
}
