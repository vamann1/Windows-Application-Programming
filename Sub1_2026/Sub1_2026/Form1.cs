using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sub1_2026
{
    public partial class Form1 : Form
    {
        ColectivitateStatistica colectivitate;
        public Form1()
        {
            InitializeComponent();

            dgv.AutoGenerateColumns = false;
            Observatii.DataPropertyName = "Observatii";
            Indici.DataPropertyName = "Indici";

            colectivitate.DateModificate += refreshDataGridView;

        }

        public void refreshDataGridView(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Observatii");
            dt.Columns.Add("Indici");

            for (int i = 0; i < colectivitate.Observatii.Count; i++)
            {
                dt.Rows.Add(colectivitate.Observatii[i].ToString(), colectivitate.Indici[i].ToString());
            }
            
            dgv.DataSource = dt;
            
        }

        private void btnColectivitateNoua_Click(object sender, EventArgs e)
        {
            try
            {
                string nume = tbNume.Text.Trim();
                List<double> aux = new List<double>();
                int cnt = tbObs.Text.Split(',').Count();
                for(int i =0; i<cnt; i++)
                {
                    double obs = Convert.ToDouble(tbObs.Text.Split(',')[i]);
                    aux.Add(obs);
                }
                colectivitate = new ColectivitateStatistica(nume, aux);

                tbAfisareNume.Text = nume;

                colectivitate.NotificaSchimbare();

                tbNume.Clear();
                tbObs.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbNume_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbNume.Text))
            {
                err1.SetError(tbNume, "Daca adaugi o colectivitate noua, numele nu poate fi gol!");
                btnColectivitateNoua.Enabled = false;
            }
            else
            {
                btnColectivitateNoua.Enabled = true;
            }
        }

        private void tbObs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar))
            {
                err1.SetError(tbObs, "Input incorect!");
                btnColectivitateNoua.Enabled = false;
                btnModificaObs.Enabled = false;
            }
            else
            {
                btnColectivitateNoua.Enabled = true;
                btnModificaObs.Enabled = true;
            }
        }

        private void tbObs_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbObs.Text))
            {
                err1.SetError(tbObs, "Observatiile nu pot fi goale!");
                btnColectivitateNoua.Enabled = false;
                btnModificaObs.Enabled = false;
            }
            else
            {
                btnColectivitateNoua.Enabled = true;
                btnModificaObs.Enabled = true;
            }
        }

        private void btnObsNoi_Click(object sender, EventArgs e)
        {
            try
            {
                int cnt = tbObs.Text.Split(',').Count();
                for (int i = 0; i < cnt; i++)
                {
                    double obs = Convert.ToDouble(tbObs.Text.Split(',')[i]);
                    colectivitate.Observatii.Add(obs);
                }

                colectivitate.NotificaSchimbare();

                tbNume.Clear();
                tbObs.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificaObs_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgv.CurrentCell.RowIndex;
                double obsNoua = Convert.ToDouble(dgv.CurrentCell.Value);
                colectivitate.Observatii.RemoveAt(index);
                colectivitate.Observatii.Insert(index, obsNoua);
                colectivitate.NotificaSchimbare();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStergeObs_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgv.CurrentRow.Index;
                colectivitate.Observatii.RemoveAt(index);
                colectivitate.NotificaSchimbare();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dgv.CurrentCell == null)
                return;
            if (e.KeyChar == '\n' || e.KeyChar == '\r')
            {
                int index = dgv.CurrentCell.RowIndex;
                double obsNoua = Convert.ToDouble(dgv.CurrentCell.Value);
                colectivitate.Observatii.RemoveAt(index);
                colectivitate.Observatii.Insert(index, obsNoua);
                colectivitate.NotificaSchimbare();
            }
            else if (e.KeyChar == '\b')
            {
                int index = dgv.CurrentRow.Index;
                colectivitate.Observatii.RemoveAt(index);
                colectivitate.NotificaSchimbare();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ppd.ShowDialog();
        }

        private void pdoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fL = new Font("Times New Roman", 20);
            Font f = new Font("Times New Roman", 12);
            int x = e.MarginBounds.X;
            int y = e.MarginBounds.Y;

            g.DrawRectangle(Pens.Black, e.MarginBounds);

            g.DrawString(colectivitate.Nume, fL, Brushes.Black, x + 20, y + 100);
            int j = 1;
            for(int i =0; i<colectivitate.Observatii.Count; i++) 
            {
                g.DrawString(j + ".  " + colectivitate.Observatii[i] + "   " + colectivitate.Indici[i], f, Brushes.Black, x, y+50);
                y = y + 20;
                j++;
            }

        }
    }
}
