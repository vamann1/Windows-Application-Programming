using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sub3_2026
{
    internal class Grafic : Control
    {
        List<double> valori;
        public Grafic() : base()
        {
        }

        public void SetValori(List<double> v)
        {
            valori = v;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            if (valori != null && valori.Count >= 2)
            {

                Rectangle zonaPie = new Rectangle(10, 10, Width, Height);

                float unghiStart = 0f;
                for (int i = 0; i < valori.Count; i++)
                {
                    float portiune = (float)(valori[i] * 360);
                    g.FillPie(Brushes.AliceBlue, zonaPie, unghiStart, portiune);
                    g.DrawPie(Pens.Black, zonaPie, unghiStart, portiune);
                    unghiStart += portiune;
                }

                 /*
                double max = valori.Max();
                int n = valori.Count();
                int latimeBara = Width / n;

                for (int i = 0; i < n; i++)
                {
                    int inaltime = (int)(valori[i] / max * (Height - 20));
                    int x = i * latimeBara;
                    int y = Height - inaltime;
                    g.FillRectangle(Brushes.Red, x + 5, y, latimeBara, inaltime);
                }
                 */
            }
        }
        
    }
}
