using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace out_clipb_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.V))
            {
                Bitmap fimg = Clipboard.GetImage() as Bitmap;
                if (fimg != null) pb.Image = fimg;
                else MessageBox.Show("Nu a fost incarcata o imagine!!!");
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
