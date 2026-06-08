using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sub3_2026
{
    public partial class Form1 : Form
    {
        ColectivitateStatistica colectivitate = new ColectivitateStatistica();
        public Form1()
        {
            InitializeComponent();
            colectivitate.colectivitateSchimbata += ColectivitateSchimbataHandler;
            colectivitate.colectivitateSchimbata += (s, e) => grafic1.SetValori(colectivitate.Ponderi);

        }

        public void ColectivitateSchimbataHandler(object sender, EventArgs e)
        {
            lv.Items.Clear();
            for (int i = 0; i < colectivitate.Observatii.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(colectivitate.Observatii[i].ToString());
                lvi.SubItems.Add(colectivitate.Ponderi[i].ToString());
                lv.Items.Add(lvi);
            }
        }

        private void btnAdaugaObs_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(tbObs.Text))
                {
                    return;
                }
                double obs = Convert.ToDouble(tbObs.Text, CultureInfo.InvariantCulture.NumberFormat);
                colectivitate.Observatii.Add(obs);
                colectivitate.NotificaColectivitateSchimbata();

                tbObs.Clear();
                tbObs.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbObs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' || e.KeyChar == '\n')
            {
                btnAdaugaObs_Click(sender, e);
            }
            else
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                err1.SetError(tbObs, "Input invalid!");
                e.Handled = true;
            }
            else
            {
                err1.Clear();
                e.Handled = false;
            }
        }

        private void lv_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked == true)
            {
                e.Item.BackColor = Color.Red;
            }
            else
            {
                e.Item.BackColor = Color.White;
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            try
            {
                if (lv.CheckedItems.Count > 1)
                {
                    err1.SetError(btnModifica, "Nu se pot modifica multiple valori!");
                    return;
                } else if(lv.CheckedItems.Count == 0){
                    return;
                }

                List<int> index = lv.CheckedIndices.Cast<int>().ToList();

                double val = Convert.ToDouble(tbModificare.Text, CultureInfo.InvariantCulture.NumberFormat);
                colectivitate.Observatii[index[0]] = val;

                colectivitate.NotificaColectivitateSchimbata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbModificare_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' || e.KeyChar == '\n')
            {
                btnModifica_Click(sender, e);
            }
            else
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
                {
                    err1.SetError(tbModificare, "Input invalid!");
                    e.Handled = true;
                }
                else
                {
                    err1.Clear();
                    e.Handled = false;
                }
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            try
            {
                if (lv.CheckedItems.Count > 1)
                {
                    err1.SetError(btnStergere, "Nu se pot sterge multiple valori!");
                    return;
                } else if (lv.CheckedItems.Count == 0)
                {
                    return;
                }

                List<int> index = lv.CheckedIndices.Cast<int>().ToList();

                colectivitate.Observatii.RemoveAt(index[0]);

                colectivitate.NotificaColectivitateSchimbata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGrafic_Click(object sender, EventArgs e)
        {
            //grafic1.SetValori(colectivitate.Observatii);
            grafic1.SetValori(colectivitate.Ponderi);

        }
    }
}
