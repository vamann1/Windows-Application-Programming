using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubAngajat
{
    public partial class Form1 : Form
    {
        List<Angajat> listaAngajati = new List<Angajat>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdaugaAngajat_Click(object sender, EventArgs e)
        {
            try
            {
                string nume = "";
                int nrOre = 0;
                float salOrar = 0F;
                if (tbNume.Text!= "")
                {
                    nume = tbNume.Text;
                } 
                else
                {
                    throw new ArgumentNullException();
                }
                if (tbOreLucrate.Text == "")
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    nrOre = Convert.ToInt32(tbOreLucrate.Text);
                }
                if (tbSalariuOrar.Text == "")
                {
                    throw new ArgumentNullException();
                } else
                {
                    salOrar = float.Parse(tbSalariuOrar.Text, CultureInfo.InvariantCulture.NumberFormat);
                }
                Angajat ang = new Angajat(nume, nrOre, salOrar);
                listaAngajati.Add(ang);
                MessageBox.Show("Angajatul a fost adaugat cu succes!");
                tbNume.Clear();
                tbOreLucrate.Clear();
                tbSalariuOrar.Clear();
            }
            catch(Exception ex) {
               MessageBox.Show(ex.Message);
            }
        }

        private void btnAfiseazaAngajati_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listaAngajati.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(listaAngajati[i].Nume);
                lvi.SubItems.Add(listaAngajati[i].OreLucrate.ToString());
                lvi.SubItems.Add(listaAngajati[i].SalariuOrar.ToString());
                listaAngajati[i].calculeazaSalariuTotal();
                lvi.SubItems.Add(listaAngajati[i].SalariuLunar.ToString());
                lv.Items.Add(lvi);
            }
        }

        private void lv_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            int index = e.Item.Index;

            MessageBox.Show(listaAngajati[index].Nume + listaAngajati[index].OreLucrate + 
                listaAngajati[index].SalariuOrar + listaAngajati[index].SalariuLunar + listaAngajati[index].Matricol 
                );
        }

        private void salveazaFisierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "firma.txt";
            sfd.Filter = "(*.txt) | *.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(sfd.FileName);
                    sw.WriteLine(textBox1.Text);  
                    float totalSalarii = 0;
                    for (int i = 0; i < listaAngajati.Count; i++)
                    {
                        listaAngajati[i].calculeazaSalariuTotal();
                        sw.WriteLine(listaAngajati[i].Nume + " | " +
                                     listaAngajati[i].OreLucrate + " | " +
                                     listaAngajati[i].SalariuOrar + " | " +
                                     listaAngajati[i].SalariuLunar);
                        totalSalarii += listaAngajati[i].SalariuLunar;
                    }
                    sw.WriteLine("Valoare totala salarii: " + totalSalarii);
                    sw.Close();
                    MessageBox.Show("Fisier salvat!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void citesteFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.txt) | *.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string continut = File.ReadAllText(ofd.FileName);
                MessageBox.Show(continut);  // sau tbRezultat.Text = continut;
            }
        }
    }
}
