using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar_gr
{
    public class Grafic : Control
    {
        List<int> lvg;
        public Grafic()
        {
            this.ResizeRedraw = true;
            lvg = null;
        }

        public List<int> Valori
        {
            get => lvg;
            set
            {
                lvg = value;
                Invalidate();
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Rectangle canvas = new Rectangle
            {
                X = this.ClientRectangle.X + 10,
                Y = this.ClientRectangle.Y + 10,
                Width = this.ClientRectangle.Width - 20,
                Height = this.ClientRectangle.Height - 20
            };
            g.DrawRectangle(Pens.Blue, canvas);
            if(lvg!=null && lvg.Count>=2)
            {
                RectangleF[] vrect = new RectangleF[lvg.Count];
                int i, maxv=lvg.Max();
                float db, lb, stg;
                db = canvas.Width / (4F * lvg.Count + 1F);
                lb = 3F * db;
                for(i=0, stg = canvas.X+db; i< lvg.Count; i++, stg+=lb+db)
                {
                    vrect[i].X = stg;
                    vrect[i].Width = lb;
                    vrect[i].Height = (float)lvg[i]/maxv * (float)canvas.Height;
                    vrect[i].Y = canvas.Y + (canvas.Height - vrect[i].Height);
                } 
                g.FillRectangles(Brushes.Red, vrect);
            }
        }
    }
}
