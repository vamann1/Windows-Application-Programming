using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sub4_2026
{
    public partial class Form1 : Form
    {
        public ColectivitateStatistica colectivitate = new ColectivitateStatistica();
        public Form1()
        {
            InitializeComponent();

            dgv.AutoGenerateColumns = false;
            Observatii.DataPropertyName = "Observatii";
            Frecvente.DataPropertyName = "Frecvente";

            colectivitate.ColectivitateModificata += ColectivitateModificataHandler;
        }

        private void ColectivitateModificataHandler(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Observatii", typeof(double));
            dt.Columns.Add("Frecvente", typeof(int));

            for (int i = 0; i < colectivitate.Observatii.Count; i++)
            {
                dt.Rows.Add(
                    colectivitate.Observatii[i],
                    colectivitate.Frecvente[i]
                );
            }

            dgv.DataSource = dt;
            tbMedie.Text = colectivitate.Medie.ToString();
        }

        private void btnColectivitateNoua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbObs.Text))
                {
                    err1.SetError(tbObs, "Formularul este gol!");
                    return;
                }
                double obs = Convert.ToDouble(tbObs.Text);
                bool nou = true;
                for (int i = 0; i < colectivitate.Observatii.Count(); i++)
                {
                    if (obs == colectivitate.Observatii[i])
                    {
                        colectivitate.Frecvente[i]++;
                        nou = false;
                    }
                }
                if (nou)
                {
                    colectivitate.Observatii.Add(obs);
                    colectivitate.Frecvente.Add(1);
                }

                colectivitate.OnColectivitateModificata();
                tbObs.Clear();
                tbObs.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            int index = dgv.CurrentCell.RowIndex;
            bool nou = true;
            double val = Convert.ToDouble(dgv.CurrentCell.Value);
            for(int i = 0; i< colectivitate.Observatii.Count(); i++)
            {
                if(val == colectivitate.Observatii[i])
                {
                    colectivitate.Frecvente[i] += colectivitate.Frecvente[index];
                    colectivitate.Frecvente.RemoveAt(index);
                    colectivitate.Observatii.RemoveAt(index);
                    nou = false;
                }
            }
            if(nou == true)
            {
                int frecv = colectivitate.Frecvente[index];
                colectivitate.Frecvente.RemoveAt(index);
                colectivitate.Observatii.RemoveAt(index);
                colectivitate.Observatii.Add(val);
                colectivitate.Frecvente.Add(frecv);
            }

            colectivitate.OnColectivitateModificata();
        }

        private void tbObs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\n' || e.KeyChar == '\r')
            {
               btnColectivitateNoua_Click(null, null);
            }
        }

        private void btnStergeDefinitiv_Click(object sender, EventArgs e)
        {
            int index = dgv.CurrentCell.RowIndex;
            colectivitate.Observatii.RemoveAt(index);
            colectivitate.Frecvente.RemoveAt(index);

            colectivitate.OnColectivitateModificata();
        }

        private void dgv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(dgv.CurrentRow == null)
            {
                return;
            }

            if (e.KeyChar == '\b')
            {
                int index = dgv.CurrentCell.RowIndex;
                if (colectivitate.Frecvente[index] - 1 > 0)
                    colectivitate.Frecvente[index]--;
                else btnStergeDefinitiv_Click(null, null);

                colectivitate.OnColectivitateModificata();
            }

        }

        private void btnAfiseazaGrafice_Click(object sender, EventArgs e)
        {
            if(colectivitate.Observatii.Count < 2)
            {
                MessageBox.Show("Nu exista destule observatii!");
                return;
            }

            grafic1.Visible = true;
            grafic2.Visible = true;

            grafic1.SetValori(colectivitate.Observatii);

            List<double> frecvDouble = new List<double>();
            foreach (int f in colectivitate.Frecvente)
                frecvDouble.Add(f);
            grafic2.SetValori(frecvDouble);

        }
    }
}
