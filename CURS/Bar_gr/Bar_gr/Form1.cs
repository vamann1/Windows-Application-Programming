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
                //lv = new List<int>();
                //foreach (DataGridViewRow rd in gv.Rows)
                //{
                //    if (rd.Cells[0].Value != null)
                //        lv.Add(int.Parse(rd.Cells[0].Value.ToString()));
                //}
                
                lv = gv.Rows.Cast<DataGridViewRow>().Where(rd => rd.Cells[0].Value!=null).Select(rd => int.Parse(rd.Cells[0].Value.ToString())).ToList<int>();
                //ca ex, de bagat un splitter container pe orizontalin panoul din stanga, iar in partea de jos un radio button pt a selecta tipul de grafic si a modifica graficul din panooul din dreapta

            }
            else lv = null;
            gr.Valori = lv;
        }

        private void gv_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            gv_CellValueChanged(sender, null);
        }
    }
}
