using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Proiect_Vaman_Mircea_George
{
    public partial class FormProduse : Form
    {
        private List<Produs> listaProduse;
        private List<TextBox> listaTB = new List<TextBox>();
        private string moneda;
        private Action<string> logAction;

        public FormProduse(List<Produs> listaProduse, string moneda, Action<string> logAction)
        {
            InitializeComponent();
            this.listaProduse = listaProduse;
            this.moneda = moneda;
            this.logAction = logAction;

            lvProduse.ContextMenuStrip = cmsProduse;

            // adaug textbox-urile fixe din designer in lista
            listaTB.Add(tbDenumire);
            listaTB.Add(tbCategorie);
            listaTB.Add(tbPret);
            listaTB.Add(tbStoc);
            listaTB.Add(tbValoare);

            tbPret.KeyPress += tbCifre_KeyPress;
            tbStoc.KeyPress += tbCifre_KeyPress;

            WireValoareRecalc(tbPret, tbStoc, tbValoare);

            RefreshLvProduse();
        }

        private void RefreshLvProduse()
        {
            lvProduse.Items.Clear();
            double valTot = 0;
            foreach (Produs p in listaProduse)
            {
                ListViewItem lvi = new ListViewItem(p.Nume);
                lvi.SubItems.Add(p.Categorie);
                lvi.SubItems.Add(p.Pret.ToString());
                lvi.SubItems.Add(p.Stoc.ToString());
                decimal val = (decimal)p;
                lvi.SubItems.Add(val.ToString());
                valTot += (double)val;
                lvProduse.Items.Add(lvi);
            }
            tbValoareTotala.Text = valTot.ToString("F2") + " " + moneda;
        }

        // calculeaza automat valoarea (pret * stoc) in timp real
        private void WireValoareRecalc(TextBox tbP, TextBox tbS, TextBox tbV)
        {
            EventHandler recalc = (s, ev) =>
            {
                if (double.TryParse(tbP.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out double pret)
                    && int.TryParse(tbS.Text, out int stoc))
                    tbV.Text = (pret * stoc).ToString("F2");
                else
                    tbV.Text = "";
            };
            tbP.TextChanged += recalc;
            tbS.TextChanged += recalc;
        }

        private void tbCifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // permit doar cifre, backspace si punct zecimal
            e.Handled = !(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8 || e.KeyChar == '.');
        }

        private void btnAdaugaLinie_Click(object sender, EventArgs e)
        {
            int X = listaTB[0].Location.X;
            int Y = listaTB[listaTB.Count - 1].Location.Y;
            int distanta = listaTB[1].Location.X - listaTB[0].Location.X;

            TextBox tbPretNou = null, tbStocNou = null, tbValNou = null;

            for (int i = 0; i < 5; i++)
            {
                TextBox tb = new TextBox();
                tb.Location = new Point(X, Y + 40);
                X += distanta;
                tb.Width = tbDenumire.Width;

                if (i == 2) { tb.KeyPress += tbCifre_KeyPress; tbPretNou = tb; }
                if (i == 3) { tb.KeyPress += tbCifre_KeyPress; tbStocNou = tb; }
                if (i == 4) { tb.ReadOnly = true; tbValNou = tb; }

                listaTB.Add(tb);
                this.Controls.Add(tb);
            }
            WireValoareRecalc(tbPretNou, tbStocNou, tbValNou);
        }

        private void btnCalculeazaTotal_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            int baseId = listaProduse.Count;

            for (int i = 0; i < listaTB.Count; i += 5)
            {
                // daca randul e complet gol il sarim
                bool totGol = listaTB[i].Text == "" && listaTB[i+1].Text == ""
                           && listaTB[i+2].Text == "" && listaTB[i+3].Text == "";
                if (totGol) continue;

                if (listaTB[i].Text == "")
                { errorProvider1.SetError(listaTB[i], "Introduceti denumirea!"); continue; }
                if (listaTB[i+1].Text == "")
                { errorProvider1.SetError(listaTB[i+1], "Introduceti categoria!"); continue; }
                if (listaTB[i+2].Text == "")
                { errorProvider1.SetError(listaTB[i+2], "Introduceti pretul!"); continue; }
                if (listaTB[i+3].Text == "")
                { errorProvider1.SetError(listaTB[i+3], "Introduceti stocul!"); continue; }

                string denumire = listaTB[i].Text;
                string categorie = listaTB[i+1].Text;
                double pret = Convert.ToDouble(listaTB[i+2].Text);
                int stoc = Convert.ToInt32(listaTB[i+3].Text);

                Produs p = new Produs(baseId + i/5 + 1, denumire, categorie, pret, stoc);
                listaTB[i+4].Text = (pret * stoc).ToString("F2");
                listaProduse.Add(p);
            }

            // curatam campurile ca sa nu se re-adauge la urmatorul click
            foreach (TextBox tb in listaTB) tb.Text = "";

            RefreshLvProduse();
        }

        private void btnStocPlus_Click(object sender, EventArgs e)
        {
            int modificate = 0;
            for (int i = 0; i < lvProduse.Items.Count; i++)
            {
                if (!lvProduse.Items[i].Checked || i >= listaProduse.Count) continue;
                listaProduse[i]++;
                modificate++;
            }
            if (modificate == 0)
            {
                MessageBox.Show("Bifati cel putin un produs din lista!");
                return;
            }
            RefreshLvProduse();
        }

        private void btnStocMinus_Click(object sender, EventArgs e)
        {
            int modificate = 0;
            List<string> stocZero = new List<string>();

            for (int i = 0; i < lvProduse.Items.Count; i++)
            {
                if (!lvProduse.Items[i].Checked || i >= listaProduse.Count) continue;
                Produs p = listaProduse[i];
                p--;
                if (!p) stocZero.Add(p.Nume);
                modificate++;
            }

            if (modificate == 0)
            {
                MessageBox.Show("Bifati cel putin un produs din lista!");
                return;
            }

            RefreshLvProduse();

            if (stocZero.Count > 0)
                MessageBox.Show("ATENTIE: stoc 0 pentru:\n" + string.Join("\n", stocZero));
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            string data = dateTimePicker1.Value.ToString("dd-MMMM-yyyy");
            string numeFisier = "Comanda_" + data + ".txt";

            using (StreamWriter sw = new StreamWriter(numeFisier))
            {
                sw.WriteLine($"COMANDA DIN DATA: {data}");
                sw.WriteLine("Denumire | Categorie | Pret | Stoc | Valoare");
                sw.WriteLine("------------------------------------------------");

                double total = 0;
                foreach (Produs p in listaProduse)
                {
                    decimal val = (decimal)p;
                    total += (double)val;
                    sw.WriteLine($"{p.Nume} | {p.Categorie} | {p.Pret} | {p.Stoc} | {val}");
                }

                sw.WriteLine("------------------------------------------------");
                sw.WriteLine($"Valoare totala: {total:F2} {moneda}");
            }

            logAction?.Invoke($"Comanda salvata: {numeFisier}");
            MessageBox.Show($"S-a salvat {numeFisier}");
        }

        private void lvProduse_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            e.Item.BackColor = e.Item.Checked ? Color.Red : Color.White;
        }

        private void stergeProduseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Produs> deSters = new List<Produs>();

            foreach (ListViewItem item in lvProduse.Items)
            {
                if (!item.Checked) continue;
                string numeItem = item.Text;
                foreach (Produs p in listaProduse)
                    if (p.Nume == numeItem) deSters.Add(p);
            }

            foreach (Produs p in deSters)
                listaProduse.Remove(p);

            for (int i = lvProduse.Items.Count - 1; i >= 0; i--)
                if (lvProduse.Items[i].Checked)
                    lvProduse.Items[i].Remove();
        }
    }
}
