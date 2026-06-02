using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace in_clipb_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == (Keys.Control | Keys.C))
            {
                Rectangle rf = new Rectangle { X = 0, Y = 0, Width = this.Width, Height = this.Height };
                Bitmap fimg = new Bitmap(Width, Height);
                DrawToBitmap(fimg, rf);
                Clipboard.SetImage(fimg);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
