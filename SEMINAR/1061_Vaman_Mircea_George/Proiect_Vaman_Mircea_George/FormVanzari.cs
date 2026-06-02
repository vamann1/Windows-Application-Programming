using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Windows.Forms;

namespace Proiect_Vaman_Mircea_George
{
    public enum TipGrafic { None, Bars, Pie }

    public partial class FormVanzari : Form
    {
        private Collection<Vanzare> colectieVanzari;
        private List<Produs> listaProduse;
        private List<Vanzare> listaVanzariBinding = new List<Vanzare>();
        private string moneda;
        private double cotaTVA;
        private double reducereClientFidel;
        private Action<string> logAction;
        private TipGrafic graficInitial;

        public FormVanzari(
            Collection<Vanzare> colectieVanzari,
            List<Produs> listaProduse,
            string moneda,
            double cotaTVA,
            double reducereClientFidel,
            Action<string> logAction,
            TipGrafic graficInitial = TipGrafic.None)
        {
            InitializeComponent();
            this.colectieVanzari = colectieVanzari;
            this.listaProduse = listaProduse;
            this.moneda = moneda;
            this.cotaTVA = cotaTVA;
            this.reducereClientFidel = reducereClientFidel;
            this.logAction = logAction;
            this.graficInitial = graficInitial;
        }

        private void FormVanzari_Load(object sender, EventArgs e)
        {
            ucSelectorProds.IncarcaProduse(listaProduse);
            RafresheazaDGV();

            if (graficInitial == TipGrafic.Bars) btnGraficBars_Click(null, EventArgs.Empty);
            else if (graficInitial == TipGrafic.Pie) btnGraficPie_Click(null, EventArgs.Empty);
        }

        private void RafresheazaDGV()
        {
            listaVanzariBinding.Clear();
            foreach (Vanzare v in colectieVanzari)
                listaVanzariBinding.Add(v);
            dgvVanzari.DataSource = null;
            dgvVanzari.DataSource = listaVanzariBinding;

            foreach (DataGridViewColumn col in dgvVanzari.Columns)
                col.Visible = (col.Name == "Id" || col.Name == "NumeProdus" || col.Name == "Cantitate");

            tbVanzareCurenta.Text = listaVanzariBinding.Count > 0
                ? listaVanzariBinding[0].ToString() : "";
        }

        private void btnInregistreazaVanzare_Click(object sender, EventArgs e)
        {
            try
            {
                Produs produsSelectat = ucSelectorProds.SelectedProdus;
                if (produsSelectat == null)
                    throw new MagazinValidareException("Selecteaza un produs!");
                if (tbCantitate.Text == "")
                    throw new MagazinValidareException("Introdu cantitatea!");

                int cantitate = Convert.ToInt32(tbCantitate.Text);
                DateTime data = dtpVanzare.Value;
                int id = colectieVanzari.Count + 1;

                Vanzare v = new Vanzare(id, produsSelectat.Nume, cantitate, produsSelectat.Pret, data);
                colectieVanzari.Add(v);
                RafresheazaDGV();

                double total = v.ValoareFinala();
                if (rbDa.Checked)
                    total = total - (total * reducereClientFidel / 100);

                tbPlata.Text = total.ToString("F2") + " " + moneda;
                logAction?.Invoke($"Vanzare inregistrata: {v} → {total:F2} {moneda}");
                MessageBox.Show($"S-a inregistrat: {v}\nTotal: {total:F2} {moneda}");
            }
            catch (MagazinValidareException mve)
            {
                MessageBox.Show(mve.Message, "EROARE VALIDARE",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "EROARE",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { tbCantitate.Clear(); }
        }

        private void rbDa_CheckedChanged(object sender, EventArgs e) => RecalculeazaPlata();
        private void rbNu_CheckedChanged(object sender, EventArgs e) => RecalculeazaPlata();

        private void RecalculeazaPlata()
        {
            Produs p = ucSelectorProds.SelectedProdus;
            if (tbCantitate.Text == "" || p == null) return;
            int cantitate;
            try { cantitate = Convert.ToInt32(tbCantitate.Text); } catch { return; }
            double total = cantitate * p.Pret * (1 + cotaTVA / 100);
            if (rbDa.Checked) total -= total * reducereClientFidel / 100;
            tbPlata.Text = total.ToString("F2") + " " + moneda;
        }

        private void dgvVanzari_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= listaVanzariBinding.Count) return;
            tbVanzareCurenta.Text = listaVanzariBinding[e.RowIndex].ToString();
            new FormDetaliiVanzare(listaVanzariBinding, e.RowIndex).ShowDialog(this);
        }

        private void btnDetaliiVanzari_Click(object sender, EventArgs e)
        {
            if (colectieVanzari.Count == 0)
            { MessageBox.Show("Nu exista vanzari pentru afisare!"); return; }
            List<Vanzare> listaTemp = new List<Vanzare>(colectieVanzari);
            new FormDetaliiVanzare(listaTemp).ShowDialog(this);
        }

        private void btnTVA_Click(object sender, EventArgs e)
        {
            if (colectieVanzari.Count == 0) { MessageBox.Show("Nu exista vanzari!"); return; }
            double totalTVA = 0, totalFinal = 0;
            foreach (Vanzare v in colectieVanzari)
            { totalTVA += v.CalculeazaTVA(); totalFinal += v.ValoareFinala(); }
            MessageBox.Show(
                $"Total TVA: {totalTVA:F2} {moneda}\n" +
                $"Total final (cu TVA): {totalFinal:F2} {moneda}\n" +
                $"Total fara TVA: {(totalFinal - totalTVA):F2} {moneda}");
        }

        private void btnGraficBars_Click(object sender, EventArgs e)
        {
            if (colectieVanzari.Count == 0) { MessageBox.Show("Nu exista vanzari!"); return; }
            IncarcaGrafic(System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column,
                          "Vanzari pe produse - grafic bare");
        }

        private void btnGraficPie_Click(object sender, EventArgs e)
        {
            if (colectieVanzari.Count == 0) { MessageBox.Show("Nu exista vanzari!"); return; }
            IncarcaGrafic(System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie,
                          "Distributie vanzari - grafic pie");
        }

        private void IncarcaGrafic(
            System.Windows.Forms.DataVisualization.Charting.SeriesChartType tip,
            string titlu)
        {
            chart1.Series["Vanzari"].Points.Clear();
            chart1.Titles.Clear();
            chart1.Visible = true;
            chart1.Series[0].ChartType = tip;

            Dictionary<string, double> totals = new Dictionary<string, double>();
            foreach (Vanzare v in colectieVanzari)
            {
                if (totals.ContainsKey(v.NumeProdus)) totals[v.NumeProdus] += v.ValoareFinala();
                else totals[v.NumeProdus] = v.ValoareFinala();
            }
            foreach (var kv in totals)
                chart1.Series["Vanzari"].Points.AddXY(kv.Key, kv.Value);
            chart1.Titles.Add(titlu);
        }

        private void btnModificaFont_Click(object sender, EventArgs e)
        {
            if (chart1.Titles.Count == 0)
            { MessageBox.Show("Genereaza intai un grafic!"); return; }
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
                chart1.Titles[0].Font = fd.Font;
        }
    }
}
