using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_use_ctrl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pb.BackColor = Color.FromArgb(cr.CCuloare, cg.CCuloare, cb.CCuloare);
        }

        private void cr_Ev_Schimbare_culoare()
        {
            pb.BackColor = Color.FromArgb(cr.CCuloare, cg.CCuloare, cb.CCuloare);
        }
    }
}
