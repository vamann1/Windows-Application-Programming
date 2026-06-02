using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubiectBiciclete
{
    public partial class Form1 : Form
    {
        List<Bicicleta> listBiciclete = new List<Bicicleta>();
        List<Utilizator> listUtilizatori = new List<Utilizator>();
        public Form1()
        {
            InitializeComponent();
        }

        private void incarcaBicicleteDinTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("biciclete.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while (sr.EndOfStream == false)
            {
                string linie = sr.ReadLine();
                string locatie = linie.Split(',')[0];
                int kmParcursi = int.Parse(linie.Split(',')[1]);

                Bicicleta aux = new Bicicleta(locatie, kmParcursi);
                listBiciclete.Add(aux);
            }
            sr.Close();
            fs.Close();


            lvBiciclete.Items.Clear();
            for (int i = 0; i < listBiciclete.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(listBiciclete[i].CodB.ToString());
                lvi.SubItems.Add(listBiciclete[i].DenumireStatieParcare);
                lvi.SubItems.Add(listBiciclete[i].KmParcursi.ToString());
                lvBiciclete.Items.Add(lvi);
            }
            lvBiciclete.Show();
        }

        private void incarcaUtilizatoriDinTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("utilizatori.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while (sr.EndOfStream == false)
            {
                string linie = sr.ReadLine();
                string nume = linie.Split(',')[0];
                int codB = int.Parse(linie.Split(',')[1]);
                int minute = int.Parse(linie.Split(',')[2]);

                Utilizator aux = new Utilizator(nume, codB, minute);
                listUtilizatori.Add(aux);
            }
            sr.Close();
            fs.Close();

            utilizatorBindingSource.DataSource = listUtilizatori;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvBiciclete_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvBiciclete.SelectedIndices.Count == 0) return;

            List<Utilizator> aux = new List<Utilizator>();

            foreach (var item in listUtilizatori)
            {
                if (item.CodB == listBiciclete[lvBiciclete.SelectedIndices[0]].CodB)
                {
                    aux.Add(item);
                }
            }

            //lbUtilizatori.Items.Clear();
            lbUtilizatori.DataSource = aux;

        }

        private void lbUtilizatori_DoubleClick(object sender, EventArgs e)
        {
            utilizatorBindingSource.Position = lbUtilizatori.SelectedIndex;
            FormActualizareUtilizator fau = new FormActualizareUtilizator(utilizatorBindingSource);
            fau.ShowDialog();

            lvBiciclete_SelectedIndexChanged(null, null);
            lvBiciclete.Items.Clear();
            for (int i = 0; i < listBiciclete.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(listBiciclete[i].CodB.ToString());
                lvi.SubItems.Add(listBiciclete[i].DenumireStatieParcare);
                lvi.SubItems.Add(listBiciclete[i].KmParcursi.ToString());
                lvBiciclete.Items.Add(lvi);
            }
            lvBiciclete.Show();

        }

        private void lvBiciclete_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show();
            }
        }

        private void afisareIncasariPeBicicletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int codBic = listBiciclete[lvBiciclete.SelectedIndices[0]].CodB;
            double suma = 0;

            foreach (var item in listUtilizatori)
            {
                if (item.CodB == codBic)
                {
                    if(item.DurataUtilizare>=30)
                        suma += 2 * ((item.DurataUtilizare - 30) / 10);
                }
            }

            textBox1.Text = suma.ToString();
        }

        private void btnTraseazaGrafic_Click(object sender, EventArgs e)
        {
            FormGrafic fg = new FormGrafic(listBiciclete);
            fg.Show();
        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ppd.ShowDialog();
        }

        private void pdoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(Pens.Black, e.MarginBounds);

            Font f = new Font("Times New Roman", 12);
            Font fBold = new Font("Times New Roman", 12, FontStyle.Bold);

            float x = e.MarginBounds.X;
            float y = e.MarginBounds.Y;
            float pasLinie = 25;

            g.DrawString("Situatia inchirierilor", fBold, Brushes.Black, x, y);
            y += pasLinie * 2;
    
            for(int i=0; i<listBiciclete.Count; i++)
            {
                g.DrawString("Bicicleta" + listBiciclete[i].CodB, fBold, Brushes.Black, x, y);
                y += pasLinie;
                foreach(var u in listUtilizatori)
                {
                    if(u.CodB == listBiciclete[i].CodB)
                    {
                        g.DrawString("  - " + u.Nume, f, Brushes.Black, x + 20, y);
                        y += pasLinie;
                    }
                }
                y += pasLinie;
            }
        }

        private void serializareDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            FileStream fs = new FileStream("biciclete.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, listBiciclete);
            fs.Close();
            fs = new FileStream("utilizatori.dat", FileMode.Create, FileAccess.Write);
            bf = new BinaryFormatter();
            bf.Serialize(fs, listUtilizatori);
            fs.Close();

            MessageBox.Show("DATELE AU FOST SERIALIZATE!");
        }
    }
}
