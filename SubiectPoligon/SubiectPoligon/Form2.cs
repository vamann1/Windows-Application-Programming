using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SubiectPoligon
{
    public partial class Form2 : Form
    {
        private List<Poligon> listaPoligoane;
        private Poligon poligonDeDesen;

        public Form2() : this(new List<Poligon>()) { }

        public Form2(List<Poligon> listaPoligoane)
        {
            InitializeComponent();
            this.listaPoligoane = listaPoligoane;
            this.ResizeRedraw = true;
            this.Paint += Form2_Paint;
        }

        private void btnDeseneaza_Click_1(object sender, EventArgs e)
        {
            string eticheta = tbEticheta.Text.Trim();
            poligonDeDesen = listaPoligoane.Find(p => p.Eticheta == eticheta);

            if (poligonDeDesen == null)
            {
                MessageBox.Show("Nu există niciun poligon cu eticheta introdusă.", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Invalidate();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            if (poligonDeDesen == null || poligonDeDesen.Puncte.Count < 2)
                return;

            Color culoare;
            try {
                culoare = Color.FromName(poligonDeDesen.Culoare); 
            }
            catch { 
                culoare = Color.Black;
            }

            Graphics g = e.Graphics;

            Rectangle zona = new Rectangle(0, this.ClientSize.Height / 2,
            this.ClientSize.Width / 2, this.ClientSize.Height / 2);

            g.DrawRectangle(Pens.Gray, zona);
            g.TranslateTransform(zona.X, zona.Y); 

            Pen pen = new Pen(culoare, poligonDeDesen.Grosime_linie);
            Point[] puncte = poligonDeDesen.Puncte.ToArray();
            g.DrawPolygon(pen, puncte);
            pen.Dispose();
        }

        private void Form2_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
