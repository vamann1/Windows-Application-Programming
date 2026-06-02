using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;

namespace Proiect_Vaman_Mircea_George
{
    public partial class Form1 : Form
    {
        private Magazin magazinul = new Magazin(0, "—", "—", "—");
        private List<Raion> listaRaioane = new List<Raion>();
        private List<Produs> listaProduse = new List<Produs>();
        private Collection<Vanzare> colectieVanzari = new Collection<Vanzare>();

        private string numeFirma = "RetailManager";
        private string moneda = "RON";
        private double cotaTVA = 19;
        private double reducereClientFidel = 10;

        private string conexiune = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Proiect;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
            ActualizeazaStatistici();
            ActualizeazaHome();
        }

        private void ActualizeazaStatistici()
        {
            lblTotalRaioane.Text = $"Total raioane:  {listaRaioane.Count}";
            lblTotalProduse.Text = $"Total produse:  {listaProduse.Count}";
            lblTotalVanzari.Text = $"Total vanzari:  {colectieVanzari.Count}";
            double valStoc = 0;
            foreach (Produs p in listaProduse)
                valStoc += (double)(decimal)p;
            lblValoareStoc.Text = $"Valoare stoc:   {valStoc:F2} {moneda}";
        }

        private void ActualizeazaHome()
        {
            lblFirmaNume.Text = numeFirma;
            lblMagazinInfo.Text = $"Magazin: {magazinul.Nume}  |  {magazinul.Oras}  |  {magazinul.Adresa}";
        }

        private void Logheaza(string mesaj)
        {
            tbLog.AppendText($"[{DateTime.Now:HH:mm:ss}] {mesaj}{Environment.NewLine}");
        }

