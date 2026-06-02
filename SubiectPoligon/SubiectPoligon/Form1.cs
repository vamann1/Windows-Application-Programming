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

namespace SubiectPoligon
{
    public partial class Form1 : Form
    {

        List<Poligon> listaPoligoane = new List<Poligon>();

        public Form1()
        {
            InitializeComponent();
        }

        private void adaugaPoligonNouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAdaugaPoligon_Click(sender, e);
        }

        private void btnAdaugaPoligon_Click(object sender, EventArgs e)
        {
            FormAdaugare fa = new FormAdaugare();
            if (fa.ShowDialog() == DialogResult.OK)
            {
                listaPoligoane.Add(fa.PoligonNou);

                lv.Items.Clear();
                foreach (var pol in listaPoligoane)
                {
                    ListViewItem lvi = new ListViewItem(pol.Eticheta);
                    lvi.SubItems.Add(pol.Cod_figura.ToString());
                    lv.Items.Add(lvi);
                }
                ActualizeazaPerimetru();
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            ActualizeazaPerimetru();
        }

        private void ActualizeazaPerimetru()
        {
            double perimetruTotal = 0;
            foreach (var pol in listaPoligoane)
                perimetruTotal += pol.CalculPerimetru();
            ptStatus.Text = perimetruTotal.ToString("F2");
        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "DAT Files (*.dat) | *.dat";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                for (int i = 0; i < listaPoligoane.Count; i++) {
                    bf.Serialize(fs, listaPoligoane[i]);
                }
                fs.Close();
            }
        }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
               OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                List<Poligon> aux = new List<Poligon>();
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                while (fs.Position < fs.Length)
                {
                    aux.Add((Poligon)bf.Deserialize(fs));
                }
                fs.Close();

                listaPoligoane = aux;
                lv.Items.Clear();
                for (int i = 0; i < listaPoligoane.Count; i++)
                {
                    ListViewItem lvi = new ListViewItem(listaPoligoane[i].Eticheta);
                    lvi.SubItems.Add(listaPoligoane[i].Cod_figura.ToString());
                    lv.Items.Add(lvi);
                }
                lv.Show();
                ActualizeazaPerimetru();
            }
        }

        private void vizualizareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(listaPoligoane);
            f2.Show();
        }
    }
}
