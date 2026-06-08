using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sub4_2026
{
    internal class Grafic : Control
    {
        private List<double> valori;

        public Grafic() : base() 
        {
        }

        public void SetValori(List<double> v)
        {
            valori = v;
            Invalidate();   // se reapeleaza onpaint
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            if (valori == null || valori.Count < 1)
            {
                return;
            }

            double max = valori.Max();

            int n = valori.Count;
            int latimeBara = Width / n;

            for(int i =0; i<n; i++)
            {
                int inaltime = (int)(valori[i] / max * (Height - 20));
                int x = i * latimeBara;
                int y = Height - inaltime;

                g.FillRectangle(Brushes.Blue, x + 2, y, latimeBara - 4, inaltime);
                g.DrawString(valori[i].ToString(), Font, Brushes.Black, x + 2, y - 15);
            }
        }

    }
}