        private void vizAcasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizeazaStatistici();
            gbHome.Visible = true;
        }

        private void vizRaioaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormRaioane fr = new FormRaioane(listaRaioane, magazinul, Logheaza))
                fr.ShowDialog(this);
            ActualizeazaStatistici();
        }

        private void vizProduseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormProduse fp = new FormProduse(listaProduse, moneda, Logheaza))
                fp.ShowDialog(this);
            ActualizeazaStatistici();
        }

        private void vizVanzariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormVanzari fv = new FormVanzari(
                colectieVanzari, listaProduse, moneda, cotaTVA, reducereClientFidel, Logheaza))
                fv.ShowDialog(this);
            ActualizeazaStatistici();
        }

        private void incarcaTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
            {
                string linie;
                listaProduse.Clear();
                while ((linie = sr.ReadLine()) != null)
                {
                    try
                    {
                        string[] parts = linie.Split(',');
                        int id = Convert.ToInt32(parts[0]);
                        string nume = parts[1];
                        string categorie = parts[2];
                        double pret = float.Parse(parts[3], CultureInfo.InvariantCulture);
                        int stoc = Convert.ToInt32(parts[4]);
                        listaProduse.Add(new Produs(id, nume, categorie, pret, stoc));
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
            ActualizeazaStatistici();
            Logheaza($"S-au incarcat {listaProduse.Count} produse din TXT.");
            MessageBox.Show($"S-au incarcat {listaProduse.Count} produse!");
        }

        private void salveazaTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                foreach (Produs p in listaProduse)
                    sw.WriteLine($"{p.Id},{p.Nume},{p.Categorie},{p.Pret},{p.Stoc}");
            Logheaza($"S-au salvat {listaProduse.Count} produse in TXT.");
            MessageBox.Show($"Salvat: {saveFileDialog1.FileName}");
        }

        private void incarcaBinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("vanzari.dat", FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                List<Vanzare> listaT = (List<Vanzare>)bf.Deserialize(fs);
                colectieVanzari.Clear();
                foreach (Vanzare v in listaT) colectieVanzari.Add(v);
            }
            ActualizeazaStatistici();
            Logheaza($"S-au incarcat {colectieVanzari.Count} vanzari din BIN.");
            MessageBox.Show($"S-au incarcat {colectieVanzari.Count} vanzari din vanzari.dat");
        }

        private void salveazaBinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("vanzari.dat", FileMode.Create, FileAccess.Write))
            {
                BinaryFormatter bf = new BinaryFormatter();
                List<Vanzare> listaT = new List<Vanzare>(colectieVanzari);
                bf.Serialize(fs, listaT);
            }
            Logheaza($"S-au salvat {colectieVanzari.Count} vanzari in BIN.");
            MessageBox.Show("Salvat: vanzari.dat");
        }

        private void incarcaSetariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IncarcaSetariAutomat();
            MessageBox.Show(
                $"Firma: {numeFirma}\nMoneda: {moneda}\nTVA: {cotaTVA}%\n" +
                $"Reducere client fidel: {reducereClientFidel}%\n" +
                $"Magazin: {magazinul.Nume} ({magazinul.Oras})",
                "Setari XML", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void IncarcaSetariAutomat()
        {
            string caleXml = Path.Combine(Application.StartupPath, "setari.xml");
            if (!File.Exists(caleXml))
            { Logheaza("setari.xml nu a fost gasit."); return; }
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(caleXml);
                foreach (XmlNode xn in doc.SelectNodes("/configurare"))
                {
                    numeFirma = xn["numeFirma"].InnerText;
                    moneda = xn["moneda"].InnerText;
                    cotaTVA = Convert.ToDouble(xn["cotaTVA"].InnerText);
                    reducereClientFidel = Convert.ToDouble(xn["reducereClientFidel"].InnerText);
                    if (xn["magazin"] != null)
                    {
                        int id = Convert.ToInt32(xn["magazin"]["id"].InnerText);
                        string numeM = xn["magazin"]["nume"].InnerText;
                        string oras = xn["magazin"]["oras"].InnerText;
                        string adresa = xn["magazin"]["adresa"].InnerText;
                        magazinul = new Magazin(id, numeM, oras, adresa);
                    }
                }
                this.Text = $"{numeFirma} - Gestiune magazine";
                ActualizeazaHome();
                ActualizeazaStatistici();
                Logheaza($"Setari incarcate: {numeFirma} | {magazinul.Nume} ({magazinul.Oras}) | TVA={cotaTVA}%");
            }
            catch (Exception ex) { Logheaza($"Eroare setari XML: {ex.Message}"); }
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void graphicBarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormVanzari fv = new FormVanzari(
                colectieVanzari, listaProduse, moneda, cotaTVA, reducereClientFidel, Logheaza, TipGrafic.Bars))
                fv.ShowDialog(this);
            ActualizeazaStatistici();
        }

        private void graphicPieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormVanzari fv = new FormVanzari(
                colectieVanzari, listaProduse, moneda, cotaTVA, reducereClientFidel, Logheaza, TipGrafic.Pie))
                fv.ShowDialog(this);
            ActualizeazaStatistici();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colectieVanzari.Count == 0)
            { MessageBox.Show("Nu exista vanzari pentru raportare!"); return; }
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += RandPrintare;
            new PrintPreviewDialog { Document = pd }.ShowDialog();
        }

        private void RandPrintare(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fontTitlu = new Font(FontFamily.GenericSansSerif, 16, FontStyle.Bold);
            Font fontText = new Font(FontFamily.GenericSansSerif, 11, FontStyle.Regular);
            Brush brush = new SolidBrush(Color.Black);
            int x = e.PageBounds.X + 50, y = e.PageBounds.Y + 50;

            g.DrawString($"Raport vanzari - {numeFirma}", fontTitlu, brush, new Point(x, y)); y += 50;
            g.DrawString($"Data: {DateTime.Now:dd-MM-yyyy}", fontText, brush, new Point(x, y)); y += 40;
            g.DrawString("Id | Data | Produs | Cant | Pret | Total", fontText, brush, new Point(x, y)); y += 30;

            double totalGeneral = 0;
            foreach (Vanzare v in colectieVanzari)
            {
                g.DrawString(
                    $"{v.Id} | {v.Data:dd-MM-yyyy} | {v.NumeProdus} | {v.Cantitate} | {v.PretUnitar} | {v.ValoareFinala():F2}",
                    fontText, brush, new Point(x, y));
                y += 25;
                totalGeneral += v.ValoareFinala();
            }
            y += 30;
            g.DrawString($"TOTAL GENERAL: {totalGeneral:F2} {moneda}", fontTitlu, brush, new Point(x, y));
        }

        private void modificareFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modifica fontul graficului din fereastra Vanzari (butonul 'Modifica font grafic').",
                "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void despreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RetailManager - Proiect PAW\nVaman Mircea-George\nGrupa 1061",
                "Despre", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void saveBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colectieVanzari.Count == 0) { MessageBox.Show("Nu exista vanzari de salvat!"); return; }
            using (SqlConnection con = new SqlConnection(conexiune))
            {
                con.Open();
                new SqlCommand("DELETE FROM Vanzari", con).ExecuteNonQuery();
                foreach (Vanzare v in colectieVanzari)
                {
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Vanzari (Id,NumeProdus,Cantitate,PretUnitar,Data) VALUES (@id,@nume,@cant,@pret,@data)", con);
                    cmd.Parameters.AddWithValue("@id", v.Id);
                    cmd.Parameters.AddWithValue("@nume", v.NumeProdus);
                    cmd.Parameters.AddWithValue("@cant", v.Cantitate);
                    cmd.Parameters.AddWithValue("@pret", v.PretUnitar);
                    cmd.Parameters.AddWithValue("@data", v.Data);
                    cmd.ExecuteNonQuery();
                }
            }
            Logheaza($"S-au salvat {colectieVanzari.Count} vanzari in BD.");
            MessageBox.Show($"S-au salvat {colectieVanzari.Count} vanzari in BD!");
        }

        private void loadBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conexiune))
            {
                con.Open();
                SqlDataReader dr = new SqlCommand("SELECT * FROM Vanzari", con).ExecuteReader();
                colectieVanzari.Clear();
                while (dr.Read())
                    colectieVanzari.Add(new Vanzare(
                        Convert.ToInt32(dr["Id"]), dr["NumeProdus"].ToString(),
                        Convert.ToInt32(dr["Cantitate"]), Convert.ToDouble(dr["PretUnitar"]),
                        Convert.ToDateTime(dr["Data"])));
                dr.Close();
            }
            ActualizeazaStatistici();
            Logheaza($"S-au incarcat {colectieVanzari.Count} vanzari din BD.");
            MessageBox.Show($"S-au incarcat {colectieVanzari.Count} vanzari din BD!");
        }

        private void deleteBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n;
            using (SqlConnection con = new SqlConnection(conexiune))
            {
                con.Open();
                n = new SqlCommand(
                    "DELETE FROM Vanzari WHERE Id=(SELECT MAX(Id) FROM Vanzari)", con).ExecuteNonQuery();
            }
            Logheaza($"Sterse {n} inregistrari din BD.");
            MessageBox.Show($"S-au sters {n} vanzari din BD!");
        }

        private void updateBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n;
            using (SqlConnection con = new SqlConnection(conexiune))
            {
                con.Open();
                n = new SqlCommand(
                    "UPDATE Vanzari SET Cantitate=Cantitate+1 WHERE Id=(SELECT MAX(Id) FROM Vanzari)", con).ExecuteNonQuery();
            }
            Logheaza($"Actualizate {n} inregistrari in BD.");
            MessageBox.Show($"S-au actualizat {n} vanzari (cantitate +1 pe ultima)!");
        }
    }
}
