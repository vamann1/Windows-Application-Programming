using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar_gr
{
    public partial class Form1 : Form
    {
        List<int> lv=null;
        public Form1()
        {
            InitializeComponent();
            lv = new List<int>();
        }

        private void gv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (gv.Rows.Count > 3)
            {
                lv = new List<int>();
                foreach (DataGridViewRow rd in gv.Rows)
                {
                    if (rd.Cells[0].Value != null)
                        lv.Add(int.Parse(rd.Cells[0].Value.ToString()));
                }
            }
            else lv = null;
            gr.Valori = lv;
            

        }
    }
}
