using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubiectBiciclete
{
    public partial class FormGrafic : Form
    {
        List<Bicicleta> listBiciclete = new List<Bicicleta>();
        public FormGrafic(List<Bicicleta> listBiciclete)
        {
            InitializeComponent();
            this.listBiciclete = listBiciclete;
            panel.Invalidate();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            this.ResizeRedraw = true;

            int[] kilometriBiciclete = new int[listBiciclete.Count];
                for (int i = 0; i < listBiciclete.Count; i++)
                {
                kilometriBiciclete[i] = listBiciclete[i].KmParcursi;
                }

            RectangleF[] vrect = new RectangleF[kilometriBiciclete.Length];
            int maxv = kilometriBiciclete.Max();
            float db, lb;
            db = panel.Width / (4F * kilometriBiciclete.Length + 1F);
            lb = 3F * db;
            for (int i = 0, stg = 0; i < kilometriBiciclete.Length; i++, stg += (int)(lb + db))
            {
                vrect[i].X = stg;
                vrect[i].Width = lb;
                vrect[i].Height = (float)kilometriBiciclete[i] / maxv * (float)panel.Height;
                vrect[i].Y = panel.Height - vrect[i].Height;
            }
            g.FillRectangles(Brushes.Red, vrect);
        }
    }


}
