using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sub2_2026
{
    public partial class Form1 : Form
    {
        ColectivitateStatistica date = new ColectivitateStatistica();
        public Form1()
        {
            InitializeComponent();
            date.dateModif += AfisareLV;
        }

        private void AfisareLV()
        {
            lv.Items.Clear();
            for (int i = 0; i < date.Observatii.Count; i++)
            {
                ListViewItem itm = new ListViewItem(date.Observatii[i].ToString());
                itm.SubItems.Add(date.Ponderi[i].ToString());
                itm.Tag = i;
                lv.Items.Add(itm);
            }
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbObs.Text, out double val))
            {
                date.Adauga(val);
                tbObs.Clear();
                tbObs.Focus();
            }
            else
            {
                MessageBox.Show("Input invalid!");
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (lv.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecteaza o valoare!");
                return;
            }

            int index = (int)lv.SelectedItems[0].Tag;
            if (double.TryParse(tbObs.Text, out double val))
            {
                date.Modifica(index, val);
            }
            else
            {
                MessageBox.Show("Input invalid!");
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            try
            {
                if (lv.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Selecteaza o valoare!");
                    return;
                }

                int index = (int)lv.SelectedItems[0].Tag;
                date.Sterge(index);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnSterge_Click(sender, e);
            }
        }

        private void tbObs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdauga_Click(sender, e);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pp);
            PrintPreviewDialog pdlg = new PrintPreviewDialog { Document = pd };
            pdlg.ShowDialog();
        }
        private void pp(object sender, PrintPageEventArgs e)
        {
            Font fontTitlu = new Font("Arial", 16, FontStyle.Bold);
            Font fontText = new Font("Arial", 14);
            float y = 20;

            e.Graphics.DrawString("STATISTICI", fontText, Brushes.Black, 350, y);

            y += 40;
            for (int i = 0; i < date.Observatii.Count; i++)
            {
                if (i == 0)
                    e.Graphics.DrawString($"{i + 1}. x0={date.Observatii[i]}", fontText, Brushes.Black, 20, y);
                else
                    e.Graphics.DrawString($"{i + 1}. x{i}={date.Observatii[i]} i{i} = {date.Ponderi[i]}", fontText, Brushes.Black, 20, y);
                y += 25;
            }
        }
    }
}
